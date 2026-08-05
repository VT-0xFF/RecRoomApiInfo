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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C63A60", Offset = "0x6C62060", VA = "0x186C63A60", Slot = "9")]
		public override void DBOCDGJKAPE(IPPIAPOPFOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C63E40", Offset = "0x6C62440", VA = "0x186C63E40", Slot = "7")]
		public override void IEDDCCOHLFA(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
			[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C61000", Offset = "0x6C5F600", VA = "0x186C61000", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C63200", Offset = "0x6C61800", VA = "0x186C63200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C63150", Offset = "0x6C61750", VA = "0x186C63150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DBB0", Offset = "0x4E6C1B0", VA = "0x184E6DBB0")]
	public NOFOEHADOOA(NativeList<EPFCNDPNIEB> IHMBOOPIBJA, NativeList<Entity> KFKJMFOLALP, JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C63270", Offset = "0x6C61870", VA = "0x186C63270")]
	public (Entity, NativeSlice<Entity>) OOGNIKBHGGD(int DMIMFDDIIBO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C631A0", Offset = "0x6C617A0", VA = "0x186C631A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C62FE0", Offset = "0x6C615E0", VA = "0x186C62FE0")]
	public NJHDGJCEILL(FCJLNBDJJLP OGECPHANGNB, PGLKNJDLOKD GJGIMONGJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C63020", Offset = "0x6C61620", VA = "0x186C63020")]
	public NJHDGJCEILL(bool IIGCHGCHGPL, bool JPLBCLOHFPN, bool JPOMNDIDCMJ, bool LEEODHKCMHN, PGLKNJDLOKD GJGIMONGJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C62DB0", Offset = "0x6C613B0", VA = "0x186C62DB0")]
	public bool CPOFOJOPIBC(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C62D80", Offset = "0x6C61380", VA = "0x186C62D80")]
	public bool BDNDJEHKBLB(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C62FB0", Offset = "0x6C615B0", VA = "0x186C62FB0")]
	public bool LPIGLKEOKLN(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C62F60", Offset = "0x6C61560", VA = "0x186C62F60")]
	public bool JEONAAEHACH(int GPABCNEPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C62E90", Offset = "0x6C61490", VA = "0x186C62E90", Slot = "4")]
	public bool Equals(NJHDGJCEILL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C62DE0", Offset = "0x6C613E0", VA = "0x186C62DE0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C62EC0", Offset = "0x6C614C0", VA = "0x186C62EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C62F90", Offset = "0x6C61590", VA = "0x186C62F90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C62380", Offset = "0x6C60980", VA = "0x186C62380", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2266760", Offset = "0x2264D60", VA = "0x182266760")]
		public KJPKJALGJEO(JAEEGINPDLA FNMJCKGHNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C622B0", Offset = "0x6C608B0", VA = "0x186C622B0")]
		public bool EGMHPEPCEFL(ODOENGCLEHK MPKBOPEBFAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C622C0", Offset = "0x6C608C0", VA = "0x186C622C0")]
		public bool IGNDKEDHHAD(ODOENGCLEHK MPKBOPEBFAI, JAEEGINPDLA CLPKDAIEOJK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JAEEGINPDLA LHOODFCOEKF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2266760", Offset = "0x2264D60", VA = "0x182266760")]
	public ODOENGCLEHK(JAEEGINPDLA LHOODFCOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C63450", Offset = "0x6C61A50", VA = "0x186C63450")]
	public ODOENGCLEHK HNFLNJBDOKM(JAEEGINPDLA NPILMKOKHAM)
	{
		return default(ODOENGCLEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C63460", Offset = "0x6C61A60", VA = "0x186C63460")]
	public ODOENGCLEHK IDNIPDJJPID(JAEEGINPDLA EBLJIIFFGCN)
	{
		return default(ODOENGCLEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C63470", Offset = "0x6C61A70", VA = "0x186C63470", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C61AC0", Offset = "0x6C600C0", VA = "0x186C61AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C61AF0", Offset = "0x6C600F0", VA = "0x186C61AF0")]
	private FNBKAFDMNDD(HMIKMNINBAC LHOODFCOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C61AA0", Offset = "0x6C600A0", VA = "0x186C61AA0")]
	public FNBKAFDMNDD HNFLNJBDOKM(HMIKMNINBAC NPILMKOKHAM)
	{
		return default(FNBKAFDMNDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C61AD0", Offset = "0x6C600D0", VA = "0x186C61AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C61000", Offset = "0x6C5F600", VA = "0x186C61000", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C60F70", Offset = "0x6C5F570", VA = "0x186C60F70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BIDMJDNBNPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C61FF0", Offset = "0x6C605F0", VA = "0x186C61FF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x14125F0", Offset = "0x1410BF0", VA = "0x1814125F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C62D10", Offset = "0x6C61310", VA = "0x186C62D10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C62B80", Offset = "0x6C61180", VA = "0x186C62B80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C62BF0", Offset = "0x6C611F0", VA = "0x186C62BF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CC4260", Offset = "0x1CC2860", VA = "0x181CC4260", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C62B70", Offset = "0x6C61170", VA = "0x186C62B70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C62B60", Offset = "0x6C61160", VA = "0x186C62B60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C62C60", Offset = "0x6C61260", VA = "0x186C62C60", Slot = "4")]
	public bool Equals(CKELFLHNFOM NCPIGLMANIM, CKELFLHNFOM DJBPOPBDKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C62CB0", Offset = "0x6C612B0", VA = "0x186C62CB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xFA5270", Offset = "0xFA3870", VA = "0x180FA5270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61A70", Offset = "0x6C60070", VA = "0x186C61A70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C61A30", Offset = "0x6C60030", VA = "0x186C61A30")]
		public FLPLGGLFIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C61100", Offset = "0x6C5F700", VA = "0x186C61100", Slot = "14")]
		public override GameObject GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C61120", Offset = "0x6C5F720", VA = "0x186C61120", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C630E0", Offset = "0x6C616E0", VA = "0x186C630E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C630A0", Offset = "0x6C616A0", VA = "0x186C630A0")]
		public NKCIAEOGNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C63050", Offset = "0x6C61650", VA = "0x186C63050", Slot = "14")]
		public override object GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C63070", Offset = "0x6C61670", VA = "0x186C63070", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C63420", Offset = "0x6C61A20", VA = "0x186C63420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C633E0", Offset = "0x6C619E0", VA = "0x186C633E0")]
		public NPKDJDENIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C63390", Offset = "0x6C61990", VA = "0x186C63390", Slot = "14")]
		public override object GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C633B0", Offset = "0x6C619B0", VA = "0x186C633B0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C60F40", Offset = "0x6C5F540", VA = "0x186C60F40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C60F00", Offset = "0x6C5F500", VA = "0x186C60F00")]
		public ACDAFKLDJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C60EB0", Offset = "0x6C5F4B0", VA = "0x186C60EB0", Slot = "14")]
		public override JHFCNEOONBA.BICBEHEGEOP GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(JHFCNEOONBA.BICBEHEGEOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C60ED0", Offset = "0x6C5F4D0", VA = "0x186C60ED0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61250", Offset = "0x6C5F850", VA = "0x186C61250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C61210", Offset = "0x6C5F810", VA = "0x186C61210")]
		public BLODHDDNKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C611C0", Offset = "0x6C5F7C0", VA = "0x186C611C0", Slot = "14")]
		public override Delegate GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C611E0", Offset = "0x6C5F7E0", VA = "0x186C611E0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61F50", Offset = "0x6C60550", VA = "0x186C61F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C61F10", Offset = "0x6C60510", VA = "0x186C61F10")]
		public HNEHJLBMDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C61EC0", Offset = "0x6C604C0", VA = "0x186C61EC0", Slot = "14")]
		public override Delegate GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C61EE0", Offset = "0x6C604E0", VA = "0x186C61EE0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61710", Offset = "0x6C5FD10", VA = "0x186C61710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C616D0", Offset = "0x6C5FCD0", VA = "0x186C616D0")]
		public EBNPPICOEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C61660", Offset = "0x6C5FC60", VA = "0x186C61660", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C61690", Offset = "0x6C5FC90", VA = "0x186C61690", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C620F0", Offset = "0x6C606F0", VA = "0x186C620F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C620B0", Offset = "0x6C606B0", VA = "0x186C620B0")]
		public JHIKALBKBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C62040", Offset = "0x6C60640", VA = "0x186C62040", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C62070", Offset = "0x6C60670", VA = "0x186C62070", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61630", Offset = "0x6C5FC30", VA = "0x186C61630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C615F0", Offset = "0x6C5FBF0", VA = "0x186C615F0")]
		public DFMHKANFPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C61580", Offset = "0x6C5FB80", VA = "0x186C61580", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C615B0", Offset = "0x6C5FBB0", VA = "0x186C615B0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61470", Offset = "0x6C5FA70", VA = "0x186C61470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C61430", Offset = "0x6C5FA30", VA = "0x186C61430")]
		public CMDNAGDGOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C613B0", Offset = "0x6C5F9B0", VA = "0x186C613B0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C613F0", Offset = "0x6C5F9F0", VA = "0x186C613F0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C60E80", Offset = "0x6C5F480", VA = "0x186C60E80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C60E40", Offset = "0x6C5F440", VA = "0x186C60E40")]
		public ABMOANHGDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C60DC0", Offset = "0x6C5F3C0", VA = "0x186C60DC0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C60E00", Offset = "0x6C5F400", VA = "0x186C60E00", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61A00", Offset = "0x6C60000", VA = "0x186C61A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C619C0", Offset = "0x6C5FFC0", VA = "0x186C619C0")]
		public FBGJOAALEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C61940", Offset = "0x6C5FF40", VA = "0x186C61940", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C61980", Offset = "0x6C5FF80", VA = "0x186C61980", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C618B0", Offset = "0x6C5FEB0", VA = "0x186C618B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C61870", Offset = "0x6C5FE70", VA = "0x186C61870")]
		public EFEKLOCCEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C617F0", Offset = "0x6C5FDF0", VA = "0x186C617F0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C61830", Offset = "0x6C5FE30", VA = "0x186C61830", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61C80", Offset = "0x6C60280", VA = "0x186C61C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C61C40", Offset = "0x6C60240", VA = "0x186C61C40")]
		public GIOAKGDJFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C61BC0", Offset = "0x6C601C0", VA = "0x186C61BC0", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C61C00", Offset = "0x6C60200", VA = "0x186C61C00", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C610D0", Offset = "0x6C5F6D0", VA = "0x186C610D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C61090", Offset = "0x6C5F690", VA = "0x186C61090")]
		public BBMAMMDILBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C61010", Offset = "0x6C5F610", VA = "0x186C61010", Slot = "14")]
		public override FKPPMPJBOIP<Delegate> GetValue(JHFCNEOONBA EOPOOELIKIH)
		{
			return default(FKPPMPJBOIP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C61050", Offset = "0x6C5F650", VA = "0x186C61050", Slot = "15")]
		public override void SetValue(JHFCNEOONBA EOPOOELIKIH, FKPPMPJBOIP<Delegate> KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C62500", Offset = "0x6C60B00", VA = "0x186C62500")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61780", Offset = "0x6C5FD80", VA = "0x186C61780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C61740", Offset = "0x6C5FD40", VA = "0x186C61740")]
		public EEGHNOJBBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB99F20", Offset = "0xB98520", VA = "0x180B99F20", Slot = "14")]
		public override object GetValue(JHFCNEOONBA.BICBEHEGEOP EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x497EE80", Offset = "0x497D480", VA = "0x18497EE80", Slot = "15")]
		public override void SetValue(JHFCNEOONBA.BICBEHEGEOP EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C60CE0", Offset = "0x6C5F2E0", VA = "0x186C60CE0")]
	public AAGCCDLAEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class EMNGPBHMLEE : ContainerPropertyBag<FKPPMPJBOIP<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C618E0", Offset = "0x6C5FEE0", VA = "0x186C618E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C62160", Offset = "0x6C60760", VA = "0x186C62160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C62120", Offset = "0x6C60720", VA = "0x186C62120")]
		public JIGDKJKCILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C61100", Offset = "0x6C5F700", VA = "0x186C61100", Slot = "14")]
		public override Rigidbody GetValue(NGCENINCHBP EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C61120", Offset = "0x6C5F720", VA = "0x186C61120", Slot = "15")]
		public override void SetValue(NGCENINCHBP EOPOOELIKIH, Rigidbody KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C61DE0", Offset = "0x6C603E0", VA = "0x186C61DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61190", Offset = "0x6C5F790", VA = "0x186C61190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C61150", Offset = "0x6C5F750", VA = "0x186C61150")]
		public BLHPJKFALDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C61100", Offset = "0x6C5F700", VA = "0x186C61100", Slot = "14")]
		public override object GetValue(NABNKJGPJFA EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C61120", Offset = "0x6C5F720", VA = "0x186C61120", Slot = "15")]
		public override void SetValue(NABNKJGPJFA EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C621D0", Offset = "0x6C607D0", VA = "0x186C621D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C61FC0", Offset = "0x6C605C0", VA = "0x186C61FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool PBLDLBGBGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C61F80", Offset = "0x6C60580", VA = "0x186C61F80")]
		public IHHGNHLKDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C61100", Offset = "0x6C5F700", VA = "0x186C61100", Slot = "14")]
		public override object GetValue(NBFLAGELFCC EOPOOELIKIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C61120", Offset = "0x6C5F720", VA = "0x186C61120", Slot = "15")]
		public override void SetValue(NBFLAGELFCC EOPOOELIKIH, object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C614A0", Offset = "0x6C5FAA0", VA = "0x186C614A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C63580", Offset = "0x6C61B80", VA = "0x186C63580")]
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
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
