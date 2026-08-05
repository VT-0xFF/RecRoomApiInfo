using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
}
namespace Circuits.Static.RecRoom.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct ExternalFnRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Id32<YVHVHYLYUBD> AddVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Id32<YVHVHYLYUBD> CircuitsColorInverseLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Id32<YVHVHYLYUBD> CircuitsColorLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Id32<YVHVHYLYUBD> CircuitsQuatInverseLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Id32<YVHVHYLYUBD> CircuitsQuatLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Id32<YVHVHYLYUBD> CircuitsVec3InverseLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Id32<YVHVHYLYUBD> CircuitsVec3Lerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public Id32<YVHVHYLYUBD> ClampFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Id32<YVHVHYLYUBD> ClampInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Id32<YVHVHYLYUBD> CreateVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public Id32<YVHVHYLYUBD> DivideVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public Id32<YVHVHYLYUBD> EqualBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Id32<YVHVHYLYUBD> F32AbsoluteValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Id32<YVHVHYLYUBD> I32AbsoluteValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Id32<YVHVHYLYUBD> InverseLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Id32<YVHVHYLYUBD> Lerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Id32<YVHVHYLYUBD> MultiplyVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Id32<YVHVHYLYUBD> QuaternionCreateLook;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public Id32<YVHVHYLYUBD> QuaternionSlerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Id32<YVHVHYLYUBD> RandomFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Id32<YVHVHYLYUBD> RandomInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Id32<YVHVHYLYUBD> SplitVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Id32<YVHVHYLYUBD> StringContains;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Id32<YVHVHYLYUBD> StringGetLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Id32<YVHVHYLYUBD> StringToLower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Id32<YVHVHYLYUBD> SubtractVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Id32<YVHVHYLYUBD> TextToolSetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Id32<YVHVHYLYUBD> TextToolSetText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Id32<YVHVHYLYUBD> TextToolSetMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Id32<YVHVHYLYUBD> Vector3Dot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Id32<YVHVHYLYUBD> Vector3Angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Id32<YVHVHYLYUBD> Vector3Inverse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Id32<YVHVHYLYUBD> Vector3ScaleFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Id32<YVHVHYLYUBD> Vector3ScaleInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Id32<YVHVHYLYUBD> VectorGetMagnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Id32<YVHVHYLYUBD> VectorInverseTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Id32<YVHVHYLYUBD> VectorNormalize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Id32<YVHVHYLYUBD> VectorProject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Id32<YVHVHYLYUBD> VectorProjectOnPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Id32<YVHVHYLYUBD> VectorSlerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Id32<YVHVHYLYUBD> VectorTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Id32<YVHVHYLYUBD> InvisibleCollisionSetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Id32<YVHVHYLYUBD> PlayerGetEquippedObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Id32<YVHVHYLYUBD> PlayerToString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Id32<YVHVHYLYUBD> BoolToString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Id32<YVHVHYLYUBD> F32ToString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Id32<YVHVHYLYUBD> I32ToString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Id32<YVHVHYLYUBD> ObjectToString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Id32<YVHVHYLYUBD> ObjectEquals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Id32<YVHVHYLYUBD> AlwaysValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Id32<YVHVHYLYUBD> NeverValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Id32<YVHVHYLYUBD> NotNullValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Id32<YVHVHYLYUBD> PlayerIsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Id32<YVHVHYLYUBD> ButtonGetIsPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Id32<YVHVHYLYUBD> ButtonGetText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Id32<YVHVHYLYUBD> ButtonSetText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Id32<YVHVHYLYUBD> ListGetElement4Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Id32<YVHVHYLYUBD> ListGetElement12Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Id32<YVHVHYLYUBD> ListGetElement16Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Id32<YVHVHYLYUBD> ListGetElementManaged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Id32<YVHVHYLYUBD> ListSetElement4Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Id32<YVHVHYLYUBD> ListSetElement12Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Id32<YVHVHYLYUBD> ListSetElement16Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Id32<YVHVHYLYUBD> ListSetElementManaged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Id32<YVHVHYLYUBD> ListGetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Id32<YVHVHYLYUBD> Acos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Id32<YVHVHYLYUBD> Asin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Id32<YVHVHYLYUBD> Atan2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Id32<YVHVHYLYUBD> Atan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Id32<YVHVHYLYUBD> Cos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Id32<YVHVHYLYUBD> Sin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Id32<YVHVHYLYUBD> Tan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Id32<YVHVHYLYUBD> CeilToInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Id32<YVHVHYLYUBD> Floor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Id32<YVHVHYLYUBD> FloorToInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Id32<YVHVHYLYUBD> IntToFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Id32<YVHVHYLYUBD> Logarithm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Id32<YVHVHYLYUBD> ModuloInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Id32<YVHVHYLYUBD> ModuloFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Id32<YVHVHYLYUBD> PowerInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Id32<YVHVHYLYUBD> PowerFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Id32<YVHVHYLYUBD> QuaternionCreateAngleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Id32<YVHVHYLYUBD> QuaternionCreateEulerAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Id32<YVHVHYLYUBD> QuaternionCreateFromTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Id32<YVHVHYLYUBD> QuaternionCreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Id32<YVHVHYLYUBD> QuaternionInverse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Id32<YVHVHYLYUBD> RemainderInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Id32<YVHVHYLYUBD> RemainderFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Id32<YVHVHYLYUBD> Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Id32<YVHVHYLYUBD> Round;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Id32<YVHVHYLYUBD> RoundToInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Id32<YVHVHYLYUBD> StudioObjectGetBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Id32<YVHVHYLYUBD> StudioObjectGetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Id32<YVHVHYLYUBD> StudioObjectGetFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Id32<YVHVHYLYUBD> StudioObjectGetInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Id32<YVHVHYLYUBD> StudioObjectGetQuaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Id32<YVHVHYLYUBD> StudioObjectGetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Id32<YVHVHYLYUBD> StudioObjectGetVector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Id32<YVHVHYLYUBD> ToggleButtonSetIsPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Id32<YVHVHYLYUBD> CreationObjectOutline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Id32<YVHVHYLYUBD> PlayerResetHealth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Id32<YVHVHYLYUBD> RotatorSetTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Id32<YVHVHYLYUBD> LocalPlayerGetIsDeveloper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Id32<YVHVHYLYUBD> ImpulseSetPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Id32<YVHVHYLYUBD> ImpulseSetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Id32<YVHVHYLYUBD> HolotarProjectorSetVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Id32<YVHVHYLYUBD> GetAllInventoryItemsWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Id32<YVHVHYLYUBD> GetInventoryItemDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Id32<YVHVHYLYUBD> CloudDataFlush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Id32<YVHVHYLYUBD> ParseInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Id32<YVHVHYLYUBD> ParseFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Id32<YVHVHYLYUBD> ParseBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Id32<YVHVHYLYUBD> ParseDateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Id32<YVHVHYLYUBD> ParseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Id32<YVHVHYLYUBD> LeaderboardGetProjectorEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Id32<YVHVHYLYUBD> LeaderboardSetProjectorEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Id32<YVHVHYLYUBD> LocalPlayerRequestThirdPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Id32<YVHVHYLYUBD> LocalPlayerGetIsThirdPersonActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Id32<YVHVHYLYUBD> HandleSetControlLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Id32<YVHVHYLYUBD> HandleGetControlLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Id32<YVHVHYLYUBD> SwingHandleGetIsSwinging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Id32<YVHVHYLYUBD> GunHandleGetCurrentAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Id32<YVHVHYLYUBD> GunHandleGetMaxAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Id32<YVHVHYLYUBD> GunHandleSetCurrentAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Id32<YVHVHYLYUBD> GunHandleSetMaxAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Id32<YVHVHYLYUBD> GunHandleSetADSEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Id32<YVHVHYLYUBD> GunHandleSetRateOfFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Id32<YVHVHYLYUBD> GunHandleGetRateOfFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Id32<YVHVHYLYUBD> GunHandleSetReloadDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Id32<YVHVHYLYUBD> GunHandleGetReloadDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Id32<YVHVHYLYUBD> GunHandleGetIsReloading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Id32<YVHVHYLYUBD> GunHandleGetCanReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Id32<YVHVHYLYUBD> GunHandleSetCanReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Id32<YVHVHYLYUBD> GunHandleGetContinuousFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Id32<YVHVHYLYUBD> GunHandleSetContinuousFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Id32<YVHVHYLYUBD> GunHandleGetFiringDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Id32<YVHVHYLYUBD> GunHandleApplyRecoil;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Id32<YVHVHYLYUBD> GunHandleAddAutoAimRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Id32<YVHVHYLYUBD> GunHandleRemoveAutoAimRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Id32<YVHVHYLYUBD> GunHandleSetAutoAimRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Id32<YVHVHYLYUBD> TriggerHandleGetPrimaryActionHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetPathingTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetRotationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetPathingTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetRotationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetMaxLinearSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetMaxAngularSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetMaxAcceleration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetMaxAcceleration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Id32<YVHVHYLYUBD> SteeringEngineStopPathing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Id32<YVHVHYLYUBD> SteeringEngineStopRotating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetPathingState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetRotationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetEnableGroundClamping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Id32<YVHVHYLYUBD> SteeringEngineSetTagsToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetEnableGroundClamping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetTagsToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetMaxLinearSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Id32<YVHVHYLYUBD> SteeringEngineGetMaxAngularSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Id32<YVHVHYLYUBD> PlayerAddRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Id32<YVHVHYLYUBD> PlayerBodyOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Id32<YVHVHYLYUBD> PlayerBodyPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Id32<YVHVHYLYUBD> PlayerGetCanFly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Id32<YVHVHYLYUBD> PlayerGetCanTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Id32<YVHVHYLYUBD> PlayerGetCanWallClimb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Id32<YVHVHYLYUBD> PlayerGetCrouchInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Id32<YVHVHYLYUBD> PlayerGetCanWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Id32<YVHVHYLYUBD> PlayerGetCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Id32<YVHVHYLYUBD> PlayerGetDominantHandIsRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Id32<YVHVHYLYUBD> PlayerIsAuthorityOf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Id32<YVHVHYLYUBD> PlayerGetIsJumpingOrFalling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Id32<YVHVHYLYUBD> PlayerIsRoomContributor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Id32<YVHVHYLYUBD> PlayerIsRoomHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Id32<YVHVHYLYUBD> PlayerIsRoomMod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Id32<YVHVHYLYUBD> PlayerIsRoomOwner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Id32<YVHVHYLYUBD> PlayerHasRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Id32<YVHVHYLYUBD> PlayerHeadHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Id32<YVHVHYLYUBD> PlayerHeadForwardVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Id32<YVHVHYLYUBD> PlayerHeadOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Id32<YVHVHYLYUBD> PlayerHeadPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Id32<YVHVHYLYUBD> PlayerHeadUpVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Id32<YVHVHYLYUBD> PlayerHeadVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandFingerDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandThumbDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Id32<YVHVHYLYUBD> PlayerRightHandFingerDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Id32<YVHVHYLYUBD> PlayerRightHandPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Id32<YVHVHYLYUBD> PlayerRightHandOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Id32<YVHVHYLYUBD> PlayerRightHandThumbDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Id32<YVHVHYLYUBD> PlayerRightHandVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Id32<YVHVHYLYUBD> RotatorGetTargetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Id32<YVHVHYLYUBD> RotatorGetRotationAcceleration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Id32<YVHVHYLYUBD> RotatorGetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Id32<YVHVHYLYUBD> RotatorGetRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Id32<YVHVHYLYUBD> RotatorSetRotationAcceleration_DEPRECATED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Id32<YVHVHYLYUBD> RotatorSetRotationAcceleration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Id32<YVHVHYLYUBD> RotatorSetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Id32<YVHVHYLYUBD> RotatorSetRotationSpeed_DEPRECATED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Id32<YVHVHYLYUBD> RotatorSetRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Id32<YVHVHYLYUBD> ClearPlayerVignette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Id32<YVHVHYLYUBD> ClearPlayerWorldUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Id32<YVHVHYLYUBD> DisplayHUDElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Id32<YVHVHYLYUBD> GetGameHudElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Id32<YVHVHYLYUBD> GetHUDElementColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Id32<YVHVHYLYUBD> GetGameHUDElementEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Id32<YVHVHYLYUBD> GetGameHUDElementLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Id32<YVHVHYLYUBD> GetGameHUDElementMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Id32<YVHVHYLYUBD> GetGameHUDElementValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementConstantValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Id32<YVHVHYLYUBD> SetGameHUDElementValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Id32<YVHVHYLYUBD> ShowGameHUDElementLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Id32<YVHVHYLYUBD> ShowGameHUDElementValueText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUIEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUIPrimaryBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUIPrimaryBarEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUIPrimaryBarMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUIPrimaryBarValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUISecondaryBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUISecondaryBarEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUISecondaryBarMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUISecondaryBarValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUITextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUITextEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Id32<YVHVHYLYUBD> GetPlayerWorldUITextText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUIPrimaryBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUIPrimaryBarEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUIPrimaryBarMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUIPrimaryBarValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUISecondaryBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUISecondaryBarEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUISecondaryBarMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUISecondaryBarValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUITextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUITextEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Id32<YVHVHYLYUBD> SetPlayerWorldUITextText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Id32<YVHVHYLYUBD> ResetPlayerWorldUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Id32<YVHVHYLYUBD> SetPlayerVignette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetCurrentDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetDistanceIndicatorEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetLabelEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetProximityFadeThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetTargetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerGetTargetPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetDistanceIndicatorEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetLabelEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetProximityFadeThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetTargetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Id32<YVHVHYLYUBD> ObjectiveMarkerSetTargetPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Id32<YVHVHYLYUBD> PlayerGetXp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Id32<YVHVHYLYUBD> PlayerGetRoomLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Id32<YVHVHYLYUBD> PlayerGetIsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Id32<YVHVHYLYUBD> PlayerGetIsCrouching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Id32<YVHVHYLYUBD> PlayerGetIsGrounded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Id32<YVHVHYLYUBD> PlayerGetIsProne;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Id32<YVHVHYLYUBD> PlayerGetIsSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Id32<YVHVHYLYUBD> PlayerGetIsSprinting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Id32<YVHVHYLYUBD> ClearUgcSubtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Id32<YVHVHYLYUBD> ShowUgcSubtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Id32<YVHVHYLYUBD> PlayerGetCrouchSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Id32<YVHVHYLYUBD> PlayerGetForceManualSprint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Id32<YVHVHYLYUBD> PlayerGetForceVirtualHeightMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Id32<YVHVHYLYUBD> PlayerGetJumpHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Id32<YVHVHYLYUBD> PlayerGetJumpInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Id32<YVHVHYLYUBD> PlayerGetProneSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Id32<YVHVHYLYUBD> PlayerGetSlideSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Id32<YVHVHYLYUBD> PlayerGetSprintInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Id32<YVHVHYLYUBD> PlayerGetSprintSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Id32<YVHVHYLYUBD> PlayerGetTeleportDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Id32<YVHVHYLYUBD> PlayerGetTeleportDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Id32<YVHVHYLYUBD> PlayerGetWalkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Id32<YVHVHYLYUBD> PlayerGetForceVRWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Id32<YVHVHYLYUBD> PlayerSetJumpInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Id32<YVHVHYLYUBD> PlayerSetProneSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public Id32<YVHVHYLYUBD> PlayerSetSlideSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public Id32<YVHVHYLYUBD> PlayerSetSprintInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Id32<YVHVHYLYUBD> PlayerSetSprintSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public Id32<YVHVHYLYUBD> PlayerSetSteeringInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Id32<YVHVHYLYUBD> PlayerSetTeleportDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Id32<YVHVHYLYUBD> PlayerSetTeleportDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Id32<YVHVHYLYUBD> PlayerSetVoiceRolloffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Id32<YVHVHYLYUBD> PlayerSetWalkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Id32<YVHVHYLYUBD> GetTimeZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Id32<YVHVHYLYUBD> ProjectileLauncherSetFiringPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public Id32<YVHVHYLYUBD> LocalPlayerSetPlayerNametagVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Id32<YVHVHYLYUBD> AimAssistPlayerAddAimAssistTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Id32<YVHVHYLYUBD> PlayerCanReceivePromptTextDialog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Id32<YVHVHYLYUBD> AimAssistPlayerGetAimAssistTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Id32<YVHVHYLYUBD> PlayerGetEquipmentSlotIsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Id32<YVHVHYLYUBD> AimAssistPlayerRemoveAimAssistTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Id32<YVHVHYLYUBD> PlayerRemoveRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Id32<YVHVHYLYUBD> PlayerResetNameColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Id32<YVHVHYLYUBD> PlayerClearVoiceRolloffDistanceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Id32<YVHVHYLYUBD> PlayerOverrideVoiceRolloffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Id32<YVHVHYLYUBD> PlayerIsHoldingMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Id32<YVHVHYLYUBD> PlayerIsInParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public Id32<YVHVHYLYUBD> PlayerGetIsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4DC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public Id32<YVHVHYLYUBD> PlayerGetRoomIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Id32<YVHVHYLYUBD> PlayerGetIsFlying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Id32<YVHVHYLYUBD> PlayerGetIsWallClimbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Id32<YVHVHYLYUBD> PlayerGetIsWallRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4EC")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Id32<YVHVHYLYUBD> PlayerGetSteeringDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Id32<YVHVHYLYUBD> PlayerGetSteeringSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Id32<YVHVHYLYUBD> PlayerGetSeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Id32<YVHVHYLYUBD> PlayerGetSteeringInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Id32<YVHVHYLYUBD> PlayerGetVoiceRolloffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Id32<YVHVHYLYUBD> PlayerSetCanFly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x504")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Id32<YVHVHYLYUBD> PlayerSetIsTeleportEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x508")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Id32<YVHVHYLYUBD> PlayerSetCanWallClimb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Id32<YVHVHYLYUBD> PlayerSetCanWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Id32<YVHVHYLYUBD> PlayerSetCrouchInputEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x514")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Id32<YVHVHYLYUBD> PlayerSetForceManualSprint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x518")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Id32<YVHVHYLYUBD> PlayerSetForceVirtualHeightMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public Id32<YVHVHYLYUBD> PlayerSetCrouchSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x520")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public Id32<YVHVHYLYUBD> PlayerSetJumpHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x524")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Id32<YVHVHYLYUBD> PlayerSetEquipmentSlotEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x528")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Id32<YVHVHYLYUBD> SetPlayerNameColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52C")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Id32<YVHVHYLYUBD> PlayerSetForceVRWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x530")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Id32<YVHVHYLYUBD> ProjectileLauncherGetFiringPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x534")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Id32<YVHVHYLYUBD> GetFirstPlayerWithRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x538")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Id32<YVHVHYLYUBD> ImpulseReflectPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x53C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Id32<YVHVHYLYUBD> ImpulseReflectObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x540")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Id32<YVHVHYLYUBD> RequestImpulseSetPlayerOverTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x544")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Id32<YVHVHYLYUBD> RequestImpulseSetObjectOverTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x548")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Id32<YVHVHYLYUBD> ImpulseAddPlayerAndSimulateLocally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Id32<YVHVHYLYUBD> ImpulseAddPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x550")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public Id32<YVHVHYLYUBD> ImpulseAddObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x554")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public Id32<YVHVHYLYUBD> HolotarProjectorGetCurrentTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x558")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public Id32<YVHVHYLYUBD> HolotarProjectorGetVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55C")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Id32<YVHVHYLYUBD> HolotarProjectorPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x560")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Id32<YVHVHYLYUBD> HolotarProjectorPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x564")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public Id32<YVHVHYLYUBD> HolotarProjectorResume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x568")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Id32<YVHVHYLYUBD> HolotarProjectorSetCurrentTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Id32<YVHVHYLYUBD> HolotarProjectorStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x570")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Id32<YVHVHYLYUBD> GrabberGetAttachObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x574")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Id32<YVHVHYLYUBD> GrabberSetPlayerCanStealFromGrabber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x578")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Id32<YVHVHYLYUBD> GrabberDetachObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x57C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Id32<YVHVHYLYUBD> GrabberAttachObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x580")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public Id32<YVHVHYLYUBD> InstanceGetMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x584")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Id32<YVHVHYLYUBD> InstanceGetLifetime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x588")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Id32<YVHVHYLYUBD> IsMultiInstanceEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Id32<YVHVHYLYUBD> IsPrivateInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x590")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Id32<YVHVHYLYUBD> IsEventInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x594")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public Id32<YVHVHYLYUBD> InteractionVolumeGetHoldTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x598")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Id32<YVHVHYLYUBD> InteractionVolumeGetInteractionPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Id32<YVHVHYLYUBD> InteractionVolumeGetIsLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Id32<YVHVHYLYUBD> InteractionVolumeGetNormalizedHoldProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A4")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Id32<YVHVHYLYUBD> InteractionVolumeSetHoldTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Id32<YVHVHYLYUBD> InteractionVolumeSetInteractionPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5AC")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Id32<YVHVHYLYUBD> InteractionVolumeSetLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5B0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Id32<YVHVHYLYUBD> InteractionVolumeSetNormalizedHoldProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5B4")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Id32<YVHVHYLYUBD> InvisibleCollisionGetBlocksPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5B8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Id32<YVHVHYLYUBD> InvisibleCollisionGetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5BC")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Id32<YVHVHYLYUBD> InvisibleCollisionSetBlocksPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Id32<YVHVHYLYUBD> ReplicatorGetActiveObjectCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C4")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Id32<YVHVHYLYUBD> ReplicatorGetActiveObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Id32<YVHVHYLYUBD> ReplicatorReturnObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5CC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Id32<YVHVHYLYUBD> RoomGetMatchmaking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetFilterRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D4")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Id32<YVHVHYLYUBD> TriggerVolumeSetFilterRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetFilterTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5DC")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Id32<YVHVHYLYUBD> TriggerVolumeSetFilterTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetNumObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E4")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetNumPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5EC")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5F0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Id32<YVHVHYLYUBD> TriggerVolumeGetPlayerFilterTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5F4")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Id32<YVHVHYLYUBD> TriggerVolumeSetPlayerFilterTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5F8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Id32<YVHVHYLYUBD> LaserPointerGetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5FC")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Id32<YVHVHYLYUBD> LaserPointerGetIsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x600")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Id32<YVHVHYLYUBD> LaserPointerGetLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x604")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Id32<YVHVHYLYUBD> LaserPointerSetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x608")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public Id32<YVHVHYLYUBD> LaserPointerSetIsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60C")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public Id32<YVHVHYLYUBD> LaserPointerSetLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x610")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x614")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x618")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetProjectileColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61C")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetProjectileColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x620")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetProjectileGravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x624")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetProjectileGravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x628")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetProjectileSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetProjectileSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x630")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetProjectileLifetime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x634")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetProjectileLifetime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x638")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetSoundEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetSoundEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x640")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetHeadDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x644")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetHeadDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x648")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetLimbDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetLimbDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x650")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetTorsoDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x654")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetTorsoDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x658")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Id32<YVHVHYLYUBD> RangedWeaponGetRecRoomObjectDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public Id32<YVHVHYLYUBD> RangedWeaponSetRecRoomObjectDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x660")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetIsReloading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x664")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetRecoilIntensityMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x668")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetRecoilIntensityMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetProjectileSpreadMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x670")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetProjectileSpreadMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x674")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetProjectileImpactForceMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x678")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetProjectileImpactForceMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x67C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetRateOfFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x680")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetRateOfFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x684")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetIsOnCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x688")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetTotalAmmunition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropGetDefaultTotalAmmunition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x690")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetMaxMagazineAmmunition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x694")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetInfiniteAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x698")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetCanReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropResetCurrentAmmunition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetBulletsInMagazine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A4")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Id32<YVHVHYLYUBD> RangedWeaponPropSetTotalAmmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Id32<YVHVHYLYUBD> UseInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6AC")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Id32<YVHVHYLYUBD> GetInventoryItemFromName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6B0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Id32<YVHVHYLYUBD> GetInventoryItemImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6B4")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Id32<YVHVHYLYUBD> GroundVehicleGetBoostFuel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6B8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Id32<YVHVHYLYUBD> GroundVehicleGetDrivingEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6BC")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Id32<YVHVHYLYUBD> GroundVehicleGetEngineTorqueMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Id32<YVHVHYLYUBD> GroundVehicleGetWheelFrictionMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C4")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Id32<YVHVHYLYUBD> GroundVehicleGetSeatedPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Id32<YVHVHYLYUBD> GroundVehicleAddBoostFuel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6CC")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Id32<YVHVHYLYUBD> GroundVehicleSetDrivingEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Id32<YVHVHYLYUBD> GroundVehicleSetEngineTorqueMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Id32<YVHVHYLYUBD> GroundVehicleSetWheelFrictionMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Id32<YVHVHYLYUBD> GroundVehicleSetSeatedPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6DC")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Id32<YVHVHYLYUBD> SpawnerResetSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Id32<YVHVHYLYUBD> SpawnerStartSpawning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E4")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Id32<YVHVHYLYUBD> QuaternionDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Id32<YVHVHYLYUBD> QuaternionEulerAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6EC")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Id32<YVHVHYLYUBD> QuaternionGetAngleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6F0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public Id32<YVHVHYLYUBD> QuaternionNormalize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6F4")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Id32<YVHVHYLYUBD> QuaternionRotateTowards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6F8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public Id32<YVHVHYLYUBD> QuaternionRotateVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6FC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public Id32<YVHVHYLYUBD> QuaternionSplit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x700")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Id32<YVHVHYLYUBD> SfxIsPlaying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x704")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Id32<YVHVHYLYUBD> SfxGetVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x708")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Id32<YVHVHYLYUBD> SfxSetVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70C")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Id32<YVHVHYLYUBD> SfxStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x710")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Id32<YVHVHYLYUBD> SfxPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x714")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerGetIsPlaying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x718")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerGetVideoUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71C")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerGetCurrentFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x720")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerSetCurrentFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x724")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerPauseVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x728")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerPlayVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72C")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Id32<YVHVHYLYUBD> RemoteVideoPlayerStopVideo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x730")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Id32<YVHVHYLYUBD> VectorGadgetGetVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x734")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Id32<YVHVHYLYUBD> TextScreenClearScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x738")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Id32<YVHVHYLYUBD> TextScreenPrintTextToScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x73C")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Id32<YVHVHYLYUBD> TextScreenScrollText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x740")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public Id32<YVHVHYLYUBD> StringReplace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x744")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public Id32<YVHVHYLYUBD> StringSplit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x748")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public Id32<YVHVHYLYUBD> StringSplitAtIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public Id32<YVHVHYLYUBD> StringSplitWhitespace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x750")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Id32<YVHVHYLYUBD> StringSubstringIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x754")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Id32<YVHVHYLYUBD> StringToUpper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x758")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public Id32<YVHVHYLYUBD> StringTrim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x75C")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public Id32<YVHVHYLYUBD> DialogueUIGetDialogueText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x760")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public Id32<YVHVHYLYUBD> DialogueUIGetMessageVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x764")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Id32<YVHVHYLYUBD> DialogueUIGetTitleIsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x768")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public Id32<YVHVHYLYUBD> DialogueUIGetTitleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x76C")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public Id32<YVHVHYLYUBD> DialogueUISetButtonState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x770")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Id32<YVHVHYLYUBD> DialogueUISetDialogueTexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x774")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public Id32<YVHVHYLYUBD> DialogueUISetMessageVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x778")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public Id32<YVHVHYLYUBD> DialogueUISetTitleIsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x77C")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Id32<YVHVHYLYUBD> DialogueUISetTitleTexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x780")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Id32<YVHVHYLYUBD> SpawnPointV2GetActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x784")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public Id32<YVHVHYLYUBD> SpawnPointV2AddAvoidRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x788")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Id32<YVHVHYLYUBD> SpawnPointV2AddAvoidTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78C")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Id32<YVHVHYLYUBD> SpawnPointV2AddSpawnRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x790")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Id32<YVHVHYLYUBD> SpawnPointV2AddSpawnTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x794")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RemoveAvoidRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x798")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RemoveAvoidTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79C")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RemoveSpawnRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RemoveSpawnTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A4")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RespawnPlayerAtPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Id32<YVHVHYLYUBD> SpawnPointV2RespawnPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7AC")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Id32<YVHVHYLYUBD> SpawnPointV2SetActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7B0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public Id32<YVHVHYLYUBD> AddTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7B4")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Id32<YVHVHYLYUBD> AddTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7B8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Id32<YVHVHYLYUBD> CreationObjectGetAllWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7BC")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Id32<YVHVHYLYUBD> CreationObjectGetFirstWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Id32<YVHVHYLYUBD> GetFirstTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C4")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Id32<YVHVHYLYUBD> GetTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Id32<YVHVHYLYUBD> HasTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7CC")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public Id32<YVHVHYLYUBD> RemoveTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Id32<YVHVHYLYUBD> RemoveTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D4")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Id32<YVHVHYLYUBD> PlayerGetFirstWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public Id32<YVHVHYLYUBD> PlayerGetAllWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7DC")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public Id32<YVHVHYLYUBD> ListRemoveAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Id32<YVHVHYLYUBD> ListAdd4Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E4")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public Id32<YVHVHYLYUBD> ListAdd12Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public Id32<YVHVHYLYUBD> ListAdd16Byte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7EC")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public Id32<YVHVHYLYUBD> ListAddManaged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7F0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public Id32<YVHVHYLYUBD> ListAllTrue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7F4")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public Id32<YVHVHYLYUBD> ListAnyTrue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7F8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public Id32<YVHVHYLYUBD> ListClear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7FC")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public Id32<YVHVHYLYUBD> ListRemoveLast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x800")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Id32<YVHVHYLYUBD> ListShuffle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x804")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Id32<YVHVHYLYUBD> PlayerGetVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x808")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Id32<YVHVHYLYUBD> PlayerGetProfileImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80C")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public Id32<YVHVHYLYUBD> AudioFXZoneSetIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x810")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public Id32<YVHVHYLYUBD> AudioFXZoneGetIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x814")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public Id32<YVHVHYLYUBD> AudioFXZoneSetPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x818")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public Id32<YVHVHYLYUBD> AudioFXZoneGetPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81C")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public Id32<YVHVHYLYUBD> AudioFXZoneSetEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x820")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public Id32<YVHVHYLYUBD> LocalPlayerSetGravityDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x824")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public Id32<YVHVHYLYUBD> PlayerGetPhysicsVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x828")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public Id32<YVHVHYLYUBD> PlayerSetPhysicsVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82C")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public Id32<YVHVHYLYUBD> PlayerSetSteeringVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x830")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public Id32<YVHVHYLYUBD> GoToPlayerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x834")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public Id32<YVHVHYLYUBD> LocalPlayerIsUsingController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x838")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public Id32<YVHVHYLYUBD> LocalPlayerIsUsingTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83C")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public Id32<YVHVHYLYUBD> LocalPlayerIsUsingKeyboardAndMouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x840")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public Id32<YVHVHYLYUBD> LightSetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x844")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public Id32<YVHVHYLYUBD> LocalPlayerSetLocomotionVFXEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x848")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public Id32<YVHVHYLYUBD> CreationObjectGetAllChildrenWithTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84C")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public Id32<YVHVHYLYUBD> IfRecRoomObjectIsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x850")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public Id32<YVHVHYLYUBD> LocalPlayerSetAnimationParamBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x854")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Id32<YVHVHYLYUBD> PlayerGetIsBalancing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x858")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public Id32<YVHVHYLYUBD> RequestBalanceAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public Id32<YVHVHYLYUBD> PlayerGetIsStanding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x860")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public Id32<YVHVHYLYUBD> RequestStopAvatarLocomotionAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x864")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Id32<YVHVHYLYUBD> GetRoomOfferByName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x868")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Id32<YVHVHYLYUBD> RoundToDecimalPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x86C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Id32<YVHVHYLYUBD> TruncateToDecimalPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x870")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public Id32<YVHVHYLYUBD> AABBContainsPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x874")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public Id32<YVHVHYLYUBD> VerticalCylinderContainsPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x878")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Id32<YVHVHYLYUBD> Vector3Mask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x87C")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Id32<YVHVHYLYUBD> LocalPlayerRequestFOVMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x880")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public Id32<YVHVHYLYUBD> ClosestPointOnLineSegment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x884")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public Id32<YVHVHYLYUBD> ClosestPointOnLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x888")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public Id32<YVHVHYLYUBD> AudioPlayerGetCurrentVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88C")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Id32<YVHVHYLYUBD> PlayerRightHandIsClosed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x890")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandIsClosed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x894")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public Id32<YVHVHYLYUBD> PlayerGetIsAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x898")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Id32<YVHVHYLYUBD> RecRoomObjectSetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89C")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public Id32<YVHVHYLYUBD> PlayerRightHandIsPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Id32<YVHVHYLYUBD> PlayerLeftHandIsPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A4")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public Id32<YVHVHYLYUBD> ConstantAvatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public Id32<YVHVHYLYUBD> ShowAvatarItemDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8AC")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Id32<YVHVHYLYUBD> LocalPlayerGetIsRespawning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Id32<YVHVHYLYUBD> AllowDressUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B4")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Id32<YVHVHYLYUBD> ForbidDressUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public Id32<YVHVHYLYUBD> OpenStore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8BC")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public Id32<YVHVHYLYUBD> OpenCheckout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public Id32<YVHVHYLYUBD> GetShoppingBagQuantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C4")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public Id32<YVHVHYLYUBD> GetTrialItemQuantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C8")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public Id32<YVHVHYLYUBD> GameAIGetIsAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8CC")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2GetFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2GetSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D4")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2GetTimeStamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D8")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2IsPlaying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8DC")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2Pause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2Play;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E4")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2SetFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2SetSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8EC")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2SetTimeStamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8F0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Id32<YVHVHYLYUBD> AnimationGizmoV2Stop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8F4")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Id32<YVHVHYLYUBD> LightGetAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8F8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public Id32<YVHVHYLYUBD> LightGetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8FC")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public Id32<YVHVHYLYUBD> LightGetEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x900")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public Id32<YVHVHYLYUBD> LightGetIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x904")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public Id32<YVHVHYLYUBD> LightGetRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x908")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Id32<YVHVHYLYUBD> LightGetSoftness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90C")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public Id32<YVHVHYLYUBD> LightGetSpecular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x910")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Id32<YVHVHYLYUBD> LightSetAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x914")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public Id32<YVHVHYLYUBD> LightSetColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x918")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public Id32<YVHVHYLYUBD> LightSetIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91C")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Id32<YVHVHYLYUBD> LightSetRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x920")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public Id32<YVHVHYLYUBD> LightSetSoftness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x924")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public Id32<YVHVHYLYUBD> LightSetSpecular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x928")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Id32<YVHVHYLYUBD> LightTurnOff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92C")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Id32<YVHVHYLYUBD> LightTurnOn;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B14110", Offset = "0x2B12F10", VA = "0x182B14110")]
		public static ExternalFnRegistry New()
		{
			return default(ExternalFnRegistry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B17BA0", Offset = "0x2B169A0", VA = "0x182B17BA0")]
		[CompilerGenerated]
		internal static Id32<YVHVHYLYUBD> TGCWQTKDHTD(int a)
		{
			return default(Id32<YVHVHYLYUBD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct RuntimeFnRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Id32<NLLDXUHMLOS> DataDeadEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Id32<NLLDXUHMLOS> ExecDeadEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Id32<NLLDXUHMLOS> ManagedRegisterCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public Id32<NLLDXUHMLOS> OffsetManagedObjectStackPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public Id32<NLLDXUHMLOS> DefaultValueForPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public Id32<NLLDXUHMLOS> DefaultValueForString;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B17C20", Offset = "0x2B16A20", VA = "0x182B17C20")]
		public static RuntimeFnRegistry New()
		{
			return default(RuntimeFnRegistry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B17BE0", Offset = "0x2B169E0", VA = "0x182B17BE0")]
		[CompilerGenerated]
		internal static Id32<NLLDXUHMLOS> GPJTMMIVXBS(int a)
		{
			return default(Id32<NLLDXUHMLOS>);
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
