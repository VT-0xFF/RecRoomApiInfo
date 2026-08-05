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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LAIOEGBLPPN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCC30", Offset = "0x5FBBA30", VA = "0x185FBCC30")]
	public static void EKJJFHKEBNK(ComponentSystemGroup JNOOPBCIILF, EntityCommandBufferSystem DBDNEMICNGA)
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
		[Cpp2IlInjected.Address(RVA = "0x5FBCC30", Offset = "0x5FBBA30", VA = "0x185FBCC30")]
		public static void DBMIOLKOEJE(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FBEF60", Offset = "0x5FBDD60", VA = "0x185FBEF60")]
		private void EKJJFHKEBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF200", Offset = "0x5FBE000", VA = "0x185FBF200")]
		private void HLOBDAGJMBJ(JLEAELELJLE system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : JLEAELELJLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public PCCEDNEDEIF<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public PBCJLDBLFJH<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5FBCF80", Offset = "0x5FBBD80", VA = "0x185FBCF80")]
			private void NNFOBPHEIJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5FBCF70", Offset = "0x5FBBD70", VA = "0x185FBCF70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly KNPFMNBIIDA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override KNPFMNBIIDA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5FBCC80", Offset = "0x5FBBA80", VA = "0x185FBCC80", Slot = "14")]
			get
			{
				return default(KNPFMNBIIDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCE00", Offset = "0x5FBBC00", VA = "0x185FBCE00", Slot = "15")]
		protected override void LGILBNGHBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCCD0", Offset = "0x5FBBAD0", VA = "0x185FBCCD0")]
		private JobHandle DGPFEGPCEBD(PCCEDNEDEIF<PersistentUserTagData_v1> component_1, PBCJLDBLFJH<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0AE00", Offset = "0x1F09C00", VA = "0x181F0AE00")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : JLEAELELJLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public PCCEDNEDEIF<OMShapeContainerData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public PBCJLDBLFJH<OMShapeContainerData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5FBD610", Offset = "0x5FBC410", VA = "0x185FBD610")]
			private void NNFOBPHEIJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5FBD600", Offset = "0x5FBC400", VA = "0x185FBD600", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly KNPFMNBIIDA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override KNPFMNBIIDA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5FBD310", Offset = "0x5FBC110", VA = "0x185FBD310", Slot = "14")]
			get
			{
				return default(KNPFMNBIIDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD490", Offset = "0x5FBC290", VA = "0x185FBD490", Slot = "15")]
		protected override void LGILBNGHBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD360", Offset = "0x5FBC160", VA = "0x185FBD360")]
		private JobHandle JKJDHKLONCK(PCCEDNEDEIF<OMShapeContainerData_v1> component_23, PBCJLDBLFJH<OMShapeContainerData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F0AE00", Offset = "0x1F09C00", VA = "0x181F0AE00")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : JLEAELELJLE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public PCCEDNEDEIF<ContainerFlagsData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public PBCJLDBLFJH<ContainerFlagsData> component_43;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5FBDC50", Offset = "0x5FBCA50", VA = "0x185FBDC50")]
			private void NNFOBPHEIJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5FBDC40", Offset = "0x5FBCA40", VA = "0x185FBDC40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly KNPFMNBIIDA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override KNPFMNBIIDA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5FBDA80", Offset = "0x5FBC880", VA = "0x185FBDA80", Slot = "14")]
			get
			{
				return default(KNPFMNBIIDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FBDAD0", Offset = "0x5FBC8D0", VA = "0x185FBDAD0", Slot = "15")]
		protected override void LGILBNGHBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD950", Offset = "0x5FBC750", VA = "0x185FBD950")]
		private JobHandle BFOEGFIOOLB(PCCEDNEDEIF<ContainerFlagsData_v1> component_42, PBCJLDBLFJH<ContainerFlagsData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0AE00", Offset = "0x1F09C00", VA = "0x181F0AE00")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : JLEAELELJLE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PCCEDNEDEIF<ObjectPolicyData_v1> component_46;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PCCEDNEDEIF<ObjectPolicyData_v2> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public PCCEDNEDEIF<ObjectPolicyData_v3> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PCCEDNEDEIF<ObjectPolicyData_v4> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PBCJLDBLFJH<ObjectPolicyData> component_50;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FBE2A0", Offset = "0x5FBD0A0", VA = "0x185FBE2A0")]
			private void NNFOBPHEIJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FBE290", Offset = "0x5FBD090", VA = "0x185FBE290", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly KNPFMNBIIDA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override KNPFMNBIIDA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FBDF70", Offset = "0x5FBCD70", VA = "0x185FBDF70", Slot = "14")]
			get
			{
				return default(KNPFMNBIIDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FBDFC0", Offset = "0x5FBCDC0", VA = "0x185FBDFC0", Slot = "15")]
		protected override void LGILBNGHBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FBED20", Offset = "0x5FBDB20", VA = "0x185FBED20")]
		private JobHandle MAGOEPMIJHA(PCCEDNEDEIF<ObjectPolicyData_v1> component_46, PCCEDNEDEIF<ObjectPolicyData_v2> component_47, PCCEDNEDEIF<ObjectPolicyData_v3> component_48, PCCEDNEDEIF<ObjectPolicyData_v4> component_49, PBCJLDBLFJH<ObjectPolicyData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F0AE00", Offset = "0x1F09C00", VA = "0x181F0AE00")]
		public LinearUpgradeSystem_3()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class ECHCNIONKBE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25C4110", Offset = "0x25C2F10", VA = "0x1825C4110")]
	public static void IIADKFFKKEG<T>(T HPFNNCFAOFH, [Out] T JIBECFCCCNL) where T : struct
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
