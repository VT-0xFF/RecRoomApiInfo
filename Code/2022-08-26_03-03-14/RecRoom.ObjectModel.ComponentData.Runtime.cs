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
	[PAHCCKKDLOM(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LDFMEFPABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x357D3E0", Offset = "0x357BFE0", VA = "0x18357D3E0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[PAHCCKKDLOM(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[NMNIIILIOGO(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NMNIIILIOGO(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x57E4880", Offset = "0x57E3480", VA = "0x1857E4880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x101C4B0", Offset = "0x101B0B0", VA = "0x18101C4B0")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[PAHCCKKDLOM(1)]
	public struct AuthoredParentData : IComponentData, LDFMEFPABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[NMNIIILIOGO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57E48A0", Offset = "0x57E34A0", VA = "0x1857E48A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FPCEGCFLDMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LDLGNIMIDMK : ISystemStateComponentData, IComponentData, LDFMEFPABAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity ADPOFKEOFEN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity LLFBMCJPBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[InternalBufferCapacity(8)]
	[PAHCCKKDLOM(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LDFMEFPABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x357D3E0", Offset = "0x357BFE0", VA = "0x18357D3E0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
[EEGDGHMPONM(0, 15)]
public enum HBACPGGANIJ
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
[EEGDGHMPONM(0, 2)]
public enum BGDIOKOHEDH
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
	[NKGHJKEILFF("Container", 0)]
	[PAHCCKKDLOM(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[NMNIIILIOGO(1)]
		[ALCNAHEFLFH(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[NMNIIILIOGO(2)]
		[ALCNAHEFLFH(0)]
		public BGDIOKOHEDH collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(3)]
		public HBACPGGANIJ collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[NMNIIILIOGO(4)]
		[ALCNAHEFLFH(0)]
		public ABKGIMPMKPN grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(5)]
		public EFIPFMNBNEP flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[NMNIIILIOGO(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57E4AE0", Offset = "0x57E36E0", VA = "0x1857E4AE0", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
[EEGDGHMPONM(0, 16071)]
public enum EFIPFMNBNEP
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
[EEGDGHMPONM(0, 1)]
public enum ABKGIMPMKPN
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
[EJHDJBMEJKK(1)]
public struct FKHOENHGGLL : IComparable<FKHOENHGGLL>, IEquatable<FKHOENHGGLL>, MHGHNPKFAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[DEEGMHIGGBN(1)]
	public uint EEFOPJBCGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[DEEGMHIGGBN(2)]
	public uint JEFHPNGEBJL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint JPBABEIIANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57E58A0", Offset = "0x57E44A0", VA = "0x1857E58A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57E5970", Offset = "0x57E4570", VA = "0x1857E5970")]
	public FKHOENHGGLL(int EEFOPJBCGJP, int HHJCOLHHMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57E5970", Offset = "0x57E4570", VA = "0x1857E5970")]
	public FKHOENHGGLL(uint EEFOPJBCGJP, uint HHJCOLHHMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57E5850", Offset = "0x57E4450", VA = "0x1857E5850")]
	private static uint JPNIENMHNJL(uint FNKIIBFNLFB, uint EDLPJGEPJPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57E56C0", Offset = "0x57E42C0", VA = "0x1857E56C0", Slot = "4")]
	public int CompareTo(FKHOENHGGLL NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57E5770", Offset = "0x57E4370", VA = "0x1857E5770", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57E58B0", Offset = "0x57E44B0", VA = "0x1857E58B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57E5750", Offset = "0x57E4350", VA = "0x1857E5750", Slot = "5")]
	public bool Equals(FKHOENHGGLL NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57E5800", Offset = "0x57E4400", VA = "0x1857E5800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57E5640", Offset = "0x57E4240", VA = "0x1857E5640", Slot = "6")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57E56E0", Offset = "0x57E42E0", VA = "0x1857E56E0", Slot = "7")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57E5880", Offset = "0x57E4480", VA = "0x1857E5880")]
	public static bool NHPMPBNMAAP(FKHOENHGGLL MHNBAJMEABL, FKHOENHGGLL JEINCPEGPNH)
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
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		public static SerializableGuid GOPIOOMOEDD(Guid JLMDLFJCONJ)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57E78B0", Offset = "0x57E64B0", VA = "0x1857E78B0", Slot = "4")]
		public bool Equals(SerializableGuid NPKIIGGBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57E7890", Offset = "0x57E6490", VA = "0x1857E7890", Slot = "5")]
		public int CompareTo(SerializableGuid NPKIIGGBCCI)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CLDHNMCBBFL("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	[PAHCCKKDLOM(1)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[PAHCCKKDLOM(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[NMNIIILIOGO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[NMNIIILIOGO(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[EEGDGHMPONM(0, 4)]
public enum JLAGNLCEABL
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
	[PAHCCKKDLOM(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[NMNIIILIOGO(1)]
		public JLAGNLCEABL gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[PAHCCKKDLOM(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[NMNIIILIOGO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[NMNIIILIOGO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[NMNIIILIOGO(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[PAHCCKKDLOM(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[NMNIIILIOGO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[NMNIIILIOGO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[NMNIIILIOGO(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[NMNIIILIOGO(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NMNIIILIOGO(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[PAHCCKKDLOM(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[NMNIIILIOGO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[NMNIIILIOGO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[NMNIIILIOGO(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LDFMEFPABAI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity LHHBOIJJOCN
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
	[NKGHJKEILFF("Light", 0)]
	[PAHCCKKDLOM(1)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[PAHCCKKDLOM(1)]
	[NKGHJKEILFF("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[NMNIIILIOGO(1)]
		[ALCNAHEFLFH(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[PAHCCKKDLOM(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[PAHCCKKDLOM(1)]
	public struct ParentData : IComponentData, LDFMEFPABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[NMNIIILIOGO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GNFHMKOLIFD : ISystemStateComponentData, IComponentData, LDFMEFPABAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Entity ADPOFKEOFEN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity LLFBMCJPBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x93E270", Offset = "0x93CE70", VA = "0x18093E270", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EPONONFBHIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[EEGDGHMPONM(0, 4)]
public enum PNBJNIPAEOF
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
	[PAHCCKKDLOM(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[NMNIIILIOGO(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[NMNIIILIOGO(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[NMNIIILIOGO(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[NMNIIILIOGO(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[NMNIIILIOGO(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[NMNIIILIOGO(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[NMNIIILIOGO(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[NMNIIILIOGO(8)]
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
public struct CEJJHCLKOFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float3 PPELONMPOIC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly CEJJHCLKOFC KEBFNIGMDAM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[PAHCCKKDLOM(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[NMNIIILIOGO(1)]
		public OBBNEPBOPBE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[NMNIIILIOGO(2)]
		public JMNLBPDOCPJ scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DNADOFDJNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x57E50C0", Offset = "0x57E3CC0", VA = "0x1857E50C0")]
	public static OBBNEPBOPBE LFMPFEAFMAL(this OBBNEPBOPBE AJKANCOMGHN, JJHDDLJFOCE JANGOMFIKHC)
	{
		return default(OBBNEPBOPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57E5090", Offset = "0x57E3C90", VA = "0x1857E5090")]
	public static OBBNEPBOPBE JNIHJKFEBJI(this OBBNEPBOPBE AJKANCOMGHN, JJHDDLJFOCE JANGOMFIKHC)
	{
		return default(OBBNEPBOPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57E5070", Offset = "0x57E3C70", VA = "0x1857E5070")]
	public static OBBNEPBOPBE DEHOHFNEGEO(this OBBNEPBOPBE AJKANCOMGHN, JJHDDLJFOCE JANGOMFIKHC, bool INBOJIDPLPB)
	{
		return default(OBBNEPBOPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57E50A0", Offset = "0x57E3CA0", VA = "0x1857E50A0")]
	public static bool KECEEJAKCPI(this OBBNEPBOPBE AJKANCOMGHN, JJHDDLJFOCE JANGOMFIKHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum JJHDDLJFOCE
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
[EEGDGHMPONM(0, 16383)]
public enum OBBNEPBOPBE
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
[EJHDJBMEJKK(1)]
public struct JMNLBPDOCPJ : MHGHNPKFAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[DEEGMHIGGBN(1)]
	public bool BGCPHEKMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[DEEGMHIGGBN(2)]
	public float3 PMCKMAPPHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[DEEGMHIGGBN(3)]
	public float3 JMAAHOKBMFC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57E6330", Offset = "0x57E4F30", VA = "0x1857E6330", Slot = "5")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x57E6210", Offset = "0x57E4E10", VA = "0x1857E6210", Slot = "4")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[EJHDJBMEJKK(1)]
public struct GPILGPICAJM : MHGHNPKFAFL, IEquatable<GPILGPICAJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[DEEGMHIGGBN(1)]
	public int DJHPMDEHJMK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0")]
	public GPILGPICAJM(int DJHPMDEHJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x57E5D20", Offset = "0x57E4920", VA = "0x1857E5D20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x57E5CA0", Offset = "0x57E48A0", VA = "0x1857E5CA0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD8F730", Offset = "0xD8E330", VA = "0x180D8F730", Slot = "6")]
	public bool Equals(GPILGPICAJM NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22A2A70", Offset = "0x22A1670", VA = "0x1822A2A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57E5C70", Offset = "0x57E4870", VA = "0x1857E5C70", Slot = "5")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57E5C40", Offset = "0x57E4840", VA = "0x1857E5C40", Slot = "4")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[PAHCCKKDLOM(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[NMNIIILIOGO(1)]
		public GPILGPICAJM customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[EEGDGHMPONM(0, 1)]
public enum KOMBGIFPLPP
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
	[PAHCCKKDLOM(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[NMNIIILIOGO(1)]
		public KOMBGIFPLPP propType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[NKGHJKEILFF("Physics", 0)]
	[PAHCCKKDLOM(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[NMNIIILIOGO(1)]
		[ALCNAHEFLFH(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[PAHCCKKDLOM(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[NMNIIILIOGO(1)]
		public HNGFAHNAKGA shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[EEGDGHMPONM(-1, 18)]
public enum HNGFAHNAKGA
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
[EEGDGHMPONM(0, 2)]
public enum NLLNHNNMAMI
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
	[PAHCCKKDLOM(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[NMNIIILIOGO(1)]
		public NLLNHNNMAMI shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[PAHCCKKDLOM(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		[EEGDGHMPONM(0, 7)]
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
		[NMNIIILIOGO(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x57E7980", Offset = "0x57E6580", VA = "0x1857E7980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x57E7A00", Offset = "0x57E6600", VA = "0x1857E7A00")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[EJHDJBMEJKK(1)]
public struct DFJBBJNIPDN : MHGHNPKFAFL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	[EEGDGHMPONM(0, 7)]
	public enum DOEPKPCALNA
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
	[DEEGMHIGGBN(1)]
	public float ACJEIECEAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[DEEGMHIGGBN(2)]
	public int ENPKBKONFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[DEEGMHIGGBN(3)]
	public DOEPKPCALNA AJKANCOMGHN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PNCOOFJDHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x57E4DA0", Offset = "0x57E39A0", VA = "0x1857E4DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x57E4D20", Offset = "0x57E3920", VA = "0x1857E4D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PCEMOKCEOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x57E4E60", Offset = "0x57E3A60", VA = "0x1857E4E60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x57E4E20", Offset = "0x57E3A20", VA = "0x1857E4E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool AJGNDNFAMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x57E4C40", Offset = "0x57E3840", VA = "0x1857E4C40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57E4E40", Offset = "0x57E3A40", VA = "0x1857E4E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57E4D40", Offset = "0x57E3940", VA = "0x1857E4D40", Slot = "5")]
	public void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57E4CC0", Offset = "0x57E38C0", VA = "0x1857E4CC0", Slot = "4")]
	public void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[PAHCCKKDLOM(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[NMNIIILIOGO(1)]
		public DFJBBJNIPDN parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[PAHCCKKDLOM(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[NMNIIILIOGO(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[NMNIIILIOGO(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[NMNIIILIOGO(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[NMNIIILIOGO(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[NMNIIILIOGO(5)]
		public FKHOENHGGLL order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct CFLMDAHOOGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct IPHDBJNHIDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ECELCGMILON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BDCMCIJDHFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GIOPLGCIDEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GAKOBEDNLHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal struct KADHOJFHADO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct PDHADMJJNEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct KADJJKJODIN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[PAHCCKKDLOM(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[NMNIIILIOGO(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[NMNIIILIOGO(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[NMNIIILIOGO(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[PAHCCKKDLOM(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[NMNIIILIOGO(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[NMNIIILIOGO(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[NMNIIILIOGO(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[NMNIIILIOGO(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[NMNIIILIOGO(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[NMNIIILIOGO(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[NMNIIILIOGO(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[NMNIIILIOGO(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[NMNIIILIOGO(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[NMNIIILIOGO(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[NMNIIILIOGO(11)]
		public HNBFOAFMOMB mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[NMNIIILIOGO(12)]
		public FEPDEBCEOCG myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[NMNIIILIOGO(13)]
		public NNMHKHLNBEH myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[NMNIIILIOGO(14)]
		public JKHBEAKDPOP myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[NMNIIILIOGO(15)]
		public JBHGFFHHBHN myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[NMNIIILIOGO(16)]
		public LPNOFEJPLFL myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[NMNIIILIOGO(17)]
		public GGFBBDFCPGA myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[NMNIIILIOGO(18)]
		public ALLECKCCKGH myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[NMNIIILIOGO(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[NMNIIILIOGO(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[NMNIIILIOGO(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[NMNIIILIOGO(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum HNBFOAFMOMB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum FEPDEBCEOCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum NNMHKHLNBEH : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum JKHBEAKDPOP : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum JBHGFFHHBHN
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum LPNOFEJPLFL : uint
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum GGFBBDFCPGA : long
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum ALLECKCCKGH : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[PAHCCKKDLOM(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[PAHCCKKDLOM(1)]
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
	[PAHCCKKDLOM(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class BIMPINEADGD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct CILOLFJHMMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 HOJJHACNLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public List<SerializableGuid> EDHBEJENADA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CDIMOLDHAMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public CILOLFJHMMA LHHEFPICEBH;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CDIMOLDHAMD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public SerializableGuid MMMEMPGJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public List<int> LBAHKLCOPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<CILOLFJHMMA> KDBHBOCNBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public List<CDIMOLDHAMD> POCBGMCKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GameObject MHECAANKLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Light GOGJOCCKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Collider PCJIIECCPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public string DAEMBHBLFFP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public BIMPINEADGD()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[PAHCCKKDLOM(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[NMNIIILIOGO(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[PAHCCKKDLOM(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NMNIIILIOGO(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[NMNIIILIOGO(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x101C4B0", Offset = "0x101B0B0", VA = "0x18101C4B0")]
		public LocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[PAHCCKKDLOM(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[PAHCCKKDLOM(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x57E6820", Offset = "0x57E5420", VA = "0x1857E6820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[PAHCCKKDLOM(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[NMNIIILIOGO(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct DAJBKHGJPKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NIOLLIPEMNE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HIANDEDCLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x57E4BC0", Offset = "0x57E37C0", VA = "0x1857E4BC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x57E4BB0", Offset = "0x57E37B0", VA = "0x1857E4BB0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[PAHCCKKDLOM(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[NMNIIILIOGO(1)]
		public CKMFMOEAADO transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[NMNIIILIOGO(2)]
		public HCJIOPPKELK transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
[EEGDGHMPONM(0, 1)]
public enum CKMFMOEAADO
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
[EEGDGHMPONM(-2, 2)]
public enum HCJIOPPKELK
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
	[PAHCCKKDLOM(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[PAHCCKKDLOM(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x57E7B10", Offset = "0x57E6710", VA = "0x1857E7B10")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[PAHCCKKDLOM(1)]
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
[EEGDGHMPONM(1000, 7003)]
public enum CMECOJAJFAB
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
internal enum IGMLAAPOIJP
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
internal static class BIALGDOGHOG
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[PAHCCKKDLOM(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[NMNIIILIOGO(1)]
		public CMECOJAJFAB prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class PMAMLLCIPDP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x57E70A0", Offset = "0x57E5CA0", VA = "0x1857E70A0")]
	public static bool JLAEDNLFBME(this CMECOJAJFAB LIJLAEFJGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x57E70E0", Offset = "0x57E5CE0", VA = "0x1857E70E0")]
	public static string OCGLNLPHEPA(this CMECOJAJFAB LIJLAEFJGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x57E70C0", Offset = "0x57E5CC0", VA = "0x1857E70C0")]
	public static IFCMLGGILLI MDFJJHGEBIB(this CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(IFCMLGGILLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57E7090", Offset = "0x57E5C90", VA = "0x1857E7090")]
	internal static IGMLAAPOIJP BIEPMNJFNKJ(this IFCMLGGILLI EACFGECJPIC)
	{
		return default(IGMLAAPOIJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57E7070", Offset = "0x57E5C70", VA = "0x1857E7070")]
	internal static IGMLAAPOIJP BIEPMNJFNKJ(this CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(IGMLAAPOIJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EEGDGHMPONM(0, 7)]
public enum IFCMLGGILLI
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
	[PAHCCKKDLOM(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[NMNIIILIOGO(1)]
		public IFCMLGGILLI objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FGJLCINBMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57E5630", Offset = "0x57E4230", VA = "0x1857E5630")]
	public static bool IIEPIDENEMM(this IFCMLGGILLI EACFGECJPIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[EEGDGHMPONM(-1, 60)]
public enum HEIDOPLIFDP
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
[EEGDGHMPONM(-1, 31)]
public enum GGBPBHPAHHF
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
	[NKGHJKEILFF("Visual", 0)]
	[PAHCCKKDLOM(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[ALCNAHEFLFH(0)]
		[NMNIIILIOGO(1)]
		public HEIDOPLIFDP color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[NMNIIILIOGO(2)]
		[ALCNAHEFLFH(0)]
		public GGBPBHPAHHF material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[NMNIIILIOGO(3)]
		[ALCNAHEFLFH(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[NMNIIILIOGO(4)]
		[ALCNAHEFLFH(0)]
		public Vector3 uvOffset;
	}
}
namespace RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	internal class _RRAssemblyIndex : DGENKNGBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57E7DF0", Offset = "0x57E69F0", VA = "0x1857E7DF0", Slot = "4")]
		public sealed override void JHENDOAEKLB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class MOHLNODJMAG : ContainerPropertyBag<TestNonSerializedManagedData>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private class JINJALIELKA : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x57E61E0", Offset = "0x57E4DE0", VA = "0x1857E61E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57E61A0", Offset = "0x57E4DA0", VA = "0x1857E61A0")]
		public JINJALIELKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x39B70D0", Offset = "0x39B5CD0", VA = "0x1839B70D0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x57E6180", Offset = "0x57E4D80", VA = "0x1857E6180", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class PJHPIOOGIDG : Property<TestNonSerializedManagedData, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x57E7040", Offset = "0x57E5C40", VA = "0x1857E7040", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57E7000", Offset = "0x57E5C00", VA = "0x1857E7000")]
		public PJHPIOOGIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x57E6FC0", Offset = "0x57E5BC0", VA = "0x1857E6FC0", Slot = "11")]
		public override int GetValue(ref TestNonSerializedManagedData NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x57E6FE0", Offset = "0x57E5BE0", VA = "0x1857E6FE0", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class DPGBKJGFOAI : Property<TestNonSerializedManagedData, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x57E5140", Offset = "0x57E3D40", VA = "0x1857E5140", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57E5100", Offset = "0x57E3D00", VA = "0x1857E5100")]
		public DPGBKJGFOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x39B73B0", Offset = "0x39B5FB0", VA = "0x1839B73B0", Slot = "11")]
		public override GameObject GetValue(ref TestNonSerializedManagedData NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x57E50D0", Offset = "0x57E3CD0", VA = "0x1857E50D0", Slot = "12")]
		public override void SetValue(ref TestNonSerializedManagedData NBELCHPBKDK, GameObject KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x57E6B20", Offset = "0x57E5720", VA = "0x1857E6B20")]
	public MOHLNODJMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal class ELAIMJDGLEC : ContainerPropertyBag<BIMPINEADGD>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class FCCLCAGNNOI : Property<BIMPINEADGD, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x57E5600", Offset = "0x57E4200", VA = "0x1857E5600", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57E55C0", Offset = "0x57E41C0", VA = "0x1857E55C0")]
		public FCCLCAGNNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x57E5570", Offset = "0x57E4170", VA = "0x1857E5570", Slot = "11")]
		public override SerializableGuid GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x57E55A0", Offset = "0x57E41A0", VA = "0x1857E55A0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, SerializableGuid KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class HCPPPFHKBDG : Property<BIMPINEADGD, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x57E5DF0", Offset = "0x57E49F0", VA = "0x1857E5DF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57E5DB0", Offset = "0x57E49B0", VA = "0x1857E5DB0")]
		public HCPPPFHKBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D930", Offset = "0x3A5C530", VA = "0x183A5D930", Slot = "11")]
		public override List<int> GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x57E5D80", Offset = "0x57E4980", VA = "0x1857E5D80", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, List<int> KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class KPGMABHJGCD : Property<BIMPINEADGD, List<BIMPINEADGD.CILOLFJHMMA>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x57E6550", Offset = "0x57E5150", VA = "0x1857E6550", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x57E6510", Offset = "0x57E5110", VA = "0x1857E6510")]
		public KPGMABHJGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57E64C0", Offset = "0x57E50C0", VA = "0x1857E64C0", Slot = "11")]
		public override List<BIMPINEADGD.CILOLFJHMMA> GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x57E64E0", Offset = "0x57E50E0", VA = "0x1857E64E0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, List<BIMPINEADGD.CILOLFJHMMA> KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class FMPAHLMDLBB : Property<BIMPINEADGD, List<BIMPINEADGD.CDIMOLDHAMD>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x57E5A50", Offset = "0x57E4650", VA = "0x1857E5A50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57E5A10", Offset = "0x57E4610", VA = "0x1857E5A10")]
		public FMPAHLMDLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x57E59C0", Offset = "0x57E45C0", VA = "0x1857E59C0", Slot = "11")]
		public override List<BIMPINEADGD.CDIMOLDHAMD> GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x57E59E0", Offset = "0x57E45E0", VA = "0x1857E59E0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, List<BIMPINEADGD.CDIMOLDHAMD> KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private class NFKAPJPLALN : Property<BIMPINEADGD, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x57E6D60", Offset = "0x57E5960", VA = "0x1857E6D60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x57E6D20", Offset = "0x57E5920", VA = "0x1857E6D20")]
		public NFKAPJPLALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x57E6CD0", Offset = "0x57E58D0", VA = "0x1857E6CD0", Slot = "11")]
		public override GameObject GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x57E6CF0", Offset = "0x57E58F0", VA = "0x1857E6CF0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, GameObject KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class LJBJIIFCAPG : Property<BIMPINEADGD, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x57E6610", Offset = "0x57E5210", VA = "0x1857E6610", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x57E65D0", Offset = "0x57E51D0", VA = "0x1857E65D0")]
		public LJBJIIFCAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x57E6580", Offset = "0x57E5180", VA = "0x1857E6580", Slot = "11")]
		public override Light GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x57E65A0", Offset = "0x57E51A0", VA = "0x1857E65A0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, Light KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class CFDIMBODMOG : Property<BIMPINEADGD, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x57E4990", Offset = "0x57E3590", VA = "0x1857E4990", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57E4950", Offset = "0x57E3550", VA = "0x1857E4950")]
		public CFDIMBODMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x57E4900", Offset = "0x57E3500", VA = "0x1857E4900", Slot = "11")]
		public override Collider GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x57E4920", Offset = "0x57E3520", VA = "0x1857E4920", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, Collider KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class JBMFAKDDNIB : Property<BIMPINEADGD, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x57E6040", Offset = "0x57E4C40", VA = "0x1857E6040", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57E6000", Offset = "0x57E4C00", VA = "0x1857E6000")]
		public JBMFAKDDNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57E5FB0", Offset = "0x57E4BB0", VA = "0x1857E5FB0", Slot = "11")]
		public override string GetValue(ref BIMPINEADGD NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57E5FD0", Offset = "0x57E4BD0", VA = "0x1857E5FD0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD NBELCHPBKDK, string KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57E5290", Offset = "0x57E3E90", VA = "0x1857E5290")]
	public ELAIMJDGLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class DPNLGHKBPGN : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private class ANDEOHABEPG : Property<SerializableGuid, SerializableGuid.Data>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x57E47D0", Offset = "0x57E33D0", VA = "0x1857E47D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x57E4790", Offset = "0x57E3390", VA = "0x1857E4790")]
		public ANDEOHABEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2573880", Offset = "0x2572480", VA = "0x182573880", Slot = "11")]
		public override SerializableGuid.Data GetValue(ref SerializableGuid NBELCHPBKDK)
		{
			return default(SerializableGuid.Data);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x357D280", Offset = "0x357BE80", VA = "0x18357D280", Slot = "12")]
		public override void SetValue(ref SerializableGuid NBELCHPBKDK, SerializableGuid.Data KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x57E5170", Offset = "0x57E3D70", VA = "0x1857E5170")]
	public DPNLGHKBPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal class DMNODDOPMDK : ContainerPropertyBag<SerializableGuid.Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private class NBKLFOKIKGE : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x57E6CA0", Offset = "0x57E58A0", VA = "0x1857E6CA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x57E6C60", Offset = "0x57E5860", VA = "0x1857E6C60")]
		public NBKLFOKIKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xFBF6B0", Offset = "0xFBE2B0", VA = "0x180FBF6B0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x357AEF0", Offset = "0x3579AF0", VA = "0x18357AEF0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class EEFCANLMPDH : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x57E5260", Offset = "0x57E3E60", VA = "0x1857E5260", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x57E5220", Offset = "0x57E3E20", VA = "0x1857E5220")]
		public EEFCANLMPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3587BA0", Offset = "0x35867A0", VA = "0x183587BA0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3587BB0", Offset = "0x35867B0", VA = "0x183587BB0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class MDFHFDBFIDB : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x57E6AF0", Offset = "0x57E56F0", VA = "0x1857E6AF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x57E6AB0", Offset = "0x57E56B0", VA = "0x1857E6AB0")]
		public MDFHFDBFIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2276C00", Offset = "0x2275800", VA = "0x182276C00", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x358AC20", Offset = "0x3589820", VA = "0x18358AC20", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private class DCJBGEGHCFB : Property<SerializableGuid.Data, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x57E4C10", Offset = "0x57E3810", VA = "0x1857E4C10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x57E4BD0", Offset = "0x57E37D0", VA = "0x1857E4BD0")]
		public DCJBGEGHCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x358AAB0", Offset = "0x35896B0", VA = "0x18358AAB0", Slot = "11")]
		public override int GetValue(ref SerializableGuid.Data NBELCHPBKDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x358AAC0", Offset = "0x35896C0", VA = "0x18358AAC0", Slot = "12")]
		public override void SetValue(ref SerializableGuid.Data NBELCHPBKDK, int KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x57E4EE0", Offset = "0x57E3AE0", VA = "0x1857E4EE0")]
	public DMNODDOPMDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal class JGLKNDLNFCG : ContainerPropertyBag<BIMPINEADGD.CILOLFJHMMA>
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class IBBCKKFFNKE : Property<BIMPINEADGD.CILOLFJHMMA, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x57E5E80", Offset = "0x57E4A80", VA = "0x1857E5E80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x57E5E40", Offset = "0x57E4A40", VA = "0x1857E5E40")]
		public IBBCKKFFNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xFA2D50", Offset = "0xFA1950", VA = "0x180FA2D50", Slot = "11")]
		public override Vector3 GetValue(ref BIMPINEADGD.CILOLFJHMMA NBELCHPBKDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x57E5E20", Offset = "0x57E4A20", VA = "0x1857E5E20", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD.CILOLFJHMMA NBELCHPBKDK, Vector3 KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class CJIHBAEEEHH : Property<BIMPINEADGD.CILOLFJHMMA, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x57E4AB0", Offset = "0x57E36B0", VA = "0x1857E4AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x57E4A70", Offset = "0x57E3670", VA = "0x1857E4A70")]
		public CJIHBAEEEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x57E4A50", Offset = "0x57E3650", VA = "0x1857E4A50", Slot = "11")]
		public override List<SerializableGuid> GetValue(ref BIMPINEADGD.CILOLFJHMMA NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57E4A60", Offset = "0x57E3660", VA = "0x1857E4A60", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD.CILOLFJHMMA NBELCHPBKDK, List<SerializableGuid> KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57E6070", Offset = "0x57E4C70", VA = "0x1857E6070")]
	public JGLKNDLNFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class MDBAFFEBGJB : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class KPFFIDEDGMP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x57E6490", Offset = "0x57E5090", VA = "0x1857E6490", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x57E6450", Offset = "0x57E5050", VA = "0x1857E6450")]
		public KPFFIDEDGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x57E6430", Offset = "0x57E5030", VA = "0x1857E6430", Slot = "11")]
		public override float GetValue(ref Vector3 NBELCHPBKDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x57E6440", Offset = "0x57E5040", VA = "0x1857E6440", Slot = "12")]
		public override void SetValue(ref Vector3 NBELCHPBKDK, float KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class CHGPDEEIKOP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x57E4A20", Offset = "0x57E3620", VA = "0x1857E4A20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57E49E0", Offset = "0x57E35E0", VA = "0x1857E49E0")]
		public CHGPDEEIKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x57E49C0", Offset = "0x57E35C0", VA = "0x1857E49C0", Slot = "11")]
		public override float GetValue(ref Vector3 NBELCHPBKDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x57E49D0", Offset = "0x57E35D0", VA = "0x1857E49D0", Slot = "12")]
		public override void SetValue(ref Vector3 NBELCHPBKDK, float KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private class PDHGGEBFFII : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x57E6F90", Offset = "0x57E5B90", VA = "0x1857E6F90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57E6F50", Offset = "0x57E5B50", VA = "0x1857E6F50")]
		public PDHGGEBFFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1626020", Offset = "0x1624C20", VA = "0x181626020", Slot = "11")]
		public override float GetValue(ref Vector3 NBELCHPBKDK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x57E6F40", Offset = "0x57E5B40", VA = "0x1857E6F40", Slot = "12")]
		public override void SetValue(ref Vector3 NBELCHPBKDK, float KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x57E6970", Offset = "0x57E5570", VA = "0x1857E6970")]
	public MDBAFFEBGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class NLAHCCHHABN : ContainerPropertyBag<BIMPINEADGD.CDIMOLDHAMD>
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class AKDOPNPALKJ : Property<BIMPINEADGD.CDIMOLDHAMD, BIMPINEADGD.CILOLFJHMMA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x57E4760", Offset = "0x57E3360", VA = "0x1857E4760", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x57E4720", Offset = "0x57E3320", VA = "0x1857E4720")]
		public AKDOPNPALKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x57E46B0", Offset = "0x57E32B0", VA = "0x1857E46B0", Slot = "11")]
		public override BIMPINEADGD.CILOLFJHMMA GetValue(ref BIMPINEADGD.CDIMOLDHAMD NBELCHPBKDK)
		{
			return default(BIMPINEADGD.CILOLFJHMMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x57E46E0", Offset = "0x57E32E0", VA = "0x1857E46E0", Slot = "12")]
		public override void SetValue(ref BIMPINEADGD.CDIMOLDHAMD NBELCHPBKDK, BIMPINEADGD.CILOLFJHMMA KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x57E6D90", Offset = "0x57E5990", VA = "0x1857E6D90")]
	public NLAHCCHHABN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x57E71A0", Offset = "0x57E5DA0", VA = "0x1857E71A0")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
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
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
