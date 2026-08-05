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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PEKJJGEDAOC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78BF2E0", Offset = "0x78BDCE0", VA = "0x1878BF2E0")]
	public static void HAFBDIPMKLA(ComponentSystemGroup ILBJJIFAJFF, EntityCommandBufferSystem GKLAEIHDPAE)
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
		[Cpp2IlInjected.Address(RVA = "0x78BF2E0", Offset = "0x78BDCE0", VA = "0x1878BF2E0")]
		public static void JGBPKPBLPFI(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78C31B0", Offset = "0x78C1BB0", VA = "0x1878C31B0")]
		private void HAFBDIPMKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78C3AA0", Offset = "0x78C24A0", VA = "0x1878C3AA0")]
		private void NIKGPNALNLL(DEKKAHDLANI system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GDDJBKFDOPP<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public GHOELHDNJOP<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x78BF6F0", Offset = "0x78BE0F0", VA = "0x1878BF6F0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x78BFA30", Offset = "0x78BE430", VA = "0x1878BFA30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x78BF400", Offset = "0x78BDE00", VA = "0x1878BF400", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78BF580", Offset = "0x78BDF80", VA = "0x1878BF580", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78BF450", Offset = "0x78BDE50", VA = "0x1878BF450")]
		private JobHandle EFOANCEBHED(GDDJBKFDOPP<PersistentUserTagData_v1> component_1, GHOELHDNJOP<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public GDDJBKFDOPP<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public GHOELHDNJOP<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x78BD5B0", Offset = "0x78BBFB0", VA = "0x1878BD5B0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x78BD890", Offset = "0x78BC290", VA = "0x1878BD890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x78BD3F0", Offset = "0x78BBDF0", VA = "0x1878BD3F0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78BD440", Offset = "0x78BBE40", VA = "0x1878BD440", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78BD2C0", Offset = "0x78BBCC0", VA = "0x1878BD2C0")]
		private JobHandle CANLNKMFMAC(GDDJBKFDOPP<LocalDeformableScaleData_v1> component_4, GHOELHDNJOP<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public GDDJBKFDOPP<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public GHOELHDNJOP<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x78C2820", Offset = "0x78C1220", VA = "0x1878C2820")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x78C2AE0", Offset = "0x78C14E0", VA = "0x1878C2AE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x78C2530", Offset = "0x78C0F30", VA = "0x1878C2530", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78C2580", Offset = "0x78C0F80", VA = "0x1878C2580", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78C26F0", Offset = "0x78C10F0", VA = "0x1878C26F0")]
		private JobHandle HLHELOBJHPO(GDDJBKFDOPP<SerializedDataLayerVersionData_v1> component_12, GHOELHDNJOP<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public GDDJBKFDOPP<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GHOELHDNJOP<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x78C2210", Offset = "0x78C0C10", VA = "0x1878C2210")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x78C24D0", Offset = "0x78C0ED0", VA = "0x1878C24D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x78C1F20", Offset = "0x78C0920", VA = "0x1878C1F20", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78C1F70", Offset = "0x78C0970", VA = "0x1878C1F70", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78C20E0", Offset = "0x78C0AE0", VA = "0x1878C20E0")]
		private JobHandle FKCCKLIHGFH(GDDJBKFDOPP<ReplicatorPreallocatedObjectCountData_v1> component_20, GHOELHDNJOP<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public GDDJBKFDOPP<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public GHOELHDNJOP<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x78C2E30", Offset = "0x78C1830", VA = "0x1878C2E30")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x78C3150", Offset = "0x78C1B50", VA = "0x1878C3150", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78C2C70", Offset = "0x78C1670", VA = "0x1878C2C70", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78C2CC0", Offset = "0x78C16C0", VA = "0x1878C2CC0", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78C2B40", Offset = "0x78C1540", VA = "0x1878C2B40")]
		private JobHandle DBJKIOMHFFJ(GDDJBKFDOPP<ToolCleanupStatusData_v1> component_25, GHOELHDNJOP<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GDDJBKFDOPP<ReplicatorData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public GHOELHDNJOP<ReplicatorData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x78C1BC0", Offset = "0x78C05C0", VA = "0x1878C1BC0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x78C1EC0", Offset = "0x78C08C0", VA = "0x1878C1EC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x78C18D0", Offset = "0x78C02D0", VA = "0x1878C18D0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78C1920", Offset = "0x78C0320", VA = "0x1878C1920", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78C1A90", Offset = "0x78C0490", VA = "0x1878C1A90")]
		private JobHandle LHGGFONBEPK(GDDJBKFDOPP<ReplicatorData_v1> component_33, GHOELHDNJOP<ReplicatorData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public GDDJBKFDOPP<InventionInstanceIdData_v1> component_36;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public GHOELHDNJOP<InventionInstanceIdData> component_37;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x78BCE80", Offset = "0x78BB880", VA = "0x1878BCE80")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x78BD130", Offset = "0x78BBB30", VA = "0x1878BD130", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x78BCCC0", Offset = "0x78BB6C0", VA = "0x1878BCCC0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78BCD10", Offset = "0x78BB710", VA = "0x1878BCD10", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78BD140", Offset = "0x78BBB40", VA = "0x1878BD140")]
		private JobHandle PKBBGHIPIEP(GDDJBKFDOPP<InventionInstanceIdData_v1> component_36, GHOELHDNJOP<InventionInstanceIdData> component_37, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GDDJBKFDOPP<OMShapeContainerData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GHOELHDNJOP<OMShapeContainerData> component_40;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x78BDAB0", Offset = "0x78BC4B0", VA = "0x1878BDAB0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x78BDDA0", Offset = "0x78BC7A0", VA = "0x1878BDDA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x78BD8F0", Offset = "0x78BC2F0", VA = "0x1878BD8F0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78BD940", Offset = "0x78BC340", VA = "0x1878BD940", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78BDDB0", Offset = "0x78BC7B0", VA = "0x1878BDDB0")]
		private JobHandle POENBOGAHHO(GDDJBKFDOPP<OMShapeContainerData_v1> component_39, GHOELHDNJOP<OMShapeContainerData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public GDDJBKFDOPP<AuthoredAIIdData_v1> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public GHOELHDNJOP<AuthoredAIIdData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x78BC9A0", Offset = "0x78BB3A0", VA = "0x1878BC9A0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78BCC60", Offset = "0x78BB660", VA = "0x1878BCC60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78BC6B0", Offset = "0x78BB0B0", VA = "0x1878BC6B0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78BC700", Offset = "0x78BB100", VA = "0x1878BC700", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78BC870", Offset = "0x78BB270", VA = "0x1878BC870")]
		private JobHandle JCJKBEAALHH(GDDJBKFDOPP<AuthoredAIIdData_v1> component_48, GHOELHDNJOP<AuthoredAIIdData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public GDDJBKFDOPP<ContainerCollisionLayerData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public GHOELHDNJOP<PhysicsModelCollisionLayerData> component_59;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x78BFD80", Offset = "0x78BE780", VA = "0x1878BFD80")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x78C0070", Offset = "0x78BEA70", VA = "0x1878C0070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x78BFBC0", Offset = "0x78BE5C0", VA = "0x1878BFBC0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x78BFC10", Offset = "0x78BE610", VA = "0x1878BFC10", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x78BFA90", Offset = "0x78BE490", VA = "0x1878BFA90")]
		private JobHandle DCPINNIECKI(GDDJBKFDOPP<ContainerCollisionLayerData_v1> component_58, GHOELHDNJOP<PhysicsModelCollisionLayerData> component_59, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GDDJBKFDOPP<ContainerGrabbableModeData_v1> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public GHOELHDNJOP<PhysicsModelGrabbableModeData> component_63;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x78C1580", Offset = "0x78BFF80", VA = "0x1878C1580")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x78C1870", Offset = "0x78C0270", VA = "0x1878C1870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x78C1290", Offset = "0x78BFC90", VA = "0x1878C1290", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x78C1410", Offset = "0x78BFE10", VA = "0x1878C1410", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x78C12E0", Offset = "0x78BFCE0", VA = "0x1878C12E0")]
		private JobHandle FBJGFIKFDFN(GDDJBKFDOPP<ContainerGrabbableModeData_v1> component_62, GHOELHDNJOP<PhysicsModelGrabbableModeData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GDDJBKFDOPP<ContainerFlagsData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GDDJBKFDOPP<ContainerFlagsData_v2> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public GDDJBKFDOPP<PhysicsModelFlagsData_v3> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GHOELHDNJOP<PhysicsModelFlagsData> component_73;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x78C0B60", Offset = "0x78BF560", VA = "0x1878C0B60")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x78C1230", Offset = "0x78BFC30", VA = "0x1878C1230", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x78C0710", Offset = "0x78BF110", VA = "0x1878C0710", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78C0760", Offset = "0x78BF160", VA = "0x1878C0760", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x78C09C0", Offset = "0x78BF3C0", VA = "0x1878C09C0")]
		private JobHandle GNGOKHAEAMN(GDDJBKFDOPP<ContainerFlagsData_v1> component_70, GDDJBKFDOPP<ContainerFlagsData_v2> component_71, GDDJBKFDOPP<PhysicsModelFlagsData_v3> component_72, GHOELHDNJOP<PhysicsModelFlagsData> component_73, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public GDDJBKFDOPP<ContainerCollisionModeData_v1> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GHOELHDNJOP<PhysicsModelCollisionModeData> component_75;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x78C03C0", Offset = "0x78BEDC0", VA = "0x1878C03C0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x78C06B0", Offset = "0x78BF0B0", VA = "0x1878C06B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x78C00D0", Offset = "0x78BEAD0", VA = "0x1878C00D0", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78C0120", Offset = "0x78BEB20", VA = "0x1878C0120", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78C0290", Offset = "0x78BEC90", VA = "0x1878C0290")]
		private JobHandle HCCCBELKCLA(GDDJBKFDOPP<ContainerCollisionModeData_v1> component_74, GHOELHDNJOP<PhysicsModelCollisionModeData> component_75, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DEKKAHDLANI
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public GDDJBKFDOPP<ObjectPolicyData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GDDJBKFDOPP<ObjectPolicyData_v2> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GDDJBKFDOPP<ObjectPolicyData_v3> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public GDDJBKFDOPP<ObjectPolicyData_v4> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public GDDJBKFDOPP<ObjectPolicyData_v5> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public GHOELHDNJOP<ObjectPolicyData> component_83;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x78BE490", Offset = "0x78BCE90", VA = "0x1878BE490")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x78BF280", Offset = "0x78BDC80", VA = "0x1878BF280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override LMPJBEBLCLM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x78BDF30", Offset = "0x78BC930", VA = "0x1878BDF30", Slot = "14")]
			get
			{
				return default(LMPJBEBLCLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78BDF80", Offset = "0x78BC980", VA = "0x1878BDF80", Slot = "15")]
		protected override void FBONMCAOKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78BE290", Offset = "0x78BCC90", VA = "0x1878BE290")]
		private JobHandle JBDEDKJDDND(GDDJBKFDOPP<ObjectPolicyData_v1> component_78, GDDJBKFDOPP<ObjectPolicyData_v2> component_79, GDDJBKFDOPP<ObjectPolicyData_v3> component_80, GDDJBKFDOPP<ObjectPolicyData_v4> component_81, GDDJBKFDOPP<ObjectPolicyData_v5> component_82, GHOELHDNJOP<ObjectPolicyData> component_83, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class OKFDGMPIPOG
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3820F10", Offset = "0x381F910", VA = "0x183820F10")]
	public static void PBAEEGBGLLC<T, U>(T OCDJAMBMLIK, [Out] U FGHNEGLCMOH) where T : struct where U : struct
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
