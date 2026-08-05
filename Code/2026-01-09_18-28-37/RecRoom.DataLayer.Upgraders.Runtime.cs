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
	public static class HIUUJLGYDUS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81C82C0", Offset = "0x81C76C0", VA = "0x1881C82C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void ODJHXDHSYOY([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB830", Offset = "0x3BBAC30", VA = "0x183BBB830")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void PRRHNOLIXGK([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class GOIWWTRLUFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81C82B0", Offset = "0x81C76B0", VA = "0x1881C82B0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void FSWBJZXJWJW([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class RVEEWMYGUNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB750", Offset = "0x3BBAB50", VA = "0x183BBB750")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void LHHKPNJINUM([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class LFMFSGGFUIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB750", Offset = "0x3BBAB50", VA = "0x183BBB750")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void LHHKPNJINUM([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class JIAIAGVLOEQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81C82D0", Offset = "0x81C76D0", VA = "0x1881C82D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void GLCPZRIJTXM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81C82E0", Offset = "0x81C76E0", VA = "0x1881C82E0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void LHHKPNJINUM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81C82E0", Offset = "0x81C76E0", VA = "0x1881C82E0")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void YCGBOMBGJNP([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class RSRDFBNWGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB750", Offset = "0x3BBAB50", VA = "0x183BBB750")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void LOCHAQAOGGZ([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class VLEASNGWYNN : HSTVJDRLNEJ, RMHBMYLEQGQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HFZJNJYSWWN MEAINQCIGYW;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81C82F0", Offset = "0x81C76F0", VA = "0x1881C82F0", Slot = "15")]
		public void InitReferences(KHYDBENZVLP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81C8340", Offset = "0x81C7740", VA = "0x1881C8340", Slot = "14")]
		protected override void NGUUVZXAACR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C850", Offset = "0x2B6BC50", VA = "0x182B6C850")]
		[Preserve]
		public VLEASNGWYNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ZNXGMAONFCU : HSTVJDRLNEJ, RMHBMYLEQGQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery JRYBYENMGTI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81C8C40", Offset = "0x81C8040", VA = "0x1881C8C40", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "15")]
		public void InitReferences(KHYDBENZVLP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81C89C0", Offset = "0x81C7DC0", VA = "0x1881C89C0", Slot = "14")]
		protected override void NGUUVZXAACR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C850", Offset = "0x2B6BC50", VA = "0x182B6C850")]
		[Preserve]
		public ZNXGMAONFCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class CKGMZTTNATJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB750", Offset = "0x3BBAB50", VA = "0x183BBB750")]
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
