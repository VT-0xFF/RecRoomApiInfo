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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
	public class _AssemblyIndex : GGAMJMDOFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HCDJNOEMFDF bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1336400", Offset = "0x1335400", VA = "0x181336400", Slot = "5")]
		public override void FECPPHBOIKG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6151B80", Offset = "0x6150B80", VA = "0x186151B80")]
		private void MMMABEIHAIP(LBOIHOEMEKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6151B20", Offset = "0x6150B20", VA = "0x186151B20", Slot = "6")]
		public override void BPJLBOBFIFD(LBOIHOEMEKD registry, [In] OFPCFOAIPIF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
		public override void PKDINHKFILI(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6151E00", Offset = "0x6150E00", VA = "0x186151E00")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x614CA20", Offset = "0x614BA20", VA = "0x18614CA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : MCEIKOOOBMF<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly NIBIGOIHKOG<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6144FF0", Offset = "0x6143FF0", VA = "0x186144FF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly BLMOCAEMMLB<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x614C8D0", Offset = "0x614B8D0", VA = "0x18614C8D0")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool initalizedDefaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x614CEF0", Offset = "0x614BEF0", VA = "0x18614CEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x614CF50", Offset = "0x614BF50", VA = "0x18614CF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x614CFF0", Offset = "0x614BFF0", VA = "0x18614CFF0")]
		public bool KOKGMCAIFIL(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x614CE90", Offset = "0x614BE90", VA = "0x18614CE90")]
		public bool CGIHMJMGIDM(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Preserve]
	[CompilerGenerated]
	public class PersistentUserTagDataProperties : MCEIKOOOBMF<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly NIBIGOIHKOG<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly NIBIGOIHKOG<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6145170", Offset = "0x6144170", VA = "0x186145170")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly BLMOCAEMMLB<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly BLMOCAEMMLB<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x614CCB0", Offset = "0x614BCB0", VA = "0x18614CCB0")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::PJCJCOBMFCM]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::DJMGDJBDIKC(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61449A0", Offset = "0x61439A0", VA = "0x1861449A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : MCEIKOOOBMF<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly NIBIGOIHKOG<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61464F0", Offset = "0x61454F0", VA = "0x1861464F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BLMOCAEMMLB<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6144850", Offset = "0x6143850", VA = "0x186144850")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6150090", Offset = "0x614F090", VA = "0x186150090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61501A0", Offset = "0x614F1A0", VA = "0x1861501A0")]
		public float3 LEBHKLBJCKO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6150130", Offset = "0x614F130", VA = "0x186150130")]
		public bool HKMMFEGNPDJ(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointScaleDataProperties : MCEIKOOOBMF<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly NIBIGOIHKOG<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6145A20", Offset = "0x6144A20", VA = "0x186145A20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly BLMOCAEMMLB<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x614FF40", Offset = "0x614EF40", VA = "0x18614FF40")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6144E10", Offset = "0x6143E10", VA = "0x186144E10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : MCEIKOOOBMF<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly NIBIGOIHKOG<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6145AA0", Offset = "0x6144AA0", VA = "0x186145AA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly BLMOCAEMMLB<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6144CC0", Offset = "0x6143CC0", VA = "0x186144CC0")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FixedList32Bytes<int> tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6144770", Offset = "0x6143770", VA = "0x186144770")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61445A0", Offset = "0x61435A0", VA = "0x1861445A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6144520", Offset = "0x6143520", VA = "0x186144520")]
		public FixedList32Bytes<int> EONGHNMBJNC()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61446A0", Offset = "0x61436A0", VA = "0x1861446A0")]
		public bool KOKGMCAIFIL(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61444C0", Offset = "0x61434C0", VA = "0x1861444C0")]
		public bool AAIBNKIPICD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6144710", Offset = "0x6143710", VA = "0x186144710")]
		public bool MFAINHFAPBM(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61447F0", Offset = "0x61437F0", VA = "0x1861447F0")]
		public KNJALDOLDFP PLEHOJLNAAJ()
		{
			return default(KNJALDOLDFP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6144640", Offset = "0x6143640", VA = "0x186144640")]
		public bool IDNEGDHMFJE(KNJALDOLDFP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : MCEIKOOOBMF<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly NIBIGOIHKOG<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly NIBIGOIHKOG<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly NIBIGOIHKOG<KNJALDOLDFP> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61452C0", Offset = "0x61442C0", VA = "0x1861452C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly BLMOCAEMMLB<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly BLMOCAEMMLB<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly BLMOCAEMMLB<KNJALDOLDFP> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6144260", Offset = "0x6143260", VA = "0x186144260")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override InteractionFilterDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6137150", Offset = "0x6136150", VA = "0x186137150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Preserve]
	[CompilerGenerated]
	public class ComponentSerializedVersionDataProperties : MCEIKOOOBMF<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly NIBIGOIHKOG<MBBLILPOINK> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6144F70", Offset = "0x6143F70", VA = "0x186144F70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly BLMOCAEMMLB<MBBLILPOINK> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6137000", Offset = "0x6136000", VA = "0x186137000")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x614F670", Offset = "0x614E670", VA = "0x18614F670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x614F610", Offset = "0x614E610", VA = "0x18614F610")]
		public bool CPGPAJDJMNO(HFCIOEOECBJ value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : MCEIKOOOBMF<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly NIBIGOIHKOG<HFCIOEOECBJ> order;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61465F0", Offset = "0x61455F0", VA = "0x1861465F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly BLMOCAEMMLB<HFCIOEOECBJ> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x614F4C0", Offset = "0x614E4C0", VA = "0x18614F4C0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6143F40", Offset = "0x6142F40", VA = "0x186143F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : MCEIKOOOBMF<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly NIBIGOIHKOG<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x61455D0", Offset = "0x61445D0", VA = "0x1861455D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly BLMOCAEMMLB<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6143DF0", Offset = "0x6142DF0", VA = "0x186143DF0")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x614EF20", Offset = "0x614DF20", VA = "0x18614EF20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[CompilerGenerated]
	public class SerializedEmbodiedDataProperties : MCEIKOOOBMF<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x614EE90", Offset = "0x614DE90", VA = "0x18614EE90")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6144C20", Offset = "0x6143C20", VA = "0x186144C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : MCEIKOOOBMF<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly NIBIGOIHKOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly NIBIGOIHKOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6145C70", Offset = "0x6144C70", VA = "0x186145C70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly BLMOCAEMMLB<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly BLMOCAEMMLB<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6144A40", Offset = "0x6143A40", VA = "0x186144A40")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override LocalPoseDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x614EA10", Offset = "0x614DA10", VA = "0x18614EA10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectActiveStatusDataProperties : MCEIKOOOBMF<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly NIBIGOIHKOG<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6145E90", Offset = "0x6144E90", VA = "0x186145E90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly BLMOCAEMMLB<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x614E8C0", Offset = "0x614D8C0", VA = "0x18614E8C0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x614FE30", Offset = "0x614EE30", VA = "0x18614FE30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x614FDC0", Offset = "0x614EDC0", VA = "0x18614FDC0")]
		public quaternion BMGKNDJAELE()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x614FED0", Offset = "0x614EED0", VA = "0x18614FED0")]
		public bool MJIBMDHJICH(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : MCEIKOOOBMF<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public static readonly NIBIGOIHKOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x61454D0", Offset = "0x61444D0", VA = "0x1861454D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly BLMOCAEMMLB<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x614FC70", Offset = "0x614EC70", VA = "0x18614FC70")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x614FB60", Offset = "0x614EB60", VA = "0x18614FB60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x614FAE0", Offset = "0x614EAE0", VA = "0x18614FAE0")]
		public float3 CGJOHBGAJBF()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x614FC00", Offset = "0x614EC00", VA = "0x18614FC00")]
		public bool IHILKJELLHF(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointPositionDataProperties : MCEIKOOOBMF<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly NIBIGOIHKOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6145070", Offset = "0x6144070", VA = "0x186145070")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly BLMOCAEMMLB<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x614F990", Offset = "0x614E990", VA = "0x18614F990")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JIGEFLCICEA shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x614F460", Offset = "0x614E460", VA = "0x18614F460")]
			get
			{
				return default(JIGEFLCICEA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x614F3C0", Offset = "0x614E3C0", VA = "0x18614F3C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeTypeDataProperties : MCEIKOOOBMF<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly NIBIGOIHKOG<JIGEFLCICEA> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x61457D0", Offset = "0x61447D0", VA = "0x1861457D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly BLMOCAEMMLB<JIGEFLCICEA> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x614F270", Offset = "0x614E270", VA = "0x18614F270")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ShapeTypeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public MOFBPNJFCKE shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x614D6F0", Offset = "0x614C6F0", VA = "0x18614D6F0")]
			get
			{
				return default(MOFBPNJFCKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x614D5F0", Offset = "0x614C5F0", VA = "0x18614D5F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x614D690", Offset = "0x614C690", VA = "0x18614D690")]
		public MOFBPNJFCKE HFMDKCOGCNJ()
		{
			return default(MOFBPNJFCKE);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : MCEIKOOOBMF<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly NIBIGOIHKOG<MOFBPNJFCKE> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x61459A0", Offset = "0x61449A0", VA = "0x1861459A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly BLMOCAEMMLB<MOFBPNJFCKE> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x614D4A0", Offset = "0x614C4A0", VA = "0x18614D4A0")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x614EDF0", Offset = "0x614DDF0", VA = "0x18614EDF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : MCEIKOOOBMF<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly NIBIGOIHKOG<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6146320", Offset = "0x6145320", VA = "0x186146320")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly BLMOCAEMMLB<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x614ECA0", Offset = "0x614DCA0", VA = "0x18614ECA0")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ReplicatorDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x614D400", Offset = "0x614C400", VA = "0x18614D400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : MCEIKOOOBMF<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly NIBIGOIHKOG<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6145450", Offset = "0x6144450", VA = "0x186145450")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly BLMOCAEMMLB<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x614D2B0", Offset = "0x614C2B0", VA = "0x18614D2B0")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override PlayerScopeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x61441C0", Offset = "0x61431C0", VA = "0x1861441C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[Preserve]
	public class EntityBundlePartDataProperties : MCEIKOOOBMF<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly NIBIGOIHKOG<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly NIBIGOIHKOG<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6145D40", Offset = "0x6144D40", VA = "0x186145D40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly BLMOCAEMMLB<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly BLMOCAEMMLB<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6143FE0", Offset = "0x6142FE0", VA = "0x186143FE0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x614EC00", Offset = "0x614DC00", VA = "0x18614EC00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectOwnedByPlayerDataProperties : MCEIKOOOBMF<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly NIBIGOIHKOG<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6146150", Offset = "0x6145150", VA = "0x186146150")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly BLMOCAEMMLB<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x614EAB0", Offset = "0x614DAB0", VA = "0x18614EAB0")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x614BF80", Offset = "0x614AF80", VA = "0x18614BF80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : MCEIKOOOBMF<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly NIBIGOIHKOG<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly NIBIGOIHKOG<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6144EB0", Offset = "0x6143EB0", VA = "0x186144EB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly BLMOCAEMMLB<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly BLMOCAEMMLB<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x614BDB0", Offset = "0x614ADB0", VA = "0x18614BDB0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[global::PJCJCOBMFCM]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[global::DJMGDJBDIKC(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[global::DJMGDJBDIKC(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[global::DJMGDJBDIKC(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6136DC0", Offset = "0x6135DC0", VA = "0x186136DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : MCEIKOOOBMF<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly NIBIGOIHKOG<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6145F90", Offset = "0x6144F90", VA = "0x186145F90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly BLMOCAEMMLB<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6136C70", Offset = "0x6135C70", VA = "0x186136C70")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override AuthoredParentDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x61468A0", Offset = "0x61458A0", VA = "0x1861468A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6146940", Offset = "0x6145940", VA = "0x186146940")]
		public HPFLICBCNBK MICAMOFNAGO()
		{
			return default(HPFLICBCNBK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6146840", Offset = "0x6145840", VA = "0x186146840")]
		public bool BADMKMCJGPP(HPFLICBCNBK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : MCEIKOOOBMF<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly NIBIGOIHKOG<HPFLICBCNBK> mode;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6145BF0", Offset = "0x6144BF0", VA = "0x186145BF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly BLMOCAEMMLB<HPFLICBCNBK> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x61466F0", Offset = "0x61456F0", VA = "0x1861466F0")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6143A60", Offset = "0x6142A60", VA = "0x186143A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6143B70", Offset = "0x6142B70", VA = "0x186143B70")]
		public FixedString64Bytes OKIIELFOFHA()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6143B00", Offset = "0x6142B00", VA = "0x186143B00")]
		public bool OEBBNLKMOPI(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : MCEIKOOOBMF<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly NIBIGOIHKOG<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6146010", Offset = "0x6145010", VA = "0x186146010")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly BLMOCAEMMLB<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6143910", Offset = "0x6142910", VA = "0x186143910")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerNameDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x614F170", Offset = "0x614E170", VA = "0x18614F170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x614F210", Offset = "0x614E210", VA = "0x18614F210")]
		public DIPCEMIMPMH OHAGJCJIAPD()
		{
			return default(DIPCEMIMPMH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x614F110", Offset = "0x614E110", VA = "0x18614F110")]
		public bool AMNBLDDBLJM(DIPCEMIMPMH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeConfigDataProperties : MCEIKOOOBMF<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public static readonly NIBIGOIHKOG<DIPCEMIMPMH> flags;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6146670", Offset = "0x6145670", VA = "0x186146670")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly BLMOCAEMMLB<DIPCEMIMPMH> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x614EFC0", Offset = "0x614DFC0", VA = "0x18614EFC0")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ShapeConfigDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x614CC10", Offset = "0x614BC10", VA = "0x18614CC10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : MCEIKOOOBMF<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public static readonly NIBIGOIHKOG<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6145F10", Offset = "0x6144F10", VA = "0x186145F10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly BLMOCAEMMLB<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x614CAC0", Offset = "0x614BAC0", VA = "0x18614CAC0")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ParentDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61437B0", Offset = "0x61427B0", VA = "0x1861437B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6143850", Offset = "0x6142850", VA = "0x186143850")]
		public float LMGNLCJINFP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61438B0", Offset = "0x61428B0", VA = "0x1861438B0")]
		public bool NLFNGKOLJHK(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : MCEIKOOOBMF<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly NIBIGOIHKOG<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6145920", Offset = "0x6144920", VA = "0x186145920")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly BLMOCAEMMLB<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6143660", Offset = "0x6142660", VA = "0x186143660")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61369D0", Offset = "0x61359D0", VA = "0x1861369D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : MCEIKOOOBMF<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly NIBIGOIHKOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly NIBIGOIHKOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6145850", Offset = "0x6144850", VA = "0x186145850")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly BLMOCAEMMLB<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly BLMOCAEMMLB<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61367F0", Offset = "0x61357F0", VA = "0x1861367F0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x614C1F0", Offset = "0x614B1F0", VA = "0x18614C1F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : MCEIKOOOBMF<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly NIBIGOIHKOG<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly NIBIGOIHKOG<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6146090", Offset = "0x6145090", VA = "0x186146090")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly BLMOCAEMMLB<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly BLMOCAEMMLB<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x614C020", Offset = "0x614B020", VA = "0x18614C020")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6136BD0", Offset = "0x6135BD0", VA = "0x186136BD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : MCEIKOOOBMF<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly NIBIGOIHKOG<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6145E10", Offset = "0x6144E10", VA = "0x186145E10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly BLMOCAEMMLB<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6136A80", Offset = "0x6135A80", VA = "0x186136A80")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PIKEMHDKICN color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6150B00", Offset = "0x614FB00", VA = "0x186150B00")]
			get
			{
				return default(PIKEMHDKICN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KDGIIONBBNP material
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6150B60", Offset = "0x614FB60", VA = "0x186150B60")]
			get
			{
				return default(KDGIIONBBNP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6150A40", Offset = "0x614FA40", VA = "0x186150A40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6150CE0", Offset = "0x614FCE0", VA = "0x186150CE0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61509A0", Offset = "0x614F9A0", VA = "0x1861509A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6150AA0", Offset = "0x614FAA0", VA = "0x186150AA0")]
		public PIKEMHDKICN GLBFCENJFCP()
		{
			return default(PIKEMHDKICN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6150C80", Offset = "0x614FC80", VA = "0x186150C80")]
		public bool OKGOEJLLFLK(PIKEMHDKICN value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6150860", Offset = "0x614F860", VA = "0x186150860")]
		public KDGIIONBBNP DFMNIFKFNJG()
		{
			return default(KDGIIONBBNP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6150BC0", Offset = "0x614FBC0", VA = "0x186150BC0")]
		public bool NEACEJKDPLB(KDGIIONBBNP value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6150940", Offset = "0x614F940", VA = "0x186150940")]
		public float EFAOKFNNMDJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6150C20", Offset = "0x614FC20", VA = "0x186150C20")]
		public bool OHLELBPFGLK(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61508C0", Offset = "0x614F8C0", VA = "0x1861508C0")]
		public float3 DKLCFHPKGAO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x61507F0", Offset = "0x614F7F0", VA = "0x1861507F0")]
		public bool CGLOPCLMCEI(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[Preserve]
	public class StandardRenderableVisualDataProperties : MCEIKOOOBMF<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly NIBIGOIHKOG<PIKEMHDKICN> color;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly NIBIGOIHKOG<KDGIIONBBNP> material;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly NIBIGOIHKOG<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly NIBIGOIHKOG<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x61463A0", Offset = "0x61453A0", VA = "0x1861463A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly BLMOCAEMMLB<PIKEMHDKICN> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly BLMOCAEMMLB<KDGIIONBBNP> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly BLMOCAEMMLB<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly BLMOCAEMMLB<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6150500", Offset = "0x614F500", VA = "0x186150500")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6142CA0", Offset = "0x6141CA0", VA = "0x186142CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6142C40", Offset = "0x6141C40", VA = "0x186142C40")]
		public HLPMAFFHFPE BDBIMMOGFNM()
		{
			return default(HLPMAFFHFPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6142D40", Offset = "0x6141D40", VA = "0x186142D40")]
		public bool OBGIDOLJOGG(HLPMAFFHFPE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : MCEIKOOOBMF<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly NIBIGOIHKOG<HLPMAFFHFPE> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6145650", Offset = "0x6144650", VA = "0x186145650")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly BLMOCAEMMLB<HLPMAFFHFPE> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6142AF0", Offset = "0x6141AF0", VA = "0x186142AF0")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6143500", Offset = "0x6142500", VA = "0x186143500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6143600", Offset = "0x6142600", VA = "0x186143600")]
		public DCGLFJKGGOD PCHJEHDPLMD()
		{
			return default(DCGLFJKGGOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61435A0", Offset = "0x61425A0", VA = "0x1861435A0")]
		public bool FGPIELDCLOJ(DCGLFJKGGOD value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : MCEIKOOOBMF<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly NIBIGOIHKOG<DCGLFJKGGOD> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6146570", Offset = "0x6145570", VA = "0x186146570")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly BLMOCAEMMLB<DCGLFJKGGOD> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x61433B0", Offset = "0x61423B0", VA = "0x1861433B0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6143D50", Offset = "0x6142D50", VA = "0x186143D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : MCEIKOOOBMF<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly NIBIGOIHKOG<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6145240", Offset = "0x6144240", VA = "0x186145240")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly BLMOCAEMMLB<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6143C00", Offset = "0x6142C00", VA = "0x186143C00")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x61503F0", Offset = "0x614F3F0", VA = "0x1861503F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6150370", Offset = "0x614F370", VA = "0x186150370")]
		public MKFECDAPJFD BGPMDMMDMFC()
		{
			return default(MKFECDAPJFD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6150490", Offset = "0x614F490", VA = "0x186150490")]
		public bool JMHDCBCHDJA(MKFECDAPJFD value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : MCEIKOOOBMF<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly NIBIGOIHKOG<MKFECDAPJFD> parameters;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x6145550", Offset = "0x6144550", VA = "0x186145550")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly BLMOCAEMMLB<MKFECDAPJFD> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6150220", Offset = "0x614F220", VA = "0x186150220")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplineShapeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6150F40", Offset = "0x614FF40", VA = "0x186150F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	[CompilerGenerated]
	public class TransformFlagsDataProperties : MCEIKOOOBMF<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly NIBIGOIHKOG<JMJJMFCIOBF> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly NIBIGOIHKOG<OCNMEONOIHE> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6145B20", Offset = "0x6144B20", VA = "0x186145B20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly BLMOCAEMMLB<JMJJMFCIOBF> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly BLMOCAEMMLB<OCNMEONOIHE> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6150D60", Offset = "0x614FD60", VA = "0x186150D60")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override TransformFlagsDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6143200", Offset = "0x6142200", VA = "0x186143200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x61432A0", Offset = "0x61422A0", VA = "0x1861432A0")]
		public KPMECJNFOCC OHAGJCJIAPD()
		{
			return default(KPMECJNFOCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6143300", Offset = "0x6142300", VA = "0x186143300")]
		public void PPLLNONIPBP(KPMECJNFOCC flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : MCEIKOOOBMF<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly NIBIGOIHKOG<KPMECJNFOCC> flags;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x61456D0", Offset = "0x61446D0", VA = "0x1861456D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly BLMOCAEMMLB<KPMECJNFOCC> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x61430B0", Offset = "0x61420B0", VA = "0x1861430B0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[global::PJCJCOBMFCM]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[global::DJMGDJBDIKC(1)]
		public KPMECJNFOCC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public CDHFHDAPKFA collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x6142FF0", Offset = "0x6141FF0", VA = "0x186142FF0")]
			get
			{
				return default(CDHFHDAPKFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6142F50", Offset = "0x6141F50", VA = "0x186142F50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6142EF0", Offset = "0x6141EF0", VA = "0x186142EF0")]
		public CDHFHDAPKFA DBGJMMEAOPD()
		{
			return default(CDHFHDAPKFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6143050", Offset = "0x6142050", VA = "0x186143050")]
		public bool MEDBOFGGDCM(CDHFHDAPKFA value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : MCEIKOOOBMF<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly NIBIGOIHKOG<CDHFHDAPKFA> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x61450F0", Offset = "0x61440F0", VA = "0x1861450F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly BLMOCAEMMLB<CDHFHDAPKFA> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6142DA0", Offset = "0x6141DA0", VA = "0x186142DA0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x614D210", Offset = "0x614C210", VA = "0x18614D210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x614D1B0", Offset = "0x614C1B0", VA = "0x18614D1B0")]
		public bool BILAAEIIGPH(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : MCEIKOOOBMF<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly NIBIGOIHKOG<float> density;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6145750", Offset = "0x6144750", VA = "0x186145750")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly BLMOCAEMMLB<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x614D060", Offset = "0x614C060", VA = "0x18614D060")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public DIOGDHPIICB scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x614C7F0", Offset = "0x614B7F0", VA = "0x18614C7F0")]
			get
			{
				return default(DIOGDHPIICB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x614C580", Offset = "0x614B580", VA = "0x18614C580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x614C790", Offset = "0x614B790", VA = "0x18614C790")]
		public GBCMIJBHFFJ OHAGJCJIAPD()
		{
			return default(GBCMIJBHFFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x614C6D0", Offset = "0x614B6D0", VA = "0x18614C6D0")]
		public EPPCAEDGIAE IBJLABLGBGK()
		{
			return default(EPPCAEDGIAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x614C620", Offset = "0x614B620", VA = "0x18614C620")]
		public void HBNCDMEAHNI(EPPCAEDGIAE flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x614C730", Offset = "0x614B730", VA = "0x18614C730")]
		public FOIDHFLBELL NDPECOGHLNO()
		{
			return default(FOIDHFLBELL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x614C870", Offset = "0x614B870", VA = "0x18614C870")]
		public bool PIJKPMKBEFL(FOIDHFLBELL value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : MCEIKOOOBMF<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly NIBIGOIHKOG<DIOGDHPIICB> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly NIBIGOIHKOG<EPPCAEDGIAE> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly NIBIGOIHKOG<FOIDHFLBELL> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly NIBIGOIHKOG<GBCMIJBHFFJ> flags;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x61461D0", Offset = "0x61451D0", VA = "0x1861461D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly BLMOCAEMMLB<DIOGDHPIICB> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly BLMOCAEMMLB<EPPCAEDGIAE> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly BLMOCAEMMLB<FOIDHFLBELL> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly BLMOCAEMMLB<GBCMIJBHFFJ> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x614C290", Offset = "0x614B290", VA = "0x18614C290")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[global::PJCJCOBMFCM]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[global::DJMGDJBDIKC(1)]
		public GBCMIJBHFFJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[global::DJMGDJBDIKC(2)]
		public DIOGDHPIICB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[global::DJMGDJBDIKC(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	[global::PJCJCOBMFCM]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[global::DJMGDJBDIKC(1)]
		public GBCMIJBHFFJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[global::DJMGDJBDIKC(2)]
		public DIOGDHPIICB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::DJMGDJBDIKC(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::PJCJCOBMFCM]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[global::DJMGDJBDIKC(1)]
		public GBCMIJBHFFJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[global::DJMGDJBDIKC(2)]
		public DIOGDHPIICB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[global::DJMGDJBDIKC(3)]
		public EPPCAEDGIAE userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[global::PJCJCOBMFCM]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[global::DJMGDJBDIKC(2)]
		public DIOGDHPIICB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[global::DJMGDJBDIKC(3)]
		public EPPCAEDGIAE userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[global::DJMGDJBDIKC(1)]
		public GBCMIJBHFFJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : JIMDEJLCKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x614F860", Offset = "0x614E860", VA = "0x18614F860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6136A70", Offset = "0x6135A70", VA = "0x186136A70")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x614F900", Offset = "0x614E900", VA = "0x18614F900")]
		public bool OOCDDDHBEFD(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : MCEIKOOOBMF<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly NIBIGOIHKOG<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x61453D0", Offset = "0x61443D0", VA = "0x1861453D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly BLMOCAEMMLB<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly BFHJGOOAAIN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override BFHJGOOAAIN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x614F710", Offset = "0x614E710", VA = "0x18614F710")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x61357D0", VA = "0x1861367D0", Slot = "16")]
		protected internal override SplinePointParentDataWrapper FKHEOKLOIFH(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x61371F0", Offset = "0x61361F0", VA = "0x1861371F0")]
		public static (long, string, string) LNCMBAEGOPK(EFKHMPACCDB value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6138DD0", Offset = "0x6137DD0", VA = "0x186138DD0")]
		public static (long, string, string)[] OJFHDDHHAIP(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6136FA0", Offset = "0x6135FA0", VA = "0x186136FA0")]
		public static Type[] GFIFJEIJPCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x61469A0", Offset = "0x61459A0", VA = "0x1861469A0")]
		private static void PCEAKBMIBLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6136F40", Offset = "0x6135F40", VA = "0x186136F40")]
		public static (Type, long, long)[] GFIFJEIJPCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6147B70", Offset = "0x6146B70", VA = "0x186147B70")]
		private static void PCEAKBMIBLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	[PFJACEDCDHI(DIENCAJKNHD.Application)]
	[PMGKIFLEIJE(typeof(FIACICBJNHJ), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : FIACICBJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x614BD90", Offset = "0x614AD90", VA = "0x18614BD90")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6148790", Offset = "0x6147790", VA = "0x186148790")]
		private void DFBLEHMKABO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6136EC0", Offset = "0x6135EC0", VA = "0x186136EC0")]
		public static Type[] GFIFJEIJPCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x614D750", Offset = "0x614C750", VA = "0x18614D750")]
		private static void PCEAKBMIBLF()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6151B10", Offset = "0x6150B10", VA = "0x186151B10")]
		public void PCEAKBMIBLF(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6150FE0", Offset = "0x614FFE0", VA = "0x186150FE0")]
		private void JNIMJOALPGB(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DAB0", Offset = "0x2D2CAB0", VA = "0x182D2DAB0")]
		private void NHBOMKJCCKF<T>(DOOENEHKPHI registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PMGKIFLEIJE(typeof(JNPFAFNKOGN), new string[] { "Registry" })]
[PFJACEDCDHI(DIENCAJKNHD.Application)]
internal class BCONNOOCMCC : JNPFAFNKOGN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Type KKCACKDPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6136E60", Offset = "0x6135E60", VA = "0x186136E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type[] KLCLLEAIDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6136EC0", Offset = "0x6135EC0", VA = "0x186136EC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Type[] NAPPLPKADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6136FA0", Offset = "0x6135FA0", VA = "0x186136FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public (Type type, long min, long max)[] CKJBBIFEHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6136F40", Offset = "0x6135F40", VA = "0x186136F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6136F20", Offset = "0x6135F20", VA = "0x186136F20", Slot = "8")]
	public void KJFOADOIJLF(DOOENEHKPHI FOMHOPBANOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BCONNOOCMCC()
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
