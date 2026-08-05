using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.Foundation.Service;
using Unity.Collections;
using Unity.Entities;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
	public static class RVWBSGGKPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D20", Offset = "0x83E4F20", VA = "0x1883E5D20")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void GOCKKVUBELM([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C51F20", Offset = "0x3C51120", VA = "0x183C51F20")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void KXHQQBIPWUU([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class LEIVCCFUAHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E5CF0", Offset = "0x83E4EF0", VA = "0x1883E5CF0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void RGOFHOWWZEO([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class BHRMCCBAPTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E40", Offset = "0x3C51040", VA = "0x183C51E40")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void SPGZMOCXYXA([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class FNRXJIXSFTU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E40", Offset = "0x3C51040", VA = "0x183C51E40")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void SPGZMOCXYXA([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class QIOJXKXERUC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D10", Offset = "0x83E4F10", VA = "0x1883E5D10")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void TFTKQIXGWHC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D00", Offset = "0x83E4F00", VA = "0x1883E5D00")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void SPGZMOCXYXA([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D00", Offset = "0x83E4F00", VA = "0x1883E5D00")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void HZTVWASQYNB([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class IDUABKYTQEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E40", Offset = "0x3C51040", VA = "0x183C51E40")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void HYNIDGWHAWT([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class HLKGTYVWVCB : KJOWQMDZKLV, HSMOOTIZJVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OIAVVFDNJAP QECJRXABFGM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83E5630", Offset = "0x83E4830", VA = "0x1883E5630", Slot = "15")]
		public void InitReferences(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83E5680", Offset = "0x83E4880", VA = "0x1883E5680", Slot = "14")]
		protected override void NJITXRATJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFCE0", Offset = "0x2BBEEE0", VA = "0x182BBFCE0")]
		[Preserve]
		public HLKGTYVWVCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UIKHXCDVDHQ : KJOWQMDZKLV, HSMOOTIZJVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery XAEKGQVKYGM;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83E5FB0", Offset = "0x83E51B0", VA = "0x1883E5FB0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "15")]
		public void InitReferences(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D30", Offset = "0x83E4F30", VA = "0x1883E5D30", Slot = "14")]
		protected override void NJITXRATJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFCE0", Offset = "0x2BBEEE0", VA = "0x182BBFCE0")]
		[Preserve]
		public UIKHXCDVDHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class FIBFIUYEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C51E40", Offset = "0x3C51040", VA = "0x183C51E40")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void Upgrade([RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v1 prev, [Out][RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v2 next)
		{
		}
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
