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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
	public class _AssemblyIndex : CDBADINMILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6378F00", Offset = "0x6377F00", VA = "0x186378F00", Slot = "8")]
		public override void OEBDDKFLPEG(LILEGJCEJGA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6378BC0", Offset = "0x6377BC0", VA = "0x186378BC0", Slot = "7")]
		public override void MHCNAHFEDEL(EHACPLBCGCL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6379300", Offset = "0x6378300", VA = "0x186379300")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CKGGNAGAMOG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6376A80", Offset = "0x6375A80", VA = "0x186376A80", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EJDNFACEIFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ANIMIPICCBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MDAKJKEGPKH;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CIAMDEMHCAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity MDAKJKEGPKH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AMPLDFHFLNF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<FJBOLMBNOCF> MAELDAECGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> IMLOLPAAHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle NFHOJLAMIPA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EDCFENPGADL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6376840", Offset = "0x6375840", VA = "0x186376840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6376A30", Offset = "0x6375A30", VA = "0x186376A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4750B70", Offset = "0x474FB70", VA = "0x184750B70")]
	public AMPLDFHFLNF(NativeList<FJBOLMBNOCF> MAELDAECGOK, NativeList<Entity> IMLOLPAAHLM, JobHandle NFHOJLAMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6376910", Offset = "0x6375910", VA = "0x186376910")]
	public (Entity, NativeSlice<Entity>) FKHFNALPLPF(int AFFJDCKHCJD)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63768B0", Offset = "0x63758B0", VA = "0x1863768B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FJBOLMBNOCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity OPFDMIOAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int NGKDOMEFDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int GOKGFKKLOOJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCJBLFEEFFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HACHAIGBDPF(bool CKAIPHGBFND);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PBJBKNABCBD : IEquatable<PBJBKNABCBD>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool APECKNPHOHO(int BFJJJMDOJBG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool NGBPHAIBECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool MLGCLNAIIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool NNODAJMHPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool MKNBLCIDPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly APECKNPHOHO DFHMFKDBEAI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6378510", Offset = "0x6377510", VA = "0x186378510")]
	public PBJBKNABCBD(JIDDLIBAHMP ODGEOOFAOHB, APECKNPHOHO DFHMFKDBEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63784E0", Offset = "0x63774E0", VA = "0x1863784E0")]
	public PBJBKNABCBD(bool NGBPHAIBECO, bool MLGCLNAIIHE, bool NNODAJMHPOO, bool MKNBLCIDPMN, APECKNPHOHO DFHMFKDBEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6378480", Offset = "0x6377480", VA = "0x186378480")]
	public bool KJGLPFDCEMK(int BFJJJMDOJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6378280", Offset = "0x6377280", VA = "0x186378280")]
	public bool ABNAEKFEOCH(int BFJJJMDOJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6378430", Offset = "0x6377430", VA = "0x186378430")]
	public bool KBLMFFPGEDN(int BFJJJMDOJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63784B0", Offset = "0x63774B0", VA = "0x1863784B0")]
	public bool LBIFJJEEFCK(int BFJJJMDOJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63782B0", Offset = "0x63772B0", VA = "0x1863782B0", Slot = "4")]
	public bool Equals(PBJBKNABCBD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63782E0", Offset = "0x63772E0", VA = "0x1863782E0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6378390", Offset = "0x6377390", VA = "0x186378390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6378460", Offset = "0x6377460", VA = "0x186378460")]
	private bool KCLCBKPGGNA(int BFJJJMDOJBG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OOAJLPJOMLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HOPMLKPDAMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DFBIPNNJIAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct JCHEPMFMCKM : IBufferElementData, IEquatable<JCHEPMFMCKM>, LFHLPFIFIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity HJKHNDILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int ECHFOFBAGPB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity CHHEJCGKNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6377A30", Offset = "0x6376A30", VA = "0x186377A30", Slot = "4")]
	public bool Equals(JCHEPMFMCKM JNHFAFOIKEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JHGFDLFHILF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity PKHKPAPOMDJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LFHLPFIFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6376A80", Offset = "0x6375A80", VA = "0x186376A80", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BNCIIEOFJJH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool JAKHALGPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint GCFKLNLMGEB;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool FGJBDAONBIL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct FEKELMKAMDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint ENGKEIONPBF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6377270", Offset = "0x6376270", VA = "0x186377270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ENICPHPPFCP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int PGMBNNJMIFL;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FIKFBJHGIHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle ALOMPHKIBJG;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct AGLKIOMOLIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int PGMBNNJMIFL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OLIGHLLCMFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GEIGHKAIEHM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int PGMBNNJMIFL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DEAHDOANBNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IBIPCKLOBJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BJLIIAEEFPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PLDJDJFBGOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode LEHMFANBACM;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EJDCCEJOAHA]
public struct DOKDJKHNNEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public DCFIIAFEJOH JOHALJHLKIK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly DOKDJKHNNEM FNEBJKDLGHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct EIANGBCJCLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HOLMCCALFKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IJAOFBFMBBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct OCKALGJEGNO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity HJKHNDILIPH;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IJAKAAIDCPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity NNHBJFPLAAA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct OPKDBINOKBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OOJHGBOCCGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity OPFDMIOAEHD;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BDODDGEIOCB : PLEKLJEIOFK, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EJACCNNJNJP PANJKGBNGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EJACCNNJNJP);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DPOFHJAOBEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 BBBLGHEEJOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KKFHKKFOLDJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[EJDCCEJOAHA]
public struct CMBAJLLFCEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 FJMKIPCPEGP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly CMBAJLLFCEC FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[EJDCCEJOAHA]
public struct HKEOFHHMMPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 FJMKIPCPEGP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly HKEOFHHMMPA FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct AOEDDKCHFJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 GMFGADNAJAD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DDCFLGCCMLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 PJHHOHNGKFC;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[EJDCCEJOAHA]
public struct IOHJDNLBALD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float HHGGABNCADJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IOHJDNLBALD FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[EJDCCEJOAHA]
public struct MFFFMIKDKBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float PNOIJOAKOEK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MFFFMIKDKBK FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct IBMKEDABGIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 FCDBGFFMOFG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IDJOBOFEPKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public KDOAGIGOPNE IIEIOLOGIHI;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GPAAFDINIGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public KDOAGIGOPNE GDJOLJGOCEH;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DNNENOGFPBI]
public struct HCDCHLELODE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity KNIDMAMMIEJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BLMBHDPEHLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KEKBHOPJCAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ANHPHPAKIAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints LDMDMBPNDBF;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[EJDCCEJOAHA]
public struct IKAJONABGFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float KLAECCBPPOI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IKAJONABGFG FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct OKLEGDGPEGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float MFCKJHGMLFA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DIHGHIBMLDL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct CEJFFOEHKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object ACBFHDGPGOP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject HOHLOJNOGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object PCNOHKBBPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object NPIMNOPEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public CEJFFOEHKDP ACBFHDGPGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate LGJHNHEMDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate FCCFFOBEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LCOMMCMOLLP<Delegate> IJKHDOKJMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LCOMMCMOLLP<Delegate> PCGMGGGPBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LCOMMCMOLLP<Delegate> BEKHCEAKELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public LCOMMCMOLLP<Delegate> ONBPPDJDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public LCOMMCMOLLP<Delegate> FFOIPIDLEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LCOMMCMOLLP<Delegate> MFPNIIHNJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LCOMMCMOLLP<Delegate> IBLJLOJKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public LCOMMCMOLLP<Delegate> LKPODNNECDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LCOMMCMOLLP<Delegate> HKFAILPHMOG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6376DA0", Offset = "0x6375DA0", VA = "0x186376DA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DIHGHIBMLDL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MBJAPPADGMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EFLOKMIJKEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int BNKMMOPEJOB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static EFLOKMIJKEI NCBCBLCGNHJ(int LDGMLLMKHLF)
	{
		return default(EFLOKMIJKEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BJIFFGODDLO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody JPKDDDJNLCK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6376B50", Offset = "0x6375B50", VA = "0x186376B50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public BJIFFGODDLO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct GEGGOIMPOEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct KKKIABHLPOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 DNLKJNNJFNH;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct DBGGKBMBFCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 KKLIKHAJECJ;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[EJDCCEJOAHA]
public struct LOMKIHMAKGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float HKINPFHGEHD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly LOMKIHMAKGN FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GPKGICPOFED : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object JMHEHGFJIMH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63774C0", Offset = "0x63764C0", VA = "0x1863774C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public GPKGICPOFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CCFPLEIKKAA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object NFJDGACJOLP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6376BC0", Offset = "0x6375BC0", VA = "0x186376BC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CCFPLEIKKAA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LEOGKGAKECN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct GOOLOLOJEJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct OMLBNPANACG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CDGPLCIKMFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes ONGJKHHOIAM;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DNNENOGFPBI]
public struct IGMPJMJKCKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity HOOFDCHFFMO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static IGMPJMJKCKM NCBCBLCGNHJ(Entity LDGMLLMKHLF)
	{
		return default(IGMPJMJKCKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct DFNFKPALGGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity KNIDMAMMIEJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static DFNFKPALGGB NCBCBLCGNHJ(Entity KNIDMAMMIEJ)
	{
		return default(DFNFKPALGGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct OFNENHJBJHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity FLFLMPIOPFH;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KGNNBPOKOMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity FLFLMPIOPFH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct PHJGKPNKBIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity KNCHAHCEELP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static PHJGKPNKBIP NCBCBLCGNHJ(Entity KNIDMAMMIEJ)
	{
		return default(PHJGKPNKBIP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct NKCHGKMHKPO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EOFCGIGLPKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint OECHNNBOAGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DNNENOGFPBI]
internal struct CADGKCENIOP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity ALBKJLHFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int GPEHCABDGEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct IJOJMGJNANP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity OHAPFGLKHDC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct NPDHOGFPLJO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct IGDJKFDNAPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint GCFKLNLMGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int PDPPILKDEAF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
	public IGDJKFDNAPM(uint JPBGKCHOLKH, int MIJAMLDBMBP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct MMIEEEDPINA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KLPKDMBKKFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct PIFLPBPHDFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct MLGANKOMHPJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EEHGNLLNBKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct MOJHGAPBCIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct JMABOOODKCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HBNKIGAOPJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct PMLIANOFKFL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct FJCHCJEDJDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct PGIFHHNDEIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct GJOPOIICGHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct DABDNPNOIAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct OEPHOOEIBEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct HEIALHOCBKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PNPOGMHLHFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct FJCIGAAJMOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct JFBBFEHEIJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DBHEDDDLBNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct KDOBFJLLOBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct MKBGAPGHNEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct FOLHHLKEGHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct KLALNLPLKGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct KGCOIDEHPBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct LEBHPFOFKCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LOAFLIIDKEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct ODOCIMHCKHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[DNNENOGFPBI]
public struct GLJOPBALOIO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes KHOLDKJFPPN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IDGGEFBAOIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct ADHADCIKALI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct OALDHCHDKHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct JEMNIICNJJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ALJEJMOIFME : IComponentData, IComparable<ALJEJMOIFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int ECDFKNGPFIP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18A9610", Offset = "0x18A8610", VA = "0x1818A9610", Slot = "4")]
	public int CompareTo(ALJEJMOIFME JNHFAFOIKEO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct LHMNADCCKKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct DIIKFDPHOKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion CKCOAEGKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 BJIKBOECFPB;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct DJNFHPBEAJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BDHJODFKKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NKGDPIBFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float FDDPJPNIPKD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NOFAOAKGBNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct CHGMBEGEONE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct LOFNDDHEJIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct DPFGHGNFADA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int PGMBNNJMIFL;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DNNENOGFPBI]
public struct BCMKCGDJJCM : ISystemStateBufferElementData, IBufferElementData, LFHLPFIFIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity MOOOFCHMDDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity IBJNHNLOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[EJDCCEJOAHA]
public struct PMMGJDPOHAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 GDMJPEMPIOL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PMMGJDPOHAK FNEBJKDLGHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IMPNCCAGFDA : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DMDKLJEEFJM : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct FHNGKLBDDMB : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct OFPMCDBOMLJ : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[EJDCCEJOAHA]
public struct LIKKJHPHHFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 IPMNAPGBLEC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LIKKJHPHHFO FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct GOIIDLOHIMG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int KEGLPPJGABF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GPEHCABDGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x63774A0", Offset = "0x63764A0", VA = "0x1863774A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63774B0", Offset = "0x63764B0", VA = "0x1863774B0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[EJDCCEJOAHA]
public struct LEGNNFENHPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 CDPKOHAEGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly LEGNNFENHPC FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[EJDCCEJOAHA]
public struct MMDPJAMCPON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 BJIKBOECFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion CKCOAEGKOKA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly MMDPJAMCPON FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class IJNEMPICECB
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[EJDCCEJOAHA]
public struct KGNLPBACIFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float KLHEHMNKHJJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly KGNLPBACIFD FNEBJKDLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PBHOALCOHCI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> GDLGHCFALIO;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ACJPJHLHPEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> GDLGHCFALIO;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class ACJEOHJGOIF : ContainerPropertyBag<DIHGHIBMLDL>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class IEBFKFCPBII : Property<DIHGHIBMLDL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63778A0", Offset = "0x63768A0", VA = "0x1863778A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6377860", Offset = "0x6376860", VA = "0x186377860")]
		public IEBFKFCPBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6376710", Offset = "0x6375710", VA = "0x186376710", Slot = "14")]
		public override GameObject GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6376730", Offset = "0x6375730", VA = "0x186376730", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, GameObject LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class EMPHHKMODDE : Property<DIHGHIBMLDL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6377150", Offset = "0x6376150", VA = "0x186377150", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6377110", Offset = "0x6376110", VA = "0x186377110")]
		public EMPHHKMODDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x63770C0", Offset = "0x63760C0", VA = "0x1863770C0", Slot = "14")]
		public override object GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x63770E0", Offset = "0x63760E0", VA = "0x1863770E0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, object LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class EMNFCKNMKNH : Property<DIHGHIBMLDL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6377090", Offset = "0x6376090", VA = "0x186377090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6377050", Offset = "0x6376050", VA = "0x186377050")]
		public EMNFCKNMKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6377000", Offset = "0x6376000", VA = "0x186377000", Slot = "14")]
		public override object GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6377020", Offset = "0x6376020", VA = "0x186377020", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, object LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class FOIOAEHJBKM : Property<DIHGHIBMLDL, DIHGHIBMLDL.CEJFFOEHKDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6377470", Offset = "0x6376470", VA = "0x186377470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6377430", Offset = "0x6376430", VA = "0x186377430")]
		public FOIOAEHJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63773E0", Offset = "0x63763E0", VA = "0x1863773E0", Slot = "14")]
		public override DIHGHIBMLDL.CEJFFOEHKDP GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(DIHGHIBMLDL.CEJFFOEHKDP);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6377400", Offset = "0x6376400", VA = "0x186377400", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, DIHGHIBMLDL.CEJFFOEHKDP LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class OGJFEGCECIL : Property<DIHGHIBMLDL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6378250", Offset = "0x6377250", VA = "0x186378250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6378210", Offset = "0x6377210", VA = "0x186378210")]
		public OGJFEGCECIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63781C0", Offset = "0x63771C0", VA = "0x1863781C0", Slot = "14")]
		public override Delegate GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63781E0", Offset = "0x63771E0", VA = "0x1863781E0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, Delegate LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class BIMPMPNKMIH : Property<DIHGHIBMLDL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6376B20", Offset = "0x6375B20", VA = "0x186376B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6376AE0", Offset = "0x6375AE0", VA = "0x186376AE0")]
		public BIMPMPNKMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6376A90", Offset = "0x6375A90", VA = "0x186376A90", Slot = "14")]
		public override Delegate GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6376AB0", Offset = "0x6375AB0", VA = "0x186376AB0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, Delegate LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class PNBMOODIMCB : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63786B0", Offset = "0x63776B0", VA = "0x1863786B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6378670", Offset = "0x6377670", VA = "0x186378670")]
		public PNBMOODIMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6378600", Offset = "0x6377600", VA = "0x186378600", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6378630", Offset = "0x6377630", VA = "0x186378630", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class FNPGGLDFLCA : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x63773B0", Offset = "0x63763B0", VA = "0x1863773B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6377370", Offset = "0x6376370", VA = "0x186377370")]
		public FNPGGLDFLCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6377300", Offset = "0x6376300", VA = "0x186377300", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6377330", Offset = "0x6376330", VA = "0x186377330", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class HHMCJCDMMJJ : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x63776D0", Offset = "0x63766D0", VA = "0x1863776D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6377690", Offset = "0x6376690", VA = "0x186377690")]
		public HHMCJCDMMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6377620", Offset = "0x6376620", VA = "0x186377620", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6377650", Offset = "0x6376650", VA = "0x186377650", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class LGAGBEJNLMG : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6377D50", Offset = "0x6376D50", VA = "0x186377D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6377D10", Offset = "0x6376D10", VA = "0x186377D10")]
		public LGAGBEJNLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6377C90", Offset = "0x6376C90", VA = "0x186377C90", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6377CD0", Offset = "0x6376CD0", VA = "0x186377CD0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class NBMMCABAOGO : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x63780A0", Offset = "0x63770A0", VA = "0x1863780A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6378060", Offset = "0x6377060", VA = "0x186378060")]
		public NBMMCABAOGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6377FE0", Offset = "0x6376FE0", VA = "0x186377FE0", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6378020", Offset = "0x6377020", VA = "0x186378020", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class NNCDBELPDOL : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6378190", Offset = "0x6377190", VA = "0x186378190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6378150", Offset = "0x6377150", VA = "0x186378150")]
		public NNCDBELPDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63780D0", Offset = "0x63770D0", VA = "0x1863780D0", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6378110", Offset = "0x6377110", VA = "0x186378110", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class FADKGOCKMOI : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6377240", Offset = "0x6376240", VA = "0x186377240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6377200", Offset = "0x6376200", VA = "0x186377200")]
		public FADKGOCKMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6377180", Offset = "0x6376180", VA = "0x186377180", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63771C0", Offset = "0x63761C0", VA = "0x1863771C0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class HDMKLDMOJBI : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x63775F0", Offset = "0x63765F0", VA = "0x1863775F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63775B0", Offset = "0x63765B0", VA = "0x1863775B0")]
		public HDMKLDMOJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6377530", Offset = "0x6376530", VA = "0x186377530", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6377570", Offset = "0x6376570", VA = "0x186377570", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class DOGCFJJMJJK : Property<DIHGHIBMLDL, LCOMMCMOLLP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6376F90", Offset = "0x6375F90", VA = "0x186376F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6376F50", Offset = "0x6375F50", VA = "0x186376F50")]
		public DOGCFJJMJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6376ED0", Offset = "0x6375ED0", VA = "0x186376ED0", Slot = "14")]
		public override LCOMMCMOLLP<Delegate> GetValue(DIHGHIBMLDL MJBHKMGKNLL)
		{
			return default(LCOMMCMOLLP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6376F10", Offset = "0x6375F10", VA = "0x186376F10", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL MJBHKMGKNLL, LCOMMCMOLLP<Delegate> LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63760B0", Offset = "0x63750B0", VA = "0x1863760B0")]
	public ACJEOHJGOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class IFOJACNMHML : ContainerPropertyBag<DIHGHIBMLDL.CEJFFOEHKDP>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class AJLIJHLEJCB : Property<DIHGHIBMLDL.CEJFFOEHKDP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6376810", Offset = "0x6375810", VA = "0x186376810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63767D0", Offset = "0x63757D0", VA = "0x1863767D0")]
		public AJLIJHLEJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D70", Offset = "0x8C4D70", VA = "0x1808C5D70", Slot = "14")]
		public override object GetValue(DIHGHIBMLDL.CEJFFOEHKDP MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x42B4BF0", Offset = "0x42B3BF0", VA = "0x1842B4BF0", Slot = "15")]
		public override void SetValue(DIHGHIBMLDL.CEJFFOEHKDP MJBHKMGKNLL, object LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x63778D0", Offset = "0x63768D0", VA = "0x1863778D0")]
	public IFOJACNMHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class HHNGGLNCNEP : ContainerPropertyBag<LCOMMCMOLLP<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6377700", Offset = "0x6376700", VA = "0x186377700")]
	public HHNGGLNCNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KFGNNLPFFLB : ContainerPropertyBag<BJIFFGODDLO>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class JGIBKPLEEPK : Property<BJIFFGODDLO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6377AC0", Offset = "0x6376AC0", VA = "0x186377AC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6377A80", Offset = "0x6376A80", VA = "0x186377A80")]
		public JGIBKPLEEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6376710", Offset = "0x6375710", VA = "0x186376710", Slot = "14")]
		public override Rigidbody GetValue(BJIFFGODDLO MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6376730", Offset = "0x6375730", VA = "0x186376730", Slot = "15")]
		public override void SetValue(BJIFFGODDLO MJBHKMGKNLL, Rigidbody LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6377AF0", Offset = "0x6376AF0", VA = "0x186377AF0")]
	public KFGNNLPFFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class DNCMOFOMHOD : ContainerPropertyBag<GPKGICPOFED>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class CDELCPCJPJA : Property<GPKGICPOFED, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6376C70", Offset = "0x6375C70", VA = "0x186376C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6376C30", Offset = "0x6375C30", VA = "0x186376C30")]
		public CDELCPCJPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6376710", Offset = "0x6375710", VA = "0x186376710", Slot = "14")]
		public override object GetValue(GPKGICPOFED MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6376730", Offset = "0x6375730", VA = "0x186376730", Slot = "15")]
		public override void SetValue(GPKGICPOFED MJBHKMGKNLL, object LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6376DF0", Offset = "0x6375DF0", VA = "0x186376DF0")]
	public DNCMOFOMHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class AAPMBMBNMDB : ContainerPropertyBag<CCFPLEIKKAA>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class AFAHMKNGJCK : Property<CCFPLEIKKAA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string FJOKHGLGEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x63767A0", Offset = "0x63757A0", VA = "0x1863767A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool CNGKFBOLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6376760", Offset = "0x6375760", VA = "0x186376760")]
		public AFAHMKNGJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6376710", Offset = "0x6375710", VA = "0x186376710", Slot = "14")]
		public override object GetValue(CCFPLEIKKAA MJBHKMGKNLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6376730", Offset = "0x6375730", VA = "0x186376730", Slot = "15")]
		public override void SetValue(CCFPLEIKKAA MJBHKMGKNLL, object LDGMLLMKHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6375FD0", Offset = "0x6374FD0", VA = "0x186375FD0")]
	public AAPMBMBNMDB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x63786E0", Offset = "0x63776E0", VA = "0x1863786E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class CKEHPJAMLMC
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CKEHPJAMLMC()
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
