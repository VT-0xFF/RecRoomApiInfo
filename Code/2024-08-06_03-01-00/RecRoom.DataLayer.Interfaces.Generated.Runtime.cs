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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
	public class _AssemblyIndex : KHELACBDANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DDEOLOLNDJP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15D4770", Offset = "0x15D2D70", VA = "0x1815D4770", Slot = "5")]
		public override void ENKMMKDBHKM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x696CF50", Offset = "0x696B550", VA = "0x18696CF50")]
		private void COCKNKCMPAG(AOOOFDNBGDI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x696D1D0", Offset = "0x696B7D0", VA = "0x18696D1D0", Slot = "6")]
		public override void MGOLIABDFGJ(AOOOFDNBGDI registry, [In] ADBFLCOCMBA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
		public override void PEGDOCGMNBF(FEIKJFAIAHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x696D230", Offset = "0x696B830", VA = "0x18696D230")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6968680", Offset = "0x6966C80", VA = "0x186968680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : LGDCJDLIJCO<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly NNHKJGLKIOG<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x695E880", Offset = "0x695CE80", VA = "0x18695E880")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly EEOFACKHPBM<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6968530", Offset = "0x6966B30", VA = "0x186968530")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override OverrideObjectNetworkIdDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6968AF0", Offset = "0x69670F0", VA = "0x186968AF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : LGDCJDLIJCO<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly NNHKJGLKIOG<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly NNHKJGLKIOG<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x695EA00", Offset = "0x695D000", VA = "0x18695EA00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EEOFACKHPBM<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly EEOFACKHPBM<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6968910", Offset = "0x6966F10", VA = "0x186968910")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override PersistentUserTagDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::FMFALIJHNIH]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::OEDHNLDDELA(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x695DF30", Offset = "0x695C530", VA = "0x18695DF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[Preserve]
	public class LocalDeformableScaleDataProperties : LGDCJDLIJCO<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly NNHKJGLKIOG<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69604F0", Offset = "0x695EAF0", VA = "0x1869604F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EEOFACKHPBM<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x695DDE0", Offset = "0x695C3E0", VA = "0x18695DDE0")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override LocalDeformableScaleDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::FMFALIJHNIH]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::OEDHNLDDELA(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x696B5D0", Offset = "0x6969BD0", VA = "0x18696B5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x696B550", Offset = "0x6969B50", VA = "0x18696B550")]
		public float3 CPBBKJDGJKF()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x696B670", Offset = "0x6969C70", VA = "0x18696B670")]
		public bool GPCMDIJBPHD(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : LGDCJDLIJCO<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly NNHKJGLKIOG<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x695F840", Offset = "0x695DE40", VA = "0x18695F840")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly EEOFACKHPBM<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x696B400", Offset = "0x6969A00", VA = "0x18696B400")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplinePointScaleDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x695E3A0", Offset = "0x695C9A0", VA = "0x18695E3A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : LGDCJDLIJCO<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly NNHKJGLKIOG<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x695F940", Offset = "0x695DF40", VA = "0x18695F940")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly EEOFACKHPBM<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x695E250", Offset = "0x695C850", VA = "0x18695E250")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override LocalUniformScaleDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEnabledDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterEnabledDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x695D960", Offset = "0x695BF60", VA = "0x18695D960", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterEnabledDataWrapper(Entity entity, InteractionFilterEnabledDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEnabledDataProperties : LGDCJDLIJCO<InteractionFilterEnabledDataWrapper, InteractionFilterEnabledData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly NNHKJGLKIOG<JMEGKBANMDE> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x695EFC0", Offset = "0x695D5C0", VA = "0x18695EFC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly EEOFACKHPBM<JMEGKBANMDE> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x695D810", Offset = "0x695BE10", VA = "0x18695D810")]
		public InteractionFilterEnabledDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterEnabledDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterEnabledDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupReferenceBufferWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ReferenceGroupReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69697B0", Offset = "0x6967DB0", VA = "0x1869697B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReferenceGroupReferenceBufferWrapper(Entity entity, ReferenceGroupReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ReferenceGroupReferenceBufferProperties : OFFPOFPMKKP<ReferenceGroupReferenceBufferWrapper, ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly NNHKJGLKIOG<Entity> reference;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x695FC40", Offset = "0x695E240", VA = "0x18695FC40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly DBNKJBBIGDJ<ReferenceGroupReferenceBuffer, Entity> reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6969660", Offset = "0x6967C60", VA = "0x186969660")]
		public ReferenceGroupReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReferenceGroupReferenceBufferWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReferenceGroupReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct UserTagReferenceBufferWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly UserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x696CEB0", Offset = "0x696B4B0", VA = "0x18696CEB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal UserTagReferenceBufferWrapper(Entity entity, UserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagReferenceBufferProperties : OFFPOFPMKKP<UserTagReferenceBufferWrapper, UserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly NNHKJGLKIOG<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x695F040", Offset = "0x695D640", VA = "0x18695F040")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly DBNKJBBIGDJ<UserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x696CD60", Offset = "0x696B360", VA = "0x18696CD60")]
		public UserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override UserTagReferenceBufferWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(UserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x695D770", Offset = "0x695BD70", VA = "0x18695D770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : LGDCJDLIJCO<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly NNHKJGLKIOG<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly NNHKJGLKIOG<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly NNHKJGLKIOG<JMEGKBANMDE> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x695EB40", Offset = "0x695D140", VA = "0x18695EB40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly EEOFACKHPBM<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly EEOFACKHPBM<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly EEOFACKHPBM<JMEGKBANMDE> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x695D510", Offset = "0x695BB10", VA = "0x18695D510")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x694F770", Offset = "0x694DD70", VA = "0x18694F770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : LGDCJDLIJCO<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly NNHKJGLKIOG<GELFCKFFFNJ> version;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x695E800", Offset = "0x695CE00", VA = "0x18695E800")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly EEOFACKHPBM<GELFCKFFFNJ> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x694F620", Offset = "0x694DC20", VA = "0x18694F620")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ComponentSerializedVersionDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupOwnerDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ReferenceGroupOwnerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69695C0", Offset = "0x6967BC0", VA = "0x1869695C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReferenceGroupOwnerDataWrapper(Entity entity, ReferenceGroupOwnerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupOwnerDataProperties : LGDCJDLIJCO<ReferenceGroupOwnerDataWrapper, ReferenceGroupOwnerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly NNHKJGLKIOG<Entity> owner;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x695F1C0", Offset = "0x695D7C0", VA = "0x18695F1C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly EEOFACKHPBM<Entity> owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6969470", Offset = "0x6967A70", VA = "0x186969470")]
		public ReferenceGroupOwnerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReferenceGroupOwnerDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReferenceGroupOwnerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct MakerPenHeldDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly MakerPenHeldDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x695E590", Offset = "0x695CB90", VA = "0x18695E590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal MakerPenHeldDataWrapper(Entity entity, MakerPenHeldDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x695E630", Offset = "0x695CC30", VA = "0x18695E630")]
		public bool IDBMBPEPGED(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class MakerPenHeldDataProperties : LGDCJDLIJCO<MakerPenHeldDataWrapper, MakerPenHeldData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly NNHKJGLKIOG<bool> makerPenHeld;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x695EF40", Offset = "0x695D540", VA = "0x18695EF40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly EEOFACKHPBM<bool> makerPenHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x695E440", Offset = "0x695CA40", VA = "0x18695E440")]
		public MakerPenHeldDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override MakerPenHeldDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(MakerPenHeldDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x696C570", Offset = "0x696AB70", VA = "0x18696C570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x696C460", Offset = "0x696AA60", VA = "0x18696C460")]
		public float BMEGDGAHCAJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x696C610", Offset = "0x696AC10", VA = "0x18696C610")]
		public bool JJCLOBGHCNN(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x696C400", Offset = "0x696AA00", VA = "0x18696C400")]
		public IGPBHFHDCAI ACLGHLFHAID()
		{
			return default(IGPBHFHDCAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x696C4C0", Offset = "0x696AAC0", VA = "0x18696C4C0")]
		public void CGOIHJANNLE(IGPBHFHDCAI flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupSettingsDataProperties : LGDCJDLIJCO<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly NNHKJGLKIOG<float> delay;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly NNHKJGLKIOG<IGPBHFHDCAI> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x695E740", Offset = "0x695CD40", VA = "0x18695E740")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly EEOFACKHPBM<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EEOFACKHPBM<IGPBHFHDCAI> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x696C220", Offset = "0x696A820", VA = "0x18696C220")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ToolCleanupSettingsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x696AAD0", Offset = "0x69690D0", VA = "0x18696AAD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x696AB70", Offset = "0x6969170", VA = "0x18696AB70")]
		public bool IJMHNCPHBFE(IHNOLNDFHLF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointOrderDataProperties : LGDCJDLIJCO<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NNHKJGLKIOG<IHNOLNDFHLF> order;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x69605F0", Offset = "0x695EBF0", VA = "0x1869605F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly EEOFACKHPBM<IHNOLNDFHLF> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x696A980", Offset = "0x6968F80", VA = "0x18696A980")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplinePointOrderDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x695CE10", Offset = "0x695B410", VA = "0x18695CE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : LGDCJDLIJCO<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly NNHKJGLKIOG<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x695F140", Offset = "0x695D740", VA = "0x18695F140")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly EEOFACKHPBM<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x695CCC0", Offset = "0x695B2C0", VA = "0x18695CCC0")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override CostumePieceSlotIndexDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x695E1B0", Offset = "0x695C7B0", VA = "0x18695E1B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : LGDCJDLIJCO<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly NNHKJGLKIOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly NNHKJGLKIOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x695FB80", Offset = "0x695E180", VA = "0x18695FB80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly EEOFACKHPBM<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly EEOFACKHPBM<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x695DFD0", Offset = "0x695C5D0", VA = "0x18695DFD0")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override LocalPoseDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69699A0", Offset = "0x6967FA0", VA = "0x1869699A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : LGDCJDLIJCO<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly NNHKJGLKIOG<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x695FE80", Offset = "0x695E480", VA = "0x18695FE80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly EEOFACKHPBM<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6969850", Offset = "0x6967E50", VA = "0x186969850")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct ReplicatorPreallocatedObjectCountDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ReplicatorPreallocatedObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x696A1F0", Offset = "0x69687F0", VA = "0x18696A1F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReplicatorPreallocatedObjectCountDataWrapper(Entity entity, ReplicatorPreallocatedObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataProperties : LGDCJDLIJCO<ReplicatorPreallocatedObjectCountDataWrapper, ReplicatorPreallocatedObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly NNHKJGLKIOG<int> preallocatedCopies;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x695F8C0", Offset = "0x695DEC0", VA = "0x18695F8C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly EEOFACKHPBM<int> preallocatedCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x696A0A0", Offset = "0x69686A0", VA = "0x18696A0A0")]
		public ReplicatorPreallocatedObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReplicatorPreallocatedObjectCountDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReplicatorPreallocatedObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[global::FMFALIJHNIH]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::OEDHNLDDELA(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x696B280", Offset = "0x6969880", VA = "0x18696B280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x696B390", Offset = "0x6969990", VA = "0x18696B390")]
		public quaternion MLLMNJPEFGG()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x696B320", Offset = "0x6969920", VA = "0x18696B320")]
		public bool GGEKGKOHHKK(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : LGDCJDLIJCO<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly NNHKJGLKIOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x695ED40", Offset = "0x695D340", VA = "0x18695ED40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly EEOFACKHPBM<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x696B130", Offset = "0x6969730", VA = "0x18696B130")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplinePointRotationDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAllTagsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly InteractionFilterAllTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x695D280", Offset = "0x695B880", VA = "0x18695D280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterAllTagsDataWrapper(Entity entity, InteractionFilterAllTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterAllTagsDataProperties : LGDCJDLIJCO<InteractionFilterAllTagsDataWrapper, InteractionFilterAllTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly NNHKJGLKIOG<Entity> allTags;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x695EEC0", Offset = "0x695D4C0", VA = "0x18695EEC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly EEOFACKHPBM<Entity> allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x695D130", Offset = "0x695B730", VA = "0x18695D130")]
		public InteractionFilterAllTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterAllTagsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterAllTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x696C850", Offset = "0x696AE50", VA = "0x18696C850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : LGDCJDLIJCO<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly NNHKJGLKIOG<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly NNHKJGLKIOG<CCBEHACJIFF> statusFlags;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x695F440", Offset = "0x695DA40", VA = "0x18695F440")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly EEOFACKHPBM<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly EEOFACKHPBM<CCBEHACJIFF> statusFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x696C670", Offset = "0x696AC70", VA = "0x18696C670")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ToolCleanupStatusDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	[global::FMFALIJHNIH]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[global::OEDHNLDDELA(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[global::OEDHNLDDELA(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[global::OEDHNLDDELA(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAnyTagsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly InteractionFilterAnyTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x695D470", Offset = "0x695BA70", VA = "0x18695D470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterAnyTagsDataWrapper(Entity entity, InteractionFilterAnyTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterAnyTagsDataProperties : LGDCJDLIJCO<InteractionFilterAnyTagsDataWrapper, InteractionFilterAnyTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly NNHKJGLKIOG<Entity> anyTags;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x695EDC0", Offset = "0x695D3C0", VA = "0x18695EDC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly EEOFACKHPBM<Entity> anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x695D320", Offset = "0x695B920", VA = "0x18695D320")]
		public InteractionFilterAnyTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterAnyTagsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterAnyTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x696AFA0", Offset = "0x69695A0", VA = "0x18696AFA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x696B0B0", Offset = "0x69696B0", VA = "0x18696B0B0")]
		public float3 OCGFIDOAJAI()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x696B040", Offset = "0x6969640", VA = "0x18696B040")]
		public bool MDKLILIIHNJ(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : LGDCJDLIJCO<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly NNHKJGLKIOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x695E900", Offset = "0x695CF00", VA = "0x18695E900")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly EEOFACKHPBM<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x696AE50", Offset = "0x6969450", VA = "0x18696AE50")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplinePointPositionDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LEDGIGOBGNJ shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x696A690", Offset = "0x6968C90", VA = "0x18696A690")]
			get
			{
				return default(LEDGIGOBGNJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x696A6F0", Offset = "0x6968CF0", VA = "0x18696A6F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : LGDCJDLIJCO<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public static readonly NNHKJGLKIOG<LEDGIGOBGNJ> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x695F600", Offset = "0x695DC00", VA = "0x18695F600")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly EEOFACKHPBM<LEDGIGOBGNJ> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x696A540", Offset = "0x6968B40", VA = "0x18696A540")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ShapeTypeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public KKIGPGIMOPI shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6969120", Offset = "0x6967720", VA = "0x186969120")]
			get
			{
				return default(KKIGPGIMOPI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69691E0", Offset = "0x69677E0", VA = "0x1869691E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6969180", Offset = "0x6967780", VA = "0x186969180")]
		public KKIGPGIMOPI BDIIECGCNOO()
		{
			return default(KKIGPGIMOPI);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : LGDCJDLIJCO<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly NNHKJGLKIOG<KKIGPGIMOPI> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x695F7C0", Offset = "0x695DDC0", VA = "0x18695F7C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly EEOFACKHPBM<KKIGPGIMOPI> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6968FD0", Offset = "0x69675D0", VA = "0x186968FD0")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override PrimitiveShapeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6969E10", Offset = "0x6968410", VA = "0x186969E10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : LGDCJDLIJCO<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly NNHKJGLKIOG<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly NNHKJGLKIOG<bool> NeedsCircuitUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x69602F0", Offset = "0x695E8F0", VA = "0x1869602F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly EEOFACKHPBM<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly EEOFACKHPBM<bool> NeedsCircuitUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6969C30", Offset = "0x6968230", VA = "0x186969C30")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReplicatorDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[global::FMFALIJHNIH]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[global::OEDHNLDDELA(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6968F30", Offset = "0x6967530", VA = "0x186968F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : LGDCJDLIJCO<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly NNHKJGLKIOG<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x695ECC0", Offset = "0x695D2C0", VA = "0x18695ECC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly EEOFACKHPBM<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6968DE0", Offset = "0x69673E0", VA = "0x186968DE0")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override PlayerScopeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x695D090", Offset = "0x695B690", VA = "0x18695D090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : LGDCJDLIJCO<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly NNHKJGLKIOG<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly NNHKJGLKIOG<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x695FCC0", Offset = "0x695E2C0", VA = "0x18695FCC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly EEOFACKHPBM<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly EEOFACKHPBM<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x695CEB0", Offset = "0x695B4B0", VA = "0x18695CEB0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override EntityBundlePartDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6969B90", Offset = "0x6968190", VA = "0x186969B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : LGDCJDLIJCO<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly NNHKJGLKIOG<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6960130", Offset = "0x695E730", VA = "0x186960130")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly EEOFACKHPBM<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6969A40", Offset = "0x6968040", VA = "0x186969A40")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6967B80", Offset = "0x6966180", VA = "0x186967B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : LGDCJDLIJCO<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly NNHKJGLKIOG<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly NNHKJGLKIOG<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x695E690", Offset = "0x695CC90", VA = "0x18695E690")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly EEOFACKHPBM<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly EEOFACKHPBM<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x69679B0", Offset = "0x6965FB0", VA = "0x1869679B0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override OMShapeContainerDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	[global::FMFALIJHNIH]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[global::OEDHNLDDELA(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[global::OEDHNLDDELA(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[global::OEDHNLDDELA(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x694F390", Offset = "0x694D990", VA = "0x18694F390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : LGDCJDLIJCO<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly NNHKJGLKIOG<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x695FF80", Offset = "0x695E580", VA = "0x18695FF80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly EEOFACKHPBM<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x694F240", Offset = "0x694D840", VA = "0x18694F240")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override AuthoredParentDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct UserTagNameDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly UserTagNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x696CCC0", Offset = "0x696B2C0", VA = "0x18696CCC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal UserTagNameDataWrapper(Entity entity, UserTagNameDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[Preserve]
	public class UserTagNameDataProperties : LGDCJDLIJCO<UserTagNameDataWrapper, UserTagNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly NNHKJGLKIOG<FixedString32Bytes> Value;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x695FE00", Offset = "0x695E400", VA = "0x18695FE00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly EEOFACKHPBM<FixedString32Bytes> Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x696CB70", Offset = "0x696B170", VA = "0x18696CB70")]
		public UserTagNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override UserTagNameDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(UserTagNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x69608C0", Offset = "0x695EEC0", VA = "0x1869608C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69609C0", Offset = "0x695EFC0", VA = "0x1869609C0")]
		public DOHMONAGHON MHKBOJFNGNN()
		{
			return default(DOHMONAGHON);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6960960", Offset = "0x695EF60", VA = "0x186960960")]
		public bool GFELGHLPAKJ(DOHMONAGHON value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : LGDCJDLIJCO<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly NNHKJGLKIOG<DOHMONAGHON> mode;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x695FB00", Offset = "0x695E100", VA = "0x18695FB00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly EEOFACKHPBM<DOHMONAGHON> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6960770", Offset = "0x695ED70", VA = "0x186960770")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override NavMeshGenerationDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x695C930", Offset = "0x695AF30", VA = "0x18695C930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x695C9D0", Offset = "0x695AFD0", VA = "0x18695C9D0")]
		public FixedString64Bytes PCNJNGKHPDC()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x695CA60", Offset = "0x695B060", VA = "0x18695CA60")]
		public bool PIDKEMFFGAD(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : LGDCJDLIJCO<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly NNHKJGLKIOG<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6960000", Offset = "0x695E600", VA = "0x186960000")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly EEOFACKHPBM<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x695C7E0", Offset = "0x695ADE0", VA = "0x18695C7E0")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerNameDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x696A3E0", Offset = "0x69689E0", VA = "0x18696A3E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x696A480", Offset = "0x6968A80", VA = "0x18696A480")]
		public NOPGGEKHLCF IOENPNLNIKK()
		{
			return default(NOPGGEKHLCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x696A4E0", Offset = "0x6968AE0", VA = "0x18696A4E0")]
		public bool JJIGBFBNHLJ(NOPGGEKHLCF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : LGDCJDLIJCO<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public static readonly NNHKJGLKIOG<NOPGGEKHLCF> flags;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6960670", Offset = "0x695EC70", VA = "0x186960670")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly EEOFACKHPBM<NOPGGEKHLCF> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x696A290", Offset = "0x6968890", VA = "0x18696A290")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ShapeConfigDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6968870", Offset = "0x6966E70", VA = "0x186968870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : LGDCJDLIJCO<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly NNHKJGLKIOG<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x695FF00", Offset = "0x695E500", VA = "0x18695FF00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly EEOFACKHPBM<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6968720", Offset = "0x6966D20", VA = "0x186968720")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ParentDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x696A000", Offset = "0x6968600", VA = "0x18696A000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : LGDCJDLIJCO<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly NNHKJGLKIOG<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x695F580", Offset = "0x695DB80", VA = "0x18695F580")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly EEOFACKHPBM<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6969EB0", Offset = "0x69684B0", VA = "0x186969EB0")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReplicatorMaxObjectCountDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x695C680", Offset = "0x695AC80", VA = "0x18695C680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x695C780", Offset = "0x695AD80", VA = "0x18695C780")]
		public float PPAFJNDJIGN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x695C720", Offset = "0x695AD20", VA = "0x18695C720")]
		public bool HMGCJLIOKLM(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : LGDCJDLIJCO<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly NNHKJGLKIOG<float> mass;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x695F740", Offset = "0x695DD40", VA = "0x18695F740")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly EEOFACKHPBM<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x695C530", Offset = "0x695AB30", VA = "0x18695C530")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerMassOverrideDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x694EFA0", Offset = "0x694D5A0", VA = "0x18694EFA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalPoseDataProperties : LGDCJDLIJCO<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly NNHKJGLKIOG<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly NNHKJGLKIOG<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x695F680", Offset = "0x695DC80", VA = "0x18695F680")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly EEOFACKHPBM<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly EEOFACKHPBM<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x694EDC0", Offset = "0x694D3C0", VA = "0x18694EDC0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override AuthoredLocalPoseDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6967DF0", Offset = "0x69663F0", VA = "0x186967DF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : LGDCJDLIJCO<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly NNHKJGLKIOG<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly NNHKJGLKIOG<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6960080", Offset = "0x695E680", VA = "0x186960080")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly EEOFACKHPBM<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly EEOFACKHPBM<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6967C20", Offset = "0x6966220", VA = "0x186967C20")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ObjectBoardNodeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x694F1A0", Offset = "0x694D7A0", VA = "0x18694F1A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : LGDCJDLIJCO<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly NNHKJGLKIOG<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x695FD80", Offset = "0x695E380", VA = "0x18695FD80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly EEOFACKHPBM<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x694F050", Offset = "0x694D650", VA = "0x18694F050")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override AuthoredLocalUniformScaleDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OOIJLPKHKBF color
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x696C040", Offset = "0x696A640", VA = "0x18696C040")]
			get
			{
				return default(OOIJLPKHKBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public FOPEFPIMFIG material
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x696C1C0", Offset = "0x696A7C0", VA = "0x18696C1C0")]
			get
			{
				return default(FOPEFPIMFIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x696BF10", Offset = "0x696A510", VA = "0x18696BF10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x696BD90", Offset = "0x696A390", VA = "0x18696BD90")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x696BE70", Offset = "0x696A470", VA = "0x18696BE70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x696C160", Offset = "0x696A760", VA = "0x18696C160")]
		public OOIJLPKHKBF JOHBGLGBMDO()
		{
			return default(OOIJLPKHKBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x696C0A0", Offset = "0x696A6A0", VA = "0x18696C0A0")]
		public bool IIOPMMIKIIN(OOIJLPKHKBF value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x696C100", Offset = "0x696A700", VA = "0x18696C100")]
		public FOPEFPIMFIG JMDMFIDJMKM()
		{
			return default(FOPEFPIMFIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x696BCB0", Offset = "0x696A2B0", VA = "0x18696BCB0")]
		public bool BCKCIAAFGKF(FOPEFPIMFIG value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x696BE10", Offset = "0x696A410", VA = "0x18696BE10")]
		public float EEDFNILJIBB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x696BF70", Offset = "0x696A570", VA = "0x18696BF70")]
		public bool GMCLOIDBCAI(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x696BD10", Offset = "0x696A310", VA = "0x18696BD10")]
		public float3 DBMDEOKMKDP()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x696BFD0", Offset = "0x696A5D0", VA = "0x18696BFD0")]
		public bool GMKPBGKIFOD(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : LGDCJDLIJCO<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly NNHKJGLKIOG<OOIJLPKHKBF> color;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly NNHKJGLKIOG<FOPEFPIMFIG> material;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly NNHKJGLKIOG<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly NNHKJGLKIOG<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x69603B0", Offset = "0x695E9B0", VA = "0x1869603B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly EEOFACKHPBM<OOIJLPKHKBF> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly EEOFACKHPBM<FOPEFPIMFIG> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly EEOFACKHPBM<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly EEOFACKHPBM<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x696B9C0", Offset = "0x6969FC0", VA = "0x18696B9C0")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override StandardRenderableVisualDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x695BB10", Offset = "0x695A110", VA = "0x18695BB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x695BC10", Offset = "0x695A210", VA = "0x18695BC10")]
		public GNJPMHJGDIL OBMFENFEEEB()
		{
			return default(GNJPMHJGDIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x695BBB0", Offset = "0x695A1B0", VA = "0x18695BBB0")]
		public bool IMINBOKJDND(GNJPMHJGDIL value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : LGDCJDLIJCO<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly NNHKJGLKIOG<GNJPMHJGDIL> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x695F240", Offset = "0x695D840", VA = "0x18695F240")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly EEOFACKHPBM<GNJPMHJGDIL> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x695B9C0", Offset = "0x6959FC0", VA = "0x18695B9C0")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerCollisionLayerDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public readonly struct InteractionFilterNoneTagsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly InteractionFilterNoneTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x695DD40", Offset = "0x695C340", VA = "0x18695DD40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterNoneTagsDataWrapper(Entity entity, InteractionFilterNoneTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterNoneTagsDataProperties : LGDCJDLIJCO<InteractionFilterNoneTagsDataWrapper, InteractionFilterNoneTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly NNHKJGLKIOG<Entity> noneTags;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x695F500", Offset = "0x695DB00", VA = "0x18695F500")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public readonly EEOFACKHPBM<Entity> noneTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x695DBF0", Offset = "0x695C1F0", VA = "0x18695DBF0")]
		public InteractionFilterNoneTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterNoneTagsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterNoneTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x696A8E0", Offset = "0x6968EE0", VA = "0x18696A8E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : LGDCJDLIJCO<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly NNHKJGLKIOG<IHNOLNDFHLF> order;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x695F0C0", Offset = "0x695D6C0", VA = "0x18695F0C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public readonly EEOFACKHPBM<IHNOLNDFHLF> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x696A790", Offset = "0x6968D90", VA = "0x18696A790")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SiblingSortOrderDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x695C3D0", Offset = "0x695A9D0", VA = "0x18695C3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x695C4D0", Offset = "0x695AAD0", VA = "0x18695C4D0")]
		public JNOJFPGIFFF PIMNBDJDJBC()
		{
			return default(JNOJFPGIFFF);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x695C470", Offset = "0x695AA70", VA = "0x18695C470")]
		public bool IMBBDPOKNEE(JNOJFPGIFFF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerGrabbableModeDataProperties : LGDCJDLIJCO<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly NNHKJGLKIOG<JNOJFPGIFFF> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x6960570", Offset = "0x695EB70", VA = "0x186960570")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly EEOFACKHPBM<JNOJFPGIFFF> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x695C280", Offset = "0x695A880", VA = "0x18695C280")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerGrabbableModeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x695CC20", Offset = "0x695B220", VA = "0x18695CC20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : LGDCJDLIJCO<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly NNHKJGLKIOG<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x695EAC0", Offset = "0x695D0C0", VA = "0x18695EAC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly EEOFACKHPBM<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x695CAD0", Offset = "0x695B0D0", VA = "0x18695CAD0")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override CostumePieceParentCostumeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	public readonly struct AuthoredUserTagReferenceBufferWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly AuthoredUserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x694F580", Offset = "0x694DB80", VA = "0x18694F580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal AuthoredUserTagReferenceBufferWrapper(Entity entity, AuthoredUserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredUserTagReferenceBufferProperties : OFFPOFPMKKP<AuthoredUserTagReferenceBufferWrapper, AuthoredUserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly NNHKJGLKIOG<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x695F9C0", Offset = "0x695DFC0", VA = "0x18695F9C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly DBNKJBBIGDJ<AuthoredUserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x694F430", Offset = "0x694DA30", VA = "0x18694F430")]
		public AuthoredUserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override AuthoredUserTagReferenceBufferWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(AuthoredUserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x696B830", Offset = "0x6969E30", VA = "0x18696B830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x696B8D0", Offset = "0x6969ED0", VA = "0x18696B8D0")]
		public JPECDHIKLOG FOLBADKPCFJ()
		{
			return default(JPECDHIKLOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x696B950", Offset = "0x6969F50", VA = "0x18696B950")]
		public bool MCCKFAFOHOJ(JPECDHIKLOG value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : LGDCJDLIJCO<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly NNHKJGLKIOG<JPECDHIKLOG> parameters;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x695EE40", Offset = "0x695D440", VA = "0x18695EE40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly EEOFACKHPBM<JPECDHIKLOG> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x696B6E0", Offset = "0x6969CE0", VA = "0x18696B6E0")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplineShapeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x696CAD0", Offset = "0x696B0D0", VA = "0x18696CAD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : LGDCJDLIJCO<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly NNHKJGLKIOG<JGNDJNOBALA> transformHint;

			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly NNHKJGLKIOG<NGDGKLCCCLB> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x695FA40", Offset = "0x695E040", VA = "0x18695FA40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly EEOFACKHPBM<JGNDJNOBALA> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly EEOFACKHPBM<NGDGKLCCCLB> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x696C8F0", Offset = "0x696AEF0", VA = "0x18696C8F0")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override TransformFlagsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x695C180", Offset = "0x695A780", VA = "0x18695C180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x695C220", Offset = "0x695A820", VA = "0x18695C220")]
		public LONNJOBPNCL IOENPNLNIKK()
		{
			return default(LONNJOBPNCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x695C0D0", Offset = "0x695A6D0", VA = "0x18695C0D0")]
		public void AGAHPAJNOEE(LONNJOBPNCL flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : LGDCJDLIJCO<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly NNHKJGLKIOG<LONNJOBPNCL> flags;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x695F340", Offset = "0x695D940", VA = "0x18695F340")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly EEOFACKHPBM<LONNJOBPNCL> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x695BF80", Offset = "0x695A580", VA = "0x18695BF80")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerFlagsDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[global::FMFALIJHNIH]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[global::OEDHNLDDELA(1)]
		public LONNJOBPNCL flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public BOFJOCMLJKF collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x695BDC0", Offset = "0x695A3C0", VA = "0x18695BDC0")]
			get
			{
				return default(BOFJOCMLJKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x695BE80", Offset = "0x695A480", VA = "0x18695BE80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x695BF20", Offset = "0x695A520", VA = "0x18695BF20")]
		public BOFJOCMLJKF GOLIBOEJIBA()
		{
			return default(BOFJOCMLJKF);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x695BE20", Offset = "0x695A420", VA = "0x18695BE20")]
		public bool EIKNBPBCHJD(BOFJOCMLJKF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionModeDataProperties : LGDCJDLIJCO<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly NNHKJGLKIOG<BOFJOCMLJKF> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x695E980", Offset = "0x695CF80", VA = "0x18695E980")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly EEOFACKHPBM<BOFJOCMLJKF> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x695BC70", Offset = "0x695A270", VA = "0x18695BC70")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ContainerCollisionModeDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEntityRefDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly InteractionFilterEntityRefDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x695DB50", Offset = "0x695C150", VA = "0x18695DB50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal InteractionFilterEntityRefDataWrapper(Entity entity, InteractionFilterEntityRefDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEntityRefDataProperties : LGDCJDLIJCO<InteractionFilterEntityRefDataWrapper, InteractionFilterEntityRefData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly NNHKJGLKIOG<Entity> filterEntity;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x695F2C0", Offset = "0x695D8C0", VA = "0x18695F2C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly EEOFACKHPBM<Entity> filterEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x695DA00", Offset = "0x695C000", VA = "0x18695DA00")]
		public InteractionFilterEntityRefDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override InteractionFilterEntityRefDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(InteractionFilterEntityRefDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6968CE0", Offset = "0x69672E0", VA = "0x186968CE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6968D80", Offset = "0x6967380", VA = "0x186968D80")]
		public bool LNKFMOCBCPB(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : LGDCJDLIJCO<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly NNHKJGLKIOG<float> density;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x695F3C0", Offset = "0x695D9C0", VA = "0x18695F3C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly EEOFACKHPBM<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6968B90", Offset = "0x6967190", VA = "0x186968B90")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override PhysicsMaterialDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public CDIDPDDEDFD scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x69683F0", Offset = "0x69669F0", VA = "0x1869683F0")]
			get
			{
				return default(CDIDPDDEDFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x69682F0", Offset = "0x69668F0", VA = "0x1869682F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6968390", Offset = "0x6966990", VA = "0x186968390")]
		public JOOBBFPCOLA IOENPNLNIKK()
		{
			return default(JOOBBFPCOLA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6968180", Offset = "0x6966780", VA = "0x186968180")]
		public PEHDHGKMHNJ BJMDPEMEPDA()
		{
			return default(PEHDHGKMHNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x69684D0", Offset = "0x6966AD0", VA = "0x1869684D0")]
		public bool PHDCLAOCNAF(PEHDHGKMHNJ value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x69681E0", Offset = "0x69667E0", VA = "0x1869681E0")]
		public void DJHOMGGCCFO(PEHDHGKMHNJ flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6968470", Offset = "0x6966A70", VA = "0x186968470")]
		public NMGHEDLANIA ODLAIDLIDPG()
		{
			return default(NMGHEDLANIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6968290", Offset = "0x6966890", VA = "0x186968290")]
		public bool DOHONADMNMH(NMGHEDLANIA value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : LGDCJDLIJCO<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly NNHKJGLKIOG<CDIDPDDEDFD> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly NNHKJGLKIOG<PEHDHGKMHNJ> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly NNHKJGLKIOG<NMGHEDLANIA> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly NNHKJGLKIOG<JOOBBFPCOLA> flags;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x69601B0", Offset = "0x695E7B0", VA = "0x1869601B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly EEOFACKHPBM<CDIDPDDEDFD> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly EEOFACKHPBM<PEHDHGKMHNJ> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly EEOFACKHPBM<NMGHEDLANIA> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public readonly EEOFACKHPBM<JOOBBFPCOLA> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6967E90", Offset = "0x6966490", VA = "0x186967E90")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ObjectPolicyDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[global::FMFALIJHNIH]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[global::OEDHNLDDELA(1)]
		public JOOBBFPCOLA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[global::OEDHNLDDELA(2)]
		public CDIDPDDEDFD scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[global::OEDHNLDDELA(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[global::FMFALIJHNIH]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[global::OEDHNLDDELA(1)]
		public JOOBBFPCOLA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[global::OEDHNLDDELA(2)]
		public CDIDPDDEDFD scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[global::OEDHNLDDELA(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[global::FMFALIJHNIH]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[global::OEDHNLDDELA(1)]
		public JOOBBFPCOLA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[global::OEDHNLDDELA(2)]
		public CDIDPDDEDFD scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[global::OEDHNLDDELA(3)]
		public PEHDHGKMHNJ userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[global::FMFALIJHNIH]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[global::OEDHNLDDELA(2)]
		public CDIDPDDEDFD scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[global::OEDHNLDDELA(3)]
		public PEHDHGKMHNJ userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[global::OEDHNLDDELA(1)]
		public JOOBBFPCOLA flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x696AD20", Offset = "0x6969320", VA = "0x18696AD20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x696ADC0", Offset = "0x69693C0", VA = "0x18696ADC0")]
		public bool PDDONEKFAJL(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : LGDCJDLIJCO<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly NNHKJGLKIOG<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x695EC40", Offset = "0x695D240", VA = "0x18695EC40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public readonly EEOFACKHPBM<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x696ABD0", Offset = "0x69691D0", VA = "0x18696ABD0")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override SplinePointParentDataWrapper PMNJLKMHGFE(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupKindDataWrapper : PNKIDODJDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly ReferenceGroupKindDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69693D0", Offset = "0x69679D0", VA = "0x1869693D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x694F040", Offset = "0x694D640", VA = "0x18694F040")]
		internal ReferenceGroupKindDataWrapper(Entity entity, ReferenceGroupKindDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupKindDataProperties : LGDCJDLIJCO<ReferenceGroupKindDataWrapper, ReferenceGroupKindData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public static readonly NNHKJGLKIOG<KDBIDFLODON> kind;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x69606F0", Offset = "0x695ECF0", VA = "0x1869606F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public readonly EEOFACKHPBM<KDBIDFLODON> kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly HMLDKFIAGBN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected internal override HMLDKFIAGBN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6969280", Offset = "0x6967880", VA = "0x186969280")]
		public ReferenceGroupKindDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x694EDA0", Offset = "0x694D3A0", VA = "0x18694EDA0", Slot = "18")]
		protected internal override ReferenceGroupKindDataWrapper PMNJLKMHGFE(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x694F950", Offset = "0x694DF50", VA = "0x18694F950")]
		public static (long, string, string) LJEHEJLHLPB(MEMKGEEBKGM value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x694F810", Offset = "0x694DE10", VA = "0x18694F810")]
		public static (long, string, string)[] CJPBAHLMAOC(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x6960A20", Offset = "0x695F020", VA = "0x186960A20")]
		public static Type[] OLOIGHGEKMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6960A70", Offset = "0x695F070", VA = "0x186960A70")]
		private static void OOMCOBOGONK()
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
		[Cpp2IlInjected.Address(RVA = "0x69622E0", Offset = "0x69608E0", VA = "0x1869622E0")]
		public static (Type, long, long)[] OLOIGHGEKMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6962330", Offset = "0x6960930", VA = "0x186962330")]
		private static void OOMCOBOGONK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[KOJHAGOLJDJ(EEHOEHJJGBB.Application)]
	[CompilerGenerated]
	[EGEIKMOFAOL(typeof(IACOFFBLBED), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : IACOFFBLBED
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6967990", Offset = "0x6965F90", VA = "0x186967990")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x69630E0", Offset = "0x69616E0", VA = "0x1869630E0")]
		private void HFBAMFLAFIM()
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
		[Cpp2IlInjected.Address(RVA = "0x696D3C0", Offset = "0x696B9C0", VA = "0x18696D3C0")]
		public static Type[] OLOIGHGEKMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x696D4A0", Offset = "0x696BAA0", VA = "0x18696D4A0")]
		private static void OOMCOBOGONK()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x696FB60", Offset = "0x696E160", VA = "0x18696FB60")]
		public void OOMCOBOGONK(FEIKJFAIAHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x696ECA0", Offset = "0x696D2A0", VA = "0x18696ECA0")]
		private void ADODGPNPKHB(FEIKJFAIAHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x31B0A60", Offset = "0x31AF060", VA = "0x1831B0A60")]
		private void GBEHKHEJPMM<T>(FEIKJFAIAHC registry, [In] T value) where T : struct
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
[KOJHAGOLJDJ(EEHOEHJJGBB.Application)]
[EGEIKMOFAOL(typeof(LEANPNLPEIK), new string[] { "Registry" })]
internal class CKIKPFOIBPD : LEANPNLPEIK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Type IAFDGCGAOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x696D410", Offset = "0x696BA10", VA = "0x18696D410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Type[] CENGLDDPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x696D3C0", Offset = "0x696B9C0", VA = "0x18696D3C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Type[] FMAHLEEOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x696D3B0", Offset = "0x696B9B0", VA = "0x18696D3B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public (Type type, long min, long max)[] BAAIBDODJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x696D470", Offset = "0x696BA70", VA = "0x18696D470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x696D480", Offset = "0x696BA80", VA = "0x18696D480", Slot = "8")]
	public void LEKJOCLKDAK(FEIKJFAIAHC KMNGIDIHGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public CKIKPFOIBPD()
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
