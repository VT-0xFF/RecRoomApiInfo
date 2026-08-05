using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EBNFHFAIKEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode OHIPEMGHIOA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PICECHDBAOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public IBCCCJOGKLP HAECHIPDEHN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly KFOHILCLCBE<PICECHDBAOI> BKEFLEENBBL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CBKNMNEOJBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AIDMEBGPMPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IBCCCJOGKLP
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LJABBJOCMCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct JDIEBLABNBC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity FKKAOLHJCBE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OLAHABNHJMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity LBLLNFOEKNE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LIFOEEKEOMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NKPFKMGPKJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JKEBPOPHOPF;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AMJJEAJMPPH : JECAHKJAFHM, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NCNMOPKBHNL AAMCEOPKDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NCNMOPKBHNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IBDDLCMIDFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 HLGDJAEDJBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GLMKACHBJOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IIONDMBMEAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 FGJGGNHCPKD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly KFOHILCLCBE<IKMNOAJHAOI> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IKMNOAJHAOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 FGJGGNHCPKD;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KFOHILCLCBE<IKMNOAJHAOI> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JNKGNIMCLKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 NECLKKEPKOO;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LGDFPOGFODA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 JCCMCFCNFOA;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LLADDDPHPAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float NNKPFOBEOFO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KFOHILCLCBE<LLADDDPHPAB> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HOLDFGNFCDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float KPCNHEKAOOJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KFOHILCLCBE<HOLDFGNFCDO> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MGLMLNJNIKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 AAAIDNKIFIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DJFFKEPPBFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public GOIKPLFAGFM AFMPEOCEABJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NHPELLEOADP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GOIKPLFAGFM ILIEELGBJLL;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BBGAKOBIAGC]
public struct JGFHDBKOHGK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity CCHOHIEEHEH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GEBIHBIHMDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DHABPKCJEOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GPGOCDIGOPO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IBEOOMILKKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints AJGCGHEJJII;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DMEIEOLAIGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CGHFGHFBHCK;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly KFOHILCLCBE<DMEIEOLAIGN> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AAIGMOCDIIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float DJLCHILPGAA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ANBDJPOIHEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct LLCPONLICFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int DOBLMNECOCN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static LLCPONLICFC FMKGPFEKDFI(int GNLEHBFFNFG)
	{
		return default(LLCPONLICFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LEMFBLJCKPH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody MAAIGBPPBFP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D5F0", Offset = "0x5D8C3F0", VA = "0x185D8D5F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LEMFBLJCKPH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PIAMHIIECGI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PNHEIFKAPGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float MLIIJCNNBPA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KFOHILCLCBE<PNHEIFKAPGL> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NNIJPIIKDJM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public object GKGJNHDKHDH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E000", Offset = "0x5D8CE00", VA = "0x185D8E000", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NNIJPIIKDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BMFNFNIHHDA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public object FAHODDKJILO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D871F0", Offset = "0x5D85FF0", VA = "0x185D871F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BMFNFNIHHDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GOIKPLFAGFM
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum EPMFMHNHMEG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HDDDKCEGLNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDKLHBOLFFL(IBCCCJOGKLP JGIAMHBKIBA, IBCCCJOGKLP AFKIDGEHLLD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCCEABODPJG();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCGIDAAGDMA();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMMDNFNCIPM(bool IMPHHDIGJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JGEPINIMDCB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOHPGKLGNHD();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AGOOCGCIPPE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HDDDKCEGLNC CPPMNINGDPD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D87080", Offset = "0x5D85E80", VA = "0x185D87080", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public AGOOCGCIPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JGAIBLAEKFC
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly List<(FPKCPFBLOPG nameHash, KEDJJAGCMFO stableTypeHash, Type type)> DDEFFFCKLLO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly List<(FPKCPFBLOPG nameHash, KEDJJAGCMFO stableTypeHash, Type type)> DGODFIJGIBA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(FPKCPFBLOPG previousNameHash, KEDJJAGCMFO previousStableTypeHash, Type currentTypeName)> FPEANFIFEON;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NPLDCLIFNFC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D871D0", Offset = "0x5D85FD0", VA = "0x185D871D0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct BOMPBJOFHHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[GDDFPGEMHFM(1)]
	public quaternion FIIPDOPILCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[GDDFPGEMHFM(2)]
	public float3 ELHIODNHAHA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly KFOHILCLCBE<BOMPBJOFHHO> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x391C0F0", Offset = "0x391AEF0", VA = "0x18391C0F0")]
	public BOMPBJOFHHO(quaternion FIIPDOPILCE, float3 ELHIODNHAHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D87260", Offset = "0x5D86060", VA = "0x185D87260")]
	public static BOMPBJOFHHO FMKGPFEKDFI(RigidTransform HKMBHMECFMJ)
	{
		return default(BOMPBJOFHHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LJHLOHNONFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[CPJGCOIJHGH]
public struct CBCEOBHEKLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[GDDFPGEMHFM(1)]
	public float JDLJFLJJFBP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly KFOHILCLCBE<CBCEOBHEKLO> BKEFLEENBBL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CPJGCOIJHGH]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[GDDFPGEMHFM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D871E0", Offset = "0x5D85FE0", VA = "0x185D871E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IHIJNEKFLEC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct AGECMMOJHMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct KJJOIOAKAKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[GDDFPGEMHFM(1)]
	public SerializableGuid HPBOKIMIODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[GDDFPGEMHFM(2)]
	public SerializableGuid JLBBMGLDMCI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct EJJFAPGOCID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity JFOCFPMOGNO;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FAMLAGKPFED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity JFOCFPMOGNO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[FLDPNFONGFG("Container", 0)]
[CPJGCOIJHGH]
public struct EDLMMIAOCLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public KJMNOPEJLKJ OHBNMFIHJMC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KFOHILCLCBE<EDLMMIAOCLP> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[FPKBNLHPOFP(0, 127)]
public enum KJMNOPEJLKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FLLDAHOMAOD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum PFBHBNBKOLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ANBJPIJPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D88B20", Offset = "0x5D87920", VA = "0x185D88B20")]
	public static (PFBHBNBKOLC, ANBJPIJPGAG) GPNOIJOANKO(this KJMNOPEJLKJ OJIFKCMJFIG)
	{
		return default((PFBHBNBKOLC, ANBJPIJPGAG));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[FLDPNFONGFG("Container", 0)]
public struct MDBNEJGOCFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public LCBPDIKJNPN CNFAPNGILPM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KFOHILCLCBE<MDBNEJGOCFE> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[FPKBNLHPOFP(0, 2)]
public enum LCBPDIKJNPN
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[FLDPNFONGFG("Container", 0)]
public struct IHGPMFPNODN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public DNCLPBDFMLC LCCBIJEOFHP;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Flags]
[FPKBNLHPOFP(0, 15943)]
public enum DNCLPBDFMLC
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct BMMKOGDMEFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IOFNJFIMDMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AEFLNIPEOEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct DIFAAIGNEFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PAMKJLDDAEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AKBENINIIDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct JJPPFKAKPGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct PBLOOLDHIEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct KBMOPILOEIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[CPJGCOIJHGH]
[FLDPNFONGFG("Container", 0)]
public struct NHMIOCMPOEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public float ACPGGACNAPA;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[CPJGCOIJHGH]
[FLDPNFONGFG("Container", 0)]
public struct OODABLJJAPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(1)]
	public FixedString64Bytes ONIBECKLJDD;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ECDFNMEFCMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<HCJNPEJCLCD> HACNEBJEDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<Entity> LCEJLMJBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private JobHandle GLEFMKPHENM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HDOIMIGPILP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D88540", Offset = "0x5D87340", VA = "0x185D88540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D88730", Offset = "0x5D87530", VA = "0x185D88730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42BC220", Offset = "0x42BB020", VA = "0x1842BC220")]
	public ECDFNMEFCMB(NativeList<HCJNPEJCLCD> HACNEBJEDOA, NativeList<Entity> LCEJLMJBKEN, JobHandle GLEFMKPHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D88610", Offset = "0x5D87410", VA = "0x185D88610")]
	public (Entity, NativeSlice<Entity>) FIBOCJJFHHD(int FJLKBMOCNHL)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D885B0", Offset = "0x5D873B0", VA = "0x185D885B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HCJNPEJCLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity JKEBPOPHOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int HLAIJKBFIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int JMNJMKJAMOL;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HIPJNBHFBBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNNHDOEDDCG(bool MJPIEFIOAEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[CPJGCOIJHGH]
[FLDPNFONGFG("Container", 0)]
public struct BOIDOBJEPGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public HJILKDHBDBL AGMLFAMGBNN;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[FPKBNLHPOFP(0, 1)]
public enum HJILKDHBDBL
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[IKGHBAMNGIG(1)]
public struct OODAAJNAONI : IComparable<OODAAJNAONI>, IEquatable<OODAAJNAONI>, MGELDCPHNEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[MPPGHNMOAHP(1)]
	public uint BDOFCNHECGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[MPPGHNMOAHP(2)]
	public uint MHCJHCJLANA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint IMNEGDFMFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E6B0", Offset = "0x5D8D4B0", VA = "0x185D8E6B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D8EB10", Offset = "0x5D8D910", VA = "0x185D8EB10")]
	public OODAAJNAONI(int BDOFCNHECGK, int IBNGJKDJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D8EB10", Offset = "0x5D8D910", VA = "0x185D8EB10")]
	public OODAAJNAONI(uint BDOFCNHECGK, uint IBNGJKDJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E9C0", Offset = "0x5D8D7C0", VA = "0x185D8E9C0")]
	public OODAAJNAONI OPLKONACOJC(int HLAIJKBFIJH = 1)
	{
		return default(OODAAJNAONI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E730", Offset = "0x5D8D530", VA = "0x185D8E730")]
	public OODAAJNAONI EFMMBLEKPLF(int HLAIJKBFIJH = 1)
	{
		return default(OODAAJNAONI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E850", Offset = "0x5D8D650", VA = "0x185D8E850")]
	public static OODAAJNAONI FNIMPACPDCA(OODAAJNAONI HADGDMKFEOD, OODAAJNAONI CJIAEKJDMKM)
	{
		return default(OODAAJNAONI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E990", Offset = "0x5D8D790", VA = "0x185D8E990")]
	private static uint NFDMHKNOACP(uint MACGGKMNKNM, uint JHKDDIMPPGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E690", Offset = "0x5D8D490", VA = "0x185D8E690", Slot = "4")]
	public int CompareTo(OODAAJNAONI MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E7A0", Offset = "0x5D8D5A0", VA = "0x185D8E7A0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8EA30", Offset = "0x5D8D830", VA = "0x185D8EA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E830", Offset = "0x5D8D630", VA = "0x185D8E830", Slot = "5")]
	public bool Equals(OODAAJNAONI MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E940", Offset = "0x5D8D740", VA = "0x185D8E940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E8D0", Offset = "0x5D8D6D0", VA = "0x185D8E8D0", Slot = "6")]
	public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E6C0", Offset = "0x5D8D4C0", VA = "0x185D8E6C0", Slot = "7")]
	public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24F4400", Offset = "0x24F3200", VA = "0x1824F4400")]
	public static bool NOLBLOCHCOA(OODAAJNAONI HADGDMKFEOD, OODAAJNAONI CJIAEKJDMKM)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[IKGHBAMNGIG(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[MPPGHNMOAHP(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[MPPGHNMOAHP(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[MPPGHNMOAHP(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[MPPGHNMOAHP(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[IKGHBAMNGIG(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, MGELDCPHNEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[MPPGHNMOAHP(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public static SerializableGuid FMKGPFEKDFI(Guid FGCEIIELPBP)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D90070", Offset = "0x5D8EE70", VA = "0x185D90070", Slot = "4")]
		public bool Equals(SerializableGuid MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializableGuid MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D900A0", Offset = "0x5D8EEA0", VA = "0x185D900A0", Slot = "6")]
		public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFF0", Offset = "0x5D8EDF0", VA = "0x185D8FFF0", Slot = "7")]
		public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D90160", Offset = "0x5D8EF60", VA = "0x185D90160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[CPJGCOIJHGH]
public struct PHGGCAODHCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct DKDONCAONCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[GDDFPGEMHFM(1)]
	public Entity CJKEIGLKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[GDDFPGEMHFM(2)]
	public bool FCEHMMEHDLO;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct KLIEBDBJHMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[GDDFPGEMHFM(1)]
	public MGAKHNOAGMM LLPAKMNIICP;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[FPKBNLHPOFP(0, 4)]
public enum MGAKHNOAGMM
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct CFJFLFILIBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[GDDFPGEMHFM(1)]
	public Entity CJKEIGLKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[GDDFPGEMHFM(2)]
	public bool OHDNMKMHMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[GDDFPGEMHFM(3)]
	public float GHPJGLLMOAM;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct NNOPOEGGGBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[GDDFPGEMHFM(1)]
	public bool IELHLOGPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[GDDFPGEMHFM(2)]
	public bool OHDNMKMHMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[GDDFPGEMHFM(3)]
	public float AAFIFKJHGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[GDDFPGEMHFM(4)]
	public float GBOBLEMPFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[GDDFPGEMHFM(5)]
	public float COGFLCBHIIG;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[CPJGCOIJHGH]
public struct NIIMBJMFKML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[GDDFPGEMHFM(1)]
	public bool IELHLOGPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[GDDFPGEMHFM(2)]
	public bool OHDNMKMHMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[GDDFPGEMHFM(3)]
	public float GHPJGLLMOAM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D871D0", Offset = "0x5D85FD0", VA = "0x185D871D0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CPJGCOIJHGH]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[GDDFPGEMHFM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, DPJHIPLKBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct BKFCADMOBLH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface DPJHIPLKBBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Entity BBEFCNMIGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct NDEJLNBOAMH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly bool EHIDAKAHKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public uint BGONHANGILN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	private static bool LFLLBANEEIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[CPJGCOIJHGH]
[FLDPNFONGFG("Light", 0)]
public struct DENHCLPIMNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public bool HNEIOJHCMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(2)]
	public float ICBFFKHKCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[GDDFPGEMHFM(3)]
	[FOFEEPDIDPH(0)]
	public float OCEFOKCLIAN;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[FLDPNFONGFG("Light", 0)]
public struct PGGIHPFMBKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public float IENMGLLFLLM;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.TypeVersion(2)]
public struct KFNLPBLECCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public uint OGPFELMLPBG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D4A0", Offset = "0x5D8C2A0", VA = "0x185D8D4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CPJGCOIJHGH]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[MPPGHNMOAHP(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NEPMLPNCDKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public int LKPDEMOKJBN;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GBBEHLEGGAO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GCHandle LNFJJCJOBAI;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FPKBNLHPOFP(0, 4)]
public enum MBGBDMPAHDM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct EOJGLAGNFDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct FKEEAGJJACM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int LKPDEMOKJBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct DKAKHBCLFPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DMACHJBHEFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FBBDPNEHODE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.TypeVersion(3)]
[FLDPNFONGFG("Object", 0)]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
public struct OLLGOOGNBNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[GDDFPGEMHFM(2)]
	public EHHEFHOMMNK KPFAEMOGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[GDDFPGEMHFM(3)]
	[FOFEEPDIDPH(0)]
	public LDPKFFBAGIL AOOGGFCOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[GDDFPGEMHFM(5)]
	[FOFEEPDIDPH(0)]
	public PCNANKKHLJH MCGACFHJKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[MPPGHNMOAHP(4)]
	public IDNBFDLFICN LCCBIJEOFHP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public static readonly KFOHILCLCBE<OLLGOOGNBNN> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class FMCPPCPIEGK
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D88CB0", Offset = "0x5D87AB0", VA = "0x185D88CB0")]
	public static void KLJMIKDFPBF(this IDNBFDLFICN LCCBIJEOFHP, GLALILOLCDJ IELFADNHFOL, bool CLDLJEEKFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D88C90", Offset = "0x5D87A90", VA = "0x185D88C90")]
	public static bool CEOMECCPPOO(this IDNBFDLFICN LCCBIJEOFHP, GLALILOLCDJ IELFADNHFOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D88D00", Offset = "0x5D87B00", VA = "0x185D88D00")]
	public static IDNBFDLFICN OCIPPDMHHJC(this GLALILOLCDJ IELFADNHFOL)
	{
		return default(IDNBFDLFICN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D88CE0", Offset = "0x5D87AE0", VA = "0x185D88CE0")]
	public static void KLJMIKDFPBF(this LDPKFFBAGIL LCCBIJEOFHP, LDPKFFBAGIL CBPCLKCPMML, bool CLDLJEEKFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CBA170", Offset = "0x5CB8F70", VA = "0x185CBA170")]
	public static bool CEOMECCPPOO(this LDPKFFBAGIL LCCBIJEOFHP, LDPKFFBAGIL IELFADNHFOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum GLALILOLCDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[FPKBNLHPOFP(0, 16383)]
[Flags]
public enum IDNBFDLFICN
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FPKBNLHPOFP(0, 3)]
[Flags]
public enum LDPKFFBAGIL
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[LFLCELAOCJL]
[FPKBNLHPOFP(0, 4)]
public enum PCNANKKHLJH
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class LFLCELAOCJL : IIPDAAOMMFK
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D660", Offset = "0x5D8C460", VA = "0x185D8D660", Slot = "7")]
	public override string JJBOMBABIFH(string JAEAMOHJHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LFLCELAOCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IKGHBAMNGIG(1)]
public struct EHHEFHOMMNK : MGELDCPHNEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[MPPGHNMOAHP(1)]
	public bool HNEIOJHCMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[MPPGHNMOAHP(2)]
	public float3 EMNGFLFMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[MPPGHNMOAHP(3)]
	public float3 GJGMNLLCGGB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly KFOHILCLCBE<EHHEFHOMMNK> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D88900", Offset = "0x5D87700", VA = "0x185D88900", Slot = "5")]
	public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D88970", Offset = "0x5D87770", VA = "0x185D88970", Slot = "4")]
	public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MADHIJBFJFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct AHAMCJKOAGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct LCGEBGJLNNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CMEJGAINJJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public FixedString32Bytes ONIBECKLJDD;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BBGAKOBIAGC]
public struct AJLEKDDOFNF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Entity PIOKEHOJBEJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static AJLEKDDOFNF FMKGPFEKDFI(Entity GNLEHBFFNFG)
	{
		return default(AJLEKDDOFNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct IAOMJPKLHIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[GDDFPGEMHFM(1)]
	public Entity KCDDDCOKIBP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static IAOMJPKLHIP FMKGPFEKDFI(Entity CCHOHIEEHEH)
	{
		return default(IAOMJPKLHIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal struct CEGOIFELBED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Entity CCHOHIEEHEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static CEGOIFELBED FMKGPFEKDFI(Entity CCHOHIEEHEH)
	{
		return default(CEGOIFELBED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct KGHJNFKKDAG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Entity PGBFFEFAJAF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static KGHJNFKKDAG FMKGPFEKDFI(Entity CCHOHIEEHEH)
	{
		return default(KGHJNFKKDAG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal struct EDGNCPLCMBK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[FPKBNLHPOFP(0, 2)]
public enum PPAIKDMJOOF
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[CPJGCOIJHGH]
[FLDPNFONGFG("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct DFOBAGCJCAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public float GAKEMKPKCJF;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly KFOHILCLCBE<DFOBAGCJCAG> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct AJJHCLCGOEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[GDDFPGEMHFM(1)]
	public NJGEKDIELMJ MFNGBEAMPOM;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FPKBNLHPOFP(-1, 38)]
public enum NJGEKDIELMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
[CPJGCOIJHGH]
public struct KFAMMCNDFDG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[FPKBNLHPOFP(0, 7)]
	[Flags]
	public enum EPHEGHNINDM
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[GDDFPGEMHFM(1)]
	public EPHEGHNINDM LCCBIJEOFHP;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static readonly KFOHILCLCBE<KFAMMCNDFDG> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool LOEPGMOGBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D440", Offset = "0x5D8C240", VA = "0x185D8D440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FABJDAPHHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D430", Offset = "0x5D8C230", VA = "0x185D8D430")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct MINBIPMHPGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[GDDFPGEMHFM(1)]
	public PPAIKDMJOOF MFNGBEAMPOM;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[IKGHBAMNGIG(1)]
public struct HGKFIBGMEHG : MGELDCPHNEL
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[FPKBNLHPOFP(0, 7)]
	[Flags]
	public enum JIPAKLDAJAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[MPPGHNMOAHP(1)]
	public float EGGADGNLOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[MPPGHNMOAHP(2)]
	public int ODCOIMPFMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[MPPGHNMOAHP(3)]
	public JIPAKLDAJAO LCCBIJEOFHP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LOIMOJPGKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5D897C0", Offset = "0x5D885C0", VA = "0x185D897C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D897D0", Offset = "0x5D885D0", VA = "0x185D897D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NPOELNLBHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D897A0", Offset = "0x5D885A0", VA = "0x185D897A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D89780", Offset = "0x5D88580", VA = "0x185D89780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EBDNBLALEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D897B0", Offset = "0x5D885B0", VA = "0x185D897B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D89760", Offset = "0x5D88560", VA = "0x185D89760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D896B0", Offset = "0x5D884B0", VA = "0x185D896B0", Slot = "5")]
	public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D89700", Offset = "0x5D88500", VA = "0x185D89700", Slot = "4")]
	public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BBGAKOBIAGC]
internal struct KEBJOMPDFBL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Entity DEGOJJNLONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int DOJILIOCHKM;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[CPJGCOIJHGH]
public struct DJJFFCHIFLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[GDDFPGEMHFM(1)]
	public OODAAJNAONI HIGLKKMCPLJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static DJJFFCHIFLN FMKGPFEKDFI(OODAAJNAONI GNLEHBFFNFG)
	{
		return default(DJJFFCHIFLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct OKOJMLFLNIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[GDDFPGEMHFM(1)]
	public Entity PPEPGBPKJPK;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal struct NEHHHLOLDGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Entity PPEPGBPKJPK;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[CPJGCOIJHGH]
public struct NBKIDJCCNAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[GDDFPGEMHFM(1)]
	public float3 ELHIODNHAHA;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly KFOHILCLCBE<NBKIDJCCNAD> BKEFLEENBBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1EF6800", Offset = "0x1EF5600", VA = "0x181EF6800")]
	public static NBKIDJCCNAD FMKGPFEKDFI(float3 GNLEHBFFNFG)
	{
		return default(NBKIDJCCNAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[CPJGCOIJHGH]
public struct CGCGLHKGMBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[GDDFPGEMHFM(1)]
	public quaternion FIIPDOPILCE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly KFOHILCLCBE<CGCGLHKGMBB> BKEFLEENBBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
	public static CGCGLHKGMBB FMKGPFEKDFI(quaternion GNLEHBFFNFG)
	{
		return default(CGCGLHKGMBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct PFPLHPDBGCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[GDDFPGEMHFM(1)]
	public float3 MKLPPFHEAGD;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static readonly KFOHILCLCBE<PFPLHPDBGCJ> BKEFLEENBBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1EF6800", Offset = "0x1EF5600", VA = "0x181EF6800")]
	public static PFPLHPDBGCJ FMKGPFEKDFI(float3 GNLEHBFFNFG)
	{
		return default(PFPLHPDBGCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[CPJGCOIJHGH]
public struct GHJGKJPPKGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[GDDFPGEMHFM(1)]
	public HGKFIBGMEHG FJDDANGEILG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct KIHCCANCFDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct AOAIOFODAEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint BGONHANGILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int PJGBLPKPLFO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	public AOAIOFODAEG(uint LPNFFLNLCOL, int GLBBHPJBFPF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct DOLKIMOPGCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct HJILEFKKGBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct ELMGEMCPHPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct PJDPKOPAPBO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct NLHNIAPAJID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct KJGNJFNNPBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct IJOIOCPMDKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MHCAEFKDDBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct OJMIOFFGGHC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct APEDLHBGAPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct HHIBLDBKMNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct DFJIEBGDBEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal struct LLBHAMFJJKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct CJINLGLHLAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct MMDGMGAGMKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct ABAOJOMLHFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct GNKIIIJPFLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct HBCBGKCANMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal struct KMKNAGGHNPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct IMOGIHDFDIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct INPCLNOCFBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct PHJJEDGBPBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct NOEGEDLAJJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[CPJGCOIJHGH]
public struct DBPBPJDJHOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[MPPGHNMOAHP(1)]
	public AKACOOECCNI KCPGKFKLEJL;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly KFOHILCLCBE<DBPBPJDJHOB> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum AKACOOECCNI : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct MGNPDNGJLOP : IComponentData, IComparable<MGNPDNGJLOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public int JHOOOGADAIM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x162C040", Offset = "0x162AE40", VA = "0x18162C040", Slot = "4")]
	public int CompareTo(MGNPDNGJLOP MFMJJEFODHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct AGDPGJDMHLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[GDDFPGEMHFM(2)]
	public bool INCCAMBEHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[GDDFPGEMHFM(3)]
	public bool APDOPAJJIEH;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly KFOHILCLCBE<AGDPGJDMHLG> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct LPKENMAIAHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[GDDFPGEMHFM(1)]
	public bool LKBHADLOCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[GDDFPGEMHFM(2)]
	public byte HHDAAFNEHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[GDDFPGEMHFM(3)]
	public short AAGEGLMIPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[GDDFPGEMHFM(4)]
	public ushort KBNKDKGJALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[GDDFPGEMHFM(5)]
	public int LAPEMOPMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[GDDFPGEMHFM(6)]
	public uint CPOKGCJHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[GDDFPGEMHFM(7)]
	public long MCLCJDBNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[GDDFPGEMHFM(8)]
	public ulong OAMCGIEEPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[GDDFPGEMHFM(9)]
	public float HHIIKBECABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[GDDFPGEMHFM(10)]
	public double GFICEDDMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[GDDFPGEMHFM(11)]
	public GAFFGONPOAE AIAKNECDGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[GDDFPGEMHFM(12)]
	public AGIBNNHADJL LFPFOLEHION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[GDDFPGEMHFM(13)]
	public COLOMFBHHCI FNIBMGAEBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[GDDFPGEMHFM(14)]
	public KAGHEMJLFCB HLJLBJHKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[GDDFPGEMHFM(15)]
	public NHONOJPALLP IAMEJHIFIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[GDDFPGEMHFM(16)]
	public LPMHAPLGAEL HKIEOPFBFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[GDDFPGEMHFM(17)]
	public PFOFLGHKAKL BJEFFKAMEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[GDDFPGEMHFM(18)]
	public CODJJLEIIPK OILOHOKFKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[GDDFPGEMHFM(20)]
	public Quaternion DJGFOANPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[GDDFPGEMHFM(22)]
	public Vector3 LNDJIIBHFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[GDDFPGEMHFM(23)]
	public Vector4 IGEHIFDLOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[GDDFPGEMHFM(40)]
	public Entity JDNGJABKGFK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum GAFFGONPOAE : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum AGIBNNHADJL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum COLOMFBHHCI : short
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum KAGHEMJLFCB : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum NHONOJPALLP
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum LPMHAPLGAEL : uint
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum PFOFLGHKAKL : long
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum CODJJLEIIPK : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CPJGCOIJHGH]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CPJGCOIJHGH]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class LNHJLPGOEFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int GHHJLCMBOHI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public int DODFLGDLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public GameObject DEGGPBGPMDB;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LNHJLPGOEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class DOMLODLOEEH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public struct NLJPEEDOONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector3 KMBJNBJIABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public List<SerializableGuid> LEGIOPNEFJM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class JDGEMLMBELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NLJPEEDOONK AKGJHAAKLKC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JDGEMLMBELC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public SerializableGuid KHCIPMBOIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public List<int> KLMCAKHMBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public List<NLJPEEDOONK> KOCIBBPLOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public List<JDGEMLMBELC> GGPACBHCMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public GameObject DEGGPBGPMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Light LPJHLKDIFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Collider BHBBEPIOBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public string PCAKJEGHCAE;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DOMLODLOEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct GLDJHBJAKIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[GDDFPGEMHFM(1)]
	public float3 JDGMAFKPACL;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public static readonly KFOHILCLCBE<GLDJHBJAKIA> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct HDEJALOFGAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[GDDFPGEMHFM(1)]
	public quaternion FIIPDOPILCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[GDDFPGEMHFM(2)]
	public float3 ELHIODNHAHA;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public static readonly KFOHILCLCBE<HDEJALOFGAC> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x391C0F0", Offset = "0x391AEF0", VA = "0x18391C0F0")]
	public HDEJALOFGAC(quaternion FIIPDOPILCE, float3 ELHIODNHAHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D87260", Offset = "0x5D86060", VA = "0x185D87260")]
	public static RigidTransform FMKGPFEKDFI(HDEJALOFGAC IFFPEEKCNAO)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D87260", Offset = "0x5D86060", VA = "0x185D87260")]
	public static HDEJALOFGAC FMKGPFEKDFI(RigidTransform HKMBHMECFMJ)
	{
		return default(HDEJALOFGAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class DIALOHENFFB
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct IMBFFICPOKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public float4x4 OOOPJFMBINF;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public static readonly KFOHILCLCBE<IMBFFICPOKD> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct APOICHPMLJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public float4x4 AIPDOMPIDDN;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly KFOHILCLCBE<APOICHPMLJB> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[CPJGCOIJHGH]
public struct PEDPLCBIGKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[GDDFPGEMHFM(1)]
	public float JDLJFLJJFBP;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static readonly KFOHILCLCBE<PEDPLCBIGKO> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct FPKGPMINNAO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int CNNAIOGLMBH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DOJILIOCHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D88EC0", Offset = "0x5D87CC0", VA = "0x185D88EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D88EB0", Offset = "0x5D87CB0", VA = "0x185D88EB0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[CPJGCOIJHGH]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct KIAGMALCCOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[GDDFPGEMHFM(1)]
	public CIMBMICICGF LHEJPIHOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[GDDFPGEMHFM(2)]
	public IEBPIIBENLF AMLALKCONIO;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[FPKBNLHPOFP(0, 1)]
[Flags]
public enum CIMBMICICGF
{
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[FPKBNLHPOFP(-2, 2)]
public enum IEBPIIBENLF
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct CBNJLCMNPAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float3 OOBKEMKJMBD;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly KFOHILCLCBE<CBNJLCMNPAA> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct GLPHDKJHCLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float3 AILFIIEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public quaternion GIBIBDOGOLL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly KFOHILCLCBE<GLPHDKJHCLN> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D89070", Offset = "0x5D87E70", VA = "0x185D89070")]
	public float3 DHOGHGFFMCM(float3 EPFKACHOOEF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class PHBDEPDAONN
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct CJHAAIFGNDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float HHNCIKLKENP;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly KFOHILCLCBE<CJHAAIFGNDF> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[FPKBNLHPOFP(1000, 8000)]
public enum FMJMJJHCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public static class AEEDBPOJGLG
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal enum LACJANELCHE
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class EPNDGOBEMOB
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[FPKBNLHPOFP(0, 9)]
public enum IBDEBMIBBIB
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class MDIDAPLKHEB
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DB50", Offset = "0x5D8C950", VA = "0x185D8DB50")]
	public static bool LPAPCEPBICM(this IBDEBMIBBIB BCHJNKHDPLI)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[CPJGCOIJHGH]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public FMJMJJHCMAN prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class JNJFLBEJLPC
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D200", Offset = "0x5D8C000", VA = "0x185D8D200")]
	public static bool BIFFBPKCPAN(this FMJMJJHCMAN PEMNIEMPPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D220", Offset = "0x5D8C020", VA = "0x185D8D220")]
	public static string BOHLGOOIBFD(this FMJMJJHCMAN PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D1E0", Offset = "0x5D8BFE0", VA = "0x185D8D1E0")]
	public static IBDEBMIBBIB ALCOCMIFPNC(this FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(IBDEBMIBBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D270", Offset = "0x5D8C070", VA = "0x185D8D270")]
	internal static LACJANELCHE DLJLICFKILM(this IBDEBMIBBIB BCHJNKHDPLI)
	{
		return default(LACJANELCHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D280", Offset = "0x5D8C080", VA = "0x185D8D280")]
	internal static LACJANELCHE DLJLICFKILM(this FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(LACJANELCHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class CHPGBAFBHBB
{
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly Dictionary<FMJMJJHCMAN, string> GOOGEPCJCHI;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D87750", Offset = "0x5D86550", VA = "0x185D87750")]
	public static string LBBDJGJMGKI(this FMJMJJHCMAN PEMNIEMPPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[FPKBNLHPOFP(int.MinValue, int.MaxValue)]
public enum NLNFEJBMKIC
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[FPKBNLHPOFP(-1, 31)]
public enum ECODBCHBEFD
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[CPJGCOIJHGH]
[FLDPNFONGFG("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct JDDPGABLPKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[GDDFPGEMHFM(1)]
	[FOFEEPDIDPH(0)]
	public NLNFEJBMKIC BJLKCDOCMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(2)]
	public ECODBCHBEFD DDNJBDIAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	[GDDFPGEMHFM(3)]
	[FOFEEPDIDPH(0)]
	public float MFFNJELLFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(4)]
	public Vector3 NFFJJNEAMIH;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[HEGEEHEAMMF(2613756846563002039uL, 6372660366488563574uL)]
[FLDPNFONGFG("Container", 0)]
[DEIOJFONNEH]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct LDFAIBBEIHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(1)]
	public DKJPLFEIDBA JEHHLCHFKOL;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[FPKBNLHPOFP(0, 15)]
[Flags]
public enum DKJPLFEIDBA
{
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[DEIOJFONNEH]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[HEGEEHEAMMF(9804513251708000208uL, 10903582988135044631uL)]
public struct MPEAMMCMNBD : IComponentData, IEquatable<MPEAMMCMNBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	[GDDFPGEMHFM(1)]
	public FixedString64Bytes ONIBECKLJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	[GDDFPGEMHFM(2)]
	public LCBPDIKJNPN CNFAPNGILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[GDDFPGEMHFM(3)]
	public DKJPLFEIDBA JEHHLCHFKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[GDDFPGEMHFM(4)]
	public HJILKDHBDBL AGMLFAMGBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	[GDDFPGEMHFM(5)]
	public DNCLPBDFMLC LCCBIJEOFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	[GDDFPGEMHFM(6)]
	public float ACPGGACNAPA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DEA0", Offset = "0x5D8CCA0", VA = "0x185D8DEA0", Slot = "4")]
	public bool Equals(MPEAMMCMNBD MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[DEIOJFONNEH]
[HEGEEHEAMMF(1213445203937950283uL, 119653618660684511uL)]
public struct AFPLOKKIKPB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[IKGHBAMNGIG(1)]
	public struct IOMFJMBDBJJ : MGELDCPHNEL, IEquatable<IOMFJMBDBJJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		[MPPGHNMOAHP(1)]
		public int NBHCOBHPFBM;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D89EC0", Offset = "0x5D88CC0", VA = "0x185D89EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D89E30", Offset = "0x5D88C30", VA = "0x185D89E30", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x161D6C0", Offset = "0x161C4C0", VA = "0x18161D6C0", Slot = "6")]
		public bool Equals(IOMFJMBDBJJ MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x162C0D0", Offset = "0x162AED0", VA = "0x18162C0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D89E10", Offset = "0x5D88C10", VA = "0x185D89E10", Slot = "5")]
		public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D89EB0", Offset = "0x5D88CB0", VA = "0x185D89EB0", Slot = "4")]
		public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	[GDDFPGEMHFM(1)]
	public IOMFJMBDBJJ HKEECPMGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public GCHandle JGOGHBIKMPG;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[HEGEEHEAMMF(218523523639012570uL, 15191719635551116065uL)]
[DEIOJFONNEH]
public struct KNDIEGHJNOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private uint CBFMFMGNINH;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[DEIOJFONNEH]
[HEGEEHEAMMF(9898405628982320166uL, 2023375009558162791uL)]
public struct DHPHIHHLCAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[GDDFPGEMHFM(1)]
	public IDNBFDLFICN LCCBIJEOFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[GDDFPGEMHFM(2)]
	public EHHEFHOMMNK KPFAEMOGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(3)]
	public bool CIHGPBFILGN;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly KFOHILCLCBE<DHPHIHHLCAG> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[HEGEEHEAMMF(9807788745867066359uL, 15168486114979071194uL)]
[DEIOJFONNEH]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct JKNDOMJBHAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[GDDFPGEMHFM(1)]
	public IDNBFDLFICN LCCBIJEOFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[GDDFPGEMHFM(2)]
	public EHHEFHOMMNK KPFAEMOGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(3)]
	public bool CIHGPBFILGN;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly KFOHILCLCBE<JKNDOMJBHAG> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[HEGEEHEAMMF(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[DEIOJFONNEH]
public struct HGJMAKDKJAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[MPPGHNMOAHP(1)]
	public IDNBFDLFICN LCCBIJEOFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[GDDFPGEMHFM(2)]
	public EHHEFHOMMNK KPFAEMOGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[FOFEEPDIDPH(0)]
	[GDDFPGEMHFM(3)]
	public LDPKFFBAGIL AOOGGFCOPIN;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly KFOHILCLCBE<HGJMAKDKJAP> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[HEGEEHEAMMF(12226092714547765037uL, 15970362445488810630uL)]
[DEIOJFONNEH]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct IIKFGABJCHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[GDDFPGEMHFM(2)]
	public EHHEFHOMMNK KPFAEMOGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[GDDFPGEMHFM(3)]
	[FOFEEPDIDPH(0)]
	public LDPKFFBAGIL AOOGGFCOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[MPPGHNMOAHP(4)]
	public IDNBFDLFICN LCCBIJEOFHP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly KFOHILCLCBE<IIKFGABJCHA> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[DEIOJFONNEH]
[HEGEEHEAMMF(3318727941304405759uL, 6047901070934821887uL)]
public struct GBFDACAEBKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public int KLKKGNLCGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[GDDFPGEMHFM(2)]
	public bool INCCAMBEHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[GDDFPGEMHFM(3)]
	public bool APDOPAJJIEH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly KFOHILCLCBE<GBFDACAEBKA> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[HEGEEHEAMMF(5861057081882613294uL, 13746475565109640919uL)]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[DEIOJFONNEH]
public struct CPPKAAOJHGB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[FPKBNLHPOFP(0, 1)]
	public enum DICACFPLOPP
	{
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[GDDFPGEMHFM(1)]
	public DICACFPLOPP KFCJIFCMMHB;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[DEIOJFONNEH]
[HEGEEHEAMMF(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct CPAHCBLMOCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[GDDFPGEMHFM(1)]
	public FMJMJJHCMAN CMNEDOHOKIA;
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[DEIOJFONNEH]
[HEGEEHEAMMF(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct PDKKPKEINKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[GDDFPGEMHFM(1)]
	public FMJMJJHCMAN CMNEDOHOKIA;
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[DEIOJFONNEH]
[HEGEEHEAMMF(1029043735688538310uL, 14256247939851101839uL)]
public struct LBNNCJOLGHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public IBDEBMIBBIB BCHJNKHDPLI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DEIOJFONNEH]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[HEGEEHEAMMF(17667479821163689808uL, 11946378475791123970uL)]
public struct FBOKOEFEHLE : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : LHFJOJDLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D90170", Offset = "0x5D8EF70", VA = "0x185D90170", Slot = "4")]
		public sealed override void JDGHKCFEBFB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class OJCGHEAGEOG : ContainerPropertyBag<LEMFBLJCKPH>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class JHBBGCNFAND : Property<LEMFBLJCKPH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CF70", Offset = "0x5D8BD70", VA = "0x185D8CF70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D8CF30", Offset = "0x5D8BD30", VA = "0x185D8CF30")]
		public JHBBGCNFAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A60", Offset = "0x5D87860", VA = "0x185D88A60", Slot = "14")]
		public override Rigidbody GetValue(LEMFBLJCKPH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A80", Offset = "0x5D87880", VA = "0x185D88A80", Slot = "15")]
		public override void SetValue(LEMFBLJCKPH NFDHIFFHPGD, Rigidbody GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E2A0", Offset = "0x5D8D0A0", VA = "0x185D8E2A0")]
	public OJCGHEAGEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class AAANIMDDCBO : ContainerPropertyBag<NNIJPIIKDJM>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class EKAIAGEOPAM : Property<NNIJPIIKDJM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D88AF0", Offset = "0x5D878F0", VA = "0x185D88AF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D88AB0", Offset = "0x5D878B0", VA = "0x185D88AB0")]
		public EKAIAGEOPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A60", Offset = "0x5D87860", VA = "0x185D88A60", Slot = "14")]
		public override object GetValue(NNIJPIIKDJM NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A80", Offset = "0x5D87880", VA = "0x185D88A80", Slot = "15")]
		public override void SetValue(NNIJPIIKDJM NFDHIFFHPGD, object GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D86AA0", Offset = "0x5D858A0", VA = "0x185D86AA0")]
	public AAANIMDDCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class OEKPAMMBINE : ContainerPropertyBag<BMFNFNIHHDA>
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class PDOCEMPBBAH : Property<BMFNFNIHHDA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D8EBA0", Offset = "0x5D8D9A0", VA = "0x185D8EBA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EB60", Offset = "0x5D8D960", VA = "0x185D8EB60")]
		public PDOCEMPBBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A60", Offset = "0x5D87860", VA = "0x185D88A60", Slot = "14")]
		public override object GetValue(BMFNFNIHHDA NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A80", Offset = "0x5D87880", VA = "0x185D88A80", Slot = "15")]
		public override void SetValue(BMFNFNIHHDA NFDHIFFHPGD, object GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E130", Offset = "0x5D8CF30", VA = "0x185D8E130")]
	public OEKPAMMBINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class CBOFIJHAPOI : ContainerPropertyBag<AGOOCGCIPPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class JOKHHEJAEPB : Property<AGOOCGCIPPE, HDDDKCEGLNC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D2E0", Offset = "0x5D8C0E0", VA = "0x185D8D2E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D2A0", Offset = "0x5D8C0A0", VA = "0x185D8D2A0")]
		public JOKHHEJAEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A60", Offset = "0x5D87860", VA = "0x185D88A60", Slot = "14")]
		public override HDDDKCEGLNC GetValue(AGOOCGCIPPE NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A80", Offset = "0x5D87880", VA = "0x185D88A80", Slot = "15")]
		public override void SetValue(AGOOCGCIPPE NFDHIFFHPGD, HDDDKCEGLNC GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D875F0", Offset = "0x5D863F0", VA = "0x185D875F0")]
	public CBOFIJHAPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class FOPMODAHGLO : ContainerPropertyBag<LNHJLPGOEFM>
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class LGNBJAJLBEL : Property<LNHJLPGOEFM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D7B0", Offset = "0x5D8C5B0", VA = "0x185D8D7B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D770", Offset = "0x5D8C570", VA = "0x185D8D770")]
		public LGNBJAJLBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D730", Offset = "0x5D8C530", VA = "0x185D8D730", Slot = "14")]
		public override int GetValue(LNHJLPGOEFM NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D750", Offset = "0x5D8C550", VA = "0x185D8D750", Slot = "15")]
		public override void SetValue(LNHJLPGOEFM NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class LPOIJOFABHF : Property<LNHJLPGOEFM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5D8DAC0", Offset = "0x5D8C8C0", VA = "0x185D8DAC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DA80", Offset = "0x5D8C880", VA = "0x185D8DA80")]
		public LPOIJOFABHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DA40", Offset = "0x5D8C840", VA = "0x185D8DA40", Slot = "14")]
		public override int GetValue(LNHJLPGOEFM NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DA60", Offset = "0x5D8C860", VA = "0x185D8DA60", Slot = "15")]
		public override void SetValue(LNHJLPGOEFM NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class GDBPEEGMJKO : Property<LNHJLPGOEFM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D88FD0", Offset = "0x5D87DD0", VA = "0x185D88FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D88F90", Offset = "0x5D87D90", VA = "0x185D88F90")]
		public GDBPEEGMJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D88F40", Offset = "0x5D87D40", VA = "0x185D88F40", Slot = "14")]
		public override GameObject GetValue(LNHJLPGOEFM NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D88F60", Offset = "0x5D87D60", VA = "0x185D88F60", Slot = "15")]
		public override void SetValue(LNHJLPGOEFM NFDHIFFHPGD, GameObject GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D88D10", Offset = "0x5D87B10", VA = "0x185D88D10")]
	public FOPMODAHGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class AAIBEDDBCNA : ContainerPropertyBag<DOMLODLOEEH>
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class ODMEDDCMBLB : Property<DOMLODLOEEH, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E100", Offset = "0x5D8CF00", VA = "0x185D8E100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E0C0", Offset = "0x5D8CEC0", VA = "0x185D8E0C0")]
		public ODMEDDCMBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E070", Offset = "0x5D8CE70", VA = "0x185D8E070", Slot = "14")]
		public override SerializableGuid GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E0A0", Offset = "0x5D8CEA0", VA = "0x185D8E0A0", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, SerializableGuid GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class OKNHJHEFDBF : Property<DOMLODLOEEH, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E4A0", Offset = "0x5D8D2A0", VA = "0x185D8E4A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E460", Offset = "0x5D8D260", VA = "0x185D8E460")]
		public OKNHJHEFDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E410", Offset = "0x5D8D210", VA = "0x185D8E410", Slot = "14")]
		public override List<int> GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E430", Offset = "0x5D8D230", VA = "0x185D8E430", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, List<int> GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class ONCGCMEMBAN : Property<DOMLODLOEEH, List<DOMLODLOEEH.NLJPEEDOONK>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E660", Offset = "0x5D8D460", VA = "0x185D8E660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E620", Offset = "0x5D8D420", VA = "0x185D8E620")]
		public ONCGCMEMBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5D0", Offset = "0x5D8D3D0", VA = "0x185D8E5D0", Slot = "14")]
		public override List<DOMLODLOEEH.NLJPEEDOONK> GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5F0", Offset = "0x5D8D3F0", VA = "0x185D8E5F0", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, List<DOMLODLOEEH.NLJPEEDOONK> GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class LJLFBBIMOOL : Property<DOMLODLOEEH, List<DOMLODLOEEH.JDGEMLMBELC>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D870", Offset = "0x5D8C670", VA = "0x185D8D870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D830", Offset = "0x5D8C630", VA = "0x185D8D830")]
		public LJLFBBIMOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D7E0", Offset = "0x5D8C5E0", VA = "0x185D8D7E0", Slot = "14")]
		public override List<DOMLODLOEEH.JDGEMLMBELC> GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D800", Offset = "0x5D8C600", VA = "0x185D8D800", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, List<DOMLODLOEEH.JDGEMLMBELC> GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class GPHJAMMEMHF : Property<DOMLODLOEEH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D894D0", Offset = "0x5D882D0", VA = "0x185D894D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D89490", Offset = "0x5D88290", VA = "0x185D89490")]
		public GPHJAMMEMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D89440", Offset = "0x5D88240", VA = "0x185D89440", Slot = "14")]
		public override GameObject GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D89460", Offset = "0x5D88260", VA = "0x185D89460", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, GameObject GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class EBCDJLKAMEP : Property<DOMLODLOEEH, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5D88510", Offset = "0x5D87310", VA = "0x185D88510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D884D0", Offset = "0x5D872D0", VA = "0x185D884D0")]
		public EBCDJLKAMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D88480", Offset = "0x5D87280", VA = "0x185D88480", Slot = "14")]
		public override Light GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D884A0", Offset = "0x5D872A0", VA = "0x185D884A0", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, Light GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class PHIKAMBMFHL : Property<DOMLODLOEEH, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5D8ED30", Offset = "0x5D8DB30", VA = "0x185D8ED30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D8ECF0", Offset = "0x5D8DAF0", VA = "0x185D8ECF0")]
		public PHIKAMBMFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D8ECA0", Offset = "0x5D8DAA0", VA = "0x185D8ECA0", Slot = "14")]
		public override Collider GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8ECC0", Offset = "0x5D8DAC0", VA = "0x185D8ECC0", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, Collider GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class KGHPENPKBDF : Property<DOMLODLOEEH, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D5C0", Offset = "0x5D8C3C0", VA = "0x185D8D5C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D580", Offset = "0x5D8C380", VA = "0x185D8D580")]
		public KGHPENPKBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D530", Offset = "0x5D8C330", VA = "0x185D8D530", Slot = "14")]
		public override string GetValue(DOMLODLOEEH NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D550", Offset = "0x5D8C350", VA = "0x185D8D550", Slot = "15")]
		public override void SetValue(DOMLODLOEEH NFDHIFFHPGD, string GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D86B80", Offset = "0x5D85980", VA = "0x185D86B80")]
	public AAIBEDDBCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class MJBNINCHDBK : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class INGNEIKEEEB : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5D89DE0", Offset = "0x5D88BE0", VA = "0x185D89DE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D89CF0", Offset = "0x5D88AF0", VA = "0x185D89CF0")]
		public INGNEIKEEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "14")]
		public override Data128 GetValue(SerializableGuid NFDHIFFHPGD)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D89CE0", Offset = "0x5D88AE0", VA = "0x185D89CE0", Slot = "15")]
		public override void SetValue(SerializableGuid NFDHIFFHPGD, Data128 GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DC40", Offset = "0x5D8CA40", VA = "0x185D8DC40")]
	public MJBNINCHDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class PINGAHNLAKJ : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class KANEBDKKNBJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D400", Offset = "0x5D8C200", VA = "0x185D8D400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D310", Offset = "0x5D8C110", VA = "0x185D8D310")]
		public KANEBDKKNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1201160", Offset = "0x11FFF60", VA = "0x181201160", Slot = "14")]
		public override int GetValue(Data128 NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D87300", Offset = "0x5D86100", VA = "0x185D87300", Slot = "15")]
		public override void SetValue(Data128 NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class LPHEBPKMGFH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5D8DA10", Offset = "0x5D8C810", VA = "0x185D8DA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D920", Offset = "0x5D8C720", VA = "0x185D8D920")]
		public LPHEBPKMGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D900", Offset = "0x5D8C700", VA = "0x185D8D900", Slot = "14")]
		public override int GetValue(Data128 NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D910", Offset = "0x5D8C710", VA = "0x185D8D910", Slot = "15")]
		public override void SetValue(Data128 NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class EHFCJEPBPGL : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5D888D0", Offset = "0x5D876D0", VA = "0x185D888D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D887E0", Offset = "0x5D875E0", VA = "0x185D887E0")]
		public EHFCJEPBPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x14AF7D0", Offset = "0x14AE5D0", VA = "0x1814AF7D0", Slot = "14")]
		public override int GetValue(Data128 NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D887D0", Offset = "0x5D875D0", VA = "0x185D887D0", Slot = "15")]
		public override void SetValue(Data128 NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class JNAKFGGACBH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D1B0", Offset = "0x5D8BFB0", VA = "0x185D8D1B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D0C0", Offset = "0x5D8BEC0", VA = "0x185D8D0C0")]
		public JNAKFGGACBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D0A0", Offset = "0x5D8BEA0", VA = "0x185D8D0A0", Slot = "14")]
		public override int GetValue(Data128 NFDHIFFHPGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D0B0", Offset = "0x5D8BEB0", VA = "0x185D8D0B0", Slot = "15")]
		public override void SetValue(Data128 NFDHIFFHPGD, int GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D8EDC0", Offset = "0x5D8DBC0", VA = "0x185D8EDC0")]
	public PINGAHNLAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class CAFHHLNPMGP : ContainerPropertyBag<DOMLODLOEEH.NLJPEEDOONK>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class OHACHAGMADC : Property<DOMLODLOEEH.NLJPEEDOONK, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E270", Offset = "0x5D8D070", VA = "0x185D8E270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E230", Offset = "0x5D8D030", VA = "0x185D8E230")]
		public OHACHAGMADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85CF00", Offset = "0x85BD00", VA = "0x18085CF00", Slot = "14")]
		public override Vector3 GetValue(DOMLODLOEEH.NLJPEEDOONK NFDHIFFHPGD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E210", Offset = "0x5D8D010", VA = "0x185D8E210", Slot = "15")]
		public override void SetValue(DOMLODLOEEH.NLJPEEDOONK NFDHIFFHPGD, Vector3 GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class OKIMKPPNMLE : Property<DOMLODLOEEH.NLJPEEDOONK, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E3E0", Offset = "0x5D8D1E0", VA = "0x185D8E3E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E3A0", Offset = "0x5D8D1A0", VA = "0x185D8E3A0")]
		public OKIMKPPNMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E380", Offset = "0x5D8D180", VA = "0x185D8E380", Slot = "14")]
		public override List<SerializableGuid> GetValue(DOMLODLOEEH.NLJPEEDOONK NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E390", Offset = "0x5D8D190", VA = "0x185D8E390", Slot = "15")]
		public override void SetValue(DOMLODLOEEH.NLJPEEDOONK NFDHIFFHPGD, List<SerializableGuid> GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D87380", Offset = "0x5D86180", VA = "0x185D87380")]
	public CAFHHLNPMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class DCNAKKHNFJD : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class DDJCPKCJDGL : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D88290", Offset = "0x5D87090", VA = "0x185D88290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D88250", Offset = "0x5D87050", VA = "0x185D88250")]
		public DDJCPKCJDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D88230", Offset = "0x5D87030", VA = "0x185D88230", Slot = "14")]
		public override float GetValue(Vector3 NFDHIFFHPGD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D88240", Offset = "0x5D87040", VA = "0x185D88240", Slot = "15")]
		public override void SetValue(Vector3 NFDHIFFHPGD, float GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class HHBGCHOOJDC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5D89850", Offset = "0x5D88650", VA = "0x185D89850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5D89810", Offset = "0x5D88610", VA = "0x185D89810")]
		public HHBGCHOOJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D897F0", Offset = "0x5D885F0", VA = "0x185D897F0", Slot = "14")]
		public override float GetValue(Vector3 NFDHIFFHPGD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D89800", Offset = "0x5D88600", VA = "0x185D89800", Slot = "15")]
		public override void SetValue(Vector3 NFDHIFFHPGD, float GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class AFABCFHGNMI : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5D86FF0", Offset = "0x5D85DF0", VA = "0x185D86FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5D86FB0", Offset = "0x5D85DB0", VA = "0x185D86FB0")]
		public AFABCFHGNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1892DD0", Offset = "0x1891BD0", VA = "0x181892DD0", Slot = "14")]
		public override float GetValue(Vector3 NFDHIFFHPGD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5D86FA0", Offset = "0x5D85DA0", VA = "0x185D86FA0", Slot = "15")]
		public override void SetValue(Vector3 NFDHIFFHPGD, float GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D88090", Offset = "0x5D86E90", VA = "0x185D88090")]
	public DCNAKKHNFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal class GMHNIJHBOBO : ContainerPropertyBag<DOMLODLOEEH.JDGEMLMBELC>
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class MINMKCBKEEI : Property<DOMLODLOEEH.JDGEMLMBELC, DOMLODLOEEH.NLJPEEDOONK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5D8DC10", Offset = "0x5D8CA10", VA = "0x185D8DC10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DBD0", Offset = "0x5D8C9D0", VA = "0x185D8DBD0")]
		public MINMKCBKEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DB60", Offset = "0x5D8C960", VA = "0x185D8DB60", Slot = "14")]
		public override DOMLODLOEEH.NLJPEEDOONK GetValue(DOMLODLOEEH.JDGEMLMBELC NFDHIFFHPGD)
		{
			return default(DOMLODLOEEH.NLJPEEDOONK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DB90", Offset = "0x5D8C990", VA = "0x185D8DB90", Slot = "15")]
		public override void SetValue(DOMLODLOEEH.JDGEMLMBELC NFDHIFFHPGD, DOMLODLOEEH.NLJPEEDOONK GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D89360", Offset = "0x5D88160", VA = "0x185D89360")]
	public GMHNIJHBOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal class MONHFFCAIAN : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class BPOILMMCLAA : Property<RRObjectPrefabV2Data, FMJMJJHCMAN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5D87350", Offset = "0x5D86150", VA = "0x185D87350", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D87310", Offset = "0x5D86110", VA = "0x185D87310")]
		public BPOILMMCLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1201160", Offset = "0x11FFF60", VA = "0x181201160", Slot = "14")]
		public override FMJMJJHCMAN GetValue(RRObjectPrefabV2Data NFDHIFFHPGD)
		{
			return default(FMJMJJHCMAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D87300", Offset = "0x5D86100", VA = "0x185D87300", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data NFDHIFFHPGD, FMJMJJHCMAN GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DDC0", Offset = "0x5D8CBC0", VA = "0x185D8DDC0")]
	public MONHFFCAIAN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F2A0", Offset = "0x5D8E0A0", VA = "0x185D8F2A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000110")]
public class IKMPJPADFGH
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKMPJPADFGH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
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
