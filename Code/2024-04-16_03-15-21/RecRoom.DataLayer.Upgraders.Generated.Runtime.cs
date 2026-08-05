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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LNHKCINPOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60F7CF0", Offset = "0x60F6EF0", VA = "0x1860F7CF0")]
	public static void PGEMJCNCEFL(ComponentSystemGroup MGGCNGMFFHE, EntityCommandBufferSystem FHGCOJAKMHG)
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
		[Cpp2IlInjected.Address(RVA = "0x60F7CF0", Offset = "0x60F6EF0", VA = "0x1860F7CF0")]
		public static void AMJAFDMAFHE(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60FA6E0", Offset = "0x60F98E0", VA = "0x1860FA6E0")]
		private void PGEMJCNCEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60FA650", Offset = "0x60F9850", VA = "0x1860FA650")]
		private void HBCLOJMCDJA(BFNODGCGCMB system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : BFNODGCGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LFCAKBENIFM<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LIFGFOIDDKE<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60F8030", Offset = "0x60F7230", VA = "0x1860F8030")]
			private void DJEKBHIENHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60F8370", Offset = "0x60F7570", VA = "0x1860F8370", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IOBNAOMELJK log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IOBNAOMELJK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x60F7D40", Offset = "0x60F6F40", VA = "0x1860F7D40", Slot = "14")]
			get
			{
				return default(IOBNAOMELJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60F7EC0", Offset = "0x60F70C0", VA = "0x1860F7EC0", Slot = "15")]
		protected override void HLEAOJLJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60F7D90", Offset = "0x60F6F90", VA = "0x1860F7D90")]
		private JobHandle GMOLGHPOPBE(LFCAKBENIFM<PersistentUserTagData_v1> component_1, LIFGFOIDDKE<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7760", Offset = "0x1FD6960", VA = "0x181FD7760")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : BFNODGCGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LFCAKBENIFM<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LIFGFOIDDKE<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60F8590", Offset = "0x60F7790", VA = "0x1860F8590")]
			private void DJEKBHIENHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x60F8870", Offset = "0x60F7A70", VA = "0x1860F8870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IOBNAOMELJK log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IOBNAOMELJK Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60F83D0", Offset = "0x60F75D0", VA = "0x1860F83D0", Slot = "14")]
			get
			{
				return default(IOBNAOMELJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60F8420", Offset = "0x60F7620", VA = "0x1860F8420", Slot = "15")]
		protected override void HLEAOJLJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60F8880", Offset = "0x60F7A80", VA = "0x1860F8880")]
		private JobHandle OFNEEMBAIBM(LFCAKBENIFM<LocalDeformableScaleData_v1> component_3, LIFGFOIDDKE<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7760", Offset = "0x1FD6960", VA = "0x181FD7760")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : BFNODGCGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LFCAKBENIFM<OMShapeContainerData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public LIFGFOIDDKE<OMShapeContainerData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60F8CF0", Offset = "0x60F7EF0", VA = "0x1860F8CF0")]
			private void DJEKBHIENHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60F8FE0", Offset = "0x60F81E0", VA = "0x1860F8FE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IOBNAOMELJK log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IOBNAOMELJK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x60F8A00", Offset = "0x60F7C00", VA = "0x1860F8A00", Slot = "14")]
			get
			{
				return default(IOBNAOMELJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60F8A50", Offset = "0x60F7C50", VA = "0x1860F8A50", Slot = "15")]
		protected override void HLEAOJLJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60F8BC0", Offset = "0x60F7DC0", VA = "0x1860F8BC0")]
		private JobHandle ILPJNAFFNLG(LFCAKBENIFM<OMShapeContainerData_v1> component_26, LIFGFOIDDKE<OMShapeContainerData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7760", Offset = "0x1FD6960", VA = "0x181FD7760")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : BFNODGCGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LFCAKBENIFM<ContainerFlagsData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LIFGFOIDDKE<ContainerFlagsData> component_48;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60F9330", Offset = "0x60F8530", VA = "0x1860F9330")]
			private void DJEKBHIENHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60F9600", Offset = "0x60F8800", VA = "0x1860F9600", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IOBNAOMELJK log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IOBNAOMELJK Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60F9040", Offset = "0x60F8240", VA = "0x1860F9040", Slot = "14")]
			get
			{
				return default(IOBNAOMELJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60F91C0", Offset = "0x60F83C0", VA = "0x1860F91C0", Slot = "15")]
		protected override void HLEAOJLJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60F9090", Offset = "0x60F8290", VA = "0x1860F9090")]
		private JobHandle CKEJJPFLPJP(LFCAKBENIFM<ContainerFlagsData_v1> component_47, LIFGFOIDDKE<ContainerFlagsData> component_48, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7760", Offset = "0x1FD6960", VA = "0x181FD7760")]
		public LinearUpgradeSystem_3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_4 : BFNODGCGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_4_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LFCAKBENIFM<ObjectPolicyData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LFCAKBENIFM<ObjectPolicyData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public LFCAKBENIFM<ObjectPolicyData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LFCAKBENIFM<ObjectPolicyData_v4> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LIFGFOIDDKE<ObjectPolicyData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60F9B70", Offset = "0x60F8D70", VA = "0x1860F9B70")]
			private void DJEKBHIENHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60FA5F0", Offset = "0x60F97F0", VA = "0x1860FA5F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly IOBNAOMELJK log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override IOBNAOMELJK Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60F9660", Offset = "0x60F8860", VA = "0x1860F9660", Slot = "14")]
			get
			{
				return default(IOBNAOMELJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60F98A0", Offset = "0x60F8AA0", VA = "0x1860F98A0", Slot = "15")]
		protected override void HLEAOJLJOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60F96B0", Offset = "0x60F88B0", VA = "0x1860F96B0")]
		private JobHandle FMCFBMAEALP(LFCAKBENIFM<ObjectPolicyData_v1> component_51, LFCAKBENIFM<ObjectPolicyData_v2> component_52, LFCAKBENIFM<ObjectPolicyData_v3> component_53, LFCAKBENIFM<ObjectPolicyData_v4> component_54, LIFGFOIDDKE<ObjectPolicyData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7760", Offset = "0x1FD6960", VA = "0x181FD7760")]
		public LinearUpgradeSystem_4()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class COLFGNKINIO
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26FA250", Offset = "0x26F9450", VA = "0x1826FA250")]
	public static void CNCLBGMJEKC<T>(T OAGFINNAPHP, [Out] T DFFOCGCONAB) where T : struct
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
