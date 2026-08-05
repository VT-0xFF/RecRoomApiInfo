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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
	public class _AssemblyIndex : LHJJEIDOJLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private IPMDCNDONNF bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x133F970", Offset = "0x133ED70", VA = "0x18133F970", Slot = "5")]
		public override void EPIKBAOIJJD(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x617CD30", Offset = "0x617C130", VA = "0x18617CD30")]
		private void LCMBPGOKGFP(MKELEIBDMMM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x617CCD0", Offset = "0x617C0D0", VA = "0x18617CCD0", Slot = "6")]
		public override void HDPKBLFAOGN(MKELEIBDMMM registry, [In] CHMHKFPJJIN filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
		public override void AOEHIAAJNNJ(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x617CFB0", Offset = "0x617C3B0", VA = "0x18617CFB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6177AF0", Offset = "0x6176EF0", VA = "0x186177AF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : HMADGEFEGFK<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly FPIAKKBMKOD<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6170000", Offset = "0x616F400", VA = "0x186170000")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly OLDJDOOGOCO<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61779A0", Offset = "0x6176DA0", VA = "0x1861779A0")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : OPOEDDCBANK
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
			[Cpp2IlInjected.Address(RVA = "0x6178140", Offset = "0x6177540", VA = "0x186178140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6178040", Offset = "0x6177440", VA = "0x186178040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61781A0", Offset = "0x61775A0", VA = "0x1861781A0")]
		public bool NIEAMDHKBPM(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x61780E0", Offset = "0x61774E0", VA = "0x1861780E0")]
		public bool HFKEMLABLMH(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Preserve]
	[CompilerGenerated]
	public class PersistentUserTagDataProperties : HMADGEFEGFK<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly FPIAKKBMKOD<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly FPIAKKBMKOD<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6170180", Offset = "0x616F580", VA = "0x186170180")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly OLDJDOOGOCO<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly OLDJDOOGOCO<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6177E60", Offset = "0x6177260", VA = "0x186177E60")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::BEOLILAPHFD]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::ALGMDGFOCIH(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x616F9B0", Offset = "0x616EDB0", VA = "0x18616F9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : HMADGEFEGFK<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly FPIAKKBMKOD<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6171500", Offset = "0x6170900", VA = "0x186171500")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OLDJDOOGOCO<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x616F860", Offset = "0x616EC60", VA = "0x18616F860")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x617B240", Offset = "0x617A640", VA = "0x18617B240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x617B2E0", Offset = "0x617A6E0", VA = "0x18617B2E0")]
		public float3 FKOALEGIPAJ()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x617B360", Offset = "0x617A760", VA = "0x18617B360")]
		public bool IGGDCPNKOAE(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointScaleDataProperties : HMADGEFEGFK<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly FPIAKKBMKOD<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6170A30", Offset = "0x616FE30", VA = "0x186170A30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly OLDJDOOGOCO<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x617B0F0", Offset = "0x617A4F0", VA = "0x18617B0F0")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x616FE20", Offset = "0x616F220", VA = "0x18616FE20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : HMADGEFEGFK<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly FPIAKKBMKOD<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6170AB0", Offset = "0x616FEB0", VA = "0x186170AB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly OLDJDOOGOCO<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x616FCD0", Offset = "0x616F0D0", VA = "0x18616FCD0")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : OPOEDDCBANK
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
			[Cpp2IlInjected.Address(RVA = "0x616F770", Offset = "0x616EB70", VA = "0x18616F770")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x616F610", Offset = "0x616EA10", VA = "0x18616F610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x616F530", Offset = "0x616E930", VA = "0x18616F530")]
		public FixedList32Bytes<int> AMGBEIIMIBL()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x616F7F0", Offset = "0x616EBF0", VA = "0x18616F7F0")]
		public bool NIEAMDHKBPM(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x616F5B0", Offset = "0x616E9B0", VA = "0x18616F5B0")]
		public bool DBJJCOCPANM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x616F710", Offset = "0x616EB10", VA = "0x18616F710")]
		public bool MBMMHOMPCKP(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x616F4D0", Offset = "0x616E8D0", VA = "0x18616F4D0")]
		public HDKDOHKGHDF ADCNODIJHEC()
		{
			return default(HDKDOHKGHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x616F6B0", Offset = "0x616EAB0", VA = "0x18616F6B0")]
		public bool FCMMHBMLDII(HDKDOHKGHDF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : HMADGEFEGFK<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly FPIAKKBMKOD<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly FPIAKKBMKOD<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly FPIAKKBMKOD<HDKDOHKGHDF> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61702D0", Offset = "0x616F6D0", VA = "0x1861702D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly OLDJDOOGOCO<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly OLDJDOOGOCO<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly OLDJDOOGOCO<HDKDOHKGHDF> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x616F270", Offset = "0x616E670", VA = "0x18616F270")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override InteractionFilterDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6162160", Offset = "0x6161560", VA = "0x186162160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Preserve]
	[CompilerGenerated]
	public class ComponentSerializedVersionDataProperties : HMADGEFEGFK<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly FPIAKKBMKOD<EGGEHHFFOFC> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x616FF80", Offset = "0x616F380", VA = "0x18616FF80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly OLDJDOOGOCO<EGGEHHFFOFC> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6162010", Offset = "0x6161410", VA = "0x186162010")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x617A7C0", Offset = "0x6179BC0", VA = "0x18617A7C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x617A860", Offset = "0x6179C60", VA = "0x18617A860")]
		public bool FOLLLHHJKLM(PPGMDHCJPMB value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : HMADGEFEGFK<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly FPIAKKBMKOD<PPGMDHCJPMB> order;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6171600", Offset = "0x6170A00", VA = "0x186171600")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly OLDJDOOGOCO<PPGMDHCJPMB> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x617A670", Offset = "0x6179A70", VA = "0x18617A670")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x616EF50", Offset = "0x616E350", VA = "0x18616EF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : HMADGEFEGFK<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly FPIAKKBMKOD<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x61705E0", Offset = "0x616F9E0", VA = "0x1861705E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly OLDJDOOGOCO<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x616EE00", Offset = "0x616E200", VA = "0x18616EE00")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x617A0D0", Offset = "0x61794D0", VA = "0x18617A0D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[CompilerGenerated]
	public class SerializedEmbodiedDataProperties : HMADGEFEGFK<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x617A040", Offset = "0x6179440", VA = "0x18617A040")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x616FC30", Offset = "0x616F030", VA = "0x18616FC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : HMADGEFEGFK<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly FPIAKKBMKOD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly FPIAKKBMKOD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6170C80", Offset = "0x6170080", VA = "0x186170C80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly OLDJDOOGOCO<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly OLDJDOOGOCO<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x616FA50", Offset = "0x616EE50", VA = "0x18616FA50")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override LocalPoseDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6179BC0", Offset = "0x6178FC0", VA = "0x186179BC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectActiveStatusDataProperties : HMADGEFEGFK<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly FPIAKKBMKOD<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6170EA0", Offset = "0x61702A0", VA = "0x186170EA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly OLDJDOOGOCO<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6179A70", Offset = "0x6178E70", VA = "0x186179A70")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x617AF70", Offset = "0x617A370", VA = "0x18617AF70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x617B080", Offset = "0x617A480", VA = "0x18617B080")]
		public quaternion OLFPBDLPOMD()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x617B010", Offset = "0x617A410", VA = "0x18617B010")]
		public bool GEGGLIPAKOD(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : HMADGEFEGFK<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public static readonly FPIAKKBMKOD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x61704E0", Offset = "0x616F8E0", VA = "0x1861704E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly OLDJDOOGOCO<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x617AE20", Offset = "0x617A220", VA = "0x18617AE20")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x617AD00", Offset = "0x617A100", VA = "0x18617AD00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x617ADA0", Offset = "0x617A1A0", VA = "0x18617ADA0")]
		public float3 NOCDIBEICMO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x617AC90", Offset = "0x617A090", VA = "0x18617AC90")]
		public bool BIFMCELJLNA(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointPositionDataProperties : HMADGEFEGFK<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly FPIAKKBMKOD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6170080", Offset = "0x616F480", VA = "0x186170080")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly OLDJDOOGOCO<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x617AB40", Offset = "0x6179F40", VA = "0x18617AB40")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AFBGGHLJJLI shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x617A570", Offset = "0x6179970", VA = "0x18617A570")]
			get
			{
				return default(AFBGGHLJJLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x617A5D0", Offset = "0x61799D0", VA = "0x18617A5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeTypeDataProperties : HMADGEFEGFK<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly FPIAKKBMKOD<AFBGGHLJJLI> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x61707E0", Offset = "0x616FBE0", VA = "0x1861707E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly OLDJDOOGOCO<AFBGGHLJJLI> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x617A420", Offset = "0x6179820", VA = "0x18617A420")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ShapeTypeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public HAONKCOIBBF shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x61787A0", Offset = "0x6177BA0", VA = "0x1861787A0")]
			get
			{
				return default(HAONKCOIBBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6178800", Offset = "0x6177C00", VA = "0x186178800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61788A0", Offset = "0x6177CA0", VA = "0x1861788A0")]
		public HAONKCOIBBF LJDIBOOPKJL()
		{
			return default(HAONKCOIBBF);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : HMADGEFEGFK<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly FPIAKKBMKOD<HAONKCOIBBF> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x61709B0", Offset = "0x616FDB0", VA = "0x1861709B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly OLDJDOOGOCO<HAONKCOIBBF> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6178650", Offset = "0x6177A50", VA = "0x186178650")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6179FA0", Offset = "0x61793A0", VA = "0x186179FA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : HMADGEFEGFK<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly FPIAKKBMKOD<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6171330", Offset = "0x6170730", VA = "0x186171330")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly OLDJDOOGOCO<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6179E50", Offset = "0x6179250", VA = "0x186179E50")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ReplicatorDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61785B0", Offset = "0x61779B0", VA = "0x1861785B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : HMADGEFEGFK<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly FPIAKKBMKOD<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6170460", Offset = "0x616F860", VA = "0x186170460")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly OLDJDOOGOCO<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6178460", Offset = "0x6177860", VA = "0x186178460")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override PlayerScopeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x616F1D0", Offset = "0x616E5D0", VA = "0x18616F1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[Preserve]
	public class EntityBundlePartDataProperties : HMADGEFEGFK<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly FPIAKKBMKOD<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly FPIAKKBMKOD<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6170D50", Offset = "0x6170150", VA = "0x186170D50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly OLDJDOOGOCO<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly OLDJDOOGOCO<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x616EFF0", Offset = "0x616E3F0", VA = "0x18616EFF0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6179DB0", Offset = "0x61791B0", VA = "0x186179DB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectOwnedByPlayerDataProperties : HMADGEFEGFK<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly FPIAKKBMKOD<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6171160", Offset = "0x6170560", VA = "0x186171160")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly OLDJDOOGOCO<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6179C60", Offset = "0x6179060", VA = "0x186179C60")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6177050", Offset = "0x6176450", VA = "0x186177050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : HMADGEFEGFK<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly FPIAKKBMKOD<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly FPIAKKBMKOD<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x616FEC0", Offset = "0x616F2C0", VA = "0x18616FEC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly OLDJDOOGOCO<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly OLDJDOOGOCO<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6176E80", Offset = "0x6176280", VA = "0x186176E80")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[global::BEOLILAPHFD]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[global::ALGMDGFOCIH(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[global::ALGMDGFOCIH(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[global::ALGMDGFOCIH(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6161F70", Offset = "0x6161370", VA = "0x186161F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : HMADGEFEGFK<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly FPIAKKBMKOD<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6170FA0", Offset = "0x61703A0", VA = "0x186170FA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly OLDJDOOGOCO<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6161E20", Offset = "0x6161220", VA = "0x186161E20")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override AuthoredParentDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6171910", Offset = "0x6170D10", VA = "0x186171910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61718B0", Offset = "0x6170CB0", VA = "0x1861718B0")]
		public BJGHBAAOJAL BPDINEPIKHC()
		{
			return default(BJGHBAAOJAL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6171850", Offset = "0x6170C50", VA = "0x186171850")]
		public bool AIINKAGFKOF(BJGHBAAOJAL value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : HMADGEFEGFK<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly FPIAKKBMKOD<BJGHBAAOJAL> mode;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6170C00", Offset = "0x6170000", VA = "0x186170C00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly OLDJDOOGOCO<BJGHBAAOJAL> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6171700", Offset = "0x6170B00", VA = "0x186171700")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x616EB00", Offset = "0x616DF00", VA = "0x18616EB00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x616EA70", Offset = "0x616DE70", VA = "0x18616EA70")]
		public FixedString64Bytes CBMPFCPNGNG()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x616EBA0", Offset = "0x616DFA0", VA = "0x18616EBA0")]
		public bool JCANOKNBMLI(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : HMADGEFEGFK<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly FPIAKKBMKOD<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6171020", Offset = "0x6170420", VA = "0x186171020")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly OLDJDOOGOCO<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x616E920", Offset = "0x616DD20", VA = "0x18616E920")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerNameDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x617A320", Offset = "0x6179720", VA = "0x18617A320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x617A2C0", Offset = "0x61796C0", VA = "0x18617A2C0")]
		public KAKHEKABOPI DPNNOJBEJDI()
		{
			return default(KAKHEKABOPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x617A3C0", Offset = "0x61797C0", VA = "0x18617A3C0")]
		public bool IENBBHAHGIB(KAKHEKABOPI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeConfigDataProperties : HMADGEFEGFK<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public static readonly FPIAKKBMKOD<KAKHEKABOPI> flags;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6171680", Offset = "0x6170A80", VA = "0x186171680")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly OLDJDOOGOCO<KAKHEKABOPI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x617A170", Offset = "0x6179570", VA = "0x18617A170")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ShapeConfigDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6177DC0", Offset = "0x61771C0", VA = "0x186177DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : HMADGEFEGFK<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public static readonly FPIAKKBMKOD<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6170F20", Offset = "0x6170320", VA = "0x186170F20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly OLDJDOOGOCO<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6177C70", Offset = "0x6177070", VA = "0x186177C70")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ParentDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x616E820", Offset = "0x616DC20", VA = "0x18616E820", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x616E7C0", Offset = "0x616DBC0", VA = "0x18616E7C0")]
		public float DJMIKPBNMJG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x616E8C0", Offset = "0x616DCC0", VA = "0x18616E8C0")]
		public bool MJCGLFKPKBH(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : HMADGEFEGFK<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly FPIAKKBMKOD<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6170930", Offset = "0x616FD30", VA = "0x186170930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly OLDJDOOGOCO<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x616E670", Offset = "0x616DA70", VA = "0x18616E670")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6161B80", Offset = "0x6160F80", VA = "0x186161B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : HMADGEFEGFK<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly FPIAKKBMKOD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly FPIAKKBMKOD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6170860", Offset = "0x616FC60", VA = "0x186170860")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly OLDJDOOGOCO<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly OLDJDOOGOCO<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61619A0", Offset = "0x6160DA0", VA = "0x1861619A0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61772C0", Offset = "0x61766C0", VA = "0x1861772C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : HMADGEFEGFK<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly FPIAKKBMKOD<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly FPIAKKBMKOD<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x61710A0", Offset = "0x61704A0", VA = "0x1861710A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly OLDJDOOGOCO<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly OLDJDOOGOCO<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61770F0", Offset = "0x61764F0", VA = "0x1861770F0")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6161D80", Offset = "0x6161180", VA = "0x186161D80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : HMADGEFEGFK<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly FPIAKKBMKOD<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6170E20", Offset = "0x6170220", VA = "0x186170E20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly OLDJDOOGOCO<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6161C30", Offset = "0x6161030", VA = "0x186161C30")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KBFMLIPEAPB color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x617BAC0", Offset = "0x617AEC0", VA = "0x18617BAC0")]
			get
			{
				return default(KBFMLIPEAPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GFPPGPNCOOG material
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x617BA00", Offset = "0x617AE00", VA = "0x18617BA00")]
			get
			{
				return default(GFPPGPNCOOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x617B9A0", Offset = "0x617ADA0", VA = "0x18617B9A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x617BDB0", Offset = "0x617B1B0", VA = "0x18617BDB0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x617BB20", Offset = "0x617AF20", VA = "0x18617BB20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x617BBC0", Offset = "0x617AFC0", VA = "0x18617BBC0")]
		public KBFMLIPEAPB FFGFDFBJFCC()
		{
			return default(KBFMLIPEAPB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x617BD50", Offset = "0x617B150", VA = "0x18617BD50")]
		public bool KDNIOPCBKKB(KBFMLIPEAPB value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x617BC20", Offset = "0x617B020", VA = "0x18617BC20")]
		public GFPPGPNCOOG FPNHFHKCAOE()
		{
			return default(GFPPGPNCOOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x617BE30", Offset = "0x617B230", VA = "0x18617BE30")]
		public bool MGDEIINGPEM(GFPPGPNCOOG value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x617BA60", Offset = "0x617AE60", VA = "0x18617BA60")]
		public float ENHHHEJNKIM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x617BC80", Offset = "0x617B080", VA = "0x18617BC80")]
		public bool IFGOEPPDKIA(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x617BE90", Offset = "0x617B290", VA = "0x18617BE90")]
		public float3 ODLIKHBJLJC()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x617BCE0", Offset = "0x617B0E0", VA = "0x18617BCE0")]
		public bool JKMHFOGPMEA(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[Preserve]
	public class StandardRenderableVisualDataProperties : HMADGEFEGFK<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly FPIAKKBMKOD<KBFMLIPEAPB> color;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly FPIAKKBMKOD<GFPPGPNCOOG> material;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly FPIAKKBMKOD<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly FPIAKKBMKOD<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x61713B0", Offset = "0x61707B0", VA = "0x1861713B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly OLDJDOOGOCO<KBFMLIPEAPB> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly OLDJDOOGOCO<GFPPGPNCOOG> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly OLDJDOOGOCO<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly OLDJDOOGOCO<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x617B6B0", Offset = "0x617AAB0", VA = "0x18617B6B0")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x616DC50", Offset = "0x616D050", VA = "0x18616DC50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x616DCF0", Offset = "0x616D0F0", VA = "0x18616DCF0")]
		public LNDIEOGLFMH FCGOKPNGDDG()
		{
			return default(LNDIEOGLFMH);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x616DD50", Offset = "0x616D150", VA = "0x18616DD50")]
		public bool PLIMHFHEJAG(LNDIEOGLFMH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : HMADGEFEGFK<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly FPIAKKBMKOD<LNDIEOGLFMH> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6170660", Offset = "0x616FA60", VA = "0x186170660")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly OLDJDOOGOCO<LNDIEOGLFMH> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x616DB00", Offset = "0x616CF00", VA = "0x18616DB00")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x616E510", Offset = "0x616D910", VA = "0x18616E510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x616E610", Offset = "0x616DA10", VA = "0x18616E610")]
		public HOMFGJBFHLH NMAIIEMANIP()
		{
			return default(HOMFGJBFHLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x616E5B0", Offset = "0x616D9B0", VA = "0x18616E5B0")]
		public bool LOIDIMOBCJO(HOMFGJBFHLH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : HMADGEFEGFK<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly FPIAKKBMKOD<HOMFGJBFHLH> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6171580", Offset = "0x6170980", VA = "0x186171580")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly OLDJDOOGOCO<HOMFGJBFHLH> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x616E3C0", Offset = "0x616D7C0", VA = "0x18616E3C0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x616ED60", Offset = "0x616E160", VA = "0x18616ED60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : HMADGEFEGFK<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly FPIAKKBMKOD<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6170250", Offset = "0x616F650", VA = "0x186170250")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly OLDJDOOGOCO<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x616EC10", Offset = "0x616E010", VA = "0x18616EC10")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x617B5A0", Offset = "0x617A9A0", VA = "0x18617B5A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x617B520", Offset = "0x617A920", VA = "0x18617B520")]
		public BKOJBAGNAGP CFAIMLEFBOE()
		{
			return default(BKOJBAGNAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x617B640", Offset = "0x617AA40", VA = "0x18617B640")]
		public bool OAKMCIJIAKE(BKOJBAGNAGP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : HMADGEFEGFK<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly FPIAKKBMKOD<BKOJBAGNAGP> parameters;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x6170560", Offset = "0x616F960", VA = "0x186170560")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly OLDJDOOGOCO<BKOJBAGNAGP> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x617B3D0", Offset = "0x617A7D0", VA = "0x18617B3D0")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplineShapeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x617C0F0", Offset = "0x617B4F0", VA = "0x18617C0F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	[CompilerGenerated]
	public class TransformFlagsDataProperties : HMADGEFEGFK<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly FPIAKKBMKOD<OMBMLIKMBNC> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly FPIAKKBMKOD<OPGEGPMBAAC> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6170B30", Offset = "0x616FF30", VA = "0x186170B30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly OLDJDOOGOCO<OMBMLIKMBNC> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly OLDJDOOGOCO<OPGEGPMBAAC> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x617BF10", Offset = "0x617B310", VA = "0x18617BF10")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override TransformFlagsDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x616E270", Offset = "0x616D670", VA = "0x18616E270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x616E210", Offset = "0x616D610", VA = "0x18616E210")]
		public OCIFAGNHLMI DPNNOJBEJDI()
		{
			return default(OCIFAGNHLMI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x616E310", Offset = "0x616D710", VA = "0x18616E310")]
		public void HHNBIIEAPBL(OCIFAGNHLMI flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : HMADGEFEGFK<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly FPIAKKBMKOD<OCIFAGNHLMI> flags;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x61706E0", Offset = "0x616FAE0", VA = "0x1861706E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly OLDJDOOGOCO<OCIFAGNHLMI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x616E0C0", Offset = "0x616D4C0", VA = "0x18616E0C0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[global::BEOLILAPHFD]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[global::ALGMDGFOCIH(1)]
		public OCIFAGNHLMI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public GIHHPODLHAH collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x616E060", Offset = "0x616D460", VA = "0x18616E060")]
			get
			{
				return default(GIHHPODLHAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x616DF00", Offset = "0x616D300", VA = "0x18616DF00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x616E000", Offset = "0x616D400", VA = "0x18616E000")]
		public GIHHPODLHAH KCKCPLIFDNA()
		{
			return default(GIHHPODLHAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x616DFA0", Offset = "0x616D3A0", VA = "0x18616DFA0")]
		public bool FAINFPGPLOF(GIHHPODLHAH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : HMADGEFEGFK<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly FPIAKKBMKOD<GIHHPODLHAH> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x6170100", Offset = "0x616F500", VA = "0x186170100")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly OLDJDOOGOCO<GIHHPODLHAH> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x616DDB0", Offset = "0x616D1B0", VA = "0x18616DDB0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6178360", Offset = "0x6177760", VA = "0x186178360", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6178400", Offset = "0x6177800", VA = "0x186178400")]
		public bool MFOMEFBIEKK(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : HMADGEFEGFK<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly FPIAKKBMKOD<float> density;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6170760", Offset = "0x616FB60", VA = "0x186170760")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly OLDJDOOGOCO<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6178210", Offset = "0x6177610", VA = "0x186178210")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public JMPHIPJKBMO scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x61777C0", Offset = "0x6176BC0", VA = "0x1861777C0")]
			get
			{
				return default(JMPHIPJKBMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6177840", Offset = "0x6176C40", VA = "0x186177840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6177760", Offset = "0x6176B60", VA = "0x186177760")]
		public LOOPLOFJENM DPNNOJBEJDI()
		{
			return default(LOOPLOFJENM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6177940", Offset = "0x6176D40", VA = "0x186177940")]
		public LPMEJADPGOH PMCNMEPPOJI()
		{
			return default(LPMEJADPGOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6177650", Offset = "0x6176A50", VA = "0x186177650")]
		public void APOCJONDAJL(LPMEJADPGOH flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x61778E0", Offset = "0x6176CE0", VA = "0x1861778E0")]
		public DOMGPPLBLAL JAEJCNCIACI()
		{
			return default(DOMGPPLBLAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6177700", Offset = "0x6176B00", VA = "0x186177700")]
		public bool DLKACFKPCJM(DOMGPPLBLAL value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : HMADGEFEGFK<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly FPIAKKBMKOD<JMPHIPJKBMO> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly FPIAKKBMKOD<LPMEJADPGOH> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly FPIAKKBMKOD<DOMGPPLBLAL> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly FPIAKKBMKOD<LOOPLOFJENM> flags;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x61711E0", Offset = "0x61705E0", VA = "0x1861711E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly OLDJDOOGOCO<JMPHIPJKBMO> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly OLDJDOOGOCO<LPMEJADPGOH> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly OLDJDOOGOCO<DOMGPPLBLAL> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly OLDJDOOGOCO<LOOPLOFJENM> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6177360", Offset = "0x6176760", VA = "0x186177360")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper NPCMNHHPBNC(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[global::BEOLILAPHFD]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[global::ALGMDGFOCIH(1)]
		public LOOPLOFJENM flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[global::ALGMDGFOCIH(2)]
		public JMPHIPJKBMO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[global::ALGMDGFOCIH(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	[global::BEOLILAPHFD]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[global::ALGMDGFOCIH(1)]
		public LOOPLOFJENM flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[global::ALGMDGFOCIH(2)]
		public JMPHIPJKBMO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::ALGMDGFOCIH(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::BEOLILAPHFD]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[global::ALGMDGFOCIH(1)]
		public LOOPLOFJENM flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[global::ALGMDGFOCIH(2)]
		public JMPHIPJKBMO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[global::ALGMDGFOCIH(3)]
		public LPMEJADPGOH userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[global::BEOLILAPHFD]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[global::ALGMDGFOCIH(2)]
		public JMPHIPJKBMO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[global::ALGMDGFOCIH(3)]
		public LPMEJADPGOH userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[global::ALGMDGFOCIH(1)]
		public LOOPLOFJENM flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : OPOEDDCBANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x617AA10", Offset = "0x6179E10", VA = "0x18617AA10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6161C20", Offset = "0x6161020", VA = "0x186161C20")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x617AAB0", Offset = "0x6179EB0", VA = "0x18617AAB0")]
		public bool FJPCEJHKBBN(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : HMADGEFEGFK<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly FPIAKKBMKOD<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x61703E0", Offset = "0x616F7E0", VA = "0x1861703E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly OLDJDOOGOCO<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly DLJCHKGNAAL[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override DLJCHKGNAAL[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x617A8C0", Offset = "0x6179CC0", VA = "0x18617A8C0")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6161980", Offset = "0x6160D80", VA = "0x186161980", Slot = "16")]
		protected internal override SplinePointParentDataWrapper NPCMNHHPBNC(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x6162200", Offset = "0x6161600", VA = "0x186162200")]
		public static (long, string, string) HDNNFKIFGEA(DMHNOCGAKFK value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6163DE0", Offset = "0x61631E0", VA = "0x186163DE0")]
		public static (long, string, string)[] MMKJMMHHNPE(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x6172B80", Offset = "0x6171F80", VA = "0x186172B80")]
		public static Type[] HGFFEHFIKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x61719B0", Offset = "0x6170DB0", VA = "0x1861719B0")]
		private static void GPKLHHLKJHO()
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
		[Cpp2IlInjected.Address(RVA = "0x6173800", Offset = "0x6172C00", VA = "0x186173800")]
		public static (Type, long, long)[] HGFFEHFIKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6172BE0", Offset = "0x6171FE0", VA = "0x186172BE0")]
		private static void GPKLHHLKJHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
	[JGOEIFPBJFO(typeof(FIGOBJJODBD), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : FIGOBJJODBD
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6176E60", Offset = "0x6176260", VA = "0x186176E60")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6173860", Offset = "0x6172C60", VA = "0x186173860")]
		private void LPCJIPCMHAM()
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
		[Cpp2IlInjected.Address(RVA = "0x6177BF0", Offset = "0x6176FF0", VA = "0x186177BF0")]
		public static Type[] HGFFEHFIKAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6178900", Offset = "0x6177D00", VA = "0x186178900")]
		private static void GPKLHHLKJHO()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x617C190", Offset = "0x617B590", VA = "0x18617C190")]
		public void GPKLHHLKJHO(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x617C1A0", Offset = "0x617B5A0", VA = "0x18617C1A0")]
		private void HCODFFJJAIJ(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2D57330", Offset = "0x2D56730", VA = "0x182D57330")]
		private void JHEAHBLFKKO<T>(EFDDNENJJHG registry, [In] T value) where T : struct
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
[JGOEIFPBJFO(typeof(NPLGGEECPCO), new string[] { "Registry" })]
[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
internal class POBJMOAICFE : NPLGGEECPCO
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Type HCAJPHBNEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6177B90", Offset = "0x6176F90", VA = "0x186177B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type[] GLLGPMMGFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6177BF0", Offset = "0x6176FF0", VA = "0x186177BF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Type[] BBNALKNOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6172B80", Offset = "0x6171F80", VA = "0x186172B80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public (Type type, long min, long max)[] IMJCOKPMJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6173800", Offset = "0x6172C00", VA = "0x186173800", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6177C50", Offset = "0x6177050", VA = "0x186177C50", Slot = "8")]
	public void PDICKFLCMHL(EFDDNENJJHG BAHIJADNDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public POBJMOAICFE()
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
