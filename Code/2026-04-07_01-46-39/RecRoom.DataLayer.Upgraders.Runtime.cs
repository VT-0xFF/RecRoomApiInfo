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
	public static class UFRQPCFCPAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x995F2D0", Offset = "0x995E2D0", VA = "0x18995F2D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void PVWHHFXMWZW([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3AE19E0", Offset = "0x3AE09E0", VA = "0x183AE19E0")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void MTHGCHPZGRM([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class PAADVNKEOWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x995F2C0", Offset = "0x995E2C0", VA = "0x18995F2C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void VLIFTLRJYHG([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class EYIRMCUIHSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AE18F0", Offset = "0x3AE08F0", VA = "0x183AE18F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void BYUDDVSYCUE([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class AQZVHIUQMQA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AE18F0", Offset = "0x3AE08F0", VA = "0x183AE18F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void BYUDDVSYCUE([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class HFSBKNZQRUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x995F2B0", Offset = "0x995E2B0", VA = "0x18995F2B0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void GUKYNWSPOKW([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x995F2A0", Offset = "0x995E2A0", VA = "0x18995F2A0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void BYUDDVSYCUE([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x995F2A0", Offset = "0x995E2A0", VA = "0x18995F2A0")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void FMRGQEVJTFD([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class HKEYFAVPAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3AE18F0", Offset = "0x3AE08F0", VA = "0x183AE18F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void MQRJBTMGGVH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class DQXYXLLGPBN : ETVVCDLRMKV, FEPVKGQXMPS
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NSBQCENPIGJ DCWKPPVIFOC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x995EBD0", Offset = "0x995DBD0", VA = "0x18995EBD0", Slot = "15")]
		public void InitReferences(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x995EC20", Offset = "0x995DC20", VA = "0x18995EC20", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public DQXYXLLGPBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CXIYUEUZPOA : ETVVCDLRMKV, FEPVKGQXMPS
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery BRWDVQMMCSW;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x995E870", Offset = "0x995D870", VA = "0x18995E870", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "15")]
		public void InitReferences(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x995E900", Offset = "0x995D900", VA = "0x18995E900", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public CXIYUEUZPOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class ERENALSAQFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AE18F0", Offset = "0x3AE08F0", VA = "0x183AE18F0")]
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
