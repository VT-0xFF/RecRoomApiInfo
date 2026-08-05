using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Mono.Math;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LGMCOLBFDJK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HGNFKFGIIDH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> IHPLCMEEOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int PGFOAHEHPOH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2D9E780", Offset = "0x2D9DB80", VA = "0x182D9E780")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E7F0", Offset = "0x2D9DBF0", VA = "0x182D9E7F0")]
		public HGNFKFGIIDH(NativeArray<Entity> IHPLCMEEOEJ, EntityManager KLFKJJDHNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E7E0", Offset = "0x2D9DBE0", VA = "0x182D9E7E0")]
		public bool LLFPOELOPGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x141BFD0", Offset = "0x141B3D0", VA = "0x18141BFD0")]
		public HGNFKFGIIDH<T> IEHFBKOKLDF()
		{
			return default(HGNFKFGIIDH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PEDHOBCHDIG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> IHPLCMEEOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int PGFOAHEHPOH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF130", Offset = "0x2BBE530", VA = "0x182BBF130")]
	public static bool CAOBGEHCFAN<T>(this NativeArray<T> PKODKJLGOIN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF1A0", Offset = "0x2BBE5A0", VA = "0x182BBF1A0")]
	public static string MEEJPADAJHH<T>(this NativeList<T> BEOMDPHLMGK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF1F0", Offset = "0x2BBE5F0", VA = "0x182BBF1F0")]
	public static string MEEJPADAJHH<T>(this NativeArray<T> CCKHAOABLMF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF160", Offset = "0x2BBE560", VA = "0x182BBF160")]
	public static HGNFKFGIIDH<T> HEECLONFODB<T>(this NativeArray<Entity> COMFNEOABDK, EntityManager KLFKJJDHNIL) where T : class
	{
		return default(HGNFKFGIIDH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CKLFCFPEGDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NIDDBICDKLH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
public struct LDOBHGCGPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly int NNKFDKAPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly uint NHLMBBLEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly bool BEONEAIAKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly bool LDFFNIPJNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly int JHAKDDAGFCD;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F42450", Offset = "0x5F41850", VA = "0x185F42450")]
	internal LDOBHGCGPJK(int IJKBMAIIDGK, bool CNDIMEFFGEE, uint DLBKDCLBJAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
[DefaultMember("Item")]
public struct EEFBLJMPCLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly Unity.Entities.EntityComponentStore* NPOEPOMLEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly int NNKFDKAPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly int JAHMCGGPBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly uint NHLMBBLEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int CEGMLMKLDAG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Entity BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F411A0", Offset = "0x5F405A0", VA = "0x185F411A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F41380", Offset = "0x5F40780", VA = "0x185F41380")]
	internal unsafe EEFBLJMPCLJ(int IJKBMAIIDGK, int OAOCNAELCIL, Unity.Entities.EntityComponentStore* KNPCJBOPMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2184CC0", Offset = "0x21840C0", VA = "0x182184CC0")]
	public bool NNJMHAAKOAN(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F41240", Offset = "0x5F40640", VA = "0x185F41240")]
	public void NOMDGCOBCEN(Entity KCGBIDJFHLF, NativeArray<byte> JLGPIDMNHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct APDBBCPJHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private CKHILNKKNDE LLKPCNGMKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<int> CGKMJOIBMPH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F3EEE0", Offset = "0x5F3E2E0", VA = "0x185F3EEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<ComponentType> NLAOHAPONPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F3EFB0", Offset = "0x5F3E3B0", VA = "0x185F3EFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F120", Offset = "0x5F3E520", VA = "0x185F3F120")]
	public int PIBKJLEHEKO(int PGFOAHEHPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EF30", Offset = "0x5F3E330", VA = "0x185F3EF30")]
	public ComponentType KPDGFBIGDCH(int PGFOAHEHPOH)
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F5E0", Offset = "0x5F3E9E0", VA = "0x185F3F5E0")]
	public APDBBCPJHNI(APDBBCPJHNI ANJGLCCJFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F510", Offset = "0x5F3E910", VA = "0x185F3F510")]
	public APDBBCPJHNI(ComponentType ANJGLCCJFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F300", Offset = "0x5F3E700", VA = "0x185F3F300")]
	public APDBBCPJHNI(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F400", Offset = "0x5F3E800", VA = "0x185F3F400")]
	public APDBBCPJHNI(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FFA0", Offset = "0x5F3F3A0", VA = "0x185F3FFA0")]
	public APDBBCPJHNI(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA, ComponentType PFEJCBNJLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F6E0", Offset = "0x5F3EAE0", VA = "0x185F3F6E0")]
	public APDBBCPJHNI(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA, ComponentType PFEJCBNJLGA, ComponentType CLHMIOKIOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F800", Offset = "0x5F3EC00", VA = "0x185F3F800")]
	public APDBBCPJHNI(params ComponentType[] CGKMJOIBMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FBF0", Offset = "0x5F3EFF0", VA = "0x185F3FBF0")]
	public APDBBCPJHNI(IEnumerable<ComponentType> CGKMJOIBMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E680", Offset = "0x5F3DA80", VA = "0x185F3E680")]
	public void EEFLLAHKIBO(ComponentType DHGPLCEACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EE80", Offset = "0x5F3E280", VA = "0x185F3EE80")]
	public void KAADNOLIHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E8D0", Offset = "0x5F3DCD0", VA = "0x185F3E8D0")]
	public static APDBBCPJHNI EIPAABBBFMM(in APDBBCPJHNI ANJGLCCJFPO, in APDBBCPJHNI ABBMKKCGFBG)
	{
		return default(APDBBCPJHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F3ED00", Offset = "0x5F3E100", VA = "0x185F3ED00")]
	public static APDBBCPJHNI EIPAABBBFMM(in APDBBCPJHNI NOBDDMHFHPJ, params ComponentType[] LMEPHHLCLDM)
	{
		return default(APDBBCPJHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F3EBE0", Offset = "0x5F3DFE0", VA = "0x185F3EBE0")]
	public static APDBBCPJHNI EIPAABBBFMM(in APDBBCPJHNI NOBDDMHFHPJ, IEnumerable<ComponentType> LMEPHHLCLDM)
	{
		return default(APDBBCPJHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F1A0", Offset = "0x5F3E5A0", VA = "0x185F3F1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HHNEPMCKDFN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3939C70", Offset = "0x3939070", VA = "0x183939C70")]
	public static APDBBCPJHNI CGAONFIAEGJ<T>(this APDBBCPJHNI NOBDDMHFHPJ)
	{
		return default(APDBBCPJHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F41960", Offset = "0x5F40D60", VA = "0x185F41960")]
	public static APDBBCPJHNI CGAONFIAEGJ(this APDBBCPJHNI ANJGLCCJFPO, APDBBCPJHNI ABBMKKCGFBG)
	{
		return default(APDBBCPJHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3ED00", Offset = "0x5F3E100", VA = "0x185F3ED00")]
	public static APDBBCPJHNI CGAONFIAEGJ(this APDBBCPJHNI ANJGLCCJFPO, params ComponentType[] LMEPHHLCLDM)
	{
		return default(APDBBCPJHNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CKHILNKKNDE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BFPCHNABIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public uint NCNOHAIKIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public uint CAGEOCFFFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public uint OLNGOICNCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public uint EMCNKPJBEJI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private FixedListInt128 HKHAJOIFDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public BFPCHNABIGD APHEKGMAHCK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IEnumerable<ComponentType> NLAOHAPONPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F40A20", Offset = "0x5F3FE20", VA = "0x185F40A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F40820", Offset = "0x5F3FC20", VA = "0x185F40820")]
	private void BNNAILCKJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F40B50", Offset = "0x5F3FF50", VA = "0x185F40B50")]
	public int PIBKJLEHEKO(int PGFOAHEHPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F409A0", Offset = "0x5F3FDA0", VA = "0x185F409A0")]
	public ComponentType KPDGFBIGDCH(int PGFOAHEHPOH)
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F41030", Offset = "0x5F40430", VA = "0x185F41030")]
	public CKHILNKKNDE(ComponentType ANJGLCCJFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F41080", Offset = "0x5F40480", VA = "0x185F41080")]
	public CKHILNKKNDE(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F40FA0", Offset = "0x5F403A0", VA = "0x185F40FA0")]
	public CKHILNKKNDE(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F40CC0", Offset = "0x5F400C0", VA = "0x185F40CC0")]
	public CKHILNKKNDE(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA, ComponentType PFEJCBNJLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F410F0", Offset = "0x5F404F0", VA = "0x185F410F0")]
	public CKHILNKKNDE(ComponentType ANJGLCCJFPO, ComponentType ABBMKKCGFBG, ComponentType CMLILENOEPA, ComponentType PFEJCBNJLGA, ComponentType CLHMIOKIOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F40D60", Offset = "0x5F40160", VA = "0x185F40D60")]
	public CKHILNKKNDE(params ComponentType[] CGKMJOIBMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F40E10", Offset = "0x5F40210", VA = "0x185F40E10")]
	public CKHILNKKNDE(IEnumerable<ComponentType> CGKMJOIBMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F40990", Offset = "0x5F3FD90", VA = "0x185F40990")]
	public void EEFLLAHKIBO(ComponentType DHGPLCEACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F40970", Offset = "0x5F3FD70", VA = "0x185F40970")]
	public void ECMOBMEKGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F40B60", Offset = "0x5F3FF60", VA = "0x185F40B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBDCEJJNNDA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F40640", Offset = "0x5F3FA40", VA = "0x185F40640")]
	public static EntityQuery NLECPBAAOKC(this EntityQueryDesc MAFGMLOJJCJ, SystemBase PEOBFOOAMDB)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F40720", Offset = "0x5F3FB20", VA = "0x185F40720")]
	public static EntityQuery NLECPBAAOKC(this EntityQueryDesc MAFGMLOJJCJ, EntityManager KLFKJJDHNIL)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F40550", Offset = "0x5F3F950", VA = "0x185F40550")]
	public static EntityQueryDesc KMCCECIPNEC(this EntityQueryDesc MAFGMLOJJCJ, params ComponentType[] ICJBAHODFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F400C0", Offset = "0x5F3F4C0", VA = "0x185F400C0")]
	public static EntityQueryDesc AKCGEACDILA(this EntityQueryDesc MAFGMLOJJCJ, params ComponentType[] ICJBAHODFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F40440", Offset = "0x5F3F840", VA = "0x185F40440")]
	public static EntityQueryDesc EGOMDEGNMFC(this EntityQueryDesc MAFGMLOJJCJ, params ComponentType[] ICJBAHODFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F40420", Offset = "0x5F3F820", VA = "0x185F40420")]
	public static EntityQueryDesc DEJIEBEEDEE(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F40530", Offset = "0x5F3F930", VA = "0x185F40530")]
	public static EntityQueryDesc FDJABGLKLBF(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F40800", Offset = "0x5F3FC00", VA = "0x185F40800")]
	public static EntityQueryDesc OOHEFEAOHBH(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5F401B0", Offset = "0x5F3F5B0", VA = "0x185F401B0")]
	public static EntityQueryDesc APNGCNFCFAB(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2E78F20", Offset = "0x2E78320", VA = "0x182E78F20")]
	public static EntityQueryDesc CGAONFIAEGJ<T>(this EntityQueryDesc MAFGMLOJJCJ, bool KBCMEGOGEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DDE0", Offset = "0x2E7D1E0", VA = "0x182E7DDE0")]
	public static EntityQueryDesc KMCCECIPNEC<T1>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DDE0", Offset = "0x2E7D1E0", VA = "0x182E7DDE0")]
	public static EntityQueryDesc KMCCECIPNEC<T1, T2>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DDE0", Offset = "0x2E7D1E0", VA = "0x182E7DDE0")]
	public static EntityQueryDesc KMCCECIPNEC<T1, T2, T3>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DDE0", Offset = "0x2E7D1E0", VA = "0x182E7DDE0")]
	public static EntityQueryDesc KMCCECIPNEC<T1, T2, T3, T4>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E78F40", Offset = "0x2E78340", VA = "0x182E78F40")]
	public static EntityQueryDesc EGOMDEGNMFC<T1, T2>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E78EF0", Offset = "0x2E782F0", VA = "0x182E78EF0")]
	public static EntityQueryDesc AKCGEACDILA<T1>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E78EF0", Offset = "0x2E782F0", VA = "0x182E78EF0")]
	public static EntityQueryDesc AKCGEACDILA<T1, T2>(this EntityQueryDesc MAFGMLOJJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E78F70", Offset = "0x2E78370", VA = "0x182E78F70")]
	private static ComponentType[] JLFJMLAGJBL<T1>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E78FF0", Offset = "0x2E783F0", VA = "0x182E78FF0")]
	private static ComponentType[] JLFJMLAGJBL<T1, T2>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E79690", Offset = "0x2E78A90", VA = "0x182E79690")]
	private static ComponentType[] JLFJMLAGJBL<T1, T2, T3>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B2E0", Offset = "0x2E7A6E0", VA = "0x182E7B2E0")]
	private static ComponentType[] JLFJMLAGJBL<T1, T2, T3, T4>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F40350", Offset = "0x5F3F750", VA = "0x185F40350")]
	private static ComponentType[] BCAHKFOBCCB(ComponentType[] ANJGLCCJFPO, ComponentType[] ABBMKKCGFBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GBPCDNGKEPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly Entity BADKAKDHHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly EntityManager CPBCICNIGNB;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class PHBEJFCGIEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BLEKFDHJNIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BKDIOOFGNMB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BD30", Offset = "0x2A2B130", VA = "0x182A2BD30")]
	public static void DBLOPOMEFMO<T>(this DynamicBuffer<T> BPMIJGKONLK, int PGFOAHEHPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BE90", Offset = "0x2A2B290", VA = "0x182A2BE90")]
	public static int LPHHEGFFIAL<T>(this DynamicBuffer<T> BPMIJGKONLK, T PKODKJLGOIN) where T : struct, IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BDB0", Offset = "0x2A2B1B0", VA = "0x182A2BDB0")]
	public static bool FLPJJBKECMH<T>(this DynamicBuffer<T> BPMIJGKONLK, T PKODKJLGOIN) where T : struct, IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C040", Offset = "0x2A2B440", VA = "0x182A2C040")]
	public static int LPHHEGFFIAL<T>(this DynamicBuffer<T> BPMIJGKONLK, T PKODKJLGOIN, IEqualityComparer<T> DECMEAHCICP) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BE20", Offset = "0x2A2B220", VA = "0x182A2BE20")]
	public static bool FLPJJBKECMH<T>(this DynamicBuffer<T> BPMIJGKONLK, T PKODKJLGOIN, IEqualityComparer<T> DECMEAHCICP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PLCKNPIHMAM
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F42B50", Offset = "0x5F41F50", VA = "0x185F42B50")]
	public static EntityArchetype GAGKPJPCDAM(this EntityManager KLFKJJDHNIL, Span<ComponentType> LLKPCNGMKKA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F42BD0", Offset = "0x5F41FD0", VA = "0x185F42BD0")]
	public static EntityArchetype HIMLDABCCHB(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27F9E80", Offset = "0x27F9280", VA = "0x1827F9E80")]
	public static bool AKMCDAIJJHN<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, out DynamicBuffer<T> BPMIJGKONLK) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27FB450", Offset = "0x27FA850", VA = "0x1827FB450")]
	public static bool MNLBFOAGJDP<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, out DynamicBuffer<T> BPMIJGKONLK) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27FAC00", Offset = "0x27FA000", VA = "0x1827FAC00")]
	public static DynamicBuffer<T> CKKBIENPJKO<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27FB0B0", Offset = "0x27FA4B0", VA = "0x1827FB0B0")]
	public static DynamicBuffer<T> FCNAHHBHILK<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27F9F00", Offset = "0x27F9300", VA = "0x1827F9F00")]
	public static bool BNJMDOAAABE<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, out T NELFDLPEFHO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F42A90", Offset = "0x5F41E90", VA = "0x185F42A90")]
	public static EEFBLJMPCLJ EMOFNGGEBFH(this EntityManager KLFKJJDHNIL, int IJKBMAIIDGK, bool CNDIMEFFGEE = false)
	{
		return default(EEFBLJMPCLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27FB380", Offset = "0x27FA780", VA = "0x1827FB380")]
	public static void IIIGOPGJDHI<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, T CGICDJFIDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27FB3D0", Offset = "0x27FA7D0", VA = "0x1827FB3D0")]
	public static bool IJNJMNBIPOJ<T>(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, out T NDJEINDKPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27FAD20", Offset = "0x27FA120", VA = "0x1827FAD20")]
	public static void DABMJKGCJCF<T>(this EntityManager KLFKJJDHNIL, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<T> HANEMGLFJMM) where T : struct, IComponentData
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HLOJEKEEGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F41B00", Offset = "0x5F40F00", VA = "0x185F41B00")]
	public static bool CAOBGEHCFAN(this EntityQuery HLMFLLBMKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F41B40", Offset = "0x5F40F40", VA = "0x185F41B40")]
	public static bool CAOBGEHCFAN(this EntityQuery HLMFLLBMKOG, out int EFJDLDLIAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21E6600", Offset = "0x21E5A00", VA = "0x1821E6600")]
	public static EntityQuery LFCOGCGDENA<T>(this EntityQuery HLMFLLBMKOG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21E6590", Offset = "0x21E5990", VA = "0x1821E6590")]
	public static EntityQuery LFCOGCGDENA<T1, T2>(this EntityQuery HLMFLLBMKOG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F42210", Offset = "0x5F41610", VA = "0x185F42210")]
	public static EntityQuery LFCOGCGDENA(this EntityQuery HLMFLLBMKOG, ComponentType DHGPLCEACKF)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5F42250", Offset = "0x5F41650", VA = "0x185F42250")]
	public static NativeArray<Entity> POLADNMNPFE(this EntityQuery HLMFLLBMKOG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x21E6230", Offset = "0x21E5630", VA = "0x1821E6230")]
	public static NativeArray<T> KLCMMPJGKAC<T>(this EntityQuery HLMFLLBMKOG) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21E5E00", Offset = "0x21E5200", VA = "0x1821E5E00")]
	public static NativeArray<T> EEGENMNKNLN<T>(this EntityQuery HLMFLLBMKOG, Allocator NHNCCHNPCJI) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F41E50", Offset = "0x5F41250", VA = "0x185F41E50")]
	public static NativeArray<byte> EEGENMNKNLN(this EntityQuery HLMFLLBMKOG, Allocator NHNCCHNPCJI, int IJKBMAIIDGK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F41CE0", Offset = "0x5F410E0", VA = "0x185F41CE0")]
	public static NativeArray<Entity> DFKBFCMFJKC(this EntityQuery HLMFLLBMKOG, Allocator NHNCCHNPCJI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F42060", Offset = "0x5F41460", VA = "0x185F42060")]
	private static NativeArray<byte> LDFPKFDMDOL(Unity.Entities.UnsafeMatchingArchetypePtrList IEHJGIAPBMM, Allocator NHNCCHNPCJI, LDOBHGCGPJK NLAFPPIOFPG, EntityQuery HLMFLLBMKOG, ref Unity.Entities.EntityQueryFilter BIGIMFNMPLJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x21E6430", Offset = "0x21E5830", VA = "0x1821E6430")]
	private static NativeArray<T> LDFPKFDMDOL<T>(Unity.Entities.UnsafeMatchingArchetypePtrList IEHJGIAPBMM, Allocator NHNCCHNPCJI, ArchetypeChunkComponentType<T> NLAFPPIOFPG, EntityQuery HLMFLLBMKOG, ref Unity.Entities.EntityQueryFilter BIGIMFNMPLJ) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F41B90", Offset = "0x5F40F90", VA = "0x185F41B90")]
	private static NativeArray<Entity> CKOCNIIOFDD(Unity.Entities.UnsafeMatchingArchetypePtrList IEHJGIAPBMM, Allocator NHNCCHNPCJI, ArchetypeChunkEntityType NLAFPPIOFPG, EntityQuery HLMFLLBMKOG, ref Unity.Entities.EntityQueryFilter BIGIMFNMPLJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F419F0", Offset = "0x5F40DF0", VA = "0x185F419F0")]
	public static global::LJNKEFMLNCC<Entity> APKHIFEIGAJ(this EntityQuery KFGMFPAGHMA, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(global::LJNKEFMLNCC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x21E5EF0", Offset = "0x21E52F0", VA = "0x1821E5EF0")]
	public static global::LJNKEFMLNCC<T> GNKBIPDJJPL<T>(this EntityQuery KFGMFPAGHMA, Allocator NHNCCHNPCJI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(global::LJNKEFMLNCC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LPACCGKNOFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GOACPJDKIAN
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ECPNJKKOEIP
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x202B3D0", Offset = "0x202A7D0", VA = "0x18202B3D0")]
	public static Memory<T> PDDGKECMJLF<T>(int EFJDLDLIAEL)
	{
		return default(Memory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x202B210", Offset = "0x202A610", VA = "0x18202B210")]
	public static void IFPCGKMHHBP<T>(this Memory<T> HNJOBBBCILH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LJNKEFMLNCC<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NativeArray<T> CCKHAOABLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JobHandle IICPGPKAIEH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x23E1750", Offset = "0x23E0B50", VA = "0x1823E1750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23E1C60", Offset = "0x23E1060", VA = "0x1823E1C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JobHandle BNHKHJGIJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeArray<T> KIJBGIPPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
		get
		{
			return default(NativeArray<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5750", Offset = "0x1EC4B50", VA = "0x181EC5750")]
	public LJNKEFMLNCC(NativeArray<T> CCKHAOABLMF, JobHandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23E1710", Offset = "0x23E0B10", VA = "0x1823E1710")]
	public NativeArray<T> DACLICHPPJK()
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x23E1790", Offset = "0x23E0B90", VA = "0x1823E1790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x23E1160", Offset = "0x23E0560", VA = "0x1823E1160")]
	public JobHandle ANGPDPCFPPL(JobHandle KNAKGAMMCOC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EJJIDHDCHDJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5F413A0", Offset = "0x5F407A0", VA = "0x185F413A0")]
	public static JobHandle LCKFFMIFGHI(this JobHandle ANJGLCCJFPO, JobHandle ABBMKKCGFBG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2034570", Offset = "0x2033970", VA = "0x182034570")]
	public static JobHandle LCKFFMIFGHI<T>(this JobHandle ANJGLCCJFPO, global::LJNKEFMLNCC<T> ABBMKKCGFBG) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2034570", Offset = "0x2033970", VA = "0x182034570")]
	public static JobHandle LCKFFMIFGHI<T>(this JobHandle ANJGLCCJFPO, global::CBNGKCNANOL<T> ABBMKKCGFBG) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20345C0", Offset = "0x20339C0", VA = "0x1820345C0")]
	public static JobHandle LCKFFMIFGHI<T>(this global::CBNGKCNANOL<T> ANJGLCCJFPO, global::CBNGKCNANOL<T> ABBMKKCGFBG) where T : struct
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CBNGKCNANOL<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly NativeList<T> BEOMDPHLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JobHandle IICPGPKAIEH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x23E1750", Offset = "0x23E0B50", VA = "0x1823E1750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle BNHKHJGIJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5750", Offset = "0x1EC4B50", VA = "0x181EC5750")]
	public CBNGKCNANOL(NativeList<T> BEOMDPHLMGK, JobHandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x30DC580", Offset = "0x30DB980", VA = "0x1830DC580")]
	public global::LJNKEFMLNCC<T> POLHEFOJEHN()
	{
		return default(global::LJNKEFMLNCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x23E1710", Offset = "0x23E0B10", VA = "0x1823E1710")]
	public NativeList<T> DACLICHPPJK()
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x30DC4D0", Offset = "0x30DB8D0", VA = "0x1830DC4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30DC400", Offset = "0x30DB800", VA = "0x1830DC400")]
	public JobHandle ANGPDPCFPPL(JobHandle KNAKGAMMCOC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ALNHCHGJBIC<T> : IDisposable where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NativeArray<T> CCKHAOABLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JobHandle IICPGPKAIEH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HPFMJOAOGMI
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x21E8BB0", Offset = "0x21E7FB0", VA = "0x1821E8BB0")]
	public static Span<T> ELAGJCJFLKC<T>(this NativeArray<T> CCKHAOABLMF) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x21E8A50", Offset = "0x21E7E50", VA = "0x1821E8A50")]
	public static Span<T> ELAGJCJFLKC<T>(this NativeList<T> BEOMDPHLMGK) where T : struct
	{
		return default(Span<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class MFABPHPMMGC
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B610", Offset = "0x2E5AA10", VA = "0x182E5B610")]
	public static bool KPLPCHPLAID<T>(T ANJGLCCJFPO, T ABBMKKCGFBG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OFIPJEGNJEO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct GOJHHJGALPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static bool CDGGLOGNJFF;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F41910", Offset = "0x5F40D10", VA = "0x185F41910")]
		public GOJHHJGALPE(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5F418C0", Offset = "0x5F40CC0", VA = "0x185F418C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F42520", Offset = "0x5F41920", VA = "0x185F42520")]
	public static global::LJNKEFMLNCC<Entity> APKHIFEIGAJ(this EntityQuery KFGMFPAGHMA, SceneTag ENNCIIPAJMI, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(global::LJNKEFMLNCC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F42940", Offset = "0x5F41D40", VA = "0x185F42940")]
	public static NativeArray<Entity> POLADNMNPFE(this EntityQuery KFGMFPAGHMA, SceneTag ENNCIIPAJMI, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F42880", Offset = "0x5F41C80", VA = "0x185F42880")]
	public static GOJHHJGALPE PEOBDOADIAL(this EntityQuery KFGMFPAGHMA, SceneTag ENNCIIPAJMI)
	{
		return default(GOJHHJGALPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5F42750", Offset = "0x5F41B50", VA = "0x185F42750")]
	public static int IAEFHKIOPGO(this EntityQuery KFGMFPAGHMA, SceneTag ENNCIIPAJMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FHFADFCKOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5F415B0", Offset = "0x5F409B0", VA = "0x185F415B0")]
	public static bool LINBKOLNMPN(this in EntityManager KLFKJJDHNIL, Entity NMHBGKPCHAM, out NativeArray<Entity> PGMCOJAFBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F416B0", Offset = "0x5F40AB0", VA = "0x185F416B0")]
	public static bool NELBGKAKCMO(this in BufferFromEntity<LinkedEntityGroup> PIFFEACDJFF, Entity NMHBGKPCHAM, out NativeArray<Entity> PGMCOJAFBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F41790", Offset = "0x5F40B90", VA = "0x185F41790")]
	public static bool NELBGKAKCMO(this in DynamicBuffer<LinkedEntityGroup> BPMIJGKONLK, out NativeArray<Entity> PGMCOJAFBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5F414C0", Offset = "0x5F408C0", VA = "0x185F414C0")]
	public static NativeArray<Entity> EDPHMOOGCDG(this EntityManager KLFKJJDHNIL, Entity NMHBGKPCHAM)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F413E0", Offset = "0x5F407E0", VA = "0x185F413E0")]
	public static NativeArray<Entity> EDPHMOOGCDG(this BufferFromEntity<LinkedEntityGroup> PIFFEACDJFF, Entity NMHBGKPCHAM)
	{
		return default(NativeArray<Entity>);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
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
