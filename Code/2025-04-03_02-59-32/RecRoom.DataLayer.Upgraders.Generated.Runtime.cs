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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OPMJLCGBECG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78382A0", Offset = "0x78376A0", VA = "0x1878382A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78382A0", Offset = "0x78376A0", VA = "0x1878382A0")]
		public static void OOOMEECOMLM(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x783D520", Offset = "0x783C920", VA = "0x18783D520")]
		private void KCKHCFAOFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x783DD70", Offset = "0x783D170", VA = "0x18783DD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x7839A60", Offset = "0x7838E60", VA = "0x187839A60")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7839DA0", Offset = "0x78391A0", VA = "0x187839DA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7839770", Offset = "0x7838B70", VA = "0x187839770", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78397C0", Offset = "0x7838BC0", VA = "0x1878397C0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7839930", Offset = "0x7838D30", VA = "0x187839930")]
		private JobHandle KPFNKKFONDJ(FHJCILOPLOE<PersistentUserTagData_v1> component_1, IKCOLHKCLPG<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
			public FHJCILOPLOE<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IKCOLHKCLPG<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7837920", Offset = "0x7836D20", VA = "0x187837920")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7837C00", Offset = "0x7837000", VA = "0x187837C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7837630", Offset = "0x7836A30", VA = "0x187837630", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7837680", Offset = "0x7836A80", VA = "0x187837680", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78377F0", Offset = "0x7836BF0", VA = "0x1878377F0")]
		private JobHandle HILMDCJHJML(FHJCILOPLOE<LocalDeformableScaleData_v1> component_3, IKCOLHKCLPG<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public FHJCILOPLOE<SerializedDataLayerVersionData_v1> component_11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IKCOLHKCLPG<SerializedDataLayerVersionData> component_12;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x783CB90", Offset = "0x783BF90", VA = "0x18783CB90")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x783CE50", Offset = "0x783C250", VA = "0x18783CE50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783C8A0", Offset = "0x783BCA0", VA = "0x18783C8A0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x783CA20", Offset = "0x783BE20", VA = "0x18783CA20", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x783C8F0", Offset = "0x783BCF0", VA = "0x18783C8F0")]
		private JobHandle EIKLIIGMNPN(FHJCILOPLOE<SerializedDataLayerVersionData_v1> component_11, IKCOLHKCLPG<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
			public FHJCILOPLOE<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IKCOLHKCLPG<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x783C580", Offset = "0x783B980", VA = "0x18783C580")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x783C840", Offset = "0x783BC40", VA = "0x18783C840", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783C290", Offset = "0x783B690", VA = "0x18783C290", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x783C410", Offset = "0x783B810", VA = "0x18783C410", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x783C2E0", Offset = "0x783B6E0", VA = "0x18783C2E0")]
		private JobHandle EFHCHBHMGNK(FHJCILOPLOE<ReplicatorPreallocatedObjectCountData_v1> component_19, IKCOLHKCLPG<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
			public FHJCILOPLOE<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IKCOLHKCLPG<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x783D1A0", Offset = "0x783C5A0", VA = "0x18783D1A0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x783D4C0", Offset = "0x783C8C0", VA = "0x18783D4C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783CEB0", Offset = "0x783C2B0", VA = "0x18783CEB0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x783CF00", Offset = "0x783C300", VA = "0x18783CF00", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x783D070", Offset = "0x783C470", VA = "0x18783D070")]
		private JobHandle HFNEBAAHCLA(FHJCILOPLOE<ToolCleanupStatusData_v1> component_24, IKCOLHKCLPG<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FHJCILOPLOE<ReplicatorData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IKCOLHKCLPG<ReplicatorData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x783BE00", Offset = "0x783B200", VA = "0x18783BE00")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x783C100", Offset = "0x783B500", VA = "0x18783C100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783BC40", Offset = "0x783B040", VA = "0x18783BC40", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x783BC90", Offset = "0x783B090", VA = "0x18783BC90", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x783C110", Offset = "0x783B510", VA = "0x18783C110")]
		private JobHandle NAHDIKONCDG(FHJCILOPLOE<ReplicatorData_v1> component_31, IKCOLHKCLPG<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public FHJCILOPLOE<InventionInstanceIdData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IKCOLHKCLPG<InventionInstanceIdData> component_35;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7837320", Offset = "0x7836720", VA = "0x187837320")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x78375D0", Offset = "0x78369D0", VA = "0x1878375D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7837030", Offset = "0x7836430", VA = "0x187837030", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7837080", Offset = "0x7836480", VA = "0x187837080", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78371F0", Offset = "0x78365F0", VA = "0x1878371F0")]
		private JobHandle FMGJGFMMMOF(FHJCILOPLOE<InventionInstanceIdData_v1> component_34, IKCOLHKCLPG<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FHJCILOPLOE<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IKCOLHKCLPG<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7837F50", Offset = "0x7837350", VA = "0x187837F50")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7838240", Offset = "0x7837640", VA = "0x187838240", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7837C60", Offset = "0x7837060", VA = "0x187837C60", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7837CB0", Offset = "0x78370B0", VA = "0x187837CB0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7837E20", Offset = "0x7837220", VA = "0x187837E20")]
		private JobHandle JDAHDNMAHPB(FHJCILOPLOE<OMShapeContainerData_v1> component_37, IKCOLHKCLPG<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FHJCILOPLOE<ContainerCollisionLayerData_v1> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IKCOLHKCLPG<PhysicsModelCollisionLayerData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7839FC0", Offset = "0x78393C0", VA = "0x187839FC0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x783A2B0", Offset = "0x78396B0", VA = "0x18783A2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7839E00", Offset = "0x7839200", VA = "0x187839E00", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7839E50", Offset = "0x7839250", VA = "0x187839E50", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x783A2C0", Offset = "0x78396C0", VA = "0x18783A2C0")]
		private JobHandle PNAIOLGNFEI(FHJCILOPLOE<ContainerCollisionLayerData_v1> component_54, IKCOLHKCLPG<PhysicsModelCollisionLayerData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public FHJCILOPLOE<ContainerGrabbableModeData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IKCOLHKCLPG<PhysicsModelGrabbableModeData> component_59;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x783B8F0", Offset = "0x783ACF0", VA = "0x18783B8F0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x783BBE0", Offset = "0x783AFE0", VA = "0x18783BBE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783B600", Offset = "0x783AA00", VA = "0x18783B600", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x783B650", Offset = "0x783AA50", VA = "0x18783B650", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x783B7C0", Offset = "0x783ABC0", VA = "0x18783B7C0")]
		private JobHandle KJEEEABMPPJ(FHJCILOPLOE<ContainerGrabbableModeData_v1> component_58, IKCOLHKCLPG<PhysicsModelGrabbableModeData> component_59, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public FHJCILOPLOE<ContainerFlagsData_v1> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public FHJCILOPLOE<ContainerFlagsData_v2> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FHJCILOPLOE<PhysicsModelFlagsData_v3> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public IKCOLHKCLPG<PhysicsModelFlagsData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x783AED0", Offset = "0x783A2D0", VA = "0x18783AED0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x783B5A0", Offset = "0x783A9A0", VA = "0x18783B5A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x783AA80", Offset = "0x7839E80", VA = "0x18783AA80", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x783AAD0", Offset = "0x7839ED0", VA = "0x18783AAD0", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x783AD30", Offset = "0x783A130", VA = "0x18783AD30")]
		private JobHandle LENFFICLBNC(FHJCILOPLOE<ContainerFlagsData_v1> component_65, FHJCILOPLOE<ContainerFlagsData_v2> component_66, FHJCILOPLOE<PhysicsModelFlagsData_v3> component_67, IKCOLHKCLPG<PhysicsModelFlagsData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public FHJCILOPLOE<ContainerCollisionModeData_v1> component_69;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IKCOLHKCLPG<PhysicsModelCollisionModeData> component_70;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x783A600", Offset = "0x7839A00", VA = "0x18783A600")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x783A8F0", Offset = "0x7839CF0", VA = "0x18783A8F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override GBHBOJAPDOA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x783A440", Offset = "0x7839840", VA = "0x18783A440", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x783A490", Offset = "0x7839890", VA = "0x18783A490", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x783A900", Offset = "0x7839D00", VA = "0x18783A900")]
		private JobHandle NDCJDHOFHHL(FHJCILOPLOE<ContainerCollisionModeData_v1> component_69, IKCOLHKCLPG<PhysicsModelCollisionModeData> component_70, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : NENNCPJHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public FHJCILOPLOE<ObjectPolicyData_v1> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public FHJCILOPLOE<ObjectPolicyData_v2> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FHJCILOPLOE<ObjectPolicyData_v3> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public FHJCILOPLOE<ObjectPolicyData_v4> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FHJCILOPLOE<ObjectPolicyData_v5> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public IKCOLHKCLPG<ObjectPolicyData> component_78;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7838720", Offset = "0x7837B20", VA = "0x187838720")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7839510", Offset = "0x7838910", VA = "0x187839510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x78383C0", Offset = "0x78377C0", VA = "0x1878383C0", Slot = "14")]
			get
			{
				return default(GBHBOJAPDOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7838410", Offset = "0x7837810", VA = "0x187838410", Slot = "15")]
		protected override void EJKDABAILNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7839520", Offset = "0x7838920", VA = "0x187839520")]
		private JobHandle ODBOMFAGIHE(FHJCILOPLOE<ObjectPolicyData_v1> component_73, FHJCILOPLOE<ObjectPolicyData_v2> component_74, FHJCILOPLOE<ObjectPolicyData_v3> component_75, FHJCILOPLOE<ObjectPolicyData_v4> component_76, FHJCILOPLOE<ObjectPolicyData_v5> component_77, IKCOLHKCLPG<ObjectPolicyData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class FJNBBJHNBHK
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x35C1210", Offset = "0x35C0610", VA = "0x1835C1210")]
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
