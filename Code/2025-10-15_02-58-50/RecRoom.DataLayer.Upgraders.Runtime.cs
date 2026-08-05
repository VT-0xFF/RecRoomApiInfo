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
	public static class PWVVJREHOUP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8436DB0", Offset = "0x8435BB0", VA = "0x188436DB0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void PWMAEHNDOTJ([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C34660", Offset = "0x3C33460", VA = "0x183C34660")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void VXZKVTFCNFB([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class RBPWNKTPDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8436DC0", Offset = "0x8435BC0", VA = "0x188436DC0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void ATMCZODJKQL([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class FICSPUSRBTX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C34570", Offset = "0x3C33370", VA = "0x183C34570")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void TNSPMYCTZAB([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class CTJFIVDKHOX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C34570", Offset = "0x3C33370", VA = "0x183C34570")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void TNSPMYCTZAB([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class VNWAUXOEWIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8436DE0", Offset = "0x8435BE0", VA = "0x188436DE0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void WKFBGVENXZB([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8436DD0", Offset = "0x8435BD0", VA = "0x188436DD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void TNSPMYCTZAB([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8436DD0", Offset = "0x8435BD0", VA = "0x188436DD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void CMSEPGEFJEQ([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class KFPXYIJYECT
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C34570", Offset = "0x3C33370", VA = "0x183C34570")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void PPYYBCLLOPO([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class CQLVVMNHHZY : ROCIYXMFVRO, LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private RKCYXOCMPLE FQFTXTABGRB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84369B0", Offset = "0x84357B0", VA = "0x1884369B0", Slot = "15")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8436380", Offset = "0x8435180", VA = "0x188436380", Slot = "14")]
		protected override void CPTKFVTXNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
		[Preserve]
		public CQLVVMNHHZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DQOAOLFHRLV : ROCIYXMFVRO, LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery HTMBLQGSSGB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8436CD0", Offset = "0x8435AD0", VA = "0x188436CD0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "15")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8436A50", Offset = "0x8435850", VA = "0x188436A50", Slot = "14")]
		protected override void CPTKFVTXNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
		[Preserve]
		public DQOAOLFHRLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class JOPSQZUXOWK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C34570", Offset = "0x3C33370", VA = "0x183C34570")]
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
