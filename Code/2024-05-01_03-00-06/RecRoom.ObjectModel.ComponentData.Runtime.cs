using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
	public class _AssemblyIndex : FIMMIOHCHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62DD0D0", Offset = "0x62DBED0", VA = "0x1862DD0D0", Slot = "8")]
		public override void PMLABOBIDNF(KLINEBNHAFG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62DCD90", Offset = "0x62DBB90", VA = "0x1862DCD90", Slot = "7")]
		public override void PKKFEMHMJGB(GFIFHOJIFLD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62DD4B0", Offset = "0x62DC2B0", VA = "0x1862DD4B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MLIEPAKNOBM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62DA420", Offset = "0x62D9220", VA = "0x1862DA420", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CLFLNAIGGJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OLFJEBLLHDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity PAAPJFMAENP;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FFGOOALPNHE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity PAAPJFMAENP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IBCJKBIIOID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<EPFOILJKPPD> OHIHLFCAPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> DCBHLFPCNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle BNBGJBKKKMM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JHNGBNKCFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62DB200", Offset = "0x62DA000", VA = "0x1862DB200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62DB3F0", Offset = "0x62DA1F0", VA = "0x1862DB3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46D1830", Offset = "0x46D0630", VA = "0x1846D1830")]
	public IBCJKBIIOID(NativeList<EPFOILJKPPD> OHIHLFCAPAO, NativeList<Entity> DCBHLFPCNBE, JobHandle BNBGJBKKKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62DB2D0", Offset = "0x62DA0D0", VA = "0x1862DB2D0")]
	public (Entity, NativeSlice<Entity>) HDOJOHMHIHP(int GJPDNBKOLHF)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62DB270", Offset = "0x62DA070", VA = "0x1862DB270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EPFOILJKPPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity GDOPFEEANMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int PJPGJICIKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int PDCHCFIOJCE;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HCCCHEPBEJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHDCJBJEKEA(bool DPBMNLMGDGP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DMIOBKAGFIO : IEquatable<DMIOBKAGFIO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool PGNDILCDFEL(int HAEHFCPEDMJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool BFNCMICCBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool LKKAFNPGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool NCGFAHGJKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool BLKPLDCBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PGNDILCDFEL DADMJEGLGPE;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62DAD00", Offset = "0x62D9B00", VA = "0x1862DAD00")]
	public DMIOBKAGFIO(BAMHMIEKLNG OKIGIEHONKO, PGNDILCDFEL DADMJEGLGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62DACD0", Offset = "0x62D9AD0", VA = "0x1862DACD0")]
	public DMIOBKAGFIO(bool BFNCMICCBGK, bool LKKAFNPGBOB, bool NCGFAHGJKMM, bool BLKPLDCBOKG, PGNDILCDFEL DADMJEGLGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62DAC80", Offset = "0x62D9A80", VA = "0x1862DAC80")]
	public bool HKCIKPADICF(int HAEHFCPEDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62DAA70", Offset = "0x62D9870", VA = "0x1862DAA70")]
	public bool BKCPPAAKGCN(int HAEHFCPEDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62DAAD0", Offset = "0x62D98D0", VA = "0x1862DAAD0")]
	public bool DKHLCKDCCFO(int HAEHFCPEDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62DAAA0", Offset = "0x62D98A0", VA = "0x1862DAAA0")]
	public bool CLAEDIOIHLJ(int HAEHFCPEDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62DABB0", Offset = "0x62D99B0", VA = "0x1862DABB0", Slot = "4")]
	public bool Equals(DMIOBKAGFIO GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62DAB00", Offset = "0x62D9900", VA = "0x1862DAB00", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62DABE0", Offset = "0x62D99E0", VA = "0x1862DABE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62DACB0", Offset = "0x62D9AB0", VA = "0x1862DACB0")]
	private bool IKOFDEIKOJB(int HAEHFCPEDMJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JGKKMFFBAIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JHPPOKOHELP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FGAAJDHAEHG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct DAGHJEFNKNO : IBufferElementData, IEquatable<DAGHJEFNKNO>, AOOKKGFAIFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity APEMCPNHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int DLGPHLDHJHI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity CCEHDGBIBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62DA850", Offset = "0x62D9650", VA = "0x1862DA850", Slot = "4")]
	public bool Equals(DAGHJEFNKNO GGINNHLAMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BDFNEIBMBLL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity FJMPGKGGIBH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AOOKKGFAIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62DA420", Offset = "0x62D9220", VA = "0x1862DA420", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DPBNHKCDCBK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool GOBGLGCFBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint MEHKLMGBKFF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool NKCMCEOICPF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct IMLOHINCHPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint DDKKJJNDMJN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62DB520", Offset = "0x62DA320", VA = "0x1862DB520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CBGBNAOOKIG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int EKDOAMOHCJD;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AJIFKENCLDI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle NEOAFOMKLGA;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OBALIKNPAIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int EKDOAMOHCJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PALDIAEELJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PELAOIBLAMJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int EKDOAMOHCJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DOFJFFHBFKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JMICAEKPLBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BGGPHNPEKDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OHDLFDOFFKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode OOPGBJDKDFO;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HCGIHEKKONE]
public struct DAMNGIMPKIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public LJIBDJGPFIC AMOAHGHHEJC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly DAMNGIMPKIM NGIMMBPCNIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IINGBGJGOKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HFKMOEPLOEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BMPOCEACDLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct LMBLDPIGNMD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity APEMCPNHEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LMEBFNMNFOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity OGCHMLDLLMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ILFFIAFDFBM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AJCIJHHNCOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity GDOPFEEANMP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct APJFEMDLAOC : FDHGAOPBAEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BDHHBIINIFM LNEOCLGEBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BDHHBIINIFM);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JCAHLCAIFLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 GEBACHONAJH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MFNCCODENIA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HCGIHEKKONE]
public struct LJGDJCENNJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 PPDGJPEPHFK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly LJGDJCENNJJ NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HCGIHEKKONE]
public struct NAABINOGFDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 PPDGJPEPHFK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NAABINOGFDE NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OFPNJAPHFPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 EKIOENBMGNN;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EIFAJIFABAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 INNFLJFJAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HCGIHEKKONE]
public struct HOBNENJCFMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float GOLCAODDFPL;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly HOBNENJCFMD NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HCGIHEKKONE]
public struct ADDKLIDGBHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float GGKHMKMJJDI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ADDKLIDGBHD NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BFNJBKJFIDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 OKCDMFDFCEB;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BEACCGABELK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public HOHJIBLCPPE OMNCCIOEEKP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JJEPICBGNIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public HOHJIBLCPPE EDKHHEDNNED;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HLNLBCEEPCC]
public struct HEFPOJGKEGF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity IBOBFMDOLFK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BHJDPDPAFEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JGAMBAHFPFK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FMCFCLBBICC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints AFHMPPHFBOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[HCGIHEKKONE]
public struct MCIHDLEJBNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float GMNCHFOEOHH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly MCIHDLEJBNO NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct PFMAEAMPOOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float GCNJANMKHKK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KFECEFAMAOP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct KFPBJJFAKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object EDFAPFELCOB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject EBIGFKEAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object ONEJKOJJBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object BODMNDDIHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public KFPBJJFAKOC EDFAPFELCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate JCBMLJJGNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate GICPMGBPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public KLPODJLKBNG<Delegate> DCLFHNMKDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public KLPODJLKBNG<Delegate> JJLBEOMCGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KLPODJLKBNG<Delegate> DHMLLGKICCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public KLPODJLKBNG<Delegate> KMDEIBFKFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public KLPODJLKBNG<Delegate> LMPGKGOGOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public KLPODJLKBNG<Delegate> CKILFLFJPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public KLPODJLKBNG<Delegate> IEDCDHFIGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public KLPODJLKBNG<Delegate> IMOGFFDEAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KLPODJLKBNG<Delegate> BFJFNCKNLDN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62DB610", Offset = "0x62DA410", VA = "0x1862DB610", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KFECEFAMAOP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BBCIPCBGMBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GHPFKDMMJPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int JJPOFFFNDJB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static GHPFKDMMJPO BPFJNEHKLMP(int DIBNBLEEFNN)
	{
		return default(GHPFKDMMJPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class OPEAFGONECO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody AAHNMGFGCFC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62DC020", Offset = "0x62DAE20", VA = "0x1862DC020", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OPEAFGONECO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FLFNDDCLLCD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct FCCFCKDEELJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 JHCGPEPGKKC;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FJELDGBHONB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 PKCNPDCOCJE;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HCGIHEKKONE]
public struct INNEOKBMNEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float NLLKAOHMMKA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly INNEOKBMNEF NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FDFJCPCGHCO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object CAKCKJIPLCF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62DAEE0", Offset = "0x62D9CE0", VA = "0x1862DAEE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FDFJCPCGHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KKCFMOIPNEG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object DMODDJBACJA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62DB6D0", Offset = "0x62DA4D0", VA = "0x1862DB6D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KKCFMOIPNEG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MCEHHIMLMEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AIJNCILICCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct GPCKDOIFCCK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GLAEAEFNOIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes PHEKPMAPPHM;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[HLNLBCEEPCC]
public struct POFHJPEBGAB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity JBCGCLHCBFD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static POFHJPEBGAB BPFJNEHKLMP(Entity DIBNBLEEFNN)
	{
		return default(POFHJPEBGAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct FCKKFPLOCCD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity IBOBFMDOLFK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static FCKKFPLOCCD BPFJNEHKLMP(Entity IBOBFMDOLFK)
	{
		return default(FCKKFPLOCCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GHIFPBKILBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity MLMAFEJHDNB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct HNIBAEECACK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity MLMAFEJHDNB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct BIFKAOHAGAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity IPMCKLGCMCJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static BIFKAOHAGAD BPFJNEHKLMP(Entity IBOBFMDOLFK)
	{
		return default(BIFKAOHAGAD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct PHDCDKJCBLF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FNIFDOHAPNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint MIJEJKOAIDK;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[HLNLBCEEPCC]
internal struct KHKPOPPMHDM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity NEOBIINPDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int AELAKOMEEDP;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct GPLGEBBEENH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity DLIBIIFDOGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JKAKMANMLEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct OPKFDIHOLGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint MEHKLMGBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int JMACMBPDAGG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
	public OPKFDIHOLGE(uint COCEHEFAMBD, int LNEDCBJJPJP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct EMCALACHKIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct IONBJPHGFKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct ICBIHBHFKKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct BJGDIHGCEGO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct AEHDNMHBEDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct ACEPJDOFAAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct MMNDKGPNOFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KCBAPGPHOID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct IEGENDNBAIG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct IJKGNKKHOHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct DEOHEHNMLHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct OLMGEDMHMCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct OFKIFHHONHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct LGGMHAPAOKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct GHBOLMANJNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct NCKFBPEJAMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BNJPEOPAPAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NFGCCFFDMAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct NBNFPIKFFKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OHKKCECFBGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GDBNGBKIHHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IEGOKGFBIDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct MHMKKNKKPCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct BGCNIJBHDNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct JPEOGEBPMJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IALAEEFEIAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AGNNDFPCLCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[HLNLBCEEPCC]
public struct NOJMBABOAPP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes FLCDMHECMDI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PHAMHHAFMGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct HJFEJKCEPDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct IEPLLGBKKEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct ENNDPJNOHON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct BPLINJBPCAD : IComponentData, IComparable<BPLINJBPCAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int COFIOKHLHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18935F0", Offset = "0x18923F0", VA = "0x1818935F0", Slot = "4")]
	public int CompareTo(BPLINJBPCAD GGINNHLAMLI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct BMEDCLGAKMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct FLCNLEJIPGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 JPLKOMKCHGP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct KBFCNCOAIAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float ABLINCCIAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float HGFIFNFKKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float ICIDFEJBJBB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct FLMDLPCBKIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HIKEGFLJHHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct OIMBMHNKJHC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MPMHGOAOHIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int EKDOAMOHCJD;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HLNLBCEEPCC]
public struct GIDGCMEFKPL : ISystemStateBufferElementData, IBufferElementData, AOOKKGFAIFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity AABHHMAPNDI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity KFGIIIJDBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HCGIHEKKONE]
public struct GFHJIJFFKCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 EKBJMKGFLHP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly GFHJIJFFKCA NGIMMBPCNIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct BDEEHOBHNHB : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IPMKHAIPMNM : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct AEGOCCEHPHA : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct JANAOGIPIMJ : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[HCGIHEKKONE]
public struct FDAMCKBNCGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 BNBHOPKIFIC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly FDAMCKBNCGA NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct JKIILPGMDDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BNHEJEBHPAL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AELAKOMEEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62DB5F0", Offset = "0x62DA3F0", VA = "0x1862DB5F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62DB600", Offset = "0x62DA400", VA = "0x1862DB600")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[HCGIHEKKONE]
public struct ALHKMIEJMJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 CENJLFABCHK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly ALHKMIEJMJO NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[HCGIHEKKONE]
public struct NJDEBFHCOHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 JPLKOMKCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly NJDEBFHCOHB NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class HJKIOBCDPLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[HCGIHEKKONE]
public struct DIIJBHDCIHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float ILMFDEBEBEP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly DIIJBHDCIHK NGIMMBPCNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct ELHJGIDMANB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> HMMKLKCHIGP;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct HPGGJFDPJMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> HMMKLKCHIGP;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class PDCDPLBHPOE : ContainerPropertyBag<KFECEFAMAOP>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class LDHCBJIOJKB : Property<KFECEFAMAOP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x62DB780", Offset = "0x62DA580", VA = "0x1862DB780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62DB740", Offset = "0x62DA540", VA = "0x1862DB740")]
		public LDHCBJIOJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62DA520", Offset = "0x62D9320", VA = "0x1862DA520", Slot = "14")]
		public override GameObject GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62DA540", Offset = "0x62D9340", VA = "0x1862DA540", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, GameObject DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class OIOJNFAIOMM : Property<KFECEFAMAOP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x62DBFF0", Offset = "0x62DADF0", VA = "0x1862DBFF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62DBFB0", Offset = "0x62DADB0", VA = "0x1862DBFB0")]
		public OIOJNFAIOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62DBF60", Offset = "0x62DAD60", VA = "0x1862DBF60", Slot = "14")]
		public override object GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62DBF80", Offset = "0x62DAD80", VA = "0x1862DBF80", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, object DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class BNDCALFJONN : Property<KFECEFAMAOP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x62DA760", Offset = "0x62D9560", VA = "0x1862DA760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62DA720", Offset = "0x62D9520", VA = "0x1862DA720")]
		public BNDCALFJONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62DA6D0", Offset = "0x62D94D0", VA = "0x1862DA6D0", Slot = "14")]
		public override object GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62DA6F0", Offset = "0x62D94F0", VA = "0x1862DA6F0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, object DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class NMDNCAGNOEA : Property<KFECEFAMAOP, KFECEFAMAOP.KFPBJJFAKOC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62DBF30", Offset = "0x62DAD30", VA = "0x1862DBF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62DBEF0", Offset = "0x62DACF0", VA = "0x1862DBEF0")]
		public NMDNCAGNOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62DBEA0", Offset = "0x62DACA0", VA = "0x1862DBEA0", Slot = "14")]
		public override KFECEFAMAOP.KFPBJJFAKOC GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KFECEFAMAOP.KFPBJJFAKOC);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62DBEC0", Offset = "0x62DACC0", VA = "0x1862DBEC0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KFECEFAMAOP.KFPBJJFAKOC DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class CKCACPPGNGK : Property<KFECEFAMAOP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62DA820", Offset = "0x62D9620", VA = "0x1862DA820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62DA7E0", Offset = "0x62D95E0", VA = "0x1862DA7E0")]
		public CKCACPPGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62DA790", Offset = "0x62D9590", VA = "0x1862DA790", Slot = "14")]
		public override Delegate GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62DA7B0", Offset = "0x62D95B0", VA = "0x1862DA7B0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, Delegate DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class AEIKCGAEFOE : Property<KFECEFAMAOP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62DA290", Offset = "0x62D9090", VA = "0x1862DA290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62DA250", Offset = "0x62D9050", VA = "0x1862DA250")]
		public AEIKCGAEFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62DA200", Offset = "0x62D9000", VA = "0x1862DA200", Slot = "14")]
		public override Delegate GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62DA220", Offset = "0x62D9020", VA = "0x1862DA220", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, Delegate DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class ICEIDGILALO : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x62DB4F0", Offset = "0x62DA2F0", VA = "0x1862DB4F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62DB4B0", Offset = "0x62DA2B0", VA = "0x1862DB4B0")]
		public ICEIDGILALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62DB440", Offset = "0x62DA240", VA = "0x1862DB440", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62DB470", Offset = "0x62DA270", VA = "0x1862DB470", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class AHEHBIGDCFL : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x62DA370", Offset = "0x62D9170", VA = "0x1862DA370", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62DA330", Offset = "0x62D9130", VA = "0x1862DA330")]
		public AHEHBIGDCFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62DA2C0", Offset = "0x62D90C0", VA = "0x1862DA2C0", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62DA2F0", Offset = "0x62D90F0", VA = "0x1862DA2F0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class FPLOCPJPDPH : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x62DB000", Offset = "0x62D9E00", VA = "0x1862DB000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62DAFC0", Offset = "0x62D9DC0", VA = "0x1862DAFC0")]
		public FPLOCPJPDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62DAF50", Offset = "0x62D9D50", VA = "0x1862DAF50", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62DAF80", Offset = "0x62D9D80", VA = "0x1862DAF80", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class DLLGEOJGMAI : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x62DAA40", Offset = "0x62D9840", VA = "0x1862DAA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62DAA00", Offset = "0x62D9800", VA = "0x1862DAA00")]
		public DLLGEOJGMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62DA980", Offset = "0x62D9780", VA = "0x1862DA980", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62DA9C0", Offset = "0x62D97C0", VA = "0x1862DA9C0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class EGLOKPDPFAI : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x62DAE00", Offset = "0x62D9C00", VA = "0x1862DAE00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62DADC0", Offset = "0x62D9BC0", VA = "0x1862DADC0")]
		public EGLOKPDPFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62DAD40", Offset = "0x62D9B40", VA = "0x1862DAD40", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62DAD80", Offset = "0x62D9B80", VA = "0x1862DAD80", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class BHINLGOPKPL : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x62DA4F0", Offset = "0x62D92F0", VA = "0x1862DA4F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62DA4B0", Offset = "0x62D92B0", VA = "0x1862DA4B0")]
		public BHINLGOPKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62DA430", Offset = "0x62D9230", VA = "0x1862DA430", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62DA470", Offset = "0x62D9270", VA = "0x1862DA470", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class BLODFDFKBHB : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x62DA6A0", Offset = "0x62D94A0", VA = "0x1862DA6A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62DA660", Offset = "0x62D9460", VA = "0x1862DA660")]
		public BLODFDFKBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62DA5E0", Offset = "0x62D93E0", VA = "0x1862DA5E0", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62DA620", Offset = "0x62D9420", VA = "0x1862DA620", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class MGIGDBPIFGN : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x62DBA80", Offset = "0x62DA880", VA = "0x1862DBA80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62DBA40", Offset = "0x62DA840", VA = "0x1862DBA40")]
		public MGIGDBPIFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62DB9C0", Offset = "0x62DA7C0", VA = "0x1862DB9C0", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62DBA00", Offset = "0x62DA800", VA = "0x1862DBA00", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class MKHGAAIALBA : Property<KFECEFAMAOP, KLPODJLKBNG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x62DBB70", Offset = "0x62DA970", VA = "0x1862DBB70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62DBB30", Offset = "0x62DA930", VA = "0x1862DBB30")]
		public MKHGAAIALBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62DBAB0", Offset = "0x62DA8B0", VA = "0x1862DBAB0", Slot = "14")]
		public override KLPODJLKBNG<Delegate> GetValue(KFECEFAMAOP COEPBABOGAM)
		{
			return default(KLPODJLKBNG<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62DBAF0", Offset = "0x62DA8F0", VA = "0x1862DBAF0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP COEPBABOGAM, KLPODJLKBNG<Delegate> DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62DC090", Offset = "0x62DAE90", VA = "0x1862DC090")]
	public PDCDPLBHPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class GODKMNBBPNB : ContainerPropertyBag<KFECEFAMAOP.KFPBJJFAKOC>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class NANKCEHEMPG : Property<KFECEFAMAOP.KFPBJJFAKOC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62DBD40", Offset = "0x62DAB40", VA = "0x1862DBD40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62DBD00", Offset = "0x62DAB00", VA = "0x1862DBD00")]
		public NANKCEHEMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F20", Offset = "0x8B4D20", VA = "0x1808B5F20", Slot = "14")]
		public override object GetValue(KFECEFAMAOP.KFPBJJFAKOC COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4275CB0", Offset = "0x4274AB0", VA = "0x184275CB0", Slot = "15")]
		public override void SetValue(KFECEFAMAOP.KFPBJJFAKOC COEPBABOGAM, object DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62DB0E0", Offset = "0x62D9EE0", VA = "0x1862DB0E0")]
	public GODKMNBBPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class DFAJBEKGGOM : ContainerPropertyBag<KLPODJLKBNG<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62DA8E0", Offset = "0x62D96E0", VA = "0x1862DA8E0")]
	public DFAJBEKGGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class LJIGOBCPEAN : ContainerPropertyBag<OPEAFGONECO>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class MNDBAJJIPGK : Property<OPEAFGONECO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x62DBBE0", Offset = "0x62DA9E0", VA = "0x1862DBBE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62DBBA0", Offset = "0x62DA9A0", VA = "0x1862DBBA0")]
		public MNDBAJJIPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62DA520", Offset = "0x62D9320", VA = "0x1862DA520", Slot = "14")]
		public override Rigidbody GetValue(OPEAFGONECO COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62DA540", Offset = "0x62D9340", VA = "0x1862DA540", Slot = "15")]
		public override void SetValue(OPEAFGONECO COEPBABOGAM, Rigidbody DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62DB8A0", Offset = "0x62DA6A0", VA = "0x1862DB8A0")]
	public LJIGOBCPEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class PNNOKPADMKH : ContainerPropertyBag<FDFJCPCGHCO>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class KGIADFHBIMH : Property<FDFJCPCGHCO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62DB6A0", Offset = "0x62DA4A0", VA = "0x1862DB6A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62DB660", Offset = "0x62DA460", VA = "0x1862DB660")]
		public KGIADFHBIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62DA520", Offset = "0x62D9320", VA = "0x1862DA520", Slot = "14")]
		public override object GetValue(FDFJCPCGHCO COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62DA540", Offset = "0x62D9340", VA = "0x1862DA540", Slot = "15")]
		public override void SetValue(FDFJCPCGHCO COEPBABOGAM, object DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62DC7D0", Offset = "0x62DB5D0", VA = "0x1862DC7D0")]
	public PNNOKPADMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class PIPJJDJAGEN : ContainerPropertyBag<KKCFMOIPNEG>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class BKIJAMCMNPF : Property<KKCFMOIPNEG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x62DA5B0", Offset = "0x62D93B0", VA = "0x1862DA5B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool LIIHEFGBOIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62DA570", Offset = "0x62D9370", VA = "0x1862DA570")]
		public BKIJAMCMNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62DA520", Offset = "0x62D9320", VA = "0x1862DA520", Slot = "14")]
		public override object GetValue(KKCFMOIPNEG COEPBABOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62DA540", Offset = "0x62D9340", VA = "0x1862DA540", Slot = "15")]
		public override void SetValue(KKCFMOIPNEG COEPBABOGAM, object DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62DC6F0", Offset = "0x62DB4F0", VA = "0x1862DC6F0")]
	public PIPJJDJAGEN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62DC8B0", Offset = "0x62DB6B0", VA = "0x1862DC8B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class LDJNHENMGAB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LDJNHENMGAB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
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
