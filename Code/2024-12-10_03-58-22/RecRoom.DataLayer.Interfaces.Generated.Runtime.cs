using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B60", Offset = "0x6B88760", VA = "0x186B89B60", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCD60", Offset = "0x6BFB960", VA = "0x186BFCD60")]
		private void MNIOJKDAHNG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCBF0", Offset = "0x6BFB7F0", VA = "0x186BFCBF0")]
		private void FOMIKMKGDKF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCED0", Offset = "0x6BFBAD0", VA = "0x186BFCED0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD210", Offset = "0x6BFBE10", VA = "0x186BFD210")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[RecRoom.DataLayer.Field(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[RecRoom.DataLayer.Field(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[RecRoom.DataLayer.Field(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(14339944730508775718uL)]
	public struct InventionInstanceIdData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[RecRoom.DataLayer.Field(1)]
		public Guid instanceId;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[RecRoom.DataLayer.Field(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[RecRoom.DataLayer.Field(1)]
		public NCAHLIGACJD flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[RecRoom.DataLayer.Field(1)]
		public NBLNKCBJOEI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[RecRoom.DataLayer.Field(2)]
		public MPJMCMMMKMB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[RecRoom.DataLayer.Field(1)]
		public NBLNKCBJOEI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[RecRoom.DataLayer.Field(2)]
		public MPJMCMMMKMB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[RecRoom.DataLayer.Field(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[RecRoom.DataLayer.Field(1)]
		public NBLNKCBJOEI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[RecRoom.DataLayer.Field(2)]
		public MPJMCMMMKMB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[RecRoom.DataLayer.Field(3)]
		public IDFJCJHJMNO userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.TypeVersion(2)]
	[RecRoom.DataLayer.DEPRECATED_NetworkComponent]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[RecRoom.DataLayer.Field(2)]
		public MPJMCMMMKMB scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[RecRoom.DataLayer.Field(3)]
		public IDFJCJHJMNO userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[RecRoom.DataLayer.Field(1)]
		public NBLNKCBJOEI flags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OPMAHOIMEIC : IComparable<OPMAHOIMEIC>, IEquatable<OPMAHOIMEIC>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly OPMAHOIMEIC LPNKNEBEAHM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly OPMAHOIMEIC MIEICEMCCNI;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly OPMAHOIMEIC FKJLJOCECAO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly OPMAHOIMEIC GECPGLIEDFN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly OPMAHOIMEIC JKHPKPMJODL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OPMAHOIMEIC DFCOLCLNBCD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int MFJLAMOCOBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Type DAFMCPDAMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB040", Offset = "0x6BF9C40", VA = "0x186BFB040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FDEMFMNLEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFADD0", Offset = "0x6BF99D0", VA = "0x186BFADD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DMCOCMMDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB3E0", Offset = "0x6BF9FE0", VA = "0x186BFB3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Type IEMAFDGCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB510", Offset = "0x6BFA110", VA = "0x186BFB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LAMLBHNKOCA NPPDBBKFFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB230", Offset = "0x6BF9E30", VA = "0x186BFB230")]
		get
		{
			return default(LAMLBHNKOCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FCCDFEBNLNN FBDOFIAGLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB720", Offset = "0x6BFA320", VA = "0x186BFB720")]
		get
		{
			return default(FCCDFEBNLNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MILEHFBKIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB8F0", Offset = "0x6BFA4F0", VA = "0x186BFB8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LBMMMHIHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB390", Offset = "0x6BF9F90", VA = "0x186BFB390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NNJFIPHIPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB5E0", Offset = "0x6BFA1E0", VA = "0x186BFB5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IGINKJJNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAF00", Offset = "0x6BF9B00", VA = "0x186BFAF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
	public OPMAHOIMEIC(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB1B0", Offset = "0x6BF9DB0", VA = "0x186BFB1B0", Slot = "5")]
	public bool Equals(OPMAHOIMEIC FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB110", Offset = "0x6BF9D10", VA = "0x186BFB110", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB940", Offset = "0x6BFA540", VA = "0x186BFB940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE53A0", Offset = "0x3DE3FA0", VA = "0x183DE53A0", Slot = "4")]
	public int CompareTo(OPMAHOIMEIC FDOEIPBMJJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PNOGKMFKKNL<T>
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly int MFJLAMOCOBC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private OPMAHOIMEIC CNJFHAFLCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		get
		{
			return default(OPMAHOIMEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
	internal PNOGKMFKKNL(int MFJLAMOCOBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1552660", Offset = "0x1551260", VA = "0x181552660")]
	public static OPMAHOIMEIC FGDKAMMLLCN(PNOGKMFKKNL<T> OPOMMFAAAOF)
	{
		return default(OPMAHOIMEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x491F900", Offset = "0x491E500", VA = "0x18491F900", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4920770", Offset = "0x491F370", VA = "0x184920770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BDFB10", Offset = "0x6BDE710", VA = "0x186BDFB10")]
		public static (long, string, string) EPKOBKNILCJ(EKPAFNPHKFE value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1780", Offset = "0x6BE0380", VA = "0x186BE1780")]
		public static (long, string, string)[] PNDGIIMDEJM(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBCD0", Offset = "0x6BEA8D0", VA = "0x186BEBCD0")]
		public static Type[] APBPGLBBDED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBD20", Offset = "0x6BEA920", VA = "0x186BEBD20")]
		private static void PEGPHNFMEDB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public class NetworkProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly PNOGKMFKKNL<uint> OverrideObjectNetworkIdData_networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly PNOGKMFKKNL<FixedList32Bytes<int>> PersistentUserTagData_tags;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly PNOGKMFKKNL<bool> PersistentUserTagData_initalizedDefaults;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly PNOGKMFKKNL<float3> LocalDeformableScaleData_localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly PNOGKMFKKNL<float3> SplinePointScaleData_localScale;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly PNOGKMFKKNL<float> LocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly PNOGKMFKKNL<AALAMJMKCOL> InteractionFilterEnabledData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly PNOGKMFKKNL<LocalId> ReferenceGroupReferenceBuffer_reference;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly PNOGKMFKKNL<long> InventionIdData_inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly PNOGKMFKKNL<LocalId> UserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly PNOGKMFKKNL<FixedList32Bytes<int>> InteractionFilterData_tags;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly PNOGKMFKKNL<bool> InteractionFilterData_enabled;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly PNOGKMFKKNL<AALAMJMKCOL> InteractionFilterData_filterMode;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly PNOGKMFKKNL<DBBJCJICPMA> ComponentSerializedVersionData_version;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly PNOGKMFKKNL<LocalId> ReferenceGroupOwnerData_owner;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly PNOGKMFKKNL<bool> MakerPenHeldData_makerPenHeld;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PNOGKMFKKNL<float> ToolCleanupSettingsData_delay;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly PNOGKMFKKNL<DKDJCAKPEJH> ToolCleanupSettingsData_toolCleanupFlags;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly PNOGKMFKKNL<KDOGGLNNCFG> SplinePointOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly PNOGKMFKKNL<int> CostumePieceSlotIndexData_slotIndex;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly PNOGKMFKKNL<quaternion> LocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly PNOGKMFKKNL<float3> LocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly PNOGKMFKKNL<bool> ReplicatedObjectActiveStatusData_active;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly PNOGKMFKKNL<int> ReplicatorPreallocatedObjectCountData_preallocatedCopies;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PNOGKMFKKNL<quaternion> SplinePointRotationData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly PNOGKMFKKNL<LocalId> InteractionFilterAllTagsData_allTags;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly PNOGKMFKKNL<float> ToolCleanupStatusData_cleanupStartTime;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly PNOGKMFKKNL<ALOIBALNGAA> ToolCleanupStatusData_statusFlags;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly PNOGKMFKKNL<LocalId> InteractionFilterAnyTagsData_anyTags;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly PNOGKMFKKNL<float3> SplinePointPositionData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly PNOGKMFKKNL<JMPLPCFCNKL> ShapeTypeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly PNOGKMFKKNL<FLDGGDEOLHM> PrimitiveShapeData_shapeType;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly PNOGKMFKKNL<LocalId> ReplicatorData_Target;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly PNOGKMFKKNL<bool> ReplicatorData_NeedsCircuitUpdate;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly PNOGKMFKKNL<LocalId> PlayerScopeData_playerScope;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly PNOGKMFKKNL<NetworkGuid> InventionInstanceIdData_instanceId;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly PNOGKMFKKNL<LocalId> EntityBundlePartData_prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly PNOGKMFKKNL<uint> EntityBundlePartData_entityBundlePartId;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly PNOGKMFKKNL<int> ReplicatedObjectOwnedByPlayerData_actorId;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly PNOGKMFKKNL<bool> OMShapeContainerData_canModifyWithCircuits;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly PNOGKMFKKNL<bool> OMShapeContainerData_optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly PNOGKMFKKNL<LocalId> AuthoredParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly PNOGKMFKKNL<FixedString32Bytes> UserTagNameData_Value;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly PNOGKMFKKNL<KOIOJDPNKFG> NavMeshGenerationData_mode;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly PNOGKMFKKNL<FixedString64Bytes> ContainerNameData_name;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly PNOGKMFKKNL<BBKOFHLHEBG> ShapeConfigData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly PNOGKMFKKNL<LocalId> ParentData_parent;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly PNOGKMFKKNL<int> ReplicatorMaxObjectCountData_MaxCopies;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly PNOGKMFKKNL<float> ContainerMassOverrideData_mass;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly PNOGKMFKKNL<quaternion> AuthoredLocalPoseData_localRotation;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly PNOGKMFKKNL<float3> AuthoredLocalPoseData_localPosition;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly PNOGKMFKKNL<NetworkGuid> ObjectBoardNodeData_nodeId;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly PNOGKMFKKNL<NetworkGuid> ObjectBoardNodeData_graphId;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly PNOGKMFKKNL<float> AuthoredLocalUniformScaleData_localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly PNOGKMFKKNL<KFACANAEJMG> StandardRenderableVisualData_color;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly PNOGKMFKKNL<IIABJBBPAPB> StandardRenderableVisualData_material;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly PNOGKMFKKNL<float> StandardRenderableVisualData_uvScale;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly PNOGKMFKKNL<float3> StandardRenderableVisualData_uvOffset;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly PNOGKMFKKNL<PFAGBDBNINI> ContainerCollisionLayerData_collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly PNOGKMFKKNL<LocalId> InteractionFilterNoneTagsData_noneTags;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly PNOGKMFKKNL<KDOGGLNNCFG> SiblingSortOrderData_order;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly PNOGKMFKKNL<JCOOFEPGIPB> ContainerGrabbableModeData_grabbableMode;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly PNOGKMFKKNL<LocalId> CostumePieceParentCostumeData_parentCostume;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly PNOGKMFKKNL<LocalId> AuthoredUserTagReferenceBuffer_Child;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly PNOGKMFKKNL<ENKLMLKMLJC> SplineShapeData_parameters;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly PNOGKMFKKNL<DGDIIOJMPHI> TransformFlagsData_transformHint;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly PNOGKMFKKNL<LPJHKBMDJNE> TransformFlagsData_transformPriority;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly PNOGKMFKKNL<NCAHLIGACJD> ContainerFlagsData_flags;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly PNOGKMFKKNL<KDBPJBNOMHD> ContainerCollisionModeData_collisionMode;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly PNOGKMFKKNL<LocalId> InteractionFilterEntityRefData_filterEntity;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly PNOGKMFKKNL<float> PhysicsMaterialData_density;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly PNOGKMFKKNL<MPJMCMMMKMB> ObjectPolicyData_scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly PNOGKMFKKNL<IDFJCJHJMNO> ObjectPolicyData_userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly PNOGKMFKKNL<HGPGHDAEOFM> ObjectPolicyData_circuitsTransformBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly PNOGKMFKKNL<NBLNKCBJOEI> ObjectPolicyData_flags;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly PNOGKMFKKNL<LocalId> SplinePointParentData_spline;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly PNOGKMFKKNL<AFHJIGHFEFH> ReferenceGroupKindData_kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	[ServiceLifetime(Lifetime.Application)]
	[RegisterService(typeof(EBHADBONBLI), new string[] { "Registry", "Ignore" })]
	internal class NetworkPropertyRegistry : EBHADBONBLI, OMHHLNDDBBK, POGLPIENEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NativeArray<int> sizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeBitArray entityByProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NativeBitArray bufferByProperty;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NativeArray<int> Offsets
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0", Slot = "6")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeArray<int> Sizes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA6A0D0", Offset = "0xA68CD0", VA = "0x180A6A0D0", Slot = "7")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NativeBitArray EntityByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA7C320", Offset = "0xA7AF20", VA = "0x180A7C320", Slot = "8")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NativeBitArray BufferByProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8F45E0", Offset = "0x8F31E0", VA = "0x1808F45E0", Slot = "9")]
			get
			{
				return default(NativeBitArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Type[] PropertyTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88C6D0", Offset = "0x88B2D0", VA = "0x18088C6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Type[] ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x88C530", Offset = "0x88B130", VA = "0x18088C530", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88C6F0", Offset = "0x88B2F0", VA = "0x18088C6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public LAMLBHNKOCA[] PropertyMetadata
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x88D710", Offset = "0x88C310", VA = "0x18088D710", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x88D700", Offset = "0x88C300", VA = "0x18088D700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<int, FCCDFEBNLNN> ComponentPropertyMetadataByTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x88C750", Offset = "0x88B350", VA = "0x18088C750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6BF7470", Offset = "0x6BF6070", VA = "0x186BF7470", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7490", Offset = "0x6BF6090", VA = "0x186BF7490", Slot = "13")]
		public void KEOFPJKOBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BF74A0", Offset = "0x6BF60A0", VA = "0x186BF74A0", Slot = "14")]
		public void NPJJLDNPIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDE20", Offset = "0x6BECA20", VA = "0x186BEDE20")]
		private void AHNBKBIHHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NetworkPropertyRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	public static class NetworkPropertySerializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9920", Offset = "0x6BF8520", VA = "0x186BF9920")]
		public static void KPNGEGKIPDM(GLPNGAEBKBF writer, OPMAHOIMEIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8CA0", Offset = "0x6BF78A0", VA = "0x186BF8CA0")]
		public static void HFODKNHEMHK(PIBOEPEAJAM reader, OPMAHOIMEIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7500", Offset = "0x6BF6100", VA = "0x186BF7500")]
		private static void GGDIIBAPFBL(GLPNGAEBKBF writer, OPMAHOIMEIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9940", Offset = "0x6BF8540", VA = "0x186BF9940")]
		private static void PPOKCJHFHHD(PIBOEPEAJAM reader, OPMAHOIMEIC property, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3350", Offset = "0x2FB1F50", VA = "0x182FB3350")]
		internal static void IMPFBNFMBKJ<T>(GLPNGAEBKBF writer, PNOGKMFKKNL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB2F30", Offset = "0x2FB1B30", VA = "0x182FB2F30")]
		internal static void ICHKPGLOBMP<T>(PIBOEPEAJAM reader, PNOGKMFKKNL<T> prop, NativeArray<byte> data, byte min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3470", Offset = "0x2FB2070", VA = "0x182FB3470")]
		internal static void IMPFBNFMBKJ<T>(GLPNGAEBKBF writer, PNOGKMFKKNL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3020", Offset = "0x2FB1C20", VA = "0x182FB3020")]
		internal static void ICHKPGLOBMP<T>(PIBOEPEAJAM reader, PNOGKMFKKNL<T> prop, NativeArray<byte> data, int min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2FB36A0", Offset = "0x2FB22A0", VA = "0x182FB36A0")]
		internal static void IMPFBNFMBKJ<T>(GLPNGAEBKBF writer, PNOGKMFKKNL<T> prop, NativeArray<byte> data, uint min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2FB31F0", Offset = "0x2FB1DF0", VA = "0x182FB31F0")]
		internal static void ICHKPGLOBMP<T>(PIBOEPEAJAM reader, PNOGKMFKKNL<T> prop, NativeArray<byte> data, uint min) where T : struct, Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9660", Offset = "0x6BF8260", VA = "0x186BF9660")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9290", Offset = "0x6BF7E90", VA = "0x186BF9290")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<bool> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BF93A0", Offset = "0x6BF7FA0", VA = "0x186BF93A0")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8D70", Offset = "0x6BF7970", VA = "0x186BF8D70")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<int> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BF96D0", Offset = "0x6BF82D0", VA = "0x186BF96D0")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9180", Offset = "0x6BF7D80", VA = "0x186BF9180")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<uint> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9340", Offset = "0x6BF7F40", VA = "0x186BF9340")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8DD0", Offset = "0x6BF79D0", VA = "0x186BF8DD0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<long> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF95F0", Offset = "0x6BF81F0", VA = "0x186BF95F0")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF91E0", Offset = "0x6BF7DE0", VA = "0x186BF91E0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<float> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF98B0", Offset = "0x6BF84B0", VA = "0x186BF98B0")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BF90D0", Offset = "0x6BF7CD0", VA = "0x186BF90D0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<float3> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9580", Offset = "0x6BF8180", VA = "0x186BF9580")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8CC0", Offset = "0x6BF78C0", VA = "0x186BF8CC0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<quaternion> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9730", Offset = "0x6BF8330", VA = "0x186BF9730")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8E30", Offset = "0x6BF7A30", VA = "0x186BF8E30")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<NetworkGuid> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3550", Offset = "0x2FB2150", VA = "0x182FB3550")]
		internal static void IMPFBNFMBKJ<T>(GLPNGAEBKBF writer, PNOGKMFKKNL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3100", Offset = "0x2FB1D00", VA = "0x182FB3100")]
		internal static void ICHKPGLOBMP<T>(PIBOEPEAJAM reader, PNOGKMFKKNL<FixedList32Bytes<T>> prop, NativeArray<byte> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BF97A0", Offset = "0x6BF83A0", VA = "0x186BF97A0")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8FA0", Offset = "0x6BF7BA0", VA = "0x186BF8FA0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<FixedString32Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9470", Offset = "0x6BF8070", VA = "0x186BF9470")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8EE0", Offset = "0x6BF7AE0", VA = "0x186BF8EE0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<FixedString64Bytes> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9400", Offset = "0x6BF8000", VA = "0x186BF9400")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<KDOGGLNNCFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9060", Offset = "0x6BF7C60", VA = "0x186BF9060")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<KDOGGLNNCFG> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BDFA30", Offset = "0x6BDE630", VA = "0x186BDFA30")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, PNOGKMFKKNL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BDF6F0", Offset = "0x6BDE2F0", VA = "0x186BDF6F0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, PNOGKMFKKNL<LocalId> prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDFA30", Offset = "0x6BDE630", VA = "0x186BDFA30")]
		internal static void IMPFBNFMBKJ(GLPNGAEBKBF writer, OPMAHOIMEIC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BDF6F0", Offset = "0x6BDE2F0", VA = "0x186BDF6F0")]
		internal static void ICHKPGLOBMP(PIBOEPEAJAM reader, OPMAHOIMEIC prop, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB32D0", Offset = "0x2FB1ED0", VA = "0x182FB32D0")]
		internal static T ILJOHLAMDKO<T>(this NativeArray<byte> data) where T : struct
		{
			return (T)null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCBE0", Offset = "0x6BFB7E0", VA = "0x186BFCBE0")]
		public void PEGPHNFMEDB(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBC90", Offset = "0x6BFA890", VA = "0x186BFBC90")]
		private void IOFDEPKEEOD(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3468B60", Offset = "0x3467760", VA = "0x183468B60")]
		private void GGEFPJDIECC<T>(IComponentDefaultRegistration registry, [In] T value) where T : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PJEMKBLPKEE
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CreateObject = -1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DestroyObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	BeginTransaction = -3,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	EndTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	External = -5
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(LIFHNJIHFKA), new string[] { "Registry" })]
[ServiceLifetime(Lifetime.Application)]
internal class MNKPBILBIPN : LIFHNJIHFKA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Type BEMENKAIFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD450", Offset = "0x6BFC050", VA = "0x186BFD450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public Type[] FHEDGIFDMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BFD440", Offset = "0x6BFC040", VA = "0x186BFD440", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD4B0", Offset = "0x6BFC0B0", VA = "0x186BFD4B0", Slot = "6")]
	public void NLKCPOIHLJH(IComponentDefaultRegistration LHOGDPPEIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public MNKPBILBIPN()
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
