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
	[JFCKEAJHBKC(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JCDLAHGBHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3543DF0", Offset = "0x35429F0", VA = "0x183543DF0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[JFCKEAJHBKC(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[AHDFMABLMIO(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[AHDFMABLMIO(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x57968E0", Offset = "0x57954E0", VA = "0x1857968E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x15BD550", Offset = "0x15BC150", VA = "0x1815BD550")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[JFCKEAJHBKC(1)]
	public struct AuthoredParentData : IComponentData, JCDLAHGBHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[AHDFMABLMIO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5796900", Offset = "0x5795500", VA = "0x185796900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MEMELGJDJJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OJJDCGFPFHF : ISystemStateComponentData, IComponentData, JCDLAHGBHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity GAEKDCPLMPC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity KOIDKPOELDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[JFCKEAJHBKC(1)]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JCDLAHGBHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3543DF0", Offset = "0x35429F0", VA = "0x183543DF0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[NEFJGCLJDFJ(0, 15)]
public enum OEIMEBBKKGA
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
[NEFJGCLJDFJ(0, 2)]
public enum OKGPOMGFIDF
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
	[JFCKEAJHBKC(1)]
	[FLGCFDICFAJ("Container", 0)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[AHDFMABLMIO(1)]
		[HBJALOLJMNC(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HBJALOLJMNC(0)]
		[AHDFMABLMIO(2)]
		public OKGPOMGFIDF collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[AHDFMABLMIO(3)]
		[HBJALOLJMNC(0)]
		public OEIMEBBKKGA collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[HBJALOLJMNC(0)]
		[AHDFMABLMIO(4)]
		public HDMJPLDMOMA grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[AHDFMABLMIO(5)]
		public KDPPMPGAEMF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[AHDFMABLMIO(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5796F10", Offset = "0x5795B10", VA = "0x185796F10", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[NEFJGCLJDFJ(0, 16071)]
public enum KDPPMPGAEMF
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
[NEFJGCLJDFJ(0, 1)]
public enum HDMJPLDMOMA
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
[LFCABNEOOLF(1)]
public struct GFPPCPFHMFP : IComparable<GFPPCPFHMFP>, IEquatable<GFPPCPFHMFP>, FAACHECLGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[DCIAAGPJBDJ(1)]
	public uint PDNMFNPIPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[DCIAAGPJBDJ(2)]
	public uint DOIHKLFDHJM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint GDDGPACGHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5797830", Offset = "0x5796430", VA = "0x185797830")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57979A0", Offset = "0x57965A0", VA = "0x1857979A0")]
	public GFPPCPFHMFP(int PDNMFNPIPFL, int EEBGDFAICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57979A0", Offset = "0x57965A0", VA = "0x1857979A0")]
	public GFPPCPFHMFP(uint PDNMFNPIPFL, uint EEBGDFAICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5797840", Offset = "0x5796440", VA = "0x185797840")]
	private static uint KLLBHMOPIJJ(uint GBHOMBFJPAG, uint DBJNEGCCKCM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5797670", Offset = "0x5796270", VA = "0x185797670", Slot = "4")]
	public int CompareTo(GFPPCPFHMFP LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5797730", Offset = "0x5796330", VA = "0x185797730", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57978E0", Offset = "0x57964E0", VA = "0x1857978E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5797710", Offset = "0x5796310", VA = "0x185797710", Slot = "5")]
	public bool Equals(GFPPCPFHMFP LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57977E0", Offset = "0x57963E0", VA = "0x1857977E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5797690", Offset = "0x5796290", VA = "0x185797690", Slot = "6")]
	public void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5797870", Offset = "0x5796470", VA = "0x185797870", Slot = "7")]
	public void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57977C0", Offset = "0x57963C0", VA = "0x1857977C0")]
	public static bool GPLOOKALJBH(GFPPCPFHMFP KMDHLKAFBJL, GFPPCPFHMFP OIJGCCLFBGG)
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
		[Cpp2IlInjected.Address(RVA = "0xB53810", Offset = "0xB52410", VA = "0x180B53810")]
		public static SerializableGuid EDHAFEIJFCP(Guid EDJALHGEENI)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57998C0", Offset = "0x57984C0", VA = "0x1857998C0", Slot = "4")]
		public bool Equals(SerializableGuid LPEBOAHCFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57998A0", Offset = "0x57984A0", VA = "0x1857998A0", Slot = "5")]
		public int CompareTo(SerializableGuid LPEBOAHCFNN)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[JFCKEAJHBKC(1)]
	[MPJLBCPNKLM("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[JFCKEAJHBKC(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[AHDFMABLMIO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[AHDFMABLMIO(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NEFJGCLJDFJ(0, 4)]
public enum MKMAJNKPPKN
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
	[JFCKEAJHBKC(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[AHDFMABLMIO(1)]
		public MKMAJNKPPKN gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[JFCKEAJHBKC(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[AHDFMABLMIO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[AHDFMABLMIO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[AHDFMABLMIO(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[JFCKEAJHBKC(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[AHDFMABLMIO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[AHDFMABLMIO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[AHDFMABLMIO(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[AHDFMABLMIO(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[AHDFMABLMIO(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[JFCKEAJHBKC(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[AHDFMABLMIO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[AHDFMABLMIO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[AHDFMABLMIO(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JCDLAHGBHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity CMGIPAKOGCG
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
	[FLGCFDICFAJ("Light", 0)]
	[JFCKEAJHBKC(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[AHDFMABLMIO(1)]
		[HBJALOLJMNC(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HBJALOLJMNC(0)]
		[AHDFMABLMIO(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[AHDFMABLMIO(3)]
		[HBJALOLJMNC(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[JFCKEAJHBKC(1)]
	[FLGCFDICFAJ("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[AHDFMABLMIO(1)]
		[HBJALOLJMNC(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[JFCKEAJHBKC(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[JFCKEAJHBKC(1)]
	public struct ParentData : IComponentData, JCDLAHGBHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[AHDFMABLMIO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DPBOGNPPLME : ISystemStateComponentData, IComponentData, JCDLAHGBHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity GAEKDCPLMPC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity KOIDKPOELDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x936270", Offset = "0x934E70", VA = "0x180936270", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KMGCPOBJPIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[NEFJGCLJDFJ(0, 4)]
public enum IMNHOPFMHJD
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
	[JFCKEAJHBKC(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[AHDFMABLMIO(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[AHDFMABLMIO(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[AHDFMABLMIO(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[AHDFMABLMIO(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[AHDFMABLMIO(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[AHDFMABLMIO(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[AHDFMABLMIO(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[AHDFMABLMIO(8)]
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
public struct HDAKJJDIEGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 NAMHFPEGFCL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[JFCKEAJHBKC(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[AHDFMABLMIO(1)]
		public CNNFLHMBHAC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[AHDFMABLMIO(2)]
		public CDDAOIHDHNB scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class ILOJEJMOKLO
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5797FC0", Offset = "0x5796BC0", VA = "0x185797FC0")]
	public static CNNFLHMBHAC JNIPLPDFDNO(this CNNFLHMBHAC PELMCJBBFEG, FJLDBEJEKBI FAOFMGAPHDP)
	{
		return default(CNNFLHMBHAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5797FD0", Offset = "0x5796BD0", VA = "0x185797FD0")]
	public static CNNFLHMBHAC MAHLOMNJIKK(this CNNFLHMBHAC PELMCJBBFEG, FJLDBEJEKBI FAOFMGAPHDP)
	{
		return default(CNNFLHMBHAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5797FE0", Offset = "0x5796BE0", VA = "0x185797FE0")]
	public static CNNFLHMBHAC OMMECLKDPFJ(this CNNFLHMBHAC PELMCJBBFEG, FJLDBEJEKBI FAOFMGAPHDP, bool DICKNPIGMGL)
	{
		return default(CNNFLHMBHAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5797FA0", Offset = "0x5796BA0", VA = "0x185797FA0")]
	public static bool CDCJMJCFICB(this CNNFLHMBHAC PELMCJBBFEG, FJLDBEJEKBI FAOFMGAPHDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FJLDBEJEKBI
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
[NEFJGCLJDFJ(0, 16383)]
public enum CNNFLHMBHAC
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
[LFCABNEOOLF(1)]
public struct CDDAOIHDHNB : FAACHECLGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[DCIAAGPJBDJ(1)]
	public bool HBNIBEPBNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[DCIAAGPJBDJ(2)]
	public float3 FELOLGEFONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[DCIAAGPJBDJ(3)]
	public float3 EIPGPKANBGO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5796D30", Offset = "0x5795930", VA = "0x185796D30", Slot = "5")]
	public void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5796C10", Offset = "0x5795810", VA = "0x185796C10", Slot = "4")]
	public void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LFCABNEOOLF(1)]
public struct ANEJDFCHNED : FAACHECLGAP, IEquatable<ANEJDFCHNED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[DCIAAGPJBDJ(1)]
	public int PHGKKLLIIFD;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0")]
	public ANEJDFCHNED(int PHGKKLLIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57967D0", Offset = "0x57953D0", VA = "0x1857967D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5796750", Offset = "0x5795350", VA = "0x185796750", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xD87730", Offset = "0xD86330", VA = "0x180D87730", Slot = "6")]
	public bool Equals(ANEJDFCHNED LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2030A70", Offset = "0x202F670", VA = "0x182030A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5796830", Offset = "0x5795430", VA = "0x185796830", Slot = "5")]
	public void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5796720", Offset = "0x5795320", VA = "0x185796720", Slot = "4")]
	public void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[JFCKEAJHBKC(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[AHDFMABLMIO(1)]
		public ANEJDFCHNED customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NEFJGCLJDFJ(0, 1)]
public enum ALBDICGHDPI
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
	[JFCKEAJHBKC(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[AHDFMABLMIO(1)]
		public ALBDICGHDPI propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[FLGCFDICFAJ("Physics", 0)]
	[JFCKEAJHBKC(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[HBJALOLJMNC(0)]
		[AHDFMABLMIO(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[JFCKEAJHBKC(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[AHDFMABLMIO(1)]
		public AGOBHJFJLNP shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NEFJGCLJDFJ(-1, 18)]
public enum AGOBHJFJLNP
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
[NEFJGCLJDFJ(0, 2)]
public enum CECKPKBGDDH
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
	[JFCKEAJHBKC(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[AHDFMABLMIO(1)]
		public CECKPKBGDDH shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[JFCKEAJHBKC(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[NEFJGCLJDFJ(0, 7)]
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
		[AHDFMABLMIO(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5799990", Offset = "0x5798590", VA = "0x185799990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5799A10", Offset = "0x5798610", VA = "0x185799A10")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LFCABNEOOLF(1)]
public struct LMCIJACOKIM : FAACHECLGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[NEFJGCLJDFJ(0, 7)]
	public enum KOJKDGOLICE
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
	[DCIAAGPJBDJ(1)]
	public float MGOHKMPLGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[DCIAAGPJBDJ(2)]
	public int OHLGGILMHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[DCIAAGPJBDJ(3)]
	public KOJKDGOLICE PELMCJBBFEG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FDKKOCBFLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5798410", Offset = "0x5797010", VA = "0x185798410")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x57983F0", Offset = "0x5796FF0", VA = "0x1857983F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ONPEAMILNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5798510", Offset = "0x5797110", VA = "0x185798510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5798590", Offset = "0x5797190", VA = "0x185798590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OKILHNGFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5798610", Offset = "0x5797210", VA = "0x185798610")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x57984F0", Offset = "0x57970F0", VA = "0x1857984F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57985B0", Offset = "0x57971B0", VA = "0x1857985B0", Slot = "5")]
	public void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5798490", Offset = "0x5797090", VA = "0x185798490", Slot = "4")]
	public void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[JFCKEAJHBKC(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[AHDFMABLMIO(1)]
		public LMCIJACOKIM parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[JFCKEAJHBKC(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[AHDFMABLMIO(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[AHDFMABLMIO(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[AHDFMABLMIO(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[AHDFMABLMIO(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[AHDFMABLMIO(5)]
		public GFPPCPFHMFP order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CGILNCPLECI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DMMNFEMLBEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct GKNJLNJEPMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ADIHNACPGPO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[JFCKEAJHBKC(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[AHDFMABLMIO(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[AHDFMABLMIO(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[AHDFMABLMIO(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[JFCKEAJHBKC(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[AHDFMABLMIO(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[AHDFMABLMIO(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[AHDFMABLMIO(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[AHDFMABLMIO(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[AHDFMABLMIO(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[AHDFMABLMIO(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[AHDFMABLMIO(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[AHDFMABLMIO(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[AHDFMABLMIO(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[AHDFMABLMIO(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[AHDFMABLMIO(11)]
		public EDJEGALDGMA mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[AHDFMABLMIO(12)]
		public JJLBOMFOMFM myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[AHDFMABLMIO(13)]
		public PFCBCAMGILN myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[AHDFMABLMIO(14)]
		public JHBOAJGNHPE myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[AHDFMABLMIO(15)]
		public JDEAKJAPGPH myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[AHDFMABLMIO(16)]
		public LPILENDIIDJ myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[AHDFMABLMIO(17)]
		public MHJLBLNOGAO myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[AHDFMABLMIO(18)]
		public NJADFABHPAC myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[AHDFMABLMIO(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[AHDFMABLMIO(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[AHDFMABLMIO(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[AHDFMABLMIO(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum EDJEGALDGMA : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum JJLBOMFOMFM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum PFCBCAMGILN : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum JHBOAJGNHPE : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum JDEAKJAPGPH
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum LPILENDIIDJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum MHJLBLNOGAO : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum NJADFABHPAC : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[JFCKEAJHBKC(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[JFCKEAJHBKC(1)]
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
	[JFCKEAJHBKC(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class ENOKOOGIPFK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct DLMCNNNNDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Vector3 KHFECHLNOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<SerializableGuid> KPLAMELBMBA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class DACCLPMECFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DLMCNNNNDMJ NACFHKOKAIM;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public DACCLPMECFK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public SerializableGuid MEODFJOIFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public List<int> FLCEMBBJEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public List<DLMCNNNNDMJ> FLLGCAIFBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<DACCLPMECFK> FABAELKBFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public GameObject JPIPKHMPCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Light BGMGHGLOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Collider DDOMPBPGFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public string EKEAMMCLOAP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public ENOKOOGIPFK()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[JFCKEAJHBKC(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[AHDFMABLMIO(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[JFCKEAJHBKC(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[AHDFMABLMIO(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[AHDFMABLMIO(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static LocalPoseData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[JFCKEAJHBKC(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[JFCKEAJHBKC(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5798870", Offset = "0x5797470", VA = "0x185798870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[JFCKEAJHBKC(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[AHDFMABLMIO(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JGOMOMBKPJI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int EBKNFNEIINA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BAOHKIGDOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5798110", Offset = "0x5796D10", VA = "0x185798110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5798100", Offset = "0x5796D00", VA = "0x185798100")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[JFCKEAJHBKC(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[AHDFMABLMIO(1)]
		public PFCOJKJEDEA transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[AHDFMABLMIO(2)]
		public IMEAPMBIBLD transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Flags]
[NEFJGCLJDFJ(0, 1)]
public enum PFCOJKJEDEA
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
[NEFJGCLJDFJ(-2, 2)]
public enum IMEAPMBIBLD
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
	[JFCKEAJHBKC(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[JFCKEAJHBKC(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5799B20", Offset = "0x5798720", VA = "0x185799B20")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[JFCKEAJHBKC(1)]
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
[NEFJGCLJDFJ(1000, 7003)]
public enum GGPLMDHKFKM
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
internal enum EBANIDIALED
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
internal static class CLKDKBHKEPN
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[JFCKEAJHBKC(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[AHDFMABLMIO(1)]
		public GGPLMDHKFKM prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FBIGDNFKHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5797190", Offset = "0x5795D90", VA = "0x185797190")]
	public static bool CFPLHNJDHJJ(this GGPLMDHKFKM HCPDGKICMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x57971B0", Offset = "0x5795DB0", VA = "0x1857971B0")]
	public static string EJNGBHEHDFF(this GGPLMDHKFKM HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5797260", Offset = "0x5795E60", VA = "0x185797260")]
	public static PJMGKLOCDGA MKDPNGGDPBH(this GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(PJMGKLOCDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5797250", Offset = "0x5795E50", VA = "0x185797250")]
	internal static EBANIDIALED FGGOPLFAFNO(this PJMGKLOCDGA MOCONOOMAJE)
	{
		return default(EBANIDIALED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5797230", Offset = "0x5795E30", VA = "0x185797230")]
	internal static EBANIDIALED FGGOPLFAFNO(this GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(EBANIDIALED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[NEFJGCLJDFJ(0, 7)]
public enum PJMGKLOCDGA
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
	[JFCKEAJHBKC(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[AHDFMABLMIO(1)]
		public PJMGKLOCDGA objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PCCHHCIEBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5798F10", Offset = "0x5797B10", VA = "0x185798F10")]
	public static bool FFDOGLPPPIO(this PJMGKLOCDGA MOCONOOMAJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[NEFJGCLJDFJ(-1, 60)]
public enum FGMDFHIGIMG
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
[NEFJGCLJDFJ(-1, 31)]
public enum LEILBCOIFJH
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
	[FLGCFDICFAJ("Visual", 0)]
	[JFCKEAJHBKC(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[AHDFMABLMIO(1)]
		[HBJALOLJMNC(0)]
		public FGMDFHIGIMG color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[HBJALOLJMNC(0)]
		[AHDFMABLMIO(2)]
		public LEILBCOIFJH material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[AHDFMABLMIO(3)]
		[HBJALOLJMNC(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[AHDFMABLMIO(4)]
		[HBJALOLJMNC(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	internal class _RRAssemblyIndex : GNPHCGOMALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5799E00", Offset = "0x5798A00", VA = "0x185799E00", Slot = "4")]
		public sealed override void PGNCHLHGPKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class PMLBMDNJGAA : ContainerPropertyBag<TestNonSerializedManagedData>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private class LGMBOIFDMDM : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x57982A0", Offset = "0x5796EA0", VA = "0x1857982A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5798260", Offset = "0x5796E60", VA = "0x185798260")]
		public LGMBOIFDMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3056F30", Offset = "0x3055B30", VA = "0x183056F30", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5798240", Offset = "0x5796E40", VA = "0x185798240", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class FJFAAABAKAM : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5797580", Offset = "0x5796180", VA = "0x185797580", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5797540", Offset = "0x5796140", VA = "0x185797540")]
		public FJFAAABAKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5797500", Offset = "0x5796100", VA = "0x185797500", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5797520", Offset = "0x5796120", VA = "0x185797520", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private class NLHKOHMKGAP : Property<TestNonSerializedManagedData, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5798CB0", Offset = "0x57978B0", VA = "0x185798CB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5798C70", Offset = "0x5797870", VA = "0x185798C70")]
		public NLHKOHMKGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3056D70", Offset = "0x3055970", VA = "0x183056D70", Slot = "11")]
		public override GameObject GetValue(ref TestNonSerializedManagedData OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5798C40", Offset = "0x5797840", VA = "0x185798C40", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData OMBBCDBECLD, GameObject PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5799030", Offset = "0x5797C30", VA = "0x185799030")]
	public PMLBMDNJGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class IHIAHADPOKO : ContainerPropertyBag<ENOKOOGIPFK>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private class FNPFONFBPBK : Property<ENOKOOGIPFK, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5797640", Offset = "0x5796240", VA = "0x185797640", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5797600", Offset = "0x5796200", VA = "0x185797600")]
		public FNPFONFBPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57975B0", Offset = "0x57961B0", VA = "0x1857975B0", Slot = "11")]
		public override SerializableGuid GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57975E0", Offset = "0x57961E0", VA = "0x1857975E0", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, SerializableGuid PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class KLPCDGPFOPE : Property<ENOKOOGIPFK, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5798210", Offset = "0x5796E10", VA = "0x185798210", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57981D0", Offset = "0x5796DD0", VA = "0x1857981D0")]
		public KLPCDGPFOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E156A0", Offset = "0x3E142A0", VA = "0x183E156A0", Slot = "11")]
		public override List<int> GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57981A0", Offset = "0x5796DA0", VA = "0x1857981A0", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, List<int> PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class BNGIHNOHNGD : Property<ENOKOOGIPFK, List<ENOKOOGIPFK.DLMCNNNNDMJ>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5796B70", Offset = "0x5795770", VA = "0x185796B70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5796B30", Offset = "0x5795730", VA = "0x185796B30")]
		public BNGIHNOHNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5796AE0", Offset = "0x57956E0", VA = "0x185796AE0", Slot = "11")]
		public override List<ENOKOOGIPFK.DLMCNNNNDMJ> GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5796B00", Offset = "0x5795700", VA = "0x185796B00", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, List<ENOKOOGIPFK.DLMCNNNNDMJ> PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class PCAMCIAJCMM : Property<ENOKOOGIPFK, List<ENOKOOGIPFK.DACCLPMECFK>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5798EE0", Offset = "0x5797AE0", VA = "0x185798EE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5798EA0", Offset = "0x5797AA0", VA = "0x185798EA0")]
		public PCAMCIAJCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5798E50", Offset = "0x5797A50", VA = "0x185798E50", Slot = "11")]
		public override List<ENOKOOGIPFK.DACCLPMECFK> GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5798E70", Offset = "0x5797A70", VA = "0x185798E70", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, List<ENOKOOGIPFK.DACCLPMECFK> PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class BCCHIAKHNNA : Property<ENOKOOGIPFK, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x57969A0", Offset = "0x57955A0", VA = "0x1857969A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5796960", Offset = "0x5795560", VA = "0x185796960")]
		public BCCHIAKHNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5796910", Offset = "0x5795510", VA = "0x185796910", Slot = "11")]
		public override GameObject GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5796930", Offset = "0x5795530", VA = "0x185796930", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, GameObject PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class NEJJPCOIANG : Property<ENOKOOGIPFK, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5798BA0", Offset = "0x57977A0", VA = "0x185798BA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5798B60", Offset = "0x5797760", VA = "0x185798B60")]
		public NEJJPCOIANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5798B10", Offset = "0x5797710", VA = "0x185798B10", Slot = "11")]
		public override Light GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5798B30", Offset = "0x5797730", VA = "0x185798B30", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, Light PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class MJJIAFPGHIM : Property<ENOKOOGIPFK, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5798AE0", Offset = "0x57976E0", VA = "0x185798AE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5798AA0", Offset = "0x57976A0", VA = "0x185798AA0")]
		public MJJIAFPGHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5798A50", Offset = "0x5797650", VA = "0x185798A50", Slot = "11")]
		public override Collider GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5798A70", Offset = "0x5797670", VA = "0x185798A70", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, Collider PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class FJACGOACIOB : Property<ENOKOOGIPFK, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x57974D0", Offset = "0x57960D0", VA = "0x1857974D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5797490", Offset = "0x5796090", VA = "0x185797490")]
		public FJACGOACIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5797440", Offset = "0x5796040", VA = "0x185797440", Slot = "11")]
		public override string GetValue(ref ENOKOOGIPFK OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5797460", Offset = "0x5796060", VA = "0x185797460", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK OMBBCDBECLD, string PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5797B30", Offset = "0x5796730", VA = "0x185797B30")]
	public IHIAHADPOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal class LKALLCHDHMI : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class NJCCKADOHBO : Property<SerializableGuid, SerializableGuid.Data>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5798C10", Offset = "0x5797810", VA = "0x185798C10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5798BD0", Offset = "0x57977D0", VA = "0x185798BD0")]
		public NJCCKADOHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x22E18C0", Offset = "0x22E04C0", VA = "0x1822E18C0", Slot = "11")]
		public override SerializableGuid.Data GetValue(ref SerializableGuid OMBBCDBECLD)
		{
			return default(SerializableGuid.Data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3543C90", Offset = "0x3542890", VA = "0x183543C90", Slot = "12")]
		public override void SetValue(ref SerializableGuid OMBBCDBECLD, SerializableGuid.Data PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5798340", Offset = "0x5796F40", VA = "0x185798340")]
	public LKALLCHDHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class ILEDIPIKJDI : ContainerPropertyBag<SerializableGuid.Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class LIMJBMMGLPO : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5798310", Offset = "0x5796F10", VA = "0x185798310", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x57982D0", Offset = "0x5796ED0", VA = "0x1857982D0")]
		public LIMJBMMGLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xFF79A0", Offset = "0xFF65A0", VA = "0x180FF79A0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3541900", Offset = "0x3540500", VA = "0x183541900", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class BPLBNKLJJIL : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5796BE0", Offset = "0x57957E0", VA = "0x185796BE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5796BA0", Offset = "0x57957A0", VA = "0x185796BA0")]
		public BPLBNKLJJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x354E660", Offset = "0x354D260", VA = "0x18354E660", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x354E670", Offset = "0x354D270", VA = "0x18354E670", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class OCPOFNNOPKO : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5798D20", Offset = "0x5797920", VA = "0x185798D20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5798CE0", Offset = "0x57978E0", VA = "0x185798CE0")]
		public OCPOFNNOPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F6DC30", Offset = "0x2F6C830", VA = "0x182F6DC30", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x35516E0", Offset = "0x35502E0", VA = "0x1835516E0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private class DMOPHNJIBCP : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5797020", Offset = "0x5795C20", VA = "0x185797020", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5796FE0", Offset = "0x5795BE0", VA = "0x185796FE0")]
		public DMOPHNJIBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3551570", Offset = "0x3550170", VA = "0x183551570", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data OMBBCDBECLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3551580", Offset = "0x3550180", VA = "0x183551580", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data OMBBCDBECLD, int PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5797E10", Offset = "0x5796A10", VA = "0x185797E10")]
	public ILEDIPIKJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class PILDAODOECN : ContainerPropertyBag<ENOKOOGIPFK.DLMCNNNNDMJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private class DOKJKEFJIOF : Property<ENOKOOGIPFK.DLMCNNNNDMJ, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x57970B0", Offset = "0x5795CB0", VA = "0x1857970B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5797070", Offset = "0x5795C70", VA = "0x185797070")]
		public DOKJKEFJIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xF26070", Offset = "0xF24C70", VA = "0x180F26070", Slot = "11")]
		public override Vector3 GetValue(ref ENOKOOGIPFK.DLMCNNNNDMJ OMBBCDBECLD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5797050", Offset = "0x5795C50", VA = "0x185797050", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK.DLMCNNNNDMJ OMBBCDBECLD, Vector3 PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class JMFLHBAMNOF : Property<ENOKOOGIPFK.DLMCNNNNDMJ, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5798170", Offset = "0x5796D70", VA = "0x185798170", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5798130", Offset = "0x5796D30", VA = "0x185798130")]
		public JMFLHBAMNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1C70270", Offset = "0x1C6EE70", VA = "0x181C70270", Slot = "11")]
		public override List<SerializableGuid> GetValue(ref ENOKOOGIPFK.DLMCNNNNDMJ OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5798120", Offset = "0x5796D20", VA = "0x185798120", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK.DLMCNNNNDMJ OMBBCDBECLD, List<SerializableGuid> PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5798F20", Offset = "0x5797B20", VA = "0x185798F20")]
	public PILDAODOECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal class IEKOAFCIDLM : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class MIAGCJGDIPA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5798A20", Offset = "0x5797620", VA = "0x185798A20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57989E0", Offset = "0x57975E0", VA = "0x1857989E0")]
		public MIAGCJGDIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57989C0", Offset = "0x57975C0", VA = "0x1857989C0", Slot = "11")]
		public override float GetValue(ref Vector3 OMBBCDBECLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x57989D0", Offset = "0x57975D0", VA = "0x1857989D0", Slot = "12")]
		public override void SetValue(ref Vector3 OMBBCDBECLD, float PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private class BLLBADDPNOG : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5796A30", Offset = "0x5795630", VA = "0x185796A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x57969F0", Offset = "0x57955F0", VA = "0x1857969F0")]
		public BLLBADDPNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x57969D0", Offset = "0x57955D0", VA = "0x1857969D0", Slot = "11")]
		public override float GetValue(ref Vector3 OMBBCDBECLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57969E0", Offset = "0x57955E0", VA = "0x1857969E0", Slot = "12")]
		public override void SetValue(ref Vector3 OMBBCDBECLD, float PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class BMOBJADKMNH : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5796AB0", Offset = "0x57956B0", VA = "0x185796AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5796A70", Offset = "0x5795670", VA = "0x185796A70")]
		public BMOBJADKMNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x18131A0", Offset = "0x1811DA0", VA = "0x1818131A0", Slot = "11")]
		public override float GetValue(ref Vector3 OMBBCDBECLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5796A60", Offset = "0x5795660", VA = "0x185796A60", Slot = "12")]
		public override void SetValue(ref Vector3 OMBBCDBECLD, float PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x57979F0", Offset = "0x57965F0", VA = "0x1857979F0")]
	public IEKOAFCIDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class EOLMPAFFNFO : ContainerPropertyBag<ENOKOOGIPFK.DACCLPMECFK>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class CHKMJOPBPPG : Property<ENOKOOGIPFK.DACCLPMECFK, ENOKOOGIPFK.DLMCNNNNDMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5796EE0", Offset = "0x5795AE0", VA = "0x185796EE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5796EA0", Offset = "0x5795AA0", VA = "0x185796EA0")]
		public CHKMJOPBPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5796E30", Offset = "0x5795A30", VA = "0x185796E30", Slot = "11")]
		public override ENOKOOGIPFK.DLMCNNNNDMJ GetValue(ref ENOKOOGIPFK.DACCLPMECFK OMBBCDBECLD)
		{
			return default(ENOKOOGIPFK.DLMCNNNNDMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5796E60", Offset = "0x5795A60", VA = "0x185796E60", Slot = "12")]
		public override void SetValue(ref ENOKOOGIPFK.DACCLPMECFK OMBBCDBECLD, ENOKOOGIPFK.DLMCNNNNDMJ PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57970E0", Offset = "0x5795CE0", VA = "0x1857970E0")]
	public EOLMPAFFNFO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x57991B0", Offset = "0x5797DB0", VA = "0x1857991B0")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
