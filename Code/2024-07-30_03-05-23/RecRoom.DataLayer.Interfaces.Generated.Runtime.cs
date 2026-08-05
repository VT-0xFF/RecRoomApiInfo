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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
	public class _AssemblyIndex : MFFEOJCHKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LGNGCJEOPOG bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1530BC0", Offset = "0x152F1C0", VA = "0x181530BC0", Slot = "5")]
		public override void DPMBFMAPFBK(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69C2110", Offset = "0x69C0710", VA = "0x1869C2110")]
		private void EHBFLIGPAJF(FCPMPAGEMFF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69C20B0", Offset = "0x69C06B0", VA = "0x1869C20B0", Slot = "6")]
		public override void CIENDGKKGFP(FCPMPAGEMFF registry, [In] PCFCONNFILF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "8")]
		public override void JHLKEJPJBFN(FONNCKCINIP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69C2390", Offset = "0x69C0990", VA = "0x1869C2390")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69BD7D0", Offset = "0x69BBDD0", VA = "0x1869BD7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : NJJLACKLJFG<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly DJBDLMKHNKL<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69B3660", Offset = "0x69B1C60", VA = "0x1869B3660")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly ADGNBLDMCMP<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69BD680", Offset = "0x69BBC80", VA = "0x1869BD680")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override OverrideObjectNetworkIdDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69BDC40", Offset = "0x69BC240", VA = "0x1869BDC40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : NJJLACKLJFG<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly DJBDLMKHNKL<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly DJBDLMKHNKL<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69B37E0", Offset = "0x69B1DE0", VA = "0x1869B37E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly ADGNBLDMCMP<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly ADGNBLDMCMP<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69BDA60", Offset = "0x69BC060", VA = "0x1869BDA60")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override PersistentUserTagDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::DAAANLPBHCM]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::DOHEHJPPEEF(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69B2CF0", Offset = "0x69B12F0", VA = "0x1869B2CF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[Preserve]
	public class LocalDeformableScaleDataProperties : NJJLACKLJFG<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly DJBDLMKHNKL<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69B5380", Offset = "0x69B3980", VA = "0x1869B5380")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ADGNBLDMCMP<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69B2BA0", Offset = "0x69B11A0", VA = "0x1869B2BA0")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override LocalDeformableScaleDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::DAAANLPBHCM]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::DOHEHJPPEEF(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69C06A0", Offset = "0x69BECA0", VA = "0x1869C06A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69C0740", Offset = "0x69BED40", VA = "0x1869C0740")]
		public float3 FCJFDCIGIOP()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69C07C0", Offset = "0x69BEDC0", VA = "0x1869C07C0")]
		public bool HFEMHPAJJJD(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : NJJLACKLJFG<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly DJBDLMKHNKL<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69B4660", Offset = "0x69B2C60", VA = "0x1869B4660")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly ADGNBLDMCMP<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69C0550", Offset = "0x69BEB50", VA = "0x1869C0550")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplinePointScaleDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69B3160", Offset = "0x69B1760", VA = "0x1869B3160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : NJJLACKLJFG<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly DJBDLMKHNKL<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69B4760", Offset = "0x69B2D60", VA = "0x1869B4760")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly ADGNBLDMCMP<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69B3010", Offset = "0x69B1610", VA = "0x1869B3010")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override LocalUniformScaleDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEnabledDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterEnabledDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69B2720", Offset = "0x69B0D20", VA = "0x1869B2720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterEnabledDataWrapper(Entity entity, InteractionFilterEnabledDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEnabledDataProperties : NJJLACKLJFG<InteractionFilterEnabledDataWrapper, InteractionFilterEnabledData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly DJBDLMKHNKL<ODKKPIAMDKH> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69B3DC0", Offset = "0x69B23C0", VA = "0x1869B3DC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly ADGNBLDMCMP<ODKKPIAMDKH> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69B25D0", Offset = "0x69B0BD0", VA = "0x1869B25D0")]
		public InteractionFilterEnabledDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterEnabledDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterEnabledDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupReferenceBufferWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ReferenceGroupReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69BE900", Offset = "0x69BCF00", VA = "0x1869BE900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReferenceGroupReferenceBufferWrapper(Entity entity, ReferenceGroupReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ReferenceGroupReferenceBufferProperties : NMPPMEIMEDI<ReferenceGroupReferenceBufferWrapper, ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly DJBDLMKHNKL<Entity> reference;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69B4A80", Offset = "0x69B3080", VA = "0x1869B4A80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly DHDDIGFMHPD<ReferenceGroupReferenceBuffer, Entity> reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69BE7B0", Offset = "0x69BCDB0", VA = "0x1869BE7B0")]
		public ReferenceGroupReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReferenceGroupReferenceBufferWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReferenceGroupReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct UserTagReferenceBufferWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly UserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69C2010", Offset = "0x69C0610", VA = "0x1869C2010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal UserTagReferenceBufferWrapper(Entity entity, UserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagReferenceBufferProperties : NMPPMEIMEDI<UserTagReferenceBufferWrapper, UserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly DJBDLMKHNKL<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x69B3E40", Offset = "0x69B2440", VA = "0x1869B3E40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly DHDDIGFMHPD<UserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69C1EC0", Offset = "0x69C04C0", VA = "0x1869C1EC0")]
		public UserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override UserTagReferenceBufferWrapper POKMIKCFOFA(Entity entity)
		{
			return default(UserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69B2530", Offset = "0x69B0B30", VA = "0x1869B2530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : NJJLACKLJFG<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly DJBDLMKHNKL<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly DJBDLMKHNKL<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly DJBDLMKHNKL<ODKKPIAMDKH> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x69B3930", Offset = "0x69B1F30", VA = "0x1869B3930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ADGNBLDMCMP<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ADGNBLDMCMP<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly ADGNBLDMCMP<ODKKPIAMDKH> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69B22C0", Offset = "0x69B08C0", VA = "0x1869B22C0")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69A43F0", Offset = "0x69A29F0", VA = "0x1869A43F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : NJJLACKLJFG<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly DJBDLMKHNKL<DOBCBOCLKNF> version;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x69B35E0", Offset = "0x69B1BE0", VA = "0x1869B35E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly ADGNBLDMCMP<DOBCBOCLKNF> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x69A42A0", Offset = "0x69A28A0", VA = "0x1869A42A0")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ComponentSerializedVersionDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupOwnerDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ReferenceGroupOwnerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69BE710", Offset = "0x69BCD10", VA = "0x1869BE710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReferenceGroupOwnerDataWrapper(Entity entity, ReferenceGroupOwnerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupOwnerDataProperties : NJJLACKLJFG<ReferenceGroupOwnerDataWrapper, ReferenceGroupOwnerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly DJBDLMKHNKL<Entity> owner;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x69B3FC0", Offset = "0x69B25C0", VA = "0x1869B3FC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly ADGNBLDMCMP<Entity> owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69BE5C0", Offset = "0x69BCBC0", VA = "0x1869BE5C0")]
		public ReferenceGroupOwnerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReferenceGroupOwnerDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReferenceGroupOwnerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct MakerPenHeldDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly MakerPenHeldDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69B3350", Offset = "0x69B1950", VA = "0x1869B3350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal MakerPenHeldDataWrapper(Entity entity, MakerPenHeldDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x69B33F0", Offset = "0x69B19F0", VA = "0x1869B33F0")]
		public bool IGOIICGIPPI(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class MakerPenHeldDataProperties : NJJLACKLJFG<MakerPenHeldDataWrapper, MakerPenHeldData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly DJBDLMKHNKL<bool> makerPenHeld;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69B3D40", Offset = "0x69B2340", VA = "0x1869B3D40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly ADGNBLDMCMP<bool> makerPenHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69B3200", Offset = "0x69B1800", VA = "0x1869B3200")]
		public MakerPenHeldDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override MakerPenHeldDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(MakerPenHeldDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69C1730", Offset = "0x69BFD30", VA = "0x1869C1730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69C15C0", Offset = "0x69BFBC0", VA = "0x1869C15C0")]
		public float BNOGLNELHOC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69C1620", Offset = "0x69BFC20", VA = "0x1869C1620")]
		public bool DIAFJOAADFB(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69C1560", Offset = "0x69BFB60", VA = "0x1869C1560")]
		public GPFAHCMOHBB ALCAECAADGN()
		{
			return default(GPFAHCMOHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69C1680", Offset = "0x69BFC80", VA = "0x1869C1680")]
		public void EFBMNCDHGCA(GPFAHCMOHBB flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupSettingsDataProperties : NJJLACKLJFG<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly DJBDLMKHNKL<float> delay;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly DJBDLMKHNKL<GPFAHCMOHBB> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69B3510", Offset = "0x69B1B10", VA = "0x1869B3510")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly ADGNBLDMCMP<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly ADGNBLDMCMP<GPFAHCMOHBB> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69C1380", Offset = "0x69BF980", VA = "0x1869C1380")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ToolCleanupSettingsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69BFC80", Offset = "0x69BE280", VA = "0x1869BFC80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69BFC20", Offset = "0x69BE220", VA = "0x1869BFC20")]
		public bool EGKJFGDCPDB(HKHEOBACNDB value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointOrderDataProperties : NJJLACKLJFG<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly DJBDLMKHNKL<HKHEOBACNDB> order;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x69B5480", Offset = "0x69B3A80", VA = "0x1869B5480")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly ADGNBLDMCMP<HKHEOBACNDB> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69BFAD0", Offset = "0x69BE0D0", VA = "0x1869BFAD0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplinePointOrderDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69B1BC0", Offset = "0x69B01C0", VA = "0x1869B1BC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : NJJLACKLJFG<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly DJBDLMKHNKL<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69B3F40", Offset = "0x69B2540", VA = "0x1869B3F40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly ADGNBLDMCMP<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69B1A70", Offset = "0x69B0070", VA = "0x1869B1A70")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override CostumePieceSlotIndexDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69B2F70", Offset = "0x69B1570", VA = "0x1869B2F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : NJJLACKLJFG<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly DJBDLMKHNKL<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly DJBDLMKHNKL<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x69B49B0", Offset = "0x69B2FB0", VA = "0x1869B49B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly ADGNBLDMCMP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly ADGNBLDMCMP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69B2D90", Offset = "0x69B1390", VA = "0x1869B2D90")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override LocalPoseDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69BEAF0", Offset = "0x69BD0F0", VA = "0x1869BEAF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : NJJLACKLJFG<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly DJBDLMKHNKL<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x69B4CD0", Offset = "0x69B32D0", VA = "0x1869B4CD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly ADGNBLDMCMP<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69BE9A0", Offset = "0x69BCFA0", VA = "0x1869BE9A0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct ReplicatorPreallocatedObjectCountDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ReplicatorPreallocatedObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69BF340", Offset = "0x69BD940", VA = "0x1869BF340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReplicatorPreallocatedObjectCountDataWrapper(Entity entity, ReplicatorPreallocatedObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataProperties : NJJLACKLJFG<ReplicatorPreallocatedObjectCountDataWrapper, ReplicatorPreallocatedObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly DJBDLMKHNKL<int> preallocatedCopies;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x69B46E0", Offset = "0x69B2CE0", VA = "0x1869B46E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly ADGNBLDMCMP<int> preallocatedCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69BF1F0", Offset = "0x69BD7F0", VA = "0x1869BF1F0")]
		public ReplicatorPreallocatedObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReplicatorPreallocatedObjectCountDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReplicatorPreallocatedObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[global::DAAANLPBHCM]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::DOHEHJPPEEF(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69C03D0", Offset = "0x69BE9D0", VA = "0x1869C03D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69C0470", Offset = "0x69BEA70", VA = "0x1869C0470")]
		public quaternion LBHPDNMHJME()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69C04E0", Offset = "0x69BEAE0", VA = "0x1869C04E0")]
		public bool LEBFIMGCNJA(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : NJJLACKLJFG<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly DJBDLMKHNKL<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69B3B40", Offset = "0x69B2140", VA = "0x1869B3B40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly ADGNBLDMCMP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69C0280", Offset = "0x69BE880", VA = "0x1869C0280")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplinePointRotationDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAllTagsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly InteractionFilterAllTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69B2030", Offset = "0x69B0630", VA = "0x1869B2030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterAllTagsDataWrapper(Entity entity, InteractionFilterAllTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterAllTagsDataProperties : NJJLACKLJFG<InteractionFilterAllTagsDataWrapper, InteractionFilterAllTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DJBDLMKHNKL<Entity> allTags;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x69B3CC0", Offset = "0x69B22C0", VA = "0x1869B3CC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly ADGNBLDMCMP<Entity> allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69B1EE0", Offset = "0x69B04E0", VA = "0x1869B1EE0")]
		public InteractionFilterAllTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterAllTagsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterAllTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69C19B0", Offset = "0x69BFFB0", VA = "0x1869C19B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : NJJLACKLJFG<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DJBDLMKHNKL<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly DJBDLMKHNKL<JILJNNLDGBH> statusFlags;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x69B4240", Offset = "0x69B2840", VA = "0x1869B4240")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly ADGNBLDMCMP<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly ADGNBLDMCMP<JILJNNLDGBH> statusFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69C17D0", Offset = "0x69BFDD0", VA = "0x1869C17D0")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ToolCleanupStatusDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	[global::DAAANLPBHCM]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[global::DOHEHJPPEEF(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[global::DOHEHJPPEEF(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[global::DOHEHJPPEEF(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAnyTagsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly InteractionFilterAnyTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69B2220", Offset = "0x69B0820", VA = "0x1869B2220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterAnyTagsDataWrapper(Entity entity, InteractionFilterAnyTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterAnyTagsDataProperties : NJJLACKLJFG<InteractionFilterAnyTagsDataWrapper, InteractionFilterAnyTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly DJBDLMKHNKL<Entity> anyTags;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69B3BC0", Offset = "0x69B21C0", VA = "0x1869B3BC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly ADGNBLDMCMP<Entity> anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69B20D0", Offset = "0x69B06D0", VA = "0x1869B20D0")]
		public InteractionFilterAnyTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterAnyTagsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterAnyTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69C0160", Offset = "0x69BE760", VA = "0x1869C0160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69C0200", Offset = "0x69BE800", VA = "0x1869C0200")]
		public float3 MCHLPMJIEBO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69C00F0", Offset = "0x69BE6F0", VA = "0x1869C00F0")]
		public bool AEJCIOEKOAH(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : NJJLACKLJFG<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly DJBDLMKHNKL<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x69B36E0", Offset = "0x69B1CE0", VA = "0x1869B36E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly ADGNBLDMCMP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x69BFFA0", Offset = "0x69BE5A0", VA = "0x1869BFFA0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplinePointPositionDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public EMOJCCPMLJF shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69BF880", Offset = "0x69BDE80", VA = "0x1869BF880")]
			get
			{
				return default(EMOJCCPMLJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69BF7E0", Offset = "0x69BDDE0", VA = "0x1869BF7E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : NJJLACKLJFG<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public static readonly DJBDLMKHNKL<EMOJCCPMLJF> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x69B4410", Offset = "0x69B2A10", VA = "0x1869B4410")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly ADGNBLDMCMP<EMOJCCPMLJF> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69BF690", Offset = "0x69BDC90", VA = "0x1869BF690")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ShapeTypeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JNBPIKMLHDI shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x69BE310", Offset = "0x69BC910", VA = "0x1869BE310")]
			get
			{
				return default(JNBPIKMLHDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69BE270", Offset = "0x69BC870", VA = "0x1869BE270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69BE370", Offset = "0x69BC970", VA = "0x1869BE370")]
		public JNBPIKMLHDI KOJGJLGNGCL()
		{
			return default(JNBPIKMLHDI);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : NJJLACKLJFG<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DJBDLMKHNKL<JNBPIKMLHDI> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x69B45E0", Offset = "0x69B2BE0", VA = "0x1869B45E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly ADGNBLDMCMP<JNBPIKMLHDI> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69BE120", Offset = "0x69BC720", VA = "0x1869BE120")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override PrimitiveShapeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x69BEF60", Offset = "0x69BD560", VA = "0x1869BEF60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : NJJLACKLJFG<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DJBDLMKHNKL<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly DJBDLMKHNKL<bool> NeedsCircuitUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x69B5160", Offset = "0x69B3760", VA = "0x1869B5160")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly ADGNBLDMCMP<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly ADGNBLDMCMP<bool> NeedsCircuitUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69BED80", Offset = "0x69BD380", VA = "0x1869BED80")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReplicatorDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[global::DAAANLPBHCM]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[global::DOHEHJPPEEF(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69BE080", Offset = "0x69BC680", VA = "0x1869BE080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : NJJLACKLJFG<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly DJBDLMKHNKL<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x69B3AC0", Offset = "0x69B20C0", VA = "0x1869B3AC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly ADGNBLDMCMP<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69BDF30", Offset = "0x69BC530", VA = "0x1869BDF30")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override PlayerScopeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69B1E40", Offset = "0x69B0440", VA = "0x1869B1E40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : NJJLACKLJFG<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly DJBDLMKHNKL<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly DJBDLMKHNKL<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x69B4B00", Offset = "0x69B3100", VA = "0x1869B4B00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly ADGNBLDMCMP<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly ADGNBLDMCMP<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69B1C60", Offset = "0x69B0260", VA = "0x1869B1C60")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override EntityBundlePartDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x69BECE0", Offset = "0x69BD2E0", VA = "0x1869BECE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : NJJLACKLJFG<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly DJBDLMKHNKL<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x69B4F90", Offset = "0x69B3590", VA = "0x1869B4F90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly ADGNBLDMCMP<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x69BEB90", Offset = "0x69BD190", VA = "0x1869BEB90")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69BCCC0", Offset = "0x69BB2C0", VA = "0x1869BCCC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : NJJLACKLJFG<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly DJBDLMKHNKL<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly DJBDLMKHNKL<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x69B3450", Offset = "0x69B1A50", VA = "0x1869B3450")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly ADGNBLDMCMP<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly ADGNBLDMCMP<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x69BCAF0", Offset = "0x69BB0F0", VA = "0x1869BCAF0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override OMShapeContainerDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	[global::DAAANLPBHCM]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[global::DOHEHJPPEEF(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[global::DOHEHJPPEEF(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[global::DOHEHJPPEEF(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69A4010", Offset = "0x69A2610", VA = "0x1869A4010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : NJJLACKLJFG<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly DJBDLMKHNKL<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x69B4DD0", Offset = "0x69B33D0", VA = "0x1869B4DD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly ADGNBLDMCMP<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x69A3EC0", Offset = "0x69A24C0", VA = "0x1869A3EC0")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override AuthoredParentDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct UserTagNameDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly UserTagNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69C1E20", Offset = "0x69C0420", VA = "0x1869C1E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal UserTagNameDataWrapper(Entity entity, UserTagNameDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[Preserve]
	public class UserTagNameDataProperties : NJJLACKLJFG<UserTagNameDataWrapper, UserTagNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly DJBDLMKHNKL<FixedString32Bytes> Value;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x69B4C50", Offset = "0x69B3250", VA = "0x1869B4C50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly ADGNBLDMCMP<FixedString32Bytes> Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69C1CD0", Offset = "0x69C02D0", VA = "0x1869C1CD0")]
		public UserTagNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override UserTagNameDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(UserTagNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x69B57B0", Offset = "0x69B3DB0", VA = "0x1869B57B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69B5850", Offset = "0x69B3E50", VA = "0x1869B5850")]
		public CHDPAPFDIPP OLIIMBFCPFP()
		{
			return default(CHDPAPFDIPP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x69B5750", Offset = "0x69B3D50", VA = "0x1869B5750")]
		public bool EJEGAOEIIPM(CHDPAPFDIPP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : NJJLACKLJFG<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly DJBDLMKHNKL<CHDPAPFDIPP> mode;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x69B4930", Offset = "0x69B2F30", VA = "0x1869B4930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly ADGNBLDMCMP<CHDPAPFDIPP> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69B5600", Offset = "0x69B3C00", VA = "0x1869B5600")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override NavMeshGenerationDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69B16E0", Offset = "0x69AFCE0", VA = "0x1869B16E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69B1780", Offset = "0x69AFD80", VA = "0x1869B1780")]
		public FixedString64Bytes IEPMBENHMOC()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x69B1810", Offset = "0x69AFE10", VA = "0x1869B1810")]
		public bool JNBGAJOMABB(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : NJJLACKLJFG<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly DJBDLMKHNKL<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x69B4E50", Offset = "0x69B3450", VA = "0x1869B4E50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly ADGNBLDMCMP<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69B1590", Offset = "0x69AFB90", VA = "0x1869B1590")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerNameDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69BF530", Offset = "0x69BDB30", VA = "0x1869BF530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x69BF630", Offset = "0x69BDC30", VA = "0x1869BF630")]
		public PPJODBBIPDM HMAPNKFDCEC()
		{
			return default(PPJODBBIPDM);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69BF5D0", Offset = "0x69BDBD0", VA = "0x1869BF5D0")]
		public bool FHCAKKKILIA(PPJODBBIPDM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : NJJLACKLJFG<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public static readonly DJBDLMKHNKL<PPJODBBIPDM> flags;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x69B5500", Offset = "0x69B3B00", VA = "0x1869B5500")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly ADGNBLDMCMP<PPJODBBIPDM> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69BF3E0", Offset = "0x69BD9E0", VA = "0x1869BF3E0")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ShapeConfigDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69BD9C0", Offset = "0x69BBFC0", VA = "0x1869BD9C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : NJJLACKLJFG<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly DJBDLMKHNKL<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x69B4D50", Offset = "0x69B3350", VA = "0x1869B4D50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly ADGNBLDMCMP<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x69BD870", Offset = "0x69BBE70", VA = "0x1869BD870")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ParentDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69BF150", Offset = "0x69BD750", VA = "0x1869BF150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : NJJLACKLJFG<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly DJBDLMKHNKL<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x69B4390", Offset = "0x69B2990", VA = "0x1869B4390")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly ADGNBLDMCMP<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69BF000", Offset = "0x69BD600", VA = "0x1869BF000")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReplicatorMaxObjectCountDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x69B1430", Offset = "0x69AFA30", VA = "0x1869B1430", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x69B14D0", Offset = "0x69AFAD0", VA = "0x1869B14D0")]
		public float HCNPGHNFDNC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x69B1530", Offset = "0x69AFB30", VA = "0x1869B1530")]
		public bool KHAGOEDLDDJ(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : NJJLACKLJFG<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly DJBDLMKHNKL<float> mass;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x69B4560", Offset = "0x69B2B60", VA = "0x1869B4560")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly ADGNBLDMCMP<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x69B12E0", Offset = "0x69AF8E0", VA = "0x1869B12E0")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerMassOverrideDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3C20", Offset = "0x69A2220", VA = "0x1869A3C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalPoseDataProperties : NJJLACKLJFG<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly DJBDLMKHNKL<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly DJBDLMKHNKL<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x69B4490", Offset = "0x69B2A90", VA = "0x1869B4490")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly ADGNBLDMCMP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly ADGNBLDMCMP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A40", Offset = "0x69A2040", VA = "0x1869A3A40")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override AuthoredLocalPoseDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x69BCF30", Offset = "0x69BB530", VA = "0x1869BCF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : NJJLACKLJFG<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly DJBDLMKHNKL<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly DJBDLMKHNKL<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x69B4ED0", Offset = "0x69B34D0", VA = "0x1869B4ED0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly ADGNBLDMCMP<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly ADGNBLDMCMP<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x69BCD60", Offset = "0x69BB360", VA = "0x1869BCD60")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ObjectBoardNodeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x69A3E20", Offset = "0x69A2420", VA = "0x1869A3E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : NJJLACKLJFG<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly DJBDLMKHNKL<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x69B4BD0", Offset = "0x69B31D0", VA = "0x1869B4BD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly ADGNBLDMCMP<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CD0", Offset = "0x69A22D0", VA = "0x1869A3CD0")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override AuthoredLocalUniformScaleDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GDHFDPACHFB color
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x69C11F0", Offset = "0x69BF7F0", VA = "0x1869C11F0")]
			get
			{
				return default(GDHFDPACHFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EJIAINLLJBH material
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x69C1190", Offset = "0x69BF790", VA = "0x1869C1190")]
			get
			{
				return default(EJIAINLLJBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x69C10B0", Offset = "0x69BF6B0", VA = "0x1869C10B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x69C1030", Offset = "0x69BF630", VA = "0x1869C1030")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x69C0F90", Offset = "0x69BF590", VA = "0x1869C0F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69C12B0", Offset = "0x69BF8B0", VA = "0x1869C12B0")]
		public GDHFDPACHFB MIDIACNCANJ()
		{
			return default(GDHFDPACHFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x69C0ED0", Offset = "0x69BF4D0", VA = "0x1869C0ED0")]
		public bool EDEPFMCBKDH(GDHFDPACHFB value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x69C1250", Offset = "0x69BF850", VA = "0x1869C1250")]
		public EJIAINLLJBH KCCLEELDONA()
		{
			return default(EJIAINLLJBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x69C0E70", Offset = "0x69BF470", VA = "0x1869C0E70")]
		public bool BIABFLBBNGL(EJIAINLLJBH value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x69C0F30", Offset = "0x69BF530", VA = "0x1869C0F30")]
		public float EFENGDMHNFL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x69C0E10", Offset = "0x69BF410", VA = "0x1869C0E10")]
		public bool BFBJINHPLKN(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x69C1110", Offset = "0x69BF710", VA = "0x1869C1110")]
		public float3 IBOLLDNMAGO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x69C1310", Offset = "0x69BF910", VA = "0x1869C1310")]
		public bool MKCCKHAOEIC(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : NJJLACKLJFG<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly DJBDLMKHNKL<GDHFDPACHFB> color;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly DJBDLMKHNKL<EJIAINLLJBH> material;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly DJBDLMKHNKL<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly DJBDLMKHNKL<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x69B5230", Offset = "0x69B3830", VA = "0x1869B5230")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly ADGNBLDMCMP<GDHFDPACHFB> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly ADGNBLDMCMP<EJIAINLLJBH> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly ADGNBLDMCMP<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly ADGNBLDMCMP<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x69C0B10", Offset = "0x69BF110", VA = "0x1869C0B10")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override StandardRenderableVisualDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x69B08C0", Offset = "0x69AEEC0", VA = "0x1869B08C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x69B09C0", Offset = "0x69AEFC0", VA = "0x1869B09C0")]
		public IHPNPIHEBNC NNMLGBJOLEG()
		{
			return default(IHPNPIHEBNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x69B0960", Offset = "0x69AEF60", VA = "0x1869B0960")]
		public bool LMEEBAPOAHK(IHPNPIHEBNC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : NJJLACKLJFG<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly DJBDLMKHNKL<IHPNPIHEBNC> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x69B4040", Offset = "0x69B2640", VA = "0x1869B4040")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly ADGNBLDMCMP<IHPNPIHEBNC> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x69B0770", Offset = "0x69AED70", VA = "0x1869B0770")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerCollisionLayerDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public readonly struct InteractionFilterNoneTagsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly InteractionFilterNoneTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B00", Offset = "0x69B1100", VA = "0x1869B2B00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterNoneTagsDataWrapper(Entity entity, InteractionFilterNoneTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterNoneTagsDataProperties : NJJLACKLJFG<InteractionFilterNoneTagsDataWrapper, InteractionFilterNoneTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly DJBDLMKHNKL<Entity> noneTags;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x69B4310", Offset = "0x69B2910", VA = "0x1869B4310")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public readonly ADGNBLDMCMP<Entity> noneTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x69B29B0", Offset = "0x69B0FB0", VA = "0x1869B29B0")]
		public InteractionFilterNoneTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterNoneTagsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterNoneTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x69BFA30", Offset = "0x69BE030", VA = "0x1869BFA30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : NJJLACKLJFG<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly DJBDLMKHNKL<HKHEOBACNDB> order;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x69B3EC0", Offset = "0x69B24C0", VA = "0x1869B3EC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public readonly ADGNBLDMCMP<HKHEOBACNDB> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x69BF8E0", Offset = "0x69BDEE0", VA = "0x1869BF8E0")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SiblingSortOrderDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x69B1180", Offset = "0x69AF780", VA = "0x1869B1180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x69B1280", Offset = "0x69AF880", VA = "0x1869B1280")]
		public GPBBMBGGIFB NIEMNAJGFMJ()
		{
			return default(GPBBMBGGIFB);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x69B1220", Offset = "0x69AF820", VA = "0x1869B1220")]
		public bool IGJNGNGAFLG(GPBBMBGGIFB value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerGrabbableModeDataProperties : NJJLACKLJFG<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly DJBDLMKHNKL<GPBBMBGGIFB> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x69B5400", Offset = "0x69B3A00", VA = "0x1869B5400")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly ADGNBLDMCMP<GPBBMBGGIFB> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x69B1030", Offset = "0x69AF630", VA = "0x1869B1030")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerGrabbableModeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x69B19D0", Offset = "0x69AFFD0", VA = "0x1869B19D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : NJJLACKLJFG<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly DJBDLMKHNKL<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x69B38B0", Offset = "0x69B1EB0", VA = "0x1869B38B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly ADGNBLDMCMP<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69B1880", Offset = "0x69AFE80", VA = "0x1869B1880")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override CostumePieceParentCostumeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	public readonly struct AuthoredUserTagReferenceBufferWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly AuthoredUserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x69A4200", Offset = "0x69A2800", VA = "0x1869A4200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal AuthoredUserTagReferenceBufferWrapper(Entity entity, AuthoredUserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredUserTagReferenceBufferProperties : NMPPMEIMEDI<AuthoredUserTagReferenceBufferWrapper, AuthoredUserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly DJBDLMKHNKL<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x69B47E0", Offset = "0x69B2DE0", VA = "0x1869B47E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly DHDDIGFMHPD<AuthoredUserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69A40B0", Offset = "0x69A26B0", VA = "0x1869A40B0")]
		public AuthoredUserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override AuthoredUserTagReferenceBufferWrapper POKMIKCFOFA(Entity entity)
		{
			return default(AuthoredUserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x69C09F0", Offset = "0x69BEFF0", VA = "0x1869C09F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x69C0A90", Offset = "0x69BF090", VA = "0x1869C0A90")]
		public LOOJMKCMMDI PAGMNNFEBHD()
		{
			return default(LOOJMKCMMDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x69C0980", Offset = "0x69BEF80", VA = "0x1869C0980")]
		public bool AIAINHNPKOJ(LOOJMKCMMDI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : NJJLACKLJFG<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly DJBDLMKHNKL<LOOJMKCMMDI> parameters;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x69B3C40", Offset = "0x69B2240", VA = "0x1869B3C40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly ADGNBLDMCMP<LOOJMKCMMDI> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x69C0830", Offset = "0x69BEE30", VA = "0x1869C0830")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplineShapeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x69C1C30", Offset = "0x69C0230", VA = "0x1869C1C30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : NJJLACKLJFG<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly DJBDLMKHNKL<LBFNFICHKAM> transformHint;

			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly DJBDLMKHNKL<BAKFMCIJLGA> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x69B4860", Offset = "0x69B2E60", VA = "0x1869B4860")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly ADGNBLDMCMP<LBFNFICHKAM> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly ADGNBLDMCMP<BAKFMCIJLGA> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x69C1A50", Offset = "0x69C0050", VA = "0x1869C1A50")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override TransformFlagsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x69B0E80", Offset = "0x69AF480", VA = "0x1869B0E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x69B0FD0", Offset = "0x69AF5D0", VA = "0x1869B0FD0")]
		public DGLLELHCEGN HMAPNKFDCEC()
		{
			return default(DGLLELHCEGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x69B0F20", Offset = "0x69AF520", VA = "0x1869B0F20")]
		public void GCPNLIHLKLH(DGLLELHCEGN flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : NJJLACKLJFG<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly DJBDLMKHNKL<DGLLELHCEGN> flags;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x69B4140", Offset = "0x69B2740", VA = "0x1869B4140")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly ADGNBLDMCMP<DGLLELHCEGN> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x69B0D30", Offset = "0x69AF330", VA = "0x1869B0D30")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerFlagsDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[global::DAAANLPBHCM]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[global::DOHEHJPPEEF(1)]
		public DGLLELHCEGN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public FGHMMODCMKP collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x69B0B70", Offset = "0x69AF170", VA = "0x1869B0B70")]
			get
			{
				return default(FGHMMODCMKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x69B0BD0", Offset = "0x69AF1D0", VA = "0x1869B0BD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x69B0CD0", Offset = "0x69AF2D0", VA = "0x1869B0CD0")]
		public FGHMMODCMKP NNMCMJCMLDN()
		{
			return default(FGHMMODCMKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x69B0C70", Offset = "0x69AF270", VA = "0x1869B0C70")]
		public bool FKPMCHOOIKC(FGHMMODCMKP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionModeDataProperties : NJJLACKLJFG<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly DJBDLMKHNKL<FGHMMODCMKP> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x69B3760", Offset = "0x69B1D60", VA = "0x1869B3760")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly ADGNBLDMCMP<FGHMMODCMKP> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x69B0A20", Offset = "0x69AF020", VA = "0x1869B0A20")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ContainerCollisionModeDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEntityRefDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly InteractionFilterEntityRefDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x69B2910", Offset = "0x69B0F10", VA = "0x1869B2910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal InteractionFilterEntityRefDataWrapper(Entity entity, InteractionFilterEntityRefDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEntityRefDataProperties : NJJLACKLJFG<InteractionFilterEntityRefDataWrapper, InteractionFilterEntityRefData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly DJBDLMKHNKL<Entity> filterEntity;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x69B40C0", Offset = "0x69B26C0", VA = "0x1869B40C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly ADGNBLDMCMP<Entity> filterEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x69B27C0", Offset = "0x69B0DC0", VA = "0x1869B27C0")]
		public InteractionFilterEntityRefDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override InteractionFilterEntityRefDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(InteractionFilterEntityRefDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x69BDE30", Offset = "0x69BC430", VA = "0x1869BDE30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x69BDED0", Offset = "0x69BC4D0", VA = "0x1869BDED0")]
		public bool JLELBHKEFNE(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : NJJLACKLJFG<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly DJBDLMKHNKL<float> density;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x69B41C0", Offset = "0x69B27C0", VA = "0x1869B41C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly ADGNBLDMCMP<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x69BDCE0", Offset = "0x69BC2E0", VA = "0x1869BDCE0")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override PhysicsMaterialDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public GGDNKMJOBID scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x69BD5A0", Offset = "0x69BBBA0", VA = "0x1869BD5A0")]
			get
			{
				return default(GGDNKMJOBID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x69BD390", Offset = "0x69BB990", VA = "0x1869BD390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x69BD490", Offset = "0x69BBA90", VA = "0x1869BD490")]
		public JHJAHPCDJGG HMAPNKFDCEC()
		{
			return default(JHJAHPCDJGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x69BD2D0", Offset = "0x69BB8D0", VA = "0x1869BD2D0")]
		public KBPHFEOEKMF BICPMGBEEHP()
		{
			return default(KBPHFEOEKMF);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x69BD620", Offset = "0x69BBC20", VA = "0x1869BD620")]
		public bool OOEGGDGGADK(KBPHFEOEKMF value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x69BD4F0", Offset = "0x69BBAF0", VA = "0x1869BD4F0")]
		public void JBEFEBIIDBA(KBPHFEOEKMF flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x69BD430", Offset = "0x69BBA30", VA = "0x1869BD430")]
		public BMDJAEPMNDM HLOHMPDNIAD()
		{
			return default(BMDJAEPMNDM);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x69BD330", Offset = "0x69BB930", VA = "0x1869BD330")]
		public bool CFGODPDJJOI(BMDJAEPMNDM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : NJJLACKLJFG<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly DJBDLMKHNKL<GGDNKMJOBID> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly DJBDLMKHNKL<KBPHFEOEKMF> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly DJBDLMKHNKL<BMDJAEPMNDM> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly DJBDLMKHNKL<JHJAHPCDJGG> flags;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x69B5010", Offset = "0x69B3610", VA = "0x1869B5010")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly ADGNBLDMCMP<GGDNKMJOBID> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly ADGNBLDMCMP<KBPHFEOEKMF> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly ADGNBLDMCMP<BMDJAEPMNDM> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public readonly ADGNBLDMCMP<JHJAHPCDJGG> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x69BCFD0", Offset = "0x69BB5D0", VA = "0x1869BCFD0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ObjectPolicyDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[global::DAAANLPBHCM]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[global::DOHEHJPPEEF(1)]
		public JHJAHPCDJGG flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[global::DOHEHJPPEEF(2)]
		public GGDNKMJOBID scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[global::DOHEHJPPEEF(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[global::DAAANLPBHCM]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[global::DOHEHJPPEEF(1)]
		public JHJAHPCDJGG flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[global::DOHEHJPPEEF(2)]
		public GGDNKMJOBID scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[global::DOHEHJPPEEF(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[global::DAAANLPBHCM]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[global::DOHEHJPPEEF(1)]
		public JHJAHPCDJGG flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[global::DOHEHJPPEEF(2)]
		public GGDNKMJOBID scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[global::DOHEHJPPEEF(3)]
		public KBPHFEOEKMF userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[global::DAAANLPBHCM]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[global::DOHEHJPPEEF(2)]
		public GGDNKMJOBID scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[global::DOHEHJPPEEF(3)]
		public KBPHFEOEKMF userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[global::DOHEHJPPEEF(1)]
		public JHJAHPCDJGG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x69BFE70", Offset = "0x69BE470", VA = "0x1869BFE70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x69BFF10", Offset = "0x69BE510", VA = "0x1869BFF10")]
		public bool JKGICBKENDL(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : NJJLACKLJFG<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly DJBDLMKHNKL<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x69B3A40", Offset = "0x69B2040", VA = "0x1869B3A40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public readonly ADGNBLDMCMP<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69BFD20", Offset = "0x69BE320", VA = "0x1869BFD20")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override SplinePointParentDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupKindDataWrapper : JLCHKADBFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly ReferenceGroupKindDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69BE520", Offset = "0x69BCB20", VA = "0x1869BE520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3CC0", Offset = "0x69A22C0", VA = "0x1869A3CC0")]
		internal ReferenceGroupKindDataWrapper(Entity entity, ReferenceGroupKindDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupKindDataProperties : NJJLACKLJFG<ReferenceGroupKindDataWrapper, ReferenceGroupKindData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public static readonly DJBDLMKHNKL<EEMOMCJGFPH> kind;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x69B5580", Offset = "0x69B3B80", VA = "0x1869B5580")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public readonly ADGNBLDMCMP<EEMOMCJGFPH> kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly EKPIOBJJCMP[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected internal override EKPIOBJJCMP[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x69BE3D0", Offset = "0x69BC9D0", VA = "0x1869BE3D0")]
		public ReferenceGroupKindDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A20", Offset = "0x69A2020", VA = "0x1869A3A20", Slot = "18")]
		protected internal override ReferenceGroupKindDataWrapper POKMIKCFOFA(Entity entity)
		{
			return default(ReferenceGroupKindDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x69A45D0", Offset = "0x69A2BD0", VA = "0x1869A45D0")]
		public static (long, string, string) LKCEABEMBAG(IDEDIMNMLPE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x69A4490", Offset = "0x69A2A90", VA = "0x1869A4490")]
		public static (long, string, string)[] IIEEGDPNKMA(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69B58B0", Offset = "0x69B3EB0", VA = "0x1869B58B0")]
		public static Type[] HMACCOHADEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x69B5910", Offset = "0x69B3F10", VA = "0x1869B5910")]
		private static void NECNOABNHFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x69B7230", Offset = "0x69B5830", VA = "0x1869B7230")]
		public static (Type, long, long)[] HMACCOHADEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x69B7290", Offset = "0x69B5890", VA = "0x1869B7290")]
		private static void NECNOABNHFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
	[CompilerGenerated]
	[FCONBELFMBI(typeof(MGJAGLMABBG), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : MGJAGLMABBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x868280", Offset = "0x866880", VA = "0x180868280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x69BCAD0", Offset = "0x69BB0D0", VA = "0x1869BCAD0")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x69B8050", Offset = "0x69B6650", VA = "0x1869B8050")]
		private void FKEGOKCKKMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x69C2510", Offset = "0x69C0B10", VA = "0x1869C2510")]
		public static Type[] HMACCOHADEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x69C2610", Offset = "0x69C0C10", VA = "0x1869C2610")]
		private static void NECNOABNHFL()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x69C4D90", Offset = "0x69C3390", VA = "0x1869C4D90")]
		public void NECNOABNHFL(FONNCKCINIP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x69C3ED0", Offset = "0x69C24D0", VA = "0x1869C3ED0")]
		private void GBLKJDMPKHH(FONNCKCINIP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x31F1CB0", Offset = "0x31F02B0", VA = "0x1831F1CB0")]
		private void DFEGFHOHGBB<T>(FONNCKCINIP registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
[FCONBELFMBI(typeof(MFODPGOCJBB), new string[] { "Registry" })]
internal class PGHDEKCNEJO : MFODPGOCJBB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Type PAFBAHBHCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x69C25B0", Offset = "0x69C0BB0", VA = "0x1869C25B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Type[] NDPNDMHCFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x69C2510", Offset = "0x69C0B10", VA = "0x1869C2510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Type[] LOGDELNIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x69C25A0", Offset = "0x69C0BA0", VA = "0x1869C25A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public (Type type, long min, long max)[] AFJJOJNOGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x69C2590", Offset = "0x69C0B90", VA = "0x1869C2590", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69C2570", Offset = "0x69C0B70", VA = "0x1869C2570", Slot = "8")]
	public void GAGFOMHMMIE(FONNCKCINIP KKCNEBNFMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PGHDEKCNEJO()
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
