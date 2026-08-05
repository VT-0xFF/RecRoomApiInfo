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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LLMLECNPLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68956C0", Offset = "0x68942C0", VA = "0x1868956C0")]
	public static void LEDHHHIHKBP(ComponentSystemGroup PHEDNOCBEEM, EntityCommandBufferSystem DDMLMPJKBJC)
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
		[Cpp2IlInjected.Address(RVA = "0x68956C0", Offset = "0x68942C0", VA = "0x1868956C0")]
		public static void OOMNJCLGAAH(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6898010", Offset = "0x6896C10", VA = "0x186898010")]
		private void LEDHHHIHKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68983F0", Offset = "0x6896FF0", VA = "0x1868983F0")]
		private void LJANMEKGOJG(PGHFAMEGMJE system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public MKFFBBKAICP<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public FHFDJAKIHDB<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6897670", Offset = "0x6896270", VA = "0x186897670")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6897660", Offset = "0x6896260", VA = "0x186897660", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x68974E0", Offset = "0x68960E0", VA = "0x1868974E0", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6897370", Offset = "0x6895F70", VA = "0x186897370", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6897530", Offset = "0x6896130", VA = "0x186897530")]
		private JobHandle ELLPOGCGCJF(MKFFBBKAICP<PersistentUserTagData_v1> component_1, FHFDJAKIHDB<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public MKFFBBKAICP<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public FHFDJAKIHDB<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6895A10", Offset = "0x6894610", VA = "0x186895A10")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6895A00", Offset = "0x6894600", VA = "0x186895A00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6895880", Offset = "0x6894480", VA = "0x186895880", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6895710", Offset = "0x6894310", VA = "0x186895710", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68958D0", Offset = "0x68944D0", VA = "0x1868958D0")]
		private JobHandle FPOLOIIMKIO(MKFFBBKAICP<LocalDeformableScaleData_v1> component_3, FHFDJAKIHDB<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public MKFFBBKAICP<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public FHFDJAKIHDB<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6897BD0", Offset = "0x68967D0", VA = "0x186897BD0")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6897BC0", Offset = "0x68967C0", VA = "0x186897BC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6897B70", Offset = "0x6896770", VA = "0x186897B70", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6897A00", Offset = "0x6896600", VA = "0x186897A00", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6897E90", Offset = "0x6896A90", VA = "0x186897E90")]
		private JobHandle ODDHNMCHGOL(MKFFBBKAICP<ReplicatorPreallocatedObjectCountData_v1> component_19, FHFDJAKIHDB<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public MKFFBBKAICP<OMShapeContainerData_v1> component_32;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FHFDJAKIHDB<OMShapeContainerData> component_33;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6896040", Offset = "0x6894C40", VA = "0x186896040")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6896030", Offset = "0x6894C30", VA = "0x186896030", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6895EB0", Offset = "0x6894AB0", VA = "0x186895EB0", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6895D40", Offset = "0x6894940", VA = "0x186895D40", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6895F00", Offset = "0x6894B00", VA = "0x186895F00")]
		private JobHandle KKOHOKOLNMK(MKFFBBKAICP<OMShapeContainerData_v1> component_32, FHFDJAKIHDB<OMShapeContainerData> component_33, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MKFFBBKAICP<ContainerFlagsData_v1> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FHFDJAKIHDB<ContainerFlagsData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68953A0", Offset = "0x6893FA0", VA = "0x1868953A0")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6895390", Offset = "0x6893F90", VA = "0x186895390", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6895340", Offset = "0x6893F40", VA = "0x186895340", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68950A0", Offset = "0x6893CA0", VA = "0x1868950A0", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6895210", Offset = "0x6893E10", VA = "0x186895210")]
		private JobHandle AAHDMEJECCI(MKFFBBKAICP<ContainerFlagsData_v1> component_54, FHFDJAKIHDB<ContainerFlagsData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : PGHFAMEGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MKFFBBKAICP<ObjectPolicyData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public MKFFBBKAICP<ObjectPolicyData_v2> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public MKFFBBKAICP<ObjectPolicyData_v3> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public MKFFBBKAICP<ObjectPolicyData_v4> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public FHFDJAKIHDB<ObjectPolicyData> component_63;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x68968A0", Offset = "0x68954A0", VA = "0x1868968A0")]
			private void HHILLHPBAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6896890", Offset = "0x6895490", VA = "0x186896890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override KEDKJKIEEGM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6896650", Offset = "0x6895250", VA = "0x186896650", Slot = "14")]
			get
			{
				return default(KEDKJKIEEGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6896380", Offset = "0x6894F80", VA = "0x186896380", Slot = "15")]
		protected override void AAGPPBMPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68966A0", Offset = "0x68952A0", VA = "0x1868966A0")]
		private JobHandle GADICDPOCFK(MKFFBBKAICP<ObjectPolicyData_v1> component_59, MKFFBBKAICP<ObjectPolicyData_v2> component_60, MKFFBBKAICP<ObjectPolicyData_v3> component_61, MKFFBBKAICP<ObjectPolicyData_v4> component_62, FHFDJAKIHDB<ObjectPolicyData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21677D0", Offset = "0x21663D0", VA = "0x1821677D0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class JJPJIIBDJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B97880", Offset = "0x2B96480", VA = "0x182B97880")]
	public static void JAOPGLIKFBA<T>(T KNHGOFEIOHM, [Out] T HCOPCPFHNHC) where T : struct
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
