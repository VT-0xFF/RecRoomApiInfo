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
	public static class OTQXTXQNVPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82B3910", Offset = "0x82B2110", VA = "0x1882B3910")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void YRFMZXMZWSX([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB3A0", Offset = "0x3BD9BA0", VA = "0x183BDB3A0")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void OSYDSQHGRSD([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class ZVYJUIWIGWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82B3FE0", Offset = "0x82B27E0", VA = "0x1882B3FE0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void LEQQKCCJYSD([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class MHGMQYHGHWN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB2C0", Offset = "0x3BD9AC0", VA = "0x183BDB2C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void ICPVBHPOWIB([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class XVDTGPMAGRJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB2C0", Offset = "0x3BD9AC0", VA = "0x183BDB2C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void ICPVBHPOWIB([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class CGRCUZONUFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82B3900", Offset = "0x82B2100", VA = "0x1882B3900")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void VRIMKIPWGFZ([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82B38F0", Offset = "0x82B20F0", VA = "0x1882B38F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void ICPVBHPOWIB([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82B38F0", Offset = "0x82B20F0", VA = "0x1882B38F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void LEYHXHBTPBK([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class BIDRRPDUSFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB2C0", Offset = "0x3BD9AC0", VA = "0x183BDB2C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void ZVXFNRVWNYE([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class SYWGVTLTPNE : HBTGGCQSYRO, NDLMBBFOQSV
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SHUZLYBEMFY ACFWAOLPXCH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82B3920", Offset = "0x82B2120", VA = "0x1882B3920", Slot = "15")]
		public void InitReferences(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B3970", Offset = "0x82B2170", VA = "0x1882B3970", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public SYWGVTLTPNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class BHEJCVMKTMH : HBTGGCQSYRO, NDLMBBFOQSV
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery DAJDLTOFCXT;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82B3590", Offset = "0x82B1D90", VA = "0x1882B3590", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "15")]
		public void InitReferences(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82B3620", Offset = "0x82B1E20", VA = "0x1882B3620", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public BHEJCVMKTMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class AWBNQSEVZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB2C0", Offset = "0x3BD9AC0", VA = "0x183BDB2C0")]
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
