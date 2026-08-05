using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

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
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62E8190", Offset = "0x62E6F90", VA = "0x1862E8190")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FDHGAOPBAEN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BDHHBIINIFM LNEOCLGEBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GHFKDPCBNLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPKEPIHCDKP(Entity IBOBFMDOLFK, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHEMJHAEFPL(Entity IBOBFMDOLFK, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LJNMEKGNKCD(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEINKHNOANJ(Entity IBOBFMDOLFK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KPLGMMOHGGE<TComponentData, TValue> : OJACHFMNLEM<TValue>, IDisposable where TComponentData : struct, FDHGAOPBAEN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class ACPNBECJCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> GIJBOOPKLBM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BLPIMLOHMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3284510", Offset = "0x3283310", VA = "0x183284510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38E1140", Offset = "0x38DFF40", VA = "0x1838E1140")]
		public bool LCCFEIMBOIF([Out] TValue DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x38E1090", Offset = "0x38DFE90", VA = "0x1838E1090")]
		public void HDCMKJKDALC(object ADNDMAGEPOK, TValue DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38E1010", Offset = "0x38DFE10", VA = "0x1838E1010")]
		public bool BOIJHFOIOPE(object ADNDMAGEPOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38E1210", Offset = "0x38E0010", VA = "0x1838E1210")]
		public int PPNKBLEMILO(object ADNDMAGEPOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38E12F0", Offset = "0x38E00F0", VA = "0x1838E12F0")]
		public ACPNBECJCDL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<ACPNBECJCDL> CFNGGOOKCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NJGPPJHEKKC<BDHHBIINIFM, ACPNBECJCDL> DCNEDLGFIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager BCAONBAACAD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A1F0", Offset = "0x3D38FF0", VA = "0x183D3A1F0")]
	public KPLGMMOHGGE(EntityManager BCAONBAACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D39D70", Offset = "0x3D38B70", VA = "0x183D39D70", Slot = "4")]
	public void JPKEPIHCDKP(Entity IBOBFMDOLFK, object ADNDMAGEPOK, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A050", Offset = "0x3D38E50", VA = "0x183D3A050", Slot = "5")]
	public bool NHEMJHAEFPL(Entity IBOBFMDOLFK, object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D39E90", Offset = "0x3D38C90", VA = "0x183D39E90", Slot = "6")]
	public bool LCCFEIMBOIF(Entity IBOBFMDOLFK, [Out] TValue DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D39CA0", Offset = "0x3D38AA0", VA = "0x183D39CA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D39B30", Offset = "0x3D38930", VA = "0x183D39B30")]
	private void DKNHNAHLBIO(ACPNBECJCDL JMNKDCNFHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3D39CC0", Offset = "0x3D38AC0", VA = "0x183D39CC0")]
	private bool GMLONKBGCPF(Entity IBOBFMDOLFK, [Out] BDHHBIINIFM GMPBFHBNPFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D39F70", Offset = "0x3D38D70", VA = "0x183D39F70")]
	private void MNGKCNBJPCL(Entity IBOBFMDOLFK, BDHHBIINIFM GMPBFHBNPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A1D0", Offset = "0x3D38FD0", VA = "0x183D3A1D0")]
	private bool OPBFJDDCKNO(BDHHBIINIFM GMPBFHBNPFC, [Out] ACPNBECJCDL JMNKDCNFHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D39BC0", Offset = "0x3D389C0", VA = "0x183D39BC0")]
	private ACPNBECJCDL DMPGGPPANOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OJACHFMNLEM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPKEPIHCDKP(Entity IBOBFMDOLFK, object ADNDMAGEPOK, TValue DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHEMJHAEFPL(Entity IBOBFMDOLFK, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LCCFEIMBOIF(Entity IBOBFMDOLFK, [Out] TValue DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BDHHBIINIFM : ICMAJFMJFMA, IEquatable<BDHHBIINIFM>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BDHHBIINIFM AKAAHGKNKOG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int GGDKNGHMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62E7C70", Offset = "0x62E6A70", VA = "0x1862E7C70", Slot = "8")]
	public bool Equals(BDHHBIINIFM GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62E7CC0", Offset = "0x62E6AC0", VA = "0x1862E7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OIMDDCMKAIM<THasTokensTag> : GHFKDPCBNLB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, BDHHBIINIFM> POEHDEJBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> CFNGGOOKCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private NJGPPJHEKKC<BDHHBIINIFM, HashSet<object>> DCNEDLGFIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager BCAONBAACAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem MBEAFJBBBLH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x410C3C0", Offset = "0x410B1C0", VA = "0x18410C3C0")]
	public OIMDDCMKAIM(EntityManager BCAONBAACAD, EntityCommandBufferSystem MBEAFJBBBLH, JNOMMELLEMA BDCDALNALPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x410BEE0", Offset = "0x410ACE0", VA = "0x18410BEE0", Slot = "4")]
	public bool JPKEPIHCDKP(Entity IBOBFMDOLFK, object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x410C1E0", Offset = "0x410AFE0", VA = "0x18410C1E0", Slot = "5")]
	public bool NHEMJHAEFPL(Entity IBOBFMDOLFK, object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x410C0F0", Offset = "0x410AEF0", VA = "0x18410C0F0", Slot = "6")]
	public bool LJNMEKGNKCD(Entity IBOBFMDOLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x410C040", Offset = "0x410AE40", VA = "0x18410C040", Slot = "9")]
	public bool LJNMEKGNKCD(BDHHBIINIFM GMPBFHBNPFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x410BB90", Offset = "0x410A990", VA = "0x18410BB90", Slot = "7")]
	public bool IEINKHNOANJ(Entity IBOBFMDOLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x410BA90", Offset = "0x410A890", VA = "0x18410BA90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x410B980", Offset = "0x410A780", VA = "0x18410B980")]
	private void DKNHNAHLBIO(HashSet<object> JMNKDCNFHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x410BAD0", Offset = "0x410A8D0", VA = "0x18410BAD0")]
	private bool GMLONKBGCPF(Entity IBOBFMDOLFK, [Out] BDHHBIINIFM GMPBFHBNPFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x410B8D0", Offset = "0x410A6D0", VA = "0x18410B8D0")]
	private bool CKBBOABEGHC(Entity IBOBFMDOLFK, [Out] BDHHBIINIFM GMPBFHBNPFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x410BCE0", Offset = "0x410AAE0", VA = "0x18410BCE0")]
	private void IFFJMHMLIHJ(Entity IBOBFMDOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x410BDE0", Offset = "0x410ABE0", VA = "0x18410BDE0")]
	private void IPCIMOPBNOJ(Entity IBOBFMDOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x410C340", Offset = "0x410B140", VA = "0x18410C340")]
	private void PAOEOJGOKDK(Entity IBOBFMDOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x410C170", Offset = "0x410AF70", VA = "0x18410C170")]
	private void MNGKCNBJPCL(Entity IBOBFMDOLFK, BDHHBIINIFM GMPBFHBNPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x410BC80", Offset = "0x410AA80", VA = "0x18410BC80")]
	private bool IFCBPMPICBL(BDHHBIINIFM GMPBFHBNPFC, [Out] HashSet<object> JMNKDCNFHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x410B9F0", Offset = "0x410A7F0", VA = "0x18410B9F0")]
	private HashSet<object> DMPGGPPANOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JPEBGBOHNIJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LFPDGDJBBPI : IMHJDDMMJHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62E8570", Offset = "0x62E7370", VA = "0x1862E8570")]
	public float ODHIKKHJKJP([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62E8570", Offset = "0x62E7370", VA = "0x1862E8570", Slot = "4")]
	private float DHAPPGCPGHF([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LOPJMDHKKDI : IMHJDDMMJHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62E88D0", Offset = "0x62E76D0", VA = "0x1862E88D0")]
	public float ODHIKKHJKJP([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62E88D0", Offset = "0x62E76D0", VA = "0x1862E88D0", Slot = "4")]
	private float DHAPPGCPGHF([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MCFFKLBLLCF : IMHJDDMMJHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B023C0", Offset = "0x1B011C0", VA = "0x181B023C0")]
	public float ODHIKKHJKJP([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B023C0", Offset = "0x1B011C0", VA = "0x181B023C0", Slot = "4")]
	private float DHAPPGCPGHF([In] float3 DIBNBLEEFNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NCMGFPPEEDC : IMHJDDMMJHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110")]
	public int ODHIKKHJKJP([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110", Slot = "4")]
	private int EFEDLFJDBOC([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EHAGLKEHGJG : IMHJDDMMJHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62E8180", Offset = "0x62E6F80", VA = "0x1862E8180")]
	public int ODHIKKHJKJP([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62E8180", Offset = "0x62E6F80", VA = "0x1862E8180", Slot = "4")]
	private int EFEDLFJDBOC([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FIIDHPGIOOE : IMHJDDMMJHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16FE4B0", Offset = "0x16FD2B0", VA = "0x1816FE4B0")]
	public int ODHIKKHJKJP([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x16FE4B0", Offset = "0x16FD2B0", VA = "0x1816FE4B0", Slot = "4")]
	private int EFEDLFJDBOC([In] int3 DIBNBLEEFNN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BDGNMELODBE : CLKDHNLADCA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	public BDGNMELODBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MGKEJAKCEEH : SystemBase, BNEANCLKOPO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x297E980", Offset = "0x297D780", VA = "0x18297E980")]
	public void GBNLNLELIDK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x297EDC0", Offset = "0x297DBC0", VA = "0x18297EDC0")]
	public JobHandle GBNLNLELIDK<T>(JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x297E980", Offset = "0x297D780", VA = "0x18297E980")]
	public void CKGCJEJDPPE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x297E800", Offset = "0x297D600", VA = "0x18297E800")]
	public JobHandle CKGCJEJDPPE<T>(JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62E8900", Offset = "0x62E7700", VA = "0x1862E8900")]
	public ComponentDataFromEntity OAKAOOLILPF(int OIOKOFFMIPK, bool BNKEHDLBHDH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62E88E0", Offset = "0x62E76E0", VA = "0x1862E88E0")]
	public EntityExistenceLookupByEntity FGEONAINFJE()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62E89C0", Offset = "0x62E77C0", VA = "0x1862E89C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	protected MGKEJAKCEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GMJKBNAMDEB : MGKEJAKCEEH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62E8280", Offset = "0x62E7080", VA = "0x1862E8280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	protected GMJKBNAMDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NPIDKJGBFPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CNFFAPPPIBD : EntityCommandBufferSystem, BNEANCLKOPO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	protected CNFFAPPPIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IMHJDDMMJHL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ODHIKKHJKJP([In] TFrom DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MAGLFHJCEKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJDGKHLDJLL(T DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct NGKDMBANCJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes ONLDEJOKOBJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62E89D0", Offset = "0x62E77D0", VA = "0x1862E89D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct APKGHBAAACO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62E7BD0", Offset = "0x62E69D0", VA = "0x1862E7BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct PANJMPMBIKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType AAJLJIDCBHI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62E8AC0", Offset = "0x62E78C0", VA = "0x1862E8AC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct DFFFALKLMHH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> LHODDAGAJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x513DF00", Offset = "0x513CD00", VA = "0x18513DF00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct PEOEACBMCCK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> NIEBKKPIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct EKFFOOHMMMM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> EIMPJPDNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T DIBNBLEEFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer LKBOONFNOGG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3493560", Offset = "0x3492360", VA = "0x183493560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct JLOJMDHANFE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IMHJDDMMJHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> IBFEPIDEPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct HDJFIEOIEGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity HKLLPIJEFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> IBFEPIDEPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int DHGEIJGOCBI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62E82B0", Offset = "0x62E70B0", VA = "0x1862E82B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct BGOKLGKHNPP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLILMGOALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> ENLDIBGPIFC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct BFLOBIOEODO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IMHJDDMMJHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> JOJEDPCELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> IBFEPIDEPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PHBCEMEEFJI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFCDOKNJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> KBOAGPNGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> CLLALDDNHEK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LAPIKBHBGIO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFCDOKNJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> KBOAGPNGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> CLLALDDNHEK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DA72F0", Offset = "0x3DA60F0", VA = "0x183DA72F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct NPMOOCIAJJL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> ENLDIBGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> PLBNFDOAGDO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4059010", Offset = "0x4057E10", VA = "0x184059010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct IMMDLMBEPMJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IMHJDDMMJHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> ENLDIBGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> PLBNFDOAGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct PMAMGKGOAJD<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAGLFHJCEKJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> HBOLLOEHIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> FHCKJKCFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x41DC4B0", Offset = "0x41DB2B0", VA = "0x1841DC4B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct FGCEEIPPKHD<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAGLFHJCEKJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HMJPNHNFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> ENLDIBGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LKJOHEDEHJI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity MFCDOKNJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> KBOAGPNGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> KEMAOFAIFCE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62E8840", Offset = "0x62E7640", VA = "0x1862E8840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FCJBEHPIDOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity MFCDOKNJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> KBOAGPNGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> KEMAOFAIFCE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62E81F0", Offset = "0x62E6FF0", VA = "0x1862E81F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JOMAMMIFLLF
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KMNDLHCIMJL
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2956FE0", Offset = "0x2955DE0", VA = "0x182956FE0")]
	public static bool ABKEPDAKIBP<T>(this NativeArray<Entity> KBOAGPNGOLM, EntityManager BCAONBAACAD, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IKHENLHLOOD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FLIKECCLFAG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public FLIKECCLFAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NLEJCBCEIDK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public NLEJCBCEIDK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> OEDAEEHPIPN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62E83B0", Offset = "0x62E71B0", VA = "0x1862E83B0")]
	public IKHENLHLOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HIEPAEKNGFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HEKDLPKAAEG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct EEHDHPDGGNC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct PICMDGEHLBL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal EEHDHPDGGNC<TFrom> OGCHMLDLLMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> EKLFCLOPJMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct BLBCHIBIEED<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct KPLKLKFNKMO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal BLBCHIBIEED<TFrom> OGCHMLDLLMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> EKLFCLOPJMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DGHCFICLLIM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct IGFJKGOGHPF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal DGHCFICLLIM<TFrom> OGCHMLDLLMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> EKLFCLOPJMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct LCMAOEEIEBN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct KFGOOOCJBJF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal LCMAOEEIEBN<TFrom> OGCHMLDLLMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> EKLFCLOPJMB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BLEGPGANCAF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DKIGKKJPCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2758560", Offset = "0x2757360", VA = "0x182758560")]
	public static NativeList<T> EMEHGJBNFEN<T>(this NativeArray<T> FHNNJDCHHBI, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NPGONBDODEM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LFPOEFHOGDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x295E500", Offset = "0x295D300", VA = "0x18295E500")]
	[AFMEEDMPPEF]
	public static JobHandle FOILKMAJCCH<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArrayAsync<Entity> EIMPJPDNNIE, NativeArrayAsync<T> LHODDAGAJKC, [Optional] JobHandle PHKAHFHINGD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x295E780", Offset = "0x295D580", VA = "0x18295E780")]
	[AFMEEDMPPEF]
	public static JobHandle FOILKMAJCCH<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArrayAsync<Entity> EIMPJPDNNIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x295E660", Offset = "0x295D460", VA = "0x18295E660")]
	[AFMEEDMPPEF]
	public static JobHandle FOILKMAJCCH<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArray<Entity> EIMPJPDNNIE, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62E86D0", Offset = "0x62E74D0", VA = "0x1862E86D0")]
	[AFMEEDMPPEF]
	public static JobHandle FOILKMAJCCH(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArray<Entity> EIMPJPDNNIE, ComponentTypes ONLDEJOKOBJ, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62E8580", Offset = "0x62E7380", VA = "0x1862E8580")]
	[AFMEEDMPPEF]
	public static JobHandle FOILKMAJCCH(this EntityCommandBufferSystem MBEAFJBBBLH, EntityCommandBuffer LKBOONFNOGG, NativeArray<Entity> EIMPJPDNNIE, ComponentTypes ONLDEJOKOBJ, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HBGNAGKFKBP
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28E4ED0", Offset = "0x28E3CD0", VA = "0x1828E4ED0")]
	[AFMEEDMPPEF]
	public static JobHandle EJMJOPDNFOF<T>(this EntityCommandBufferSystem MBEAFJBBBLH, EntityCommandBuffer LKBOONFNOGG, EntityQuery AGOHNAAAJBJ, T DIBNBLEEFNN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DEBPICBFMLO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62E7D10", Offset = "0x62E6B10", VA = "0x1862E7D10")]
	[AFMEEDMPPEF]
	public static JobHandle MEPIMDLPJDB(this EntityCommandBufferSystem MBEAFJBBBLH, NativeList<Entity> EIMPJPDNNIE, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62E7EA0", Offset = "0x62E6CA0", VA = "0x1862E7EA0")]
	[AFMEEDMPPEF]
	public static JobHandle MEPIMDLPJDB(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArrayAsync<Entity> EIMPJPDNNIE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IFAELEOHMNC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2900070", Offset = "0x28FEE70", VA = "0x182900070")]
	public static void KIGCLKLHNNE<T>(this EntityCommandBufferSystem MBEAFJBBBLH, EntityQuery AGOHNAAAJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29004E0", Offset = "0x28FF2E0", VA = "0x1829004E0")]
	[AFMEEDMPPEF]
	public static JobHandle MCLLBBAOENH<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeListAsync<Entity> EIMPJPDNNIE, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x29005A0", Offset = "0x28FF3A0", VA = "0x1829005A0")]
	[AFMEEDMPPEF]
	public static JobHandle MCLLBBAOENH<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArrayAsync<Entity> EIMPJPDNNIE, [Optional] JobHandle PHKAHFHINGD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ALMKMIDAGMH
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2F11DA0", Offset = "0x2F10BA0", VA = "0x182F11DA0")]
	[AFMEEDMPPEF]
	public static JobHandle HDJGIOBPGPF<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArray<Entity> EIMPJPDNNIE, NativeArray<T> LHODDAGAJKC, JobHandle PHKAHFHINGD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DOAGPHHBMGH
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x275A1A0", Offset = "0x2758FA0", VA = "0x18275A1A0")]
	[AFMEEDMPPEF]
	public static JobHandle KHNIGLGFLLJ<T>(this EntityCommandBufferSystem MBEAFJBBBLH, NativeArray<Entity> EIMPJPDNNIE, T DIBNBLEEFNN, [Optional] JobHandle PHKAHFHINGD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x275A0D0", Offset = "0x2758ED0", VA = "0x18275A0D0")]
	[AFMEEDMPPEF]
	public static JobHandle KHNIGLGFLLJ<T>(this EntityCommandBufferSystem MBEAFJBBBLH, EntityCommandBuffer LKBOONFNOGG, NativeArray<Entity> EIMPJPDNNIE, T DIBNBLEEFNN, [Optional] JobHandle PHKAHFHINGD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OEPMDJNNLOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DIPALHAFMHO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x274FD10", Offset = "0x274EB10", VA = "0x18274FD10")]
	public static NativeArray<T> PHDJDBLDHOG<T>(this NativeList<Entity> FHNNJDCHHBI, EntityManager BCAONBAACAD, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x274F990", Offset = "0x274E790", VA = "0x18274F990")]
	public static NativeArray<T> PHDJDBLDHOG<T>(this NativeArray<Entity> FHNNJDCHHBI, EntityManager BCAONBAACAD, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62E7FA0", Offset = "0x62E6DA0", VA = "0x1862E7FA0")]
	public static NativeArray<Entity> GIOECJGALJO(this NativeArray<Entity> FHNNJDCHHBI, EntityManager BCAONBAACAD, ComponentType AAJLJIDCBHI, Allocator ACBNCIGINAO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x274F8B0", Offset = "0x274E6B0", VA = "0x18274F8B0")]
	public static NativeArray<T> ALCIABBBNNF<T>(this NativeArray<Entity> FHNNJDCHHBI, EntityManager BCAONBAACAD, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DEIFFMCJEEA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct DFIBCMKEIBL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct PIDIKKMGGHO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public DFIBCMKEIBL<TFrom> EKLFCLOPJMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IIGIEHCPHFE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct LBMBFAJAPMC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public IIGIEHCPHFE<TFrom> EKLFCLOPJMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GKAMIMEGOKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct PHEMBMDOKOF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public GKAMIMEGOKJ<TFrom> EKLFCLOPJMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> HMJPNHNFNJJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class EGNKEMMCJAB
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class JLHADBOHBAM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KABPAODGDGK : IMHJDDMMJHL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> OKJMBOADECI;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62E8560", Offset = "0x62E7360", VA = "0x1862E8560")]
		[BurstCompatible]
		public Entity ODHIKKHJKJP([In] Entity DIBNBLEEFNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62E8560", Offset = "0x62E7360", VA = "0x1862E8560", Slot = "4")]
		private Entity FOEKHEKHJIJ([In] Entity DIBNBLEEFNN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FPHHFADNDJG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct JNNLEJLIFAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> HBOLLOEHIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct MPPLIKBCLMM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> HBOLLOEHIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HJKDECBHBNC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> HBOLLOEHIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> HMJPNHNFNJJ;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27D4D00", Offset = "0x27D3B00", VA = "0x1827D4D00")]
		public NativeListAsync<Entity> BJDGKHLDJLL<TPredicate>() where TPredicate : struct, MAGLFHJCEKJ<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28BBF00", Offset = "0x28BAD00", VA = "0x1828BBF00")]
	public static HJKDECBHBNC<T> PKCKIKDAFMI<T>(this NativeArrayAsync<Entity> KBOAGPNGOLM, NativeArrayAsync<T> FHNNJDCHHBI, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct
	{
		return default(HJKDECBHBNC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FDCBDDNLEBL
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28A5950", Offset = "0x28A4750", VA = "0x1828A5950")]
	public static NativeListAsync<Entity> ECDHHFEJLGL<T, TPredicate>(this NativeArrayAsync<T> FHNNJDCHHBI, NativeArrayAsync<Entity> KBOAGPNGOLM, Allocator ACBNCIGINAO = Allocator.TempJob) where T : struct where TPredicate : struct, MAGLFHJCEKJ<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x28A5A10", Offset = "0x28A4810", VA = "0x1828A5A10")]
	private static NativeListAsync<Entity> JIKEBOAHNKL<T, TPredicate>(NativeArrayAsync<T> ALFONDCOBMH, NativeArrayAsync<Entity> KBOAGPNGOLM, int PDCHCFIOJCE, Allocator ACBNCIGINAO) where T : struct where TPredicate : struct, MAGLFHJCEKJ<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DPJFLAHLDID
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IGPFBENEJPN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct EDGDBOIGIFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct ACKJAMOOMAJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> HMJPNHNFNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct JCJCOIOANBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator ACBNCIGINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> HMJPNHNFNJJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NMKDDLHMHEE
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AHLMJOGEOFF
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C190", Offset = "0x2F0AF90", VA = "0x182F0C190")]
	public static NativeList<Entity> OLEGBMGOFEK<T>(this NativeArray<Entity> KBOAGPNGOLM, EntityManager BCAONBAACAD, Allocator ACBNCIGINAO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LKANCKFGGAK
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FGEKMOHPEBL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct IAGBMKPMGML<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> OKLABKDOFAF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
		public IAGBMKPMGML(NativeArray<TSrc> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420")]
		public JDBICKKEAKE<TSrc, TValue> MBDNLNKBOJG<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(JDBICKKEAKE<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct JDBICKKEAKE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> OKLABKDOFAF;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
		public JDBICKKEAKE(NativeArray<TSrc> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420")]
		public BEOIKJKGNKE<TSrc, TValue, TSelector> MLEPGKNMEKF<TSelector>() where TSelector : struct, IMHJDDMMJHL<TSrc, TValue>
		{
			return default(BEOIKJKGNKE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct BEOIKJKGNKE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IMHJDDMMJHL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> OKLABKDOFAF;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
		public BEOIKJKGNKE(NativeArray<TSrc> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x483B3B0", Offset = "0x483A1B0", VA = "0x18483B3B0")]
		public JKFKGDFLILD<TSrc, TValue, TSelector> FPKJIDHPAKP()
		{
			return default(JKFKGDFLILD<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct ENJFKLLMEHI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IMHJDDMMJHL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> OKLABKDOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector BADIELCKJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int AELAKOMEEDP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x34C37A0", Offset = "0x34C25A0", VA = "0x1834C37A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int PCBIBNEPCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA4E340", Offset = "0xA4D140", VA = "0x180A4E340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NIBNLPMGPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x34C3910", Offset = "0x34C2710", VA = "0x1834C3910")]
		public ENJFKLLMEHI(NativeArray<TSrc> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x34C3790", Offset = "0x34C2590", VA = "0x1834C3790")]
		public bool BHMBEBCDIOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x34C3830", Offset = "0x34C2630", VA = "0x1834C3830")]
		private TSrc LLCANGLOPHL(int GJPDNBKOLHF)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct JKFKGDFLILD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IMHJDDMMJHL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private ENJFKLLMEHI<TSrc, TValue, TSelector> PCKGONCDMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue LNKBIEGPNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int DLJHEFPEFCO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NOPMELDHBFC JOFMHBCKKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3C451A0", Offset = "0x3C43FA0", VA = "0x183C451A0")]
			get
			{
				return default(NOPMELDHBFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue HGPGDIPPEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, NOPMELDHBFC range) HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3C450D0", Offset = "0x3C43ED0", VA = "0x183C450D0")]
			get
			{
				return default((TValue, NOPMELDHBFC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C451E0", Offset = "0x3C43FE0", VA = "0x183C451E0")]
		public JKFKGDFLILD(NativeArray<TSrc> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x39CE690", Offset = "0x39CD490", VA = "0x1839CE690")]
		public JKFKGDFLILD<TSrc, TValue, TSelector> CNEJODDGPIM()
		{
			return default(JKFKGDFLILD<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C44F90", Offset = "0x3C43D90", VA = "0x183C44F90")]
		public bool BHMBEBCDIOJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x28AF4A0", Offset = "0x28AE2A0", VA = "0x1828AF4A0")]
	public static IAGBMKPMGML<T> EDDNIPCHLLP<T>(this NativeList<T> GIJBOOPKLBM) where T : struct
	{
		return default(IAGBMKPMGML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420")]
	public static IAGBMKPMGML<T> EDDNIPCHLLP<T>(this NativeArray<T> OKLABKDOFAF) where T : struct
	{
		return default(IAGBMKPMGML<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class FMKEEFCPBGN
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct PCHAENMNHKN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly OKLABKDOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int DLJHEFPEFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int EHKFLAMEJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T LNKBIEGPNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T CLKLEFGOOAP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NOPMELDHBFC JOFMHBCKKAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x41C50D0", Offset = "0x41C3ED0", VA = "0x1841C50D0")]
			get
			{
				return default(NOPMELDHBFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T HGPGDIPPEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3521340", Offset = "0x3520140", VA = "0x183521340")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, NOPMELDHBFC) HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x41C5000", Offset = "0x41C3E00", VA = "0x1841C5000")]
			get
			{
				return default((T, NOPMELDHBFC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x41C50E0", Offset = "0x41C3EE0", VA = "0x1841C50E0")]
		public PCHAENMNHKN(NativeArray<T> OKLABKDOFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x41C4F20", Offset = "0x41C3D20", VA = "0x1841C4F20")]
		public PCHAENMNHKN<T> CNEJODDGPIM()
		{
			return default(PCHAENMNHKN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x41C4D50", Offset = "0x41C3B50", VA = "0x1841C4D50")]
		public bool BHMBEBCDIOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2886060", Offset = "0x2884E60", VA = "0x182886060")]
		public PGGJJMJBMDK<T, TComparer> AANKDDAMHHL<TComparer>([Optional] TComparer EEFFILGOCDL) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PGGJJMJBMDK<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PGGJJMJBMDK<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly OKLABKDOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int DLJHEFPEFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int EHKFLAMEJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T LNKBIEGPNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T CLKLEFGOOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer EEFFILGOCDL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NOPMELDHBFC JOFMHBCKKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x41C50D0", Offset = "0x41C3ED0", VA = "0x1841C50D0")]
			get
			{
				return default(NOPMELDHBFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T HGPGDIPPEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3521340", Offset = "0x3520140", VA = "0x183521340")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x41CD570", Offset = "0x41CC370", VA = "0x1841CD570")]
		public PGGJJMJBMDK(NativeArray<T>.ReadOnly OKLABKDOFAF, TComparer EEFFILGOCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x41CD3A0", Offset = "0x41CC1A0", VA = "0x1841CD3A0")]
		public bool BHMBEBCDIOJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28B9DC0", Offset = "0x28B8BC0", VA = "0x1828B9DC0")]
	public static PCHAENMNHKN<T> FPKJIDHPAKP<T>(this NativeArray<T> OKLABKDOFAF) where T : struct
	{
		return default(PCHAENMNHKN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface ECMOBJCIACK
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class EIIMFGFAFLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IKODAJHPDNJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IOKKMAAGNOB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public IKODAJHPDNJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x38A84B0", Offset = "0x38A72B0", VA = "0x1838A84B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public IOKKMAAGNOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A99DC0", Offset = "0x3A98BC0", VA = "0x183A99DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A99F70", Offset = "0x3A98D70", VA = "0x183A99F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> KIGFGEHMGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream MEDEAOCENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream PABMIDADACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf AABHHMAPNDI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A89F10", Offset = "0x3A88D10", VA = "0x183A89F10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A89F50", Offset = "0x3A88D50", VA = "0x183A89F50", Slot = "4")]
	[IteratorStateMachine(typeof(IKODAJHPDNJ<>.IOKKMAAGNOB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A040", Offset = "0x3A88E40", VA = "0x183A8A040", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HFAJJJDGKOF<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] GGBNILIIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf AABHHMAPNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream MEDEAOCENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream CMCIGAFCDGJ;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39BA600", Offset = "0x39B9400", VA = "0x1839BA600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct FCFMDKHMNHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream MEDEAOCENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream PABMIDADACF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62E81B0", Offset = "0x62E6FB0", VA = "0x1862E81B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JNKELPNIPCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] GGBNILIIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream MEDEAOCENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream CMCIGAFCDGJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62E8440", Offset = "0x62E7240", VA = "0x1862E8440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FGHKDBEFLPB
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DPJDKNGFADI
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum GNBDBCLMLFG
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class AKJBLBJNHLG
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LDJNHENMGAB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LDJNHENMGAB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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
