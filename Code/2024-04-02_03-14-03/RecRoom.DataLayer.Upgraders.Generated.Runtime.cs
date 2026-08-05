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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CANLLNBENLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60EBD00", Offset = "0x60EA900", VA = "0x1860EBD00")]
	public static void CHOBHJICHOL(ComponentSystemGroup BFMFDPKLEPG, EntityCommandBufferSystem CJGLJBDEBOP)
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
		[Cpp2IlInjected.Address(RVA = "0x60EBD00", Offset = "0x60EA900", VA = "0x1860EBD00")]
		public static void MHMACPDGIEO(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60EE030", Offset = "0x60ECC30", VA = "0x1860EE030")]
		private void CHOBHJICHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60EE2D0", Offset = "0x60ECED0", VA = "0x1860EE2D0")]
		private void FLMLICFNDGP(LMNCDLCGDOC system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : LMNCDLCGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EMJOILMPLEF<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AKIJOJHCGME<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60EBF20", Offset = "0x60EAB20", VA = "0x1860EBF20")]
			private void FMPICGJDEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60EBF10", Offset = "0x60EAB10", VA = "0x1860EBF10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly HEENJBKIIAO log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override HEENJBKIIAO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x60EBD50", Offset = "0x60EA950", VA = "0x1860EBD50", Slot = "14")]
			get
			{
				return default(HEENJBKIIAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60EBDA0", Offset = "0x60EA9A0", VA = "0x1860EBDA0", Slot = "15")]
		protected override void HGMMBKDJDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60EC260", Offset = "0x60EAE60", VA = "0x1860EC260")]
		private JobHandle NIHPIEJBPEP(EMJOILMPLEF<PersistentUserTagData_v1> component_1, AKIJOJHCGME<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6A40", Offset = "0x1FA5640", VA = "0x181FA6A40")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : LMNCDLCGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public EMJOILMPLEF<OMShapeContainerData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AKIJOJHCGME<OMShapeContainerData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60EC6E0", Offset = "0x60EB2E0", VA = "0x1860EC6E0")]
			private void FMPICGJDEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x60EC6D0", Offset = "0x60EB2D0", VA = "0x1860EC6D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly HEENJBKIIAO log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override HEENJBKIIAO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60EC3E0", Offset = "0x60EAFE0", VA = "0x1860EC3E0", Slot = "14")]
			get
			{
				return default(HEENJBKIIAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60EC560", Offset = "0x60EB160", VA = "0x1860EC560", Slot = "15")]
		protected override void HGMMBKDJDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60EC430", Offset = "0x60EB030", VA = "0x1860EC430")]
		private JobHandle CPEOHLFMNHK(EMJOILMPLEF<OMShapeContainerData_v1> component_23, AKIJOJHCGME<OMShapeContainerData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6A40", Offset = "0x1FA5640", VA = "0x181FA6A40")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : LMNCDLCGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public EMJOILMPLEF<ContainerFlagsData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public AKIJOJHCGME<ContainerFlagsData> component_43;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60ECD20", Offset = "0x60EB920", VA = "0x1860ECD20")]
			private void FMPICGJDEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60ECD10", Offset = "0x60EB910", VA = "0x1860ECD10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly HEENJBKIIAO log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override HEENJBKIIAO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x60ECA20", Offset = "0x60EB620", VA = "0x1860ECA20", Slot = "14")]
			get
			{
				return default(HEENJBKIIAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60ECA70", Offset = "0x60EB670", VA = "0x1860ECA70", Slot = "15")]
		protected override void HGMMBKDJDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60ECBE0", Offset = "0x60EB7E0", VA = "0x1860ECBE0")]
		private JobHandle ILBBEPAMDDO(EMJOILMPLEF<ContainerFlagsData_v1> component_42, AKIJOJHCGME<ContainerFlagsData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6A40", Offset = "0x1FA5640", VA = "0x181FA6A40")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : LMNCDLCGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public EMJOILMPLEF<ObjectPolicyData_v1> component_46;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EMJOILMPLEF<ObjectPolicyData_v2> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EMJOILMPLEF<ObjectPolicyData_v3> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EMJOILMPLEF<ObjectPolicyData_v4> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AKIJOJHCGME<ObjectPolicyData> component_50;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60ED370", Offset = "0x60EBF70", VA = "0x1860ED370")]
			private void FMPICGJDEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60ED360", Offset = "0x60EBF60", VA = "0x1860ED360", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly HEENJBKIIAO log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override HEENJBKIIAO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60ED040", Offset = "0x60EBC40", VA = "0x1860ED040", Slot = "14")]
			get
			{
				return default(HEENJBKIIAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60ED090", Offset = "0x60EBC90", VA = "0x1860ED090", Slot = "15")]
		protected override void HGMMBKDJDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60EDDF0", Offset = "0x60EC9F0", VA = "0x1860EDDF0")]
		private JobHandle NBDOCCBHCPE(EMJOILMPLEF<ObjectPolicyData_v1> component_46, EMJOILMPLEF<ObjectPolicyData_v2> component_47, EMJOILMPLEF<ObjectPolicyData_v3> component_48, EMJOILMPLEF<ObjectPolicyData_v4> component_49, AKIJOJHCGME<ObjectPolicyData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6A40", Offset = "0x1FA5640", VA = "0x181FA6A40")]
		public LinearUpgradeSystem_3()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class GDAAKHOGINH
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27DAFA0", Offset = "0x27D9BA0", VA = "0x1827DAFA0")]
	public static void BGBOOGMBOFC<T>(T BCGMNFKKHHA, [Out] T MHIFLJNAGOF) where T : struct
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
