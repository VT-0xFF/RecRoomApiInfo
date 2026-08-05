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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OPMJLCGBECG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7885960", Offset = "0x7884D60", VA = "0x187885960")]
	public static void KCKHCFAOFIJ(ComponentSystemGroup EOGFPKLNIAM, EntityCommandBufferSystem LGJBMJJMAGE)
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
		[Cpp2IlInjected.Address(RVA = "0x7885960", Offset = "0x7884D60", VA = "0x187885960")]
		public static void OOOMEECOMLM(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x788ABE0", Offset = "0x7889FE0", VA = "0x18788ABE0")]
		private void KCKHCFAOFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x788B4D0", Offset = "0x788A8D0", VA = "0x18788B4D0")]
		private void KFOHIBNLDNC(NENNCPJHDEM system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FHJCILOPLOE<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IKCOLHKCLPG<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7887120", Offset = "0x7886520", VA = "0x187887120")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7887460", Offset = "0x7886860", VA = "0x187887460", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7886E30", Offset = "0x7886230", VA = "0x187886E30", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7886E80", Offset = "0x7886280", VA = "0x187886E80", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7886FF0", Offset = "0x78863F0", VA = "0x187886FF0")]
		private JobHandle KPFNKKFONDJ(FHJCILOPLOE<PersistentUserTagData_v1> component_1, IKCOLHKCLPG<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public FHJCILOPLOE<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IKCOLHKCLPG<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7884FE0", Offset = "0x78843E0", VA = "0x187884FE0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x78852C0", Offset = "0x78846C0", VA = "0x1878852C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7884CF0", Offset = "0x78840F0", VA = "0x187884CF0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7884D40", Offset = "0x7884140", VA = "0x187884D40", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7884EB0", Offset = "0x78842B0", VA = "0x187884EB0")]
		private JobHandle HILMDCJHJML(FHJCILOPLOE<LocalDeformableScaleData_v1> component_4, IKCOLHKCLPG<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public FHJCILOPLOE<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IKCOLHKCLPG<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x788A250", Offset = "0x7889650", VA = "0x18788A250")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x788A510", Offset = "0x7889910", VA = "0x18788A510", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7889F60", Offset = "0x7889360", VA = "0x187889F60", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x788A0E0", Offset = "0x78894E0", VA = "0x18788A0E0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7889FB0", Offset = "0x78893B0", VA = "0x187889FB0")]
		private JobHandle EIKLIIGMNPN(FHJCILOPLOE<SerializedDataLayerVersionData_v1> component_12, IKCOLHKCLPG<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public FHJCILOPLOE<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IKCOLHKCLPG<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7889C40", Offset = "0x7889040", VA = "0x187889C40")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7889F00", Offset = "0x7889300", VA = "0x187889F00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7889950", Offset = "0x7888D50", VA = "0x187889950", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7889AD0", Offset = "0x7888ED0", VA = "0x187889AD0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78899A0", Offset = "0x7888DA0", VA = "0x1878899A0")]
		private JobHandle EFHCHBHMGNK(FHJCILOPLOE<ReplicatorPreallocatedObjectCountData_v1> component_20, IKCOLHKCLPG<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FHJCILOPLOE<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IKCOLHKCLPG<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x788A860", Offset = "0x7889C60", VA = "0x18788A860")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x788AB80", Offset = "0x7889F80", VA = "0x18788AB80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x788A570", Offset = "0x7889970", VA = "0x18788A570", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x788A5C0", Offset = "0x78899C0", VA = "0x18788A5C0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x788A730", Offset = "0x7889B30", VA = "0x18788A730")]
		private JobHandle HFNEBAAHCLA(FHJCILOPLOE<ToolCleanupStatusData_v1> component_25, IKCOLHKCLPG<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FHJCILOPLOE<ReplicatorData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IKCOLHKCLPG<ReplicatorData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x78894C0", Offset = "0x78888C0", VA = "0x1878894C0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x78897C0", Offset = "0x7888BC0", VA = "0x1878897C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7889300", Offset = "0x7888700", VA = "0x187889300", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7889350", Offset = "0x7888750", VA = "0x187889350", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78897D0", Offset = "0x7888BD0", VA = "0x1878897D0")]
		private JobHandle NAHDIKONCDG(FHJCILOPLOE<ReplicatorData_v1> component_33, IKCOLHKCLPG<ReplicatorData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public FHJCILOPLOE<InventionInstanceIdData_v1> component_36;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IKCOLHKCLPG<InventionInstanceIdData> component_37;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x78849E0", Offset = "0x7883DE0", VA = "0x1878849E0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7884C90", Offset = "0x7884090", VA = "0x187884C90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x78846F0", Offset = "0x7883AF0", VA = "0x1878846F0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7884740", Offset = "0x7883B40", VA = "0x187884740", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78848B0", Offset = "0x7883CB0", VA = "0x1878848B0")]
		private JobHandle FMGJGFMMMOF(FHJCILOPLOE<InventionInstanceIdData_v1> component_36, IKCOLHKCLPG<InventionInstanceIdData> component_37, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FHJCILOPLOE<OMShapeContainerData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IKCOLHKCLPG<OMShapeContainerData> component_40;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7885610", Offset = "0x7884A10", VA = "0x187885610")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7885900", Offset = "0x7884D00", VA = "0x187885900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7885320", Offset = "0x7884720", VA = "0x187885320", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7885370", Offset = "0x7884770", VA = "0x187885370", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78854E0", Offset = "0x78848E0", VA = "0x1878854E0")]
		private JobHandle JDAHDNMAHPB(FHJCILOPLOE<OMShapeContainerData_v1> component_39, IKCOLHKCLPG<OMShapeContainerData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FHJCILOPLOE<AuthoredAIIdData_v1> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IKCOLHKCLPG<AuthoredAIIdData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x78842A0", Offset = "0x78836A0", VA = "0x1878842A0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7884560", Offset = "0x7883960", VA = "0x187884560", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78840E0", Offset = "0x78834E0", VA = "0x1878840E0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7884130", Offset = "0x7883530", VA = "0x187884130", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7884570", Offset = "0x7883970", VA = "0x187884570")]
		private JobHandle MMDJCHBILDG(FHJCILOPLOE<AuthoredAIIdData_v1> component_48, IKCOLHKCLPG<AuthoredAIIdData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public FHJCILOPLOE<ContainerCollisionLayerData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IKCOLHKCLPG<PhysicsModelCollisionLayerData> component_59;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7887680", Offset = "0x7886A80", VA = "0x187887680")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7887970", Offset = "0x7886D70", VA = "0x187887970", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x78874C0", Offset = "0x78868C0", VA = "0x1878874C0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7887510", Offset = "0x7886910", VA = "0x187887510", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7887980", Offset = "0x7886D80", VA = "0x187887980")]
		private JobHandle PNAIOLGNFEI(FHJCILOPLOE<ContainerCollisionLayerData_v1> component_58, IKCOLHKCLPG<PhysicsModelCollisionLayerData> component_59, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public FHJCILOPLOE<ContainerGrabbableModeData_v1> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public IKCOLHKCLPG<PhysicsModelGrabbableModeData> component_63;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7888FB0", Offset = "0x78883B0", VA = "0x187888FB0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x78892A0", Offset = "0x78886A0", VA = "0x1878892A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7888CC0", Offset = "0x78880C0", VA = "0x187888CC0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7888D10", Offset = "0x7888110", VA = "0x187888D10", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7888E80", Offset = "0x7888280", VA = "0x187888E80")]
		private JobHandle KJEEEABMPPJ(FHJCILOPLOE<ContainerGrabbableModeData_v1> component_62, IKCOLHKCLPG<PhysicsModelGrabbableModeData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public FHJCILOPLOE<ContainerFlagsData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public FHJCILOPLOE<ContainerFlagsData_v2> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public FHJCILOPLOE<PhysicsModelFlagsData_v3> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IKCOLHKCLPG<PhysicsModelFlagsData> component_73;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7888590", Offset = "0x7887990", VA = "0x187888590")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7888C60", Offset = "0x7888060", VA = "0x187888C60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7888140", Offset = "0x7887540", VA = "0x187888140", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7888190", Offset = "0x7887590", VA = "0x187888190", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x78883F0", Offset = "0x78877F0", VA = "0x1878883F0")]
		private JobHandle LENFFICLBNC(FHJCILOPLOE<ContainerFlagsData_v1> component_70, FHJCILOPLOE<ContainerFlagsData_v2> component_71, FHJCILOPLOE<PhysicsModelFlagsData_v3> component_72, IKCOLHKCLPG<PhysicsModelFlagsData> component_73, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public FHJCILOPLOE<ContainerCollisionModeData_v1> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IKCOLHKCLPG<PhysicsModelCollisionModeData> component_75;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7887CC0", Offset = "0x78870C0", VA = "0x187887CC0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7887FB0", Offset = "0x78873B0", VA = "0x187887FB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7887B00", Offset = "0x7886F00", VA = "0x187887B00", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7887B50", Offset = "0x7886F50", VA = "0x187887B50", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7887FC0", Offset = "0x78873C0", VA = "0x187887FC0")]
		private JobHandle NDCJDHOFHHL(FHJCILOPLOE<ContainerCollisionModeData_v1> component_74, IKCOLHKCLPG<PhysicsModelCollisionModeData> component_75, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public FHJCILOPLOE<ObjectPolicyData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FHJCILOPLOE<ObjectPolicyData_v2> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public FHJCILOPLOE<ObjectPolicyData_v3> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public FHJCILOPLOE<ObjectPolicyData_v4> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public FHJCILOPLOE<ObjectPolicyData_v5> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IKCOLHKCLPG<ObjectPolicyData> component_83;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7885DE0", Offset = "0x78851E0", VA = "0x187885DE0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7886BD0", Offset = "0x7885FD0", VA = "0x187886BD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7885A80", Offset = "0x7884E80", VA = "0x187885A80", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7885AD0", Offset = "0x7884ED0", VA = "0x187885AD0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7886BE0", Offset = "0x7885FE0", VA = "0x187886BE0")]
		private JobHandle ODBOMFAGIHE(FHJCILOPLOE<ObjectPolicyData_v1> component_78, FHJCILOPLOE<ObjectPolicyData_v2> component_79, FHJCILOPLOE<ObjectPolicyData_v3> component_80, FHJCILOPLOE<ObjectPolicyData_v4> component_81, FHJCILOPLOE<ObjectPolicyData_v5> component_82, IKCOLHKCLPG<ObjectPolicyData> component_83, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class FJNBBJHNBHK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x35D74C0", Offset = "0x35D68C0", VA = "0x1835D74C0")]
	public static void JGKIKOHAMIK<T, U>(T KDKMHDIGKBK, [Out] U POEMJFLDIAK) where T : struct where U : struct
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
