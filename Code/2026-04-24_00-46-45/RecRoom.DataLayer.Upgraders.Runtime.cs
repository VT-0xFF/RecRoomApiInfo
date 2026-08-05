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
	public static class LPBZZFNZBVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99704F0", Offset = "0x996EEF0", VA = "0x1899704F0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void KKLXYUFMKEI([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3D92FD0", Offset = "0x3D919D0", VA = "0x183D92FD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void TWBVJLTFKQW([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class AJHQXTNEIOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x996FDF0", Offset = "0x996E7F0", VA = "0x18996FDF0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void CCTYZRGNZRO([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class EHBQSENFTOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D92EE0", Offset = "0x3D918E0", VA = "0x183D92EE0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void QFIBXAFZFFG([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class ARTFXDPBGSM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D92EE0", Offset = "0x3D918E0", VA = "0x183D92EE0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void QFIBXAFZFFG([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class FWTJWRZXTGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x996FE10", Offset = "0x996E810", VA = "0x18996FE10")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void XFOWKLFOUES([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x996FE00", Offset = "0x996E800", VA = "0x18996FE00")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void QFIBXAFZFFG([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x996FE00", Offset = "0x996E800", VA = "0x18996FE00")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void GLIXSWBCGWV([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class NKFEVJPPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D92EE0", Offset = "0x3D918E0", VA = "0x183D92EE0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void QUSLQRPYVQN([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class HUZWUVCSVXJ : UFEECZPMNGB, YMKBVOLYXIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CAMXWFZJLNX ATQLHMYAFYO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x996FE20", Offset = "0x996E820", VA = "0x18996FE20", Slot = "15")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x996FE70", Offset = "0x996E870", VA = "0x18996FE70", Slot = "14")]
		protected override void SWIMNWSMOCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E65BC0", Offset = "0x2E645C0", VA = "0x182E65BC0")]
		[Preserve]
		public HUZWUVCSVXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class VDGQAYMQLYU : UFEECZPMNGB, YMKBVOLYXIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery PRVIQHBSOVY;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9970500", Offset = "0x996EF00", VA = "0x189970500", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "15")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9970590", Offset = "0x996EF90", VA = "0x189970590", Slot = "14")]
		protected override void SWIMNWSMOCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E65BC0", Offset = "0x2E645C0", VA = "0x182E65BC0")]
		[Preserve]
		public VDGQAYMQLYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class CMUQHBZRDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D92EE0", Offset = "0x3D918E0", VA = "0x183D92EE0")]
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
