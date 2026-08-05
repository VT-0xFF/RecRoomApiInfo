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
	public static class RPVGMIHGTAZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99691A0", Offset = "0x9967BA0", VA = "0x1899691A0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void OWZSTDKOBKF([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x33A23C0", Offset = "0x33A0DC0", VA = "0x1833A23C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void ASAGYGCNQVH([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class ZLTTXLMGBMT
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99691B0", Offset = "0x9967BB0", VA = "0x1899691B0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void XJNUSOBKWRL([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class ZODRRUOOPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x33A22D0", Offset = "0x33A0CD0", VA = "0x1833A22D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void SLOFFEJXZFF([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class VQWTOKXIKQR
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x33A22D0", Offset = "0x33A0CD0", VA = "0x1833A22D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void SLOFFEJXZFF([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class ZONVVPGGFZP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99691C0", Offset = "0x9967BC0", VA = "0x1899691C0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void MQPIAQZSNQV([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99691D0", Offset = "0x9967BD0", VA = "0x1899691D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void SLOFFEJXZFF([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99691D0", Offset = "0x9967BD0", VA = "0x1899691D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void TOENXYFYJTY([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class QJUNLKYVEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x33A22D0", Offset = "0x33A0CD0", VA = "0x1833A22D0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void CCXPQGCEBLE([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class JJBUFMUZOPK : WQJNUUJTJDI, YWYIFNCKTFV
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ADHQIFOWVEE YXXNZSKTYEZ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9968770", Offset = "0x9967170", VA = "0x189968770", Slot = "15")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99687C0", Offset = "0x99671C0", VA = "0x1899687C0", Slot = "14")]
		protected override void UHJCRCGBHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E66290", Offset = "0x2E64C90", VA = "0x182E66290")]
		[Preserve]
		public JJBUFMUZOPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class KNLXWJVITUZ : WQJNUUJTJDI, YWYIFNCKTFV
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery QTIDXDZIEEH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9968E40", Offset = "0x9967840", VA = "0x189968E40", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "15")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9968ED0", Offset = "0x99678D0", VA = "0x189968ED0", Slot = "14")]
		protected override void UHJCRCGBHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E66290", Offset = "0x2E64C90", VA = "0x182E66290")]
		[Preserve]
		public KNLXWJVITUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class VVCDUYAKYBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x33A22D0", Offset = "0x33A0CD0", VA = "0x1833A22D0")]
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
