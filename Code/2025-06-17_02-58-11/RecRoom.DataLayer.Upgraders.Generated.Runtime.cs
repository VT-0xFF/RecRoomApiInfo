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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NECKMECLMKA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CFBAD0", Offset = "0x7CFA4D0", VA = "0x187CFBAD0")]
	public static void IKAOKKJJFNB(ComponentSystemGroup AJEELMNCDNB, EntityCommandBufferSystem KDHHDHABEII)
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
		[Cpp2IlInjected.Address(RVA = "0x7CFBAD0", Offset = "0x7CFA4D0", VA = "0x187CFBAD0")]
		public static void IBDEBGMGDKH(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D01390", Offset = "0x7CFFD90", VA = "0x187D01390")]
		private void IKAOKKJJFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D01C80", Offset = "0x7D00680", VA = "0x187D01C80")]
		private void NMBFFHOGGEB(DEKEAIHHHBC system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public ELPNJKNOFMC<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public EHLHOOIMFHG<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7CFD770", Offset = "0x7CFC170", VA = "0x187CFD770")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFD760", Offset = "0x7CFC160", VA = "0x187CFD760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7CFD5E0", Offset = "0x7CFBFE0", VA = "0x187CFD5E0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDAB0", Offset = "0x7CFC4B0", VA = "0x187CFDAB0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD630", Offset = "0x7CFC030", VA = "0x187CFD630")]
		private JobHandle HIJNCLIBIHC(ELPNJKNOFMC<PersistentUserTagData_v1> component_1, EHLHOOIMFHG<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ELPNJKNOFMC<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public EHLHOOIMFHG<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7CFB500", Offset = "0x7CF9F00", VA = "0x187CFB500")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7CFB4F0", Offset = "0x7CF9EF0", VA = "0x187CFB4F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFB4A0", Offset = "0x7CF9EA0", VA = "0x187CFB4A0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB910", Offset = "0x7CFA310", VA = "0x187CFB910", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB7E0", Offset = "0x7CFA1E0", VA = "0x187CFB7E0")]
		private JobHandle OHEHCAHKHDI(ELPNJKNOFMC<LocalDeformableScaleData_v1> component_4, EHLHOOIMFHG<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ELPNJKNOFMC<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public EHLHOOIMFHG<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D008A0", Offset = "0x7CFF2A0", VA = "0x187D008A0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D00890", Offset = "0x7CFF290", VA = "0x187D00890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D00840", Offset = "0x7CFF240", VA = "0x187D00840", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D00B60", Offset = "0x7CFF560", VA = "0x187D00B60", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D00710", Offset = "0x7CFF110", VA = "0x187D00710")]
		private JobHandle BBEEPLHPJOO(ELPNJKNOFMC<SerializedDataLayerVersionData_v1> component_12, EHLHOOIMFHG<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public ELPNJKNOFMC<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EHLHOOIMFHG<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D00290", Offset = "0x7CFEC90", VA = "0x187D00290")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7D00280", Offset = "0x7CFEC80", VA = "0x187D00280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D00100", Offset = "0x7CFEB00", VA = "0x187D00100", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D00550", Offset = "0x7CFEF50", VA = "0x187D00550", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D00150", Offset = "0x7CFEB50", VA = "0x187D00150")]
		private JobHandle GLIHNHEPIIE(ELPNJKNOFMC<ReplicatorPreallocatedObjectCountData_v1> component_20, EHLHOOIMFHG<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ELPNJKNOFMC<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EHLHOOIMFHG<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D00D80", Offset = "0x7CFF780", VA = "0x187D00D80")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D00D70", Offset = "0x7CFF770", VA = "0x187D00D70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7D00D20", Offset = "0x7CFF720", VA = "0x187D00D20", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D011D0", Offset = "0x7CFFBD0", VA = "0x187D011D0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D010A0", Offset = "0x7CFFAA0", VA = "0x187D010A0")]
		private JobHandle MOBEJLICKNG(ELPNJKNOFMC<ToolCleanupStatusData_v1> component_25, EHLHOOIMFHG<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public ELPNJKNOFMC<ReplicatorData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EHLHOOIMFHG<ReplicatorData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFB10", Offset = "0x7CFE510", VA = "0x187CFFB10")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFB00", Offset = "0x7CFE500", VA = "0x187CFFB00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFAB0", Offset = "0x7CFE4B0", VA = "0x187CFFAB0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFF40", Offset = "0x7CFE940", VA = "0x187CFFF40", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFE10", Offset = "0x7CFE810", VA = "0x187CFFE10")]
		private JobHandle MFBKOKNDMJK(ELPNJKNOFMC<ReplicatorData_v1> component_33, EHLHOOIMFHG<ReplicatorData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public ELPNJKNOFMC<InventionInstanceIdData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public EHLHOOIMFHG<InventionInstanceIdData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7CFAF00", Offset = "0x7CF9900", VA = "0x187CFAF00")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFAEF0", Offset = "0x7CF98F0", VA = "0x187CFAEF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7CFAEA0", Offset = "0x7CF98A0", VA = "0x187CFAEA0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB2E0", Offset = "0x7CF9CE0", VA = "0x187CFB2E0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB1B0", Offset = "0x7CF9BB0", VA = "0x187CFB1B0")]
		private JobHandle MFOJOAKFILJ(ELPNJKNOFMC<InventionInstanceIdData_v1> component_37, EHLHOOIMFHG<InventionInstanceIdData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ELPNJKNOFMC<OMShapeContainerData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EHLHOOIMFHG<OMShapeContainerData> component_43;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7CFBD80", Offset = "0x7CFA780", VA = "0x187CFBD80")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7CFBD70", Offset = "0x7CFA770", VA = "0x187CFBD70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFBBF0", Offset = "0x7CFA5F0", VA = "0x187CFBBF0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC070", Offset = "0x7CFAA70", VA = "0x187CFC070", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CFBC40", Offset = "0x7CFA640", VA = "0x187CFBC40")]
		private JobHandle HDKJKKCNLJB(ELPNJKNOFMC<OMShapeContainerData_v1> component_42, EHLHOOIMFHG<OMShapeContainerData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ELPNJKNOFMC<AuthoredAIIdData_v1> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public ELPNJKNOFMC<AuthoredAIIdData_v2> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ELPNJKNOFMC<AuthoredAIIdData_v3> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public EHLHOOIMFHG<AuthoredAIIdData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA4D0", Offset = "0x7CF8ED0", VA = "0x187CFA4D0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA4C0", Offset = "0x7CF8EC0", VA = "0x187CFA4C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA2D0", Offset = "0x7CF8CD0", VA = "0x187CFA2D0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7CFABF0", Offset = "0x7CF95F0", VA = "0x187CFABF0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA320", Offset = "0x7CF8D20", VA = "0x187CFA320")]
		private JobHandle JKGOCJJNOHO(ELPNJKNOFMC<AuthoredAIIdData_v1> component_52, ELPNJKNOFMC<AuthoredAIIdData_v2> component_53, ELPNJKNOFMC<AuthoredAIIdData_v3> component_54, EHLHOOIMFHG<AuthoredAIIdData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ELPNJKNOFMC<ContainerCollisionLayerData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public EHLHOOIMFHG<PhysicsModelCollisionLayerData> component_65;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7CFDE00", Offset = "0x7CFC800", VA = "0x187CFDE00")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7CFDDF0", Offset = "0x7CFC7F0", VA = "0x187CFDDF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFDC70", Offset = "0x7CFC670", VA = "0x187CFDC70", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE0F0", Offset = "0x7CFCAF0", VA = "0x187CFE0F0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDCC0", Offset = "0x7CFC6C0", VA = "0x187CFDCC0")]
		private JobHandle EGNIALOEKBL(ELPNJKNOFMC<ContainerCollisionLayerData_v1> component_64, EHLHOOIMFHG<PhysicsModelCollisionLayerData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public ELPNJKNOFMC<ContainerGrabbableModeData_v1> component_68;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public EHLHOOIMFHG<PhysicsModelGrabbableModeData> component_69;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7CFF4D0", Offset = "0x7CFDED0", VA = "0x187CFF4D0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFF4C0", Offset = "0x7CFDEC0", VA = "0x187CFF4C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7CFF470", Offset = "0x7CFDE70", VA = "0x187CFF470", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF8F0", Offset = "0x7CFE2F0", VA = "0x187CFF8F0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF7C0", Offset = "0x7CFE1C0", VA = "0x187CFF7C0")]
		private JobHandle OAFNHJBEELD(ELPNJKNOFMC<ContainerGrabbableModeData_v1> component_68, EHLHOOIMFHG<PhysicsModelGrabbableModeData> component_69, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ELPNJKNOFMC<ContainerFlagsData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public ELPNJKNOFMC<ContainerFlagsData_v2> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public ELPNJKNOFMC<PhysicsModelFlagsData_v3> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public EHLHOOIMFHG<PhysicsModelFlagsData> component_78;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE950", Offset = "0x7CFD350", VA = "0x187CFE950")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE940", Offset = "0x7CFD340", VA = "0x187CFE940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE8F0", Offset = "0x7CFD2F0", VA = "0x187CFE8F0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF1C0", Offset = "0x7CFDBC0", VA = "0x187CFF1C0", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF020", Offset = "0x7CFDA20", VA = "0x187CFF020")]
		private JobHandle OKLPFNKGCFD(ELPNJKNOFMC<ContainerFlagsData_v1> component_75, ELPNJKNOFMC<ContainerFlagsData_v2> component_76, ELPNJKNOFMC<PhysicsModelFlagsData_v3> component_77, EHLHOOIMFHG<PhysicsModelFlagsData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ELPNJKNOFMC<ContainerCollisionModeData_v1> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public EHLHOOIMFHG<PhysicsModelCollisionModeData> component_80;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE440", Offset = "0x7CFCE40", VA = "0x187CFE440")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE430", Offset = "0x7CFCE30", VA = "0x187CFE430", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE2B0", Offset = "0x7CFCCB0", VA = "0x187CFE2B0", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE730", Offset = "0x7CFD130", VA = "0x187CFE730", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE300", Offset = "0x7CFCD00", VA = "0x187CFE300")]
		private JobHandle GJNPGIOIINL(ELPNJKNOFMC<ContainerCollisionModeData_v1> component_79, EHLHOOIMFHG<PhysicsModelCollisionModeData> component_80, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DEKEAIHHHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public ELPNJKNOFMC<ObjectPolicyData_v1> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ELPNJKNOFMC<ObjectPolicyData_v2> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public ELPNJKNOFMC<ObjectPolicyData_v3> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ELPNJKNOFMC<ObjectPolicyData_v4> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ELPNJKNOFMC<ObjectPolicyData_v5> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public EHLHOOIMFHG<ObjectPolicyData> component_88;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7CFC290", Offset = "0x7CFAC90", VA = "0x187CFC290")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7CFC280", Offset = "0x7CFAC80", VA = "0x187CFC280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly COJJKFBGGKB log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override COJJKFBGGKB Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7CFC230", Offset = "0x7CFAC30", VA = "0x187CFC230", Slot = "14")]
			get
			{
				return default(COJJKFBGGKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD280", Offset = "0x7CFBC80", VA = "0x187CFD280", Slot = "15")]
		protected override void PGCLMIIADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD080", Offset = "0x7CFBA80", VA = "0x187CFD080")]
		private JobHandle MMDKLHLPCDC(ELPNJKNOFMC<ObjectPolicyData_v1> component_83, ELPNJKNOFMC<ObjectPolicyData_v2> component_84, ELPNJKNOFMC<ObjectPolicyData_v3> component_85, ELPNJKNOFMC<ObjectPolicyData_v4> component_86, ELPNJKNOFMC<ObjectPolicyData_v5> component_87, EHLHOOIMFHG<ObjectPolicyData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class JEIHHJMGLGC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFC50", Offset = "0x3ABE650", VA = "0x183ABFC50")]
	public static void PEPGPNGFBBO<T, U>(T NGEPLLLPPCI, [Out] U OECIMOKICEB) where T : struct where U : struct
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
