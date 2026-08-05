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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	public class _AssemblyIndex : IPFMOKLMBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69B4840", Offset = "0x69B3440", VA = "0x1869B4840", Slot = "8")]
		public override void NFNLBHNCOKJ(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69B4430", Offset = "0x69B3030", VA = "0x1869B4430", Slot = "7")]
		public override void KDGBONHLJCG(NLHJPPPFLAA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69B4C40", Offset = "0x69B3840", VA = "0x1869B4C40")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EMJIPOILBNP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69B19C0", Offset = "0x69B05C0", VA = "0x1869B19C0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LAOAGDFNECM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JGFCGPELOAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity JLIHMCFIPGI;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MGBBEEJLPAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity JLIHMCFIPGI;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FPCNFKGFCHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<CAIELNEMBIC> EHBBFIMCPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> FMPECGCMPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle CAEABJCEFAI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CAKMGDHDFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69B29E0", Offset = "0x69B15E0", VA = "0x1869B29E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69B2990", Offset = "0x69B1590", VA = "0x1869B2990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C7DE10", Offset = "0x4C7CA10", VA = "0x184C7DE10")]
	public FPCNFKGFCHF(NativeList<CAIELNEMBIC> EHBBFIMCPIA, NativeList<Entity> FMPECGCMPHP, JobHandle CAEABJCEFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69B2810", Offset = "0x69B1410", VA = "0x1869B2810")]
	public (Entity, NativeSlice<Entity>) ALCCCGDJPGG(int EKELKKECGGF)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69B2930", Offset = "0x69B1530", VA = "0x1869B2930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CAIELNEMBIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity BLPDMPJLPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int MANKJHLJMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int JKBHNDINMGD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BLGKAGCDBDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCHPDOOGDFH(bool MFLBJDJJODA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CJCHPKAMHAP : IEquatable<CJCHPKAMHAP>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool KFAJEPMDEMB(int OPBLCCPLEKK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool ABBAAJPDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool PAOBMHJEBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OINIDHKKEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool PJGCHPNBDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KFAJEPMDEMB FNLHFIPODPP;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69B1CE0", Offset = "0x69B08E0", VA = "0x1869B1CE0")]
	public CJCHPKAMHAP(KLJFOIFHPPB NBEBDBNCFGK, KFAJEPMDEMB FNLHFIPODPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69B1CB0", Offset = "0x69B08B0", VA = "0x1869B1CB0")]
	public CJCHPKAMHAP(bool ABBAAJPDNDA, bool PAOBMHJEBKJ, bool OINIDHKKEFN, bool PJGCHPNBDLD, KFAJEPMDEMB FNLHFIPODPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69B1C60", Offset = "0x69B0860", VA = "0x1869B1C60")]
	public bool JCFJNCOFKCO(int OPBLCCPLEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69B1A50", Offset = "0x69B0650", VA = "0x1869B1A50")]
	public bool CODGKKMAIMK(int OPBLCCPLEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69B1C30", Offset = "0x69B0830", VA = "0x1869B1C30")]
	public bool IGBLNKLDOBJ(int OPBLCCPLEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69B1A80", Offset = "0x69B0680", VA = "0x1869B1A80")]
	public bool EAFENCPKOLI(int OPBLCCPLEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69B1B60", Offset = "0x69B0760", VA = "0x1869B1B60", Slot = "4")]
	public bool Equals(CJCHPKAMHAP OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69B1AB0", Offset = "0x69B06B0", VA = "0x1869B1AB0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69B1B90", Offset = "0x69B0790", VA = "0x1869B1B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69B1C90", Offset = "0x69B0890", VA = "0x1869B1C90")]
	private bool MHIDILLPNNG(int OPBLCCPLEKK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OOLCLKEJADG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KDFEBDFMJFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PNGMHCGDHLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct GCFAKACHHOM : IBufferElementData, IEquatable<GCFAKACHHOM>, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity EJMCPAEEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int BEPKAGFNBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity HHFLECDDMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69B2A50", Offset = "0x69B1650", VA = "0x1869B2A50", Slot = "4")]
	public bool Equals(GCFAKACHHOM OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct KEPDOBDIOJE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct JFBFKLKBLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AGBIFOLKPAN MFKLPMIMMHF;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
		public JFBFKLKBLCG(AGBIFOLKPAN EKFOOPKDFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69B3100", Offset = "0x69B1D00", VA = "0x1869B3100")]
		public bool MBNCFBIFGLN(KEPDOBDIOJE BJIPEBKGPIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69B3110", Offset = "0x69B1D10", VA = "0x1869B3110")]
		public bool MGINLMHPMLO(KEPDOBDIOJE BJIPEBKGPIJ, AGBIFOLKPAN KPAEPBKOAFO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly AGBIFOLKPAN CDDHLCNNPIK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	public KEPDOBDIOJE(AGBIFOLKPAN CDDHLCNNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69B30E0", Offset = "0x69B1CE0", VA = "0x1869B30E0")]
	public KEPDOBDIOJE KBDCAEBFKIN(AGBIFOLKPAN KGFEPABFHEM)
	{
		return default(KEPDOBDIOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69B30D0", Offset = "0x69B1CD0", VA = "0x1869B30D0")]
	public KEPDOBDIOJE GJEFDJAJFMF(AGBIFOLKPAN OPEIBCNOJPM)
	{
		return default(KEPDOBDIOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69B3390", Offset = "0x69B1F90", VA = "0x1869B3390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum AGBIFOLKPAN : byte
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
public enum BGEMNEBPHIM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CKMHBLGFJCD]
public struct JAFLJLJLKNO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BGEMNEBPHIM CDDHLCNNPIK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EFAFHINEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69B30F0", Offset = "0x69B1CF0", VA = "0x1869B30F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	private JAFLJLJLKNO(BGEMNEBPHIM CDDHLCNNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69B30E0", Offset = "0x69B1CE0", VA = "0x1869B30E0")]
	public JAFLJLJLKNO KBDCAEBFKIN(BGEMNEBPHIM KGFEPABFHEM)
	{
		return default(JAFLJLJLKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69B30D0", Offset = "0x69B1CD0", VA = "0x1869B30D0")]
	public JAFLJLJLKNO GJEFDJAJFMF(BGEMNEBPHIM OPEIBCNOJPM)
	{
		return default(JAFLJLJLKNO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JLLCHPADMON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NMGHJHONHNB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity PEBEMKEOFAM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, HEMCHFPENCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69B19C0", Offset = "0x69B05C0", VA = "0x1869B19C0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CKMHBLGFJCD]
public struct MJHFHDAAHNB : ISystemStateBufferElementData, IBufferElementData, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity NGLCFDBCFFC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity LFNIFLKAADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LKBLDFCMKAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity MIODMODEJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity NCOKBFAAPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity JNNDDPMEHOG;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JLGEILFJNIH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly bool GKFNCCNFNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public uint AEGPDHLKIFI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool AJLMHLCPMMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct LMAIIKKAKNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint KNJAGMFOJJG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69B3670", Offset = "0x69B2270", VA = "0x1869B3670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BLNNCJBCBFA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LDNLBCKJNFL;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct FONLBCDPILM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public GCHandle IPOHNJHEDCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CNOIKIFODEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int LDNLBCKJNFL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OCEJFGNGOGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KBHAAMPNEAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NGPHLINPEMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int LDNLBCKJNFL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GJGEGGPGCKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LCGOIIFOJPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PBNOEAGGOKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EBJIBKMKJON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public CollisionDetectionMode JCOJADOCEFP;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BNDNDLDEKNI]
public struct MLOEAMOMNBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public PHMIKAKJJJM JFFLOMIDOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MLOEAMOMNBM IOGFCHMIMPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KCIPEMKGOCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HDMEOJGIGCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JBDDJLPAEBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[InternalBufferCapacity(0)]
public struct OOEFKKOLEGJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity EJMCPAEEGJH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BAONPPEHOIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity GPMGJNAOOEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct LCLAJMKLENC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PEBDHNHHOAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity BLPDMPJLPPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CCPBIAPGDIA : NCANMDHNBCI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AFFCBADDDMF LAICJGEAPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(AFFCBADDDMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KPACKLEDCAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float3 OGNCCDPDPDG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EEPDLCNFKLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BNDNDLDEKNI]
public struct ELGBBABCKDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3x3 ADLCNIKBPAI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly ELGBBABCKDN IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BNDNDLDEKNI]
public struct DBFLDOHDGKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 ADLCNIKBPAI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly DBFLDOHDGKA IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CLHCCMHLPEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3 INMIKANHMKK;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NOJMHFENICH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3 FPCELEMJBCM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BNDNDLDEKNI]
public struct INBOGJPOMHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float NPJLGHKCFOD;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly INBOGJPOMHB IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BNDNDLDEKNI]
public struct BLLEBKPJLCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float IDCLPNLDLEJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly BLLEBKPJLCK IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct LKHCEBIBJGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3 AFOBJDMFBDF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BIEGFBKMOHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IIIFFGPCIFG DPJMCLAAMAE;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CJHIOADODPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IIIFFGPCIFG HOAMBBJAPED;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CKMHBLGFJCD]
public struct MOBJLOMLJDD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity NGLCFDBCFFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct EFBHCGLANAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NCAPBFOKHGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct ENGHCMALGKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public RigidbodyConstraints JMGKMOJEHOB;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[BNDNDLDEKNI]
public struct AFHAGJBJJJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float JDFIFBHABCG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly AFHAGJBJJJE IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct HBPNBMOJOFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float IDDLGGDDKLE;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AFMNCACHFPE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OAJPCFLCEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public object GNOFKBHKOOD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject OLFFLDPKCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public object GJCLNIHGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public object BABOEAABOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public OAJPCFLCEDN GNOFKBHKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Delegate CMGHJAGDDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Delegate HKPCFJEBEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FLCPOFJGBNN<Delegate> FKCAHIINICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public FLCPOFJGBNN<Delegate> HKGAFFDFEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FLCPOFJGBNN<Delegate> DIOICMOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FLCPOFJGBNN<Delegate> CIHADPGGEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public FLCPOFJGBNN<Delegate> JKOEPOCMPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public FLCPOFJGBNN<Delegate> CFDNIHBEHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public FLCPOFJGBNN<Delegate> NEGKNKIINFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public FLCPOFJGBNN<Delegate> LKODLHMOEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public FLCPOFJGBNN<Delegate> NGMANILLLBN;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69B1720", Offset = "0x69B0320", VA = "0x1869B1720", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public AFMNCACHFPE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DAOMJBIODEN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct CIHHMGCGPME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int MEGGOENOEGE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static CIHHMGCGPME NBHHLKKAPBL(int GLMEMJNJKAN)
	{
		return default(CIHHMGCGPME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NGIAHCIDPDM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Rigidbody GKIOHLGLLID;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69B3AA0", Offset = "0x69B26A0", VA = "0x1869B3AA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NGIAHCIDPDM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GCHEHHKDION : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CDEEBDNNIJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float3 ICGDBJCJHBC;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GHADNAGKOEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 LEDLAOFKHKA;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[BNDNDLDEKNI]
public struct BAOAPGLHHHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float BEAGJEPHPFC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BAOAPGLHHHK IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class OBMIEPICKCM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public object CIKKILLJCHN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69B3D40", Offset = "0x69B2940", VA = "0x1869B3D40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OBMIEPICKCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KDKEALHHMDF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public object AJAPLIFJOHI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69B3320", Offset = "0x69B1F20", VA = "0x1869B3320", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KDKEALHHMDF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct HCDHGOHPHBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KIAEIKEHOAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct PEJNKKJLDPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct AKPLLDHJGBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct FMPMIGKPJFH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct DFOMLOJODGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public FixedString32Bytes GFLNGGKHEOH;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[CKMHBLGFJCD]
public struct CNCCGOHOAPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Entity BIGDMHGNNKD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static CNCCGOHOAPC NBHHLKKAPBL(Entity GLMEMJNJKAN)
	{
		return default(CNCCGOHOAPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct FLFLCEEFBEO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity NGLCFDBCFFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static FLFLCEEFBEO NBHHLKKAPBL(Entity NGLCFDBCFFC)
	{
		return default(FLFLCEEFBEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct KIHLHIFPBNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity OBKFDAEPOAI;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct OHFEFBIMONC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity OBKFDAEPOAI;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct LFLIJGBKLAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KFAPCKOKMCL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static LFLIJGBKLAM NBHHLKKAPBL(Entity NGLCFDBCFFC)
	{
		return default(LFLIJGBKLAM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct MJAHHOKDAFK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct APICCNGDHNN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct OELBEOLFNDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public uint IDPOJNOELJM;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[CKMHBLGFJCD]
internal struct NFEADGGKDGK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity IONLILICMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int OPDMGNJCACB;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct LLHDKHNOAIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity KPFKIOCNACH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NMPODKMCEOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IGEECKFBENL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public uint AEGPDHLKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int AOGEPOKIPNH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
	public IGEECKFBENL(uint JGPHBODPEGN, int OILMNJBDAFN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct AIPCFOCJCKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct IJOEJEGECBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct KCPOGLOHJJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct MFHHGMOGHJH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DKJDFGGMHNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct KPDIOBMDBPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct EGHMCBPFMJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct CFPFMBFAIHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal struct LKFLJODMEKO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JBOCOIEOPLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JHHNHFFOPFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LJLJEDEOGJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct KHCJFBEOJHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct LPIAOKNOEHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct PLOCJHMHNDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct BLGNLJHHAKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DOLCBHNEDBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HEIKIPHJNHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct KIINMJLJNDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JMFPLJEOFML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct FDFCLLFDCPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AGPELHIAGAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GIGOLGNNHBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct PNIGFBFJBNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct BPOGIPGHNAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct AGDFJLJLABA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct DCBPDGAEIOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[CKMHBLGFJCD]
public struct FCKEEOLHPDH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public FixedString32Bytes HGIJFHOADFN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BLDACAOHONL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct BAJHGGIDOIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct MKPACCGHHPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct PFDBEJFKANJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct BKGAPKDOJFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct NLDPNCGMFLI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct IONKEOCHKOD : IComponentData, IComparable<IONKEOCHKOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int FKKOANGEFMO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5CF60", Offset = "0x1A5BB60", VA = "0x181A5CF60", Slot = "4")]
	public int CompareTo(IONKEOCHKOD OCNJFCPHJLD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct FEGIIJABJIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct NMMLIEIAGOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public quaternion DELGPMLKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float3 DFPHDEDIHFK;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct JICCOCPLLPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float APJOIHFMOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float GBKJAHPPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float MCMMFPMEMIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct ELPNBFANOMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct BJFJMHGGNPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CHDJAOIJJBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IBGANILDCPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int LDNLBCKJNFL;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CKMHBLGFJCD]
public struct JKCOHNPCCBF : ISystemStateBufferElementData, IBufferElementData, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity KGCMPKPCOJF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity LFNIFLKAADA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[BNDNDLDEKNI]
public struct NBJBMPHGFHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float4x4 FKBDOACBDMG;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly NBJBMPHGFHA IOGFCHMIMPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NIDEAIFFLPL : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct CEJAMJFEFDP : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct KNHLPKIIKME : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct MLOIOKGFHJA : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BNDNDLDEKNI]
public struct JNFECBGCCNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 DALJHNGMIBO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly JNFECBGCCNG IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct NFKHAACAHJG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int CCKAPAFNPJP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OPDMGNJCACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69B3A90", Offset = "0x69B2690", VA = "0x1869B3A90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69B3A80", Offset = "0x69B2680", VA = "0x1869B3A80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[BNDNDLDEKNI]
public struct NMLNJGNCBNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 PELNAJDBAFA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly NMLNJGNCBNG IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[BNDNDLDEKNI]
public struct AKLDPIOMPOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public quaternion DELGPMLKBMI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly AKLDPIOMPOD IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class NJLDGNJAIEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[BNDNDLDEKNI]
public struct LOBEHIFKJPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float BACPMGCOCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly LOBEHIFKJPJ IOGFCHMIMPG;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct IOCJOANPJMI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity PHEDNOCBEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public LECJGOBHOND OLADDMOOKPM;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct IOLKGLFCIKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public LECJGOBHOND OLADDMOOKPM;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MHLEBCKFODH : ISystemStateComponentData, IComponentData, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity ONIAHHAAJEH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity LFNIFLKAADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GAJCHKIEGGF : ISystemStateBufferElementData, IBufferElementData, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity LNIHPFEDLGA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity LFNIFLKAADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IJJOFPENLAN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity PHEDNOCBEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public LECJGOBHOND OLADDMOOKPM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GLFFFKIGCDK : IEqualityComparer<IJJOFPENLAN>
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static GLFFFKIGCDK IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69B2AA0", Offset = "0x69B16A0", VA = "0x1869B2AA0", Slot = "4")]
	public bool Equals(IJJOFPENLAN KNFDPFPHEON, IJJOFPENLAN EFBKAEHLBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69B2AF0", Offset = "0x69B16F0", VA = "0x1869B2AF0", Slot = "5")]
	public int GetHashCode(IJJOFPENLAN HAHECKLGOJC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct JDCFOCJFAKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedList32Bytes<int> JFFGADICANO;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct NNIFFFEDDFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FixedList32Bytes<int> JFFGADICANO;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct FEFLMIGNOFM : ISystemStateBufferElementData, IBufferElementData, HEMCHFPENCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Entity IPBGIGIDAAO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity HHFLECDDMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class CMIJOJIKBMK : ContainerPropertyBag<AFMNCACHFPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class GMDMGECEBBN : Property<AFMNCACHFPE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69B2BE0", Offset = "0x69B17E0", VA = "0x1869B2BE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69B2BA0", Offset = "0x69B17A0", VA = "0x1869B2BA0")]
		public GMDMGECEBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B50", Offset = "0x69B1750", VA = "0x1869B2B50", Slot = "14")]
		public override GameObject GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B70", Offset = "0x69B1770", VA = "0x1869B2B70", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, GameObject GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class EKBCBFEADHD : Property<AFMNCACHFPE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69B26E0", Offset = "0x69B12E0", VA = "0x1869B26E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69B26A0", Offset = "0x69B12A0", VA = "0x1869B26A0")]
		public EKBCBFEADHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69B2650", Offset = "0x69B1250", VA = "0x1869B2650", Slot = "14")]
		public override object GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69B2670", Offset = "0x69B1270", VA = "0x1869B2670", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, object GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class OKJEODPPOOH : Property<AFMNCACHFPE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69B3E40", Offset = "0x69B2A40", VA = "0x1869B3E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E00", Offset = "0x69B2A00", VA = "0x1869B3E00")]
		public OKJEODPPOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69B3DB0", Offset = "0x69B29B0", VA = "0x1869B3DB0", Slot = "14")]
		public override object GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69B3DD0", Offset = "0x69B29D0", VA = "0x1869B3DD0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, object GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class AGJGKCPEJGK : Property<AFMNCACHFPE, AFMNCACHFPE.OAJPCFLCEDN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x69B1800", Offset = "0x69B0400", VA = "0x1869B1800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69B17C0", Offset = "0x69B03C0", VA = "0x1869B17C0")]
		public AGJGKCPEJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69B1770", Offset = "0x69B0370", VA = "0x1869B1770", Slot = "14")]
		public override AFMNCACHFPE.OAJPCFLCEDN GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(AFMNCACHFPE.OAJPCFLCEDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69B1790", Offset = "0x69B0390", VA = "0x1869B1790", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, AFMNCACHFPE.OAJPCFLCEDN GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class NMDAEBFHJEI : Property<AFMNCACHFPE, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x69B3C90", Offset = "0x69B2890", VA = "0x1869B3C90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69B3C50", Offset = "0x69B2850", VA = "0x1869B3C50")]
		public NMDAEBFHJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69B3C00", Offset = "0x69B2800", VA = "0x1869B3C00", Slot = "14")]
		public override Delegate GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69B3C20", Offset = "0x69B2820", VA = "0x1869B3C20", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, Delegate GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class LCEJOMLNEHL : Property<AFMNCACHFPE, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69B3640", Offset = "0x69B2240", VA = "0x1869B3640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69B3600", Offset = "0x69B2200", VA = "0x1869B3600")]
		public LCEJOMLNEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69B35B0", Offset = "0x69B21B0", VA = "0x1869B35B0", Slot = "14")]
		public override Delegate GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69B35D0", Offset = "0x69B21D0", VA = "0x1869B35D0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, Delegate GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class DLKEBDFHLNF : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69B2620", Offset = "0x69B1220", VA = "0x1869B2620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69B25E0", Offset = "0x69B11E0", VA = "0x1869B25E0")]
		public DLKEBDFHLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69B2570", Offset = "0x69B1170", VA = "0x1869B2570", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69B25A0", Offset = "0x69B11A0", VA = "0x1869B25A0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class PLKBCHMDJCM : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x69B3F20", Offset = "0x69B2B20", VA = "0x1869B3F20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69B3EE0", Offset = "0x69B2AE0", VA = "0x1869B3EE0")]
		public PLKBCHMDJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E70", Offset = "0x69B2A70", VA = "0x1869B3E70", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69B3EA0", Offset = "0x69B2AA0", VA = "0x1869B3EA0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class KOADCOEPHIH : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x69B3580", Offset = "0x69B2180", VA = "0x1869B3580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69B3540", Offset = "0x69B2140", VA = "0x1869B3540")]
		public KOADCOEPHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69B34D0", Offset = "0x69B20D0", VA = "0x1869B34D0", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69B3500", Offset = "0x69B2100", VA = "0x1869B3500", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class IMIMCAGAOCM : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x69B2F10", Offset = "0x69B1B10", VA = "0x1869B2F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69B2ED0", Offset = "0x69B1AD0", VA = "0x1869B2ED0")]
		public IMIMCAGAOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69B2E50", Offset = "0x69B1A50", VA = "0x1869B2E50", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69B2E90", Offset = "0x69B1A90", VA = "0x1869B2E90", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class ILFHFHNKLHN : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x69B2E20", Offset = "0x69B1A20", VA = "0x1869B2E20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69B2DE0", Offset = "0x69B19E0", VA = "0x1869B2DE0")]
		public ILFHFHNKLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69B2D60", Offset = "0x69B1960", VA = "0x1869B2D60", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69B2DA0", Offset = "0x69B19A0", VA = "0x1869B2DA0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class DJPIFAEIJFF : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69B2540", Offset = "0x69B1140", VA = "0x1869B2540", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69B2500", Offset = "0x69B1100", VA = "0x1869B2500")]
		public DJPIFAEIJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69B2480", Offset = "0x69B1080", VA = "0x1869B2480", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69B24C0", Offset = "0x69B10C0", VA = "0x1869B24C0", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class NLIFDDIHNAP : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x69B3BD0", Offset = "0x69B27D0", VA = "0x1869B3BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69B3B90", Offset = "0x69B2790", VA = "0x1869B3B90")]
		public NLIFDDIHNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69B3B10", Offset = "0x69B2710", VA = "0x1869B3B10", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69B3B50", Offset = "0x69B2750", VA = "0x1869B3B50", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class LMDKDIKEEPI : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x69B37C0", Offset = "0x69B23C0", VA = "0x1869B37C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69B3780", Offset = "0x69B2380", VA = "0x1869B3780")]
		public LMDKDIKEEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69B3700", Offset = "0x69B2300", VA = "0x1869B3700", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69B3740", Offset = "0x69B2340", VA = "0x1869B3740", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class LNNAIIDDKPL : Property<AFMNCACHFPE, FLCPOFJGBNN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69B38B0", Offset = "0x69B24B0", VA = "0x1869B38B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69B3870", Offset = "0x69B2470", VA = "0x1869B3870")]
		public LNNAIIDDKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69B37F0", Offset = "0x69B23F0", VA = "0x1869B37F0", Slot = "14")]
		public override FLCPOFJGBNN<Delegate> GetValue(AFMNCACHFPE INBELNINGBJ)
		{
			return default(FLCPOFJGBNN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69B3830", Offset = "0x69B2430", VA = "0x1869B3830", Slot = "15")]
		public override void SetValue(AFMNCACHFPE INBELNINGBJ, FLCPOFJGBNN<Delegate> GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69B1D20", Offset = "0x69B0920", VA = "0x1869B1D20")]
	public CMIJOJIKBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class IKJEKEKNIIG : ContainerPropertyBag<AFMNCACHFPE.OAJPCFLCEDN>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class MEKKFBODHON : Property<AFMNCACHFPE.OAJPCFLCEDN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69B3960", Offset = "0x69B2560", VA = "0x1869B3960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69B3920", Offset = "0x69B2520", VA = "0x1869B3920")]
		public MEKKFBODHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC40", Offset = "0x9DA840", VA = "0x1809DBC40", Slot = "14")]
		public override object GetValue(AFMNCACHFPE.OAJPCFLCEDN INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47B9780", Offset = "0x47B8380", VA = "0x1847B9780", Slot = "15")]
		public override void SetValue(AFMNCACHFPE.OAJPCFLCEDN INBELNINGBJ, object GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69B2C10", Offset = "0x69B1810", VA = "0x1869B2C10")]
	public IKJEKEKNIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class AKDBHCPDLBP : ContainerPropertyBag<FLCPOFJGBNN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69B1830", Offset = "0x69B0430", VA = "0x1869B1830")]
	public AKDBHCPDLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JAFIDNGABLL : ContainerPropertyBag<NGIAHCIDPDM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class JNCCJNKNCNE : Property<NGIAHCIDPDM, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69B3160", Offset = "0x69B1D60", VA = "0x1869B3160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69B3120", Offset = "0x69B1D20", VA = "0x1869B3120")]
		public JNCCJNKNCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B50", Offset = "0x69B1750", VA = "0x1869B2B50", Slot = "14")]
		public override Rigidbody GetValue(NGIAHCIDPDM INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B70", Offset = "0x69B1770", VA = "0x1869B2B70", Slot = "15")]
		public override void SetValue(NGIAHCIDPDM INBELNINGBJ, Rigidbody GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69B2FF0", Offset = "0x69B1BF0", VA = "0x1869B2FF0")]
	public JAFIDNGABLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class JOPDHFAEKFI : ContainerPropertyBag<OBMIEPICKCM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class IKKMHINDBFL : Property<OBMIEPICKCM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69B2D30", Offset = "0x69B1930", VA = "0x1869B2D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69B2CF0", Offset = "0x69B18F0", VA = "0x1869B2CF0")]
		public IKKMHINDBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B50", Offset = "0x69B1750", VA = "0x1869B2B50", Slot = "14")]
		public override object GetValue(OBMIEPICKCM INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B70", Offset = "0x69B1770", VA = "0x1869B2B70", Slot = "15")]
		public override void SetValue(OBMIEPICKCM INBELNINGBJ, object GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69B3240", Offset = "0x69B1E40", VA = "0x1869B3240")]
	public JOPDHFAEKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class KNFLFCPAAGB : ContainerPropertyBag<KDKEALHHMDF>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class IPKOGHOIKAG : Property<KDKEALHHMDF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string JBJAOBKIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69B2FC0", Offset = "0x69B1BC0", VA = "0x1869B2FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool LJENBABOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69B2F80", Offset = "0x69B1B80", VA = "0x1869B2F80")]
		public IPKOGHOIKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B50", Offset = "0x69B1750", VA = "0x1869B2B50", Slot = "14")]
		public override object GetValue(KDKEALHHMDF INBELNINGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B70", Offset = "0x69B1770", VA = "0x1869B2B70", Slot = "15")]
		public override void SetValue(KDKEALHHMDF INBELNINGBJ, object GLMEMJNJKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69B33F0", Offset = "0x69B1FF0", VA = "0x1869B33F0")]
	public KNFLFCPAAGB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69B3F50", Offset = "0x69B2B50", VA = "0x1869B3F50")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class MOPBIGCLMGE
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MOPBIGCLMGE()
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
