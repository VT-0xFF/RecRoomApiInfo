using System;
using System.Reflection;
using System.Runtime.CompilerServices;
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
	public static class STOYLVKRCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89AAA80", Offset = "0x89A9680", VA = "0x1889AAA80")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void QOZRGKBCWSF([RecRoom.DataLayer.Field(3)] bool isFrozen, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7DC0", Offset = "0x3FE69C0", VA = "0x183FE7DC0")]
		[RecRoom.DataLayer.UpgradeFromVersion(5)]
		public static void ASQDNYFIUQF([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 prev, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 curr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
	public static class HPQEBKVLBXZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F60", Offset = "0x89A8B60", VA = "0x1889A9F60")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void SGDMQTYIIUJ([RecRoom.DataLayer.Field(1)] FixedList32BytesLegacy<int> tags, [Out][RecRoom.DataLayer.Field(2)] bool initializedDefaults)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
	public static class JKHAKKGRIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7CD0", Offset = "0x3FE68D0", VA = "0x183FE7CD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void OCNESOJKWNV([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
	public static class IQPOYUGNUCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7CD0", Offset = "0x3FE68D0", VA = "0x183FE7CD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void OCNESOJKWNV([RecRoom.DataLayer.Field(1)] CollisionMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
	public static class MSQXZZGSIFX
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F70", Offset = "0x89A8B70", VA = "0x1889A9F70")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void HIZYXXDCLMZ([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F80", Offset = "0x89A8B80", VA = "0x1889A9F80")]
		[RecRoom.DataLayer.UpgradeFromVersion(2)]
		public static void OCNESOJKWNV([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 newFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F80", Offset = "0x89A8B80", VA = "0x1889A9F80")]
		[RecRoom.DataLayer.UpgradeFromVersion(3)]
		public static void LUUGVUUYFEC([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 oldFlags, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 newFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
	public static class WHZKMYZVKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7CD0", Offset = "0x3FE68D0", VA = "0x183FE7CD0")]
		[RecRoom.DataLayer.UpgradeFromVersion(1)]
		public static void XOOFWZEOXSK([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 src, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 dst)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	public class RRNBVLHWGRC : KJMOKSVJOGK, PEEXKGKATXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public Entity LQOWPMIIAHU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public ObjectPrefabType EMRAXBLBAUL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public RRObjectPrefabData TTDAFUXVNXZ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89A9F90", Offset = "0x89A8B90", VA = "0x1889A9F90")]
			internal object PXESPJPRPJW(Entity a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89AA000", Offset = "0x89A8C00", VA = "0x1889AA000")]
			internal object PXJZMQJOYVF((Entity entity, RRObjectPrefabData prefabData) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private RYCBBUKFDRO MAMJXBFVJUZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override Log NPHEYIXDMFH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x89AA9E0", Offset = "0x89A95E0", VA = "0x1889AA9E0", Slot = "14")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89AA990", Offset = "0x89A9590", VA = "0x1889AA990", Slot = "16")]
		public void InitReferences(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89AA0E0", Offset = "0x89A8CE0", VA = "0x1889AA0E0", Slot = "15")]
		protected override void FIFFBOFXCTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3087E50", Offset = "0x3086A50", VA = "0x183087E50")]
		[Preserve]
		public RRNBVLHWGRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WOWFECRSTYN : KJMOKSVJOGK, PEEXKGKATXF
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private EntityQuery UUNZANQWEVR;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override Log NPHEYIXDMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89AAD10", Offset = "0x89A9910", VA = "0x1889AAD10", Slot = "14")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89AAD60", Offset = "0x89A9960", VA = "0x1889AAD60", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void InitReferences(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89AAA90", Offset = "0x89A9690", VA = "0x1889AAA90", Slot = "15")]
		protected override void FIFFBOFXCTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3087E50", Offset = "0x3086A50", VA = "0x183087E50")]
		[Preserve]
		public WOWFECRSTYN()
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
