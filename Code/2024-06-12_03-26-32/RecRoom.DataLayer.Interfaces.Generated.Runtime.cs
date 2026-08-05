using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.Foundation;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : IPFMOKLMBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CKEMOIBJBPA bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14CFF50", Offset = "0x14CEB50", VA = "0x1814CFF50", Slot = "5")]
		public override void JGJIGEFNIIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x688FAB0", Offset = "0x688E6B0", VA = "0x18688FAB0")]
		private void MNGJLCJEIMO(FKPMNNCCCMF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x688FA50", Offset = "0x688E650", VA = "0x18688FA50", Slot = "6")]
		public override void GILNKLKCLKE(FKPMNNCCCMF registry, [In] OLGFJANFKOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
		public override void NFNLBHNCOKJ(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x688FD30", Offset = "0x688E930", VA = "0x18688FD30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x688B180", Offset = "0x6889D80", VA = "0x18688B180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Preserve]
	public class OverrideObjectNetworkIdDataProperties : HEFJBGLFEKL<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly GAFGIJDLHMM<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x68810E0", Offset = "0x687FCE0", VA = "0x1868810E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly DAMPAIGLGJK<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x688B030", Offset = "0x6889C30", VA = "0x18688B030")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override OverrideObjectNetworkIdDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x688B5F0", Offset = "0x688A1F0", VA = "0x18688B5F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : HEFJBGLFEKL<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly GAFGIJDLHMM<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly GAFGIJDLHMM<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6881260", Offset = "0x687FE60", VA = "0x186881260")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DAMPAIGLGJK<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly DAMPAIGLGJK<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x688B410", Offset = "0x688A010", VA = "0x18688B410")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override PersistentUserTagDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::DBBCAOEPLAO]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::BPFJPAPNAML(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6880770", Offset = "0x687F370", VA = "0x186880770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : HEFJBGLFEKL<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly GAFGIJDLHMM<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6882DE0", Offset = "0x68819E0", VA = "0x186882DE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DAMPAIGLGJK<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6880620", Offset = "0x687F220", VA = "0x186880620")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override LocalDeformableScaleDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[global::DBBCAOEPLAO]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::BPFJPAPNAML(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x688DFC0", Offset = "0x688CBC0", VA = "0x18688DFC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x688E060", Offset = "0x688CC60", VA = "0x18688E060")]
		public float3 INEGFDPOIDJ()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x688E0E0", Offset = "0x688CCE0", VA = "0x18688E0E0")]
		public bool OCDLKGGEOPK(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointScaleDataProperties : HEFJBGLFEKL<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly GAFGIJDLHMM<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6882110", Offset = "0x6880D10", VA = "0x186882110")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly DAMPAIGLGJK<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x688DE70", Offset = "0x688CA70", VA = "0x18688DE70")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplinePointScaleDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6880BE0", Offset = "0x687F7E0", VA = "0x186880BE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : HEFJBGLFEKL<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly GAFGIJDLHMM<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6882210", Offset = "0x6880E10", VA = "0x186882210")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly DAMPAIGLGJK<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6880A90", Offset = "0x687F690", VA = "0x186880A90")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override LocalUniformScaleDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEnabledDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterEnabledDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68801A0", Offset = "0x687EDA0", VA = "0x1868801A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterEnabledDataWrapper(Entity entity, InteractionFilterEnabledDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterEnabledDataProperties : HEFJBGLFEKL<InteractionFilterEnabledDataWrapper, InteractionFilterEnabledData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly GAFGIJDLHMM<JKBEILLLHJC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6881840", Offset = "0x6880440", VA = "0x186881840")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly DAMPAIGLGJK<JKBEILLLHJC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6880050", Offset = "0x687EC50", VA = "0x186880050")]
		public InteractionFilterEnabledDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterEnabledDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterEnabledDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupReferenceBufferWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ReferenceGroupReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x688C2B0", Offset = "0x688AEB0", VA = "0x18688C2B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReferenceGroupReferenceBufferWrapper(Entity entity, ReferenceGroupReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupReferenceBufferProperties : MAKCNOCIJBP<ReferenceGroupReferenceBufferWrapper, ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly GAFGIJDLHMM<Entity> reference;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6882530", Offset = "0x6881130", VA = "0x186882530")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly MDCGHBGCMAO<ReferenceGroupReferenceBuffer, Entity> reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x688C160", Offset = "0x688AD60", VA = "0x18688C160")]
		public ReferenceGroupReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReferenceGroupReferenceBufferWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReferenceGroupReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct UserTagReferenceBufferWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly UserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x688F9B0", Offset = "0x688E5B0", VA = "0x18688F9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal UserTagReferenceBufferWrapper(Entity entity, UserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagReferenceBufferProperties : MAKCNOCIJBP<UserTagReferenceBufferWrapper, UserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly GAFGIJDLHMM<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x68818C0", Offset = "0x68804C0", VA = "0x1868818C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly MDCGHBGCMAO<UserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x688F860", Offset = "0x688E460", VA = "0x18688F860")]
		public UserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override UserTagReferenceBufferWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(UserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x687FFB0", Offset = "0x687EBB0", VA = "0x18687FFB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterDataProperties : HEFJBGLFEKL<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly GAFGIJDLHMM<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly GAFGIJDLHMM<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly GAFGIJDLHMM<JKBEILLLHJC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x68813B0", Offset = "0x687FFB0", VA = "0x1868813B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly DAMPAIGLGJK<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly DAMPAIGLGJK<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly DAMPAIGLGJK<JKBEILLLHJC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x687FD40", Offset = "0x687E940", VA = "0x18687FD40")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6872150", Offset = "0x6870D50", VA = "0x186872150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : HEFJBGLFEKL<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly GAFGIJDLHMM<AOOPCPDDDIN> version;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6881060", Offset = "0x687FC60", VA = "0x186881060")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly DAMPAIGLGJK<AOOPCPDDDIN> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6872000", Offset = "0x6870C00", VA = "0x186872000")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ComponentSerializedVersionDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupOwnerDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ReferenceGroupOwnerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x688C0C0", Offset = "0x688ACC0", VA = "0x18688C0C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReferenceGroupOwnerDataWrapper(Entity entity, ReferenceGroupOwnerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupOwnerDataProperties : HEFJBGLFEKL<ReferenceGroupOwnerDataWrapper, ReferenceGroupOwnerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly GAFGIJDLHMM<Entity> owner;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6881A40", Offset = "0x6880640", VA = "0x186881A40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly DAMPAIGLGJK<Entity> owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x688BF70", Offset = "0x688AB70", VA = "0x18688BF70")]
		public ReferenceGroupOwnerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReferenceGroupOwnerDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReferenceGroupOwnerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct MakerPenHeldDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly MakerPenHeldDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6880DD0", Offset = "0x687F9D0", VA = "0x186880DD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal MakerPenHeldDataWrapper(Entity entity, MakerPenHeldDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6880E70", Offset = "0x687FA70", VA = "0x186880E70")]
		public bool LKEBBDFLJJI(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[Preserve]
	public class MakerPenHeldDataProperties : HEFJBGLFEKL<MakerPenHeldDataWrapper, MakerPenHeldData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly GAFGIJDLHMM<bool> makerPenHeld;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68817C0", Offset = "0x68803C0", VA = "0x1868817C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly DAMPAIGLGJK<bool> makerPenHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6880C80", Offset = "0x687F880", VA = "0x186880C80")]
		public MakerPenHeldDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override MakerPenHeldDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(MakerPenHeldDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x688EF30", Offset = "0x688DB30", VA = "0x18688EF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x688F090", Offset = "0x688DC90", VA = "0x18688F090")]
		public float IADIEDIAJDC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x688EFD0", Offset = "0x688DBD0", VA = "0x18688EFD0")]
		public bool HCEPHMDIAPL(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x688F030", Offset = "0x688DC30", VA = "0x18688F030")]
		public CCFEJMHLJNL HPIGCJIICFJ()
		{
			return default(CCFEJMHLJNL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x688EE80", Offset = "0x688DA80", VA = "0x18688EE80")]
		public void DJBECMIMKKI(CCFEJMHLJNL flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupSettingsDataProperties : HEFJBGLFEKL<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly GAFGIJDLHMM<float> delay;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly GAFGIJDLHMM<CCFEJMHLJNL> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6880F90", Offset = "0x687FB90", VA = "0x186880F90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly DAMPAIGLGJK<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DAMPAIGLGJK<CCFEJMHLJNL> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x688ECA0", Offset = "0x688D8A0", VA = "0x18688ECA0")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ToolCleanupSettingsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x688D540", Offset = "0x688C140", VA = "0x18688D540", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x688D5E0", Offset = "0x688C1E0", VA = "0x18688D5E0")]
		public bool KACJPJKMGKG(CBNCODLAAAJ value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointOrderDataProperties : HEFJBGLFEKL<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly GAFGIJDLHMM<CBNCODLAAAJ> order;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6882EE0", Offset = "0x6881AE0", VA = "0x186882EE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly DAMPAIGLGJK<CBNCODLAAAJ> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x688D3F0", Offset = "0x688BFF0", VA = "0x18688D3F0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplinePointOrderDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x687F640", Offset = "0x687E240", VA = "0x18687F640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : HEFJBGLFEKL<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly GAFGIJDLHMM<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x68819C0", Offset = "0x68805C0", VA = "0x1868819C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly DAMPAIGLGJK<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x687F4F0", Offset = "0x687E0F0", VA = "0x18687F4F0")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override CostumePieceSlotIndexDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68809F0", Offset = "0x687F5F0", VA = "0x1868809F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : HEFJBGLFEKL<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly GAFGIJDLHMM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly GAFGIJDLHMM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6882460", Offset = "0x6881060", VA = "0x186882460")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly DAMPAIGLGJK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly DAMPAIGLGJK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6880810", Offset = "0x687F410", VA = "0x186880810")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override LocalPoseDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x688C4A0", Offset = "0x688B0A0", VA = "0x18688C4A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : HEFJBGLFEKL<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly GAFGIJDLHMM<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6882780", Offset = "0x6881380", VA = "0x186882780")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly DAMPAIGLGJK<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x688C350", Offset = "0x688AF50", VA = "0x18688C350")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct ReplicatorPreallocatedObjectCountDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ReplicatorPreallocatedObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x688CC60", Offset = "0x688B860", VA = "0x18688CC60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReplicatorPreallocatedObjectCountDataWrapper(Entity entity, ReplicatorPreallocatedObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorPreallocatedObjectCountDataProperties : HEFJBGLFEKL<ReplicatorPreallocatedObjectCountDataWrapper, ReplicatorPreallocatedObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly GAFGIJDLHMM<int> preallocatedCopies;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6882190", Offset = "0x6880D90", VA = "0x186882190")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly DAMPAIGLGJK<int> preallocatedCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x688CB10", Offset = "0x688B710", VA = "0x18688CB10")]
		public ReplicatorPreallocatedObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReplicatorPreallocatedObjectCountDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReplicatorPreallocatedObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[global::DBBCAOEPLAO]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::BPFJPAPNAML(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x688DCF0", Offset = "0x688C8F0", VA = "0x18688DCF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x688DE00", Offset = "0x688CA00", VA = "0x18688DE00")]
		public quaternion ILCEDCALGHA()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x688DD90", Offset = "0x688C990", VA = "0x18688DD90")]
		public bool GOEEBONCFBA(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointRotationDataProperties : HEFJBGLFEKL<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly GAFGIJDLHMM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68815C0", Offset = "0x68801C0", VA = "0x1868815C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly DAMPAIGLGJK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x688DBA0", Offset = "0x688C7A0", VA = "0x18688DBA0")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplinePointRotationDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAllTagsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly InteractionFilterAllTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x687FAB0", Offset = "0x687E6B0", VA = "0x18687FAB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterAllTagsDataWrapper(Entity entity, InteractionFilterAllTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterAllTagsDataProperties : HEFJBGLFEKL<InteractionFilterAllTagsDataWrapper, InteractionFilterAllTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly GAFGIJDLHMM<Entity> allTags;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6881740", Offset = "0x6880340", VA = "0x186881740")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly DAMPAIGLGJK<Entity> allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x687F960", Offset = "0x687E560", VA = "0x18687F960")]
		public InteractionFilterAllTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterAllTagsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterAllTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x688F350", Offset = "0x688DF50", VA = "0x18688F350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : HEFJBGLFEKL<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly GAFGIJDLHMM<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public static readonly GAFGIJDLHMM<bool> forceCleanup;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly GAFGIJDLHMM<bool> cleanupDone;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6881CC0", Offset = "0x68808C0", VA = "0x186881CC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly DAMPAIGLGJK<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly DAMPAIGLGJK<bool> forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly DAMPAIGLGJK<bool> cleanupDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x688F0F0", Offset = "0x688DCF0", VA = "0x18688F0F0")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ToolCleanupStatusDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAnyTagsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly InteractionFilterAnyTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x687FCA0", Offset = "0x687E8A0", VA = "0x18687FCA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterAnyTagsDataWrapper(Entity entity, InteractionFilterAnyTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterAnyTagsDataProperties : HEFJBGLFEKL<InteractionFilterAnyTagsDataWrapper, InteractionFilterAnyTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly GAFGIJDLHMM<Entity> anyTags;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6881640", Offset = "0x6880240", VA = "0x186881640")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly DAMPAIGLGJK<Entity> anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x687FB50", Offset = "0x687E750", VA = "0x18687FB50")]
		public InteractionFilterAnyTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterAnyTagsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterAnyTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x688DA90", Offset = "0x688C690", VA = "0x18688DA90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x688DA10", Offset = "0x688C610", VA = "0x18688DA10")]
		public float3 EPGNGKHHACA()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x688DB30", Offset = "0x688C730", VA = "0x18688DB30")]
		public bool KAODHAGFBKD(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : HEFJBGLFEKL<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly GAFGIJDLHMM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6881160", Offset = "0x687FD60", VA = "0x186881160")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly DAMPAIGLGJK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x688D8C0", Offset = "0x688C4C0", VA = "0x18688D8C0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplinePointPositionDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IFAAMIPBLNN shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x688D100", Offset = "0x688BD00", VA = "0x18688D100")]
			get
			{
				return default(IFAAMIPBLNN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x688D160", Offset = "0x688BD60", VA = "0x18688D160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : HEFJBGLFEKL<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly GAFGIJDLHMM<IFAAMIPBLNN> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6881EC0", Offset = "0x6880AC0", VA = "0x186881EC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly DAMPAIGLGJK<IFAAMIPBLNN> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x688CFB0", Offset = "0x688BBB0", VA = "0x18688CFB0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ShapeTypeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IPMKGJBCEGN shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x688BC20", Offset = "0x688A820", VA = "0x18688BC20")]
			get
			{
				return default(IPMKGJBCEGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x688BC80", Offset = "0x688A880", VA = "0x18688BC80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x688BD20", Offset = "0x688A920", VA = "0x18688BD20")]
		public IPMKGJBCEGN KKHCKCCGLDF()
		{
			return default(IPMKGJBCEGN);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : HEFJBGLFEKL<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly GAFGIJDLHMM<IPMKGJBCEGN> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6882090", Offset = "0x6880C90", VA = "0x186882090")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly DAMPAIGLGJK<IPMKGJBCEGN> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x688BAD0", Offset = "0x688A6D0", VA = "0x18688BAD0")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override PrimitiveShapeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x688C880", Offset = "0x688B480", VA = "0x18688C880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorDataProperties : HEFJBGLFEKL<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public static readonly GAFGIJDLHMM<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6882C10", Offset = "0x6881810", VA = "0x186882C10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly DAMPAIGLGJK<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x688C730", Offset = "0x688B330", VA = "0x18688C730")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReplicatorDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x688BA30", Offset = "0x688A630", VA = "0x18688BA30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[Preserve]
	public class PlayerScopeDataProperties : HEFJBGLFEKL<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public static readonly GAFGIJDLHMM<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6881540", Offset = "0x6880140", VA = "0x186881540")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly DAMPAIGLGJK<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x688B8E0", Offset = "0x688A4E0", VA = "0x18688B8E0")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override PlayerScopeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x687F8C0", Offset = "0x687E4C0", VA = "0x18687F8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[Preserve]
	public class EntityBundlePartDataProperties : HEFJBGLFEKL<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly GAFGIJDLHMM<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly GAFGIJDLHMM<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x68825B0", Offset = "0x68811B0", VA = "0x1868825B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly DAMPAIGLGJK<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly DAMPAIGLGJK<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x687F6E0", Offset = "0x687E2E0", VA = "0x18687F6E0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override EntityBundlePartDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x688C690", Offset = "0x688B290", VA = "0x18688C690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectOwnedByPlayerDataProperties : HEFJBGLFEKL<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public static readonly GAFGIJDLHMM<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6882A40", Offset = "0x6881640", VA = "0x186882A40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly DAMPAIGLGJK<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x688C540", Offset = "0x688B140", VA = "0x18688C540")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x688A670", Offset = "0x6889270", VA = "0x18688A670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	[Preserve]
	public class OMShapeContainerDataProperties : HEFJBGLFEKL<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly GAFGIJDLHMM<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly GAFGIJDLHMM<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6880ED0", Offset = "0x687FAD0", VA = "0x186880ED0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly DAMPAIGLGJK<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly DAMPAIGLGJK<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x688A4A0", Offset = "0x68890A0", VA = "0x18688A4A0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override OMShapeContainerDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[global::DBBCAOEPLAO]
	[CompilerGenerated]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[global::BPFJPAPNAML(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[global::BPFJPAPNAML(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[global::BPFJPAPNAML(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6871D70", Offset = "0x6870970", VA = "0x186871D70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredParentDataProperties : HEFJBGLFEKL<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly GAFGIJDLHMM<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6882880", Offset = "0x6881480", VA = "0x186882880")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly DAMPAIGLGJK<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6871C20", Offset = "0x6870820", VA = "0x186871C20")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override AuthoredParentDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	public readonly struct UserTagNameDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly UserTagNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x688F7C0", Offset = "0x688E3C0", VA = "0x18688F7C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal UserTagNameDataWrapper(Entity entity, UserTagNameDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagNameDataProperties : HEFJBGLFEKL<UserTagNameDataWrapper, UserTagNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly GAFGIJDLHMM<FixedString32Bytes> Value;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6882700", Offset = "0x6881300", VA = "0x186882700")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly DAMPAIGLGJK<FixedString32Bytes> Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x688F670", Offset = "0x688E270", VA = "0x18688F670")]
		public UserTagNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override UserTagNameDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(UserTagNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68831B0", Offset = "0x6881DB0", VA = "0x1868831B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6883250", Offset = "0x6881E50", VA = "0x186883250")]
		public MEGLICJNLED GNIOKLPBCPC()
		{
			return default(MEGLICJNLED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68832B0", Offset = "0x6881EB0", VA = "0x1868832B0")]
		public bool PDMCABLFBLL(MEGLICJNLED value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : HEFJBGLFEKL<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly GAFGIJDLHMM<MEGLICJNLED> mode;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x68823E0", Offset = "0x6880FE0", VA = "0x1868823E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly DAMPAIGLGJK<MEGLICJNLED> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6883060", Offset = "0x6881C60", VA = "0x186883060")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override NavMeshGenerationDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x687F1F0", Offset = "0x687DDF0", VA = "0x18687F1F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x687F160", Offset = "0x687DD60", VA = "0x18687F160")]
		public FixedString64Bytes DBIBPAPBOLM()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x687F290", Offset = "0x687DE90", VA = "0x18687F290")]
		public bool FMGDEHCLGHC(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : HEFJBGLFEKL<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly GAFGIJDLHMM<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6882900", Offset = "0x6881500", VA = "0x186882900")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly DAMPAIGLGJK<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x687F010", Offset = "0x687DC10", VA = "0x18687F010")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerNameDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x688CEB0", Offset = "0x688BAB0", VA = "0x18688CEB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x688CF50", Offset = "0x688BB50", VA = "0x18688CF50")]
		public PJNOCAJGACO GPDLOMDDDGP()
		{
			return default(PJNOCAJGACO);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x688CE50", Offset = "0x688BA50", VA = "0x18688CE50")]
		public bool APBNFLBPLDE(PJNOCAJGACO value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeConfigDataProperties : HEFJBGLFEKL<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly GAFGIJDLHMM<PJNOCAJGACO> flags;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6882F60", Offset = "0x6881B60", VA = "0x186882F60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly DAMPAIGLGJK<PJNOCAJGACO> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x688CD00", Offset = "0x688B900", VA = "0x18688CD00")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ShapeConfigDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x688B370", Offset = "0x6889F70", VA = "0x18688B370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Preserve]
	[CompilerGenerated]
	public class ParentDataProperties : HEFJBGLFEKL<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public static readonly GAFGIJDLHMM<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6882800", Offset = "0x6881400", VA = "0x186882800")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly DAMPAIGLGJK<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x688B220", Offset = "0x6889E20", VA = "0x18688B220")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ParentDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x688CA70", Offset = "0x688B670", VA = "0x18688CA70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : HEFJBGLFEKL<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly GAFGIJDLHMM<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6881E40", Offset = "0x6880A40", VA = "0x186881E40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly DAMPAIGLGJK<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x688C920", Offset = "0x688B520", VA = "0x18688C920")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReplicatorMaxObjectCountDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x687EEB0", Offset = "0x687DAB0", VA = "0x18687EEB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x687EF50", Offset = "0x687DB50", VA = "0x18687EF50")]
		public float GALHLPIFJMN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x687EFB0", Offset = "0x687DBB0", VA = "0x18687EFB0")]
		public bool GHPHJANMHLF(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : HEFJBGLFEKL<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly GAFGIJDLHMM<float> mass;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6882010", Offset = "0x6880C10", VA = "0x186882010")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly DAMPAIGLGJK<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x687ED60", Offset = "0x687D960", VA = "0x18687ED60")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerMassOverrideDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6871980", Offset = "0x6870580", VA = "0x186871980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalPoseDataProperties : HEFJBGLFEKL<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly GAFGIJDLHMM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly GAFGIJDLHMM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6881F40", Offset = "0x6880B40", VA = "0x186881F40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly DAMPAIGLGJK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly DAMPAIGLGJK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68717A0", Offset = "0x68703A0", VA = "0x1868717A0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override AuthoredLocalPoseDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x688A8E0", Offset = "0x68894E0", VA = "0x18688A8E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : HEFJBGLFEKL<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly GAFGIJDLHMM<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly GAFGIJDLHMM<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6882980", Offset = "0x6881580", VA = "0x186882980")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly DAMPAIGLGJK<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly DAMPAIGLGJK<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x688A710", Offset = "0x6889310", VA = "0x18688A710")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ObjectBoardNodeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6871B80", Offset = "0x6870780", VA = "0x186871B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : HEFJBGLFEKL<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly GAFGIJDLHMM<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x6882680", Offset = "0x6881280", VA = "0x186882680")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly DAMPAIGLGJK<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6871A30", Offset = "0x6870630", VA = "0x186871A30")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override AuthoredLocalUniformScaleDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public EFKMGKJGMIM color
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x688EAA0", Offset = "0x688D6A0", VA = "0x18688EAA0")]
			get
			{
				return default(EFKMGKJGMIM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public GDIFGOILILA material
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x688E980", Offset = "0x688D580", VA = "0x18688E980")]
			get
			{
				return default(GDIFGOILILA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x688EA40", Offset = "0x688D640", VA = "0x18688EA40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x688EB60", Offset = "0x688D760", VA = "0x18688EB60")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x688E860", Offset = "0x688D460", VA = "0x18688E860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x688EB00", Offset = "0x688D700", VA = "0x18688EB00")]
		public EFKMGKJGMIM IGCCIJIOKFP()
		{
			return default(EFKMGKJGMIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x688E9E0", Offset = "0x688D5E0", VA = "0x18688E9E0")]
		public bool GGGABEBBIIM(EFKMGKJGMIM value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x688E790", Offset = "0x688D390", VA = "0x18688E790")]
		public GDIFGOILILA EJFPIMAGIGK()
		{
			return default(GDIFGOILILA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x688EBE0", Offset = "0x688D7E0", VA = "0x18688EBE0")]
		public bool JDHLBKPJJAE(GDIFGOILILA value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x688EC40", Offset = "0x688D840", VA = "0x18688EC40")]
		public float MHCJGIHHDMH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x688E730", Offset = "0x688D330", VA = "0x18688E730")]
		public bool DPKOAPEHCDL(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x688E900", Offset = "0x688D500", VA = "0x18688E900")]
		public float3 FIKFJJPHKMC()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x688E7F0", Offset = "0x688D3F0", VA = "0x18688E7F0")]
		public bool ENHMPNMJNAA(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	[Preserve]
	public class StandardRenderableVisualDataProperties : HEFJBGLFEKL<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly GAFGIJDLHMM<EFKMGKJGMIM> color;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly GAFGIJDLHMM<GDIFGOILILA> material;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly GAFGIJDLHMM<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly GAFGIJDLHMM<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6882C90", Offset = "0x6881890", VA = "0x186882C90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly DAMPAIGLGJK<EFKMGKJGMIM> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly DAMPAIGLGJK<GDIFGOILILA> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly DAMPAIGLGJK<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly DAMPAIGLGJK<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x688E430", Offset = "0x688D030", VA = "0x18688E430")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override StandardRenderableVisualDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x687E340", Offset = "0x687CF40", VA = "0x18687E340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x687E440", Offset = "0x687D040", VA = "0x18687E440")]
		public EEBCFHBCHAF HEJKJGHPJNP()
		{
			return default(EEBCFHBCHAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x687E3E0", Offset = "0x687CFE0", VA = "0x18687E3E0")]
		public bool GEBHHGLHFND(EEBCFHBCHAF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionLayerDataProperties : HEFJBGLFEKL<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly GAFGIJDLHMM<EEBCFHBCHAF> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x6881AC0", Offset = "0x68806C0", VA = "0x186881AC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly DAMPAIGLGJK<EEBCFHBCHAF> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x687E1F0", Offset = "0x687CDF0", VA = "0x18687E1F0")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerCollisionLayerDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	public readonly struct InteractionFilterNoneTagsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly InteractionFilterNoneTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6880580", Offset = "0x687F180", VA = "0x186880580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterNoneTagsDataWrapper(Entity entity, InteractionFilterNoneTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterNoneTagsDataProperties : HEFJBGLFEKL<InteractionFilterNoneTagsDataWrapper, InteractionFilterNoneTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly GAFGIJDLHMM<Entity> noneTags;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6881DC0", Offset = "0x68809C0", VA = "0x186881DC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly DAMPAIGLGJK<Entity> noneTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6880430", Offset = "0x687F030", VA = "0x186880430")]
		public InteractionFilterNoneTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterNoneTagsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterNoneTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x688D350", Offset = "0x688BF50", VA = "0x18688D350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[Preserve]
	public class SiblingSortOrderDataProperties : HEFJBGLFEKL<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly GAFGIJDLHMM<CBNCODLAAAJ> order;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6881940", Offset = "0x6880540", VA = "0x186881940")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public readonly DAMPAIGLGJK<CBNCODLAAAJ> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x688D200", Offset = "0x688BE00", VA = "0x18688D200")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SiblingSortOrderDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x687ECC0", Offset = "0x687D8C0", VA = "0x18687ECC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x687EC00", Offset = "0x687D800", VA = "0x18687EC00")]
		public GGFFHFFDBGK CCIKMGHCIKC()
		{
			return default(GGFFHFFDBGK);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x687EC60", Offset = "0x687D860", VA = "0x18687EC60")]
		public bool DOAMCMAGICG(GGFFHFFDBGK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerGrabbableModeDataProperties : HEFJBGLFEKL<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly GAFGIJDLHMM<GGFFHFFDBGK> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x6882E60", Offset = "0x6881A60", VA = "0x186882E60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public readonly DAMPAIGLGJK<GGFFHFFDBGK> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x687EAB0", Offset = "0x687D6B0", VA = "0x18687EAB0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerGrabbableModeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x687F450", Offset = "0x687E050", VA = "0x18687F450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : HEFJBGLFEKL<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly GAFGIJDLHMM<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x6881330", Offset = "0x687FF30", VA = "0x186881330")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly DAMPAIGLGJK<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x687F300", Offset = "0x687DF00", VA = "0x18687F300")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override CostumePieceParentCostumeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	public readonly struct AuthoredUserTagReferenceBufferWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly AuthoredUserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6871F60", Offset = "0x6870B60", VA = "0x186871F60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal AuthoredUserTagReferenceBufferWrapper(Entity entity, AuthoredUserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredUserTagReferenceBufferProperties : MAKCNOCIJBP<AuthoredUserTagReferenceBufferWrapper, AuthoredUserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly GAFGIJDLHMM<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6882290", Offset = "0x6880E90", VA = "0x186882290")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly MDCGHBGCMAO<AuthoredUserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6871E10", Offset = "0x6870A10", VA = "0x186871E10")]
		public AuthoredUserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override AuthoredUserTagReferenceBufferWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(AuthoredUserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x688E2A0", Offset = "0x688CEA0", VA = "0x18688E2A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x688E3B0", Offset = "0x688CFB0", VA = "0x18688E3B0")]
		public OFPOAEGCOLE GJJPEFCCNGD()
		{
			return default(OFPOAEGCOLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x688E340", Offset = "0x688CF40", VA = "0x18688E340")]
		public bool GEEDBNCABBO(OFPOAEGCOLE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : HEFJBGLFEKL<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly GAFGIJDLHMM<OFPOAEGCOLE> parameters;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x68816C0", Offset = "0x68802C0", VA = "0x1868816C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly DAMPAIGLGJK<OFPOAEGCOLE> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x688E150", Offset = "0x688CD50", VA = "0x18688E150")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplineShapeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x688F5D0", Offset = "0x688E1D0", VA = "0x18688F5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : HEFJBGLFEKL<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly GAFGIJDLHMM<HKDNLFAONPL> transformHint;

			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly GAFGIJDLHMM<ABGMOEOEDKG> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6882310", Offset = "0x6880F10", VA = "0x186882310")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly DAMPAIGLGJK<HKDNLFAONPL> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly DAMPAIGLGJK<ABGMOEOEDKG> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x688F3F0", Offset = "0x688DFF0", VA = "0x18688F3F0")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override TransformFlagsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x687E9B0", Offset = "0x687D5B0", VA = "0x18687E9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x687EA50", Offset = "0x687D650", VA = "0x18687EA50")]
		public KLJFOIFHPPB GPDLOMDDDGP()
		{
			return default(KLJFOIFHPPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x687E900", Offset = "0x687D500", VA = "0x18687E900")]
		public void DEOIPOPGCOM(KLJFOIFHPPB flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : HEFJBGLFEKL<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly GAFGIJDLHMM<KLJFOIFHPPB> flags;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6881BC0", Offset = "0x68807C0", VA = "0x186881BC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly DAMPAIGLGJK<KLJFOIFHPPB> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x687E7B0", Offset = "0x687D3B0", VA = "0x18687E7B0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerFlagsDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[global::DBBCAOEPLAO]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[global::BPFJPAPNAML(1)]
		public KLJFOIFHPPB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public LEGGIBKEPLP collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x687E5F0", Offset = "0x687D1F0", VA = "0x18687E5F0")]
			get
			{
				return default(LEGGIBKEPLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687D250", VA = "0x18687E650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x687E750", Offset = "0x687D350", VA = "0x18687E750")]
		public LEGGIBKEPLP JJMHLMODMFP()
		{
			return default(LEGGIBKEPLP);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x687E6F0", Offset = "0x687D2F0", VA = "0x18687E6F0")]
		public bool IFLLNHGHHHP(LEGGIBKEPLP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : HEFJBGLFEKL<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public static readonly GAFGIJDLHMM<LEGGIBKEPLP> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x68811E0", Offset = "0x687FDE0", VA = "0x1868811E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public readonly DAMPAIGLGJK<LEGGIBKEPLP> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x687E4A0", Offset = "0x687D0A0", VA = "0x18687E4A0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ContainerCollisionModeDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEntityRefDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly InteractionFilterEntityRefDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6880390", Offset = "0x687EF90", VA = "0x186880390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal InteractionFilterEntityRefDataWrapper(Entity entity, InteractionFilterEntityRefDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEntityRefDataProperties : HEFJBGLFEKL<InteractionFilterEntityRefDataWrapper, InteractionFilterEntityRefData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly GAFGIJDLHMM<Entity> filterEntity;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6881B40", Offset = "0x6880740", VA = "0x186881B40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly DAMPAIGLGJK<Entity> filterEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6880240", Offset = "0x687EE40", VA = "0x186880240")]
		public InteractionFilterEntityRefDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override InteractionFilterEntityRefDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(InteractionFilterEntityRefDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x688B7E0", Offset = "0x688A3E0", VA = "0x18688B7E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x688B880", Offset = "0x688A480", VA = "0x18688B880")]
		public bool FDNFCCILKID(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : HEFJBGLFEKL<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly GAFGIJDLHMM<float> density;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6881C40", Offset = "0x6880840", VA = "0x186881C40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly DAMPAIGLGJK<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x688B690", Offset = "0x688A290", VA = "0x18688B690")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override PhysicsMaterialDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ENHIOBKLMJA scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x688ADE0", Offset = "0x68899E0", VA = "0x18688ADE0")]
			get
			{
				return default(ENHIOBKLMJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x688ACE0", Offset = "0x68898E0", VA = "0x18688ACE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x688AE60", Offset = "0x6889A60", VA = "0x18688AE60")]
		public EIPEDFNNELI GPDLOMDDDGP()
		{
			return default(EIPEDFNNELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x688AD80", Offset = "0x6889980", VA = "0x18688AD80")]
		public BCCIMNDHFAP FFKLNGDIDJI()
		{
			return default(BCCIMNDHFAP);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x688AC80", Offset = "0x6889880", VA = "0x18688AC80")]
		public bool BACPGJGANKP(BCCIMNDHFAP value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x688AEC0", Offset = "0x6889AC0", VA = "0x18688AEC0")]
		public void HJBHBNLKDFJ(BCCIMNDHFAP flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x688AF70", Offset = "0x6889B70", VA = "0x18688AF70")]
		public EFGMDLKHKBH LDDEOPIHENA()
		{
			return default(EFGMDLKHKBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x688AFD0", Offset = "0x6889BD0", VA = "0x18688AFD0")]
		public bool MJLEGIIFOAK(EFGMDLKHKBH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : HEFJBGLFEKL<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly GAFGIJDLHMM<ENHIOBKLMJA> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly GAFGIJDLHMM<BCCIMNDHFAP> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly GAFGIJDLHMM<EFGMDLKHKBH> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly GAFGIJDLHMM<EIPEDFNNELI> flags;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6882AC0", Offset = "0x68816C0", VA = "0x186882AC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public readonly DAMPAIGLGJK<ENHIOBKLMJA> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public readonly DAMPAIGLGJK<BCCIMNDHFAP> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public readonly DAMPAIGLGJK<EFGMDLKHKBH> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public readonly DAMPAIGLGJK<EIPEDFNNELI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x688A980", Offset = "0x6889580", VA = "0x18688A980")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ObjectPolicyDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[global::DBBCAOEPLAO]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[global::BPFJPAPNAML(1)]
		public EIPEDFNNELI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[global::BPFJPAPNAML(2)]
		public ENHIOBKLMJA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[global::BPFJPAPNAML(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[CompilerGenerated]
	[global::DBBCAOEPLAO]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[global::BPFJPAPNAML(1)]
		public EIPEDFNNELI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[global::BPFJPAPNAML(2)]
		public ENHIOBKLMJA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[global::BPFJPAPNAML(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::DBBCAOEPLAO]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[global::BPFJPAPNAML(1)]
		public EIPEDFNNELI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[global::BPFJPAPNAML(2)]
		public ENHIOBKLMJA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[global::BPFJPAPNAML(3)]
		public BCCIMNDHFAP userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[CompilerGenerated]
	[global::DBBCAOEPLAO]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[global::BPFJPAPNAML(2)]
		public ENHIOBKLMJA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[global::BPFJPAPNAML(3)]
		public BCCIMNDHFAP userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[global::BPFJPAPNAML(1)]
		public EIPEDFNNELI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x688D790", Offset = "0x688C390", VA = "0x18688D790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x688D830", Offset = "0x688C430", VA = "0x18688D830")]
		public bool KFPOENFEGNK(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointParentDataProperties : HEFJBGLFEKL<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly GAFGIJDLHMM<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x68814C0", Offset = "0x68800C0", VA = "0x1868814C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public readonly DAMPAIGLGJK<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x688D640", Offset = "0x688C240", VA = "0x18688D640")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override SplinePointParentDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupKindDataWrapper : IPGDFDBELNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly ReferenceGroupKindDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x688BED0", Offset = "0x688AAD0", VA = "0x18688BED0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6871A20", Offset = "0x6870620", VA = "0x186871A20")]
		internal ReferenceGroupKindDataWrapper(Entity entity, ReferenceGroupKindDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	[Preserve]
	public class ReferenceGroupKindDataProperties : HEFJBGLFEKL<ReferenceGroupKindDataWrapper, ReferenceGroupKindData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly GAFGIJDLHMM<LECJGOBHOND> kind;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6882FE0", Offset = "0x6881BE0", VA = "0x186882FE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public readonly DAMPAIGLGJK<LECJGOBHOND> kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly DEPCKBDOBLK[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected internal override DEPCKBDOBLK[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x688BD80", Offset = "0x688A980", VA = "0x18688BD80")]
		public ReferenceGroupKindDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6871780", Offset = "0x6870380", VA = "0x186871780", Slot = "18")]
		protected internal override ReferenceGroupKindDataWrapper HCPFBEJKCJO(Entity entity)
		{
			return default(ReferenceGroupKindDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x68721F0", Offset = "0x6870DF0", VA = "0x1868721F0")]
		public static (long, string, string) AJDFGGJEJNC(KGAFPCDNLAE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6873F30", Offset = "0x6872B30", VA = "0x186873F30")]
		public static (long, string, string)[] MMLKKFDAAKJ(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6884C30", Offset = "0x6883830", VA = "0x186884C30")]
		public static Type[] HBNCBOPDGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6883310", Offset = "0x6881F10", VA = "0x186883310")]
		private static void FHCDBNBHAOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x68859C0", Offset = "0x68845C0", VA = "0x1868859C0")]
		public static (Type, long, long)[] HBNCBOPDGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6884C90", Offset = "0x6883890", VA = "0x186884C90")]
		private static void FHCDBNBHAOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	[IGNIBOOGGBF(typeof(NHNDBONDKCC), new string[] { "Registry" })]
	[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
	internal class NetworkPropertyRegistry : NHNDBONDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x688A480", Offset = "0x6889080", VA = "0x18688A480")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6885A20", Offset = "0x6884620", VA = "0x186885A20")]
		private void HIAKOLHFEFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x688FF30", Offset = "0x688EB30", VA = "0x18688FF30")]
		public static Type[] HBNCBOPDGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x688FFB0", Offset = "0x688EBB0", VA = "0x18688FFB0")]
		private static void FHCDBNBHAOK()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68926D0", Offset = "0x68912D0", VA = "0x1868926D0")]
		public void FHCDBNBHAOK(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6891870", Offset = "0x6890470", VA = "0x186891870")]
		private void DBEFABBPBAN(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3198EE0", Offset = "0x3197AE0", VA = "0x183198EE0")]
		private void EABCFOEIEKD<T>(JNBPEJFJHHP registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[CompilerGenerated]
	[Preserve]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Preserve]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	[Preserve]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[IGNIBOOGGBF(typeof(AFDEEHODFON), new string[] { "Registry" })]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
internal class LMJCLLFBAGG : AFDEEHODFON
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Type MPCMHIJHMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x688FEB0", Offset = "0x688EAB0", VA = "0x18688FEB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Type[] BAJIIFMDGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x688FF30", Offset = "0x688EB30", VA = "0x18688FF30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Type[] CGAJBAGJONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x688FF10", Offset = "0x688EB10", VA = "0x18688FF10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public (Type type, long min, long max)[] PFBLDJCLBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x688FF20", Offset = "0x688EB20", VA = "0x18688FF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x688FF90", Offset = "0x688EB90", VA = "0x18688FF90", Slot = "8")]
	public void KJEAKEMLBMI(JNBPEJFJHHP HGFNPIJILPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LMJCLLFBAGG()
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
