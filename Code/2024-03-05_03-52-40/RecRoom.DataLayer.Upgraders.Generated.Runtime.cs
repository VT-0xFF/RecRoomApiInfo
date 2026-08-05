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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JGDPIJJJJFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A6730", Offset = "0x60A5530", VA = "0x1860A6730")]
	public static void LBCOKCMPBKD(ComponentSystemGroup APONKBIHAIO, EntityCommandBufferSystem MOMNNDIAGMH)
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
		[Cpp2IlInjected.Address(RVA = "0x60A6730", Offset = "0x60A5530", VA = "0x1860A6730")]
		public static void EAFCEDHFKDO(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60A8A60", Offset = "0x60A7860", VA = "0x1860A8A60")]
		private void LBCOKCMPBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60A8D00", Offset = "0x60A7B00", VA = "0x1860A8D00")]
		private void PACOPLAEIFP(IIFLCBDHLLH system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : IIFLCBDHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NNFGMLBCBML<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IABMDKIPAEF<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60A6910", Offset = "0x60A5710", VA = "0x1860A6910")]
			private void HJPGOANINAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60A6900", Offset = "0x60A5700", VA = "0x1860A6900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IIFCCHIKGII log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IIFCCHIKGII Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x60A6780", Offset = "0x60A5580", VA = "0x1860A6780", Slot = "14")]
			get
			{
				return default(IIFCCHIKGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60A6C50", Offset = "0x60A5A50", VA = "0x1860A6C50", Slot = "15")]
		protected override void PHHEGBOKHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60A67D0", Offset = "0x60A55D0", VA = "0x1860A67D0")]
		private JobHandle LPKAMHMDECO(NNFGMLBCBML<PersistentUserTagData_v1> component_1, IABMDKIPAEF<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F357E0", Offset = "0x1F345E0", VA = "0x181F357E0")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : IIFLCBDHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NNFGMLBCBML<OMShapeContainerData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IABMDKIPAEF<OMShapeContainerData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60A6FA0", Offset = "0x60A5DA0", VA = "0x1860A6FA0")]
			private void HJPGOANINAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x60A6F90", Offset = "0x60A5D90", VA = "0x1860A6F90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IIFCCHIKGII log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IIFCCHIKGII Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60A6E10", Offset = "0x60A5C10", VA = "0x1860A6E10", Slot = "14")]
			get
			{
				return default(IIFCCHIKGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60A7290", Offset = "0x60A6090", VA = "0x1860A7290", Slot = "15")]
		protected override void PHHEGBOKHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60A6E60", Offset = "0x60A5C60", VA = "0x1860A6E60")]
		private JobHandle BOOKMIHAPPO(NNFGMLBCBML<OMShapeContainerData_v1> component_23, IABMDKIPAEF<OMShapeContainerData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F357E0", Offset = "0x1F345E0", VA = "0x181F357E0")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : IIFLCBDHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public NNFGMLBCBML<ContainerFlagsData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IABMDKIPAEF<ContainerFlagsData> component_43;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60A75E0", Offset = "0x60A63E0", VA = "0x1860A75E0")]
			private void HJPGOANINAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60A75D0", Offset = "0x60A63D0", VA = "0x1860A75D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IIFCCHIKGII log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IIFCCHIKGII Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x60A7450", Offset = "0x60A6250", VA = "0x1860A7450", Slot = "14")]
			get
			{
				return default(IIFCCHIKGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60A78B0", Offset = "0x60A66B0", VA = "0x1860A78B0", Slot = "15")]
		protected override void PHHEGBOKHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60A74A0", Offset = "0x60A62A0", VA = "0x1860A74A0")]
		private JobHandle BKLAKLNJAOC(NNFGMLBCBML<ContainerFlagsData_v1> component_42, IABMDKIPAEF<ContainerFlagsData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F357E0", Offset = "0x1F345E0", VA = "0x181F357E0")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : IIFLCBDHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public NNFGMLBCBML<ObjectPolicyData_v1> component_46;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NNFGMLBCBML<ObjectPolicyData_v2> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public NNFGMLBCBML<ObjectPolicyData_v3> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NNFGMLBCBML<ObjectPolicyData_v4> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IABMDKIPAEF<ObjectPolicyData> component_50;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60A7CC0", Offset = "0x60A6AC0", VA = "0x1860A7CC0")]
			private void HJPGOANINAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60A7CB0", Offset = "0x60A6AB0", VA = "0x1860A7CB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IIFCCHIKGII log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IIFCCHIKGII Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60A7A70", Offset = "0x60A6870", VA = "0x1860A7A70", Slot = "14")]
			get
			{
				return default(IIFCCHIKGII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60A8740", Offset = "0x60A7540", VA = "0x1860A8740", Slot = "15")]
		protected override void PHHEGBOKHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60A7AC0", Offset = "0x60A68C0", VA = "0x1860A7AC0")]
		private JobHandle LJEAKLHMFAP(NNFGMLBCBML<ObjectPolicyData_v1> component_46, NNFGMLBCBML<ObjectPolicyData_v2> component_47, NNFGMLBCBML<ObjectPolicyData_v3> component_48, NNFGMLBCBML<ObjectPolicyData_v4> component_49, IABMDKIPAEF<ObjectPolicyData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F357E0", Offset = "0x1F345E0", VA = "0x181F357E0")]
		public LinearUpgradeSystem_3()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class LEIBPIMHBED
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27F4DD0", Offset = "0x27F3BD0", VA = "0x1827F4DD0")]
	public static void ODKBFDINOIE<T>(T ILMCAINDAOO, [Out] T FIBACKHEOKM) where T : struct
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
