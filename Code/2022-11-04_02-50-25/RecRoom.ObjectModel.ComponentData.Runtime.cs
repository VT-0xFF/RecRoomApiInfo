using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Components;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct ABBCBLJMMNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode PCMIAMNBBHC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ABBCBLJMMNF MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct DDJDCKIFIPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public KACHEPBJCJB NOJBBGEAIDI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DDJDCKIFIPM MGJBOLMPFNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CGMLGDBGAEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DIHCKLGPKMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KACHEPBJCJB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LFNLJCMAGEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct BCHKFCEDDOO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity MIJGFFHMOFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GJDCEPAJFCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BLENCGKHIJI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly GJDCEPAJFCP MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KEEMEBINMNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity JAFNHFEOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly KEEMEBINMNA MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KNFINANKODG : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KNBKLLABAKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 FBHKMNMJJJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KLKCMAPJIGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OEOLLEBICGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 JDCDFFHCHBF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly OEOLLEBICGI MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IGCFHJMAFDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion KGMIHLJJHED;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly IGCFHJMAFDM MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FHKNLIGMGNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 GBHLCANBGFN;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly FHKNLIGMGNK MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FMNLMLKNEGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KOECGKDLFHA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly FMNLMLKNEGH MGJBOLMPFNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NDNIFJFJCHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FINHABMOIIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float AKJAJNBDHHN;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly FINHABMOIIL MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GDADEMIDBIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 KBDCFHKMMEE;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JDLHECNGEDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OBMNDCKAAPN HMJIHEOLILH;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly JDLHECNGEDC MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ICKNFNIMFGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OBMNDCKAAPN IILDEPAHHLC;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly ICKNFNIMFGM MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BIFPCOHOIBP : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CLALFINCOBK : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ALBJJIPJILG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MAKIDOFIDOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HACGKKFJBJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CJHEJJKECMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints BGPNKBPMPMD;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CJHEJJKECMC MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KHACLFGCNGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CBOIDDOJDAO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KHACLFGCNGP MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HANCCCJJBCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float GDCLNFEPIOA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly HANCCCJJBCJ MGJBOLMPFNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FKPIHPKAIHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LEKLBINIPFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int NBNLKJODOFF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly LEKLBINIPFJ MGJBOLMPFNF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x850260", Offset = "0x84F660", VA = "0x180850260")]
	public static LEKLBINIPFJ IGKGMCHPHKB(int PKODKJLGOIN)
	{
		return default(LEKLBINIPFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KLFFPBFDDJE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody MCFBEICDKMP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F20260", Offset = "0x5F1F660", VA = "0x185F20260", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public KLFFPBFDDJE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GGCJJBBPBHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KLKLJDBPIGE : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BFFAOFPDNDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float OBFEIADOPEN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly BFFAOFPDNDM MGJBOLMPFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct EGJNONMMACL : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LEKMBJAHKKE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object EGFPMGJAODP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F202D0", Offset = "0x5F1F6D0", VA = "0x185F202D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LEKMBJAHKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IIAMMOMGJKL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object KJBPJGFEOPM;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FFE0", Offset = "0x5F1F3E0", VA = "0x185F1FFE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public IIAMMOMGJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OBMNDCKAAPN
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CKFADKHCOCO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KFMMEAOIBIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILIPNLHHAFK(KACHEPBJCJB CCHOACKDLOO, KACHEPBJCJB OAKKLPMJENG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKAHJOONMIM();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDBOKNCOPNE();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHNLKPNKEBM(bool LJBNFKDALHI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFIJKDEFHIH();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BGBFJMKGMAM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KFMMEAOIBIL LDIJPOLPBIJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F4E0", Offset = "0x5F1E8E0", VA = "0x185F1F4E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BGBFJMKGMAM()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[InternalBufferCapacity(8)]
	[DNDHFINHMIH(1)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, DCIIGNCABLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A89870", Offset = "0x3A88C70", VA = "0x183A89870", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[DNDHFINHMIH(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GDPJNMPNCJB(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[GDPJNMPNCJB(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1EC5800", Offset = "0x1EC4C00", VA = "0x181EC5800")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F240", Offset = "0x5F1E640", VA = "0x185F1F240")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[DNDHFINHMIH(1)]
	public struct AuthoredParentData : IComponentData, DCIIGNCABLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[GDPJNMPNCJB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F270", Offset = "0x5F1E670", VA = "0x185F1F270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BKLOPJPPHED : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NEJHAMPOPML : ISystemStateComponentData, IComponentData, DCIIGNCABLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity OANAMMJAMEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity HKIDIDENHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PDNNBBMMODJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int CFFPFDDOHIM;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MLFPOGNAGBJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle AKIHCIKAOPB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[PLNMLHECGFL(1)]
	[DNDHFINHMIH(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[GDPJNMPNCJB(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[GDPJNMPNCJB(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Flags]
[PPMCLPGJKOH(0, 15)]
public enum DHDOFFNGFJO
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	All = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PPMCLPGJKOH(0, 2)]
public enum HHGDALAMKNG
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[DNDHFINHMIH(1)]
	[MJJLCIOLOIA("Container", 0)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[GDPJNMPNCJB(1)]
		[AIHIFOHMDKA(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[GFPAJCPDPAL]
		[GDPJNMPNCJB(2)]
		[AIHIFOHMDKA(0)]
		public HHGDALAMKNG collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[GFPAJCPDPAL]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(3)]
		public DHDOFFNGFJO collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[GFPAJCPDPAL]
		[GDPJNMPNCJB(4)]
		[AIHIFOHMDKA(0)]
		public EHFEJMGIMNE grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[GFPAJCPDPAL]
		[GDPJNMPNCJB(5)]
		[AIHIFOHMDKA(0)]
		public ABMFFIFNGAO flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[GFPAJCPDPAL]
		[GDPJNMPNCJB(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F550", Offset = "0x5F1E950", VA = "0x185F1F550", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
[PPMCLPGJKOH(0, 16071)]
public enum ABMFFIFNGAO
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	IsGrabbable = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	All = 0x3EC7,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MAX = 0x3EC7
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PPMCLPGJKOH(0, 1)]
public enum EHFEJMGIMNE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PLNMLHECGFL(1)]
public struct EEJCBIDCBHN : IComparable<EEJCBIDCBHN>, IEquatable<EEJCBIDCBHN>, JEHFEHAOHED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[MNDFNGFCIJE(1)]
	public uint HBCDJAJKNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[MNDFNGFCIJE(2)]
	public uint CBNLDDBDLFK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint IEEPIJNOOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F1FB50", Offset = "0x5F1EF50", VA = "0x185F1FB50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FC40", Offset = "0x5F1F040", VA = "0x185F1FC40")]
	public EEJCBIDCBHN(int HBCDJAJKNAI, int JGKHGNCNNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FC40", Offset = "0x5F1F040", VA = "0x185F1FC40")]
	public EEJCBIDCBHN(uint HBCDJAJKNAI, uint JGKHGNCNNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F910", Offset = "0x5F1ED10", VA = "0x185F1F910")]
	private static uint ANLDKKPKMGK(uint ANJGLCCJFPO, uint ABBMKKCGFBG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F9C0", Offset = "0x5F1EDC0", VA = "0x185F1F9C0", Slot = "4")]
	public int CompareTo(EEJCBIDCBHN BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FA50", Offset = "0x5F1EE50", VA = "0x185F1FA50", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FB60", Offset = "0x5F1EF60", VA = "0x185F1FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FAE0", Offset = "0x5F1EEE0", VA = "0x185F1FAE0", Slot = "5")]
	public bool Equals(EEJCBIDCBHN BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FB00", Offset = "0x5F1EF00", VA = "0x185F1FB00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F940", Offset = "0x5F1ED40", VA = "0x185F1F940", Slot = "6")]
	public void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F9E0", Offset = "0x5F1EDE0", VA = "0x185F1F9E0", Slot = "7")]
	public void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDB3370", Offset = "0xDB2770", VA = "0x180DB3370")]
	public static bool HOHCOENENOO(EEJCBIDCBHN LJEFIPFJBOF, EEJCBIDCBHN DAPBJAIHDIF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[PLNMLHECGFL(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[MNDFNGFCIJE(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[MNDFNGFCIJE(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[MNDFNGFCIJE(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[MNDFNGFCIJE(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[PLNMLHECGFL(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, JEHFEHAOHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[MNDFNGFCIJE(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
		public static SerializableGuid IGKGMCHPHKB(Guid KIDLKIGCBDG)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F20A20", Offset = "0x5F1FE20", VA = "0x185F20A20", Slot = "4")]
		public bool Equals(SerializableGuid BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F20980", Offset = "0x5F1FD80", VA = "0x185F20980", Slot = "5")]
		public int CompareTo(SerializableGuid BKBGGIICJOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F20880", Offset = "0x5F1FC80", VA = "0x185F20880", Slot = "6")]
		public void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F209A0", Offset = "0x5F1FDA0", VA = "0x185F209A0", Slot = "7")]
		public void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F20AB0", Offset = "0x5F1FEB0", VA = "0x185F20AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DNDHFINHMIH(1)]
	[NJNFGCHAOCE("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[DNDHFINHMIH(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[GDPJNMPNCJB(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[GDPJNMPNCJB(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[PPMCLPGJKOH(0, 4)]
public enum NNNACFBOHIB
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[DNDHFINHMIH(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[GDPJNMPNCJB(1)]
		public NNNACFBOHIB gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[DNDHFINHMIH(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[GDPJNMPNCJB(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[GDPJNMPNCJB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[GDPJNMPNCJB(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[DNDHFINHMIH(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[GDPJNMPNCJB(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[GDPJNMPNCJB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[GDPJNMPNCJB(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[GDPJNMPNCJB(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[GDPJNMPNCJB(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[DNDHFINHMIH(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[GDPJNMPNCJB(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[GDPJNMPNCJB(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[GDPJNMPNCJB(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[InternalBufferCapacity(8)]
	[DNDHFINHMIH(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, DCIIGNCABLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A89870", Offset = "0x3A88C70", VA = "0x183A89870", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[DNDHFINHMIH(1)]
	public struct ParentData : IComponentData, DCIIGNCABLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[GDPJNMPNCJB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LGMDCDJDGBF : ISystemStateComponentData, IComponentData, DCIIGNCABLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity OANAMMJAMEI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity HKIDIDENHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0")]
	public LGMDCDJDGBF(Entity BLENCGKHIJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static LGMDCDJDGBF IGKGMCHPHKB(Entity KCGBIDJFHLF)
	{
		return default(LGMDCDJDGBF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct BHBCICILJNI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DCIIGNCABLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity BADKAKDHHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[DNDHFINHMIH(1)]
	[MJJLCIOLOIA("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[DNDHFINHMIH(1)]
	[MJJLCIOLOIA("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[DNDHFINHMIH(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F20710", Offset = "0x5F1FB10", VA = "0x185F20710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[PPMCLPGJKOH(0, 4)]
public enum EIFMHALKOMK
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LGAIJMKKHPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ENDKPCGCDAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CFFPFDDOHIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OJCIMFCGNJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CIFDNFDBHAC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[DNDHFINHMIH(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[GDPJNMPNCJB(1)]
		public LAKAEOIEFNN flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[GDPJNMPNCJB(2)]
		public BCFLOIPLCIJ scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LJCHGEBOOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F20340", Offset = "0x5F1F740", VA = "0x185F20340")]
	public static LAKAEOIEFNN EIPAABBBFMM(this LAKAEOIEFNN GHPHIAMLFNM, OPPABAMFOJE CCENAAIKJJK)
	{
		return default(LAKAEOIEFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F20370", Offset = "0x5F1F770", VA = "0x185F20370")]
	public static LAKAEOIEFNN GMLJNDAKNDK(this LAKAEOIEFNN GHPHIAMLFNM, OPPABAMFOJE CCENAAIKJJK)
	{
		return default(LAKAEOIEFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F20380", Offset = "0x5F1F780", VA = "0x185F20380")]
	public static LAKAEOIEFNN PAGAFEIMKDK(this LAKAEOIEFNN GHPHIAMLFNM, OPPABAMFOJE CCENAAIKJJK, bool EFFGBEOGIKM)
	{
		return default(LAKAEOIEFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F20350", Offset = "0x5F1F750", VA = "0x185F20350")]
	public static bool FJBPNNFHJLM(this LAKAEOIEFNN GHPHIAMLFNM, OPPABAMFOJE CCENAAIKJJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum OPPABAMFOJE
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
[PPMCLPGJKOH(0, 16383)]
public enum LAKAEOIEFNN
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PLNMLHECGFL(1)]
public struct BCFLOIPLCIJ : JEHFEHAOHED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[MNDFNGFCIJE(1)]
	public bool DILCHIHLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[MNDFNGFCIJE(2)]
	public float3 IPIDKIDDDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[MNDFNGFCIJE(3)]
	public float3 AOIDPMKKMHO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F3A0", Offset = "0x5F1E7A0", VA = "0x185F1F3A0", Slot = "5")]
	public void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F280", Offset = "0x5F1E680", VA = "0x185F1F280", Slot = "4")]
	public void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[PLNMLHECGFL(1)]
public struct GPMMCAIIICI : JEHFEHAOHED, IEquatable<GPMMCAIIICI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[MNDFNGFCIJE(1)]
	public int FBDAFGPAOAL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90")]
	public GPMMCAIIICI(int FBDAFGPAOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FF10", Offset = "0x5F1F310", VA = "0x185F1FF10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FE90", Offset = "0x5F1F290", VA = "0x185F1FE90", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84E6A0", Offset = "0x84DAA0", VA = "0x18084E6A0", Slot = "6")]
	public bool Equals(GPMMCAIIICI BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21187F0", Offset = "0x2117BF0", VA = "0x1821187F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FE60", Offset = "0x5F1F260", VA = "0x185F1FE60", Slot = "5")]
	public void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FE30", Offset = "0x5F1F230", VA = "0x185F1FE30", Slot = "4")]
	public void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DNDHFINHMIH(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[GDPJNMPNCJB(1)]
		public GPMMCAIIICI customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[PPMCLPGJKOH(0, 1)]
public enum KKJCLKEEIOC
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[DNDHFINHMIH(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[GDPJNMPNCJB(1)]
		public KKJCLKEEIOC propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct MNOEIHIDHIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct IHOLFKHEKLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct HIGNICEKPAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct LOHCJKPEBBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public FixedString32 JODEBEIHAPC;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[CFCMFMBKBAH]
public struct BFKJLELKLEO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Entity ENNCIIPAJMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static BFKJLELKLEO IGKGMCHPHKB(Entity PKODKJLGOIN)
	{
		return default(BFKJLELKLEO);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[DNDHFINHMIH(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[GDPJNMPNCJB(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct HMOIPFDDKOA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Entity KCGBIDJFHLF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static HMOIPFDDKOA IGKGMCHPHKB(Entity KCGBIDJFHLF)
	{
		return default(HMOIPFDDKOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct OFKCOADDCGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity CGJAJAEMHBC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static OFKCOADDCGN IGKGMCHPHKB(Entity KCGBIDJFHLF)
	{
		return default(OFKCOADDCGN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct HJJBACAGIHA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[DNDHFINHMIH(1)]
	[MJJLCIOLOIA("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[DNDHFINHMIH(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[GDPJNMPNCJB(1)]
		public CDPNPEPOMEC shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[PPMCLPGJKOH(-1, 18)]
public enum CDPNPEPOMEC
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	LegacyWedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	LegacyPyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	COUNT = 19,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	MAX = 18,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	MIN = -1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[DNDHFINHMIH(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[Flags]
		[PPMCLPGJKOH(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[GDPJNMPNCJB(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5F20B00", Offset = "0x5F1FF00", VA = "0x185F20B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5F20B80", Offset = "0x5F1FF80", VA = "0x185F20B80")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[PPMCLPGJKOH(0, 2)]
public enum AGHINPILCNI
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
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[DNDHFINHMIH(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[GDPJNMPNCJB(1)]
		public AGHINPILCNI shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[DNDHFINHMIH(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[GDPJNMPNCJB(1)]
		public EEJCBIDCBHN order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[DNDHFINHMIH(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[GDPJNMPNCJB(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[DNDHFINHMIH(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[GDPJNMPNCJB(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1EC5AE0", Offset = "0x1EC4EE0", VA = "0x181EC5AE0")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[DNDHFINHMIH(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[GDPJNMPNCJB(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[DNDHFINHMIH(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[GDPJNMPNCJB(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC5AE0", Offset = "0x1EC4EE0", VA = "0x181EC5AE0")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[PLNMLHECGFL(1)]
public struct DNOIBALCHPH : JEHFEHAOHED
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	[PPMCLPGJKOH(0, 7)]
	public enum PGBAMCIICJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[MNDFNGFCIJE(1)]
	public float JFHNAJBKBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[MNDFNGFCIJE(2)]
	public int HPJIBOACKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[MNDFNGFCIJE(3)]
	public PGBAMCIICJI GHPHIAMLFNM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MDAKKHPOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F890", Offset = "0x5F1EC90", VA = "0x185F1F890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F730", Offset = "0x5F1EB30", VA = "0x185F1F730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NDILPGEMNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F770", Offset = "0x5F1EB70", VA = "0x185F1F770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F750", Offset = "0x5F1EB50", VA = "0x185F1F750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LGDIAJKHGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F7F0", Offset = "0x5F1EBF0", VA = "0x185F1F7F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F870", Offset = "0x5F1EC70", VA = "0x185F1F870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F6D0", Offset = "0x5F1EAD0", VA = "0x185F1F6D0", Slot = "5")]
	public void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F670", Offset = "0x5F1EA70", VA = "0x185F1F670", Slot = "4")]
	public void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[DNDHFINHMIH(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[GDPJNMPNCJB(1)]
		public DNOIBALCHPH parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DDCJCPFCBAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct PKDIMGBLMKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LGONAFLKCAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct NHICHEOPGJJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct HIIDPANLLLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal struct DCKMMKIAAFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct BBJJGAEKHEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct KAGEFLLDAMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct GAEIJNIAHGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct LHPFHGFGCAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct ENBGDKAGBPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal struct IHKHLLADNIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LJJKNKIMAGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal struct NDNBEALLFBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct KCKNGDKFFAO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DNDHFINHMIH(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[GDPJNMPNCJB(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[GDPJNMPNCJB(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[GDPJNMPNCJB(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[DNDHFINHMIH(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[GDPJNMPNCJB(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[GDPJNMPNCJB(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[GDPJNMPNCJB(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[GDPJNMPNCJB(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[GDPJNMPNCJB(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[GDPJNMPNCJB(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[GDPJNMPNCJB(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[GDPJNMPNCJB(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[GDPJNMPNCJB(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[GDPJNMPNCJB(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[GDPJNMPNCJB(11)]
		public DCIOEBPJHNM mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[GDPJNMPNCJB(12)]
		public NMONCGCKIIA myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[GDPJNMPNCJB(13)]
		public FJNMFGGGBHP myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[GDPJNMPNCJB(14)]
		public JILICHNPGJG myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[GDPJNMPNCJB(15)]
		public PFFLDLOMLLN myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[GDPJNMPNCJB(16)]
		public DFKLGLNBIHJ myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[GDPJNMPNCJB(17)]
		public BLHLOOFLMFP myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[GDPJNMPNCJB(18)]
		public HAOEFLHIACM myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[GDPJNMPNCJB(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[GDPJNMPNCJB(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[GDPJNMPNCJB(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[GDPJNMPNCJB(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public enum DCIOEBPJHNM : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum NMONCGCKIIA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum FJNMFGGGBHP : short
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum JILICHNPGJG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum PFFLDLOMLLN
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum DFKLGLNBIHJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum BLHLOOFLMFP : long
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum HAOEFLHIACM : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[DNDHFINHMIH(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[DNDHFINHMIH(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[DNDHFINHMIH(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class EJPFPFLLPPI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct CGKHJPOAJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 AEHLMIEGAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<SerializableGuid> OBOPBONOPLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class FIHFELBLGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FIHFELBLGKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public EJPFPFLLPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[CFCMFMBKBAH]
public struct FKOKEBGMIKN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public TimeData GLMKPPDOKMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
	public static FKOKEBGMIKN IGKGMCHPHKB(TimeData PKODKJLGOIN)
	{
		return default(FKOKEBGMIKN);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[DNDHFINHMIH(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[GDPJNMPNCJB(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[DNDHFINHMIH(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[GDPJNMPNCJB(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[GDPJNMPNCJB(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC5800", Offset = "0x1EC4C00", VA = "0x181EC5800")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F240", Offset = "0x5F1E640", VA = "0x185F1F240")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F240", Offset = "0x5F1E640", VA = "0x185F1F240")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[DNDHFINHMIH(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[DNDHFINHMIH(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5F20530", Offset = "0x5F1F930", VA = "0x185F20530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[DNDHFINHMIH(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[GDPJNMPNCJB(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EGEDBOODONB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int PFPNGBDKFNI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PGFOAHEHPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F1FCA0", Offset = "0x5F1F0A0", VA = "0x185F1FCA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F1FC90", Offset = "0x5F1F090", VA = "0x185F1FC90")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[DNDHFINHMIH(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[GDPJNMPNCJB(1)]
		public DNJBHCKIBII transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[GDPJNMPNCJB(2)]
		public PJDPKCILJKJ transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[Flags]
[PPMCLPGJKOH(0, 1)]
public enum DNJBHCKIBII
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[PPMCLPGJKOH(-2, 2)]
public enum PJDPKCILJKJ
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[DNDHFINHMIH(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[DNDHFINHMIH(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5F20DC0", Offset = "0x5F201C0", VA = "0x185F20DC0")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[DNDHFINHMIH(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[PPMCLPGJKOH(1000, 8001)]
public enum FFIHEMJDJJI
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Player = 8000,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Unused = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	COUNT = 8002,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	MAX = 8001
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal enum NGLODICEFNA
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal static class IPJOKCNKCPI
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[DNDHFINHMIH(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[GDPJNMPNCJB(1)]
		public FFIHEMJDJJI prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class FCNGMNGKOIO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FD50", Offset = "0x5F1F150", VA = "0x185F1FD50")]
	public static bool LOONONNGKKJ(this FFIHEMJDJJI NLAFPPIOFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FCD0", Offset = "0x5F1F0D0", VA = "0x185F1FCD0")]
	public static string LLEHCHBNIDH(this FFIHEMJDJJI NLAFPPIOFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FCB0", Offset = "0x5F1F0B0", VA = "0x185F1FCB0")]
	public static DEGKDCDCKLH IBJMLEAPICC(this FFIHEMJDJJI CNEFMCCDIIL)
	{
		return default(DEGKDCDCKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FD70", Offset = "0x5F1F170", VA = "0x185F1FD70")]
	internal static NGLODICEFNA NKNCJHLBOLL(this DEGKDCDCKLH CKFCEBDNJPA)
	{
		return default(NGLODICEFNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FD80", Offset = "0x5F1F180", VA = "0x185F1FD80")]
	internal static NGLODICEFNA NKNCJHLBOLL(this FFIHEMJDJJI CNEFMCCDIIL)
	{
		return default(NGLODICEFNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[PPMCLPGJKOH(0, 9)]
public enum DEGKDCDCKLH
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	MAX = 9
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[DNDHFINHMIH(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[GDPJNMPNCJB(1)]
		public DEGKDCDCKLH objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class FMGPGJCGDAA
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FDE0", Offset = "0x5F1F1E0", VA = "0x185F1FDE0")]
	public static bool AFEKCOIBBLP(this DEGKDCDCKLH CKFCEBDNJPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[PPMCLPGJKOH(-1, 60)]
public enum OHMDOGKJIBF
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	MAX = 60,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[PPMCLPGJKOH(-1, 31)]
public enum IFNEMFOLMNP
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[MJJLCIOLOIA("Visual", 0)]
	[DNDHFINHMIH(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(1)]
		public OHMDOGKJIBF color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(2)]
		public IFNEMFOLMNP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[GDPJNMPNCJB(3)]
		[AIHIFOHMDKA(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[AIHIFOHMDKA(0)]
		[GDPJNMPNCJB(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5F21110", Offset = "0x5F20510", VA = "0x185F21110", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
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
