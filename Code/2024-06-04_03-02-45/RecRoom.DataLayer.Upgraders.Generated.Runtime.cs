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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KMONCOPEMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6819F00", Offset = "0x6818700", VA = "0x186819F00")]
	public static void GOHKNMANMGG(ComponentSystemGroup COODGNDJFPK, EntityCommandBufferSystem DCIPJFFEGJB)
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
		[Cpp2IlInjected.Address(RVA = "0x6819F00", Offset = "0x6818700", VA = "0x186819F00")]
		public static void BFNOLNFOLAF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x681C8E0", Offset = "0x681B0E0", VA = "0x18681C8E0")]
		private void GOHKNMANMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x681C850", Offset = "0x681B050", VA = "0x18681C850")]
		private void CFBGDKENHDO(PIKMBFPJDKL system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OHIMBDGOHLK<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public ILBBPINKANN<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x681BEB0", Offset = "0x681A6B0", VA = "0x18681BEB0")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x681BEA0", Offset = "0x681A6A0", VA = "0x18681BEA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x681BE50", Offset = "0x681A650", VA = "0x18681BE50", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x681BCE0", Offset = "0x681A4E0", VA = "0x18681BCE0", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x681BBB0", Offset = "0x681A3B0", VA = "0x18681BBB0")]
		private JobHandle BPEJHAFGCHH(OHIMBDGOHLK<PersistentUserTagData_v1> component_1, ILBBPINKANN<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OHIMBDGOHLK<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public ILBBPINKANN<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x681A250", Offset = "0x6818A50", VA = "0x18681A250")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x681A240", Offset = "0x6818A40", VA = "0x18681A240", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x681A1F0", Offset = "0x68189F0", VA = "0x18681A1F0", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x681A080", Offset = "0x6818880", VA = "0x18681A080", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6819F50", Offset = "0x6818750", VA = "0x186819F50")]
		private JobHandle BPGECCPOOAA(OHIMBDGOHLK<LocalDeformableScaleData_v1> component_3, ILBBPINKANN<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public OHIMBDGOHLK<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public ILBBPINKANN<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x681C540", Offset = "0x681AD40", VA = "0x18681C540")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x681C530", Offset = "0x681AD30", VA = "0x18681C530", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x681C4E0", Offset = "0x681ACE0", VA = "0x18681C4E0", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x681C370", Offset = "0x681AB70", VA = "0x18681C370", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x681C240", Offset = "0x681AA40", VA = "0x18681C240")]
		private JobHandle FENCKGDMMKE(OHIMBDGOHLK<ReplicatorPreallocatedObjectCountData_v1> component_19, ILBBPINKANN<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public OHIMBDGOHLK<OMShapeContainerData_v1> component_32;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ILBBPINKANN<OMShapeContainerData> component_33;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x681A880", Offset = "0x6819080", VA = "0x18681A880")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x681A870", Offset = "0x6819070", VA = "0x18681A870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x681A820", Offset = "0x6819020", VA = "0x18681A820", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x681A6B0", Offset = "0x6818EB0", VA = "0x18681A6B0", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x681A580", Offset = "0x6818D80", VA = "0x18681A580")]
		private JobHandle HHDANGINEFB(OHIMBDGOHLK<OMShapeContainerData_v1> component_32, ILBBPINKANN<OMShapeContainerData> component_33, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OHIMBDGOHLK<ContainerFlagsData_v1> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ILBBPINKANN<ContainerFlagsData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6819BE0", Offset = "0x68183E0", VA = "0x186819BE0")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6819BD0", Offset = "0x68183D0", VA = "0x186819BD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6819B80", Offset = "0x6818380", VA = "0x186819B80", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6819A10", Offset = "0x6818210", VA = "0x186819A10", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68198E0", Offset = "0x68180E0", VA = "0x1868198E0")]
		private JobHandle HJALNHLEIPD(OHIMBDGOHLK<ContainerFlagsData_v1> component_54, ILBBPINKANN<ContainerFlagsData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : PIKMBFPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OHIMBDGOHLK<ObjectPolicyData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public OHIMBDGOHLK<ObjectPolicyData_v2> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public OHIMBDGOHLK<ObjectPolicyData_v3> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OHIMBDGOHLK<ObjectPolicyData_v4> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ILBBPINKANN<ObjectPolicyData> component_63;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x681AEF0", Offset = "0x68196F0", VA = "0x18681AEF0")]
			private void PCKMOLHBJIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x681AEE0", Offset = "0x68196E0", VA = "0x18681AEE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MMJHHDEPGMK Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x681AE90", Offset = "0x6819690", VA = "0x18681AE90", Slot = "14")]
			get
			{
				return default(MMJHHDEPGMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x681ABC0", Offset = "0x68193C0", VA = "0x18681ABC0", Slot = "15")]
		protected override void KFIIOHHKDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x681B970", Offset = "0x681A170", VA = "0x18681B970")]
		private JobHandle PCEDNBMMNCD(OHIMBDGOHLK<ObjectPolicyData_v1> component_59, OHIMBDGOHLK<ObjectPolicyData_v2> component_60, OHIMBDGOHLK<ObjectPolicyData_v3> component_61, OHIMBDGOHLK<ObjectPolicyData_v4> component_62, ILBBPINKANN<ObjectPolicyData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x210B000", Offset = "0x2109800", VA = "0x18210B000")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class GHJCPLMJDFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C120", Offset = "0x2A8A920", VA = "0x182A8C120")]
	public static void DPBOJPFCOAI<T>(T GNAJPFLMGKG, [Out] T MLFCBDFHBAL) where T : struct
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
