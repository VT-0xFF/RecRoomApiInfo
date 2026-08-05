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
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[GHAHBJDLDII(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, OLKMAFNAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E27B20", Offset = "0x5E26320", VA = "0x185E27B20", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[GHAHBJDLDII(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[NBNKGMNPMDB(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NBNKGMNPMDB(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5E27B90", Offset = "0x5E26390", VA = "0x185E27B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1AED630", Offset = "0x1AEBE30", VA = "0x181AED630")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[GHAHBJDLDII(1)]
	public struct AuthoredParentData : IComponentData, OLKMAFNAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[NBNKGMNPMDB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E27BB0", Offset = "0x5E263B0", VA = "0x185E27BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KANIAOHNMNJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HDODHPJEEDH : ISystemStateComponentData, IComponentData, OLKMAFNAGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity EBPMEIILHEP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity FHBAFMAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[InternalBufferCapacity(8)]
	[GHAHBJDLDII(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, OLKMAFNAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E27B20", Offset = "0x5E26320", VA = "0x185E27B20", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[LNCEOKOADNK(0, 15)]
public enum HNDLKGPPICC
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
[LNCEOKOADNK(0, 2)]
public enum BDDMGDHFDCI
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
	[GHAHBJDLDII(1)]
	[HOOKOBANMNL("Container", 0)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(1)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[NBNKGMNPMDB(2)]
		[DKHEHKPEAHD(0)]
		public BDDMGDHFDCI collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[NBNKGMNPMDB(3)]
		[DKHEHKPEAHD(0)]
		public HNDLKGPPICC collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(4)]
		public OENFMNFOBOI grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[NBNKGMNPMDB(5)]
		[DKHEHKPEAHD(0)]
		public LKMLNDHMMOF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[NBNKGMNPMDB(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E28030", Offset = "0x5E26830", VA = "0x185E28030", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[LNCEOKOADNK(0, 16071)]
public enum LKMLNDHMMOF
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
[LNCEOKOADNK(0, 1)]
public enum OENFMNFOBOI
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
[AGKMDMHABLG(1)]
public struct EGEIGNKPPAL : IComparable<EGEIGNKPPAL>, IEquatable<EGEIGNKPPAL>, JAPJBKCPIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[CPCKKNFFHMG(1)]
	public uint DDGOMJJFJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[CPCKKNFFHMG(2)]
	public uint DFOIFCEOIFK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint GKDJOGKLPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E28180", Offset = "0x5E26980", VA = "0x185E28180")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E28440", Offset = "0x5E26C40", VA = "0x185E28440")]
	public EGEIGNKPPAL(int DDGOMJJFJHL, int GIPPIMBJGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E28440", Offset = "0x5E26C40", VA = "0x185E28440")]
	public EGEIGNKPPAL(uint DDGOMJJFJHL, uint GIPPIMBJGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E28260", Offset = "0x5E26A60", VA = "0x185E28260")]
	private static uint FIIPJLMNDKB(uint DOGOAAONBOH, uint ENHIJCCJFBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E28190", Offset = "0x5E26990", VA = "0x185E28190", Slot = "4")]
	public int CompareTo(EGEIGNKPPAL IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E281B0", Offset = "0x5E269B0", VA = "0x185E281B0", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E28360", Offset = "0x5E26B60", VA = "0x185E28360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E28240", Offset = "0x5E26A40", VA = "0x185E28240", Slot = "5")]
	public bool Equals(EGEIGNKPPAL IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E28290", Offset = "0x5E26A90", VA = "0x185E28290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E282E0", Offset = "0x5E26AE0", VA = "0x185E282E0", Slot = "6")]
	public void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E28110", Offset = "0x5E26910", VA = "0x185E28110", Slot = "7")]
	public void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2650", Offset = "0x1AC0E50", VA = "0x181AC2650")]
	public static bool CGFEPDNGNBJ(EGEIGNKPPAL CIMDKEEFACC, EGEIGNKPPAL LAFBLOLJEPD)
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
		[Cpp2IlInjected.Address(RVA = "0x765470", Offset = "0x763C70", VA = "0x180765470")]
		public static SerializableGuid EDIIAGKPKGG(Guid PMPGCMIMMLH)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E28F00", Offset = "0x5E27700", VA = "0x185E28F00", Slot = "4")]
		public bool Equals(SerializableGuid IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E28EE0", Offset = "0x5E276E0", VA = "0x185E28EE0", Slot = "5")]
		public int CompareTo(SerializableGuid IIKMMJKCGDO)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[GHAHBJDLDII(1)]
	[CMFHGIIPMDP("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[GHAHBJDLDII(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[NBNKGMNPMDB(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[NBNKGMNPMDB(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LNCEOKOADNK(0, 4)]
public enum BNFPHFLJIBP
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
	[GHAHBJDLDII(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[NBNKGMNPMDB(1)]
		public BNFPHFLJIBP gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[GHAHBJDLDII(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[NBNKGMNPMDB(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[NBNKGMNPMDB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[NBNKGMNPMDB(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[GHAHBJDLDII(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[NBNKGMNPMDB(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[NBNKGMNPMDB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[NBNKGMNPMDB(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[NBNKGMNPMDB(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NBNKGMNPMDB(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[GHAHBJDLDII(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[NBNKGMNPMDB(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[NBNKGMNPMDB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[NBNKGMNPMDB(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OLKMAFNAGAF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity FCMHICMIJCG
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
	[HOOKOBANMNL("Light", 0)]
	[GHAHBJDLDII(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[NBNKGMNPMDB(2)]
		[DKHEHKPEAHD(0)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[HOOKOBANMNL("Light", 0)]
	[GHAHBJDLDII(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[GHAHBJDLDII(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[GHAHBJDLDII(1)]
	public struct ParentData : IComponentData, OLKMAFNAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[NBNKGMNPMDB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IBNCHDDCFDM : ISystemStateComponentData, IComponentData, OLKMAFNAGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity EBPMEIILHEP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity FHBAFMAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7649C0", Offset = "0x7631C0", VA = "0x1807649C0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OJMGOMNBCIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[LNCEOKOADNK(0, 4)]
public enum FGGMFADEPDL
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
	[GHAHBJDLDII(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[NBNKGMNPMDB(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[NBNKGMNPMDB(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[NBNKGMNPMDB(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[NBNKGMNPMDB(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[NBNKGMNPMDB(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[NBNKGMNPMDB(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[NBNKGMNPMDB(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[NBNKGMNPMDB(8)]
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
public struct NOPNMMPBCNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 FBDEMBLCHNI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly NOPNMMPBCNL PJLEDACBOPG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[GHAHBJDLDII(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[NBNKGMNPMDB(1)]
		public EOBEDFCNIJE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[NBNKGMNPMDB(2)]
		public GMFEEELKMNP scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HOMCHHNBFLM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E28940", Offset = "0x5E27140", VA = "0x185E28940")]
	public static EOBEDFCNIJE CEMPCIEDPMO(this EOBEDFCNIJE ALKHBOMOJMO, FEJLNCDFKKF FGAAFLEJHAO)
	{
		return default(EOBEDFCNIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E28930", Offset = "0x5E27130", VA = "0x185E28930")]
	public static EOBEDFCNIJE ADDEDGCCJIP(this EOBEDFCNIJE ALKHBOMOJMO, FEJLNCDFKKF FGAAFLEJHAO)
	{
		return default(EOBEDFCNIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E28950", Offset = "0x5E27150", VA = "0x185E28950")]
	public static EOBEDFCNIJE DCFGDHMFNEP(this EOBEDFCNIJE ALKHBOMOJMO, FEJLNCDFKKF FGAAFLEJHAO, bool JDGAOKBHEFE)
	{
		return default(EOBEDFCNIJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E28910", Offset = "0x5E27110", VA = "0x185E28910")]
	public static bool AABCHIPMCCC(this EOBEDFCNIJE ALKHBOMOJMO, FEJLNCDFKKF FGAAFLEJHAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FEJLNCDFKKF
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
[LNCEOKOADNK(0, 16383)]
public enum EOBEDFCNIJE
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
[AGKMDMHABLG(1)]
public struct GMFEEELKMNP : JAPJBKCPIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CPCKKNFFHMG(1)]
	public bool CNKCPFJNMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[CPCKKNFFHMG(2)]
	public float3 ALFKEIMCIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[CPCKKNFFHMG(3)]
	public float3 PINKDMFEJGF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E286D0", Offset = "0x5E26ED0", VA = "0x185E286D0", Slot = "5")]
	public void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E287D0", Offset = "0x5E26FD0", VA = "0x185E287D0", Slot = "4")]
	public void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AGKMDMHABLG(1)]
public struct EIGCJOLCLNC : JAPJBKCPIOB, IEquatable<EIGCJOLCLNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CPCKKNFFHMG(1)]
	public int DGFBLJMJMFI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0")]
	public EIGCJOLCLNC(int DGFBLJMJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E28540", Offset = "0x5E26D40", VA = "0x185E28540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E284C0", Offset = "0x5E26CC0", VA = "0x185E284C0", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x816EF0", Offset = "0x8156F0", VA = "0x180816EF0", Slot = "6")]
	public bool Equals(EIGCJOLCLNC IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x163E950", Offset = "0x163D150", VA = "0x18163E950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E28490", Offset = "0x5E26C90", VA = "0x185E28490", Slot = "5")]
	public void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E285B0", Offset = "0x5E26DB0", VA = "0x185E285B0", Slot = "4")]
	public void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[GHAHBJDLDII(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[NBNKGMNPMDB(1)]
		public EIGCJOLCLNC customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LNCEOKOADNK(0, 1)]
public enum AODJOCFAFBC
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
	[GHAHBJDLDII(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[NBNKGMNPMDB(1)]
		public AODJOCFAFBC propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[GHAHBJDLDII(1)]
	[HOOKOBANMNL("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[NBNKGMNPMDB(1)]
		[DKHEHKPEAHD(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[GHAHBJDLDII(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[NBNKGMNPMDB(1)]
		public KOILODOMKMM shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LNCEOKOADNK(-1, 18)]
public enum KOILODOMKMM
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
[LNCEOKOADNK(0, 2)]
public enum NFNNCKINGNH
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
	[GHAHBJDLDII(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[NBNKGMNPMDB(1)]
		public NFNNCKINGNH shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[GHAHBJDLDII(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[LNCEOKOADNK(0, 7)]
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
		[NBNKGMNPMDB(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5E28FD0", Offset = "0x5E277D0", VA = "0x185E28FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5E29050", Offset = "0x5E27850", VA = "0x185E29050")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AGKMDMHABLG(1)]
public struct COJILPPCMFJ : JAPJBKCPIOB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[LNCEOKOADNK(0, 7)]
	public enum GBOKBNLENKC
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
	[CPCKKNFFHMG(1)]
	public float CDLKKBDOKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CPCKKNFFHMG(2)]
	public int HHJCJIPMBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[CPCKKNFFHMG(3)]
	public GBOKBNLENKC ALKHBOMOJMO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HLPPOIIJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E27F90", Offset = "0x5E26790", VA = "0x185E27F90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E28010", Offset = "0x5E26810", VA = "0x185E28010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FPFDMIHCDND
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E27F10", Offset = "0x5E26710", VA = "0x185E27F10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E27E10", Offset = "0x5E26610", VA = "0x185E27E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KHJFFGEGNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E27E30", Offset = "0x5E26630", VA = "0x185E27E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E27DF0", Offset = "0x5E265F0", VA = "0x185E27DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E27D90", Offset = "0x5E26590", VA = "0x185E27D90", Slot = "5")]
	public void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E27EB0", Offset = "0x5E266B0", VA = "0x185E27EB0", Slot = "4")]
	public void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[GHAHBJDLDII(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[NBNKGMNPMDB(1)]
		public COJILPPCMFJ parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[GHAHBJDLDII(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[NBNKGMNPMDB(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[NBNKGMNPMDB(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[NBNKGMNPMDB(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[NBNKGMNPMDB(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[NBNKGMNPMDB(5)]
		public EGEIGNKPPAL order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct BMIMCLOBNPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct MNNEIAHDBGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct AELMBJGAMNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JAEHIMJEDGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct IBEGNJBHFBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct CMKDAPAMLON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal struct NBHLBGLKKKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct GLJNFILDIDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct MGBPOLEKKNF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[GHAHBJDLDII(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[NBNKGMNPMDB(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[NBNKGMNPMDB(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[NBNKGMNPMDB(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[GHAHBJDLDII(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[NBNKGMNPMDB(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[NBNKGMNPMDB(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[NBNKGMNPMDB(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[NBNKGMNPMDB(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[NBNKGMNPMDB(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[NBNKGMNPMDB(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[NBNKGMNPMDB(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[NBNKGMNPMDB(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[NBNKGMNPMDB(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[NBNKGMNPMDB(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[NBNKGMNPMDB(11)]
		public JGBGELLHAKB mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[NBNKGMNPMDB(12)]
		public JKFGEBLNJIK myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[NBNKGMNPMDB(13)]
		public IBOOLOHFKOA myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[NBNKGMNPMDB(14)]
		public KCPDBFOAOHC myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[NBNKGMNPMDB(15)]
		public CHEMJBPCBPD myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[NBNKGMNPMDB(16)]
		public CHEMAIMBECJ myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[NBNKGMNPMDB(17)]
		public FNGPHGPMJKI myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[NBNKGMNPMDB(18)]
		public GBKFJOKLEEN myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[NBNKGMNPMDB(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[NBNKGMNPMDB(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[NBNKGMNPMDB(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[NBNKGMNPMDB(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum JGBGELLHAKB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum JKFGEBLNJIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum IBOOLOHFKOA : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum KCPDBFOAOHC : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum CHEMJBPCBPD
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum CHEMAIMBECJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum FNGPHGPMJKI : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum GBKFJOKLEEN : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[GHAHBJDLDII(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[GHAHBJDLDII(1)]
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
	[GHAHBJDLDII(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class BMHNKGJHMIN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct KHFJBKDIMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Vector3 DAGENFJHHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<SerializableGuid> LADIBLAAAEC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class EIPIBLEFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EIPIBLEFAFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BMHNKGJHMIN()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[GHAHBJDLDII(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[NBNKGMNPMDB(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[GHAHBJDLDII(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[NBNKGMNPMDB(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[NBNKGMNPMDB(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1AED630", Offset = "0x1AEBE30", VA = "0x181AED630")]
		public LocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[GHAHBJDLDII(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[GHAHBJDLDII(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E28C20", Offset = "0x5E27420", VA = "0x185E28C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[GHAHBJDLDII(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[NBNKGMNPMDB(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct GMNCMFEFGOD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HPIHFBFHBGK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MMABPPDCBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E28900", Offset = "0x5E27100", VA = "0x185E28900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E288F0", Offset = "0x5E270F0", VA = "0x185E288F0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[GHAHBJDLDII(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[NBNKGMNPMDB(1)]
		public HAOHDLBBHBN transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[NBNKGMNPMDB(2)]
		public LCOKFFPAELO transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
[LNCEOKOADNK(0, 1)]
public enum HAOHDLBBHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LNCEOKOADNK(-2, 2)]
public enum LCOKFFPAELO
{
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[GHAHBJDLDII(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[GHAHBJDLDII(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E29170", Offset = "0x5E27970", VA = "0x185E29170")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[GHAHBJDLDII(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[LNCEOKOADNK(1000, 7003)]
public enum IOFCPOJDKFL
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	COUNT = 7004,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MAX = 7003
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal enum IDIDNBJGBKM
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	GameObject = 7000
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal static class LMOFHHCMPCG
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[GHAHBJDLDII(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[NBNKGMNPMDB(1)]
		public IOFCPOJDKFL prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class FEOGJJGIKOM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E286B0", Offset = "0x5E26EB0", VA = "0x185E286B0")]
	public static bool LGBLJCGFKEG(this IOFCPOJDKFL BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E28630", Offset = "0x5E26E30", VA = "0x185E28630")]
	public static string EKJLAAEHEOA(this IOFCPOJDKFL BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E28610", Offset = "0x5E26E10", VA = "0x185E28610")]
	public static DMDFKHMLDPI DFEMBKDBHPB(this IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E285E0", Offset = "0x5E26DE0", VA = "0x185E285E0")]
	internal static IDIDNBJGBKM BNJHLPOEFAE(this DMDFKHMLDPI FFJCFOLGEHC)
	{
		return default(IDIDNBJGBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E285F0", Offset = "0x5E26DF0", VA = "0x185E285F0")]
	internal static IDIDNBJGBKM BNJHLPOEFAE(this IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(IDIDNBJGBKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[LNCEOKOADNK(0, 7)]
public enum DMDFKHMLDPI
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	COUNT = 8,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MAX = 7
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[GHAHBJDLDII(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[NBNKGMNPMDB(1)]
		public DMDFKHMLDPI objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class ANFHEJBKNJL
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E27B10", Offset = "0x5E26310", VA = "0x185E27B10")]
	public static bool FHMOACBGLLI(this DMDFKHMLDPI FFJCFOLGEHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[LNCEOKOADNK(-1, 60)]
public enum HCGPNBKPGJD
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	MAX = 60,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LNCEOKOADNK(-1, 31)]
public enum JCIEKPCHCBO
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[GHAHBJDLDII(1)]
	[HOOKOBANMNL("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(1)]
		public HCGPNBKPGJD color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(2)]
		public JCIEKPCHCBO material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[DKHEHKPEAHD(0)]
		[NBNKGMNPMDB(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[NBNKGMNPMDB(4)]
		[DKHEHKPEAHD(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	internal class _RRAssemblyIndex : NBDBIEGIKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E294C0", Offset = "0x5E27CC0", VA = "0x185E294C0", Slot = "4")]
		public sealed override void LAFCMKKIOHM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
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
