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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JCFCBLCJKGM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63C0750", Offset = "0x63BF950", VA = "0x1863C0750")]
	public static void BKOIMFHPLHI(ComponentSystemGroup FPAMHMBGLIL, EntityCommandBufferSystem PENMCEINNIN)
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
		[Cpp2IlInjected.Address(RVA = "0x63C0750", Offset = "0x63BF950", VA = "0x1863C0750")]
		public static void EBGJPPFCLHB(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63C3750", Offset = "0x63C2950", VA = "0x1863C3750")]
		private void BKOIMFHPLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63C36C0", Offset = "0x63C28C0", VA = "0x1863C36C0")]
		private void ABFCIDFKEPG(KMEDPOFBENB system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_0 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_0_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LLEENHKMHLB<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public CMNHHGJFCEJ<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x63C0930", Offset = "0x63BFB30", VA = "0x1863C0930")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0920", Offset = "0x63BFB20", VA = "0x1863C0920", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x63C08D0", Offset = "0x63BFAD0", VA = "0x1863C08D0", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x63C0C70", Offset = "0x63BFE70", VA = "0x1863C0C70", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63C07A0", Offset = "0x63BF9A0", VA = "0x1863C07A0")]
		private JobHandle CBDGECKMLJO(LLEENHKMHLB<PersistentUserTagData_v1> component_1, CMNHHGJFCEJ<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_0()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_1 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LLEENHKMHLB<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public CMNHHGJFCEJ<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63C0FC0", Offset = "0x63C01C0", VA = "0x1863C0FC0")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63C0FB0", Offset = "0x63C01B0", VA = "0x1863C0FB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F60", Offset = "0x63C0160", VA = "0x1863C0F60", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63C12A0", Offset = "0x63C04A0", VA = "0x1863C12A0", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x63C0E30", Offset = "0x63C0030", VA = "0x1863C0E30")]
		private JobHandle DLEKOLLCMDG(LLEENHKMHLB<LocalDeformableScaleData_v1> component_3, CMNHHGJFCEJ<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_1()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_2 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LLEENHKMHLB<ReplicatorPreallocatedObjectCountData_v1> component_16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public CMNHHGJFCEJ<ReplicatorPreallocatedObjectCountData> component_17;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63C15F0", Offset = "0x63C07F0", VA = "0x1863C15F0")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63C15E0", Offset = "0x63C07E0", VA = "0x1863C15E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63C1590", Offset = "0x63C0790", VA = "0x1863C1590", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63C18B0", Offset = "0x63C0AB0", VA = "0x1863C18B0", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63C1460", Offset = "0x63C0660", VA = "0x1863C1460")]
		private JobHandle CEIOLDBFBKB(LLEENHKMHLB<ReplicatorPreallocatedObjectCountData_v1> component_16, CMNHHGJFCEJ<ReplicatorPreallocatedObjectCountData> component_17, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_3 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_3_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LLEENHKMHLB<OMShapeContainerData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CMNHHGJFCEJ<OMShapeContainerData> component_29;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63C1C00", Offset = "0x63C0E00", VA = "0x1863C1C00")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63C1BF0", Offset = "0x63C0DF0", VA = "0x1863C1BF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63C1A70", Offset = "0x63C0C70", VA = "0x1863C1A70", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63C1EF0", Offset = "0x63C10F0", VA = "0x1863C1EF0", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63C1AC0", Offset = "0x63C0CC0", VA = "0x1863C1AC0")]
		private JobHandle LIHBFMBFMKC(LLEENHKMHLB<OMShapeContainerData_v1> component_28, CMNHHGJFCEJ<OMShapeContainerData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_4 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct LinearUpgradeSystem_4_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LLEENHKMHLB<ContainerFlagsData_v1> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CMNHHGJFCEJ<ContainerFlagsData> component_50;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2240", Offset = "0x63C1440", VA = "0x1863C2240")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63C2230", Offset = "0x63C1430", VA = "0x1863C2230", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63C20B0", Offset = "0x63C12B0", VA = "0x1863C20B0", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63C2510", Offset = "0x63C1710", VA = "0x1863C2510", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x63C2100", Offset = "0x63C1300", VA = "0x1863C2100")]
		private JobHandle KFGPGOPEOGK(LLEENHKMHLB<ContainerFlagsData_v1> component_49, CMNHHGJFCEJ<ContainerFlagsData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_4()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class LinearUpgradeSystem_5 : KMEDPOFBENB
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LinearUpgradeSystem_5_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LLEENHKMHLB<ObjectPolicyData_v1> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LLEENHKMHLB<ObjectPolicyData_v2> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public LLEENHKMHLB<ObjectPolicyData_v3> component_55;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LLEENHKMHLB<ObjectPolicyData_v4> component_56;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CMNHHGJFCEJ<ObjectPolicyData> component_57;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63C2730", Offset = "0x63C1930", VA = "0x1863C2730")]
			private void NGEMPNJOPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63C2720", Offset = "0x63C1920", VA = "0x1863C2720", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LBOEGNBEJHN log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LBOEGNBEJHN Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63C26D0", Offset = "0x63C18D0", VA = "0x1863C26D0", Slot = "14")]
			get
			{
				return default(LBOEGNBEJHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63C33A0", Offset = "0x63C25A0", VA = "0x1863C33A0", Slot = "15")]
		protected override void OOGOECPBDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63C31B0", Offset = "0x63C23B0", VA = "0x1863C31B0")]
		private JobHandle MDJDCGFNAAJ(LLEENHKMHLB<ObjectPolicyData_v1> component_53, LLEENHKMHLB<ObjectPolicyData_v2> component_54, LLEENHKMHLB<ObjectPolicyData_v3> component_55, LLEENHKMHLB<ObjectPolicyData_v4> component_56, CMNHHGJFCEJ<ObjectPolicyData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x208AB30", Offset = "0x2089D30", VA = "0x18208AB30")]
		public LinearUpgradeSystem_5()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal static class CEHGLINHILC
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x27CD350", Offset = "0x27CC550", VA = "0x1827CD350")]
	public static void PMKBGLHCNFF<T>(T DDBPKNAMPGF, [Out] T OINJHLFKAEJ) where T : struct
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
