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
	[IGCOOAFMKMN(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, NACFKHNICAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3543F00", Offset = "0x3542F00", VA = "0x183543F00", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[IGCOOAFMKMN(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[NHDDJFFBGMA(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NHDDJFFBGMA(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x57A2F90", Offset = "0x57A1F90", VA = "0x1857A2F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x175A2D0", Offset = "0x17592D0", VA = "0x18175A2D0")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[IGCOOAFMKMN(1)]
	public struct AuthoredParentData : IComponentData, NACFKHNICAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[NHDDJFFBGMA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57A2FB0", Offset = "0x57A1FB0", VA = "0x1857A2FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NEOAGFCCEKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HIEPCEPLNDC : ISystemStateComponentData, IComponentData, NACFKHNICAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity HMLOAKDPGOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity BAAICHICCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[IGCOOAFMKMN(1)]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, NACFKHNICAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3543F00", Offset = "0x3542F00", VA = "0x183543F00", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[GDFDLEHEDBH(0, 15)]
public enum EMJDDNECGHC
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
[GDFDLEHEDBH(0, 2)]
public enum OEENACCBKMN
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
	[IGCOOAFMKMN(1)]
	[DKMNPOBAPGG("Container", 0)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[NHDDJFFBGMA(1)]
		[FBLBNJPNCKG(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[FBLBNJPNCKG(0)]
		[NHDDJFFBGMA(2)]
		public OEENACCBKMN collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[NHDDJFFBGMA(3)]
		[FBLBNJPNCKG(0)]
		public EMJDDNECGHC collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[FBLBNJPNCKG(0)]
		[NHDDJFFBGMA(4)]
		public HFFEJOMCEIC grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[NHDDJFFBGMA(5)]
		public KFOBEONHFDG flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[NHDDJFFBGMA(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57A3660", Offset = "0x57A2660", VA = "0x1857A3660", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[GDFDLEHEDBH(0, 16071)]
public enum KFOBEONHFDG
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
[GDFDLEHEDBH(0, 1)]
public enum HFFEJOMCEIC
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
[IOEOLNBCFMO(1)]
public struct AJEDPPHLNAN : IComparable<AJEDPPHLNAN>, IEquatable<AJEDPPHLNAN>, BJGHIGICLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[BGJEPEGIOIG(1)]
	public uint LKNKGBEKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[BGJEPEGIOIG(2)]
	public uint FACDDGLHEJG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint DHHCBOPGGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57A2C80", Offset = "0x57A1C80", VA = "0x1857A2C80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57A2EC0", Offset = "0x57A1EC0", VA = "0x1857A2EC0")]
	public AJEDPPHLNAN(int LKNKGBEKPNO, int HBIABMBIFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57A2EC0", Offset = "0x57A1EC0", VA = "0x1857A2EC0")]
	public AJEDPPHLNAN(uint LKNKGBEKPNO, uint HBIABMBIFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57A2C90", Offset = "0x57A1C90", VA = "0x1857A2C90")]
	private static uint FGLGFOFJOED(uint KKHMNCLOHHK, uint GMPKOOIGMDG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57A2BB0", Offset = "0x57A1BB0", VA = "0x1857A2BB0", Slot = "4")]
	public int CompareTo(AJEDPPHLNAN IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57A2BD0", Offset = "0x57A1BD0", VA = "0x1857A2BD0", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57A2E00", Offset = "0x57A1E00", VA = "0x1857A2E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57A2C60", Offset = "0x57A1C60", VA = "0x1857A2C60", Slot = "5")]
	public bool Equals(AJEDPPHLNAN IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57A2CC0", Offset = "0x57A1CC0", VA = "0x1857A2CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57A2D80", Offset = "0x57A1D80", VA = "0x1857A2D80", Slot = "6")]
	public void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57A2D10", Offset = "0x57A1D10", VA = "0x1857A2D10", Slot = "7")]
	public void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57A2B90", Offset = "0x57A1B90", VA = "0x1857A2B90")]
	public static bool ABFAIBNGIFN(AJEDPPHLNAN MHLPMABHBAH, AJEDPPHLNAN HAJOPPLMLNE)
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
		[Cpp2IlInjected.Address(RVA = "0xB54810", Offset = "0xB53810", VA = "0x180B54810")]
		public static SerializableGuid BNLFJABIBKP(Guid BEAFCMKDKCM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57A5CC0", Offset = "0x57A4CC0", VA = "0x1857A5CC0", Slot = "4")]
		public bool Equals(SerializableGuid IJDAJAEAAKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57A5CA0", Offset = "0x57A4CA0", VA = "0x1857A5CA0", Slot = "5")]
		public int CompareTo(SerializableGuid IJDAJAEAAKC)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[IGCOOAFMKMN(1)]
	[LMIMNKDKABA("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[IGCOOAFMKMN(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[NHDDJFFBGMA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[NHDDJFFBGMA(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GDFDLEHEDBH(0, 4)]
public enum DGJNFBKJHDF
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
	[IGCOOAFMKMN(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[NHDDJFFBGMA(1)]
		public DGJNFBKJHDF gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[IGCOOAFMKMN(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[NHDDJFFBGMA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[NHDDJFFBGMA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[NHDDJFFBGMA(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[IGCOOAFMKMN(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[NHDDJFFBGMA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[NHDDJFFBGMA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[NHDDJFFBGMA(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[NHDDJFFBGMA(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NHDDJFFBGMA(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[IGCOOAFMKMN(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[NHDDJFFBGMA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[NHDDJFFBGMA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[NHDDJFFBGMA(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NACFKHNICAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity HFANCMABCJB
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
	[DKMNPOBAPGG("Light", 0)]
	[IGCOOAFMKMN(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[NHDDJFFBGMA(1)]
		[FBLBNJPNCKG(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[FBLBNJPNCKG(0)]
		[NHDDJFFBGMA(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[NHDDJFFBGMA(3)]
		[FBLBNJPNCKG(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[IGCOOAFMKMN(1)]
	[DKMNPOBAPGG("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[NHDDJFFBGMA(1)]
		[FBLBNJPNCKG(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[IGCOOAFMKMN(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[IGCOOAFMKMN(1)]
	public struct ParentData : IComponentData, NACFKHNICAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[NHDDJFFBGMA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BIFLGOGGJAG : ISystemStateComponentData, IComponentData, NACFKHNICAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity HMLOAKDPGOM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity BAAICHICCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x937270", Offset = "0x936270", VA = "0x180937270", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FCDGKDPFLOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[GDFDLEHEDBH(0, 4)]
public enum JFDAEEMFBOB
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
	[IGCOOAFMKMN(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[NHDDJFFBGMA(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[NHDDJFFBGMA(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[NHDDJFFBGMA(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[NHDDJFFBGMA(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[NHDDJFFBGMA(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[NHDDJFFBGMA(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[NHDDJFFBGMA(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[NHDDJFFBGMA(8)]
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
public struct NCJBKACLIIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 JMDAEBODFGG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[IGCOOAFMKMN(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[NHDDJFFBGMA(1)]
		public PENKGBJBPJM flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[NHDDJFFBGMA(2)]
		public OGFGGNMJPLP scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class BGCLDIDFJIA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57A3010", Offset = "0x57A2010", VA = "0x1857A3010")]
	public static PENKGBJBPJM PPCBFHPPBHE(this PENKGBJBPJM AANEECAEOLG, AOIIFJONLBA NHHOFJNBKIB)
	{
		return default(PENKGBJBPJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x57A2FC0", Offset = "0x57A1FC0", VA = "0x1857A2FC0")]
	public static PENKGBJBPJM DKCILJPFPEA(this PENKGBJBPJM AANEECAEOLG, AOIIFJONLBA NHHOFJNBKIB)
	{
		return default(PENKGBJBPJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57A2FD0", Offset = "0x57A1FD0", VA = "0x1857A2FD0")]
	public static PENKGBJBPJM ILJPNBFKLFK(this PENKGBJBPJM AANEECAEOLG, AOIIFJONLBA NHHOFJNBKIB, bool CCKFKEMKBMC)
	{
		return default(PENKGBJBPJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57A2FF0", Offset = "0x57A1FF0", VA = "0x1857A2FF0")]
	public static bool KNPMELGFNKO(this PENKGBJBPJM AANEECAEOLG, AOIIFJONLBA NHHOFJNBKIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum AOIIFJONLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
[GDFDLEHEDBH(0, 16383)]
public enum PENKGBJBPJM
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IOEOLNBCFMO(1)]
public struct OGFGGNMJPLP : BJGHIGICLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[BGJEPEGIOIG(1)]
	public bool EOODJCKPPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[BGJEPEGIOIG(2)]
	public float3 HJLNDNBMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[BGJEPEGIOIG(3)]
	public float3 LKMOEJJAINL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57A4F80", Offset = "0x57A3F80", VA = "0x1857A4F80", Slot = "5")]
	public void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57A5080", Offset = "0x57A4080", VA = "0x1857A5080", Slot = "4")]
	public void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[IOEOLNBCFMO(1)]
public struct MMDFPOBNGDD : BJGHIGICLOC, IEquatable<MMDFPOBNGDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[BGJEPEGIOIG(1)]
	public int LGBAJKGIPMA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0")]
	public MMDFPOBNGDD(int LGBAJKGIPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57A4B80", Offset = "0x57A3B80", VA = "0x1857A4B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x57A4B00", Offset = "0x57A3B00", VA = "0x1857A4B00", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xD88730", Offset = "0xD87730", VA = "0x180D88730", Slot = "6")]
	public bool Equals(MMDFPOBNGDD IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21313E0", Offset = "0x21303E0", VA = "0x1821313E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57A4BE0", Offset = "0x57A3BE0", VA = "0x1857A4BE0", Slot = "5")]
	public void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57A4C10", Offset = "0x57A3C10", VA = "0x1857A4C10", Slot = "4")]
	public void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IGCOOAFMKMN(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[NHDDJFFBGMA(1)]
		public MMDFPOBNGDD customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[GDFDLEHEDBH(0, 1)]
public enum OCJDDNMHJGM
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[IGCOOAFMKMN(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[NHDDJFFBGMA(1)]
		public OCJDDNMHJGM propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DKMNPOBAPGG("Physics", 0)]
	[IGCOOAFMKMN(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[FBLBNJPNCKG(0)]
		[NHDDJFFBGMA(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[IGCOOAFMKMN(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[NHDDJFFBGMA(1)]
		public HHBAPNOMDDB shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GDFDLEHEDBH(-1, 18)]
public enum HHBAPNOMDDB
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	LegacyWedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	LegacyPyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	COUNT = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	MAX = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MIN = -1
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GDFDLEHEDBH(0, 2)]
public enum JHICMKBJNCB
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[IGCOOAFMKMN(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[NHDDJFFBGMA(1)]
		public JHICMKBJNCB shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[IGCOOAFMKMN(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[GDFDLEHEDBH(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[NHDDJFFBGMA(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x57A5D90", Offset = "0x57A4D90", VA = "0x1857A5D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x57A5E10", Offset = "0x57A4E10", VA = "0x1857A5E10")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[IOEOLNBCFMO(1)]
public struct OEGGBHIEKPE : BJGHIGICLOC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[GDFDLEHEDBH(0, 7)]
	public enum DJGONFGFFHD
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[BGJEPEGIOIG(1)]
	public float CPAJFCDCEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BGJEPEGIOIG(2)]
	public int GICGAIGBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[BGJEPEGIOIG(3)]
	public DJGONFGFFHD AANEECAEOLG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CKLAKBHFHML
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x57A4E00", Offset = "0x57A3E00", VA = "0x1857A4E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x57A4F60", Offset = "0x57A3F60", VA = "0x1857A4F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DFMNACHPENA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x57A4CE0", Offset = "0x57A3CE0", VA = "0x1857A4CE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x57A4DE0", Offset = "0x57A3DE0", VA = "0x1857A4DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GMEPEJFHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x57A4E80", Offset = "0x57A3E80", VA = "0x1857A4E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x57A4D60", Offset = "0x57A3D60", VA = "0x1857A4D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57A4D80", Offset = "0x57A3D80", VA = "0x1857A4D80", Slot = "5")]
	public void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57A4F00", Offset = "0x57A3F00", VA = "0x1857A4F00", Slot = "4")]
	public void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[IGCOOAFMKMN(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[NHDDJFFBGMA(1)]
		public OEGGBHIEKPE parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[IGCOOAFMKMN(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[NHDDJFFBGMA(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[NHDDJFFBGMA(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[NHDDJFFBGMA(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[NHDDJFFBGMA(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[NHDDJFFBGMA(5)]
		public AJEDPPHLNAN order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OKHJCMKPFGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct COODJGNCPEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct DHPBIDOIKPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GKGCMEGHNOJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[IGCOOAFMKMN(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[NHDDJFFBGMA(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[NHDDJFFBGMA(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[NHDDJFFBGMA(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[IGCOOAFMKMN(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[NHDDJFFBGMA(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[NHDDJFFBGMA(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[NHDDJFFBGMA(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[NHDDJFFBGMA(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[NHDDJFFBGMA(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[NHDDJFFBGMA(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[NHDDJFFBGMA(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[NHDDJFFBGMA(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[NHDDJFFBGMA(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[NHDDJFFBGMA(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[NHDDJFFBGMA(11)]
		public NEPOFLPPDGM mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[NHDDJFFBGMA(12)]
		public DNAMJPAFOJJ myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[NHDDJFFBGMA(13)]
		public OEHLMCDLBCA myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[NHDDJFFBGMA(14)]
		public LJIGEOBADLJ myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[NHDDJFFBGMA(15)]
		public ICOLAEPDNIN myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[NHDDJFFBGMA(16)]
		public DJDAHPCBNMA myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[NHDDJFFBGMA(17)]
		public AHEIBEBCMIH myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[NHDDJFFBGMA(18)]
		public KCMAIBFACHH myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[NHDDJFFBGMA(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[NHDDJFFBGMA(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[NHDDJFFBGMA(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[NHDDJFFBGMA(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum NEPOFLPPDGM : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum DNAMJPAFOJJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum OEHLMCDLBCA : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum LJIGEOBADLJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum ICOLAEPDNIN
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum DJDAHPCBNMA : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum AHEIBEBCMIH : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum KCMAIBFACHH : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[IGCOOAFMKMN(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[IGCOOAFMKMN(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[IGCOOAFMKMN(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int nonSerialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public GameObject gameObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CNCHFKLPNDB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct BPIPKGAMNMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Vector3 GHPFFFIEINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<SerializableGuid> LMNGJINPNPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class COCPIJIKPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public BPIPKGAMNMA LBPMPOCLLKF;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public COCPIJIKPEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public SerializableGuid HIOHOJIDGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public List<int> LINOACHBDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public List<BPIPKGAMNMA> KOMEEEPIKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<COCPIJIKPEF> DBBFJEDAAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public GameObject PKGBHIMGLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Light NGDHBJMIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Collider PIGJAIJJEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public string PHINCAHPAHK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public CNCHFKLPNDB()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[IGCOOAFMKMN(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[NHDDJFFBGMA(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[IGCOOAFMKMN(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[NHDDJFFBGMA(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NHDDJFFBGMA(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static LocalPoseData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[IGCOOAFMKMN(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[IGCOOAFMKMN(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x57A47D0", Offset = "0x57A37D0", VA = "0x1857A47D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[IGCOOAFMKMN(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[NHDDJFFBGMA(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EIFMLBKMBLE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HNIJFOJGCHK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IIHEDPBOLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x57A3850", Offset = "0x57A2850", VA = "0x1857A3850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x57A3840", Offset = "0x57A2840", VA = "0x1857A3840")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[IGCOOAFMKMN(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[NHDDJFFBGMA(1)]
		public KMJKMLNGBKB transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[NHDDJFFBGMA(2)]
		public AAGBFKFDEMJ transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Flags]
[GDFDLEHEDBH(0, 1)]
public enum KMJKMLNGBKB
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[GDFDLEHEDBH(-2, 2)]
public enum AAGBFKFDEMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[IGCOOAFMKMN(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[IGCOOAFMKMN(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x57A5F20", Offset = "0x57A4F20", VA = "0x1857A5F20")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[IGCOOAFMKMN(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[GDFDLEHEDBH(1000, 7003)]
public enum DAGBJECOPFG
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	GameObject_Gizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	COUNT = 7004,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MAX = 7003
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal enum BJHABFBGGJE
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	GameObject = 7000
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal static class OBDNBGAHMIE
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[IGCOOAFMKMN(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[NHDDJFFBGMA(1)]
		public DAGBJECOPFG prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FKDOIBKCNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57A3AC0", Offset = "0x57A2AC0", VA = "0x1857A3AC0")]
	public static bool GHFCOPHLPJG(this DAGBJECOPFG GLKKDGLKBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x57A3A20", Offset = "0x57A2A20", VA = "0x1857A3A20")]
	public static string BODILGPFAPK(this DAGBJECOPFG GLKKDGLKBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x57A3AA0", Offset = "0x57A2AA0", VA = "0x1857A3AA0")]
	public static DPLBJNFOOGD DNMIJANHDJP(this DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(DPLBJNFOOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x57A3AE0", Offset = "0x57A2AE0", VA = "0x1857A3AE0")]
	internal static BJHABFBGGJE NPMLKCNKKPM(this DPLBJNFOOGD AELHBENMHGM)
	{
		return default(BJHABFBGGJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x57A3AF0", Offset = "0x57A2AF0", VA = "0x1857A3AF0")]
	internal static BJHABFBGGJE NPMLKCNKKPM(this DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(BJHABFBGGJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[GDFDLEHEDBH(0, 7)]
public enum DPLBJNFOOGD
{
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	COUNT = 8,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MAX = 7
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[IGCOOAFMKMN(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[NHDDJFFBGMA(1)]
		public DPLBJNFOOGD objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BNHJHFIGCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57A30E0", Offset = "0x57A20E0", VA = "0x1857A30E0")]
	public static bool MMPNBDJCHMJ(this DPLBJNFOOGD AELHBENMHGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[GDFDLEHEDBH(-1, 60)]
public enum HEBOHMDPFIL
{
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	MAX = 60,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[GDFDLEHEDBH(-1, 31)]
public enum EPEJNEFJGFK
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[DKMNPOBAPGG("Visual", 0)]
	[IGCOOAFMKMN(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[NHDDJFFBGMA(1)]
		[FBLBNJPNCKG(0)]
		public HEBOHMDPFIL color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[FBLBNJPNCKG(0)]
		[NHDDJFFBGMA(2)]
		public EPEJNEFJGFK material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[NHDDJFFBGMA(3)]
		[FBLBNJPNCKG(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[NHDDJFFBGMA(4)]
		[FBLBNJPNCKG(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	internal class _RRAssemblyIndex : AICCCLPHIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57A6200", Offset = "0x57A5200", VA = "0x1857A6200", Slot = "4")]
		public sealed override void CIJCLICMJID()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MEDCBIJHGHD : ContainerPropertyBag<TestNonSerializedManagedData>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private class IHKEFHIOEIO : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x57A3FA0", Offset = "0x57A2FA0", VA = "0x1857A3FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57A3F60", Offset = "0x57A2F60", VA = "0x1857A3F60")]
		public IHKEFHIOEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x44D64C0", Offset = "0x44D54C0", VA = "0x1844D64C0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57A3F40", Offset = "0x57A2F40", VA = "0x1857A3F40", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class CPPNKCBHOJM : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x57A3630", Offset = "0x57A2630", VA = "0x1857A3630", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x57A35F0", Offset = "0x57A25F0", VA = "0x1857A35F0")]
		public CPPNKCBHOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x57A35B0", Offset = "0x57A25B0", VA = "0x1857A35B0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57A35D0", Offset = "0x57A25D0", VA = "0x1857A35D0", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private class MDGPBGALFNM : Property<TestNonSerializedManagedData, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x57A4990", Offset = "0x57A3990", VA = "0x1857A4990", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x57A4950", Offset = "0x57A3950", VA = "0x1857A4950")]
		public MDGPBGALFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x44D6310", Offset = "0x44D5310", VA = "0x1844D6310", Slot = "11")]
		public override GameObject GetValue(ref TestNonSerializedManagedData KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57A4920", Offset = "0x57A3920", VA = "0x1857A4920", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData KIKNDHMFIHG, GameObject JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57A49C0", Offset = "0x57A39C0", VA = "0x1857A49C0")]
	public MEDCBIJHGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class CKDPJHKGJGE : ContainerPropertyBag<CNCHFKLPNDB>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private class CJBGLDCKCCF : Property<CNCHFKLPNDB, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x57A32A0", Offset = "0x57A22A0", VA = "0x1857A32A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x57A3260", Offset = "0x57A2260", VA = "0x1857A3260")]
		public CJBGLDCKCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57A3210", Offset = "0x57A2210", VA = "0x1857A3210", Slot = "11")]
		public override SerializableGuid GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57A3240", Offset = "0x57A2240", VA = "0x1857A3240", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, SerializableGuid JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class MPNNOBHAGEN : Property<CNCHFKLPNDB, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x57A4CB0", Offset = "0x57A3CB0", VA = "0x1857A4CB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57A4C70", Offset = "0x57A3C70", VA = "0x1857A4C70")]
		public MPNNOBHAGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2FC69C0", Offset = "0x2FC59C0", VA = "0x182FC69C0", Slot = "11")]
		public override List<int> GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57A4C40", Offset = "0x57A3C40", VA = "0x1857A4C40", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, List<int> JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class IDNCHIEDJNP : Property<CNCHFKLPNDB, List<CNCHFKLPNDB.BPIPKGAMNMA>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x57A3EA0", Offset = "0x57A2EA0", VA = "0x1857A3EA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x57A3E60", Offset = "0x57A2E60", VA = "0x1857A3E60")]
		public IDNCHIEDJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x57A3E10", Offset = "0x57A2E10", VA = "0x1857A3E10", Slot = "11")]
		public override List<CNCHFKLPNDB.BPIPKGAMNMA> GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x57A3E30", Offset = "0x57A2E30", VA = "0x1857A3E30", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, List<CNCHFKLPNDB.BPIPKGAMNMA> JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class HLOEPAHEBPF : Property<CNCHFKLPNDB, List<CNCHFKLPNDB.COCPIJIKPEF>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x57A3D00", Offset = "0x57A2D00", VA = "0x1857A3D00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x57A3CC0", Offset = "0x57A2CC0", VA = "0x1857A3CC0")]
		public HLOEPAHEBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x57A3C70", Offset = "0x57A2C70", VA = "0x1857A3C70", Slot = "11")]
		public override List<CNCHFKLPNDB.COCPIJIKPEF> GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57A3C90", Offset = "0x57A2C90", VA = "0x1857A3C90", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, List<CNCHFKLPNDB.COCPIJIKPEF> JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class BLAIDBOLECO : Property<CNCHFKLPNDB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x57A30B0", Offset = "0x57A20B0", VA = "0x1857A30B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x57A3070", Offset = "0x57A2070", VA = "0x1857A3070")]
		public BLAIDBOLECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x57A3020", Offset = "0x57A2020", VA = "0x1857A3020", Slot = "11")]
		public override GameObject GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x57A3040", Offset = "0x57A2040", VA = "0x1857A3040", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, GameObject JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class IHNOFPFJOPA : Property<CNCHFKLPNDB, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x57A4060", Offset = "0x57A3060", VA = "0x1857A4060", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x57A4020", Offset = "0x57A3020", VA = "0x1857A4020")]
		public IHNOFPFJOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x57A3FD0", Offset = "0x57A2FD0", VA = "0x1857A3FD0", Slot = "11")]
		public override Light GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x57A3FF0", Offset = "0x57A2FF0", VA = "0x1857A3FF0", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, Light JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class LAHLAGCMFEI : Property<CNCHFKLPNDB, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x57A43B0", Offset = "0x57A33B0", VA = "0x1857A43B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x57A4370", Offset = "0x57A3370", VA = "0x1857A4370")]
		public LAHLAGCMFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57A4320", Offset = "0x57A3320", VA = "0x1857A4320", Slot = "11")]
		public override Collider GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57A4340", Offset = "0x57A3340", VA = "0x1857A4340", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, Collider JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class LNKPPBBOAPF : Property<CNCHFKLPNDB, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x57A45C0", Offset = "0x57A35C0", VA = "0x1857A45C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57A4580", Offset = "0x57A3580", VA = "0x1857A4580")]
		public LNKPPBBOAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x57A4530", Offset = "0x57A3530", VA = "0x1857A4530", Slot = "11")]
		public override string GetValue(ref CNCHFKLPNDB KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57A4550", Offset = "0x57A3550", VA = "0x1857A4550", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB KIKNDHMFIHG, string JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57A32D0", Offset = "0x57A22D0", VA = "0x1857A32D0")]
	public CKDPJHKGJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal class HGJKFLAHGIA : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class LEOOKNDIPPB : Property<SerializableGuid, SerializableGuid.Data>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x57A4420", Offset = "0x57A3420", VA = "0x1857A4420", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57A43E0", Offset = "0x57A33E0", VA = "0x1857A43E0")]
		public LEOOKNDIPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x22C6470", Offset = "0x22C5470", VA = "0x1822C6470", Slot = "11")]
		public override SerializableGuid.Data GetValue(ref SerializableGuid KIKNDHMFIHG)
		{
			return default(SerializableGuid.Data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3543DA0", Offset = "0x3542DA0", VA = "0x183543DA0", Slot = "12")]
		public override void SetValue(ref SerializableGuid KIKNDHMFIHG, SerializableGuid.Data JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x57A3BC0", Offset = "0x57A2BC0", VA = "0x1857A3BC0")]
	public HGJKFLAHGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class PKANIOLIABM : ContainerPropertyBag<SerializableGuid.Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class IGKAFMGDKHI : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x57A3F10", Offset = "0x57A2F10", VA = "0x1857A3F10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x57A3ED0", Offset = "0x57A2ED0", VA = "0x1857A3ED0")]
		public IGKAFMGDKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10556B0", Offset = "0x10546B0", VA = "0x1810556B0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3541A10", Offset = "0x3540A10", VA = "0x183541A10", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class LILEKHIPEME : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x57A4490", Offset = "0x57A3490", VA = "0x1857A4490", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x57A4450", Offset = "0x57A3450", VA = "0x1857A4450")]
		public LILEKHIPEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x354E770", Offset = "0x354D770", VA = "0x18354E770", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x354E780", Offset = "0x354D780", VA = "0x18354E780", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class AHEBDPBMPEP : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x57A2B60", Offset = "0x57A1B60", VA = "0x1857A2B60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x57A2B20", Offset = "0x57A1B20", VA = "0x1857A2B20")]
		public AHEBDPBMPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2FD2AD0", Offset = "0x2FD1AD0", VA = "0x182FD2AD0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x35517F0", Offset = "0x35507F0", VA = "0x1835517F0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private class LNHDKIJNEHB : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x57A4500", Offset = "0x57A3500", VA = "0x1857A4500", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x57A44C0", Offset = "0x57A34C0", VA = "0x1857A44C0")]
		public LNHDKIJNEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3551680", Offset = "0x3550680", VA = "0x183551680", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data KIKNDHMFIHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3551690", Offset = "0x3550690", VA = "0x183551690", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data KIKNDHMFIHG, int JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x57A52A0", Offset = "0x57A42A0", VA = "0x1857A52A0")]
	public PKANIOLIABM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class JJJAKGKEKNL : ContainerPropertyBag<CNCHFKLPNDB.BPIPKGAMNMA>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private class CFLCDPIFEJI : Property<CNCHFKLPNDB.BPIPKGAMNMA, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x57A31E0", Offset = "0x57A21E0", VA = "0x1857A31E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x57A31A0", Offset = "0x57A21A0", VA = "0x1857A31A0")]
		public CFLCDPIFEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xF259A0", Offset = "0xF249A0", VA = "0x180F259A0", Slot = "11")]
		public override Vector3 GetValue(ref CNCHFKLPNDB.BPIPKGAMNMA KIKNDHMFIHG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x57A3180", Offset = "0x57A2180", VA = "0x1857A3180", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB.BPIPKGAMNMA KIKNDHMFIHG, Vector3 JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JPLIGPMCDNM : Property<CNCHFKLPNDB.BPIPKGAMNMA, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x57A42F0", Offset = "0x57A32F0", VA = "0x1857A42F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x57A42B0", Offset = "0x57A32B0", VA = "0x1857A42B0")]
		public JPLIGPMCDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1C41F50", Offset = "0x1C40F50", VA = "0x181C41F50", Slot = "11")]
		public override List<SerializableGuid> GetValue(ref CNCHFKLPNDB.BPIPKGAMNMA KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x57A42A0", Offset = "0x57A32A0", VA = "0x1857A42A0", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB.BPIPKGAMNMA KIKNDHMFIHG, List<SerializableGuid> JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x57A4190", Offset = "0x57A3190", VA = "0x1857A4190")]
	public JJJAKGKEKNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal class PNGGOKILOJB : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class DIBCFIAEGID : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x57A3810", Offset = "0x57A2810", VA = "0x1857A3810", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57A37D0", Offset = "0x57A27D0", VA = "0x1857A37D0")]
		public DIBCFIAEGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57A37B0", Offset = "0x57A27B0", VA = "0x1857A37B0", Slot = "11")]
		public override float GetValue(ref Vector3 KIKNDHMFIHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x57A37C0", Offset = "0x57A27C0", VA = "0x1857A37C0", Slot = "12")]
		public override void SetValue(ref Vector3 KIKNDHMFIHG, float JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private class CALDHNPLJHP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x57A3150", Offset = "0x57A2150", VA = "0x1857A3150", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x57A3110", Offset = "0x57A2110", VA = "0x1857A3110")]
		public CALDHNPLJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x57A30F0", Offset = "0x57A20F0", VA = "0x1857A30F0", Slot = "11")]
		public override float GetValue(ref Vector3 KIKNDHMFIHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57A3100", Offset = "0x57A2100", VA = "0x1857A3100", Slot = "12")]
		public override void SetValue(ref Vector3 KIKNDHMFIHG, float JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class DFELFINEHBA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x57A3780", Offset = "0x57A2780", VA = "0x1857A3780", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x57A3740", Offset = "0x57A2740", VA = "0x1857A3740")]
		public DFELFINEHBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x16F8C60", Offset = "0x16F7C60", VA = "0x1816F8C60", Slot = "11")]
		public override float GetValue(ref Vector3 KIKNDHMFIHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57A3730", Offset = "0x57A2730", VA = "0x1857A3730", Slot = "12")]
		public override void SetValue(ref Vector3 KIKNDHMFIHG, float JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x57A5430", Offset = "0x57A4430", VA = "0x1857A5430")]
	public PNGGOKILOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class HAEHEPDENBC : ContainerPropertyBag<CNCHFKLPNDB.COCPIJIKPEF>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class HPELJDDKFHH : Property<CNCHFKLPNDB.COCPIJIKPEF, CNCHFKLPNDB.BPIPKGAMNMA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x57A3DE0", Offset = "0x57A2DE0", VA = "0x1857A3DE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x57A3DA0", Offset = "0x57A2DA0", VA = "0x1857A3DA0")]
		public HPELJDDKFHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x57A3D30", Offset = "0x57A2D30", VA = "0x1857A3D30", Slot = "11")]
		public override CNCHFKLPNDB.BPIPKGAMNMA GetValue(ref CNCHFKLPNDB.COCPIJIKPEF KIKNDHMFIHG)
		{
			return default(CNCHFKLPNDB.BPIPKGAMNMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x57A3D60", Offset = "0x57A2D60", VA = "0x1857A3D60", Slot = "12")]
		public override void SetValue(ref CNCHFKLPNDB.COCPIJIKPEF KIKNDHMFIHG, CNCHFKLPNDB.BPIPKGAMNMA JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57A3B10", Offset = "0x57A2B10", VA = "0x1857A3B10")]
	public HAEHEPDENBC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x57A55B0", Offset = "0x57A45B0", VA = "0x1857A55B0")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
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
