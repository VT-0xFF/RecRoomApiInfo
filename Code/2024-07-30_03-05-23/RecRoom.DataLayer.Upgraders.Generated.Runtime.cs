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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OOEKLBNIKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69C9010", Offset = "0x69C7610", VA = "0x1869C9010")]
	public static void HPCKIKBCCPN(ComponentSystemGroup AMNPFAMIOOO, EntityCommandBufferSystem PHHFKCLJAJF)
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
		[Cpp2IlInjected.Address(RVA = "0x69C9010", Offset = "0x69C7610", VA = "0x1869C9010")]
		public static void JCFLJBNMAML(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9B0", Offset = "0x69C9FB0", VA = "0x1869CB9B0")]
		private void HPCKIKBCCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69CBED0", Offset = "0x69CA4D0", VA = "0x1869CBED0")]
		private void NFFEEKGFGJN(AOOHEKCGMFO system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OEHKLOAFKBA<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public BIJFMHEHLLI<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x69CA210", Offset = "0x69C8810", VA = "0x1869CA210")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69CA550", Offset = "0x69C8B50", VA = "0x1869CA550", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x69CA050", Offset = "0x69C8650", VA = "0x1869CA050", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C86A0", VA = "0x1869CA0A0", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69CA560", Offset = "0x69C8B60", VA = "0x1869CA560")]
		private JobHandle MEJEBADOBHM(OEHKLOAFKBA<PersistentUserTagData_v1> component_1, BIJFMHEHLLI<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OEHKLOAFKBA<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public BIJFMHEHLLI<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x69C8560", Offset = "0x69C6B60", VA = "0x1869C8560")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69C8840", Offset = "0x69C6E40", VA = "0x1869C8840", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69C83A0", Offset = "0x69C69A0", VA = "0x1869C83A0", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69C83F0", Offset = "0x69C69F0", VA = "0x1869C83F0", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69C8850", Offset = "0x69C6E50", VA = "0x1869C8850")]
		private JobHandle OJFGMBJLBIB(OEHKLOAFKBA<LocalDeformableScaleData_v1> component_3, BIJFMHEHLLI<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public OEHKLOAFKBA<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public BIJFMHEHLLI<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69CB020", Offset = "0x69C9620", VA = "0x1869CB020")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x69CB2E0", Offset = "0x69C98E0", VA = "0x1869CB2E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69CAD30", Offset = "0x69C9330", VA = "0x1869CAD30", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69CAEB0", Offset = "0x69C94B0", VA = "0x1869CAEB0", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD80", Offset = "0x69C9380", VA = "0x1869CAD80")]
		private JobHandle FDIAIKOCGKN(OEHKLOAFKBA<ReplicatorPreallocatedObjectCountData_v1> component_19, BIJFMHEHLLI<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public OEHKLOAFKBA<ToolCleanupStatusData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public BIJFMHEHLLI<ToolCleanupStatusData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69CB500", Offset = "0x69C9B00", VA = "0x1869CB500")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69CB820", Offset = "0x69C9E20", VA = "0x1869CB820", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69CB340", Offset = "0x69C9940", VA = "0x1869CB340", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69CB390", Offset = "0x69C9990", VA = "0x1869CB390", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69CB830", Offset = "0x69C9E30", VA = "0x1869CB830")]
		private JobHandle MOJBAOFMDLD(OEHKLOAFKBA<ToolCleanupStatusData_v1> component_23, BIJFMHEHLLI<ToolCleanupStatusData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OEHKLOAFKBA<ReplicatorData_v1> component_29;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public BIJFMHEHLLI<ReplicatorData> component_30;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69CA9D0", Offset = "0x69C8FD0", VA = "0x1869CA9D0")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69CACD0", Offset = "0x69C92D0", VA = "0x1869CACD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69CA810", Offset = "0x69C8E10", VA = "0x1869CA810", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69CA860", Offset = "0x69C8E60", VA = "0x1869CA860", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69CA6E0", Offset = "0x69C8CE0", VA = "0x1869CA6E0")]
		private JobHandle AKHOANMHCCD(OEHKLOAFKBA<ReplicatorData_v1> component_29, BIJFMHEHLLI<ReplicatorData> component_30, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OEHKLOAFKBA<OMShapeContainerData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public BIJFMHEHLLI<OMShapeContainerData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69C8B90", Offset = "0x69C7190", VA = "0x1869C8B90")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69C8E80", Offset = "0x69C7480", VA = "0x1869C8E80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69C89D0", Offset = "0x69C6FD0", VA = "0x1869C89D0", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69C8A20", Offset = "0x69C7020", VA = "0x1869C8A20", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69C8E90", Offset = "0x69C7490", VA = "0x1869C8E90")]
		private JobHandle MLCLEBAILBJ(OEHKLOAFKBA<OMShapeContainerData_v1> component_34, BIJFMHEHLLI<OMShapeContainerData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OEHKLOAFKBA<ContainerFlagsData_v1> component_56;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BIJFMHEHLLI<ContainerFlagsData> component_57;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x69C7F40", Offset = "0x69C6540", VA = "0x1869C7F40")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x69C8210", Offset = "0x69C6810", VA = "0x1869C8210", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x69C7D80", Offset = "0x69C6380", VA = "0x1869C7D80", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69C7DD0", Offset = "0x69C63D0", VA = "0x1869C7DD0", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69C8220", Offset = "0x69C6820", VA = "0x1869C8220")]
		private JobHandle OHPOOPMJFLE(OEHKLOAFKBA<ContainerFlagsData_v1> component_56, BIJFMHEHLLI<ContainerFlagsData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : AOOHEKCGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OEHKLOAFKBA<ObjectPolicyData_v1> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OEHKLOAFKBA<ObjectPolicyData_v2> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OEHKLOAFKBA<ObjectPolicyData_v3> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OEHKLOAFKBA<ObjectPolicyData_v4> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public BIJFMHEHLLI<ObjectPolicyData> component_65;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x69C9380", Offset = "0x69C7980", VA = "0x1869C9380")]
			private void BOJFAEIDMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x69C9E00", Offset = "0x69C8400", VA = "0x1869C9E00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override PBGLEKOCCEM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69C9060", Offset = "0x69C7660", VA = "0x1869C9060", Slot = "14")]
			get
			{
				return default(PBGLEKOCCEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69C90B0", Offset = "0x69C76B0", VA = "0x1869C90B0", Slot = "15")]
		protected override void KFNDAOGFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69C9E10", Offset = "0x69C8410", VA = "0x1869C9E10")]
		private JobHandle NPEKLKMENIF(OEHKLOAFKBA<ObjectPolicyData_v1> component_61, OEHKLOAFKBA<ObjectPolicyData_v2> component_62, OEHKLOAFKBA<ObjectPolicyData_v3> component_63, OEHKLOAFKBA<ObjectPolicyData_v4> component_64, BIJFMHEHLLI<ObjectPolicyData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x21EFCF0", Offset = "0x21EE2F0", VA = "0x1821EFCF0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class FGEIOGCJPLE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D470", Offset = "0x2B7BA70", VA = "0x182B7D470")]
	public static void HBGEFBIMBLD<T>(T OIOFNFIMBBM, [Out] T DOBMFCDBEKL) where T : struct
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
