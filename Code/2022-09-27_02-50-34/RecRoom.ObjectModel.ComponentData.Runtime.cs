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
	[EGIHDKLAKHM(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JHLIGMDNFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15232A0", Offset = "0x15224A0", VA = "0x1815232A0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[EGIHDKLAKHM(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[IIBJINLIOJP(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[IIBJINLIOJP(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x274E4F0", Offset = "0x274D6F0", VA = "0x18274E4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBB4790", Offset = "0xBB3990", VA = "0x180BB4790")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[EGIHDKLAKHM(1)]
	public struct AuthoredParentData : IComponentData, JHLIGMDNFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[IIBJINLIOJP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x274E510", Offset = "0x274D710", VA = "0x18274E510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EJJPOMLFOPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IHFGDFFIKAA : ISystemStateComponentData, IComponentData, JHLIGMDNFAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity EFBPOIAFHFA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity EBACNKBJELK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[InternalBufferCapacity(8)]
	[EGIHDKLAKHM(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JHLIGMDNFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x15232A0", Offset = "0x15224A0", VA = "0x1815232A0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[LIBCNDECOMA(0, 15)]
public enum KKNCOIPAGJP
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
[LIBCNDECOMA(0, 2)]
public enum JFDGEBCJMAA
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
	[BLAGMMEDCAO("Container", 0)]
	[EGIHDKLAKHM(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[IIBJINLIOJP(1)]
		[JONAMKLMKIH(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[IIBJINLIOJP(2)]
		[JONAMKLMKIH(0)]
		public JFDGEBCJMAA collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(3)]
		public KKNCOIPAGJP collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[IIBJINLIOJP(4)]
		[JONAMKLMKIH(0)]
		public CCAFAIGBBJA grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(5)]
		public MHCAIFDFFED flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[IIBJINLIOJP(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x274EC80", Offset = "0x274DE80", VA = "0x18274EC80", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[LIBCNDECOMA(0, 16071)]
public enum MHCAIFDFFED
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
[LIBCNDECOMA(0, 1)]
public enum CCAFAIGBBJA
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
[OGDKCABKPEJ(1)]
public struct HEMMCLBAPMN : IComparable<HEMMCLBAPMN>, IEquatable<HEMMCLBAPMN>, JFOPHLNANAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[NFEIKHAAGGD(1)]
	public uint HAPPMDHCACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[NFEIKHAAGGD(2)]
	public uint GACHLLCEJNP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint CMIJGMOAHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x274F720", Offset = "0x274E920", VA = "0x18274F720")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x274F950", Offset = "0x274EB50", VA = "0x18274F950")]
	public HEMMCLBAPMN(int HAPPMDHCACG, int MJMPIHEDMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x274F950", Offset = "0x274EB50", VA = "0x18274F950")]
	public HEMMCLBAPMN(uint HAPPMDHCACG, uint MJMPIHEDMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x274F620", Offset = "0x274E820", VA = "0x18274F620")]
	private static uint CAFIKEOIKKB(uint PJIOBOBOEGF, uint KLGGEDCBMPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x274F650", Offset = "0x274E850", VA = "0x18274F650", Slot = "4")]
	public int CompareTo(HEMMCLBAPMN GHOINNFPLDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x274F670", Offset = "0x274E870", VA = "0x18274F670", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x274F890", Offset = "0x274EA90", VA = "0x18274F890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x274F700", Offset = "0x274E900", VA = "0x18274F700", Slot = "5")]
	public bool Equals(HEMMCLBAPMN GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x274F730", Offset = "0x274E930", VA = "0x18274F730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x274F7F0", Offset = "0x274E9F0", VA = "0x18274F7F0", Slot = "6")]
	public void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x274F780", Offset = "0x274E980", VA = "0x18274F780", Slot = "7")]
	public void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x274F870", Offset = "0x274EA70", VA = "0x18274F870")]
	public static bool OBFGCGKAGJG(HEMMCLBAPMN IPOFNDCGNHE, HEMMCLBAPMN GOIECGKCDOF)
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
		[Cpp2IlInjected.Address(RVA = "0x88B000", Offset = "0x88A200", VA = "0x18088B000")]
		public static SerializableGuid BKALKAPLPLL(Guid DHMJIJECAJK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2751610", Offset = "0x2750810", VA = "0x182751610", Slot = "4")]
		public bool Equals(SerializableGuid GHOINNFPLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27515F0", Offset = "0x27507F0", VA = "0x1827515F0", Slot = "5")]
		public int CompareTo(SerializableGuid GHOINNFPLDF)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[IIOJMNJJAFK("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	[EGIHDKLAKHM(1)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[EGIHDKLAKHM(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[IIBJINLIOJP(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[IIBJINLIOJP(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LIBCNDECOMA(0, 4)]
public enum HCEPBAEMJHI
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
	[EGIHDKLAKHM(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[IIBJINLIOJP(1)]
		public HCEPBAEMJHI gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[EGIHDKLAKHM(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[IIBJINLIOJP(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[IIBJINLIOJP(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[IIBJINLIOJP(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[EGIHDKLAKHM(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[IIBJINLIOJP(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[IIBJINLIOJP(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[IIBJINLIOJP(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[IIBJINLIOJP(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[IIBJINLIOJP(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[EGIHDKLAKHM(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[IIBJINLIOJP(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[IIBJINLIOJP(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[IIBJINLIOJP(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JHLIGMDNFAC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity EDLGLNELGLD
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
	[BLAGMMEDCAO("Light", 0)]
	[EGIHDKLAKHM(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[EGIHDKLAKHM(1)]
	[BLAGMMEDCAO("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[IIBJINLIOJP(1)]
		[JONAMKLMKIH(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[EGIHDKLAKHM(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[EGIHDKLAKHM(1)]
	public struct ParentData : IComponentData, JHLIGMDNFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[IIBJINLIOJP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DFNCJJGLOJB : ISystemStateComponentData, IComponentData, JHLIGMDNFAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity EFBPOIAFHFA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity EBACNKBJELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9F0", Offset = "0xA5ABF0", VA = "0x180A5B9F0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AJHGPGLGKCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[LIBCNDECOMA(0, 4)]
public enum GAJDMKGLJCB
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
	[EGIHDKLAKHM(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[IIBJINLIOJP(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[IIBJINLIOJP(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[IIBJINLIOJP(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[IIBJINLIOJP(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[IIBJINLIOJP(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[IIBJINLIOJP(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[IIBJINLIOJP(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[IIBJINLIOJP(8)]
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
public struct GNFIALGGLMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 AGAHEBNHFCC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly GNFIALGGLMJ HPMHEACECHL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[EGIHDKLAKHM(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[IIBJINLIOJP(1)]
		public NFLHHCAKGPN flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[IIBJINLIOJP(2)]
		public HJEIKMBPJDH scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class BJDOMEAGMHE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x274E6B0", Offset = "0x274D8B0", VA = "0x18274E6B0")]
	public static NFLHHCAKGPN KAGEPJABGKM(this NFLHHCAKGPN NKBIJCGCLBL, NOICBIHNDEE PIJHBPMAOAA)
	{
		return default(NFLHHCAKGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x274E660", Offset = "0x274D860", VA = "0x18274E660")]
	public static NFLHHCAKGPN CEDMIKNCMLN(this NFLHHCAKGPN NKBIJCGCLBL, NOICBIHNDEE PIJHBPMAOAA)
	{
		return default(NFLHHCAKGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x274E690", Offset = "0x274D890", VA = "0x18274E690")]
	public static NFLHHCAKGPN IFJCIHOHMLJ(this NFLHHCAKGPN NKBIJCGCLBL, NOICBIHNDEE PIJHBPMAOAA, bool KNNIGCHOJNF)
	{
		return default(NFLHHCAKGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x274E670", Offset = "0x274D870", VA = "0x18274E670")]
	public static bool GAIDKBHOMEH(this NFLHHCAKGPN NKBIJCGCLBL, NOICBIHNDEE PIJHBPMAOAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NOICBIHNDEE
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
[LIBCNDECOMA(0, 16383)]
public enum NFLHHCAKGPN
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
[OGDKCABKPEJ(1)]
public struct HJEIKMBPJDH : JFOPHLNANAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[NFEIKHAAGGD(1)]
	public bool GOODPFDDLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[NFEIKHAAGGD(2)]
	public float3 DDMLGHIPNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[NFEIKHAAGGD(3)]
	public float3 KENFDFDOGIC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x274FA60", Offset = "0x274EC60", VA = "0x18274FA60", Slot = "5")]
	public void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x274FB60", Offset = "0x274ED60", VA = "0x18274FB60", Slot = "4")]
	public void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[OGDKCABKPEJ(1)]
public struct CHGMKFJBIIK : JFOPHLNANAA, IEquatable<CHGMKFJBIIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[NFEIKHAAGGD(1)]
	public int IHPCCBHNEMN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD370", Offset = "0x6FC570", VA = "0x1806FD370")]
	public CHGMKFJBIIK(int IHPCCBHNEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x274EA10", Offset = "0x274DC10", VA = "0x18274EA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x274E990", Offset = "0x274DB90", VA = "0x18274E990", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA5B730", Offset = "0xA5A930", VA = "0x180A5B730", Slot = "6")]
	public bool Equals(CHGMKFJBIIK GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA5B800", Offset = "0xA5AA00", VA = "0x180A5B800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x274EA70", Offset = "0x274DC70", VA = "0x18274EA70", Slot = "5")]
	public void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x274EAA0", Offset = "0x274DCA0", VA = "0x18274EAA0", Slot = "4")]
	public void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[EGIHDKLAKHM(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[IIBJINLIOJP(1)]
		public CHGMKFJBIIK customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LIBCNDECOMA(0, 1)]
public enum NEPCDHCEMNL
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
	[EGIHDKLAKHM(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[IIBJINLIOJP(1)]
		public NEPCDHCEMNL propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BLAGMMEDCAO("Physics", 0)]
	[EGIHDKLAKHM(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[IIBJINLIOJP(1)]
		[JONAMKLMKIH(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[EGIHDKLAKHM(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[IIBJINLIOJP(1)]
		public HLDDLEKEHIF shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LIBCNDECOMA(-1, 18)]
public enum HLDDLEKEHIF
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
[LIBCNDECOMA(0, 2)]
public enum GFFCHJKNLEG
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
	[EGIHDKLAKHM(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[IIBJINLIOJP(1)]
		public GFFCHJKNLEG shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[EGIHDKLAKHM(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[LIBCNDECOMA(0, 7)]
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
		[IIBJINLIOJP(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x27516E0", Offset = "0x27508E0", VA = "0x1827516E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2751760", Offset = "0x2750960", VA = "0x182751760")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[OGDKCABKPEJ(1)]
public struct GLHJILCLPGK : JFOPHLNANAA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[LIBCNDECOMA(0, 7)]
	public enum KFHDFFJHHMK
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
	[NFEIKHAAGGD(1)]
	public float OPCPNMPDKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NFEIKHAAGGD(2)]
	public int EONGLDKIEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NFEIKHAAGGD(3)]
	public KFHDFFJHHMK NKBIJCGCLBL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MCBGGEDBKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x274F1C0", Offset = "0x274E3C0", VA = "0x18274F1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x274F420", Offset = "0x274E620", VA = "0x18274F420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FLNPPLGHNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x274F240", Offset = "0x274E440", VA = "0x18274F240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x274F1A0", Offset = "0x274E3A0", VA = "0x18274F1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NNHKBFKOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x274F380", Offset = "0x274E580", VA = "0x18274F380")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x274F400", Offset = "0x274E600", VA = "0x18274F400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x274F2C0", Offset = "0x274E4C0", VA = "0x18274F2C0", Slot = "5")]
	public void LGPKACCHBHO(KLJNHPCCJBI JJPICLDNKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x274F320", Offset = "0x274E520", VA = "0x18274F320", Slot = "4")]
	public void LIOPAMDCNLD(KLJNHPCCJBI JJPICLDNKPF)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[EGIHDKLAKHM(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[IIBJINLIOJP(1)]
		public GLHJILCLPGK parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[EGIHDKLAKHM(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[IIBJINLIOJP(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[IIBJINLIOJP(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[IIBJINLIOJP(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[IIBJINLIOJP(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[IIBJINLIOJP(5)]
		public HEMMCLBAPMN order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct DHGFJPDPKNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct GHGEGPACMKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ANIHGOLMIJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OFMBPOJMEMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct FMKCCIADONB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct ENDDHKGOAFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal struct BCHOLIPDPEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct JCKCMGJJKBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct OCJPIEODGAM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[EGIHDKLAKHM(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[IIBJINLIOJP(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[IIBJINLIOJP(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[IIBJINLIOJP(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[EGIHDKLAKHM(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[IIBJINLIOJP(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[IIBJINLIOJP(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[IIBJINLIOJP(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[IIBJINLIOJP(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[IIBJINLIOJP(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[IIBJINLIOJP(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[IIBJINLIOJP(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[IIBJINLIOJP(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[IIBJINLIOJP(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[IIBJINLIOJP(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[IIBJINLIOJP(11)]
		public EJCDNCEJAOL mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[IIBJINLIOJP(12)]
		public KCAPGNGPHCC myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[IIBJINLIOJP(13)]
		public LAFNOCDEELO myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[IIBJINLIOJP(14)]
		public HOLHLEFPODM myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[IIBJINLIOJP(15)]
		public HLMOAGBDGNH myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[IIBJINLIOJP(16)]
		public LADMIEEHPMK myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[IIBJINLIOJP(17)]
		public MKELHFNFEFI myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[IIBJINLIOJP(18)]
		public GBBODCMPBAA myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[IIBJINLIOJP(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[IIBJINLIOJP(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[IIBJINLIOJP(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[IIBJINLIOJP(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum EJCDNCEJAOL : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum KCAPGNGPHCC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum LAFNOCDEELO : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum HOLHLEFPODM : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum HLMOAGBDGNH
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum LADMIEEHPMK : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum MKELHFNFEFI : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum GBBODCMPBAA : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[EGIHDKLAKHM(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[EGIHDKLAKHM(1)]
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
	[EGIHDKLAKHM(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GJANDHHFHAL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct IDAMACGNMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 BNGOIMBHBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public List<SerializableGuid> PELDEEPJOBI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class OGEOIMOJEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public IDAMACGNMPH IMHEIGCAEPD;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OGEOIMOJEOE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public SerializableGuid PGLFEKDGFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public List<int> BCKMLIDBGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<IDAMACGNMPH> EJCAEJCJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public List<OGEOIMOJEOE> GKMPKNNGJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GameObject NEFMINHNLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Light HHFBMCIJCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Collider JGDOJJPMCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public string CGPAEMEDAEP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GJANDHHFHAL()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[EGIHDKLAKHM(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[IIBJINLIOJP(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[EGIHDKLAKHM(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[IIBJINLIOJP(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[IIBJINLIOJP(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBB4790", Offset = "0xBB3990", VA = "0x180BB4790")]
		public LocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[EGIHDKLAKHM(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[EGIHDKLAKHM(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2750910", Offset = "0x274FB10", VA = "0x182750910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[EGIHDKLAKHM(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[IIBJINLIOJP(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct LNMOMLMLAOK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int DHILBDBMHJB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MJNAIOAAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2750710", Offset = "0x274F910", VA = "0x182750710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2750720", Offset = "0x274F920", VA = "0x182750720")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[EGIHDKLAKHM(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[IIBJINLIOJP(1)]
		public FGPFIOLCOIF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[IIBJINLIOJP(2)]
		public ANJHFHDKMAO transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
[LIBCNDECOMA(0, 1)]
public enum FGPFIOLCOIF
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
[LIBCNDECOMA(-2, 2)]
public enum ANJHFHDKMAO
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
	[EGIHDKLAKHM(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[EGIHDKLAKHM(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x2751870", Offset = "0x2750A70", VA = "0x182751870")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[EGIHDKLAKHM(1)]
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
[LIBCNDECOMA(1000, 7003)]
public enum FNCBEEHJHBJ
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
internal enum NJGCLJAPNCL
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
internal static class MJFGBNBABEN
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[EGIHDKLAKHM(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[IIBJINLIOJP(1)]
		public FNCBEEHJHBJ prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class ABMFONLJJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x274E400", Offset = "0x274D600", VA = "0x18274E400")]
	public static bool FLDAOKPAEMF(this FNCBEEHJHBJ BGMCKNGNOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x274E380", Offset = "0x274D580", VA = "0x18274E380")]
	public static string CMHHOPJGCAK(this FNCBEEHJHBJ BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x274E420", Offset = "0x274D620", VA = "0x18274E420")]
	public static DNJDKHAFBEJ LDLJNCFLMEB(this FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(DNJDKHAFBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x274E460", Offset = "0x274D660", VA = "0x18274E460")]
	internal static NJGCLJAPNCL LGKMIMMCIPD(this DNJDKHAFBEJ AFDFEGDEGMM)
	{
		return default(NJGCLJAPNCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x274E440", Offset = "0x274D640", VA = "0x18274E440")]
	internal static NJGCLJAPNCL LGKMIMMCIPD(this FNCBEEHJHBJ FKFNLDMHBOL)
	{
		return default(NJGCLJAPNCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[LIBCNDECOMA(0, 7)]
public enum DNJDKHAFBEJ
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
	[EGIHDKLAKHM(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[IIBJINLIOJP(1)]
		public DNJDKHAFBEJ objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class NHOAGNDJBIM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2750BC0", Offset = "0x274FDC0", VA = "0x182750BC0")]
	public static bool LFMOJOKBPAK(this DNJDKHAFBEJ AFDFEGDEGMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[LIBCNDECOMA(-1, 60)]
public enum MJIMBPKPFMI
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
[LIBCNDECOMA(-1, 31)]
public enum DHGIBEELBFD
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
	[BLAGMMEDCAO("Visual", 0)]
	[EGIHDKLAKHM(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[JONAMKLMKIH(0)]
		[IIBJINLIOJP(1)]
		public MJIMBPKPFMI color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[IIBJINLIOJP(2)]
		[JONAMKLMKIH(0)]
		public DHGIBEELBFD material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[IIBJINLIOJP(3)]
		[JONAMKLMKIH(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[IIBJINLIOJP(4)]
		[JONAMKLMKIH(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	internal class _RRAssemblyIndex : BIJDGJCEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2751B50", Offset = "0x2750D50", VA = "0x182751B50", Slot = "4")]
		public sealed override void IGACKIBLPBJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BAPHLDEAEBN : ContainerPropertyBag<TestNonSerializedManagedData>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class MHHPEIAABGN : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2750AE0", Offset = "0x274FCE0", VA = "0x182750AE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2750AA0", Offset = "0x274FCA0", VA = "0x182750AA0")]
		public MHHPEIAABGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2750A60", Offset = "0x274FC60", VA = "0x182750A60", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2750A80", Offset = "0x274FC80", VA = "0x182750A80", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class IGAAIDAPMOH : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x274FD00", Offset = "0x274EF00", VA = "0x18274FD00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x274FCC0", Offset = "0x274EEC0", VA = "0x18274FCC0")]
		public IGAAIDAPMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x274FC80", Offset = "0x274EE80", VA = "0x18274FC80", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x274FCA0", Offset = "0x274EEA0", VA = "0x18274FCA0", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class PBCJIOHAACL : Property<TestNonSerializedManagedData, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2750D60", Offset = "0x274FF60", VA = "0x182750D60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2750D20", Offset = "0x274FF20", VA = "0x182750D20")]
		public PBCJIOHAACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2750CD0", Offset = "0x274FED0", VA = "0x182750CD0", Slot = "11")]
		public override GameObject GetValue(ref TestNonSerializedManagedData APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2750CF0", Offset = "0x274FEF0", VA = "0x182750CF0", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData APJAHLFEOEM, GameObject ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x274E520", Offset = "0x274D720", VA = "0x18274E520")]
	public BAPHLDEAEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class IOFKGFPEKNE : ContainerPropertyBag<GJANDHHFHAL>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class HFAHBNECLII : Property<GJANDHHFHAL, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x274FA30", Offset = "0x274EC30", VA = "0x18274FA30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x274F9F0", Offset = "0x274EBF0", VA = "0x18274F9F0")]
		public HFAHBNECLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x274F9A0", Offset = "0x274EBA0", VA = "0x18274F9A0", Slot = "11")]
		public override SerializableGuid GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x274F9D0", Offset = "0x274EBD0", VA = "0x18274F9D0", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, SerializableGuid ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class PLIMGMHKPBO : Property<GJANDHHFHAL, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2750E90", Offset = "0x2750090", VA = "0x182750E90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2750E50", Offset = "0x2750050", VA = "0x182750E50")]
		public PLIMGMHKPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2750E00", Offset = "0x2750000", VA = "0x182750E00", Slot = "11")]
		public override List<int> GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2750E20", Offset = "0x2750020", VA = "0x182750E20", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, List<int> ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class CBBCNAKCLNJ : Property<GJANDHHFHAL, List<GJANDHHFHAL.IDAMACGNMPH>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x274E7E0", Offset = "0x274D9E0", VA = "0x18274E7E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x274E7A0", Offset = "0x274D9A0", VA = "0x18274E7A0")]
		public CBBCNAKCLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x274E750", Offset = "0x274D950", VA = "0x18274E750", Slot = "11")]
		public override List<GJANDHHFHAL.IDAMACGNMPH> GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x274E770", Offset = "0x274D970", VA = "0x18274E770", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, List<GJANDHHFHAL.IDAMACGNMPH> ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class CFCHJPAHEEI : Property<GJANDHHFHAL, List<GJANDHHFHAL.OGEOIMOJEOE>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x274E8A0", Offset = "0x274DAA0", VA = "0x18274E8A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x274E860", Offset = "0x274DA60", VA = "0x18274E860")]
		public CFCHJPAHEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x274E810", Offset = "0x274DA10", VA = "0x18274E810", Slot = "11")]
		public override List<GJANDHHFHAL.OGEOIMOJEOE> GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x274E830", Offset = "0x274DA30", VA = "0x18274E830", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, List<GJANDHHFHAL.OGEOIMOJEOE> ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class JFGCJMAGKDJ : Property<GJANDHHFHAL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x27504B0", Offset = "0x274F6B0", VA = "0x1827504B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2750470", Offset = "0x274F670", VA = "0x182750470")]
		public JFGCJMAGKDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2750420", Offset = "0x274F620", VA = "0x182750420", Slot = "11")]
		public override GameObject GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2750440", Offset = "0x274F640", VA = "0x182750440", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, GameObject ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class INNAIMIHNGK : Property<GJANDHHFHAL, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2750010", Offset = "0x274F210", VA = "0x182750010", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x274FFD0", Offset = "0x274F1D0", VA = "0x18274FFD0")]
		public INNAIMIHNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x274FF80", Offset = "0x274F180", VA = "0x18274FF80", Slot = "11")]
		public override Light GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x274FFA0", Offset = "0x274F1A0", VA = "0x18274FFA0", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, Light ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class GCOJAPFLKOA : Property<GJANDHHFHAL, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x274F170", Offset = "0x274E370", VA = "0x18274F170", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x274F130", Offset = "0x274E330", VA = "0x18274F130")]
		public GCOJAPFLKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x274F0E0", Offset = "0x274E2E0", VA = "0x18274F0E0", Slot = "11")]
		public override Collider GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x274F100", Offset = "0x274E300", VA = "0x18274F100", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, Collider ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class CFHLIACBHEN : Property<GJANDHHFHAL, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x274E960", Offset = "0x274DB60", VA = "0x18274E960", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x274E920", Offset = "0x274DB20", VA = "0x18274E920")]
		public CFHLIACBHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x274E8D0", Offset = "0x274DAD0", VA = "0x18274E8D0", Slot = "11")]
		public override string GetValue(ref GJANDHHFHAL APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x274E8F0", Offset = "0x274DAF0", VA = "0x18274E8F0", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL APJAHLFEOEM, string ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2750040", Offset = "0x274F240", VA = "0x182750040")]
	public IOFKGFPEKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class LKKLHGKGKDG : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private class GOLCBMADCNC : Property<SerializableGuid, SerializableGuid.Data>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x274F4D0", Offset = "0x274E6D0", VA = "0x18274F4D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x274F490", Offset = "0x274E690", VA = "0x18274F490")]
		public GOLCBMADCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8DB280", Offset = "0x8DA480", VA = "0x1808DB280", Slot = "11")]
		public override SerializableGuid.Data GetValue(ref SerializableGuid APJAHLFEOEM)
		{
			return default(SerializableGuid.Data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1523140", Offset = "0x1522340", VA = "0x181523140", Slot = "12")]
		public override void SetValue(ref SerializableGuid APJAHLFEOEM, SerializableGuid.Data ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2750660", Offset = "0x274F860", VA = "0x182750660")]
	public LKKLHGKGKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class EHDLKIDFCFE : ContainerPropertyBag<SerializableGuid.Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private class FJAPEJJHFMC : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x274EFD0", Offset = "0x274E1D0", VA = "0x18274EFD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x274EF90", Offset = "0x274E190", VA = "0x18274EF90")]
		public FJAPEJJHFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x939480", Offset = "0x938680", VA = "0x180939480", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1520DB0", Offset = "0x151FFB0", VA = "0x181520DB0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class CLMIHHEFJAJ : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x274EC50", Offset = "0x274DE50", VA = "0x18274EC50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x274EC10", Offset = "0x274DE10", VA = "0x18274EC10")]
		public CLMIHHEFJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x152DAC0", Offset = "0x152CCC0", VA = "0x18152DAC0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x152DAD0", Offset = "0x152CCD0", VA = "0x18152DAD0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class PHGNBJPEJCH : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2750DD0", Offset = "0x274FFD0", VA = "0x182750DD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2750D90", Offset = "0x274FF90", VA = "0x182750D90")]
		public PHGNBJPEJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1530B40", Offset = "0x152FD40", VA = "0x181530B40", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1530B50", Offset = "0x152FD50", VA = "0x181530B50", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class KFHLEKHJAJE : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2750520", Offset = "0x274F720", VA = "0x182750520", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x27504E0", Offset = "0x274F6E0", VA = "0x1827504E0")]
		public KFHLEKHJAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x15309D0", Offset = "0x152FBD0", VA = "0x1815309D0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data APJAHLFEOEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x15309E0", Offset = "0x152FBE0", VA = "0x1815309E0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data APJAHLFEOEM, int ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x274ED50", Offset = "0x274DF50", VA = "0x18274ED50")]
	public EHDLKIDFCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal class LGPLLEGMLOM : ContainerPropertyBag<GJANDHHFHAL.IDAMACGNMPH>
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class FHKOLMBDLCD : Property<GJANDHHFHAL.IDAMACGNMPH, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x274EF60", Offset = "0x274E160", VA = "0x18274EF60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x274EF20", Offset = "0x274E120", VA = "0x18274EF20")]
		public FHKOLMBDLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x274EEE0", Offset = "0x274E0E0", VA = "0x18274EEE0", Slot = "11")]
		public override Vector3 GetValue(ref GJANDHHFHAL.IDAMACGNMPH APJAHLFEOEM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x274EF00", Offset = "0x274E100", VA = "0x18274EF00", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL.IDAMACGNMPH APJAHLFEOEM, Vector3 ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class HDMPJDJBEBI : Property<GJANDHHFHAL.IDAMACGNMPH, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x274F5F0", Offset = "0x274E7F0", VA = "0x18274F5F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x274F5B0", Offset = "0x274E7B0", VA = "0x18274F5B0")]
		public HDMPJDJBEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x274F590", Offset = "0x274E790", VA = "0x18274F590", Slot = "11")]
		public override List<SerializableGuid> GetValue(ref GJANDHHFHAL.IDAMACGNMPH APJAHLFEOEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x274F5A0", Offset = "0x274E7A0", VA = "0x18274F5A0", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL.IDAMACGNMPH APJAHLFEOEM, List<SerializableGuid> ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2750550", Offset = "0x274F750", VA = "0x182750550")]
	public LGPLLEGMLOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class CIMBABLADDD : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class BLENKOIJNDB : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x274E720", Offset = "0x274D920", VA = "0x18274E720", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x274E6E0", Offset = "0x274D8E0", VA = "0x18274E6E0")]
		public BLENKOIJNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x274E6C0", Offset = "0x274D8C0", VA = "0x18274E6C0", Slot = "11")]
		public override float GetValue(ref Vector3 APJAHLFEOEM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x274E6D0", Offset = "0x274D8D0", VA = "0x18274E6D0", Slot = "12")]
		public override void SetValue(ref Vector3 APJAHLFEOEM, float ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class HAJEOPMAONL : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x274F560", Offset = "0x274E760", VA = "0x18274F560", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x274F520", Offset = "0x274E720", VA = "0x18274F520")]
		public HAJEOPMAONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x274F500", Offset = "0x274E700", VA = "0x18274F500", Slot = "11")]
		public override float GetValue(ref Vector3 APJAHLFEOEM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x274F510", Offset = "0x274E710", VA = "0x18274F510", Slot = "12")]
		public override void SetValue(ref Vector3 APJAHLFEOEM, float ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private class IKMDLDOGEIO : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x274FD90", Offset = "0x274EF90", VA = "0x18274FD90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x274FD50", Offset = "0x274EF50", VA = "0x18274FD50")]
		public IKMDLDOGEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x274FD30", Offset = "0x274EF30", VA = "0x18274FD30", Slot = "11")]
		public override float GetValue(ref Vector3 APJAHLFEOEM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x274FD40", Offset = "0x274EF40", VA = "0x18274FD40", Slot = "12")]
		public override void SetValue(ref Vector3 APJAHLFEOEM, float ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x274EAD0", Offset = "0x274DCD0", VA = "0x18274EAD0")]
	public CIMBABLADDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class MJPCNCCFLEE : ContainerPropertyBag<GJANDHHFHAL.OGEOIMOJEOE>
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class FMJAGLBIMLF : Property<GJANDHHFHAL.OGEOIMOJEOE, GJANDHHFHAL.IDAMACGNMPH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string JPGOKIEGHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x274F0B0", Offset = "0x274E2B0", VA = "0x18274F0B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool BNGNOGOPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x274F070", Offset = "0x274E270", VA = "0x18274F070")]
		public FMJAGLBIMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x274F000", Offset = "0x274E200", VA = "0x18274F000", Slot = "11")]
		public override GJANDHHFHAL.IDAMACGNMPH GetValue(ref GJANDHHFHAL.OGEOIMOJEOE APJAHLFEOEM)
		{
			return default(GJANDHHFHAL.IDAMACGNMPH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x274F030", Offset = "0x274E230", VA = "0x18274F030", Slot = "12")]
		public override void SetValue(ref GJANDHHFHAL.OGEOIMOJEOE APJAHLFEOEM, GJANDHHFHAL.IDAMACGNMPH ADBNEBBHMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2750B10", Offset = "0x274FD10", VA = "0x182750B10")]
	public MJPCNCCFLEE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2750F00", Offset = "0x2750100", VA = "0x182750F00")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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
