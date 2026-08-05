using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Build;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DisallowSerialization]
public enum LayerMasks
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Nothing = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Everything = -1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	NonPlayerPhysics = 3073,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ToolAndEnemyPhysics = 497427456,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	ToolAndAnyPlayerPhysics = 162936320,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LocalPlayerPhysics = 1049088,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RemotePlayerPhysics = 1052672,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	AnyPlayerPhysics = 1053184,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	ToolAndEnemyAndLocalPlayerPhysics = 498476544,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	ToolAndEnemyAndAnyPlayerPhysics = 498480640,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ToolAndEnemyAndRemotePlayerPhysics = 498480128,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	StaticPhysics = 2048,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	VehiclePhysics = 2097152,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	PredictiveVehicleCollisionDynamic = 16778240,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DefaultOrStaticPhysics = 2049,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	UI = 4197409,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	VehicleMovementCollision = 67128320,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	VehiclePlacementPhysics = 70278656,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	MovementCollision = 69225472,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BulletPhysics = 364133888,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	MirrorCameraCullingMask = 1606418399,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Portal = 2049,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	LaserPointerOccluder = 497433600,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	EnemyPhysics = 335544320,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	OverlayNotifications = 4194304,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	HiddenInFirstPerson = 256,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ToolPhysics = 161883136,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ToolAndStaticPhysics = 161885184,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NonPhysicalTools = 1107312640,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	PhysicalAndNonPhysicalTools = 1269195776,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	IgnoreEnemyPhysics = 419430400,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SteeringAvoidance = 77999104,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenPointer = 1269197825,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenSurfaceSnap = 1269197825,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LaserPushButtonRaycast = -517,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StickyTargets = 498482688,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	RangedWeaponOverlaps = 497427456,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Interactables = 1336290304,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	DoesntOccludeInteractableTargeting = 1111491332,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NonTargetingOccludingTools = 1107296256,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	EnemyColliderCandidate = 343932928,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	DefaultShareCamera = 2143223805,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	LocalHeldShareCamera = 2143223549,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerAISnap = 27536385
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum SerializableLayerMask
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Nothing = 0,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ToolAndAnyPlayerPhysics = 30,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	AnyPlayerPhysics = 60,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	StaticPhysics = 100,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BulletPhysics = 150,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	ToolAndStaticPhysics = 230,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	StickyTargets = 300
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class APTYHSDPWJK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8CF6A70", Offset = "0x8CF5670", VA = "0x188CF6A70")]
	public static LayerMasks AMNLZPALDEG(this SerializableLayerMask a)
	{
		return default(LayerMasks);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum Layers
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TransparentFX = 1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	IgnoreRaycast = 2,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Water = 4,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	UI = 5,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	HiddenInFirstPerson = 8,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	LocalPlayerPhysics = 9,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	DynamicPhysics = 10,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	StaticPhysics = 11,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	RemotePlayerPhysics = 12,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	DynamicPhysicsIgnoreStaticPhysics = 13,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	MovementBlocker = 14,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	DEPRECATED_OutfitTrigger = 15,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CameraMesh = 16,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DynamicPhysicsIgnoreDynamicPhysics = 17,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DynamicPhysicsIgnorePlayerPhysics = 18,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	KillZone = 19,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	PlayerTrigger = 20,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	VehiclePhysics = 21,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	OverlayNotifications = 22,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	DynamicPhysicsIgnoreDynamicAndPlayerPhysics = 23,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DynamicPhysicsIgnoreEnemyAndPlayerPhysics = 24,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	TriggerCollider = 25,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	EnemyPhysics = 26,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	DynamicPhysicsIgnoreDynamicAndPlayerAndEnemyPhysics = 27,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	EnemyPhysicsIgnoreDynamicAndEnemyPhysics = 28,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	FirstPersonShadowCaster = 29,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Decoration = 30,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CachedView = 31
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class VKOLUQXNKUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6BD0", Offset = "0x8CF57D0", VA = "0x188CF6BD0")]
		public static void ERSBRPBCGKV(this GameObject a, Layers b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6F00", Offset = "0x8CF5B00", VA = "0x188CF6F00")]
		public static void XTXZLDHCOND(this GameObject a, Layers b, Layers c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6B90", Offset = "0x8CF5790", VA = "0x188CF6B90")]
		public static bool ECMKJOQDNAV(this GameObject a, LayerMasks b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6EF0", Offset = "0x8CF5AF0", VA = "0x188CF6EF0")]
		public static bool IUVAAHFLGZW(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6E30", Offset = "0x8CF5A30", VA = "0x188CF6E30")]
		public static bool HTCYFFSKKBG(this GameObject a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class DGRYFFYITES
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly int ASZOJHNPKWT;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly int CVGEKTMOLSZ;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly int LYUPLHZDTGR;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly int DPGRXCKXAPA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly int EEWIDLIGBZY;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly int JGWWNDTDKYY;
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
