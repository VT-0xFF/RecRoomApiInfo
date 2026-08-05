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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OIADLEFMEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82582A0", Offset = "0x82576A0", VA = "0x1882582A0")]
	public static void KMKCMOMHKCF(ComponentSystemGroup JFINDLBKLHM, EntityCommandBufferSystem LHJOGJKGIBM)
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
		[Cpp2IlInjected.Address(RVA = "0x82582A0", Offset = "0x82576A0", VA = "0x1882582A0")]
		public static void CGMFENMNFAJ(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x825E360", Offset = "0x825D760", VA = "0x18825E360")]
		private void KMKCMOMHKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x825E2D0", Offset = "0x825D6D0", VA = "0x18825E2D0")]
		private void IKPDIPNNDDF(EIIFKDGBDLP system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LNHOHBJGLHB<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IPOKOGEHPPL<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8259F80", Offset = "0x8259380", VA = "0x188259F80")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8259F70", Offset = "0x8259370", VA = "0x188259F70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8259DB0", Offset = "0x82591B0", VA = "0x188259DB0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8259E00", Offset = "0x8259200", VA = "0x188259E00", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x825A2C0", Offset = "0x82596C0", VA = "0x18825A2C0")]
		private JobHandle PKGOGNBFKMK(LNHOHBJGLHB<PersistentUserTagData_v1> component_1, IPOKOGEHPPL<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LNHOHBJGLHB<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IPOKOGEHPPL<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8257F70", Offset = "0x8257370", VA = "0x188257F70")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8257F60", Offset = "0x8257360", VA = "0x188257F60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8257C70", Offset = "0x8257070", VA = "0x188257C70", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8257CC0", Offset = "0x82570C0", VA = "0x188257CC0", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8257E30", Offset = "0x8257230", VA = "0x188257E30")]
		private JobHandle HAABOLMLECL(LNHOHBJGLHB<LocalDeformableScaleData_v1> component_4, IPOKOGEHPPL<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LNHOHBJGLHB<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IPOKOGEHPPL<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x825D1E0", Offset = "0x825C5E0", VA = "0x18825D1E0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x825D1D0", Offset = "0x825C5D0", VA = "0x18825D1D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x825CEE0", Offset = "0x825C2E0", VA = "0x18825CEE0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x825D060", Offset = "0x825C460", VA = "0x18825D060", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x825CF30", Offset = "0x825C330", VA = "0x18825CF30")]
		private JobHandle GLLCIEKOBOJ(LNHOHBJGLHB<SerializedDataLayerVersionData_v1> component_15, IPOKOGEHPPL<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LNHOHBJGLHB<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IPOKOGEHPPL<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x825CBD0", Offset = "0x825BFD0", VA = "0x18825CBD0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x825CBC0", Offset = "0x825BFC0", VA = "0x18825CBC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x825C8D0", Offset = "0x825BCD0", VA = "0x18825C8D0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x825CA50", Offset = "0x825BE50", VA = "0x18825CA50", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x825C920", Offset = "0x825BD20", VA = "0x18825C920")]
		private JobHandle CMKAAMEIEFF(LNHOHBJGLHB<ReplicatorPreallocatedObjectCountData_v1> component_23, IPOKOGEHPPL<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LNHOHBJGLHB<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IPOKOGEHPPL<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x825DF60", Offset = "0x825D360", VA = "0x18825DF60")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x825DF50", Offset = "0x825D350", VA = "0x18825DF50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x825DC60", Offset = "0x825D060", VA = "0x18825DC60", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x825DDE0", Offset = "0x825D1E0", VA = "0x18825DDE0", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x825DCB0", Offset = "0x825D0B0", VA = "0x18825DCB0")]
		private JobHandle DNMDMBHMIDO(LNHOHBJGLHB<ToolCleanupStatusData_v1> component_28, IPOKOGEHPPL<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LNHOHBJGLHB<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IPOKOGEHPPL<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x825D7F0", Offset = "0x825CBF0", VA = "0x18825D7F0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x825D7E0", Offset = "0x825CBE0", VA = "0x18825D7E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x825D4F0", Offset = "0x825C8F0", VA = "0x18825D4F0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x825D670", Offset = "0x825CA70", VA = "0x18825D670", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x825D540", Offset = "0x825C940", VA = "0x18825D540")]
		private JobHandle DJEJIHLMEIO(LNHOHBJGLHB<TerrainGenerationData_v1> component_31, IPOKOGEHPPL<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LNHOHBJGLHB<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IPOKOGEHPPL<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x825C580", Offset = "0x825B980", VA = "0x18825C580")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x825C570", Offset = "0x825B970", VA = "0x18825C570", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x825C280", Offset = "0x825B680", VA = "0x18825C280", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x825C400", Offset = "0x825B800", VA = "0x18825C400", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x825C2D0", Offset = "0x825B6D0", VA = "0x18825C2D0")]
		private JobHandle CJOLFGJMABE(LNHOHBJGLHB<ReplicatorData_v1> component_39, IPOKOGEHPPL<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LNHOHBJGLHB<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IPOKOGEHPPL<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8257970", Offset = "0x8256D70", VA = "0x188257970")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8257960", Offset = "0x8256D60", VA = "0x188257960", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8257670", Offset = "0x8256A70", VA = "0x188257670", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82577F0", Offset = "0x8256BF0", VA = "0x1882577F0", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82576C0", Offset = "0x8256AC0", VA = "0x1882576C0")]
		private JobHandle CDGAININJFP(LNHOHBJGLHB<InventionInstanceIdData_v1> component_43, IPOKOGEHPPL<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LNHOHBJGLHB<OMShapeContainerData_v1> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IPOKOGEHPPL<OMShapeContainerData> component_50;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82586C0", Offset = "0x8257AC0", VA = "0x1882586C0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82586B0", Offset = "0x8257AB0", VA = "0x1882586B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82583C0", Offset = "0x82577C0", VA = "0x1882583C0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8258410", Offset = "0x8257810", VA = "0x188258410", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8258580", Offset = "0x8257980", VA = "0x188258580")]
		private JobHandle JMDDOKKBHGF(LNHOHBJGLHB<OMShapeContainerData_v1> component_49, IPOKOGEHPPL<OMShapeContainerData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LNHOHBJGLHB<AuthoredAIIdData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LNHOHBJGLHB<AuthoredAIIdData_v2> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LNHOHBJGLHB<AuthoredAIIdData_v3> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IPOKOGEHPPL<AuthoredAIIdData> component_62;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8256F00", Offset = "0x8256300", VA = "0x188256F00")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8256EF0", Offset = "0x82562F0", VA = "0x188256EF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8256AA0", Offset = "0x8255EA0", VA = "0x188256AA0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8256AF0", Offset = "0x8255EF0", VA = "0x188256AF0", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8256D50", Offset = "0x8256150", VA = "0x188256D50")]
		private JobHandle JPEELDDAJBM(LNHOHBJGLHB<AuthoredAIIdData_v1> component_59, LNHOHBJGLHB<AuthoredAIIdData_v2> component_60, LNHOHBJGLHB<AuthoredAIIdData_v3> component_61, IPOKOGEHPPL<AuthoredAIIdData> component_62, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LNHOHBJGLHB<ContainerCollisionLayerData_v1> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public IPOKOGEHPPL<PhysicsModelCollisionLayerData> component_73;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x825A740", Offset = "0x8259B40", VA = "0x18825A740")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x825A730", Offset = "0x8259B30", VA = "0x18825A730", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x825A440", Offset = "0x8259840", VA = "0x18825A440", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x825A490", Offset = "0x8259890", VA = "0x18825A490", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x825A600", Offset = "0x8259A00", VA = "0x18825A600")]
		private JobHandle GMJLKLPCHEN(LNHOHBJGLHB<ContainerCollisionLayerData_v1> component_72, IPOKOGEHPPL<PhysicsModelCollisionLayerData> component_73, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LNHOHBJGLHB<ContainerGrabbableModeData_v1> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IPOKOGEHPPL<PhysicsModelGrabbableModeData> component_78;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x825BF40", Offset = "0x825B340", VA = "0x18825BF40")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x825BF30", Offset = "0x825B330", VA = "0x18825BF30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x825BC40", Offset = "0x825B040", VA = "0x18825BC40", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x825BC90", Offset = "0x825B090", VA = "0x18825BC90", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x825BE00", Offset = "0x825B200", VA = "0x18825BE00")]
		private JobHandle LLADFIBPAPI(LNHOHBJGLHB<ContainerGrabbableModeData_v1> component_77, IPOKOGEHPPL<PhysicsModelGrabbableModeData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LNHOHBJGLHB<ContainerFlagsData_v1> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LNHOHBJGLHB<ContainerFlagsData_v2> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LNHOHBJGLHB<PhysicsModelFlagsData_v3> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IPOKOGEHPPL<PhysicsModelFlagsData> component_87;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x825B520", Offset = "0x825A920", VA = "0x18825B520")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x825B510", Offset = "0x825A910", VA = "0x18825B510", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x825B0C0", Offset = "0x825A4C0", VA = "0x18825B0C0", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x825B110", Offset = "0x825A510", VA = "0x18825B110", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x825B370", Offset = "0x825A770", VA = "0x18825B370")]
		private JobHandle HNFNCGOLHFH(LNHOHBJGLHB<ContainerFlagsData_v1> component_84, LNHOHBJGLHB<ContainerFlagsData_v2> component_85, LNHOHBJGLHB<PhysicsModelFlagsData_v3> component_86, IPOKOGEHPPL<PhysicsModelFlagsData> component_87, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public LNHOHBJGLHB<ContainerCollisionModeData_v1> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public IPOKOGEHPPL<PhysicsModelCollisionModeData> component_89;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x825AD80", Offset = "0x825A180", VA = "0x18825AD80")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x825AD70", Offset = "0x825A170", VA = "0x18825AD70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x825AA80", Offset = "0x8259E80", VA = "0x18825AA80", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x825AC00", Offset = "0x825A000", VA = "0x18825AC00", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x825AAD0", Offset = "0x8259ED0", VA = "0x18825AAD0")]
		private JobHandle FPGNFALHGKL(LNHOHBJGLHB<ContainerCollisionModeData_v1> component_88, IPOKOGEHPPL<PhysicsModelCollisionModeData> component_89, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : EIIFKDGBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public LNHOHBJGLHB<ObjectPolicyData_v1> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public LNHOHBJGLHB<ObjectPolicyData_v2> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public LNHOHBJGLHB<ObjectPolicyData_v3> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public LNHOHBJGLHB<ObjectPolicyData_v4> component_95;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public LNHOHBJGLHB<ObjectPolicyData_v5> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IPOKOGEHPPL<ObjectPolicyData> component_97;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8258F70", Offset = "0x8258370", VA = "0x188258F70")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8258F60", Offset = "0x8258360", VA = "0x188258F60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly AKNCNLDICPO log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override AKNCNLDICPO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8258A00", Offset = "0x8257E00", VA = "0x188258A00", Slot = "14")]
			get
			{
				return default(AKNCNLDICPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8258C50", Offset = "0x8258050", VA = "0x188258C50", Slot = "15")]
		protected override void GMCBLONFMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8258A50", Offset = "0x8257E50", VA = "0x188258A50")]
		private JobHandle CPNKIFPMHMJ(LNHOHBJGLHB<ObjectPolicyData_v1> component_92, LNHOHBJGLHB<ObjectPolicyData_v2> component_93, LNHOHBJGLHB<ObjectPolicyData_v3> component_94, LNHOHBJGLHB<ObjectPolicyData_v4> component_95, LNHOHBJGLHB<ObjectPolicyData_v5> component_96, IPOKOGEHPPL<ObjectPolicyData> component_97, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class JOHPDNFOAID
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D56670", Offset = "0x3D55A70", VA = "0x183D56670")]
	public static void LNLDLPOLHLP<T, U>(T AANJFBMPELD, [Out] U GEGOFMKNEED) where T : struct where U : struct
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
