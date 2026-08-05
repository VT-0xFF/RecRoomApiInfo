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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PIANOBHDKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61DD360", Offset = "0x61DC160", VA = "0x1861DD360")]
	public static void CJPJHCCHECC(ComponentSystemGroup JPNFLHEJMOJ, EntityCommandBufferSystem MBEAFJBBBLH)
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
		[Cpp2IlInjected.Address(RVA = "0x61DD360", Offset = "0x61DC160", VA = "0x1861DD360")]
		public static void PDCFDDHGNDP(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61DD440", Offset = "0x61DC240", VA = "0x1861DD440")]
		private void CJPJHCCHECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61DD3B0", Offset = "0x61DC1B0", VA = "0x1861DD3B0")]
		private void CEFMNEMJBAG(PINDEHECCBF system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : PINDEHECCBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OAGICEFBDPI<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public PJCLLKEBJGN<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x61DAD50", Offset = "0x61D9B50", VA = "0x1861DAD50")]
			private void IKLGMMOFFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x61DAD40", Offset = "0x61D9B40", VA = "0x1861DAD40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly JNOMMELLEMA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override JNOMMELLEMA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x61DACF0", Offset = "0x61D9AF0", VA = "0x1861DACF0", Slot = "14")]
			get
			{
				return default(JNOMMELLEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61DAB80", Offset = "0x61D9980", VA = "0x1861DAB80", Slot = "15")]
		protected override void CDKMIDDICLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61DAA50", Offset = "0x61D9850", VA = "0x1861DAA50")]
		private JobHandle BPLKKOFLOLI(OAGICEFBDPI<PersistentUserTagData_v1> component_1, PJCLLKEBJGN<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x20025A0", Offset = "0x20013A0", VA = "0x1820025A0")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : PINDEHECCBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OAGICEFBDPI<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public PJCLLKEBJGN<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x61DB3E0", Offset = "0x61DA1E0", VA = "0x1861DB3E0")]
			private void IKLGMMOFFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x61DB3D0", Offset = "0x61DA1D0", VA = "0x1861DB3D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly JNOMMELLEMA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override JNOMMELLEMA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x61DB380", Offset = "0x61DA180", VA = "0x1861DB380", Slot = "14")]
			get
			{
				return default(JNOMMELLEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61DB210", Offset = "0x61DA010", VA = "0x1861DB210", Slot = "15")]
		protected override void CDKMIDDICLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61DB0E0", Offset = "0x61D9EE0", VA = "0x1861DB0E0")]
		private JobHandle AIOIAKBANME(OAGICEFBDPI<LocalDeformableScaleData_v1> component_3, PJCLLKEBJGN<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20025A0", Offset = "0x20013A0", VA = "0x1820025A0")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : PINDEHECCBF
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public OAGICEFBDPI<OMShapeContainerData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public PJCLLKEBJGN<OMShapeContainerData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x61DBA10", Offset = "0x61DA810", VA = "0x1861DBA10")]
			private void IKLGMMOFFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x61DBA00", Offset = "0x61DA800", VA = "0x1861DBA00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly JNOMMELLEMA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override JNOMMELLEMA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x61DB880", Offset = "0x61DA680", VA = "0x1861DB880", Slot = "14")]
			get
			{
				return default(JNOMMELLEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61DB710", Offset = "0x61DA510", VA = "0x1861DB710", Slot = "15")]
		protected override void CDKMIDDICLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61DB8D0", Offset = "0x61DA6D0", VA = "0x1861DB8D0")]
		private JobHandle HDOCNIPDNDB(OAGICEFBDPI<OMShapeContainerData_v1> component_26, PJCLLKEBJGN<OMShapeContainerData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x20025A0", Offset = "0x20013A0", VA = "0x1820025A0")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : PINDEHECCBF
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public OAGICEFBDPI<ContainerFlagsData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PJCLLKEBJGN<ContainerFlagsData> component_48;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61DC050", Offset = "0x61DAE50", VA = "0x1861DC050")]
			private void IKLGMMOFFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61DC040", Offset = "0x61DAE40", VA = "0x1861DC040", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly JNOMMELLEMA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override JNOMMELLEMA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61DBFF0", Offset = "0x61DADF0", VA = "0x1861DBFF0", Slot = "14")]
			get
			{
				return default(JNOMMELLEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61DBD50", Offset = "0x61DAB50", VA = "0x1861DBD50", Slot = "15")]
		protected override void CDKMIDDICLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61DBEC0", Offset = "0x61DACC0", VA = "0x1861DBEC0")]
		private JobHandle CGKBPHOCHEA(OAGICEFBDPI<ContainerFlagsData_v1> component_47, PJCLLKEBJGN<ContainerFlagsData> component_48, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x20025A0", Offset = "0x20013A0", VA = "0x1820025A0")]
		public LinearUpgradeSystem_3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_4 : PINDEHECCBF
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_4_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OAGICEFBDPI<ObjectPolicyData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OAGICEFBDPI<ObjectPolicyData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OAGICEFBDPI<ObjectPolicyData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OAGICEFBDPI<ObjectPolicyData_v4> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PJCLLKEBJGN<ObjectPolicyData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x61DC6A0", Offset = "0x61DB4A0", VA = "0x1861DC6A0")]
			private void IKLGMMOFFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61DC690", Offset = "0x61DB490", VA = "0x1861DC690", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JNOMMELLEMA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override JNOMMELLEMA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61DC640", Offset = "0x61DB440", VA = "0x1861DC640", Slot = "14")]
			get
			{
				return default(JNOMMELLEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61DC370", Offset = "0x61DB170", VA = "0x1861DC370", Slot = "15")]
		protected override void CDKMIDDICLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61DD120", Offset = "0x61DBF20", VA = "0x1861DD120")]
		private JobHandle NICDANPHMIL(OAGICEFBDPI<ObjectPolicyData_v1> component_51, OAGICEFBDPI<ObjectPolicyData_v2> component_52, OAGICEFBDPI<ObjectPolicyData_v3> component_53, OAGICEFBDPI<ObjectPolicyData_v4> component_54, PJCLLKEBJGN<ObjectPolicyData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x20025A0", Offset = "0x20013A0", VA = "0x1820025A0")]
		public LinearUpgradeSystem_4()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class GIILFDPFIFO
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28C4A20", Offset = "0x28C3820", VA = "0x1828C4A20")]
	public static void PHCONDCHMHN<T>(T IOKCHIINDMF, [Out] T AAAIJIAJNCN) where T : struct
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
