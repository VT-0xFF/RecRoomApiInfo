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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : KNDIHPLNFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69ADB40", Offset = "0x69AC540", VA = "0x1869ADB40", Slot = "8")]
		public override void JNGALHFGLMK(FBOEMILKFHO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69AD740", Offset = "0x69AC140", VA = "0x1869AD740", Slot = "7")]
		public override void BPFPHHNBNPN(HBDBBGADCIE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69ADF40", Offset = "0x69AC940", VA = "0x1869ADF40")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JBCNOBJLPBA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69AAB50", Offset = "0x69A9550", VA = "0x1869AAB50", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LIICLEGLGCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EFEJFMEJCIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity OEGNDLOCBFP;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KJBKLNPKCGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity OEGNDLOCBFP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JBGCEOCMBEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<MAPACANOHCF> OHJCPCFAIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> DMABFBFEEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle IOPBMLMLGLO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JJCCGNCICLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69AC350", Offset = "0x69AAD50", VA = "0x1869AC350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69AC3C0", Offset = "0x69AADC0", VA = "0x1869AC3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C4A230", Offset = "0x4C48C30", VA = "0x184C4A230")]
	public JBGCEOCMBEP(NativeList<MAPACANOHCF> OHJCPCFAIHG, NativeList<Entity> DMABFBFEEEB, JobHandle IOPBMLMLGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69AC470", Offset = "0x69AAE70", VA = "0x1869AC470")]
	public (Entity, NativeSlice<Entity>) EPNJMDFCJAI(int KLFNJJLKNGE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69AC410", Offset = "0x69AAE10", VA = "0x1869AC410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MAPACANOHCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity GPKGNPPAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int LJEHDHLGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int NDKEFFPEPII;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDDGDDGILIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPCAIPNIIE(bool CIKLPOKOGBD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct EOGELEDJNHE : IEquatable<EOGELEDJNHE>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool PNAHGPBNNJF(int IOILMCLNKLG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool PLAGEPGFJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool CAFELCICIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OADBPKOGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool KIKGFHKNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PNAHGPBNNJF ANAGKGOIEJA;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB90", Offset = "0x69AA590", VA = "0x1869ABB90")]
	public EOGELEDJNHE(FCGHOGLKKBI GBNNPAAOJAG, PNAHGPBNNJF ANAGKGOIEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69ABBD0", Offset = "0x69AA5D0", VA = "0x1869ABBD0")]
	public EOGELEDJNHE(bool PLAGEPGFJIF, bool CAFELCICIIN, bool OADBPKOGPGE, bool KIKGFHKNBEE, PNAHGPBNNJF ANAGKGOIEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69AB960", Offset = "0x69AA360", VA = "0x1869AB960")]
	public bool CBCFJCPOOKL(int IOILMCLNKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB60", Offset = "0x69AA560", VA = "0x1869ABB60")]
	public bool MEBFADKIMLE(int IOILMCLNKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69AB930", Offset = "0x69AA330", VA = "0x1869AB930")]
	public bool BNBDPODPDKO(int IOILMCLNKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69AB990", Offset = "0x69AA390", VA = "0x1869AB990")]
	public bool CLCGBKEPBPH(int IOILMCLNKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69AB9C0", Offset = "0x69AA3C0", VA = "0x1869AB9C0", Slot = "4")]
	public bool Equals(EOGELEDJNHE HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69AB9F0", Offset = "0x69AA3F0", VA = "0x1869AB9F0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69ABAA0", Offset = "0x69AA4A0", VA = "0x1869ABAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB40", Offset = "0x69AA540", VA = "0x1869ABB40")]
	private bool LBKJCDHEIAC(int IOILMCLNKLG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct COJJPGFBMNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IPAIAFFMMJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DLCENPLBEGI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct AKIMOMEDNOK : IBufferElementData, IEquatable<AKIMOMEDNOK>, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity DPEMCBKEJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int LGCICENBILD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity EFJNIFNPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69AAA10", Offset = "0x69A9410", VA = "0x1869AAA10", Slot = "4")]
	public bool Equals(AKIMOMEDNOK HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct LADHPHKJLAD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct PJKDCEIHIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LECFCEOOFHB LAHDINJPDFG;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
		public PJKDCEIHIPH(LECFCEOOFHB MPDBHILIION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69AD240", Offset = "0x69ABC40", VA = "0x1869AD240")]
		public bool IJKIMOGODNP(LADHPHKJLAD NEGNCKLFPNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69AD250", Offset = "0x69ABC50", VA = "0x1869AD250")]
		public bool PDCAGPKOKOJ(LADHPHKJLAD NEGNCKLFPNB, LECFCEOOFHB ONKKABFJNEE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly LECFCEOOFHB GHLOHPPNJME;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	public LADHPHKJLAD(LECFCEOOFHB GHLOHPPNJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69ACA10", Offset = "0x69AB410", VA = "0x1869ACA10")]
	public LADHPHKJLAD IHMFNIBBFEG(LECFCEOOFHB EBHBLJKBOJO)
	{
		return default(LADHPHKJLAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69ACA00", Offset = "0x69AB400", VA = "0x1869ACA00")]
	public LADHPHKJLAD DINAAFPCFCP(LECFCEOOFHB BPBHAEOBBHE)
	{
		return default(LADHPHKJLAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69ACA20", Offset = "0x69AB420", VA = "0x1869ACA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum LECFCEOOFHB : byte
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
public enum PMHFCCOBFPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IHFLGJBEKFO]
public struct GHMDPKOJGPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PMHFCCOBFPG GHLOHPPNJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool PGPMPIHFPLG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GJLLFGCOMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69ABF30", Offset = "0x69AA930", VA = "0x1869ABF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF40", Offset = "0x69AA940", VA = "0x1869ABF40")]
	private GHMDPKOJGPK(PMHFCCOBFPG GHLOHPPNJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF10", Offset = "0x69AA910", VA = "0x1869ABF10")]
	public GHMDPKOJGPK IHMFNIBBFEG(PMHFCCOBFPG EBHBLJKBOJO)
	{
		return default(GHMDPKOJGPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69ABEF0", Offset = "0x69AA8F0", VA = "0x1869ABEF0")]
	public GHMDPKOJGPK DINAAFPCFCP(PMHFCCOBFPG BPBHAEOBBHE)
	{
		return default(GHMDPKOJGPK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EBIGBGPMOKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LAOOBOLDBNH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity LDGODJEJEMJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, IGEIIFAFIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69AAB50", Offset = "0x69A9550", VA = "0x1869AAB50", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[IHFLGJBEKFO]
public struct APPOHPCLGIM : ISystemStateBufferElementData, IBufferElementData, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity INJBCGOEBHC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity OEJKIADKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JEKNJPFJAGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity FGGPHDILANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity IGLJEOGPJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity HGIMPKKKHNE;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct CMAAJEJJEDD<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool JPOGMMCJBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint APNPKHAMLJJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool PJAEDMNLDEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct MMPANABOFCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint LFKNNNHGFFD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69ACF80", Offset = "0x69AB980", VA = "0x1869ACF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CPMIAAGLFHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int CEGCHAFCKNG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CABPDJIHBPE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public GCHandle DIOBJDJIECP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct MDLDEHFKJAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int CEGCHAFCKNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct FBJLADKBFLF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct DPCKGFNAIPA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int CEGCHAFCKNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BLDKDGAOMJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LPLBINFNJIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HLIMJAJAKMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MBMLFHNOGMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode AELNPNKLJME;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[IKEMKBLDMBP]
public struct KEBPICIPBPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public KFIHHKNEBMF IHANGDPGBEH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KEBPICIPBPB LDMJBAPJLGF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NMBEPIGLFDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GACKPNKOOOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PDKFJKMFJJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[InternalBufferCapacity(0)]
public struct EJHEDMOONHA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity DPEMCBKEJDJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CPGHAPGMCNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity EMNGIAIDBPA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JKOOKMKFIIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DLAPBAFEPKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity GPKGNPPAAHE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PPHFNHNMFDP : AGBGMNKBPBB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EEAMKEIKHIH AFJEKJHILFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EEAMKEIKHIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BCCPPJDCNMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 EEIBIMBJMLF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct AFNBAPFIGNE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[IKEMKBLDMBP]
public struct CNKMEELGIGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3x3 GHBEHJPLLBG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CNKMEELGIGJ LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IKEMKBLDMBP]
public struct BBIDMOFGPEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 GHBEHJPLLBG;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly BBIDMOFGPEE LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LJBFEJALENJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3 KMLKMPGEDIL;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct EHBLDFHNAAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 HFBHHNMJMIO;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[IKEMKBLDMBP]
public struct KEAMHEFFIDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float HJDCPKOBHGD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly KEAMHEFFIDK LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[IKEMKBLDMBP]
public struct MGIKKBACNKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float LODEJFOHOJP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MGIKKBACNKJ LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HNFLINECMMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float3 BALABFLOFEM;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KJHBHIMAIPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AHFBHELEKED NNJNCPOKHGJ;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BIAOLFKAKKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public AHFBHELEKED KKNHNJFEKCO;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[IHFLGJBEKFO]
public struct FAFDCIPDADN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity INJBCGOEBHC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HAKFLKMEKDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct AEOBLCLDMAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JGJIHDJGILL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public RigidbodyConstraints DKFFHGEIPJM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[IKEMKBLDMBP]
public struct CEBDMADMLCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float LGJHLMDJPEE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly CEBDMADMLCD LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GDNEPICLHAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float EOBNNHKBNDK;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HPGJMHGDAMA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FFENLDPFBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public object BMLCBLNGOHF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public GameObject AOOABPFBFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public object FBFBFNIKALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object FPEALNFFIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public FFENLDPFBKH BMLCBLNGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Delegate ENBFGGJCEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate EMHKEAFBIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public PAIPBEOLENN<Delegate> DKHBEBFCPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public PAIPBEOLENN<Delegate> NHKKJMFOLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public PAIPBEOLENN<Delegate> GEBHPPBIAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public PAIPBEOLENN<Delegate> CBEKLOJLACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public PAIPBEOLENN<Delegate> GEJGMNGONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public PAIPBEOLENN<Delegate> LEHEBHNPOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public PAIPBEOLENN<Delegate> IDENOKHKGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public PAIPBEOLENN<Delegate> LLEGCGIPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public PAIPBEOLENN<Delegate> FEHBCHOFOLD;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69AC1D0", Offset = "0x69AABD0", VA = "0x1869AC1D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public HPGJMHGDAMA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct KFEAJFHOILG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KEGBGFMOHDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int KJGCLILPPEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static KEGBGFMOHDJ OCHPDIOAFKC(int DBOBEHLEAAE)
	{
		return default(KEGBGFMOHDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ACALCMNFIGH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Rigidbody AOJGKLNIGLI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69AA9A0", Offset = "0x69A93A0", VA = "0x1869AA9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public ACALCMNFIGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct KIGNAILJFJL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct FFACBENADGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 FJPMHBKDAMB;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PKEJLHLJMHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 PBGBFAMBAMF;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[IKEMKBLDMBP]
public struct CIAEFDLPMNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MOBELBFJFDG;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CIAEFDLPMNN LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class FBJJGLCMBCA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public object CJIPKJCPFAF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69ABC00", Offset = "0x69AA600", VA = "0x1869ABC00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public FBJJGLCMBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GLJMCIHIKGD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object HGOFOCHNJBN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF50", Offset = "0x69AA950", VA = "0x1869ABF50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GLJMCIHIKGD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct AOABDMHCIEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MABCMAOBPNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PBDOPDCCNNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct PGOMONFPHIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct KELKNILFJCG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct KAFMKPMLCKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public FixedString32Bytes CCMEKJGADHN;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[IHFLGJBEKFO]
public struct JGFCIBPGOPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity GLJMOLNEMGJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static JGFCIBPGOPK OCHPDIOAFKC(Entity DBOBEHLEAAE)
	{
		return default(JGFCIBPGOPK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct OPOLNIGFGCG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity INJBCGOEBHC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static OPOLNIGFGCG OCHPDIOAFKC(Entity INJBCGOEBHC)
	{
		return default(OPOLNIGFGCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct ABPCNEHJDEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity BIOJJEHIGGL;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MDKKFOAMDMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity BIOJJEHIGGL;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal struct DMDFFONMPNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity HJFOCHKEBBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static DMDFFONMPNN OCHPDIOAFKC(Entity INJBCGOEBHC)
	{
		return default(DMDFFONMPNN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct AEJPKJNLBAK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct JIDNNLBHDJF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct JKKIMIAAEFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public uint OKMBFDMPMHM;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[IHFLGJBEKFO]
internal struct BGHPBHEMPHA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity PLMKIBOIKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public int ILOCEPPJPDO;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct HAMFNGLELHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity EIACEIPENBI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct JJNCNKPCCGE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct BNGHKGJKIJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public uint APNPKHAMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int HMBHPLGKHNN;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public BNGHKGJKIJG(uint FEAHNFOPCOO, int IAIDLDIKAGL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct ELDIFLLMBEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BHLNPGGEIAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BDJIPACOAAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct CMGGDAKFPIF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct OLIALLACCPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct NCBMMGABFHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NAALNHOMKKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OOOFHILDCML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal struct OEKBPOHEEHC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct ELKGODHDHBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct DALFKAJGNND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CCMBPCFFCAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct IMEMLKBMKDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct LEJBCIIONPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct CIAJGNIPCBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BHHCNALGNKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GKLKFMLCHON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct CAADCFBHCAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HBAIPOMMKPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LJMFODGCLHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AJGLDKBJGMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NKKPOIIMEBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct JFNMOFDDCAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct AEHIOLFIAKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct FNJLEHEGBBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct BBIOPBIOMHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OFFGIDDEKHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MPHNBKGBLEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[IHFLGJBEKFO]
public struct OODAJBHHHKP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FixedString32Bytes INNDIMHALJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct HGBMMJKJGDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct KOIABEJHLOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct BGONBPCMHIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct EKCCNMELFPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct HOPOFAJEFOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct EHILDKGODMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DNHKBJEJMLK : IComponentData, IComparable<DNHKBJEJMLK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int CCIMDIDMIGM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A67A40", Offset = "0x1A66440", VA = "0x181A67A40", Slot = "4")]
	public int CompareTo(DNHKBJEJMLK HENLEJBGFIE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct NNMFKDBEKKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct EDFIBPPIFFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 GLNEOPDBMFP;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct CAIIOMJFPLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float JJAGHAHMKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float HKNCOHPKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float JOFDMEBOIBG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct LOOPEMGFING : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MMPFIBOCOIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PDPJLNEGODP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JAHFMAPAJAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int CEGCHAFCKNG;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[IHFLGJBEKFO]
public struct HGDBBPHBFEI : ISystemStateBufferElementData, IBufferElementData, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity MDCEGLNACHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity OEJKIADKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[IKEMKBLDMBP]
public struct LHBGGHGLKPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float4x4 FNHGBIGDALL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly LHBGGHGLKPB LDMJBAPJLGF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct MOGMBCHHGDH : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct BILMFFFJIKM : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct OOJCBMNFEHB : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct DAEPJDGLJDH : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IKEMKBLDMBP]
public struct GEMGGPPKLPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 EEPHIDFBPBM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly GEMGGPPKLPG LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct LCDGMLHKKAF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int GKNCIIJBHLI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ILOCEPPJPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB40", Offset = "0x69AB540", VA = "0x1869ACB40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB30", Offset = "0x69AB530", VA = "0x1869ACB30")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[IKEMKBLDMBP]
public struct PFLGJLFMHGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 ELHKLLKAMME;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly PFLGJLFMHGE LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[IKEMKBLDMBP]
public struct KOMAAHGNNNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly KOMAAHGNNNH LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class BMLMECNJAND
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[IKEMKBLDMBP]
public struct LPKADBFHOHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float APNDHMHGBCH;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly LPKADBFHOHJ LDMJBAPJLGF;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct GNFPJHEOBBK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity OHMLPFICLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public KGNHGFCDFGP IOHMFKLLMFN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct ADIECKLNOIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public KGNHGFCDFGP IOHMFKLLMFN;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct AEMBCAOIMME : ISystemStateComponentData, IComponentData, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity BDGKMFGNNGD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity OEJKIADKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GKLLMCDENPO : ISystemStateBufferElementData, IBufferElementData, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity OOIJOOHKAED;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity OEJKIADKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct KGIMPLAJGDB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity OHMLPFICLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public KGNHGFCDFGP IOHMFKLLMFN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct LBMLGGDNMIL : IEqualityComparer<KGIMPLAJGDB>
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static LBMLGGDNMIL LDMJBAPJLGF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69ACA80", Offset = "0x69AB480", VA = "0x1869ACA80", Slot = "4")]
	public bool Equals(KGIMPLAJGDB PHDMOAMCFBE, KGIMPLAJGDB CPHIHAJIIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69ACAD0", Offset = "0x69AB4D0", VA = "0x1869ACAD0", Slot = "5")]
	public int GetHashCode(KGIMPLAJGDB GKHPLGCJCPF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct GHOBPNMMBBB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FixedList32Bytes<int> JLAJKJKMAEO;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct OGHFNCCPOJK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> JLAJKJKMAEO;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct ANCOPLGICHA : ISystemStateBufferElementData, IBufferElementData, IGEIIFAFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity EKNPMECJHCK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity EFJNIFNPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class DGOJHDABLHL : ContainerPropertyBag<HPGJMHGDAMA>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class CGMJGJANOAJ : Property<HPGJMHGDAMA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69AAFD0", Offset = "0x69A99D0", VA = "0x1869AAFD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF90", Offset = "0x69A9990", VA = "0x1869AAF90")]
		public CGMJGJANOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF40", Offset = "0x69A9940", VA = "0x1869AAF40", Slot = "14")]
		public override GameObject GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF60", Offset = "0x69A9960", VA = "0x1869AAF60", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, GameObject DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class IGJNONGOMDA : Property<HPGJMHGDAMA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69AC2B0", Offset = "0x69AACB0", VA = "0x1869AC2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69AC270", Offset = "0x69AAC70", VA = "0x1869AC270")]
		public IGJNONGOMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69AC220", Offset = "0x69AAC20", VA = "0x1869AC220", Slot = "14")]
		public override object GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69AC240", Offset = "0x69AAC40", VA = "0x1869AC240", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, object DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class OJDMKEMANKM : Property<HPGJMHGDAMA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69AD190", Offset = "0x69ABB90", VA = "0x1869AD190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69AD150", Offset = "0x69ABB50", VA = "0x1869AD150")]
		public OJDMKEMANKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69AD100", Offset = "0x69ABB00", VA = "0x1869AD100", Slot = "14")]
		public override object GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69AD120", Offset = "0x69ABB20", VA = "0x1869AD120", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, object DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class GPKLFHDNLOM : Property<HPGJMHGDAMA, HPGJMHGDAMA.FFENLDPFBKH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x69AC050", Offset = "0x69AAA50", VA = "0x1869AC050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69AC010", Offset = "0x69AAA10", VA = "0x1869AC010")]
		public GPKLFHDNLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69ABFC0", Offset = "0x69AA9C0", VA = "0x1869ABFC0", Slot = "14")]
		public override HPGJMHGDAMA.FFENLDPFBKH GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(HPGJMHGDAMA.FFENLDPFBKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69ABFE0", Offset = "0x69AA9E0", VA = "0x1869ABFE0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, HPGJMHGDAMA.FFENLDPFBKH DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class DHMBCJKNAGB : Property<HPGJMHGDAMA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x69AB900", Offset = "0x69AA300", VA = "0x1869AB900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69AB8C0", Offset = "0x69AA2C0", VA = "0x1869AB8C0")]
		public DHMBCJKNAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69AB870", Offset = "0x69AA270", VA = "0x1869AB870", Slot = "14")]
		public override Delegate GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69AB890", Offset = "0x69AA290", VA = "0x1869AB890", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, Delegate DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class LCNGGEOGLFM : Property<HPGJMHGDAMA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69ACCD0", Offset = "0x69AB6D0", VA = "0x1869ACCD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69ACC90", Offset = "0x69AB690", VA = "0x1869ACC90")]
		public LCNGGEOGLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69ACC40", Offset = "0x69AB640", VA = "0x1869ACC40", Slot = "14")]
		public override Delegate GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69ACC60", Offset = "0x69AB660", VA = "0x1869ACC60", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, Delegate DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class BDLMFBBBFLP : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69AAD10", Offset = "0x69A9710", VA = "0x1869AAD10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69AACD0", Offset = "0x69A96D0", VA = "0x1869AACD0")]
		public BDLMFBBBFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69AAC60", Offset = "0x69A9660", VA = "0x1869AAC60", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69AAC90", Offset = "0x69A9690", VA = "0x1869AAC90", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class FPIHAGLNFDP : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x69ABE10", Offset = "0x69AA810", VA = "0x1869ABE10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69ABDD0", Offset = "0x69AA7D0", VA = "0x1869ABDD0")]
		public FPIHAGLNFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69ABD60", Offset = "0x69AA760", VA = "0x1869ABD60", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69ABD90", Offset = "0x69AA790", VA = "0x1869ABD90", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class JPGOCPKFPCI : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x69AC820", Offset = "0x69AB220", VA = "0x1869AC820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69AC7E0", Offset = "0x69AB1E0", VA = "0x1869AC7E0")]
		public JPGOCPKFPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69AC770", Offset = "0x69AB170", VA = "0x1869AC770", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69AC7A0", Offset = "0x69AB1A0", VA = "0x1869AC7A0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class FKCFMBPNCOP : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x69ABD30", Offset = "0x69AA730", VA = "0x1869ABD30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69ABCF0", Offset = "0x69AA6F0", VA = "0x1869ABCF0")]
		public FKCFMBPNCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69ABC70", Offset = "0x69AA670", VA = "0x1869ABC70", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69ABCB0", Offset = "0x69AA6B0", VA = "0x1869ABCB0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class JLPFMGKBPIH : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x69AC650", Offset = "0x69AB050", VA = "0x1869AC650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69AC610", Offset = "0x69AB010", VA = "0x1869AC610")]
		public JLPFMGKBPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69AC590", Offset = "0x69AAF90", VA = "0x1869AC590", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69AC5D0", Offset = "0x69AAFD0", VA = "0x1869AC5D0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class LCFLONPLOON : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69ACC10", Offset = "0x69AB610", VA = "0x1869ACC10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69ACBD0", Offset = "0x69AB5D0", VA = "0x1869ACBD0")]
		public LCFLONPLOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB50", Offset = "0x69AB550", VA = "0x1869ACB50", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69ACB90", Offset = "0x69AB590", VA = "0x1869ACB90", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class OELKGOHFJBI : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x69AD0D0", Offset = "0x69ABAD0", VA = "0x1869AD0D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69AD090", Offset = "0x69ABA90", VA = "0x1869AD090")]
		public OELKGOHFJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69AD010", Offset = "0x69ABA10", VA = "0x1869AD010", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69AD050", Offset = "0x69ABA50", VA = "0x1869AD050", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class JOLGPPMAFHF : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x69AC740", Offset = "0x69AB140", VA = "0x1869AC740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69AC700", Offset = "0x69AB100", VA = "0x1869AC700")]
		public JOLGPPMAFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69AC680", Offset = "0x69AB080", VA = "0x1869AC680", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69AC6C0", Offset = "0x69AB0C0", VA = "0x1869AC6C0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class ANKDCNPJALN : Property<HPGJMHGDAMA, PAIPBEOLENN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69AAB20", Offset = "0x69A9520", VA = "0x1869AAB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69AAAE0", Offset = "0x69A94E0", VA = "0x1869AAAE0")]
		public ANKDCNPJALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69AAA60", Offset = "0x69A9460", VA = "0x1869AAA60", Slot = "14")]
		public override PAIPBEOLENN<Delegate> GetValue(HPGJMHGDAMA FOPICBKBDEP)
		{
			return default(PAIPBEOLENN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69AAAA0", Offset = "0x69A94A0", VA = "0x1869AAAA0", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA FOPICBKBDEP, PAIPBEOLENN<Delegate> DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69AB210", Offset = "0x69A9C10", VA = "0x1869AB210")]
	public DGOJHDABLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class MFKPIOHOCAI : ContainerPropertyBag<HPGJMHGDAMA.FFENLDPFBKH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class MILMJMCFDEJ : Property<HPGJMHGDAMA.FFENLDPFBKH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69ACF50", Offset = "0x69AB950", VA = "0x1869ACF50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69ACF10", Offset = "0x69AB910", VA = "0x1869ACF10")]
		public MILMJMCFDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA05470", Offset = "0xA03E70", VA = "0x180A05470", Slot = "14")]
		public override object GetValue(HPGJMHGDAMA.FFENLDPFBKH FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x476B160", Offset = "0x4769B60", VA = "0x18476B160", Slot = "15")]
		public override void SetValue(HPGJMHGDAMA.FFENLDPFBKH FOPICBKBDEP, object DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69ACDF0", Offset = "0x69AB7F0", VA = "0x1869ACDF0")]
	public MFKPIOHOCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class DAABONMHHDD : ContainerPropertyBag<PAIPBEOLENN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69AB140", Offset = "0x69A9B40", VA = "0x1869AB140")]
	public DAABONMHHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class HJHKHOMDHAI : ContainerPropertyBag<ACALCMNFIGH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class DGOBHIOHFNI : Property<ACALCMNFIGH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69AB1E0", Offset = "0x69A9BE0", VA = "0x1869AB1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69AB1A0", Offset = "0x69A9BA0", VA = "0x1869AB1A0")]
		public DGOBHIOHFNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF40", Offset = "0x69A9940", VA = "0x1869AAF40", Slot = "14")]
		public override Rigidbody GetValue(ACALCMNFIGH FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF60", Offset = "0x69A9960", VA = "0x1869AAF60", Slot = "15")]
		public override void SetValue(ACALCMNFIGH FOPICBKBDEP, Rigidbody DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69AC080", Offset = "0x69AAA80", VA = "0x1869AC080")]
	public HJHKHOMDHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class BFHCPGIFHJC : ContainerPropertyBag<FBJJGLCMBCA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class JBBBDLKHMAI : Property<FBJJGLCMBCA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69AC320", Offset = "0x69AAD20", VA = "0x1869AC320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69AC2E0", Offset = "0x69AACE0", VA = "0x1869AC2E0")]
		public JBBBDLKHMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF40", Offset = "0x69A9940", VA = "0x1869AAF40", Slot = "14")]
		public override object GetValue(FBJJGLCMBCA FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF60", Offset = "0x69A9960", VA = "0x1869AAF60", Slot = "15")]
		public override void SetValue(FBJJGLCMBCA FOPICBKBDEP, object DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69AAD40", Offset = "0x69A9740", VA = "0x1869AAD40")]
	public BFHCPGIFHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class BLMPNCIAMAH : ContainerPropertyBag<GLJMCIHIKGD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class HONLHMEJHKC : Property<GLJMCIHIKGD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69AC1A0", Offset = "0x69AABA0", VA = "0x1869AC1A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DODHMAHIADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69AC160", Offset = "0x69AAB60", VA = "0x1869AC160")]
		public HONLHMEJHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF40", Offset = "0x69A9940", VA = "0x1869AAF40", Slot = "14")]
		public override object GetValue(GLJMCIHIKGD FOPICBKBDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69AAF60", Offset = "0x69A9960", VA = "0x1869AAF60", Slot = "15")]
		public override void SetValue(GLJMCIHIKGD FOPICBKBDEP, object DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69AAE20", Offset = "0x69A9820", VA = "0x1869AAE20")]
	public BLMPNCIAMAH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69AD260", Offset = "0x69ABC60", VA = "0x1869AD260")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class GGKFJPNBAIC
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GGKFJPNBAIC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
