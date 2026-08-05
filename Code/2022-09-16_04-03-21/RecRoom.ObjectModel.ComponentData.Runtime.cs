using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[NGJJKELIHDK(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, HELLHLLCKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A570", Offset = "0x1E98D70", VA = "0x181E9A570", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NGJJKELIHDK(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[HFPNCJHDPNM(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[HFPNCJHDPNM(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x40D9C40", Offset = "0x40D8440", VA = "0x1840D9C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1073E30", Offset = "0x1072630", VA = "0x181073E30")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NGJJKELIHDK(1)]
	public struct AuthoredParentData : IComponentData, HELLHLLCKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[HFPNCJHDPNM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x40D9C60", Offset = "0x40D8460", VA = "0x1840D9C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EMNEDPOLCKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IIGFJFAPCCG : ISystemStateComponentData, IComponentData, HELLHLLCKLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity AHGOEKJGAFN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity PAFCAGICALM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[InternalBufferCapacity(8)]
	[NGJJKELIHDK(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, HELLHLLCKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A570", Offset = "0x1E98D70", VA = "0x181E9A570", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[OFCIKHBEPDP(0, 15)]
public enum NCDNMBDJLAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	All = 0xF,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OFCIKHBEPDP(0, 2)]
public enum AGMLDGLMLHE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[JAGBCLPLLCC("Container", 0)]
	[NGJJKELIHDK(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[HFPNCJHDPNM(1)]
		[IGMJKBMJFLH(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HFPNCJHDPNM(2)]
		[IGMJKBMJFLH(0)]
		public AGMLDGLMLHE collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(3)]
		public NCDNMBDJLAJ collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[HFPNCJHDPNM(4)]
		[IGMJKBMJFLH(0)]
		public ALMAPMMMCGD grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(5)]
		public GCCNGCMPMGI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[HFPNCJHDPNM(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x40D9E30", Offset = "0x40D8630", VA = "0x1840D9E30", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[OFCIKHBEPDP(0, 16071)]
public enum GCCNGCMPMGI
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	IsGrabbable = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	All = 0x3EC7,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	MAX = 0x3EC7
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[OFCIKHBEPDP(0, 1)]
public enum ALMAPMMMCGD
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[HPCGPGBANIE(1)]
public struct GOEJEDIGFOE : IComparable<GOEJEDIGFOE>, IEquatable<GOEJEDIGFOE>, JJELBHOACBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[BGACEOKBBOC(1)]
	public uint KNGEOIGFPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[BGACEOKBBOC(2)]
	public uint JJJMNEPPLNG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint HNDCDDIBOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x40DA410", Offset = "0x40D8C10", VA = "0x1840DA410")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40DA510", Offset = "0x40D8D10", VA = "0x1840DA510")]
	public GOEJEDIGFOE(int KNGEOIGFPHK, int AALKIFEMOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x40DA510", Offset = "0x40D8D10", VA = "0x1840DA510")]
	public GOEJEDIGFOE(uint KNGEOIGFPHK, uint AALKIFEMOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40DA420", Offset = "0x40D8C20", VA = "0x1840DA420")]
	private static uint PNMLIDDOHGC(uint DKLHMFCLOAB, uint FLEBMPFFCAA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40DA260", Offset = "0x40D8A60", VA = "0x1840DA260", Slot = "4")]
	public int CompareTo(GOEJEDIGFOE ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40DA280", Offset = "0x40D8A80", VA = "0x1840DA280", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40DA450", Offset = "0x40D8C50", VA = "0x1840DA450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40DA310", Offset = "0x40D8B10", VA = "0x1840DA310", Slot = "5")]
	public bool Equals(GOEJEDIGFOE ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40DA330", Offset = "0x40D8B30", VA = "0x1840DA330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x40DA1E0", Offset = "0x40D89E0", VA = "0x1840DA1E0", Slot = "6")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40DA380", Offset = "0x40D8B80", VA = "0x1840DA380", Slot = "7")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40DA3F0", Offset = "0x40D8BF0", VA = "0x1840DA3F0")]
	public static bool LLPKNBIICCC(GOEJEDIGFOE EFFMHOCDHAK, GOEJEDIGFOE AOHBHKCKGOP)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct Data
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int a;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int c;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int d;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Data data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Guid guid;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		public static SerializableGuid HLHIMDAEEEO(Guid NKEBGFDENCD)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40DCD70", Offset = "0x40DB570", VA = "0x1840DCD70", Slot = "4")]
		public bool Equals(SerializableGuid ALBOAABJIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40DCD50", Offset = "0x40DB550", VA = "0x1840DCD50", Slot = "5")]
		public int CompareTo(SerializableGuid ALBOAABJIJF)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[LHGODNGPPEH("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	[NGJJKELIHDK(1)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[NGJJKELIHDK(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[HFPNCJHDPNM(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[HFPNCJHDPNM(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[OFCIKHBEPDP(0, 4)]
public enum HALBGGLKEOJ
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[NGJJKELIHDK(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[HFPNCJHDPNM(1)]
		public HALBGGLKEOJ gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[NGJJKELIHDK(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[HFPNCJHDPNM(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[HFPNCJHDPNM(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[HFPNCJHDPNM(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[NGJJKELIHDK(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[HFPNCJHDPNM(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[HFPNCJHDPNM(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[HFPNCJHDPNM(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[HFPNCJHDPNM(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[HFPNCJHDPNM(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[NGJJKELIHDK(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[HFPNCJHDPNM(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[HFPNCJHDPNM(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[HFPNCJHDPNM(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HELLHLLCKLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity LLFIHJDDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[JAGBCLPLLCC("Light", 0)]
	[NGJJKELIHDK(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[NGJJKELIHDK(1)]
	[JAGBCLPLLCC("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HFPNCJHDPNM(1)]
		[IGMJKBMJFLH(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[NGJJKELIHDK(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[NGJJKELIHDK(1)]
	public struct ParentData : IComponentData, HELLHLLCKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HFPNCJHDPNM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ECIBJLGBGHF : ISystemStateComponentData, IComponentData, HELLHLLCKLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity AHGOEKJGAFN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity PAFCAGICALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC67830", Offset = "0xC66030", VA = "0x180C67830", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DIAFPPIIIAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[OFCIKHBEPDP(0, 4)]
public enum CIBFLKIMGNA
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[NGJJKELIHDK(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[HFPNCJHDPNM(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[HFPNCJHDPNM(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[HFPNCJHDPNM(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[HFPNCJHDPNM(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[HFPNCJHDPNM(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[HFPNCJHDPNM(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[HFPNCJHDPNM(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[HFPNCJHDPNM(8)]
		public CollisionDetectionMode collisionDetectionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool isKinematic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector3 localVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Vector3 localAngularVelocity;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly InertialPropertiesData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DFOPADAJPFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 IONIHDHIJOB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly DFOPADAJPFE JBGJKCAJAOI;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[NGJJKELIHDK(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[HFPNCJHDPNM(1)]
		public BKFAAPNNILK flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[HFPNCJHDPNM(2)]
		public PDMDDFOMBEH scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EJPAPBMHJPK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40DA110", Offset = "0x40D8910", VA = "0x1840DA110")]
	public static BKFAAPNNILK NLKJJINIDJF(this BKFAAPNNILK AGFHKAICCAO, IALKPOKNGGM FNBJDMBIOKK)
	{
		return default(BKFAAPNNILK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40DA100", Offset = "0x40D8900", VA = "0x1840DA100")]
	public static BKFAAPNNILK NHIAFFMKOAF(this BKFAAPNNILK AGFHKAICCAO, IALKPOKNGGM FNBJDMBIOKK)
	{
		return default(BKFAAPNNILK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40DA0C0", Offset = "0x40D88C0", VA = "0x1840DA0C0")]
	public static BKFAAPNNILK AMELFHCHKJK(this BKFAAPNNILK AGFHKAICCAO, IALKPOKNGGM FNBJDMBIOKK, bool IMIPLIDOHFG)
	{
		return default(BKFAAPNNILK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40DA0E0", Offset = "0x40D88E0", VA = "0x1840DA0E0")]
	public static bool MAMOOKKNNMJ(this BKFAAPNNILK AGFHKAICCAO, IALKPOKNGGM FNBJDMBIOKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum IALKPOKNGGM
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
[OFCIKHBEPDP(0, 16383)]
public enum BKFAAPNNILK
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[HPCGPGBANIE(1)]
public struct PDMDDFOMBEH : JJELBHOACBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[BGACEOKBBOC(1)]
	public bool MAGFABKGNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[BGACEOKBBOC(2)]
	public float3 DEPMKEOEPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[BGACEOKBBOC(3)]
	public float3 OIBJMKLGLKD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40DC220", Offset = "0x40DAA20", VA = "0x1840DC220", Slot = "5")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x40DC100", Offset = "0x40DA900", VA = "0x1840DC100", Slot = "4")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HPCGPGBANIE(1)]
public struct MINFGCMJKBL : JJELBHOACBE, IEquatable<MINFGCMJKBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[BGACEOKBBOC(1)]
	public int OCNCOBFEOBE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70")]
	public MINFGCMJKBL(int OCNCOBFEOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40DB580", Offset = "0x40D9D80", VA = "0x1840DB580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40DB500", Offset = "0x40D9D00", VA = "0x1840DB500", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D3600", Offset = "0x6D1E00", VA = "0x1806D3600", Slot = "6")]
	public bool Equals(MINFGCMJKBL ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xC6C870", Offset = "0xC6B070", VA = "0x180C6C870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x40DB5E0", Offset = "0x40D9DE0", VA = "0x1840DB5E0", Slot = "5")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x40DB4D0", Offset = "0x40D9CD0", VA = "0x1840DB4D0", Slot = "4")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[NGJJKELIHDK(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HFPNCJHDPNM(1)]
		public MINFGCMJKBL customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[OFCIKHBEPDP(0, 1)]
public enum JBEILNODJLP
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[NGJJKELIHDK(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[HFPNCJHDPNM(1)]
		public JBEILNODJLP propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[JAGBCLPLLCC("Physics", 0)]
	[NGJJKELIHDK(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[HFPNCJHDPNM(1)]
		[IGMJKBMJFLH(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[NGJJKELIHDK(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[HFPNCJHDPNM(1)]
		public JPMNNMNBHIP shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[OFCIKHBEPDP(-1, 18)]
public enum JPMNNMNBHIP
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	LegacyWedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	LegacyPyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	COUNT = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MAX = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	MIN = -1
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OFCIKHBEPDP(0, 2)]
public enum HKLFFMNFEFK
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[NGJJKELIHDK(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[HFPNCJHDPNM(1)]
		public HKLFFMNFEFK shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[NGJJKELIHDK(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[OFCIKHBEPDP(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[HFPNCJHDPNM(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x40DCE40", Offset = "0x40DB640", VA = "0x1840DCE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x40DCEC0", Offset = "0x40DB6C0", VA = "0x1840DCEC0")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HPCGPGBANIE(1)]
public struct PCLBMPEEANA : JJELBHOACBE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[OFCIKHBEPDP(0, 7)]
	public enum LLPBDLDLBAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BGACEOKBBOC(1)]
	public float ELMFPJFBGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[BGACEOKBBOC(2)]
	public int HMBKGJIDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[BGACEOKBBOC(3)]
	public LLPBDLDLBAN AGFHKAICCAO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OCIMFHAGIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x40DBFA0", Offset = "0x40DA7A0", VA = "0x1840DBFA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40DC020", Offset = "0x40DA820", VA = "0x1840DC020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FCDKMCNCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40DBE20", Offset = "0x40DA620", VA = "0x1840DBE20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x40DBEA0", Offset = "0x40DA6A0", VA = "0x1840DBEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PNNFKLNJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40DBEC0", Offset = "0x40DA6C0", VA = "0x1840DBEC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x40DBDA0", Offset = "0x40DA5A0", VA = "0x1840DBDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40DBF40", Offset = "0x40DA740", VA = "0x1840DBF40", Slot = "5")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40DBDC0", Offset = "0x40DA5C0", VA = "0x1840DBDC0", Slot = "4")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[NGJJKELIHDK(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[HFPNCJHDPNM(1)]
		public PCLBMPEEANA parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[NGJJKELIHDK(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[HFPNCJHDPNM(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[HFPNCJHDPNM(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[HFPNCJHDPNM(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[HFPNCJHDPNM(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[HFPNCJHDPNM(5)]
		public GOEJEDIGFOE order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct JHFPNALOHNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct GMPLACMMIPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NEFPMJFFMME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EHPCHOOOHBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HIGOCDEDJCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KALPBAFHKJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal struct BHHCALEGPCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct IFJIGPJDLJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct LKCJADILDIN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[NGJJKELIHDK(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[HFPNCJHDPNM(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[HFPNCJHDPNM(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[HFPNCJHDPNM(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[NGJJKELIHDK(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[HFPNCJHDPNM(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[HFPNCJHDPNM(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[HFPNCJHDPNM(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[HFPNCJHDPNM(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[HFPNCJHDPNM(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[HFPNCJHDPNM(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[HFPNCJHDPNM(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[HFPNCJHDPNM(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[HFPNCJHDPNM(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[HFPNCJHDPNM(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[HFPNCJHDPNM(11)]
		public HFMIIEIJNGB mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[HFPNCJHDPNM(12)]
		public HEJKHBJOGGE myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[HFPNCJHDPNM(13)]
		public FILAAAIGHBN myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[HFPNCJHDPNM(14)]
		public IKHMLAGHINM myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[HFPNCJHDPNM(15)]
		public IMCAICKGIFB myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[HFPNCJHDPNM(16)]
		public PNOEHCBJNIL myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[HFPNCJHDPNM(17)]
		public NJECFEFGPAD myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[HFPNCJHDPNM(18)]
		public KCEEBLCPGOP myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[HFPNCJHDPNM(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[HFPNCJHDPNM(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[HFPNCJHDPNM(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[HFPNCJHDPNM(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum HFMIIEIJNGB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum HEJKHBJOGGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum FILAAAIGHBN : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum IKHMLAGHINM : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum IMCAICKGIFB
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum PNOEHCBJNIL : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum NJECFEFGPAD : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum KCEEBLCPGOP : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[NGJJKELIHDK(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[NGJJKELIHDK(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[NGJJKELIHDK(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int nonSerialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GameObject gameObject;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class HDLDECHDACE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct NHMBEJKIJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 BKBNLPCCIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public List<SerializableGuid> NLDDJGLPJFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class KFJKBNLMKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public NHMBEJKIJKA CHKBHMHPPJK;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KFJKBNLMKNF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public SerializableGuid NPFOFJPPBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public List<int> ECMGGDAFOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<NHMBEJKIJKA> AFODELLANCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public List<KFJKBNLMKNF> BOEPAMHAINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GameObject KFNNOPCEBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Light PMEFBBLEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Collider OKCFJNOIDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public string LJOGPHAFJOP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public HDLDECHDACE()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[NGJJKELIHDK(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[HFPNCJHDPNM(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[NGJJKELIHDK(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[HFPNCJHDPNM(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[HFPNCJHDPNM(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1073E30", Offset = "0x1072630", VA = "0x181073E30")]
		public LocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[NGJJKELIHDK(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[NGJJKELIHDK(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x40DB190", Offset = "0x40D9990", VA = "0x1840DB190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[NGJJKELIHDK(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[HFPNCJHDPNM(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct KEMLKLJPNBO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int BAPPOIGGHFI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AKLHCIJHJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40DAC60", Offset = "0x40D9460", VA = "0x1840DAC60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40DAC50", Offset = "0x40D9450", VA = "0x1840DAC50")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[NGJJKELIHDK(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[HFPNCJHDPNM(1)]
		public FJOEOLLJKCF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[HFPNCJHDPNM(2)]
		public DHHPLOFCFAP transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
[OFCIKHBEPDP(0, 1)]
public enum FJOEOLLJKCF
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OFCIKHBEPDP(-2, 2)]
public enum DHHPLOFCFAP
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[NGJJKELIHDK(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[NGJJKELIHDK(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x40DCFD0", Offset = "0x40DB7D0", VA = "0x1840DCFD0")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[NGJJKELIHDK(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OFCIKHBEPDP(1000, 7003)]
public enum HEIIJIHIAKK
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	COUNT = 7004,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MAX = 7003
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal enum DMECGHKCKNG
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	GameObject = 7000
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal static class AENGBCAELJB
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[NGJJKELIHDK(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[HFPNCJHDPNM(1)]
		public HEIIJIHIAKK prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JAJBEKGNIGK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40DAB70", Offset = "0x40D9370", VA = "0x1840DAB70")]
	public static bool PBENELLCBKP(this HEIIJIHIAKK BKDBLJPNPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40DAAD0", Offset = "0x40D92D0", VA = "0x1840DAAD0")]
	public static string JDCBCAOBAFK(this HEIIJIHIAKK BKDBLJPNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40DAB50", Offset = "0x40D9350", VA = "0x1840DAB50")]
	public static MNBPBHNFCPJ OOHEKPANOLH(this HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(MNBPBHNFCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40DAAC0", Offset = "0x40D92C0", VA = "0x1840DAAC0")]
	internal static DMECGHKCKNG AKMHHGGJKCB(this MNBPBHNFCPJ HLJGHMOIFMK)
	{
		return default(DMECGHKCKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40DAAA0", Offset = "0x40D92A0", VA = "0x1840DAAA0")]
	internal static DMECGHKCKNG AKMHHGGJKCB(this HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(DMECGHKCKNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[OFCIKHBEPDP(0, 7)]
public enum MNBPBHNFCPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	COUNT = 8,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	MAX = 7
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[NGJJKELIHDK(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[HFPNCJHDPNM(1)]
		public MNBPBHNFCPJ objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class BCFMCNBMLIN
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x40D9C70", Offset = "0x40D8470", VA = "0x1840D9C70")]
	public static bool MGCEPGJLBGA(this MNBPBHNFCPJ HLJGHMOIFMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[OFCIKHBEPDP(-1, 60)]
public enum GKJAAHKBHAN
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	MAX = 60,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[OFCIKHBEPDP(-1, 31)]
public enum FLDBANCHKMF
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[JAGBCLPLLCC("Visual", 0)]
	[NGJJKELIHDK(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[IGMJKBMJFLH(0)]
		[HFPNCJHDPNM(1)]
		public GKJAAHKBHAN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[HFPNCJHDPNM(2)]
		[IGMJKBMJFLH(0)]
		public FLDBANCHKMF material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[HFPNCJHDPNM(3)]
		[IGMJKBMJFLH(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[HFPNCJHDPNM(4)]
		[IGMJKBMJFLH(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	internal class _RRAssemblyIndex : KOGEJEDODIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40DD2B0", Offset = "0x40DBAB0", VA = "0x1840DD2B0", Slot = "4")]
		public sealed override void DJCOPMFLKGB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class HIHMJPHLAMO : ContainerPropertyBag<TestNonSerializedManagedData>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class PKKODDGLHHH : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x40DC560", Offset = "0x40DAD60", VA = "0x1840DC560", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x40DC520", Offset = "0x40DAD20", VA = "0x1840DC520")]
		public PKKODDGLHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x40DC4E0", Offset = "0x40DACE0", VA = "0x1840DC4E0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x40DC500", Offset = "0x40DAD00", VA = "0x1840DC500", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class ILNPNOLLOON : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x40DA970", Offset = "0x40D9170", VA = "0x1840DA970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x40DA930", Offset = "0x40D9130", VA = "0x1840DA930")]
		public ILNPNOLLOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x40DA8F0", Offset = "0x40D90F0", VA = "0x1840DA8F0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x40DA910", Offset = "0x40D9110", VA = "0x1840DA910", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class PCPIELAGLID : Property<TestNonSerializedManagedData, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x40DC0D0", Offset = "0x40DA8D0", VA = "0x1840DC0D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x40DC090", Offset = "0x40DA890", VA = "0x1840DC090")]
		public PCPIELAGLID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x40DC040", Offset = "0x40DA840", VA = "0x1840DC040", Slot = "11")]
		public override GameObject GetValue(ref TestNonSerializedManagedData IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x40DC060", Offset = "0x40DA860", VA = "0x1840DC060", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData IGEIPKGINDO, GameObject CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40DA560", Offset = "0x40D8D60", VA = "0x1840DA560")]
	public HIHMJPHLAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class MPINJEPGFKM : ContainerPropertyBag<HDLDECHDACE>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MAJGJAEJMHH : Property<HDLDECHDACE, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x40DB370", Offset = "0x40D9B70", VA = "0x1840DB370", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x40DB330", Offset = "0x40D9B30", VA = "0x1840DB330")]
		public MAJGJAEJMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x40DB2E0", Offset = "0x40D9AE0", VA = "0x1840DB2E0", Slot = "11")]
		public override SerializableGuid GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x40DB310", Offset = "0x40D9B10", VA = "0x1840DB310", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, SerializableGuid CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class ICBBEJJMFLE : Property<HDLDECHDACE, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x40DA730", Offset = "0x40D8F30", VA = "0x1840DA730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x40DA6F0", Offset = "0x40D8EF0", VA = "0x1840DA6F0")]
		public ICBBEJJMFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40DA6A0", Offset = "0x40D8EA0", VA = "0x1840DA6A0", Slot = "11")]
		public override List<int> GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x40DA6C0", Offset = "0x40D8EC0", VA = "0x1840DA6C0", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, List<int> CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class GKDCMGGGHLA : Property<HDLDECHDACE, List<HDLDECHDACE.NHMBEJKIJKA>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x40DA1B0", Offset = "0x40D89B0", VA = "0x1840DA1B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x40DA170", Offset = "0x40D8970", VA = "0x1840DA170")]
		public GKDCMGGGHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x40DA120", Offset = "0x40D8920", VA = "0x1840DA120", Slot = "11")]
		public override List<HDLDECHDACE.NHMBEJKIJKA> GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x40DA140", Offset = "0x40D8940", VA = "0x1840DA140", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, List<HDLDECHDACE.NHMBEJKIJKA> CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class AHFJGHADEAH : Property<HDLDECHDACE, List<HDLDECHDACE.KFJKBNLMKNF>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x40D9B90", Offset = "0x40D8390", VA = "0x1840D9B90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40D9B50", Offset = "0x40D8350", VA = "0x1840D9B50")]
		public AHFJGHADEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x40D9B00", Offset = "0x40D8300", VA = "0x1840D9B00", Slot = "11")]
		public override List<HDLDECHDACE.KFJKBNLMKNF> GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x40D9B20", Offset = "0x40D8320", VA = "0x1840D9B20", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, List<HDLDECHDACE.KFJKBNLMKNF> CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class MIFMMGGMMOK : Property<HDLDECHDACE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x40DB4A0", Offset = "0x40D9CA0", VA = "0x1840DB4A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x40DB460", Offset = "0x40D9C60", VA = "0x1840DB460")]
		public MIFMMGGMMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x40DB410", Offset = "0x40D9C10", VA = "0x1840DB410", Slot = "11")]
		public override GameObject GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40DB430", Offset = "0x40D9C30", VA = "0x1840DB430", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, GameObject CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class OPGDGHOEMNK : Property<HDLDECHDACE, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x40DBCC0", Offset = "0x40DA4C0", VA = "0x1840DBCC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x40DBC80", Offset = "0x40DA480", VA = "0x1840DBC80")]
		public OPGDGHOEMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x40DBC30", Offset = "0x40DA430", VA = "0x1840DBC30", Slot = "11")]
		public override Light GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x40DBC50", Offset = "0x40DA450", VA = "0x1840DBC50", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, Light CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class DEMNFKFGLIF : Property<HDLDECHDACE, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x40D9F90", Offset = "0x40D8790", VA = "0x1840D9F90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x40D9F50", Offset = "0x40D8750", VA = "0x1840D9F50")]
		public DEMNFKFGLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x40D9F00", Offset = "0x40D8700", VA = "0x1840D9F00", Slot = "11")]
		public override Collider GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x40D9F20", Offset = "0x40D8720", VA = "0x1840D9F20", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, Collider CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class JJLJNPDDLHE : Property<HDLDECHDACE, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x40DAC20", Offset = "0x40D9420", VA = "0x1840DAC20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40DABE0", Offset = "0x40D93E0", VA = "0x1840DABE0")]
		public JJLJNPDDLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x40DAB90", Offset = "0x40D9390", VA = "0x1840DAB90", Slot = "11")]
		public override string GetValue(ref HDLDECHDACE IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x40DABB0", Offset = "0x40D93B0", VA = "0x1840DABB0", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE IGEIPKGINDO, string CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40DB610", Offset = "0x40D9E10", VA = "0x1840DB610")]
	public MPINJEPGFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class LEEHABCOOOB : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private class BMHDMKNEDJM : Property<SerializableGuid, SerializableGuid.Data>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x40D9CC0", Offset = "0x40D84C0", VA = "0x1840D9CC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x40D9C80", Offset = "0x40D8480", VA = "0x1840D9C80")]
		public BMHDMKNEDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD21250", Offset = "0xD1FA50", VA = "0x180D21250", Slot = "11")]
		public override SerializableGuid.Data GetValue(ref SerializableGuid IGEIPKGINDO)
		{
			return default(SerializableGuid.Data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A410", Offset = "0x1E98C10", VA = "0x181E9A410", Slot = "12")]
		public override void SetValue(ref SerializableGuid IGEIPKGINDO, SerializableGuid.Data CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x40DAD00", Offset = "0x40D9500", VA = "0x1840DAD00")]
	public LEEHABCOOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class IEKIBINAFOA : ContainerPropertyBag<SerializableGuid.Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private class MCPHNKBMJJO : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x40DB3E0", Offset = "0x40D9BE0", VA = "0x1840DB3E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x40DB3A0", Offset = "0x40D9BA0", VA = "0x1840DB3A0")]
		public MCPHNKBMJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6349B0", Offset = "0x6331B0", VA = "0x1806349B0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E98080", Offset = "0x1E96880", VA = "0x181E98080", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class LICGGHJMPME : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x40DAE60", Offset = "0x40D9660", VA = "0x1840DAE60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x40DAE20", Offset = "0x40D9620", VA = "0x1840DAE20")]
		public LICGGHJMPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4D80", Offset = "0x1EA3580", VA = "0x181EA4D80", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4D90", Offset = "0x1EA3590", VA = "0x181EA4D90", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class LGLBNBEPFNB : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x40DADF0", Offset = "0x40D95F0", VA = "0x1840DADF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x40DADB0", Offset = "0x40D95B0", VA = "0x1840DADB0")]
		public LGLBNBEPFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7E70", Offset = "0x1EA6670", VA = "0x181EA7E70", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7E80", Offset = "0x1EA6680", VA = "0x181EA7E80", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class OECNLBIBBOA : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x40DBBB0", Offset = "0x40DA3B0", VA = "0x1840DBBB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x40DBB70", Offset = "0x40DA370", VA = "0x1840DBB70")]
		public OECNLBIBBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7D00", Offset = "0x1EA6500", VA = "0x181EA7D00", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data IGEIPKGINDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7D10", Offset = "0x1EA6510", VA = "0x181EA7D10", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data IGEIPKGINDO, int CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x40DA760", Offset = "0x40D8F60", VA = "0x1840DA760")]
	public IEKIBINAFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal class NPIDIKNDKLJ : ContainerPropertyBag<HDLDECHDACE.NHMBEJKIJKA>
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class KKJIALMLHJB : Property<HDLDECHDACE.NHMBEJKIJKA, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x40DACD0", Offset = "0x40D94D0", VA = "0x1840DACD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x40DAC90", Offset = "0x40D9490", VA = "0x1840DAC90")]
		public KKJIALMLHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x25BA310", Offset = "0x25B8B10", VA = "0x1825BA310", Slot = "11")]
		public override Vector3 GetValue(ref HDLDECHDACE.NHMBEJKIJKA IGEIPKGINDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x40DAC70", Offset = "0x40D9470", VA = "0x1840DAC70", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE.NHMBEJKIJKA IGEIPKGINDO, Vector3 CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class LNLOJPEDCNO : Property<HDLDECHDACE.NHMBEJKIJKA, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x40DAF80", Offset = "0x40D9780", VA = "0x1840DAF80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x40DAF40", Offset = "0x40D9740", VA = "0x1840DAF40")]
		public LNLOJPEDCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x40DAF20", Offset = "0x40D9720", VA = "0x1840DAF20", Slot = "11")]
		public override List<SerializableGuid> GetValue(ref HDLDECHDACE.NHMBEJKIJKA IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x40DAF30", Offset = "0x40D9730", VA = "0x1840DAF30", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE.NHMBEJKIJKA IGEIPKGINDO, List<SerializableGuid> CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x40DBA60", Offset = "0x40DA260", VA = "0x1840DBA60")]
	public NPIDIKNDKLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class CAMIIJOKLEO : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class PNKDDMBIFCN : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x40DC5F0", Offset = "0x40DADF0", VA = "0x1840DC5F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x40DC5B0", Offset = "0x40DADB0", VA = "0x1840DC5B0")]
		public PNKDDMBIFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x40DC590", Offset = "0x40DAD90", VA = "0x1840DC590", Slot = "11")]
		public override float GetValue(ref Vector3 IGEIPKGINDO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x40DC5A0", Offset = "0x40DADA0", VA = "0x1840DC5A0", Slot = "12")]
		public override void SetValue(ref Vector3 IGEIPKGINDO, float CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class LJEBKLLFEKG : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x40DAEF0", Offset = "0x40D96F0", VA = "0x1840DAEF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x40DAEB0", Offset = "0x40D96B0", VA = "0x1840DAEB0")]
		public LJEBKLLFEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x40DAE90", Offset = "0x40D9690", VA = "0x1840DAE90", Slot = "11")]
		public override float GetValue(ref Vector3 IGEIPKGINDO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x40DAEA0", Offset = "0x40D96A0", VA = "0x1840DAEA0", Slot = "12")]
		public override void SetValue(ref Vector3 IGEIPKGINDO, float CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private class NMJEEECAILN : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x40DBA30", Offset = "0x40DA230", VA = "0x1840DBA30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x40DB9F0", Offset = "0x40DA1F0", VA = "0x1840DB9F0")]
		public NMJEEECAILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x40DB9D0", Offset = "0x40DA1D0", VA = "0x1840DB9D0", Slot = "11")]
		public override float GetValue(ref Vector3 IGEIPKGINDO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40DB9E0", Offset = "0x40DA1E0", VA = "0x1840DB9E0", Slot = "12")]
		public override void SetValue(ref Vector3 IGEIPKGINDO, float CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x40D9CF0", Offset = "0x40D84F0", VA = "0x1840D9CF0")]
	public CAMIIJOKLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class DHFPGBNCCOH : ContainerPropertyBag<HDLDECHDACE.KFJKBNLMKNF>
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class NDBMKHLHIII : Property<HDLDECHDACE.KFJKBNLMKNF, HDLDECHDACE.NHMBEJKIJKA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x40DB9A0", Offset = "0x40DA1A0", VA = "0x1840DB9A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x40DB960", Offset = "0x40DA160", VA = "0x1840DB960")]
		public NDBMKHLHIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x40DB8F0", Offset = "0x40DA0F0", VA = "0x1840DB8F0", Slot = "11")]
		public override HDLDECHDACE.NHMBEJKIJKA GetValue(ref HDLDECHDACE.KFJKBNLMKNF IGEIPKGINDO)
		{
			return default(HDLDECHDACE.NHMBEJKIJKA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40DB920", Offset = "0x40DA120", VA = "0x1840DB920", Slot = "12")]
		public override void SetValue(ref HDLDECHDACE.KFJKBNLMKNF IGEIPKGINDO, HDLDECHDACE.NHMBEJKIJKA CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x40DA010", Offset = "0x40D8810", VA = "0x1840DA010")]
	public DHFPGBNCCOH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40DC660", Offset = "0x40DAE60", VA = "0x1840DC660")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
