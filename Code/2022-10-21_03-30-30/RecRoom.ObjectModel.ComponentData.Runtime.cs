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
	[ECCAJNNDEJN(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2C60", Offset = "0x5DD1A60", VA = "0x185DD2C60", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ECCAJNNDEJN(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[FIEEHAEDALA(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[FIEEHAEDALA(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5DD2CD0", Offset = "0x5DD1AD0", VA = "0x185DD2CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xE27480", Offset = "0xE26280", VA = "0x180E27480")]
		public AuthoredLocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[ECCAJNNDEJN(1)]
	public struct AuthoredParentData : IComponentData, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[FIEEHAEDALA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2CF0", Offset = "0x5DD1AF0", VA = "0x185DD2CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BAODGLPKBEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HDLOBHOIHNH : ISystemStateComponentData, IComponentData, LJBPPGAHFFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Entity BOCLIMGIBAG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity POJNHNBPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "5")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ECCAJNNDEJN(1)]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2C60", Offset = "0x5DD1A60", VA = "0x185DD2C60", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[KCNAIFFDIPN(1)]
	[ECCAJNNDEJN(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[FIEEHAEDALA(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x15465A0", Offset = "0x15453A0", VA = "0x1815465A0")]
		public static implicit operator ObjectBoardNodeData(Guid guid)
		{
			return default(ObjectBoardNodeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
[IFEFAIBODLP(0, 15)]
public enum EJDHEEADKLA
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	All = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[IFEFAIBODLP(0, 2)]
public enum DIKLPAFDBGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DNKAAMBGEFF("Container", 0)]
	[ECCAJNNDEJN(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[FIEEHAEDALA(1)]
		[NBIFHADAKEO(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(2)]
		public DIKLPAFDBGJ collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(3)]
		public EJDHEEADKLA collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(4)]
		public NDPILNHJJLC grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(5)]
		public AGIBDFHOBNC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[FIEEHAEDALA(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2F10", Offset = "0x5DD1D10", VA = "0x185DD2F10", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Flags]
[IFEFAIBODLP(0, 16071)]
public enum AGIBDFHOBNC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	IsGrabbable = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	All = 0x3EC7,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MAX = 0x3EC7
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[IFEFAIBODLP(0, 1)]
public enum NDPILNHJJLC
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KCNAIFFDIPN(1)]
public struct IKCEHNKIMLA : IComparable<IKCEHNKIMLA>, IEquatable<IKCEHNKIMLA>, KCJNPCKFNOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[NNANKFHOMJK(1)]
	public uint DKLEMCPNHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[NNANKFHOMJK(2)]
	public uint MPPEDMFCGJL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private uint HDKNAGCBIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DD30A0", Offset = "0x5DD1EA0", VA = "0x185DD30A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3330", Offset = "0x5DD2130", VA = "0x185DD3330")]
	public IKCEHNKIMLA(int DKLEMCPNHLO, int EOCNPLIAPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3330", Offset = "0x5DD2130", VA = "0x185DD3330")]
	public IKCEHNKIMLA(uint DKLEMCPNHLO, uint EOCNPLIAPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3220", Offset = "0x5DD2020", VA = "0x185DD3220")]
	private static uint IJFIAACNFKL(uint BMPDKJEHGIN, uint BMMLDIMMAAK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3000", Offset = "0x5DD1E00", VA = "0x185DD3000", Slot = "4")]
	public int CompareTo(IKCEHNKIMLA HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DD30B0", Offset = "0x5DD1EB0", VA = "0x185DD30B0", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3250", Offset = "0x5DD2050", VA = "0x185DD3250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3140", Offset = "0x5DD1F40", VA = "0x185DD3140", Slot = "5")]
	public bool Equals(IKCEHNKIMLA HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3160", Offset = "0x5DD1F60", VA = "0x185DD3160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3020", Offset = "0x5DD1E20", VA = "0x185DD3020", Slot = "6")]
	public void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD31B0", Offset = "0x5DD1FB0", VA = "0x185DD31B0", Slot = "7")]
	public void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAD9780", Offset = "0xAD8580", VA = "0x180AD9780")]
	public static bool CJJJLAGEFIA(IKCEHNKIMLA EHPOMDFBCKH, IKCEHNKIMLA DJPDMBCBGFI)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[KCNAIFFDIPN(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[NNANKFHOMJK(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[NNANKFHOMJK(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[NNANKFHOMJK(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[NNANKFHOMJK(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[KCNAIFFDIPN(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, KCJNPCKFNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[NNANKFHOMJK(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x15465A0", Offset = "0x15453A0", VA = "0x1815465A0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15465A0", Offset = "0x15453A0", VA = "0x1815465A0")]
		public static SerializableGuid PAAEKNCKHBI(Guid AJPBBJHOAOB)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4050", Offset = "0x5DD2E50", VA = "0x185DD4050", Slot = "4")]
		public bool Equals(SerializableGuid HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3F30", Offset = "0x5DD2D30", VA = "0x185DD3F30", Slot = "5")]
		public int CompareTo(SerializableGuid HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3F50", Offset = "0x5DD2D50", VA = "0x185DD3F50", Slot = "6")]
		public void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DD40E0", Offset = "0x5DD2EE0", VA = "0x185DD40E0", Slot = "7")]
		public void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ECCAJNNDEJN(1)]
	[GBPGKDKEBMI("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ECCAJNNDEJN(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[FIEEHAEDALA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[FIEEHAEDALA(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[IFEFAIBODLP(0, 4)]
public enum EFCIKLEKING
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ECCAJNNDEJN(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[FIEEHAEDALA(1)]
		public EFCIKLEKING gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ECCAJNNDEJN(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[FIEEHAEDALA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[FIEEHAEDALA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[FIEEHAEDALA(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[ECCAJNNDEJN(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[FIEEHAEDALA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[FIEEHAEDALA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[FIEEHAEDALA(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[FIEEHAEDALA(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[FIEEHAEDALA(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ECCAJNNDEJN(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[FIEEHAEDALA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[FIEEHAEDALA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[FIEEHAEDALA(3)]
		public float speed;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LJBPPGAHFFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Entity MINMLEDGPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ECCAJNNDEJN(1)]
	[DNKAAMBGEFF("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[FIEEHAEDALA(1)]
		[NBIFHADAKEO(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DNKAAMBGEFF("Light", 0)]
	[ECCAJNNDEJN(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[FIEEHAEDALA(1)]
		[NBIFHADAKEO(0)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ECCAJNNDEJN(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ECCAJNNDEJN(1)]
	public struct ParentData : IComponentData, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[FIEEHAEDALA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HHCGCCCMOPE : ISystemStateComponentData, IComponentData, LJBPPGAHFFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity BOCLIMGIBAG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity POJNHNBPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990")]
	public HHCGCCCMOPE(Entity ADECAOLBLPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static HHCGCCCMOPE PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(HHCGCCCMOPE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KKLIIHKDOLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[IFEFAIBODLP(0, 4)]
public enum BHMOAFLHLMA
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[ECCAJNNDEJN(1)]
	public struct InertialPropertiesData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[FIEEHAEDALA(1)]
		public float3 localCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[FIEEHAEDALA(2)]
		public float3 inertialTensorDiagonal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[FIEEHAEDALA(3)]
		public quaternion interialTensorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[FIEEHAEDALA(4)]
		public float mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[FIEEHAEDALA(5)]
		public float drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[FIEEHAEDALA(6)]
		public float angularDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[FIEEHAEDALA(7)]
		public bool useGravity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[FIEEHAEDALA(8)]
		public CollisionDetectionMode collisionDetectionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool isKinematic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Vector3 localVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector3 localAngularVelocity;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly InertialPropertiesData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CAJJCLKLGOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float3 BOMEDIENHNL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly CAJJCLKLGOM FOBBLKPOGAD;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AMKIDOCJKAP]
internal struct CMNLENIHOOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity GEEFHDFLBEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static CMNLENIHOOJ PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(CMNLENIHOOJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BLHDIOPAIBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GLKHLJKPFKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int BCGICHENIFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LLAKENEBCBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HEMEHLBJFKC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ECCAJNNDEJN(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[FIEEHAEDALA(1)]
		public BIHKHBLILNE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[FIEEHAEDALA(2)]
		public PHKEACPHAED scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BMCCKAPKLLO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E80", Offset = "0x5DD1C80", VA = "0x185DD2E80")]
	public static BIHKHBLILNE HEFJCCLOLGO(this BIHKHBLILNE IDKBHBKJHPJ, FPIGOLLMEGI LOAFEMFAKGN)
	{
		return default(BIHKHBLILNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E50", Offset = "0x5DD1C50", VA = "0x185DD2E50")]
	public static BIHKHBLILNE AKJLIPOIGHF(this BIHKHBLILNE IDKBHBKJHPJ, FPIGOLLMEGI LOAFEMFAKGN)
	{
		return default(BIHKHBLILNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E60", Offset = "0x5DD1C60", VA = "0x185DD2E60")]
	public static BIHKHBLILNE AKLGBBHKCJB(this BIHKHBLILNE IDKBHBKJHPJ, FPIGOLLMEGI LOAFEMFAKGN, bool PDCNOOLALLC)
	{
		return default(BIHKHBLILNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E90", Offset = "0x5DD1C90", VA = "0x185DD2E90")]
	public static bool JJNDFHOJFBL(this BIHKHBLILNE IDKBHBKJHPJ, FPIGOLLMEGI LOAFEMFAKGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum FPIGOLLMEGI
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
[IFEFAIBODLP(0, 16383)]
public enum BIHKHBLILNE
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KCNAIFFDIPN(1)]
public struct PHKEACPHAED : KCJNPCKFNOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[NNANKFHOMJK(1)]
	public bool JBAGPIKPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NNANKFHOMJK(2)]
	public float3 FHJIOIOMCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NNANKFHOMJK(3)]
	public float3 IABENMIGIHN;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3DF0", Offset = "0x5DD2BF0", VA = "0x185DD3DF0", Slot = "5")]
	public void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3CD0", Offset = "0x5DD2AD0", VA = "0x185DD3CD0", Slot = "4")]
	public void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KCNAIFFDIPN(1)]
public struct BFFEIPJHCFH : KCJNPCKFNOM, IEquatable<BFFEIPJHCFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NNANKFHOMJK(1)]
	public int FCDKMJOKGIE;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xC46420", Offset = "0xC45220", VA = "0x180C46420")]
	public BFFEIPJHCFH(int FCDKMJOKGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2DB0", Offset = "0x5DD1BB0", VA = "0x185DD2DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2D30", Offset = "0x5DD1B30", VA = "0x185DD2D30", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xB9F510", Offset = "0xB9E310", VA = "0x180B9F510", Slot = "6")]
	public bool Equals(BFFEIPJHCFH HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16C79C0", Offset = "0x16C67C0", VA = "0x1816C79C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E20", Offset = "0x5DD1C20", VA = "0x185DD2E20", Slot = "5")]
	public void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2D00", Offset = "0x5DD1B00", VA = "0x185DD2D00", Slot = "4")]
	public void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[ECCAJNNDEJN(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[FIEEHAEDALA(1)]
		public BFFEIPJHCFH customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[IFEFAIBODLP(0, 1)]
public enum DHKLKGCIPPD
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ECCAJNNDEJN(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[FIEEHAEDALA(1)]
		public DHKLKGCIPPD propType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[ECCAJNNDEJN(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[FIEEHAEDALA(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal struct IOLJBFFLLIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity GEEFHDFLBEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static IOLJBFFLLIE PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(IOLJBFFLLIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal struct ILBMMJPLGBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Entity MFCBHLNDHNI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static ILBMMJPLGBL PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(ILBMMJPLGBL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal struct PNHKNOHMEKB : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[DNKAAMBGEFF("Physics", 0)]
	[ECCAJNNDEJN(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[ECCAJNNDEJN(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[FIEEHAEDALA(1)]
		public FEJKANODFOG shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IFEFAIBODLP(-1, 18)]
public enum FEJKANODFOG
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	LegacyWedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	LegacyPyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	COUNT = 19,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	MAX = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MIN = -1
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IFEFAIBODLP(0, 2)]
public enum MEHCJFAHHNG
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ECCAJNNDEJN(1)]
	public struct RenderableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[FIEEHAEDALA(1)]
		public MEHCJFAHHNG shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ECCAJNNDEJN(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[Flags]
		[IFEFAIBODLP(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[FIEEHAEDALA(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5DD41A0", Offset = "0x5DD2FA0", VA = "0x185DD41A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5DD4220", Offset = "0x5DD3020", VA = "0x185DD4220")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KCNAIFFDIPN(1)]
public struct LGKIAKCMDGO : KCJNPCKFNOM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Flags]
	[IFEFAIBODLP(0, 7)]
	public enum LBHJNIIJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[NNANKFHOMJK(1)]
	public float HHOLIIPNAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[NNANKFHOMJK(2)]
	public int CHDPGFAPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NNANKFHOMJK(3)]
	public LBHJNIIJMGK IDKBHBKJHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FKIKKPGIGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3730", Offset = "0x5DD2530", VA = "0x185DD3730")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3590", Offset = "0x5DD2390", VA = "0x185DD3590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PPJMPLPOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3670", Offset = "0x5DD2470", VA = "0x185DD3670")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3710", Offset = "0x5DD2510", VA = "0x185DD3710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BIPIDANGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD37B0", Offset = "0x5DD25B0", VA = "0x185DD37B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5DD36F0", Offset = "0x5DD24F0", VA = "0x185DD36F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3610", Offset = "0x5DD2410", VA = "0x185DD3610", Slot = "5")]
	public void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DD35B0", Offset = "0x5DD23B0", VA = "0x185DD35B0", Slot = "4")]
	public void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ECCAJNNDEJN(1)]
	public struct SplineData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[FIEEHAEDALA(1)]
		public LGKIAKCMDGO parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ECCAJNNDEJN(1)]
	public struct SplinePointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[FIEEHAEDALA(1)]
		public Entity spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[FIEEHAEDALA(2)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[FIEEHAEDALA(3)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[FIEEHAEDALA(4)]
		public float3 localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[FIEEHAEDALA(5)]
		public IKCEHNKIMLA order;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct EAGOFGFHFAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal struct FKEAHJHDCHG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal struct OJIIFFMJHEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal struct EILCDGAAILO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal struct GHPEDNEJKIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CEHFHPLEHDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IFDGPDBMGEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MBLFOFPCPBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct DBMDLLBHCCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct GGDHNMAPAGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct LGPDLCPKLCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct FHJAIHIHEFP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[ECCAJNNDEJN(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[FIEEHAEDALA(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[FIEEHAEDALA(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[FIEEHAEDALA(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[ECCAJNNDEJN(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[FIEEHAEDALA(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[FIEEHAEDALA(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[FIEEHAEDALA(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[FIEEHAEDALA(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[FIEEHAEDALA(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[FIEEHAEDALA(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[FIEEHAEDALA(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[FIEEHAEDALA(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[FIEEHAEDALA(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[FIEEHAEDALA(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[FIEEHAEDALA(11)]
		public EABCNCAKACM mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[FIEEHAEDALA(12)]
		public FAIPKJMECGI myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[FIEEHAEDALA(13)]
		public GOKAFDAONLH myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[FIEEHAEDALA(14)]
		public IFOCEPPEHOM myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[FIEEHAEDALA(15)]
		public BDEPBLJAIAD myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[FIEEHAEDALA(16)]
		public HDDIPPKLCJA myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[FIEEHAEDALA(17)]
		public AEJHEDIKMAL myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[FIEEHAEDALA(18)]
		public BLPPBIGNHII myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[FIEEHAEDALA(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[FIEEHAEDALA(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[FIEEHAEDALA(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[FIEEHAEDALA(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum EABCNCAKACM : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum FAIPKJMECGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum GOKAFDAONLH : short
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum IFOCEPPEHOM : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum BDEPBLJAIAD
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum HDDIPPKLCJA : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum AEJHEDIKMAL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum BLPPBIGNHII : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[ECCAJNNDEJN(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[ECCAJNNDEJN(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[ECCAJNNDEJN(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class KOFPPLLKPCD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct CDKCGENLPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Vector3 AGGELNOICKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<SerializableGuid> DCPHCKKFCPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class NHGDCFKFHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NHGDCFKFHNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public KOFPPLLKPCD()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[ECCAJNNDEJN(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[FIEEHAEDALA(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[ECCAJNNDEJN(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[FIEEHAEDALA(1)]
		public float3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[FIEEHAEDALA(2)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xE27480", Offset = "0xE26280", VA = "0x180E27480")]
		public LocalPoseData(float3 localPosition, quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3980", Offset = "0x5DD2780", VA = "0x185DD3980")]
		public static implicit operator BHJJOINCPMJ(LocalPoseData poseData)
		{
			return default(BHJJOINCPMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3930", Offset = "0x5DD2730", VA = "0x185DD3930")]
		public static implicit operator LocalPoseData(BHJJOINCPMJ pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[ECCAJNNDEJN(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[ECCAJNNDEJN(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3AB0", Offset = "0x5DD28B0", VA = "0x185DD3AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[ECCAJNNDEJN(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[FIEEHAEDALA(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct INDEJLDCMLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int CHDGKHDDBKE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AIPHGHFENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3380", Offset = "0x5DD2180", VA = "0x185DD3380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3390", Offset = "0x5DD2190", VA = "0x185DD3390")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[ECCAJNNDEJN(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[FIEEHAEDALA(1)]
		public ECHLKIHPMMG transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[FIEEHAEDALA(2)]
		public OCNAHCFKEPD transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[Flags]
[IFEFAIBODLP(0, 1)]
public enum ECHLKIHPMMG
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[IFEFAIBODLP(-2, 2)]
public enum OCNAHCFKEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[ECCAJNNDEJN(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[ECCAJNNDEJN(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4340", Offset = "0x5DD3140", VA = "0x185DD4340")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[ECCAJNNDEJN(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[IFEFAIBODLP(1000, 8001)]
public enum CBLLNBPHCKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Player = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Unused = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	COUNT = 8002,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MAX = 8001
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal enum EGNPEFPDMIF
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class HIACKIGOBPP
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[ECCAJNNDEJN(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[FIEEHAEDALA(1)]
		public CBLLNBPHCKJ prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class JMJJPHNKMOB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DD34F0", Offset = "0x5DD22F0", VA = "0x185DD34F0")]
	public static bool LLMAJNMCBPN(this CBLLNBPHCKJ NKICFHCCMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3510", Offset = "0x5DD2310", VA = "0x185DD3510")]
	public static string MNNGHMGNCLK(this CBLLNBPHCKJ NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DD34A0", Offset = "0x5DD22A0", VA = "0x185DD34A0")]
	public static PDCBPHNLNBN BPHEMGAFBAH(this CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DD34E0", Offset = "0x5DD22E0", VA = "0x185DD34E0")]
	internal static EGNPEFPDMIF CDDHNANKLDN(this PDCBPHNLNBN DOACMPJEKEJ)
	{
		return default(EGNPEFPDMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DD34C0", Offset = "0x5DD22C0", VA = "0x185DD34C0")]
	internal static EGNPEFPDMIF CDDHNANKLDN(this CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(EGNPEFPDMIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IFEFAIBODLP(0, 9)]
public enum PDCBPHNLNBN
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MAX = 9
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ECCAJNNDEJN(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[FIEEHAEDALA(1)]
		public PDCBPHNLNBN objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FKKDDCFLKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2FF0", Offset = "0x5DD1DF0", VA = "0x185DD2FF0")]
	public static bool PBOMNNMCAOJ(this PDCBPHNLNBN DOACMPJEKEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[IFEFAIBODLP(-1, 60)]
public enum MMLCCLGDAAB
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
[Cpp2IlInjected.Token(Token = "0x2000070")]
[IFEFAIBODLP(-1, 31)]
public enum DHOLENBALGH
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
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[DNKAAMBGEFF("Visual", 0)]
	[ECCAJNNDEJN(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(1)]
		public MMLCCLGDAAB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(2)]
		public DHOLENBALGH material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[NBIFHADAKEO(0)]
		[FIEEHAEDALA(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[FIEEHAEDALA(4)]
		[NBIFHADAKEO(0)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	internal class _RRAssemblyIndex : ICKAPGKMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4690", Offset = "0x5DD3490", VA = "0x185DD4690", Slot = "4")]
		public sealed override void GEKIOEINPME()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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
