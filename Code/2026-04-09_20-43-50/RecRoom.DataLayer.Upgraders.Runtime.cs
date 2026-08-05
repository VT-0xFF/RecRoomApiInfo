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
	public static class FSMMOYUDCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B10", Offset = "0x99A0B10", VA = "0x1899A1B10")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void WDZOSTZIZJQ([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C33D80", Offset = "0x3C32D80", VA = "0x183C33D80")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void KLOTUUAVLMM([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class CIINCFUIHXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B00", Offset = "0x99A0B00", VA = "0x1899A1B00")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void RLEAKBQJPCO([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class EFAKSWPWMGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C90", Offset = "0x3C32C90", VA = "0x183C33C90")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void UHCUTWFSJGC([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class JTCYMQLQFLY
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C90", Offset = "0x3C32C90", VA = "0x183C33C90")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void UHCUTWFSJGC([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class QBWGZVQBZEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99A2550", Offset = "0x99A1550", VA = "0x1899A2550")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void DPLNACWYYRC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99A2560", Offset = "0x99A1560", VA = "0x1899A2560")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void UHCUTWFSJGC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99A2560", Offset = "0x99A1560", VA = "0x1899A2560")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void KWLIYNJJYCT([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class FBKUKRFKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C90", Offset = "0x3C32C90", VA = "0x183C33C90")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void DCWPXUIOAID([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class IDDWTXHXRWN : MQCICDIZMOL, DTRQAXWKVLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KLBTRZMAJCH SSFZWFPDREM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99A2150", Offset = "0x99A1150", VA = "0x1899A2150", Slot = "15")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B20", Offset = "0x99A0B20", VA = "0x1899A1B20", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public IDDWTXHXRWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JIIQCLBISPA : MQCICDIZMOL, DTRQAXWKVLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery TNCOKZPYXHC;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A2470", Offset = "0x99A1470", VA = "0x1899A2470", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A21F0", Offset = "0x99A11F0", VA = "0x1899A21F0", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public JIIQCLBISPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class WLJTLIQAEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C90", Offset = "0x3C32C90", VA = "0x183C33C90")]
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
