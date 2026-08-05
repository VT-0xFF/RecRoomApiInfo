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
	public static class SJLVYGUZFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x844FC50", Offset = "0x844EC50", VA = "0x18844FC50")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void LWZGKPBTBFB([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3763900", Offset = "0x3762900", VA = "0x183763900")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void XNARHWKVNAT([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class DFNAOWIZRJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x844FC20", Offset = "0x844EC20", VA = "0x18844FC20")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void EDHGZEPOPTZ([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class EDLWNHELHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3763810", Offset = "0x3762810", VA = "0x183763810")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void RCDXNXCZLGV([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class KVCHUCXANLV
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3763810", Offset = "0x3762810", VA = "0x183763810")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void RCDXNXCZLGV([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class FPJLBGYSNXV
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844FC30", Offset = "0x844EC30", VA = "0x18844FC30")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void EDXZDZMVLHN([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844FC40", Offset = "0x844EC40", VA = "0x18844FC40")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void RCDXNXCZLGV([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844FC40", Offset = "0x844EC40", VA = "0x18844FC40")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void TCAGOJKTMCA([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class OEAEWFRGDFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3763810", Offset = "0x3762810", VA = "0x183763810")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void YCNESTBOMMU([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class THBYBCTAAUG : TVDLTEBRATW, AXDTJKLCJPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ASYAJDCDDZI YSJRZCEMLAH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x844FC60", Offset = "0x844EC60", VA = "0x18844FC60", Slot = "15")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844FCB0", Offset = "0x844ECB0", VA = "0x18844FCB0", Slot = "14")]
		protected override void OLUENGVBIXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD09F0", Offset = "0x2BCF9F0", VA = "0x182BD09F0")]
		[Preserve]
		public THBYBCTAAUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CMRTCVRXXJZ : TVDLTEBRATW, AXDTJKLCJPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityQuery NVGOTDLRHIZ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x844FB40", Offset = "0x844EB40", VA = "0x18844FB40", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "15")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x844F8C0", Offset = "0x844E8C0", VA = "0x18844F8C0", Slot = "14")]
		protected override void OLUENGVBIXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BD09F0", Offset = "0x2BCF9F0", VA = "0x182BD09F0")]
		[Preserve]
		public CMRTCVRXXJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
	public static class WLDMJJONVWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3763810", Offset = "0x3762810", VA = "0x183763810")]
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
