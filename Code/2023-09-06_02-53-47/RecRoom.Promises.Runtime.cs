using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F77C90", Offset = "0x6F76290", VA = "0x186F77C90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FLDEFIBHLGM : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string INHDNCBDLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F74FD0", Offset = "0x6F735D0", VA = "0x186F74FD0")]
	public FLDEFIBHLGM(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA370", Offset = "0x6E9770")]
public class MHPELDJGIDB<T1, T2> : FIKNOBAKBJH<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BDJIKCFNOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA3E0", Offset = "0x6E97E0")]
		public MFBKDKPGMNP<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public MHPELDJGIDB<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public BDJIKCFNOOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2512080", Offset = "0x2510680", VA = "0x182512080")]
		internal void JBOBNDEBFPJ(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CIPALHMIADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public BDJIKCFNOOI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public CIPALHMIADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x29C5B30", Offset = "0x29C4130", VA = "0x1829C5B30")]
		internal void NIFFGBFKJBC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D0D0", Offset = "0x2B4B6D0", VA = "0x182B4D0D0")]
	public MHPELDJGIDB(MFBKDKPGMNP<T1> PLLLDOMMCFE, MFBKDKPGMNP<T2> HHHJAMFNIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C390", Offset = "0x2B4A990", VA = "0x182B4C390")]
	private void AGNJJFIFLPO(string PMBGBHCKNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA460", Offset = "0x6E9860")]
public class NOMAIIDBBJH<T1, T2, T3> : FIKNOBAKBJH<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DNAFIFKNOFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA4D0", Offset = "0x6E98D0")]
		public MFBKDKPGMNP<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA530", Offset = "0x6E9930")]
		public MFBKDKPGMNP<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public NOMAIIDBBJH<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public DNAFIFKNOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2274730", Offset = "0x2272D30", VA = "0x182274730")]
		internal void JBOBNDEBFPJ(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HNBJIANPJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public DNAFIFKNOFB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HNBJIANPJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22B6770", Offset = "0x22B4D70", VA = "0x1822B6770")]
		internal void NIFFGBFKJBC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PGLHLGGCHPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HNBJIANPJIG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public PGLHLGGCHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E60", Offset = "0x1F12460", VA = "0x181F13E60")]
		internal void OCCJNDEMBPJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x272A2B0", Offset = "0x27288B0", VA = "0x18272A2B0")]
	public NOMAIIDBBJH(MFBKDKPGMNP<T1> PLLLDOMMCFE, MFBKDKPGMNP<T2> HHHJAMFNIKA, MFBKDKPGMNP<T3> EIMJEKKOFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x272A240", Offset = "0x2728840", VA = "0x18272A240")]
	private void AGNJJFIFLPO(string PMBGBHCKNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA590", Offset = "0x6E9990")]
public class NFALMDJAKLJ<T1, T2, T3, T4, T5> : FIKNOBAKBJH<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LEGNIMJOBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA600", Offset = "0x6E9A00")]
		public MFBKDKPGMNP<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA660", Offset = "0x6E9A60")]
		public MFBKDKPGMNP<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA6C0", Offset = "0x6E9AC0")]
		public MFBKDKPGMNP<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA720", Offset = "0x6E9B20")]
		public MFBKDKPGMNP<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NFALMDJAKLJ<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public LEGNIMJOBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2512440", Offset = "0x2510A40", VA = "0x182512440")]
		internal void JBOBNDEBFPJ(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PLCEKHJMFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LEGNIMJOBFP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public PLCEKHJMFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x22B6770", Offset = "0x22B4D70", VA = "0x1822B6770")]
		internal void NIFFGBFKJBC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MPKLNFLOHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PLCEKHJMFGO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MPKLNFLOHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24159D0", Offset = "0x2413FD0", VA = "0x1824159D0")]
		internal void OCCJNDEMBPJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EFMCCDCOPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MPKLNFLOHPJ CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public EFMCCDCOPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x23E2790", Offset = "0x23E0D90", VA = "0x1823E2790")]
		internal void BEGMCDLAACK(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NBCIICNMKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EFMCCDCOPEB CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public NBCIICNMKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x277CDF0", Offset = "0x277B3F0", VA = "0x18277CDF0")]
		internal void LOEDOOGBCFH(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2786780", Offset = "0x2784D80", VA = "0x182786780")]
	public NFALMDJAKLJ(MFBKDKPGMNP<T1> PLLLDOMMCFE, MFBKDKPGMNP<T2> HHHJAMFNIKA, MFBKDKPGMNP<T3> EIMJEKKOFLM, MFBKDKPGMNP<T4> DMIDEAMHGNA, MFBKDKPGMNP<T5> JCDFDHFGKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2786710", Offset = "0x2784D10", VA = "0x182786710")]
	private void AGNJJFIFLPO(string PMBGBHCKNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA780", Offset = "0x6E9B80")]
public class DHHKNFMGDCF<T> : FIKNOBAKBJH<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BJLAMLBHEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public DHHKNFMGDCF<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public BJLAMLBHEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x25214E0", Offset = "0x251FAE0", VA = "0x1825214E0")]
		internal void JBOBNDEBFPJ(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA7F0", Offset = "0x6E9BF0")]
	private readonly T[] IGIKGMJFBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int BDNCONKHPOC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8680", Offset = "0x2BD6C80", VA = "0x182BD8680")]
	public DHHKNFMGDCF(List<MFBKDKPGMNP<T>> FGGAHFLBHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7690", Offset = "0x2BD5C90", VA = "0x182BD7690")]
	private void AGNJJFIFLPO(string PMBGBHCKNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ELDNLAHJBDM : NOKBHGDKGNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FBBNOFNBCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<HHGLIBCDIDA> FGGAHFLBHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> CEFMHCBLKBO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F74FC0", Offset = "0x6F735C0", VA = "0x186F74FC0")]
	public ELDNLAHJBDM(params HHGLIBCDIDA[] FGGAHFLBHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F74BC0", Offset = "0x6F731C0", VA = "0x186F74BC0")]
	public ELDNLAHJBDM(IReadOnlyList<HHGLIBCDIDA> FGGAHFLBHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F74B60", Offset = "0x6F73160", VA = "0x186F74B60")]
	private void MCJLILCMLJB(string LJFAKGAONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F74AD0", Offset = "0x6F730D0", VA = "0x186F74AD0")]
	private void ILCELBLFKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CGHJAOAINCN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string DBFJDHICGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D894B0", Offset = "0x2D87AB0", VA = "0x182D894B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F74970", Offset = "0x6F72F70", VA = "0x186F74970")]
	public CGHJAOAINCN(Exception BEBCIHGCPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F748E0", Offset = "0x6F72EE0", VA = "0x186F748E0")]
	private static string HKKOJKLIIID(Exception BEBCIHGCPBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NOKBHGDKGNF : HHGLIBCDIDA, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GHAIHMDLOBI<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA970", Offset = "0x6E9D70")]
		public Func<string, MFBKDKPGMNP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA9D0", Offset = "0x6E9DD0")]
		public Func<MFBKDKPGMNP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAA30", Offset = "0x6E9E30")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAA90", Offset = "0x6E9E90")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GHAIHMDLOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24E2740", Offset = "0x24E0D40", VA = "0x1824E2740")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void PKMLHJEFHEK(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24E18D0", Offset = "0x24DFED0", VA = "0x1824E18D0")]
		internal void EGIOLPLNJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void LNPFCABNCHM(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BHBPHFMDNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAAF0", Offset = "0x6E9EF0")]
		public Func<string, HHGLIBCDIDA> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NOKBHGDKGNF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAB50", Offset = "0x6E9F50")]
		public Func<HHGLIBCDIDA> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EABB0", Offset = "0x6E9FB0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAC10", Offset = "0x6EA010")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BHBPHFMDNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F74750", Offset = "0x6F72D50", VA = "0x186F74750")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void PKMLHJEFHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F745E0", Offset = "0x6F72BE0", VA = "0x186F745E0")]
		internal void EGIOLPLNJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void LNPFCABNCHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KEJOEKKECGD<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public KEJOEKKECGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2180760", Offset = "0x217ED60", VA = "0x182180760")]
		internal void CMEJJIKHIOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26536A0", Offset = "0x2651CA0", VA = "0x1826536A0")]
		internal void CIFBCCAMJOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OBOLCEONCJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NOKBHGDKGNF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAC70", Offset = "0x6EA070")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OBOLCEONCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F77D20", Offset = "0x6F76320", VA = "0x186F77D20")]
		internal void NDKIAAGHIBB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD4D320", Offset = "0xD4B920", VA = "0x180D4D320")]
		internal void LFNICBMMADC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string HFPIBLKGEGN = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> FBPBAOFBBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> GFBBCFAIEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> MEJABLEGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? PMBGBHCKNKB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HHGLIBCDIDA NNAJGAGPMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F76F90", Offset = "0x6F75590", VA = "0x186F76F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA2E160", Offset = "0xA2C760", VA = "0x180A2E160", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA2DCC0", Offset = "0xA2C2C0", VA = "0x180A2DCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GKIKHLAEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F774C0", Offset = "0x6F75AC0", VA = "0x186F774C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NNKFHLECBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F77B00", Offset = "0x6F76100", VA = "0x186F77B00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F77B20", Offset = "0x6F76120", VA = "0x186F77B20")]
	static NOKBHGDKGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x234BF70", Offset = "0x234A570", VA = "0x18234BF70")]
	public static MFBKDKPGMNP<T> BGFCCOEKHOE<T>(T NKONLKNLFIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F77080", Offset = "0x6F75680", VA = "0x186F77080")]
	public static HHGLIBCDIDA EGMGFIBBBOM(string PMBGBHCKNKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x234BF70", Offset = "0x234A570", VA = "0x18234BF70")]
	public static MFBKDKPGMNP<T> EGMGFIBBBOM<T>(string PMBGBHCKNKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F774E0", Offset = "0x6F75AE0", VA = "0x186F774E0", Slot = "8")]
	public HHGLIBCDIDA NEPFPOCMJPJ(Action<string> OFNOOEELLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F77A80", Offset = "0x6F76080", VA = "0x186F77A80", Slot = "17")]
	public virtual HHGLIBCDIDA NPPFOIGFBJO(Action PFKFDGEPEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F76FF0", Offset = "0x6F755F0", VA = "0x186F76FF0", Slot = "7")]
	public HHGLIBCDIDA EDCBGHFJIBA(Action GIAFPCDPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFB60", Offset = "0x2FBE160", VA = "0x182FBFB60", Slot = "10")]
	public MFBKDKPGMNP<TNew> NLCGDFFABOD<TNew>(Func<MFBKDKPGMNP<TNew>> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA8B0", Offset = "0x6E9CB0")] Func<string, MFBKDKPGMNP<TNew>> LIPMKKBKLNM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F77860", Offset = "0x6F75E60", VA = "0x186F77860", Slot = "11")]
	public HHGLIBCDIDA NLCGDFFABOD(Func<HHGLIBCDIDA> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EA910", Offset = "0x6E9D10")] Func<string, HHGLIBCDIDA> LIPMKKBKLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2FBEC00", Offset = "0x2FBD200", VA = "0x182FBEC00", Slot = "12")]
	public MFBKDKPGMNP<TNew> GLAMIBJJBEO<TNew>(Func<TNew> PLLKLEBGMPF) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F77230", Offset = "0x6F75830", VA = "0x186F77230", Slot = "13")]
	public HHGLIBCDIDA GHGCCOJIDCP(Func<string, string> PLLKLEBGMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E86CF0", Offset = "0x5E852F0", VA = "0x185E86CF0", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F76D40", Offset = "0x6F75340", VA = "0x186F76D40")]
	public void BEJNCICKNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F77580", Offset = "0x6F75B80", VA = "0x186F77580")]
	public void NEPFPOCMJPJ(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F770F0", Offset = "0x6F756F0", VA = "0x186F770F0")]
	protected Exception? GAICMBPAPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F77440", Offset = "0x6F75A40", VA = "0x186F77440", Slot = "18")]
	protected virtual void HIFOODKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F77B90", Offset = "0x6F76190", VA = "0x186F77B90")]
	public NOKBHGDKGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FIKNOBAKBJH<T> : MFBKDKPGMNP<T>, HHGLIBCDIDA, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct FBDLIPLOOPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAEB0", Offset = "0x6EA2B0")]
		public readonly Action<T> ILLCNPCAHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? AHMPNLBLDAC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAC98F0", Offset = "0xAC7EF0", VA = "0x180AC98F0")]
		public FBDLIPLOOPA(Action<T> ILLCNPCAHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAC9920", Offset = "0xAC7F20", VA = "0x180AC9920")]
		public FBDLIPLOOPA(Action AHMPNLBLDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x225D0A0", Offset = "0x225B6A0", VA = "0x18225D0A0")]
		public void JLDGENJLEHM(T GFHGIIOIPBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IOJMNKPJAKB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAF10", Offset = "0x6EA310")]
		public Func<string, MFBKDKPGMNP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAF70", Offset = "0x6EA370")]
		public Func<MFBKDKPGMNP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAFD0", Offset = "0x6EA3D0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB030", Offset = "0x6EA430")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public IOJMNKPJAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E32460", Offset = "0x3E30A60", VA = "0x183E32460")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void PKMLHJEFHEK(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B0B0", Offset = "0x3E296B0", VA = "0x183E2B0B0")]
		internal void EGIOLPLNJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void LNPFCABNCHM(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class INAMEAJPHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB090", Offset = "0x6EA490")]
		public Func<string, HHGLIBCDIDA> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NOKBHGDKGNF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB0F0", Offset = "0x6EA4F0")]
		public Func<HHGLIBCDIDA> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB150", Offset = "0x6EA550")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB1B0", Offset = "0x6EA5B0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public INAMEAJPHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3067500", Offset = "0x3065B00", VA = "0x183067500")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void PKMLHJEFHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3063AE0", Offset = "0x30620E0", VA = "0x183063AE0")]
		internal void EGIOLPLNJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void LNPFCABNCHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EMNKOPEGOMO<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB210", Offset = "0x6EA610")]
		public Func<string, MFBKDKPGMNP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB270", Offset = "0x6EA670")]
		public Func<T, MFBKDKPGMNP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB2D0", Offset = "0x6EA6D0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB330", Offset = "0x6EA730")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public EMNKOPEGOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x18D0340", Offset = "0x18CE940", VA = "0x1818D0340")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void PKMLHJEFHEK(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x18CD040", Offset = "0x18CB640", VA = "0x1818CD040")]
		internal void EGIOLPLNJOH(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x18CC790", Offset = "0x18CAD90", VA = "0x1818CC790")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFF0", Offset = "0x18CE5F0", VA = "0x1818CFFF0")]
		internal void LNPFCABNCHM(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MEHCENGILFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB390", Offset = "0x6EA790")]
		public Func<string, HHGLIBCDIDA> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NOKBHGDKGNF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB3F0", Offset = "0x6EA7F0")]
		public Func<T, HHGLIBCDIDA> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB450", Offset = "0x6EA850")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB4B0", Offset = "0x6EA8B0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MEHCENGILFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x33BB960", Offset = "0x33B9F60", VA = "0x1833BB960")]
		internal void PFIJDCFNHOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void BLEMJLEADEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void PKMLHJEFHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x33B5DF0", Offset = "0x33B43F0", VA = "0x1833B5DF0")]
		internal void EGIOLPLNJOH(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x12A6180", Offset = "0x12A4780", VA = "0x1812A6180")]
		internal void CEHPNHLOAMJ(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B150", VA = "0x180C1CB50")]
		internal void LNPFCABNCHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MDADLJHIBMF<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MDADLJHIBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2180760", Offset = "0x217ED60", VA = "0x182180760")]
		internal void CMEJJIKHIOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x26536A0", Offset = "0x2651CA0", VA = "0x1826536A0")]
		internal void CIFBCCAMJOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HEGFKMDADLF<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FIKNOBAKBJH<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB510", Offset = "0x6EA910")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HEGFKMDADLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2180760", Offset = "0x217ED60", VA = "0x182180760")]
		internal void CMEJJIKHIOG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2185C80", Offset = "0x2184280", VA = "0x182185C80")]
		internal void CIFBCCAMJOG(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MDLIECBLCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NOKBHGDKGNF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB570", Offset = "0x6EA970")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public MDLIECBLCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x33B3E80", Offset = "0x33B2480", VA = "0x1833B3E80")]
		internal void APCFMCMEAME(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD4D320", Offset = "0xD4B920", VA = "0x180D4D320")]
		internal void CLMDELBMHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KAKLDJGFFNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB5D0", Offset = "0x6EA9D0")]
		public FIKNOBAKBJH<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB630", Offset = "0x6EAA30")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public KAKLDJGFFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x253F8B0", Offset = "0x253DEB0", VA = "0x18253F8B0")]
		internal void NDKIAAGHIBB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x253E3E0", Offset = "0x253C9E0", VA = "0x18253E3E0")]
		internal void LFNICBMMADC(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EACD0", Offset = "0x6EA0D0")]
	private readonly List<FIKNOBAKBJH<T>.FBDLIPLOOPA> MEJABLEGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> FBPBAOFBBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> GFBBCFAIEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? PMBGBHCKNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T NKONLKNLFIB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97FB60", Offset = "0x97E160", VA = "0x18097FB60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDF8F90", Offset = "0xDF7590", VA = "0x180DF8F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GKIKHLAEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x31BB610", Offset = "0x31B9C10", VA = "0x1831BB610", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NNKFHLECBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31BE020", Offset = "0x31BC620", VA = "0x1831BE020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x31BA380", Offset = "0x31B8980", VA = "0x1831BA380")]
	public static MFBKDKPGMNP<T> EGMGFIBBBOM(string DPAJDIEBNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3926F30", Offset = "0x3925530", VA = "0x183926F30", Slot = "6")]
	public MFBKDKPGMNP<T> NEPFPOCMJPJ(Action<string> OFNOOEELLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x392AEF0", Offset = "0x39294F0", VA = "0x18392AEF0", Slot = "25")]
	public virtual MFBKDKPGMNP<T> NPPFOIGFBJO(Action PFKFDGEPEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31BA1C0", Offset = "0x31B87C0", VA = "0x1831BA1C0", Slot = "5")]
	public MFBKDKPGMNP<T> EDCBGHFJIBA(Action GIAFPCDPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31B9FF0", Offset = "0x31B85F0", VA = "0x1831B9FF0", Slot = "4")]
	public MFBKDKPGMNP<T> EDCBGHFJIBA(Action<T> GIAFPCDPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x247FCA0", Offset = "0x247E2A0", VA = "0x18247FCA0", Slot = "18")]
	public MFBKDKPGMNP<TNew> NLCGDFFABOD<TNew>(Func<MFBKDKPGMNP<TNew>> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAD30", Offset = "0x6EA130")] Func<string, MFBKDKPGMNP<TNew>> LIPMKKBKLNM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3929530", Offset = "0x3927B30", VA = "0x183929530", Slot = "19")]
	public HHGLIBCDIDA NLCGDFFABOD(Func<HHGLIBCDIDA> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAD90", Offset = "0x6EA190")] Func<string, HHGLIBCDIDA> LIPMKKBKLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A910", Offset = "0x2B98F10", VA = "0x182B9A910", Slot = "8")]
	public MFBKDKPGMNP<TNew> NLCGDFFABOD<TNew>(Func<T, MFBKDKPGMNP<TNew>> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EADF0", Offset = "0x6EA1F0")] Func<string, MFBKDKPGMNP<TNew>> LIPMKKBKLNM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3928C10", Offset = "0x3927210", VA = "0x183928C10", Slot = "9")]
	public HHGLIBCDIDA NLCGDFFABOD(Func<T, HHGLIBCDIDA> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EAE50", Offset = "0x6EA250")] Func<string, HHGLIBCDIDA> LIPMKKBKLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2477820", Offset = "0x2475E20", VA = "0x182477820", Slot = "20")]
	public MFBKDKPGMNP<TNew> GLAMIBJJBEO<TNew>(Func<TNew> PLLKLEBGMPF) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B85680", Offset = "0x2B83C80", VA = "0x182B85680", Slot = "10")]
	public MFBKDKPGMNP<TNew> GLAMIBJJBEO<TNew>(Func<T, TNew> PLLKLEBGMPF) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3925A10", Offset = "0x3924010", VA = "0x183925A10", Slot = "21")]
	private HHGLIBCDIDA LBMFIHBCEMC(Func<string, string> PLLKLEBGMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3923C00", Offset = "0x3922200", VA = "0x183923C00", Slot = "11")]
	public MFBKDKPGMNP<T> GHGCCOJIDCP(Func<string, string> PLLKLEBGMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31BE070", Offset = "0x31BC670", VA = "0x1831BE070", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25444A0", Offset = "0x2542AA0", VA = "0x1825444A0", Slot = "15")]
	private HHGLIBCDIDA HNGPKBENMJE(Action GIAFPCDPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B79280", Offset = "0x2B77880", VA = "0x182B79280", Slot = "16")]
	private HHGLIBCDIDA DCDHPMCHPID(Action<string> OFNOOEELLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x31BA4A0", Offset = "0x31B8AA0", VA = "0x1831BA4A0", Slot = "17")]
	private HHGLIBCDIDA FPDLHDDNNKC(Action PFKFDGEPEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3922620", Offset = "0x3920C20", VA = "0x183922620")]
	public void BEJNCICKNOM(T GFHGIIOIPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3923880", Offset = "0x3921E80", VA = "0x183923880")]
	protected Exception? GAICMBPAPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3926AD0", Offset = "0x39250D0", VA = "0x183926AD0")]
	public void NEPFPOCMJPJ(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3924EB0", Offset = "0x39234B0", VA = "0x183924EB0", Slot = "26")]
	protected virtual void HIFOODKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x392BA10", Offset = "0x392A010", VA = "0x18392BA10")]
	public FIKNOBAKBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HHGLIBCDIDA : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GKIKHLAEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NNKFHLECBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHGLIBCDIDA EDCBGHFJIBA(Action GIAFPCDPEKG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HHGLIBCDIDA NEPFPOCMJPJ(Action<string> OFNOOEELLMH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHGLIBCDIDA NPPFOIGFBJO(Action PFKFDGEPEJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MFBKDKPGMNP<TNew> NLCGDFFABOD<TNew>(Func<MFBKDKPGMNP<TNew>> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB690", Offset = "0x6EAA90")] Func<string, MFBKDKPGMNP<TNew>> LIPMKKBKLNM) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HHGLIBCDIDA NLCGDFFABOD(Func<HHGLIBCDIDA> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB6F0", Offset = "0x6EAAF0")] Func<string, HHGLIBCDIDA> LIPMKKBKLNM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MFBKDKPGMNP<TNew> GLAMIBJJBEO<TNew>(Func<TNew> PLLKLEBGMPF) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HHGLIBCDIDA GHGCCOJIDCP(Func<string, string> PLLKLEBGMPF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MFBKDKPGMNP<out T> : HHGLIBCDIDA, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFBKDKPGMNP<T> EDCBGHFJIBA(Action<T> GIAFPCDPEKG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new MFBKDKPGMNP<T> EDCBGHFJIBA(Action GIAFPCDPEKG);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new MFBKDKPGMNP<T> NEPFPOCMJPJ(Action<string> OFNOOEELLMH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new MFBKDKPGMNP<T> NPPFOIGFBJO(Action PFKFDGEPEJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MFBKDKPGMNP<TNew> NLCGDFFABOD<TNew>(Func<T, MFBKDKPGMNP<TNew>> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB750", Offset = "0x6EAB50")] Func<string, MFBKDKPGMNP<TNew>> LIPMKKBKLNM) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHGLIBCDIDA NLCGDFFABOD(Func<T, HHGLIBCDIDA> PLLKLEBGMPF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB7B0", Offset = "0x6EABB0")] Func<string, HHGLIBCDIDA> LIPMKKBKLNM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MFBKDKPGMNP<TNew> GLAMIBJJBEO<TNew>(Func<T, TNew> PLLKLEBGMPF) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new MFBKDKPGMNP<T> GHGCCOJIDCP(Func<string, string> PLLKLEBGMPF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FPNLMMCEKLO
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum NDBOMDLEMNJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DPEHAHHIJDF : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F74A60", Offset = "0x6F73060", VA = "0x186F74A60")]
		public DPEHAHHIJDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NEOIFJACOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NEOIFJACOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F76CF0", Offset = "0x6F752F0", VA = "0x186F76CF0")]
		internal void PMCIKHAEBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F76C10", Offset = "0x6F75210", VA = "0x186F76C10")]
		internal void DBHDDDKGALB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F76CA0", Offset = "0x6F752A0", VA = "0x186F76CA0")]
		internal void PIFECEHMMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GIBCOILFBMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HLPKALPBBAA cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NDBOMDLEMNJ unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GIBCOILFBMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F75C70", Offset = "0x6F74270", VA = "0x186F75C70")]
		internal void PMCIKHAEBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F759B0", Offset = "0x6F73FB0", VA = "0x186F759B0")]
		internal void DBHDDDKGALB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F75BD0", Offset = "0x6F741D0", VA = "0x186F75BD0")]
		internal void PIFECEHMMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F75A40", Offset = "0x6F74040", VA = "0x186F75A40")]
		internal void KEIFMMHKGBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MBKHBKEMODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MBKHBKEMODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F10BA0", Offset = "0x1F0F1A0", VA = "0x181F10BA0")]
		internal void HNKBKAEBOEI(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GFFLDFPGKHF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GFFLDFPGKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2180720", Offset = "0x217ED20", VA = "0x182180720")]
		internal void PMCIKHAEBPE(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x24DFF50", Offset = "0x24DE550", VA = "0x1824DFF50")]
		internal void DBHDDDKGALB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x24DD320", Offset = "0x24DB920", VA = "0x1824DD320")]
		internal void PIFECEHMMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LICOGOAAOED<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HLPKALPBBAA cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NDBOMDLEMNJ unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public LICOGOAAOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x26368C0", Offset = "0x2634EC0", VA = "0x1826368C0")]
		internal void PMCIKHAEBPE(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2636480", Offset = "0x2634A80", VA = "0x182636480")]
		internal void DBHDDDKGALB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2636820", Offset = "0x2634E20", VA = "0x182636820")]
		internal void PIFECEHMMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2636520", Offset = "0x2634B20", VA = "0x182636520")]
		internal void KEIFMMHKGBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CMHBLMGFNMI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public CMHBLMGFNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F10BA0", Offset = "0x1F0F1A0", VA = "0x181F10BA0")]
		internal void HNKBKAEBOEI(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PGCIILBJMLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NOKBHGDKGNF promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PGCIILBJMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F77DA0", Offset = "0x6F763A0", VA = "0x186F77DA0")]
		internal void CPOPMFILHCF(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NHCIKGEPNNL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FIKNOBAKBJH<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public NHCIKGEPNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2718060", Offset = "0x2716660", VA = "0x182718060")]
		internal void CPOPMFILHCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB850", Offset = "0x6EAC50")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F75050", Offset = "0x6F73650", VA = "0x186F75050")]
	public static Task BEFJGHDEKFD(this HHGLIBCDIDA MOLFCCHMICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F75260", Offset = "0x6F73860", VA = "0x186F75260")]
	public static Task<bool> BEFJGHDEKFD(this HHGLIBCDIDA MOLFCCHMICC, CancellationToken KEGMOCPJOHL, NDBOMDLEMNJ EMKFAHJLIBM = NDBOMDLEMNJ.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x19FE4B0", Offset = "0x19FCAB0", VA = "0x1819FE4B0")]
	public static Task<TResult> BEFJGHDEKFD<TResult>(this MFBKDKPGMNP<TResult> MOLFCCHMICC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x19FE6E0", Offset = "0x19FCCE0", VA = "0x1819FE6E0")]
	public static Task<TResult> BEFJGHDEKFD<TResult>(this MFBKDKPGMNP<TResult> MOLFCCHMICC, CancellationToken KEGMOCPJOHL, NDBOMDLEMNJ EMKFAHJLIBM = NDBOMDLEMNJ.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F755E0", Offset = "0x6F73BE0", VA = "0x186F755E0")]
	public static TaskAwaiter FCNMHLHACAM(this HHGLIBCDIDA MOLFCCHMICC)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x19FEFF0", Offset = "0x19FD5F0", VA = "0x1819FEFF0")]
	public static TaskAwaiter<TResult> FCNMHLHACAM<TResult>(this MFBKDKPGMNP<TResult> MOLFCCHMICC) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F757E0", Offset = "0x6F73DE0", VA = "0x186F757E0")]
	public static HHGLIBCDIDA OHBCBOBLHKI(this Task JDOLHKOIGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x19FFCB0", Offset = "0x19FE2B0", VA = "0x1819FFCB0")]
	public static MFBKDKPGMNP<TResult> OHBCBOBLHKI<TResult>(this Task<TResult> JDOLHKOIGCI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F75610", Offset = "0x6F73C10", VA = "0x186F75610")]
	private static string FKIPPIGHFPC(Task JDOLHKOIGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HLPKALPBBAA : HHGLIBCDIDA, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HIHEOLKKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CEHMANFECAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGKDEANLLDM();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLPKALPBBAA FFAEIFIJLDE(Action LJGJEAKIPED);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JBAHFMBMJBC<T> : MFBKDKPGMNP<T>, HHGLIBCDIDA, IEnumerator, HLPKALPBBAA
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new JBAHFMBMJBC<T> FFAEIFIJLDE(Action LJGJEAKIPED);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LLDACAIIDPN : NOKBHGDKGNF, HLPKALPBBAA, HHGLIBCDIDA, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> LJGJEAKIPED;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static HLPKALPBBAA MJMCMGJJJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F76930", Offset = "0x6F74F30", VA = "0x186F76930")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HIHEOLKKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x97FB60", Offset = "0x97E160", VA = "0x18097FB60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xDF8F90", Offset = "0xDF7590", VA = "0x180DF8F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool CEHMANFECAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F76A20", Offset = "0x6F75020", VA = "0x186F76A20", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F76A30", Offset = "0x6F75030", VA = "0x186F76A30")]
	static LLDACAIIDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x234BF70", Offset = "0x234A570", VA = "0x18234BF70")]
	public new static JBAHFMBMJBC<T> BGFCCOEKHOE<T>(T NKONLKNLFIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x234BF70", Offset = "0x234A570", VA = "0x18234BF70")]
	public new static JBAHFMBMJBC<T> EGMGFIBBBOM<T>(string PMBGBHCKNKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F76690", Offset = "0x6F74C90", VA = "0x186F76690", Slot = "21")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F76610", Offset = "0x6F74C10", VA = "0x186F76610", Slot = "22")]
	public HLPKALPBBAA FFAEIFIJLDE(Action AAGKLNBFFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F768E0", Offset = "0x6F74EE0", VA = "0x186F768E0", Slot = "18")]
	protected override void HIFOODKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F76990", Offset = "0x6F74F90", VA = "0x186F76990", Slot = "17")]
	public override HHGLIBCDIDA NPPFOIGFBJO(Action PFKFDGEPEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F76B60", Offset = "0x6F75160", VA = "0x186F76B60")]
	public LLDACAIIDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EB8B0", Offset = "0x6EACB0")]
public class PAILLMPLHHI<T> : FIKNOBAKBJH<T>, JBAHFMBMJBC<T>, MFBKDKPGMNP<T>, HHGLIBCDIDA, IEnumerator, HLPKALPBBAA where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> LJGJEAKIPED;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HIHEOLKKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6FE0", Offset = "0x9F55E0", VA = "0x1809F6FE0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6FF0", Offset = "0x9F55F0", VA = "0x1809F6FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CEHMANFECAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x300D3D0", Offset = "0x300B9D0", VA = "0x18300D3D0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x300CF50", Offset = "0x300B550", VA = "0x18300CF50", Slot = "30")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x300CB90", Offset = "0x300B190", VA = "0x18300CB90", Slot = "27")]
	public JBAHFMBMJBC<T> FFAEIFIJLDE(Action AAGKLNBFFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x218CAD0", Offset = "0x218B0D0", VA = "0x18218CAD0", Slot = "31")]
	private HLPKALPBBAA CLBIODCJABF(Action AAGKLNBFFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x300D260", Offset = "0x300B860", VA = "0x18300D260", Slot = "26")]
	protected override void HIFOODKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x300D340", Offset = "0x300B940", VA = "0x18300D340", Slot = "25")]
	public override MFBKDKPGMNP<T> NPPFOIGFBJO(Action PFKFDGEPEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x300D4F0", Offset = "0x300BAF0", VA = "0x18300D4F0")]
	public PAILLMPLHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JBIJMHLLLOM : ELDNLAHJBDM, HLPKALPBBAA, HHGLIBCDIDA, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> LJGJEAKIPED;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HIHEOLKKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7F0", Offset = "0x8BBDF0", VA = "0x1808BD7F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4D90", Offset = "0xAA3390", VA = "0x180AA4D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CEHMANFECAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F76220", Offset = "0x6F74820", VA = "0x186F76220", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F764F0", Offset = "0x6F74AF0", VA = "0x186F764F0")]
	public JBIJMHLLLOM(HLPKALPBBAA MOLFCCHMICC, HLPKALPBBAA FKBKCLEFGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F76230", Offset = "0x6F74830", VA = "0x186F76230")]
	public JBIJMHLLLOM(IList<HLPKALPBBAA> FGGAHFLBHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F75D40", Offset = "0x6F74340", VA = "0x186F75D40", Slot = "21")]
	public void HGKDEANLLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F75CC0", Offset = "0x6F742C0", VA = "0x186F75CC0", Slot = "22")]
	public HLPKALPBBAA FFAEIFIJLDE(Action AAGKLNBFFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F76140", Offset = "0x6F74740", VA = "0x186F76140", Slot = "18")]
	protected override void HIFOODKKOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F76190", Offset = "0x6F74790", VA = "0x186F76190", Slot = "17")]
	public override HHGLIBCDIDA NPPFOIGFBJO(Action PFKFDGEPEJJ)
	{
		return null;
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
