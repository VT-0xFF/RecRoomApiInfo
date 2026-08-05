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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CJMNDDHIKCG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74B4F60", Offset = "0x74B3560", VA = "0x1874B4F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x74B4F60", Offset = "0x74B3560", VA = "0x1874B4F60")]
		public static void IAHGMEAFBIP(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74BB2C0", Offset = "0x74B98C0", VA = "0x1874BB2C0")]
		private void EANHJEFJFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74BB230", Offset = "0x74B9830", VA = "0x1874BB230")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B77D0", Offset = "0x74B5DD0", VA = "0x1874B77D0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x74B7B10", Offset = "0x74B6110", VA = "0x1874B7B10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B7C90", Offset = "0x74B6290", VA = "0x1874B7C90", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74B7B20", Offset = "0x74B6120", VA = "0x1874B7B20", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74B76A0", Offset = "0x74B5CA0", VA = "0x1874B76A0")]
		private JobHandle KBEIAPOKOMA(GLCHGDJFPEI<PersistentUserTagData_v1> component_1, LPNHABMNDJA<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B57B0", Offset = "0x74B3DB0", VA = "0x1874B57B0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x74B5A90", Offset = "0x74B4090", VA = "0x1874B5A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B5C10", Offset = "0x74B4210", VA = "0x1874B5C10", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74B5AA0", Offset = "0x74B40A0", VA = "0x1874B5AA0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74B5680", Offset = "0x74B3C80", VA = "0x1874B5680")]
		private JobHandle EOLDGADCAIM(GLCHGDJFPEI<LocalDeformableScaleData_v1> component_3, LPNHABMNDJA<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BA6E0", Offset = "0x74B8CE0", VA = "0x1874BA6E0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x74BA9A0", Offset = "0x74B8FA0", VA = "0x1874BA9A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BAB20", Offset = "0x74B9120", VA = "0x1874BAB20", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74BA9B0", Offset = "0x74B8FB0", VA = "0x1874BA9B0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74BA5B0", Offset = "0x74B8BB0", VA = "0x1874BA5B0")]
		private JobHandle JIDAMPFCLID(GLCHGDJFPEI<SerializedDataLayerVersionData_v1> component_11, LPNHABMNDJA<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BA0D0", Offset = "0x74B86D0", VA = "0x1874BA0D0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x74BA390", Offset = "0x74B8990", VA = "0x1874BA390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BA510", Offset = "0x74B8B10", VA = "0x1874BA510", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74BA3A0", Offset = "0x74B89A0", VA = "0x1874BA3A0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74B9FA0", Offset = "0x74B85A0", VA = "0x1874B9FA0")]
		private JobHandle IMCHNGHHDHI(GLCHGDJFPEI<ReplicatorPreallocatedObjectCountData_v1> component_19, LPNHABMNDJA<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BACF0", Offset = "0x74B92F0", VA = "0x1874BACF0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74BB010", Offset = "0x74B9610", VA = "0x1874BB010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74BB190", Offset = "0x74B9790", VA = "0x1874BB190", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74BB020", Offset = "0x74B9620", VA = "0x1874BB020", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74BABC0", Offset = "0x74B91C0", VA = "0x1874BABC0")]
		private JobHandle HGJPDKJBINN(GLCHGDJFPEI<ToolCleanupStatusData_v1> component_24, LPNHABMNDJA<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9950", Offset = "0x74B7F50", VA = "0x1874B9950")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x74B9C50", Offset = "0x74B8250", VA = "0x1874B9C50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9F00", Offset = "0x74B8500", VA = "0x1874B9F00", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74B9D90", Offset = "0x74B8390", VA = "0x1874B9D90", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74B9C60", Offset = "0x74B8260", VA = "0x1874B9C60")]
		private JobHandle MPNGOIFDBKM(GLCHGDJFPEI<ReplicatorData_v1> component_31, LPNHABMNDJA<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B51B0", Offset = "0x74B37B0", VA = "0x1874B51B0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74B5460", Offset = "0x74B3A60", VA = "0x1874B5460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B55E0", Offset = "0x74B3BE0", VA = "0x1874B55E0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74B5470", Offset = "0x74B3A70", VA = "0x1874B5470", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74B5080", Offset = "0x74B3680", VA = "0x1874B5080")]
		private JobHandle IKCGADLADMO(GLCHGDJFPEI<InventionInstanceIdData_v1> component_34, LPNHABMNDJA<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B5CB0", Offset = "0x74B42B0", VA = "0x1874B5CB0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74B5FA0", Offset = "0x74B45A0", VA = "0x1874B5FA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B6250", Offset = "0x74B4850", VA = "0x1874B6250", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74B60E0", Offset = "0x74B46E0", VA = "0x1874B60E0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74B5FB0", Offset = "0x74B45B0", VA = "0x1874B5FB0")]
		private JobHandle MPGBJNPAGAO(GLCHGDJFPEI<OMShapeContainerData_v1> component_37, LPNHABMNDJA<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B7D30", Offset = "0x74B6330", VA = "0x1874B7D30")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x74B8020", Offset = "0x74B6620", VA = "0x1874B8020", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B82D0", Offset = "0x74B68D0", VA = "0x1874B82D0", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74B8160", Offset = "0x74B6760", VA = "0x1874B8160", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74B8030", Offset = "0x74B6630", VA = "0x1874B8030")]
		private JobHandle MIJPLIHHBDN(GLCHGDJFPEI<ContainerCollisionLayerData_v1> component_52, LPNHABMNDJA<PhysicsModelCollisionLayerData> component_53, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9310", Offset = "0x74B7910", VA = "0x1874B9310")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x74B9600", Offset = "0x74B7C00", VA = "0x1874B9600", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9780", Offset = "0x74B7D80", VA = "0x1874B9780", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74B9610", Offset = "0x74B7C10", VA = "0x1874B9610", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74B97D0", Offset = "0x74B7DD0", VA = "0x1874B97D0")]
		private JobHandle PCENCIGIJHM(GLCHGDJFPEI<ContainerGrabbableModeData_v1> component_56, LPNHABMNDJA<PhysicsModelGrabbableModeData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B8B60", Offset = "0x74B7160", VA = "0x1874B8B60")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x74B9040", Offset = "0x74B7640", VA = "0x1874B9040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9270", Offset = "0x74B7870", VA = "0x1874B9270", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74B9050", Offset = "0x74B7650", VA = "0x1874B9050", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74B89B0", Offset = "0x74B6FB0", VA = "0x1874B89B0")]
		private JobHandle DPABKNONBPC(GLCHGDJFPEI<ContainerFlagsData_v1> component_63, GLCHGDJFPEI<ContainerFlagsData_v2> component_64, LPNHABMNDJA<PhysicsModelFlagsData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B84A0", Offset = "0x74B6AA0", VA = "0x1874B84A0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x74B8790", Offset = "0x74B6D90", VA = "0x1874B8790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B8910", Offset = "0x74B6F10", VA = "0x1874B8910", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74B87A0", Offset = "0x74B6DA0", VA = "0x1874B87A0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x74B8370", Offset = "0x74B6970", VA = "0x1874B8370")]
		private JobHandle GOPBAPGKAKC(GLCHGDJFPEI<ContainerCollisionModeData_v1> component_66, LPNHABMNDJA<PhysicsModelCollisionModeData> component_67, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B64F0", Offset = "0x74B4AF0", VA = "0x1874B64F0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x74B72E0", Offset = "0x74B58E0", VA = "0x1874B72E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B7600", Offset = "0x74B5C00", VA = "0x1874B7600", Slot = "14")]
			get
			{
				return default(IBCMILIKEJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74B72F0", Offset = "0x74B58F0", VA = "0x1874B72F0", Slot = "15")]
		protected override void NGOKEBNGGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74B62F0", Offset = "0x74B48F0", VA = "0x1874B62F0")]
		private JobHandle KDKEODOBLEC(GLCHGDJFPEI<ObjectPolicyData_v1> component_70, GLCHGDJFPEI<ObjectPolicyData_v2> component_71, GLCHGDJFPEI<ObjectPolicyData_v3> component_72, GLCHGDJFPEI<ObjectPolicyData_v4> component_73, GLCHGDJFPEI<ObjectPolicyData_v5> component_74, LPNHABMNDJA<ObjectPolicyData> component_75, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class DBGDPNECJLP
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x32434E0", Offset = "0x3241AE0", VA = "0x1832434E0")]
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
