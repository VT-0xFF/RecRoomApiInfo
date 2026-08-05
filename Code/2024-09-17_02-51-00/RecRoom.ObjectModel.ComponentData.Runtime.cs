using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D4AD80", Offset = "0x6D49780", VA = "0x186D4AD80", Slot = "9")]
		public override void DBOCDGJKAPE(IPPIAPOPFOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D4B160", Offset = "0x6D49B60", VA = "0x186D4B160", Slot = "7")]
		public override void IEDDCCOHLFA(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GEGIABIMLCL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D48320", Offset = "0x6D46D20", VA = "0x186D48320", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KOKLEMHGOKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AEHIFLGOOOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity IJIHGIFNOBN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FBCFKBMLIGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity IJIHGIFNOBN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NOFOEHADOOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<EPFCNDPNIEB> IHMBOOPIBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> KFKJMFOLALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle GDNIAPJJBPI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A520", Offset = "0x6D48F20", VA = "0x186D4A520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A470", Offset = "0x6D48E70", VA = "0x186D4A470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4F3CCD0", Offset = "0x4F3B6D0", VA = "0x184F3CCD0")]
	public NOFOEHADOOA(NativeList<EPFCNDPNIEB> IHMBOOPIBJA, NativeList<Entity> KFKJMFOLALP, JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A590", Offset = "0x6D48F90", VA = "0x186D4A590")]
	public (Entity, NativeSlice<Entity>) OOGNIKBHGGD(int DMIMFDDIIBO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A4C0", Offset = "0x6D48EC0", VA = "0x186D4A4C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EPFCNDPNIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity JPBBEMPIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int IEHCONIHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int KHMKAEGDPPG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GPLCPIPHBHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCDLNBEFHDD(bool EABBPFGJGOL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NJHDGJCEILL : IEquatable<NJHDGJCEILL>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool PGLKNJDLOKD(int GPABCNEPJFA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool IIGCHGCHGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool JPLBCLOHFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool JPOMNDIDCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool LEEODHKCMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PGLKNJDLOKD GJGIMONGJID;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A300", Offset = "0x6D48D00", VA = "0x186D4A300")]
	public NJHDGJCEILL(FCJLNBDJJLP OGECPHANGNB, PGLKNJDLOKD GJGIMONGJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A340", Offset = "0x6D48D40", VA = "0x186D4A340")]
	public NJHDGJCEILL(bool IIGCHGCHGPL, bool JPLBCLOHFPN, bool JPOMNDIDCMJ, bool LEEODHKCMHN, PGLKNJDLOKD GJGIMONGJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A0D0", Offset = "0x6D48AD0", VA = "0x186D4A0D0")]
	public bool CPOFOJOPIBC(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A0A0", Offset = "0x6D48AA0", VA = "0x186D4A0A0")]
	public bool BDNDJEHKBLB(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A2D0", Offset = "0x6D48CD0", VA = "0x186D4A2D0")]
	public bool LPIGLKEOKLN(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A280", Offset = "0x6D48C80", VA = "0x186D4A280")]
	public bool JEONAAEHACH(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A1B0", Offset = "0x6D48BB0", VA = "0x186D4A1B0", Slot = "4")]
	public bool Equals(NJHDGJCEILL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A100", Offset = "0x6D48B00", VA = "0x186D4A100", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A1E0", Offset = "0x6D48BE0", VA = "0x186D4A1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A2B0", Offset = "0x6D48CB0", VA = "0x186D4A2B0")]
	private bool JOFDKHHCLCB(int GPABCNEPJFA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GKFPGIJIMNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OGPFBLHGBMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NFHGFGGKPPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct KODAIMPGKLL : IBufferElementData, IEquatable<KODAIMPGKLL>, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JGEMMJEFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int EDGBEJEFBGH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity COAEGNPFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D496A0", Offset = "0x6D480A0", VA = "0x186D496A0", Slot = "4")]
	public bool Equals(KODAIMPGKLL PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ODOENGCLEHK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct KJPKJALGJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JAEEGINPDLA PPMCIEMNBKC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
		public KJPKJALGJEO(JAEEGINPDLA FNMJCKGHNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D495D0", Offset = "0x6D47FD0", VA = "0x186D495D0")]
		public bool EGMHPEPCEFL(ODOENGCLEHK MPKBOPEBFAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D495E0", Offset = "0x6D47FE0", VA = "0x186D495E0")]
		public bool IGNDKEDHHAD(ODOENGCLEHK MPKBOPEBFAI, JAEEGINPDLA CLPKDAIEOJK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JAEEGINPDLA LHOODFCOEKF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
	public ODOENGCLEHK(JAEEGINPDLA LHOODFCOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A770", Offset = "0x6D49170", VA = "0x186D4A770")]
	public ODOENGCLEHK HNFLNJBDOKM(JAEEGINPDLA NPILMKOKHAM)
	{
		return default(ODOENGCLEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A780", Offset = "0x6D49180", VA = "0x186D4A780")]
	public ODOENGCLEHK IDNIPDJJPID(JAEEGINPDLA EBLJIIFFGCN)
	{
		return default(ODOENGCLEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A790", Offset = "0x6D49190", VA = "0x186D4A790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum JAEEGINPDLA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsRootObject = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasColliders = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TestEmbodiment = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum HMIKMNINBAC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PIDEIBNOFHB]
public struct FNBKAFDMNDD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public HMIKMNINBAC LHOODFCOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool IGBNJHIMLKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GLADCDJNICD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D48DE0", Offset = "0x6D477E0", VA = "0x186D48DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D48E10", Offset = "0x6D47810", VA = "0x186D48E10")]
	private FNBKAFDMNDD(HMIKMNINBAC LHOODFCOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D48DC0", Offset = "0x6D477C0", VA = "0x186D48DC0")]
	public FNBKAFDMNDD HNFLNJBDOKM(HMIKMNINBAC NPILMKOKHAM)
	{
		return default(FNBKAFDMNDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D48DF0", Offset = "0x6D477F0", VA = "0x186D48DF0")]
	public FNBKAFDMNDD IDNIPDJJPID(HMIKMNINBAC EBLJIIFFGCN)
	{
		return default(FNBKAFDMNDD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AIBAMJNGDPB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IOLJDDPBHOL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity AKMPCFBEHDI;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, LOPBHHIOKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D48320", Offset = "0x6D46D20", VA = "0x186D48320", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PIDEIBNOFHB]
public struct CABIIJGGEJB : ISystemStateBufferElementData, IBufferElementData, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity AINKOAHKAPB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity DDOLMNPEMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EGPFHOKHPBB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity DGDEFDLPEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity INGNFCJPBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity EJHNADNKLIM;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OHMAMIFFACA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool OGCLLAHCFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint ALGFDACFJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool FIGOIJINJDE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct AHLJCLCMOBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint LOKKDIHAPJG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D48290", Offset = "0x6D46C90", VA = "0x186D48290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MHECBDKJJBH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[PIDEIBNOFHB]
public struct OIPCLEILDHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int CJDJODMOJFL;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JLOGMNOGJAF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int JNHDKONHEOB;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KLJENOGBMDD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle DEAIIJJHMPN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JDEBAJKGNGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int JNHDKONHEOB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NDICPLJMLFC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JFIIPIGAOMI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int JNHDKONHEOB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NIGIOOGJPDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HCBFLGIDFNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LJDNCHFLNFI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CJHAHJLLBAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode PGBDBKONKHA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CBBCGDGBDBB]
public struct EEJMPIMAKNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public MGNMBPEAPIF LAFKDAJMGPH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly EEJMPIMAKNG CLODJPHKAPB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NDBNFKPBCBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MNODKFCEPBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EHIOIEMKMDI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct FBMFGIGCNKM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity JGEMMJEFOMN;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CEBFBJOLFBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity LDJCBIBELIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FFBFMAPIFBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AJAOGGHPOIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity JPBBEMPIGCM;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BDKBHHNGJLD : DPOKJMNJGMA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BIDMJDNBNPO LOGCPLLGKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BIDMJDNBNPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EOLEMJFMJOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 DCGJMKPEKOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BNPOAHKPCGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CBBCGDGBDBB]
public struct GKFJPACGOAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 APLMKDPAJBI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly GKFJPACGOAM CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CBBCGDGBDBB]
public struct CGCDJPBHFDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 APLMKDPAJBI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly CGCDJPBHFDK CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BJEMLHNCAAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 ELAGHGAMHPN;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MBIJKHAFPAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 FMBNJHNFKGL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[CBBCGDGBDBB]
public struct HALAFPNDKFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float FCNOLJJKFPF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly HALAFPNDKFH CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[CBBCGDGBDBB]
public struct KDKKDFEEFDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float GKILHKLOHHD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KDKKDFEEFDG CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LABHODOOMBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 LFCEFGDACHJ;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct GEDEGEGCFBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DKOEEBIFOEM NKKEOAMLFCK;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EKMNCLCPONP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DKOEEBIFOEM PABIGPBBKED;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[PIDEIBNOFHB]
public struct BBNMHNCBGIC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity AINKOAHKAPB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PCJHNJBHBIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct PFBKCLNLFMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OPJKAHEHDIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints OPIKDHJECDP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[CBBCGDGBDBB]
public struct NOBPHMHGFHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float BHCJEPFNLJP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly NOBPHMHGFHE CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct NMMBFEKJDPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float CAAHNDOCFDH;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class JHFCNEOONBA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BICBEHEGEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object HCOBCJNJKJH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject MNKAGJEGJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object ELEFADMBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object ABOBIFIJHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public BICBEHEGEOP HCOBCJNJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate FMMBKOGIKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate EFFDKFELEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FKPPMPJBOIP<Delegate> OCNANONMCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FKPPMPJBOIP<Delegate> HLNMNEDAMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public FKPPMPJBOIP<Delegate> PALHDJNHJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public FKPPMPJBOIP<Delegate> CLFNJADOODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public FKPPMPJBOIP<Delegate> NNEPIHMFINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public FKPPMPJBOIP<Delegate> HKADKILGGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public FKPPMPJBOIP<Delegate> PJOPIJBGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public FKPPMPJBOIP<Delegate> HNCHKCACDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public FKPPMPJBOIP<Delegate> KOAHJAKNBJH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D49310", Offset = "0x6D47D10", VA = "0x186D49310", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public JHFCNEOONBA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BAINJKHFDHC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct ENMDJPMNEKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int BAOAGNNFBKP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16172F0", Offset = "0x1615CF0", VA = "0x1816172F0")]
	public static ENMDJPMNEKL BIEOCAPMHCM(int KLABJGGMBGH)
	{
		return default(ENMDJPMNEKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NGCENINCHBP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody FHMDKJNEMLN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A030", Offset = "0x6D48A30", VA = "0x186D4A030", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public NGCENINCHBP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BKOMFBLOOOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct ECCPOGMAIPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 OHHCFKJBEEH;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JMIGJBKEDEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DLPEMGFGHPD;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[CBBCGDGBDBB]
public struct FOCMBFFJFGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float GCAPGMEHLFJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FOCMBFFJFGM CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class NABNKJGPJFA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object JIDHNLHDIOB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D49EA0", Offset = "0x6D488A0", VA = "0x186D49EA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public NABNKJGPJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NBFLAGELFCC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object CNFHCHFPAPK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D49F10", Offset = "0x6D48910", VA = "0x186D49F10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public NBFLAGELFCC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DCMNKLEIJOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct HGJPOLHCFLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct LIKGNENBHIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct OKGGINCFDCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LIOIBHEEBIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct AHBCGNOLEEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes KJPHMNNIMDP;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[PIDEIBNOFHB]
public struct GBIAKHDOKLM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity PAANLKAJOCM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static GBIAKHDOKLM BIEOCAPMHCM(Entity KLABJGGMBGH)
	{
		return default(GBIAKHDOKLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct MAEOPFNJPHP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity AINKOAHKAPB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static MAEOPFNJPHP BIEOCAPMHCM(Entity AINKOAHKAPB)
	{
		return default(MAEOPFNJPHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IKCEGIFJOKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KIABCDHIDLM;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct FIINBADFCGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity KIABCDHIDLM;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct MMCKMFHOPNK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity KIHDMMPDHMP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static MMCKMFHOPNK BIEOCAPMHCM(Entity AINKOAHKAPB)
	{
		return default(MMCKMFHOPNK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct AONPDJKPPJK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HMOLBCEEIDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct DNAONDBMOPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint CJEHFDAEGCE;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[PIDEIBNOFHB]
internal struct NOFLBKLCGKM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity IFFMJMELHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int HGFDMIDEFHN;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct CPGHOPDPHMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity EHOJJBHONBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct FDKAIJNCGLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct IGFMMBHGCMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint ALGFDACFJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int LADILCKLAFK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
	public IGFMMBHGCMI(uint CHBIBINOGCF, int BHPCGIKJJLH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct GEJLKENMHPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct GOLKNNEIFHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PPKEPNIFJJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GIPICOLBNDC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HBLFDIAOCHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GANJOHOMMGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct LHKLECMKHHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct NAGHIPNENKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct LKGNMKJKEDP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct KCCIDMDKPCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CMKDMCGKEJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct EGHOHJCEFGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct AHIMDJMOJMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct NPDMCFJJOFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AMBEFKPJKKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AFEBNOOIMLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct GGJNOFGBDNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DEICCMBMEHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct MGPAIEMOBOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct LEIAHFPKBFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct GFPMHCGACLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HPLDGNANLCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct LPOOMNBILKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct PJFHAOMAMHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct JIPNOLICFCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct ALOEMHCFLFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct IBPCFCOIADN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LBKMFKLAHFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[PIDEIBNOFHB]
public struct PHMDGGLNOPB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes BAKDDABGCNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct OAEMLJFIKGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct HKNADNLICGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct OAOFCNHJNIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct EIKDEGCJEBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct NMFMFHCCFPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct DBEPEPIILKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FNMCGAODHLA : IComponentData, IComparable<FNMCGAODHLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int DEBCLGMOKGA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E15170", Offset = "0x1E13B70", VA = "0x181E15170", Slot = "4")]
	public int CompareTo(FNMCGAODHLA PLNBHPCFEOK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct NJBANPNHMHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct EENCNOJNODC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion JOLHFCINNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 LEELMECKGCG;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JBJBNLAMBBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float HHBJFLJOMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float CBFPKJODLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float HDKMAMIEGDH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FLOHLEOALCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MHOHOAOJDAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct FFIHIDOBACI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DIDNNEKKHHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int JNHDKONHEOB;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PIDEIBNOFHB]
public struct FGMBHKKLGBC : ISystemStateBufferElementData, IBufferElementData, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity DJFACICIDCN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity DDOLMNPEMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CBBCGDGBDBB]
public struct POELDOPGNEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 MDGPAJCGJDI;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly POELDOPGNEI CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[CBBCGDGBDBB]
public struct KNKIIANMOME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 GBJHAIHLBJE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly KNKIIANMOME CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct MLJLNHAFANO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int FKGLMKIONPM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HGFDMIDEFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D49E90", Offset = "0x6D48890", VA = "0x186D49E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D49E80", Offset = "0x6D48880", VA = "0x186D49E80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CBBCGDGBDBB]
public struct GGGGCJKBGNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 PIOFBOOALLM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly GGGGCJKBGNA CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[CBBCGDGBDBB]
public struct LENDJIHKBCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion JOLHFCINNMA;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly LENDJIHKBCN CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class LJBDFGHNHEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[CBBCGDGBDBB]
public struct CLEDOGBHDCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float BLHIBILGKMM;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly CLEDOGBHDCO CLODJPHKAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct DCPCPIBPHHA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity INICPKOBBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AOGBINLEDKL FODBPFPIPNA;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct KEABBCNNJDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AOGBINLEDKL FODBPFPIPNA;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct HEDLPABIHKB : ISystemStateComponentData, IComponentData, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity KOIICEKKKHA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity DDOLMNPEMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct NOOIAMLAMBF : ISystemStateBufferElementData, IBufferElementData, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity HFNBFKLLNEC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity DDOLMNPEMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct CKELFLHNFOM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity INICPKOBBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AOGBINLEDKL FODBPFPIPNA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct NDPHOBOEIOI : IEqualityComparer<CKELFLHNFOM>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static NDPHOBOEIOI CLODJPHKAPB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D49F80", Offset = "0x6D48980", VA = "0x186D49F80", Slot = "4")]
	public bool Equals(CKELFLHNFOM NCPIGLMANIM, CKELFLHNFOM DJBPOPBDKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D49FD0", Offset = "0x6D489D0", VA = "0x186D49FD0", Slot = "5")]
	public int GetHashCode(CKELFLHNFOM GHMNBJIOGAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct EKOOPFHPLEO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> PKHLPDFNIKO;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct EKOLHMOBMFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> PKHLPDFNIKO;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct PAJNPNMFIIH : ISystemStateBufferElementData, IBufferElementData, LOPBHHIOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity CMGJIFHDEFF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity COAEGNPFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1075060", Offset = "0x1073A60", VA = "0x181075060", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class MFLLGGJJACD : ContainerPropertyBag<JHFCNEOONBA>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class FLPLGGLFIHH : Property<JHFCNEOONBA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D48D90", Offset = "0x6D47790", VA = "0x186D48D90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D48D50", Offset = "0x6D47750", VA = "0x186D48D50")]
		public FLPLGGLFIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D48420", Offset = "0x6D46E20", VA = "0x186D48420", Slot = "14")]
		public override GameObject GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D48440", Offset = "0x6D46E40", VA = "0x186D48440", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, GameObject KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class NKCIAEOGNKE : Property<JHFCNEOONBA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D4A400", Offset = "0x6D48E00", VA = "0x186D4A400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A3C0", Offset = "0x6D48DC0", VA = "0x186D4A3C0")]
		public NKCIAEOGNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A370", Offset = "0x6D48D70", VA = "0x186D4A370", Slot = "14")]
		public override object GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A390", Offset = "0x6D48D90", VA = "0x186D4A390", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class NPKDJDENIDO : Property<JHFCNEOONBA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D4A740", Offset = "0x6D49140", VA = "0x186D4A740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A700", Offset = "0x6D49100", VA = "0x186D4A700")]
		public NPKDJDENIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A6B0", Offset = "0x6D490B0", VA = "0x186D4A6B0", Slot = "14")]
		public override object GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A6D0", Offset = "0x6D490D0", VA = "0x186D4A6D0", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class ACDAFKLDJJB : Property<JHFCNEOONBA, JHFCNEOONBA.BICBEHEGEOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6D48260", Offset = "0x6D46C60", VA = "0x186D48260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D48220", Offset = "0x6D46C20", VA = "0x186D48220")]
		public ACDAFKLDJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D481D0", Offset = "0x6D46BD0", VA = "0x186D481D0", Slot = "14")]
		public override JHFCNEOONBA.BICBEHEGEOP GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(JHFCNEOONBA.BICBEHEGEOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D481F0", Offset = "0x6D46BF0", VA = "0x186D481F0", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, JHFCNEOONBA.BICBEHEGEOP KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class BLODHDDNKBA : Property<JHFCNEOONBA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6D48570", Offset = "0x6D46F70", VA = "0x186D48570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D48530", Offset = "0x6D46F30", VA = "0x186D48530")]
		public BLODHDDNKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D484E0", Offset = "0x6D46EE0", VA = "0x186D484E0", Slot = "14")]
		public override Delegate GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D48500", Offset = "0x6D46F00", VA = "0x186D48500", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, Delegate KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class HNEHJLBMDMO : Property<JHFCNEOONBA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6D49270", Offset = "0x6D47C70", VA = "0x186D49270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D49230", Offset = "0x6D47C30", VA = "0x186D49230")]
		public HNEHJLBMDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D491E0", Offset = "0x6D47BE0", VA = "0x186D491E0", Slot = "14")]
		public override Delegate GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D49200", Offset = "0x6D47C00", VA = "0x186D49200", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, Delegate KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class EBNPPICOEOB : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6D48A30", Offset = "0x6D47430", VA = "0x186D48A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D489F0", Offset = "0x6D473F0", VA = "0x186D489F0")]
		public EBNPPICOEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D48980", Offset = "0x6D47380", VA = "0x186D48980", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D489B0", Offset = "0x6D473B0", VA = "0x186D489B0", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class JHIKALBKBOD : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6D49410", Offset = "0x6D47E10", VA = "0x186D49410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D493D0", Offset = "0x6D47DD0", VA = "0x186D493D0")]
		public JHIKALBKBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D49360", Offset = "0x6D47D60", VA = "0x186D49360", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D49390", Offset = "0x6D47D90", VA = "0x186D49390", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class DFMHKANFPLD : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D48950", Offset = "0x6D47350", VA = "0x186D48950", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D48910", Offset = "0x6D47310", VA = "0x186D48910")]
		public DFMHKANFPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D488A0", Offset = "0x6D472A0", VA = "0x186D488A0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D488D0", Offset = "0x6D472D0", VA = "0x186D488D0", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class CMDNAGDGOKO : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D48790", Offset = "0x6D47190", VA = "0x186D48790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D48750", Offset = "0x6D47150", VA = "0x186D48750")]
		public CMDNAGDGOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D486D0", Offset = "0x6D470D0", VA = "0x186D486D0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D48710", Offset = "0x6D47110", VA = "0x186D48710", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class ABMOANHGDKF : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6D481A0", Offset = "0x6D46BA0", VA = "0x186D481A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D48160", Offset = "0x6D46B60", VA = "0x186D48160")]
		public ABMOANHGDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D480E0", Offset = "0x6D46AE0", VA = "0x186D480E0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D48120", Offset = "0x6D46B20", VA = "0x186D48120", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class FBGJOAALEDP : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6D48D20", Offset = "0x6D47720", VA = "0x186D48D20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D48CE0", Offset = "0x6D476E0", VA = "0x186D48CE0")]
		public FBGJOAALEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D48C60", Offset = "0x6D47660", VA = "0x186D48C60", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D48CA0", Offset = "0x6D476A0", VA = "0x186D48CA0", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class EFEKLOCCEGJ : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6D48BD0", Offset = "0x6D475D0", VA = "0x186D48BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D48B90", Offset = "0x6D47590", VA = "0x186D48B90")]
		public EFEKLOCCEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D48B10", Offset = "0x6D47510", VA = "0x186D48B10", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D48B50", Offset = "0x6D47550", VA = "0x186D48B50", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class GIOAKGDJFCG : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6D48FA0", Offset = "0x6D479A0", VA = "0x186D48FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D48F60", Offset = "0x6D47960", VA = "0x186D48F60")]
		public GIOAKGDJFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D48EE0", Offset = "0x6D478E0", VA = "0x186D48EE0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D48F20", Offset = "0x6D47920", VA = "0x186D48F20", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class BBMAMMDILBL : Property<JHFCNEOONBA, FKPPMPJBOIP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6D483F0", Offset = "0x6D46DF0", VA = "0x186D483F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D483B0", Offset = "0x6D46DB0", VA = "0x186D483B0")]
		public BBMAMMDILBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D48330", Offset = "0x6D46D30", VA = "0x186D48330", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D48370", Offset = "0x6D46D70", VA = "0x186D48370", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D49820", Offset = "0x6D48220", VA = "0x186D49820")]
	public MFLLGGJJACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class AAGCCDLAEDC : ContainerPropertyBag<JHFCNEOONBA.BICBEHEGEOP>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class EEGHNOJBBLL : Property<JHFCNEOONBA.BICBEHEGEOP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6D48AA0", Offset = "0x6D474A0", VA = "0x186D48AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D48A60", Offset = "0x6D47460", VA = "0x186D48A60")]
		public EEGHNOJBBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320", Slot = "14")]
		public override object GetValue(JHFCNEOONBA.BICBEHEGEOP EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A53570", Offset = "0x4A51F70", VA = "0x184A53570", Slot = "15")]
		public override void SetValue(JHFCNEOONBA.BICBEHEGEOP EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D48000", Offset = "0x6D46A00", VA = "0x186D48000")]
	public AAGCCDLAEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class EMNGPBHMLEE : ContainerPropertyBag<FKPPMPJBOIP<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D48C00", Offset = "0x6D47600", VA = "0x186D48C00")]
	public EMNGPBHMLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class HGEIDHLALJH : ContainerPropertyBag<NGCENINCHBP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class JIGDKJKCILL : Property<NGCENINCHBP, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D49480", Offset = "0x6D47E80", VA = "0x186D49480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D49440", Offset = "0x6D47E40", VA = "0x186D49440")]
		public JIGDKJKCILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D48420", Offset = "0x6D46E20", VA = "0x186D48420", Slot = "14")]
		public override Rigidbody GetValue(NGCENINCHBP EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D48440", Offset = "0x6D46E40", VA = "0x186D48440", Slot = "15")]
		public override void SetValue(NGCENINCHBP EOPOOELIKIH, Rigidbody KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D49100", Offset = "0x6D47B00", VA = "0x186D49100")]
	public HGEIDHLALJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KGFFOOCOPEN : ContainerPropertyBag<NABNKJGPJFA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BLHPJKFALDE : Property<NABNKJGPJFA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D484B0", Offset = "0x6D46EB0", VA = "0x186D484B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D48470", Offset = "0x6D46E70", VA = "0x186D48470")]
		public BLHPJKFALDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D48420", Offset = "0x6D46E20", VA = "0x186D48420", Slot = "14")]
		public override object GetValue(NABNKJGPJFA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D48440", Offset = "0x6D46E40", VA = "0x186D48440", Slot = "15")]
		public override void SetValue(NABNKJGPJFA EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D494F0", Offset = "0x6D47EF0", VA = "0x186D494F0")]
	public KGFFOOCOPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class DEECHBEEJHD : ContainerPropertyBag<NBFLAGELFCC>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class IHHGNHLKDHO : Property<NBFLAGELFCC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string FHACOBMPENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D492E0", Offset = "0x6D47CE0", VA = "0x186D492E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D492A0", Offset = "0x6D47CA0", VA = "0x186D492A0")]
		public IHHGNHLKDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D48420", Offset = "0x6D46E20", VA = "0x186D48420", Slot = "14")]
		public override object GetValue(NBFLAGELFCC EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D48440", Offset = "0x6D46E40", VA = "0x186D48440", Slot = "15")]
		public override void SetValue(NBFLAGELFCC EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D487C0", Offset = "0x6D471C0", VA = "0x186D487C0")]
	public DEECHBEEJHD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A8A0", Offset = "0x6D492A0", VA = "0x186D4A8A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class GCJAEBBBAOC
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public GCJAEBBBAOC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
