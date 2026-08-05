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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
	public class _AssemblyIndex : PHLPCMENMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LDHNJOCMJPB bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1348A20", Offset = "0x1347620", VA = "0x181348A20", Slot = "5")]
		public override void BMHMIKCNLDO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60E9550", Offset = "0x60E8150", VA = "0x1860E9550")]
		private void CHPLFCKFEKA(ABPDLMJCFLP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60E97D0", Offset = "0x60E83D0", VA = "0x1860E97D0", Slot = "6")]
		public override void LHKPJBJBOHH(ABPDLMJCFLP registry, [In] DPPIIBFLCBO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
		public override void CAHAKELCOOI(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60E9830", Offset = "0x60E8430", VA = "0x1860E9830")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60E4450", Offset = "0x60E3050", VA = "0x1860E4450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : ACFPLCIOCGA<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly OCELDCMMONB<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60DCA20", Offset = "0x60DB620", VA = "0x1860DCA20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly AJLHIJOKGMI<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60E4300", Offset = "0x60E2F00", VA = "0x1860E4300")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : FBLNIHPLIAM
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
			[Cpp2IlInjected.Address(RVA = "0x60E4A30", Offset = "0x60E3630", VA = "0x1860E4A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60E4920", Offset = "0x60E3520", VA = "0x1860E4920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60E49C0", Offset = "0x60E35C0", VA = "0x1860E49C0")]
		public bool IPMMPIODAKC(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60E48C0", Offset = "0x60E34C0", VA = "0x1860E48C0")]
		public bool EHDAHOIGPIG(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Preserve]
	[CompilerGenerated]
	public class PersistentUserTagDataProperties : ACFPLCIOCGA<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly OCELDCMMONB<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly OCELDCMMONB<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x60DCBA0", Offset = "0x60DB7A0", VA = "0x1860DCBA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly AJLHIJOKGMI<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly AJLHIJOKGMI<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60E46E0", Offset = "0x60E32E0", VA = "0x1860E46E0")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::OODONGJKCIM]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::LFHHNDGABIE(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60DC3D0", Offset = "0x60DAFD0", VA = "0x1860DC3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : ACFPLCIOCGA<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly OCELDCMMONB<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60DDF20", Offset = "0x60DCB20", VA = "0x1860DDF20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AJLHIJOKGMI<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60DC280", Offset = "0x60DAE80", VA = "0x1860DC280")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60E7B30", Offset = "0x60E6730", VA = "0x1860E7B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60E7BD0", Offset = "0x60E67D0", VA = "0x1860E7BD0")]
		public float3 KCLMLMGECDL()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60E7AC0", Offset = "0x60E66C0", VA = "0x1860E7AC0")]
		public bool BJOAMFFEGEP(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointScaleDataProperties : ACFPLCIOCGA<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly OCELDCMMONB<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60DD450", Offset = "0x60DC050", VA = "0x1860DD450")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly AJLHIJOKGMI<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60E7970", Offset = "0x60E6570", VA = "0x1860E7970")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60DC840", Offset = "0x60DB440", VA = "0x1860DC840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : ACFPLCIOCGA<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly OCELDCMMONB<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60DD4D0", Offset = "0x60DC0D0", VA = "0x1860DD4D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly AJLHIJOKGMI<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60DC6F0", Offset = "0x60DB2F0", VA = "0x1860DC6F0")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : FBLNIHPLIAM
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
			[Cpp2IlInjected.Address(RVA = "0x60DBEF0", Offset = "0x60DAAF0", VA = "0x1860DBEF0")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60DBFD0", Offset = "0x60DABD0", VA = "0x1860DBFD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60DC0E0", Offset = "0x60DACE0", VA = "0x1860DC0E0")]
		public FixedList32Bytes<int> JKGKKBPOJEE()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60DC070", Offset = "0x60DAC70", VA = "0x1860DC070")]
		public bool IPMMPIODAKC(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60DC160", Offset = "0x60DAD60", VA = "0x1860DC160")]
		public bool JKOLKFMFOEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60DC220", Offset = "0x60DAE20", VA = "0x1860DC220")]
		public bool MBKNBLCAOCI(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60DC1C0", Offset = "0x60DADC0", VA = "0x1860DC1C0")]
		public LNIHFCONKNN KBNLDOENPBL()
		{
			return default(LNIHFCONKNN);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60DBF70", Offset = "0x60DAB70", VA = "0x1860DBF70")]
		public bool DHEJLIOBILC(LNIHFCONKNN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : ACFPLCIOCGA<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly OCELDCMMONB<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly OCELDCMMONB<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly OCELDCMMONB<LNIHFCONKNN> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x60DCCF0", Offset = "0x60DB8F0", VA = "0x1860DCCF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly AJLHIJOKGMI<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly AJLHIJOKGMI<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly AJLHIJOKGMI<LNIHFCONKNN> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60DBC90", Offset = "0x60DA890", VA = "0x1860DBC90")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override InteractionFilterDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60CE9E0", Offset = "0x60CD5E0", VA = "0x1860CE9E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Preserve]
	[CompilerGenerated]
	public class ComponentSerializedVersionDataProperties : ACFPLCIOCGA<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly OCELDCMMONB<PEIEPPDJHDN> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x60DC9A0", Offset = "0x60DB5A0", VA = "0x1860DC9A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly AJLHIJOKGMI<PEIEPPDJHDN> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60CE890", Offset = "0x60CD490", VA = "0x1860CE890")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60E7040", Offset = "0x60E5C40", VA = "0x1860E7040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60E70E0", Offset = "0x60E5CE0", VA = "0x1860E70E0")]
		public bool IGMILEAEMAN(HCIOGIKPEPF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : ACFPLCIOCGA<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly OCELDCMMONB<HCIOGIKPEPF> order;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x60DE020", Offset = "0x60DCC20", VA = "0x1860DE020")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly AJLHIJOKGMI<HCIOGIKPEPF> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60E6EF0", Offset = "0x60E5AF0", VA = "0x1860E6EF0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60DB7D0", Offset = "0x60DA3D0", VA = "0x1860DB7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : ACFPLCIOCGA<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly OCELDCMMONB<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x60DD000", Offset = "0x60DBC00", VA = "0x1860DD000")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly AJLHIJOKGMI<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60DB680", Offset = "0x60DA280", VA = "0x1860DB680")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60E6950", Offset = "0x60E5550", VA = "0x1860E6950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[CompilerGenerated]
	public class SerializedEmbodiedDataProperties : ACFPLCIOCGA<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60E68C0", Offset = "0x60E54C0", VA = "0x1860E68C0")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60DC650", Offset = "0x60DB250", VA = "0x1860DC650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : ACFPLCIOCGA<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly OCELDCMMONB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly OCELDCMMONB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x60DD6A0", Offset = "0x60DC2A0", VA = "0x1860DD6A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly AJLHIJOKGMI<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly AJLHIJOKGMI<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60DC470", Offset = "0x60DB070", VA = "0x1860DC470")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override LocalPoseDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60E6440", Offset = "0x60E5040", VA = "0x1860E6440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectActiveStatusDataProperties : ACFPLCIOCGA<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly OCELDCMMONB<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x60DD8C0", Offset = "0x60DC4C0", VA = "0x1860DD8C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly AJLHIJOKGMI<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60E62F0", Offset = "0x60E4EF0", VA = "0x1860E62F0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60E77F0", Offset = "0x60E63F0", VA = "0x1860E77F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60E7900", Offset = "0x60E6500", VA = "0x1860E7900")]
		public quaternion ILPDCLCBBCL()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60E7890", Offset = "0x60E6490", VA = "0x1860E7890")]
		public bool HNBKDEGDJEO(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : ACFPLCIOCGA<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public static readonly OCELDCMMONB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60DCF00", Offset = "0x60DBB00", VA = "0x1860DCF00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly AJLHIJOKGMI<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60E76A0", Offset = "0x60E62A0", VA = "0x1860E76A0")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60E7510", Offset = "0x60E6110", VA = "0x1860E7510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60E75B0", Offset = "0x60E61B0", VA = "0x1860E75B0")]
		public float3 FHPLCBEIJHM()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60E7630", Offset = "0x60E6230", VA = "0x1860E7630")]
		public bool GKNFNNPABNN(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointPositionDataProperties : ACFPLCIOCGA<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly OCELDCMMONB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x60DCAA0", Offset = "0x60DB6A0", VA = "0x1860DCAA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly AJLHIJOKGMI<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60E73C0", Offset = "0x60E5FC0", VA = "0x1860E73C0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NDNIJNHJOPC shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60E6DF0", Offset = "0x60E59F0", VA = "0x1860E6DF0")]
			get
			{
				return default(NDNIJNHJOPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60E6E50", Offset = "0x60E5A50", VA = "0x1860E6E50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeTypeDataProperties : ACFPLCIOCGA<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly OCELDCMMONB<NDNIJNHJOPC> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x60DD200", Offset = "0x60DBE00", VA = "0x1860DD200")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly AJLHIJOKGMI<NDNIJNHJOPC> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60E6CA0", Offset = "0x60E58A0", VA = "0x1860E6CA0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ShapeTypeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public EBFEJIDFJIN shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x60E5020", Offset = "0x60E3C20", VA = "0x1860E5020")]
			get
			{
				return default(EBFEJIDFJIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60E5080", Offset = "0x60E3C80", VA = "0x1860E5080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60E5120", Offset = "0x60E3D20", VA = "0x1860E5120")]
		public EBFEJIDFJIN FBCNFBHLJGF()
		{
			return default(EBFEJIDFJIN);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : ACFPLCIOCGA<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly OCELDCMMONB<EBFEJIDFJIN> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x60DD3D0", Offset = "0x60DBFD0", VA = "0x1860DD3D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly AJLHIJOKGMI<EBFEJIDFJIN> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60E4ED0", Offset = "0x60E3AD0", VA = "0x1860E4ED0")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60E6820", Offset = "0x60E5420", VA = "0x1860E6820", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : ACFPLCIOCGA<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly OCELDCMMONB<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x60DDD50", Offset = "0x60DC950", VA = "0x1860DDD50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly AJLHIJOKGMI<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60E66D0", Offset = "0x60E52D0", VA = "0x1860E66D0")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ReplicatorDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x60E4E30", Offset = "0x60E3A30", VA = "0x1860E4E30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : ACFPLCIOCGA<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly OCELDCMMONB<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x60DCE80", Offset = "0x60DBA80", VA = "0x1860DCE80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly AJLHIJOKGMI<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60E4CE0", Offset = "0x60E38E0", VA = "0x1860E4CE0")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override PlayerScopeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60DBA50", Offset = "0x60DA650", VA = "0x1860DBA50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[Preserve]
	public class EntityBundlePartDataProperties : ACFPLCIOCGA<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly OCELDCMMONB<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly OCELDCMMONB<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x60DD770", Offset = "0x60DC370", VA = "0x1860DD770")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly AJLHIJOKGMI<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly AJLHIJOKGMI<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60DB870", Offset = "0x60DA470", VA = "0x1860DB870")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60E6630", Offset = "0x60E5230", VA = "0x1860E6630", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectOwnedByPlayerDataProperties : ACFPLCIOCGA<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly OCELDCMMONB<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x60DDB80", Offset = "0x60DC780", VA = "0x1860DDB80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly AJLHIJOKGMI<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60E64E0", Offset = "0x60E50E0", VA = "0x1860E64E0")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60E39B0", Offset = "0x60E25B0", VA = "0x1860E39B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : ACFPLCIOCGA<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly OCELDCMMONB<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly OCELDCMMONB<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x60DC8E0", Offset = "0x60DB4E0", VA = "0x1860DC8E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly AJLHIJOKGMI<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly AJLHIJOKGMI<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x60E37E0", Offset = "0x60E23E0", VA = "0x1860E37E0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[global::OODONGJKCIM]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[global::LFHHNDGABIE(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[global::LFHHNDGABIE(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[global::LFHHNDGABIE(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x60CE7F0", Offset = "0x60CD3F0", VA = "0x1860CE7F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : ACFPLCIOCGA<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly OCELDCMMONB<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x60DD9C0", Offset = "0x60DC5C0", VA = "0x1860DD9C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly AJLHIJOKGMI<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60CE6A0", Offset = "0x60CD2A0", VA = "0x1860CE6A0")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override AuthoredParentDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60DE270", Offset = "0x60DCE70", VA = "0x1860DE270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60DE370", Offset = "0x60DCF70", VA = "0x1860DE370")]
		public FAHBCJFBLFI PJILNICDHAJ()
		{
			return default(FAHBCJFBLFI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x60DE310", Offset = "0x60DCF10", VA = "0x1860DE310")]
		public bool PDNKPEJGLKE(FAHBCJFBLFI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : ACFPLCIOCGA<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly OCELDCMMONB<FAHBCJFBLFI> mode;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x60DD620", Offset = "0x60DC220", VA = "0x1860DD620")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly AJLHIJOKGMI<FAHBCJFBLFI> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60DE120", Offset = "0x60DCD20", VA = "0x1860DE120")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60DB2F0", Offset = "0x60D9EF0", VA = "0x1860DB2F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60DB400", Offset = "0x60DA000", VA = "0x1860DB400")]
		public FixedString64Bytes JGBKJDOILKM()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60DB390", Offset = "0x60D9F90", VA = "0x1860DB390")]
		public bool HHFLIBAGJEB(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : ACFPLCIOCGA<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly OCELDCMMONB<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x60DDA40", Offset = "0x60DC640", VA = "0x1860DDA40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly AJLHIJOKGMI<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60DB1A0", Offset = "0x60D9DA0", VA = "0x1860DB1A0")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerNameDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60E6BA0", Offset = "0x60E57A0", VA = "0x1860E6BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60E6C40", Offset = "0x60E5840", VA = "0x1860E6C40")]
		public PHCMFDMHLCF KAGHIAGGFGC()
		{
			return default(PHCMFDMHLCF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60E6B40", Offset = "0x60E5740", VA = "0x1860E6B40")]
		public bool EJOMPJCHMME(PHCMFDMHLCF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeConfigDataProperties : ACFPLCIOCGA<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public static readonly OCELDCMMONB<PHCMFDMHLCF> flags;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x60DE0A0", Offset = "0x60DCCA0", VA = "0x1860DE0A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly AJLHIJOKGMI<PHCMFDMHLCF> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x60E69F0", Offset = "0x60E55F0", VA = "0x1860E69F0")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ShapeConfigDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60E4640", Offset = "0x60E3240", VA = "0x1860E4640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : ACFPLCIOCGA<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public static readonly OCELDCMMONB<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x60DD940", Offset = "0x60DC540", VA = "0x1860DD940")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly AJLHIJOKGMI<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60E44F0", Offset = "0x60E30F0", VA = "0x1860E44F0")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ParentDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60DB040", Offset = "0x60D9C40", VA = "0x1860DB040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60DB0E0", Offset = "0x60D9CE0", VA = "0x1860DB0E0")]
		public float GDDCPFIAAHD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60DB140", Offset = "0x60D9D40", VA = "0x1860DB140")]
		public bool NENGJPFFEMC(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : ACFPLCIOCGA<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly OCELDCMMONB<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x60DD350", Offset = "0x60DBF50", VA = "0x1860DD350")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly AJLHIJOKGMI<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60DAEF0", Offset = "0x60D9AF0", VA = "0x1860DAEF0")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60CE400", Offset = "0x60CD000", VA = "0x1860CE400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : ACFPLCIOCGA<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly OCELDCMMONB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly OCELDCMMONB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x60DD280", Offset = "0x60DBE80", VA = "0x1860DD280")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly AJLHIJOKGMI<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly AJLHIJOKGMI<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60CE220", Offset = "0x60CCE20", VA = "0x1860CE220")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60E3C20", Offset = "0x60E2820", VA = "0x1860E3C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : ACFPLCIOCGA<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly OCELDCMMONB<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly OCELDCMMONB<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x60DDAC0", Offset = "0x60DC6C0", VA = "0x1860DDAC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly AJLHIJOKGMI<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly AJLHIJOKGMI<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60E3A50", Offset = "0x60E2650", VA = "0x1860E3A50")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60CE600", Offset = "0x60CD200", VA = "0x1860CE600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : ACFPLCIOCGA<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly OCELDCMMONB<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x60DD840", Offset = "0x60DC440", VA = "0x1860DD840")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly AJLHIJOKGMI<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4B0", Offset = "0x60CD0B0", VA = "0x1860CE4B0")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FKDBJAIFMHN color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x60E8280", Offset = "0x60E6E80", VA = "0x1860E8280")]
			get
			{
				return default(FKDBJAIFMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MNJKPHMDKIP material
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x60E8470", Offset = "0x60E7070", VA = "0x1860E8470")]
			get
			{
				return default(MNJKPHMDKIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x60E8570", Offset = "0x60E7170", VA = "0x1860E8570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x60E8650", Offset = "0x60E7250", VA = "0x1860E8650")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x60E84D0", Offset = "0x60E70D0", VA = "0x1860E84D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60E8410", Offset = "0x60E7010", VA = "0x1860E8410")]
		public FKDBJAIFMHN DKAFIPEFNEN()
		{
			return default(FKDBJAIFMHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60E8730", Offset = "0x60E7330", VA = "0x1860E8730")]
		public bool ONLIEFFMHMP(FKDBJAIFMHN value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60E8340", Offset = "0x60E6F40", VA = "0x1860E8340")]
		public MNJKPHMDKIP BBLHBCKNBCD()
		{
			return default(MNJKPHMDKIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60E8220", Offset = "0x60E6E20", VA = "0x1860E8220")]
		public bool ABLNBGGNPPM(MNJKPHMDKIP value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60E86D0", Offset = "0x60E72D0", VA = "0x1860E86D0")]
		public float JMIHAFDEGOG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60E82E0", Offset = "0x60E6EE0", VA = "0x1860E82E0")]
		public bool AJMGNNGLOLA(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60E85D0", Offset = "0x60E71D0", VA = "0x1860E85D0")]
		public float3 HPHJMPBFEEC()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60E83A0", Offset = "0x60E6FA0", VA = "0x1860E83A0")]
		public bool DFGPLGFDMOL(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[Preserve]
	public class StandardRenderableVisualDataProperties : ACFPLCIOCGA<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly OCELDCMMONB<FKDBJAIFMHN> color;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly OCELDCMMONB<MNJKPHMDKIP> material;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly OCELDCMMONB<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly OCELDCMMONB<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x60DDDD0", Offset = "0x60DC9D0", VA = "0x1860DDDD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly AJLHIJOKGMI<FKDBJAIFMHN> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly AJLHIJOKGMI<MNJKPHMDKIP> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly AJLHIJOKGMI<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly AJLHIJOKGMI<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60E7F30", Offset = "0x60E6B30", VA = "0x1860E7F30")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x60DA530", Offset = "0x60D9130", VA = "0x1860DA530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60DA5D0", Offset = "0x60D91D0", VA = "0x1860DA5D0")]
		public GFIOKLOKKHG LIAJFADLKBF()
		{
			return default(GFIOKLOKKHG);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60DA4D0", Offset = "0x60D90D0", VA = "0x1860DA4D0")]
		public bool BOLLFGBJGAP(GFIOKLOKKHG value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : ACFPLCIOCGA<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly OCELDCMMONB<GFIOKLOKKHG> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x60DD080", Offset = "0x60DBC80", VA = "0x1860DD080")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly AJLHIJOKGMI<GFIOKLOKKHG> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60DA380", Offset = "0x60D8F80", VA = "0x1860DA380")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x60DADF0", Offset = "0x60D99F0", VA = "0x1860DADF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60DAE90", Offset = "0x60D9A90", VA = "0x1860DAE90")]
		public ELGLBMPMFMM KKGHAGFDFFG()
		{
			return default(ELGLBMPMFMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x60DAD90", Offset = "0x60D9990", VA = "0x1860DAD90")]
		public bool EHPCHNOBIGD(ELGLBMPMFMM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : ACFPLCIOCGA<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly OCELDCMMONB<ELGLBMPMFMM> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x60DDFA0", Offset = "0x60DCBA0", VA = "0x1860DDFA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly AJLHIJOKGMI<ELGLBMPMFMM> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x60DAC40", Offset = "0x60D9840", VA = "0x1860DAC40")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x60DB5E0", Offset = "0x60DA1E0", VA = "0x1860DB5E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : ACFPLCIOCGA<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly OCELDCMMONB<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x60DCC70", Offset = "0x60DB870", VA = "0x1860DCC70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly AJLHIJOKGMI<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60DB490", Offset = "0x60DA090", VA = "0x1860DB490")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60E7E10", Offset = "0x60E6A10", VA = "0x1860E7E10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60E7EB0", Offset = "0x60E6AB0", VA = "0x1860E7EB0")]
		public ALFAJFPDPCI NKNMNGBKCIH()
		{
			return default(ALFAJFPDPCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60E7DA0", Offset = "0x60E69A0", VA = "0x1860E7DA0")]
		public bool EJLDJDHAAAD(ALFAJFPDPCI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : ACFPLCIOCGA<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly OCELDCMMONB<ALFAJFPDPCI> parameters;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x60DCF80", Offset = "0x60DBB80", VA = "0x1860DCF80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly AJLHIJOKGMI<ALFAJFPDPCI> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60E7C50", Offset = "0x60E6850", VA = "0x1860E7C50")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplineShapeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60E8970", Offset = "0x60E7570", VA = "0x1860E8970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	[CompilerGenerated]
	public class TransformFlagsDataProperties : ACFPLCIOCGA<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly OCELDCMMONB<MJEEKHJJBMM> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly OCELDCMMONB<FLMIPEJMHKA> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x60DD550", Offset = "0x60DC150", VA = "0x1860DD550")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly AJLHIJOKGMI<MJEEKHJJBMM> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly AJLHIJOKGMI<FLMIPEJMHKA> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60E8790", Offset = "0x60E7390", VA = "0x1860E8790")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override TransformFlagsDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60DAA90", Offset = "0x60D9690", VA = "0x1860DAA90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x60DABE0", Offset = "0x60D97E0", VA = "0x1860DABE0")]
		public GEIOBDNIBFI KAGHIAGGFGC()
		{
			return default(GEIOBDNIBFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x60DAB30", Offset = "0x60D9730", VA = "0x1860DAB30")]
		public void HIPNAOJAPIG(GEIOBDNIBFI flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : ACFPLCIOCGA<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly OCELDCMMONB<GEIOBDNIBFI> flags;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x60DD100", Offset = "0x60DBD00", VA = "0x1860DD100")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly AJLHIJOKGMI<GEIOBDNIBFI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x60DA940", Offset = "0x60D9540", VA = "0x1860DA940")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[global::OODONGJKCIM]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[global::LFHHNDGABIE(1)]
		public GEIOBDNIBFI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public EOFCEFPOPKM collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x60DA780", Offset = "0x60D9380", VA = "0x1860DA780")]
			get
			{
				return default(EOFCEFPOPKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60DA7E0", Offset = "0x60D93E0", VA = "0x1860DA7E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x60DA8E0", Offset = "0x60D94E0", VA = "0x1860DA8E0")]
		public EOFCEFPOPKM MGMIBDICNEK()
		{
			return default(EOFCEFPOPKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x60DA880", Offset = "0x60D9480", VA = "0x1860DA880")]
		public bool KMGGKDKMPDL(EOFCEFPOPKM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : ACFPLCIOCGA<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly OCELDCMMONB<EOFCEFPOPKM> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x60DCB20", Offset = "0x60DB720", VA = "0x1860DCB20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly AJLHIJOKGMI<EOFCEFPOPKM> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60DA630", Offset = "0x60D9230", VA = "0x1860DA630")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60E4C40", Offset = "0x60E3840", VA = "0x1860E4C40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x60E4BE0", Offset = "0x60E37E0", VA = "0x1860E4BE0")]
		public bool DEAMHPGIMOB(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : ACFPLCIOCGA<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly OCELDCMMONB<float> density;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x60DD180", Offset = "0x60DBD80", VA = "0x1860DD180")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly AJLHIJOKGMI<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x60E4A90", Offset = "0x60E3690", VA = "0x1860E4A90")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public DDCOPLICAFO scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x60E4280", Offset = "0x60E2E80", VA = "0x1860E4280")]
			get
			{
				return default(DDCOPLICAFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x60E4070", Offset = "0x60E2C70", VA = "0x1860E4070", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x60E4170", Offset = "0x60E2D70", VA = "0x1860E4170")]
		public BJJDBIPGBFA KAGHIAGGFGC()
		{
			return default(BJJDBIPGBFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x60E4010", Offset = "0x60E2C10", VA = "0x1860E4010")]
		public ABHMDJOONNA CJGGDILJCFK()
		{
			return default(ABHMDJOONNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x60E41D0", Offset = "0x60E2DD0", VA = "0x1860E41D0")]
		public void LBILFDOLFPB(ABHMDJOONNA flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x60E3FB0", Offset = "0x60E2BB0", VA = "0x1860E3FB0")]
		public IKBPKMBLKEC BIAAKANMNBC()
		{
			return default(IKBPKMBLKEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x60E4110", Offset = "0x60E2D10", VA = "0x1860E4110")]
		public bool GFCHMNLEDEN(IKBPKMBLKEC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : ACFPLCIOCGA<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly OCELDCMMONB<DDCOPLICAFO> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly OCELDCMMONB<ABHMDJOONNA> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly OCELDCMMONB<IKBPKMBLKEC> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly OCELDCMMONB<BJJDBIPGBFA> flags;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x60DDC00", Offset = "0x60DC800", VA = "0x1860DDC00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly AJLHIJOKGMI<DDCOPLICAFO> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly AJLHIJOKGMI<ABHMDJOONNA> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly AJLHIJOKGMI<IKBPKMBLKEC> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly AJLHIJOKGMI<BJJDBIPGBFA> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x60E3CC0", Offset = "0x60E28C0", VA = "0x1860E3CC0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper IDNOFIABDEN(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[global::OODONGJKCIM]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[global::LFHHNDGABIE(1)]
		public BJJDBIPGBFA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[global::LFHHNDGABIE(2)]
		public DDCOPLICAFO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[global::LFHHNDGABIE(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	[global::OODONGJKCIM]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[global::LFHHNDGABIE(1)]
		public BJJDBIPGBFA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[global::LFHHNDGABIE(2)]
		public DDCOPLICAFO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::LFHHNDGABIE(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::OODONGJKCIM]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[global::LFHHNDGABIE(1)]
		public BJJDBIPGBFA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[global::LFHHNDGABIE(2)]
		public DDCOPLICAFO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[global::LFHHNDGABIE(3)]
		public ABHMDJOONNA userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[global::OODONGJKCIM]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[global::LFHHNDGABIE(2)]
		public DDCOPLICAFO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[global::LFHHNDGABIE(3)]
		public ABHMDJOONNA userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[global::LFHHNDGABIE(1)]
		public BJJDBIPGBFA flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : FBLNIHPLIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x60E7320", Offset = "0x60E5F20", VA = "0x1860E7320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE4A0", Offset = "0x60CD0A0", VA = "0x1860CE4A0")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x60E7290", Offset = "0x60E5E90", VA = "0x1860E7290")]
		public bool BMHNCOLBLIN(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : ACFPLCIOCGA<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly OCELDCMMONB<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x60DCE00", Offset = "0x60DBA00", VA = "0x1860DCE00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly AJLHIJOKGMI<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly DDGIJMFBIED[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override DDGIJMFBIED[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x60E7140", Offset = "0x60E5D40", VA = "0x1860E7140")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x60CE200", Offset = "0x60CCE00", VA = "0x1860CE200", Slot = "16")]
		protected internal override SplinePointParentDataWrapper IDNOFIABDEN(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x60CEBC0", Offset = "0x60CD7C0", VA = "0x1860CEBC0")]
		public static (long, string, string) JJLPBEPALJM(JDMDNBNFCKO value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60CEA80", Offset = "0x60CD680", VA = "0x1860CEA80")]
		public static (long, string, string)[] EDPKOLMGJJN(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x60DBBD0", Offset = "0x60DA7D0", VA = "0x1860DBBD0")]
		public static Type[] NOPHJLGMLHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x60DE3D0", Offset = "0x60DCFD0", VA = "0x1860DE3D0")]
		private static void FAEDNEGPAEK()
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
		[Cpp2IlInjected.Address(RVA = "0x60DBB70", Offset = "0x60DA770", VA = "0x1860DBB70")]
		public static (Type, long, long)[] NOPHJLGMLHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x60DF5A0", Offset = "0x60DE1A0", VA = "0x1860DF5A0")]
		private static void FAEDNEGPAEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
	[HPFMEPGDOBP(typeof(HINLGHCPAJM), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : HINLGHCPAJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60E37C0", Offset = "0x60E23C0", VA = "0x1860E37C0")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x60E01C0", Offset = "0x60DEDC0", VA = "0x1860E01C0")]
		private void NIHOGMIKIKJ()
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
		[Cpp2IlInjected.Address(RVA = "0x60DBAF0", Offset = "0x60DA6F0", VA = "0x1860DBAF0")]
		public static Type[] NOPHJLGMLHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60E5180", Offset = "0x60E3D80", VA = "0x1860E5180")]
		private static void FAEDNEGPAEK()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x60E8A10", Offset = "0x60E7610", VA = "0x1860E8A10")]
		public void FAEDNEGPAEK(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60E8A20", Offset = "0x60E7620", VA = "0x1860E8A20")]
		private void FGCMGPFNGJC(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2D531F0", Offset = "0x2D51DF0", VA = "0x182D531F0")]
		private void NOPGGDEDGJI<T>(EJCABKCJHLL registry, [In] T value) where T : struct
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
[HPFMEPGDOBP(typeof(HMCOOLINNBA), new string[] { "Registry" })]
[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
internal class FPNBLHKHOPC : HMCOOLINNBA
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Type HLMGCGFFMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x60DBC30", Offset = "0x60DA830", VA = "0x1860DBC30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type[] IACGJGEHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x60DBAF0", Offset = "0x60DA6F0", VA = "0x1860DBAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Type[] PFNHGKNANKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x60DBBD0", Offset = "0x60DA7D0", VA = "0x1860DBBD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public (Type type, long min, long max)[] FENMKJOANOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x60DBB70", Offset = "0x60DA770", VA = "0x1860DBB70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60DBB50", Offset = "0x60DA750", VA = "0x1860DBB50", Slot = "8")]
	public void DNKCKMPINAF(EJCABKCJHLL DGMNKJNOCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FPNBLHKHOPC()
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
