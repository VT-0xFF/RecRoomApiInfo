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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFIOFPIMEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6275D90", Offset = "0x6274D90", VA = "0x186275D90")]
	public static void KDFPFNPBMPI(ComponentSystemGroup CHIACAMHPOH, EntityCommandBufferSystem IPMNKGLLGHE)
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
		[Cpp2IlInjected.Address(RVA = "0x6275D90", Offset = "0x6274D90", VA = "0x186275D90")]
		public static void PKENNCKMPJI(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6278780", Offset = "0x6277780", VA = "0x186278780")]
		private void KDFPFNPBMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62786F0", Offset = "0x62776F0", VA = "0x1862786F0")]
		private void AMCCGOIEAEJ(GIOLPDPGEFP system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : GIOLPDPGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public ADOMEMPFHDN<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public BDKHMKPEPOG<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x62760E0", Offset = "0x62750E0", VA = "0x1862760E0")]
			private void OEJOKNELPCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x62760D0", Offset = "0x62750D0", VA = "0x1862760D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly NDLEKAMCBHL log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override NDLEKAMCBHL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6275F50", Offset = "0x6274F50", VA = "0x186275F50", Slot = "14")]
			get
			{
				return default(NDLEKAMCBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6275DE0", Offset = "0x6274DE0", VA = "0x186275DE0", Slot = "15")]
		protected override void APBINLEEMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6275FA0", Offset = "0x6274FA0", VA = "0x186275FA0")]
		private JobHandle IBDEGDKNEAG(ADOMEMPFHDN<PersistentUserTagData_v1> component_1, BDKHMKPEPOG<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x200A970", Offset = "0x2009970", VA = "0x18200A970")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : GIOLPDPGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ADOMEMPFHDN<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public BDKHMKPEPOG<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6276770", Offset = "0x6275770", VA = "0x186276770")]
			private void OEJOKNELPCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6276760", Offset = "0x6275760", VA = "0x186276760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly NDLEKAMCBHL log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override NDLEKAMCBHL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x62765E0", Offset = "0x62755E0", VA = "0x1862765E0", Slot = "14")]
			get
			{
				return default(NDLEKAMCBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6276470", Offset = "0x6275470", VA = "0x186276470", Slot = "15")]
		protected override void APBINLEEMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6276630", Offset = "0x6275630", VA = "0x186276630")]
		private JobHandle IAMLFOFJNJA(ADOMEMPFHDN<LocalDeformableScaleData_v1> component_3, BDKHMKPEPOG<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x200A970", Offset = "0x2009970", VA = "0x18200A970")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : GIOLPDPGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ADOMEMPFHDN<OMShapeContainerData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public BDKHMKPEPOG<OMShapeContainerData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6276DA0", Offset = "0x6275DA0", VA = "0x186276DA0")]
			private void OEJOKNELPCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6276D90", Offset = "0x6275D90", VA = "0x186276D90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly NDLEKAMCBHL log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override NDLEKAMCBHL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6276C10", Offset = "0x6275C10", VA = "0x186276C10", Slot = "14")]
			get
			{
				return default(NDLEKAMCBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6276AA0", Offset = "0x6275AA0", VA = "0x186276AA0", Slot = "15")]
		protected override void APBINLEEMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6276C60", Offset = "0x6275C60", VA = "0x186276C60")]
		private JobHandle GKJFDKACKPL(ADOMEMPFHDN<OMShapeContainerData_v1> component_26, BDKHMKPEPOG<OMShapeContainerData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x200A970", Offset = "0x2009970", VA = "0x18200A970")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : GIOLPDPGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public ADOMEMPFHDN<ContainerFlagsData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public BDKHMKPEPOG<ContainerFlagsData> component_48;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x62773E0", Offset = "0x62763E0", VA = "0x1862773E0")]
			private void OEJOKNELPCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62773D0", Offset = "0x62763D0", VA = "0x1862773D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly NDLEKAMCBHL log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override NDLEKAMCBHL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6277250", Offset = "0x6276250", VA = "0x186277250", Slot = "14")]
			get
			{
				return default(NDLEKAMCBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62770E0", Offset = "0x62760E0", VA = "0x1862770E0", Slot = "15")]
		protected override void APBINLEEMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62772A0", Offset = "0x62762A0", VA = "0x1862772A0")]
		private JobHandle GBAJPPMALPO(ADOMEMPFHDN<ContainerFlagsData_v1> component_47, BDKHMKPEPOG<ContainerFlagsData> component_48, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x200A970", Offset = "0x2009970", VA = "0x18200A970")]
		public LinearUpgradeSystem_3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_4 : GIOLPDPGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_4_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ADOMEMPFHDN<ObjectPolicyData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ADOMEMPFHDN<ObjectPolicyData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ADOMEMPFHDN<ObjectPolicyData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public ADOMEMPFHDN<ObjectPolicyData_v4> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public BDKHMKPEPOG<ObjectPolicyData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6277C20", Offset = "0x6276C20", VA = "0x186277C20")]
			private void OEJOKNELPCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6277C10", Offset = "0x6276C10", VA = "0x186277C10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly NDLEKAMCBHL log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override NDLEKAMCBHL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62779D0", Offset = "0x62769D0", VA = "0x1862779D0", Slot = "14")]
			get
			{
				return default(NDLEKAMCBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6277700", Offset = "0x6276700", VA = "0x186277700", Slot = "15")]
		protected override void APBINLEEMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6277A20", Offset = "0x6276A20", VA = "0x186277A20")]
		private JobHandle FMEBMEOKFFF(ADOMEMPFHDN<ObjectPolicyData_v1> component_51, ADOMEMPFHDN<ObjectPolicyData_v2> component_52, ADOMEMPFHDN<ObjectPolicyData_v3> component_53, ADOMEMPFHDN<ObjectPolicyData_v4> component_54, BDKHMKPEPOG<ObjectPolicyData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x200A970", Offset = "0x2009970", VA = "0x18200A970")]
		public LinearUpgradeSystem_4()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class HPKEIFPNBBB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28EFD80", Offset = "0x28EED80", VA = "0x1828EFD80")]
	public static void CHGOANCHFGK<T>(T NDCBPKHBNLH, [Out] T IKHBANKCHDN) where T : struct
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
