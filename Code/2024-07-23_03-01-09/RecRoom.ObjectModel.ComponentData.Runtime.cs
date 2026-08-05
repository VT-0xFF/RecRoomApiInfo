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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
	public class _AssemblyIndex : ACEDPDPNKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69D9590", Offset = "0x69D8790", VA = "0x1869D9590", Slot = "8")]
		public override void KCOPNMGFKOP(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69D9990", Offset = "0x69D8B90", VA = "0x1869D9990", Slot = "7")]
		public override void PEOLHCALGCG(CKHDLNAODNM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69D9E00", Offset = "0x69D9000", VA = "0x1869D9E00")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KBHOCHEDMCG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, DFJCABFCCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A10", Offset = "0x69D5C10", VA = "0x1869D6A10", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, DFJCABFCCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GDFLMDBMGKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BLIAHGGIOBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity BMDGDHEJHLL;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KHIOFKAKMHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity BMDGDHEJHLL;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DIIODEOBKFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<NHGDMHBFKPH> BMPCHLAFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> BDABDMFJFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle BHOKFONKIGD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ICKOEOOAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69D6D30", Offset = "0x69D5F30", VA = "0x1869D6D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D6EC0", Offset = "0x69D60C0", VA = "0x1869D6EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CBA7D0", Offset = "0x4CB99D0", VA = "0x184CBA7D0")]
	public DIIODEOBKFK(NativeList<NHGDMHBFKPH> BMPCHLAFCPD, NativeList<Entity> BDABDMFJFNK, JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69D6DA0", Offset = "0x69D5FA0", VA = "0x1869D6DA0")]
	public (Entity, NativeSlice<Entity>) JEKAMCAMIDL(int HCDMGOGKHKP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69D6CD0", Offset = "0x69D5ED0", VA = "0x1869D6CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NHGDMHBFKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity GFFCILHEGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int PENDBLHFGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int OMJPDIKPOLO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AANFAKNPOIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKKMGGDLNPD(bool BGEHHLCHEEE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct HCEDINLGGGF : IEquatable<HCEDINLGGGF>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool OEGDEJMAHNC(int IEJKLFLAGBB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool DKGNPCMBOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FBJHNJEMCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool NDKDOFEJALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool OGEHNOIPIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OEGDEJMAHNC AOODOAAAHFB;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69D7740", Offset = "0x69D6940", VA = "0x1869D7740")]
	public HCEDINLGGGF(HMOHHGDNCHA GAEADNFFCGK, OEGDEJMAHNC AOODOAAAHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69D7710", Offset = "0x69D6910", VA = "0x1869D7710")]
	public HCEDINLGGGF(bool DKGNPCMBOAB, bool FBJHNJEMCDI, bool NDKDOFEJALO, bool OGEHNOIPIJH, OEGDEJMAHNC AOODOAAAHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69D74B0", Offset = "0x69D66B0", VA = "0x1869D74B0")]
	public bool CGGDHDGJLBO(int IEJKLFLAGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69D7680", Offset = "0x69D6880", VA = "0x1869D7680")]
	public bool HLKLIIPINHE(int IEJKLFLAGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69D76B0", Offset = "0x69D68B0", VA = "0x1869D76B0")]
	public bool MHBCGKMPBIJ(int IEJKLFLAGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69D76E0", Offset = "0x69D68E0", VA = "0x1869D76E0")]
	public bool PKINMKCOMAJ(int IEJKLFLAGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69D75B0", Offset = "0x69D67B0", VA = "0x1869D75B0", Slot = "4")]
	public bool Equals(HCEDINLGGGF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69D7500", Offset = "0x69D6700", VA = "0x1869D7500", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69D75E0", Offset = "0x69D67E0", VA = "0x1869D75E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69D74E0", Offset = "0x69D66E0", VA = "0x1869D74E0")]
	private bool CNIDEPBHMMD(int IEJKLFLAGBB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DLPHPEPBPPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AHBFHNDFODB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KKPIKOJMBHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct NENGEGOLBJA : IBufferElementData, IEquatable<NENGEGOLBJA>, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JPEFLCPGHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int BBAPIEOEPFB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity BMFFBPEPEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69D8800", Offset = "0x69D7A00", VA = "0x1869D8800", Slot = "4")]
	public bool Equals(NENGEGOLBJA OKGBBGMIACH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ENGPPLDOAMD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct OEBDMJAFKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly KKOLOHBHCBK BPABOLENNMO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
		public OEBDMJAFKPC(KKOLOHBHCBK EKMOAAACAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69D8B90", Offset = "0x69D7D90", VA = "0x1869D8B90")]
		public bool EEJJIJEGDNN(ENGPPLDOAMD DDJJFLLKNFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69D8BA0", Offset = "0x69D7DA0", VA = "0x1869D8BA0")]
		public bool EJKKKGJPILK(ENGPPLDOAMD DDJJFLLKNFB, KKOLOHBHCBK LLAJEECPEOB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly KKOLOHBHCBK DOOPJKAJHBG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
	public ENGPPLDOAMD(KKOLOHBHCBK DOOPJKAJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69D71C0", Offset = "0x69D63C0", VA = "0x1869D71C0")]
	public ENGPPLDOAMD DNFAFKAIGIC(KKOLOHBHCBK OBEIKJCPIJI)
	{
		return default(ENGPPLDOAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69D71D0", Offset = "0x69D63D0", VA = "0x1869D71D0")]
	public ENGPPLDOAMD GHAMJAPJCKM(KKOLOHBHCBK GKNNLDECHEC)
	{
		return default(ENGPPLDOAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69D71E0", Offset = "0x69D63E0", VA = "0x1869D71E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum KKOLOHBHCBK : byte
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
public enum JEEBHCKFEGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MNIFOPMBNOL]
public struct JNLFIOGKANA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JEEBHCKFEGK DOOPJKAJHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool IPMMCIHFNFA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MODEAGHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69D8360", Offset = "0x69D7560", VA = "0x1869D8360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69D8370", Offset = "0x69D7570", VA = "0x1869D8370")]
	private JNLFIOGKANA(JEEBHCKFEGK DOOPJKAJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69D8320", Offset = "0x69D7520", VA = "0x1869D8320")]
	public JNLFIOGKANA DNFAFKAIGIC(JEEBHCKFEGK OBEIKJCPIJI)
	{
		return default(JNLFIOGKANA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69D8340", Offset = "0x69D7540", VA = "0x1869D8340")]
	public JNLFIOGKANA GHAMJAPJCKM(JEEBHCKFEGK GKNNLDECHEC)
	{
		return default(JNLFIOGKANA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IJDPBCEIPFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JHAOMMCJHLP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity CFNEIIAMEOE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, DFJCABFCCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A10", Offset = "0x69D5C10", VA = "0x1869D6A10", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MNIFOPMBNOL]
public struct CCGPMEAKIMA : ISystemStateBufferElementData, IBufferElementData, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity IBKNLGIDEBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity FFFEKBLOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FHCCCCBLLFG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity CJJOAKOMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity GOOMCCNBDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity HGHDEIEJMPD;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PBDGDLKAABF<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool OONANGMADII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint KBGPIKCEFAI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool KOLAHGELMPE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct IKNELCIDNCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint LPKKHGMIJPD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69D7A90", Offset = "0x69D6C90", VA = "0x1869D7A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NMPLIADOFAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MNIFOPMBNOL]
public struct NKEOMNOGLNL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int BHCNDKNHELH;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BNDKCCDKHBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int JGJFKDCDFCE;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JOMOOEHOCPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle DEHIHJKOPKO;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HNBEBCKHNPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int JGJFKDCDFCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct MLKHBOBBBNB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GKOFKNAMFHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int JGJFKDCDFCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CMANIIDCHAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AMIDJHHONEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KIDMJBDFIPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CLDBFNIKEFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode KDHFGAKGJLC;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BMGFJLNGBHO]
public struct PKBNFBDHNBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FHBBMPGGCGD NBMNIMGNBJP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly PKBNFBDHNBA ELIKMDBCIKF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BDFFNAFHJPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HOHHHOBAONF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HIGBPCJIHAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct IGEBNJDLJND : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity JPEFLCPGHGB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct HEFLAGBDOAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity BMBBFJPOJEB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DLBGKHBIMFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PHNELEPLJCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity GFFCILHEGII;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IDOEIMOEEIC : CDKJCGHPLFH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EACBOGOHBHP NBMIBOLNKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EACBOGOHBHP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct HDNDAMFJBIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 MMOGMLHFAIF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LLJDJHFKFOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BMGFJLNGBHO]
public struct DPKGLGNBCGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 CKKOBMDHEHP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly DPKGLGNBCGM ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BMGFJLNGBHO]
public struct HKENMEBEEJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 CKKOBMDHEHP;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HKENMEBEEJH ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MGCBMAEMOAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 KPHPMMJOIBC;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JCHKEKOENEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 BAIGDACCDND;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BMGFJLNGBHO]
public struct MCJPIEONKDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float DAGLHJFOHGH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MCJPIEONKDB ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BMGFJLNGBHO]
public struct CIBPPAEBEGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float NLILMFBCLII;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly CIBPPAEBEGO ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PGCFCJFFEMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 BAMHKCIJGMI;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct IPDAFNPLOJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ONPHIJJLPGG EEBPBEAOODP;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DHOHMOHODJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ONPHIJJLPGG HNIBAPCNCGC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[MNIFOPMBNOL]
public struct IIEOPCCEFAE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity IBKNLGIDEBH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FKKOOEIPEFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DEDODPGADEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct IPKNGGKHIBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints JPAPNIOBBKO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BMGFJLNGBHO]
public struct IADCLJGIJIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float JPAHPGHKFID;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly IADCLJGIJIB ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct APOCBHOLMKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float MFICPAKCDLL;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DEOFFGKPJLI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FNJMFDANNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object HDDPEKIEOAO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject NBDLDMDNCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object EFJFPKJHPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object EAHMLIEPBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public FNJMFDANNOO HDDPEKIEOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate MLOLDJEJKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate BMFOICLELCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FCCFNDGAOHI<Delegate> BKECCHHIDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FCCFNDGAOHI<Delegate> PDJEAKHHEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public FCCFNDGAOHI<Delegate> JILOOHGNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public FCCFNDGAOHI<Delegate> CJEPOCJJLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public FCCFNDGAOHI<Delegate> PLCPJIMKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public FCCFNDGAOHI<Delegate> PPLAFJPLKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public FCCFNDGAOHI<Delegate> NNPOGGAHGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public FCCFNDGAOHI<Delegate> KLHEMDBIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public FCCFNDGAOHI<Delegate> IBNGBBAAJPC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69D6C80", Offset = "0x69D5E80", VA = "0x1869D6C80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public DEOFFGKPJLI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MFAFGCAHEDG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct OLCKOEAEOEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int OFLPNINPADE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE13840", Offset = "0xE12A40", VA = "0x180E13840")]
	public static OLCKOEAEOEN GCLAHEGAFFN(int JMDCGOKJIDA)
	{
		return default(OLCKOEAEOEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PJGEPEGKEEN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody KLDLKACCMKB;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69D8F00", Offset = "0x69D8100", VA = "0x1869D8F00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public PJGEPEGKEEN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BPKOEEEGBBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JMANOAPJGGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FJCOMDPBLBJ;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct KBENOMCLBPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 GPJLHMNPICC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[BMGFJLNGBHO]
public struct OCAEKLCOMFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CCGJENGKEPC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly OCAEKLCOMFC ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class FNFPHAELOJD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object DKFLCJJCJEI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69D7280", Offset = "0x69D6480", VA = "0x1869D7280", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public FNFPHAELOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OBKMJNJDANK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object JMIACCJPHJN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69D89F0", Offset = "0x69D7BF0", VA = "0x1869D89F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public OBKMJNJDANK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MPCGJAJDMLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct KNHJNOBGABD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct ACJKMDIAKHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct CNHBBAKDAFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct DKOGBGIIFOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct EDAHPNODBJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes BHFPKCCDEEC;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MNIFOPMBNOL]
public struct DHGNDNOMOAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity AFMLKNOAEHD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210")]
	public static DHGNDNOMOAD GCLAHEGAFFN(Entity JMDCGOKJIDA)
	{
		return default(DHGNDNOMOAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct HGJMCEEILNO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity IBKNLGIDEBH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210")]
	public static HGJMCEEILNO GCLAHEGAFFN(Entity IBKNLGIDEBH)
	{
		return default(HGJMCEEILNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LCINOPAJCEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity GLECGKAFFEA;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DMCNKJNALLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity GLECGKAFFEA;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct LOFBHDKGLIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity FNHJIODKGJG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210")]
	public static LOFBHDKGLIO GCLAHEGAFFN(Entity IBKNLGIDEBH)
	{
		return default(LOFBHDKGLIO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct HLOFOECGPEL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct ONKAMFJEENH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct ENGODCIAJEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint DMDAEILPBHA;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[MNIFOPMBNOL]
internal struct DNHBLAEKNAJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity ALKLEEDDPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int DHNLEFJCEAH;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct PIFNJDHMBEM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity IFMLHGKDGCB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct KJKMLEGGCBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct EINBLHDPPEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint KBGPIKCEFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int KPOHDLGGGPM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
	public EINBLHDPPEL(uint FNBGNLBNJAF, int FECJKKNLNDE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NALPDFDLBNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct KKJHAEPEEPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct ODHABFBNCGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MPFBPKGICMN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct PNDDLHLOONL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FEGDJBHMCOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct CMIMEBHEOOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PDMABKMILLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct BEIGPPNLCDK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct IOIBEPFMMAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GPAGHGKJCHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct KOJLPKPLLIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct ADFHDHGNOLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct NGEIPCIDAEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NONGLPMBCLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BJIPICNPCMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct IEKFKEICNOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct EPGNPHEBGLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct FNAFFDAAFJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct IDFLLJHAKPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct CINDFCBCODM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LOCHLEIKEAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct AKCNAJHHEOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CDNMOPIKCGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct MLMOEKDPBFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MMPPEPACGBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct JDKGKNNAKIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct AMMPJAOOJHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[MNIFOPMBNOL]
public struct GBHKOKFEHEO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes LCFMJNPOPEB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct NGDAEHIOEAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct ADCAGIKMAJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct FPMJDCFAPHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct HNIDJCLJBGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct OBAAHAMAAHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct JCCJHNPOCNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct HJCGNGDCGMP : IComponentData, IComparable<HJCGNGDCGMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int POBDBNAMEFB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A93A20", Offset = "0x1A92C20", VA = "0x181A93A20", Slot = "4")]
	public int CompareTo(HJCGNGDCGMP OKGBBGMIACH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct KNNBPJOIILA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct LHODOECNHLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 HGDCPNGLIKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JAFHLMFMFAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float JCCDKKMEFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float GKFHBBKFIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float LPHEKOIHNIB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EOIFEDLHDME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BLGKDNCLOMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct JEHJODNEHCB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct KCFKMNBMFIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int JGJFKDCDFCE;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[MNIFOPMBNOL]
public struct DHMLPDHBHCA : ISystemStateBufferElementData, IBufferElementData, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity EEEMMJKAAFP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity FFFEKBLOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BMGFJLNGBHO]
public struct AGFBJBPDJDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 PKLFKNMBPNA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly AGFBJBPDJDF ELIKMDBCIKF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct MOECJAJPBOH : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct EMKFEFLADMF : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct HPPFOBALFBI : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct FHEFKGNGAKH : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[BMGFJLNGBHO]
public struct AJNDDMEEHBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 KKCFNCIJCJM;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly AJNDDMEEHBO ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct PKIILCFMCKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int DJEJNPJEEDK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DHNLEFJCEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69D8FB0", Offset = "0x69D81B0", VA = "0x1869D8FB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69D8FC0", Offset = "0x69D81C0", VA = "0x1869D8FC0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[BMGFJLNGBHO]
public struct CNGPFNJGMPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 DIBJOONDKFO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly CNGPFNJGMPL ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[BMGFJLNGBHO]
public struct PBOHAKBFFCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion LCDJINCAHMD;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly PBOHAKBFFCL ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class MJEKCMCIHPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[BMGFJLNGBHO]
public struct FMPEEBDDGMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float CLAPLAKODIB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly FMPEEBDDGMK ELIKMDBCIKF;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct LIMCBOANCPK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity MFNJKEIOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public FAHIIHHFPKH OIOHIJOOPGO;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct LAODCGFFELL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public FAHIIHHFPKH OIOHIJOOPGO;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct ODAHBMFALDP : ISystemStateComponentData, IComponentData, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity IDOOJPJNKLC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity FFFEKBLOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct DLMIKEIGBFC : ISystemStateBufferElementData, IBufferElementData, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity BOBMNOJIEKC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity FFFEKBLOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct MIGELBIPIEJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity MFNJKEIOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FAHIIHHFPKH OIOHIJOOPGO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct LMNBLCNHBOF : IEqualityComparer<MIGELBIPIEJ>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static LMNBLCNHBOF ELIKMDBCIKF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69D83E0", Offset = "0x69D75E0", VA = "0x1869D83E0", Slot = "4")]
	public bool Equals(MIGELBIPIEJ IPBJLCONKPC, MIGELBIPIEJ FACAKAOOAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69D8430", Offset = "0x69D7630", VA = "0x1869D8430", Slot = "5")]
	public int GetHashCode(MIGELBIPIEJ MEAFIMADMKA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct DDLMCLCCAFD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> DJEEKAMJJDN;
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct MHEFFKDEDFH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> DJEEKAMJJDN;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct JLOCKODNLAG : ISystemStateBufferElementData, IBufferElementData, DFJCABFCCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity IHKOCKLJMLG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity BMFFBPEPEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE44C70", Offset = "0xE43E70", VA = "0x180E44C70", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class IMLLKGAMHFL : ContainerPropertyBag<DEOFFGKPJLI>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class OHPPFPKFMID : Property<DEOFFGKPJLI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69D8BF0", Offset = "0x69D7DF0", VA = "0x1869D8BF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69D8BB0", Offset = "0x69D7DB0", VA = "0x1869D8BB0")]
		public OHPPFPKFMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69D6950", Offset = "0x69D5B50", VA = "0x1869D6950", Slot = "14")]
		public override GameObject GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5B70", VA = "0x1869D6970", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, GameObject JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class BJMADGIGGPC : Property<DEOFFGKPJLI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69D6AB0", Offset = "0x69D5CB0", VA = "0x1869D6AB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A70", Offset = "0x69D5C70", VA = "0x1869D6A70")]
		public BJMADGIGGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A20", Offset = "0x69D5C20", VA = "0x1869D6A20", Slot = "14")]
		public override object GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A40", Offset = "0x69D5C40", VA = "0x1869D6A40", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, object JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class NKJIFKKDHHE : Property<DEOFFGKPJLI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69D88E0", Offset = "0x69D7AE0", VA = "0x1869D88E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69D88A0", Offset = "0x69D7AA0", VA = "0x1869D88A0")]
		public NKJIFKKDHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8850", Offset = "0x69D7A50", VA = "0x1869D8850", Slot = "14")]
		public override object GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69D8870", Offset = "0x69D7A70", VA = "0x1869D8870", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, object JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class OIBFNCMDHII : Property<DEOFFGKPJLI, DEOFFGKPJLI.FNJMFDANNOO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x69D8CB0", Offset = "0x69D7EB0", VA = "0x1869D8CB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C70", Offset = "0x69D7E70", VA = "0x1869D8C70")]
		public OIBFNCMDHII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C20", Offset = "0x69D7E20", VA = "0x1869D8C20", Slot = "14")]
		public override DEOFFGKPJLI.FNJMFDANNOO GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(DEOFFGKPJLI.FNJMFDANNOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C40", Offset = "0x69D7E40", VA = "0x1869D8C40", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, DEOFFGKPJLI.FNJMFDANNOO JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class DJMKLDJEPOL : Property<DEOFFGKPJLI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x69D6FA0", Offset = "0x69D61A0", VA = "0x1869D6FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69D6F60", Offset = "0x69D6160", VA = "0x1869D6F60")]
		public DJMKLDJEPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69D6F10", Offset = "0x69D6110", VA = "0x1869D6F10", Slot = "14")]
		public override Delegate GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69D6F30", Offset = "0x69D6130", VA = "0x1869D6F30", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, Delegate JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class JMIHIOBIAAI : Property<DEOFFGKPJLI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69D82F0", Offset = "0x69D74F0", VA = "0x1869D82F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69D82B0", Offset = "0x69D74B0", VA = "0x1869D82B0")]
		public JMIHIOBIAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69D8260", Offset = "0x69D7460", VA = "0x1869D8260", Slot = "14")]
		public override Delegate GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8280", Offset = "0x69D7480", VA = "0x1869D8280", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, Delegate JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class PNIAFBAJEMK : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69D9080", Offset = "0x69D8280", VA = "0x1869D9080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69D9040", Offset = "0x69D8240", VA = "0x1869D9040")]
		public PNIAFBAJEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69D8FD0", Offset = "0x69D81D0", VA = "0x1869D8FD0", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69D9000", Offset = "0x69D8200", VA = "0x1869D9000", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class MBHPMMICOCL : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x69D8630", Offset = "0x69D7830", VA = "0x1869D8630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69D85F0", Offset = "0x69D77F0", VA = "0x1869D85F0")]
		public MBHPMMICOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69D8580", Offset = "0x69D7780", VA = "0x1869D8580", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69D85B0", Offset = "0x69D77B0", VA = "0x1869D85B0", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class HNJBCLOMLEK : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x69D7A20", Offset = "0x69D6C20", VA = "0x1869D7A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69D79E0", Offset = "0x69D6BE0", VA = "0x1869D79E0")]
		public HNJBCLOMLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69D7970", Offset = "0x69D6B70", VA = "0x1869D7970", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69D79A0", Offset = "0x69D6BA0", VA = "0x1869D79A0", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class LPBDHKEINMD : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x69D8550", Offset = "0x69D7750", VA = "0x1869D8550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69D8510", Offset = "0x69D7710", VA = "0x1869D8510")]
		public LPBDHKEINMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69D8490", Offset = "0x69D7690", VA = "0x1869D8490", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69D84D0", Offset = "0x69D76D0", VA = "0x1869D84D0", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class MPNFAEGFAHO : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x69D87D0", Offset = "0x69D79D0", VA = "0x1869D87D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69D8790", Offset = "0x69D7990", VA = "0x1869D8790")]
		public MPNFAEGFAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69D8710", Offset = "0x69D7910", VA = "0x1869D8710", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69D8750", Offset = "0x69D7950", VA = "0x1869D8750", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class OCJBECABKKI : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69D8B60", Offset = "0x69D7D60", VA = "0x1869D8B60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69D8B20", Offset = "0x69D7D20", VA = "0x1869D8B20")]
		public OCJBECABKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69D8AA0", Offset = "0x69D7CA0", VA = "0x1869D8AA0", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69D8AE0", Offset = "0x69D7CE0", VA = "0x1869D8AE0", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class HFMPFFPNKKC : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x69D7840", Offset = "0x69D6A40", VA = "0x1869D7840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7800", Offset = "0x69D6A00", VA = "0x1869D7800")]
		public HFMPFFPNKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69D7780", Offset = "0x69D6980", VA = "0x1869D7780", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69D77C0", Offset = "0x69D69C0", VA = "0x1869D77C0", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class DPOIOEGDKOF : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x69D7190", Offset = "0x69D6390", VA = "0x1869D7190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D7150", Offset = "0x69D6350", VA = "0x1869D7150")]
		public DPOIOEGDKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69D70D0", Offset = "0x69D62D0", VA = "0x1869D70D0", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69D7110", Offset = "0x69D6310", VA = "0x1869D7110", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class PDLGJABABDE : Property<DEOFFGKPJLI, FCCFNDGAOHI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69D8ED0", Offset = "0x69D80D0", VA = "0x1869D8ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69D8E90", Offset = "0x69D8090", VA = "0x1869D8E90")]
		public PDLGJABABDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69D8E10", Offset = "0x69D8010", VA = "0x1869D8E10", Slot = "14")]
		public override FCCFNDGAOHI<Delegate> GetValue(DEOFFGKPJLI PGHIDIKDPNB)
		{
			return default(FCCFNDGAOHI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69D8E50", Offset = "0x69D8050", VA = "0x1869D8E50", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI PGHIDIKDPNB, FCCFNDGAOHI<Delegate> JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69D7B20", Offset = "0x69D6D20", VA = "0x1869D7B20")]
	public IMLLKGAMHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class CDJNFJLGDFA : ContainerPropertyBag<DEOFFGKPJLI.FNJMFDANNOO>
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class GKPBADJJJBB : Property<DEOFFGKPJLI.FNJMFDANNOO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69D7480", Offset = "0x69D6680", VA = "0x1869D7480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69D7440", Offset = "0x69D6640", VA = "0x1869D7440")]
		public GKPBADJJJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0F580", Offset = "0xA0E780", VA = "0x180A0F580", Slot = "14")]
		public override object GetValue(DEOFFGKPJLI.FNJMFDANNOO PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47BAB10", Offset = "0x47B9D10", VA = "0x1847BAB10", Slot = "15")]
		public override void SetValue(DEOFFGKPJLI.FNJMFDANNOO PGHIDIKDPNB, object JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D6AE0", Offset = "0x69D5CE0", VA = "0x1869D6AE0")]
	public CDJNFJLGDFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class KHEIIPNAOAI : ContainerPropertyBag<FCCFNDGAOHI<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69D8380", Offset = "0x69D7580", VA = "0x1869D8380")]
	public KHEIIPNAOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class JLFANNFKLHF : ContainerPropertyBag<PJGEPEGKEEN>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class MFFPIKLDPOP : Property<PJGEPEGKEEN, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69D86E0", Offset = "0x69D78E0", VA = "0x1869D86E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69D86A0", Offset = "0x69D78A0", VA = "0x1869D86A0")]
		public MFFPIKLDPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69D6950", Offset = "0x69D5B50", VA = "0x1869D6950", Slot = "14")]
		public override Rigidbody GetValue(PJGEPEGKEEN PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5B70", VA = "0x1869D6970", Slot = "15")]
		public override void SetValue(PJGEPEGKEEN PGHIDIKDPNB, Rigidbody JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69D8180", Offset = "0x69D7380", VA = "0x1869D8180")]
	public JLFANNFKLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class FPJPEOJPBDB : ContainerPropertyBag<FNFPHAELOJD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class GAFMNLLHKML : Property<FNFPHAELOJD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69D7410", Offset = "0x69D6610", VA = "0x1869D7410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69D73D0", Offset = "0x69D65D0", VA = "0x1869D73D0")]
		public GAFMNLLHKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69D6950", Offset = "0x69D5B50", VA = "0x1869D6950", Slot = "14")]
		public override object GetValue(FNFPHAELOJD PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5B70", VA = "0x1869D6970", Slot = "15")]
		public override void SetValue(FNFPHAELOJD PGHIDIKDPNB, object JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69D72F0", Offset = "0x69D64F0", VA = "0x1869D72F0")]
	public FPJPEOJPBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class OAGDCHDHHOD : ContainerPropertyBag<OBKMJNJDANK>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class ANBAEBKAPDM : Property<OBKMJNJDANK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KHJLONLFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69D69E0", Offset = "0x69D5BE0", VA = "0x1869D69E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HNPAFAKBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69D69A0", Offset = "0x69D5BA0", VA = "0x1869D69A0")]
		public ANBAEBKAPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69D6950", Offset = "0x69D5B50", VA = "0x1869D6950", Slot = "14")]
		public override object GetValue(OBKMJNJDANK PGHIDIKDPNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69D6970", Offset = "0x69D5B70", VA = "0x1869D6970", Slot = "15")]
		public override void SetValue(OBKMJNJDANK PGHIDIKDPNB, object JMDCGOKJIDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69D8910", Offset = "0x69D7B10", VA = "0x1869D8910")]
	public OAGDCHDHHOD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69D90B0", Offset = "0x69D82B0", VA = "0x1869D90B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class FFCOGINOOIO
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public FFCOGINOOIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
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
