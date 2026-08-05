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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CJMNDDHIKCG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7416C10", Offset = "0x7416010", VA = "0x187416C10")]
	public static void EANHJEFJFKA(ComponentSystemGroup CMHPCDCAOKM, EntityCommandBufferSystem FOELCIFKJBD)
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
		[Cpp2IlInjected.Address(RVA = "0x7416C10", Offset = "0x7416010", VA = "0x187416C10")]
		public static void IAHGMEAFBIP(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x741CF70", Offset = "0x741C370", VA = "0x18741CF70")]
		private void EANHJEFJFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x741CEE0", Offset = "0x741C2E0", VA = "0x18741CEE0")]
		private void DHEKHBHLKKG(EKDNFEHNCKM system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GLCHGDJFPEI<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LPNHABMNDJA<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7419480", Offset = "0x7418880", VA = "0x187419480")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x74197C0", Offset = "0x7418BC0", VA = "0x1874197C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7419940", Offset = "0x7418D40", VA = "0x187419940", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74197D0", Offset = "0x7418BD0", VA = "0x1874197D0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7419350", Offset = "0x7418750", VA = "0x187419350")]
		private JobHandle KBEIAPOKOMA(GLCHGDJFPEI<PersistentUserTagData_v1> component_1, LPNHABMNDJA<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public GLCHGDJFPEI<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LPNHABMNDJA<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7417460", Offset = "0x7416860", VA = "0x187417460")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7417740", Offset = "0x7416B40", VA = "0x187417740", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x74178C0", Offset = "0x7416CC0", VA = "0x1874178C0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7417750", Offset = "0x7416B50", VA = "0x187417750", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7417330", Offset = "0x7416730", VA = "0x187417330")]
		private JobHandle EOLDGADCAIM(GLCHGDJFPEI<LocalDeformableScaleData_v1> component_3, LPNHABMNDJA<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public GLCHGDJFPEI<SerializedDataLayerVersionData_v1> component_11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public LPNHABMNDJA<SerializedDataLayerVersionData> component_12;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x741C390", Offset = "0x741B790", VA = "0x18741C390")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x741C650", Offset = "0x741BA50", VA = "0x18741C650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x741C7D0", Offset = "0x741BBD0", VA = "0x18741C7D0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x741C660", Offset = "0x741BA60", VA = "0x18741C660", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x741C260", Offset = "0x741B660", VA = "0x18741C260")]
		private JobHandle JIDAMPFCLID(GLCHGDJFPEI<SerializedDataLayerVersionData_v1> component_11, LPNHABMNDJA<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public GLCHGDJFPEI<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LPNHABMNDJA<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x741BD80", Offset = "0x741B180", VA = "0x18741BD80")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x741C040", Offset = "0x741B440", VA = "0x18741C040", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x741C1C0", Offset = "0x741B5C0", VA = "0x18741C1C0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x741C050", Offset = "0x741B450", VA = "0x18741C050", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x741BC50", Offset = "0x741B050", VA = "0x18741BC50")]
		private JobHandle IMCHNGHHDHI(GLCHGDJFPEI<ReplicatorPreallocatedObjectCountData_v1> component_19, LPNHABMNDJA<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public GLCHGDJFPEI<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LPNHABMNDJA<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x741C9A0", Offset = "0x741BDA0", VA = "0x18741C9A0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x741CCC0", Offset = "0x741C0C0", VA = "0x18741CCC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x741CE40", Offset = "0x741C240", VA = "0x18741CE40", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x741CCD0", Offset = "0x741C0D0", VA = "0x18741CCD0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x741C870", Offset = "0x741BC70", VA = "0x18741C870")]
		private JobHandle HGJPDKJBINN(GLCHGDJFPEI<ToolCleanupStatusData_v1> component_24, LPNHABMNDJA<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GLCHGDJFPEI<ReplicatorData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LPNHABMNDJA<ReplicatorData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x741B600", Offset = "0x741AA00", VA = "0x18741B600")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x741B900", Offset = "0x741AD00", VA = "0x18741B900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x741BBB0", Offset = "0x741AFB0", VA = "0x18741BBB0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x741BA40", Offset = "0x741AE40", VA = "0x18741BA40", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x741B910", Offset = "0x741AD10", VA = "0x18741B910")]
		private JobHandle MPNGOIFDBKM(GLCHGDJFPEI<ReplicatorData_v1> component_31, LPNHABMNDJA<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public GLCHGDJFPEI<InventionInstanceIdData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public LPNHABMNDJA<InventionInstanceIdData> component_35;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7416E60", Offset = "0x7416260", VA = "0x187416E60")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7417110", Offset = "0x7416510", VA = "0x187417110", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7417290", Offset = "0x7416690", VA = "0x187417290", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7417120", Offset = "0x7416520", VA = "0x187417120", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7416D30", Offset = "0x7416130", VA = "0x187416D30")]
		private JobHandle IKCGADLADMO(GLCHGDJFPEI<InventionInstanceIdData_v1> component_34, LPNHABMNDJA<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GLCHGDJFPEI<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LPNHABMNDJA<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7417960", Offset = "0x7416D60", VA = "0x187417960")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7417C50", Offset = "0x7417050", VA = "0x187417C50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7417F00", Offset = "0x7417300", VA = "0x187417F00", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7417D90", Offset = "0x7417190", VA = "0x187417D90", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7417C60", Offset = "0x7417060", VA = "0x187417C60")]
		private JobHandle MPGBJNPAGAO(GLCHGDJFPEI<OMShapeContainerData_v1> component_37, LPNHABMNDJA<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public GLCHGDJFPEI<ContainerCollisionLayerData_v1> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LPNHABMNDJA<PhysicsModelCollisionLayerData> component_53;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x74199E0", Offset = "0x7418DE0", VA = "0x1874199E0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7419CD0", Offset = "0x74190D0", VA = "0x187419CD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7419F80", Offset = "0x7419380", VA = "0x187419F80", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7419E10", Offset = "0x7419210", VA = "0x187419E10", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7419CE0", Offset = "0x74190E0", VA = "0x187419CE0")]
		private JobHandle MIJPLIHHBDN(GLCHGDJFPEI<ContainerCollisionLayerData_v1> component_52, LPNHABMNDJA<PhysicsModelCollisionLayerData> component_53, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public GLCHGDJFPEI<ContainerGrabbableModeData_v1> component_56;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LPNHABMNDJA<PhysicsModelGrabbableModeData> component_57;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x741AFC0", Offset = "0x741A3C0", VA = "0x18741AFC0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x741B2B0", Offset = "0x741A6B0", VA = "0x18741B2B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x741B430", Offset = "0x741A830", VA = "0x18741B430", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x741B2C0", Offset = "0x741A6C0", VA = "0x18741B2C0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x741B480", Offset = "0x741A880", VA = "0x18741B480")]
		private JobHandle PCENCIGIJHM(GLCHGDJFPEI<ContainerGrabbableModeData_v1> component_56, LPNHABMNDJA<PhysicsModelGrabbableModeData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GLCHGDJFPEI<ContainerFlagsData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public GLCHGDJFPEI<ContainerFlagsData_v2> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LPNHABMNDJA<PhysicsModelFlagsData> component_65;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x741A810", Offset = "0x7419C10", VA = "0x18741A810")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x741ACF0", Offset = "0x741A0F0", VA = "0x18741ACF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x741AF20", Offset = "0x741A320", VA = "0x18741AF20", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x741AD00", Offset = "0x741A100", VA = "0x18741AD00", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x741A660", Offset = "0x7419A60", VA = "0x18741A660")]
		private JobHandle DPABKNONBPC(GLCHGDJFPEI<ContainerFlagsData_v1> component_63, GLCHGDJFPEI<ContainerFlagsData_v2> component_64, LPNHABMNDJA<PhysicsModelFlagsData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GLCHGDJFPEI<ContainerCollisionModeData_v1> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LPNHABMNDJA<PhysicsModelCollisionModeData> component_67;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x741A150", Offset = "0x7419550", VA = "0x18741A150")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x741A440", Offset = "0x7419840", VA = "0x18741A440", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x741A5C0", Offset = "0x74199C0", VA = "0x18741A5C0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x741A450", Offset = "0x7419850", VA = "0x18741A450", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x741A020", Offset = "0x7419420", VA = "0x18741A020")]
		private JobHandle GOPBAPGKAKC(GLCHGDJFPEI<ContainerCollisionModeData_v1> component_66, LPNHABMNDJA<PhysicsModelCollisionModeData> component_67, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : EKDNFEHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public GLCHGDJFPEI<ObjectPolicyData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public GLCHGDJFPEI<ObjectPolicyData_v2> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLCHGDJFPEI<ObjectPolicyData_v3> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GLCHGDJFPEI<ObjectPolicyData_v4> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public GLCHGDJFPEI<ObjectPolicyData_v5> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LPNHABMNDJA<ObjectPolicyData> component_75;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x74181A0", Offset = "0x74175A0", VA = "0x1874181A0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7418F90", Offset = "0x7418390", VA = "0x187418F90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override IBCMILIKEJG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x74192B0", Offset = "0x74186B0", VA = "0x1874192B0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7418FA0", Offset = "0x74183A0", VA = "0x187418FA0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7417FA0", Offset = "0x74173A0", VA = "0x187417FA0")]
		private JobHandle KDKEODOBLEC(GLCHGDJFPEI<ObjectPolicyData_v1> component_70, GLCHGDJFPEI<ObjectPolicyData_v2> component_71, GLCHGDJFPEI<ObjectPolicyData_v3> component_72, GLCHGDJFPEI<ObjectPolicyData_v4> component_73, GLCHGDJFPEI<ObjectPolicyData_v5> component_74, LPNHABMNDJA<ObjectPolicyData> component_75, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class DBGDPNECJLP
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x31FA440", Offset = "0x31F9840", VA = "0x1831FA440")]
	public static void JAHFJBJOLEO<T, U>(T OJLBMLCGKGE, [Out] U HBBIFNILMAN) where T : struct where U : struct
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
