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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x61E6FD0", Offset = "0x61E5BD0", VA = "0x1861E6FD0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GOPJDCFJMPH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OAMNLLMKGGL NMENGCAOJFC
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
public interface EFNMGMBPCEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLKNBHOLHHD(Entity CMFPBPOIOPE, object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHIBOMABPAO(Entity CMFPBPOIOPE, object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHNJBEEMNBK(Entity CMFPBPOIOPE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHDJEPHFLBB(Entity CMFPBPOIOPE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LLNACIELNHB<TComponentData, TValue> : OEIPGJDJEJM<TValue>, IDisposable where TComponentData : struct, GOPJDCFJMPH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class EMGCGPKMLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> GPOHBJENHCE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int LOHCAPLAMPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x313B930", Offset = "0x313A530", VA = "0x18313B930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x334A370", Offset = "0x3348F70", VA = "0x18334A370")]
		public bool MDBAJHOKHDL([Out] TValue BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x334A160", Offset = "0x3348D60", VA = "0x18334A160")]
		public void BGJHDHHBMPP(object DGPOLLDAHJK, TValue BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x334A210", Offset = "0x3348E10", VA = "0x18334A210")]
		public bool DMBJGENFJDP(object DGPOLLDAHJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x334A290", Offset = "0x3348E90", VA = "0x18334A290")]
		public int ELFJNLHIMCG(object DGPOLLDAHJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x334A460", Offset = "0x3349060", VA = "0x18334A460")]
		public EMGCGPKMLJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<EMGCGPKMLJB> ILKJEJJJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private AJDIFNPPNBA<OAMNLLMKGGL, EMGCGPKMLJB> ODEOFELNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager DIINGHOOBHL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C32250", Offset = "0x3C30E50", VA = "0x183C32250")]
	public LLNACIELNHB(EntityManager DIINGHOOBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C31F70", Offset = "0x3C30B70", VA = "0x183C31F70", Slot = "4")]
	public void MLKNBHOLHHD(Entity CMFPBPOIOPE, object DGPOLLDAHJK, TValue BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C320B0", Offset = "0x3C30CB0", VA = "0x183C320B0", Slot = "5")]
	public bool PHIBOMABPAO(Entity CMFPBPOIOPE, object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C31E70", Offset = "0x3C30A70", VA = "0x183C31E70", Slot = "6")]
	public bool MDBAJHOKHDL(Entity CMFPBPOIOPE, [Out] TValue BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C31B00", Offset = "0x3C30700", VA = "0x183C31B00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C31B40", Offset = "0x3C30740", VA = "0x183C31B40")]
	private void HPAKKKCGLON(EMGCGPKMLJB BHHGDOGDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C31CC0", Offset = "0x3C308C0", VA = "0x183C31CC0")]
	private bool JMFCPMAJOCL(Entity CMFPBPOIOPE, [Out] OAMNLLMKGGL FMPJGJEOBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C31D80", Offset = "0x3C30980", VA = "0x183C31D80")]
	private void LDIOHNBANMN(Entity CMFPBPOIOPE, OAMNLLMKGGL FMPJGJEOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C31B20", Offset = "0x3C30720", VA = "0x183C31B20")]
	private bool FEOMCJEKCAH(OAMNLLMKGGL FMPJGJEOBDD, [Out] EMGCGPKMLJB BHHGDOGDNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C31BD0", Offset = "0x3C307D0", VA = "0x183C31BD0")]
	private EMGCGPKMLJB JKFGAAJIHEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OEIPGJDJEJM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLKNBHOLHHD(Entity CMFPBPOIOPE, object DGPOLLDAHJK, TValue BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHIBOMABPAO(Entity CMFPBPOIOPE, object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MDBAJHOKHDL(Entity CMFPBPOIOPE, [Out] TValue BLKAHBIJBJO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OAMNLLMKGGL : ONPNDKJAMEL, IEquatable<OAMNLLMKGGL>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly OAMNLLMKGGL FAELGIKGNCM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int KGAKPAMIIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MONJDGNGJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61E7AA0", Offset = "0x61E66A0", VA = "0x1861E7AA0", Slot = "8")]
	public bool Equals(OAMNLLMKGGL NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61E7AF0", Offset = "0x61E66F0", VA = "0x1861E7AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AEHMOIMBAFK<THasTokensTag> : EFNMGMBPCEC, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, OAMNLLMKGGL> BLNIDCKLELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> ILKJEJJJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AJDIFNPPNBA<OAMNLLMKGGL, HashSet<object>> ODEOFELNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager DIINGHOOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem CJGLJBDEBOP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x373A640", Offset = "0x3739240", VA = "0x18373A640")]
	public AEHMOIMBAFK(EntityManager DIINGHOOBHL, EntityCommandBufferSystem CJGLJBDEBOP, HEENJBKIIAO PHBEEGOHCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3739830", Offset = "0x3738430", VA = "0x183739830", Slot = "4")]
	public bool MLKNBHOLHHD(Entity CMFPBPOIOPE, object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x373A360", Offset = "0x3738F60", VA = "0x18373A360", Slot = "5")]
	public bool PHIBOMABPAO(Entity CMFPBPOIOPE, object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3738630", Offset = "0x3737230", VA = "0x183738630", Slot = "6")]
	public bool CHNJBEEMNBK(Entity CMFPBPOIOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3738770", Offset = "0x3737370", VA = "0x183738770", Slot = "9")]
	public bool CHNJBEEMNBK(OAMNLLMKGGL FMPJGJEOBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37393B0", Offset = "0x3737FB0", VA = "0x1837393B0", Slot = "7")]
	public bool MHDJEPHFLBB(Entity CMFPBPOIOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3738950", Offset = "0x3737550", VA = "0x183738950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3738A70", Offset = "0x3737670", VA = "0x183738A70")]
	private void HPAKKKCGLON(HashSet<object> BHHGDOGDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3738E60", Offset = "0x3737A60", VA = "0x183738E60")]
	private bool JMFCPMAJOCL(Entity CMFPBPOIOPE, [Out] OAMNLLMKGGL FMPJGJEOBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3739E00", Offset = "0x3738A00", VA = "0x183739E00")]
	private bool NEKMHBDMAHI(Entity CMFPBPOIOPE, [Out] OAMNLLMKGGL FMPJGJEOBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3739FD0", Offset = "0x3738BD0", VA = "0x183739FD0")]
	private void OAPDMJJBMCE(Entity CMFPBPOIOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3739040", Offset = "0x3737C40", VA = "0x183739040")]
	private void KBBJALFMOMB(Entity CMFPBPOIOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3739730", Offset = "0x3738330", VA = "0x183739730")]
	private void MLEFPOBINOM(Entity CMFPBPOIOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3739260", Offset = "0x3737E60", VA = "0x183739260")]
	private void LDIOHNBANMN(Entity CMFPBPOIOPE, OAMNLLMKGGL FMPJGJEOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3738570", Offset = "0x3737170", VA = "0x183738570")]
	private bool CFIHBNKHFJG(OAMNLLMKGGL FMPJGJEOBDD, [Out] HashSet<object> BHHGDOGDNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3738C20", Offset = "0x3737820", VA = "0x183738C20")]
	private HashSet<object> JKFGAAJIHEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IINONGDPFAM
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PLBNPNGNGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int OIAPMOHIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int MAJIECOCCAC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BOBKHJLAPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ELNHPLPIPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CAMOLGCILAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61E7F40", Offset = "0x61E6B40", VA = "0x1861E7F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61E7F50", Offset = "0x61E6B50", VA = "0x1861E7F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xADE590", Offset = "0xADD190", VA = "0x180ADE590")]
	private PLBNPNGNGLA(int OIAPMOHIBDO, int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E04AC0", Offset = "0x1E036C0", VA = "0x181E04AC0")]
	public static PLBNPNGNGLA AGMPDJCCANO(int OIAPMOHIBDO, int MAJIECOCCAC)
	{
		return default(PLBNPNGNGLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F60", Offset = "0x61E6B60", VA = "0x1861E7F60")]
	public static PLBNPNGNGLA OOKFDCHKIAA(int ILKNGPHCOGM, int FFMMBPDGBBA)
	{
		return default(PLBNPNGNGLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F70", Offset = "0x61E6B70", VA = "0x1861E7F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PGMAHNIHNKE : DOPHCONDDKL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F30", Offset = "0x61E6B30", VA = "0x1861E7F30")]
	public float PFNKGJFMOHL([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F30", Offset = "0x61E6B30", VA = "0x1861E7F30", Slot = "4")]
	private float CLPKHEIIHJB([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EHCCOJJBIOI : DOPHCONDDKL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61E6FC0", Offset = "0x61E5BC0", VA = "0x1861E6FC0")]
	public float PFNKGJFMOHL([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61E6FC0", Offset = "0x61E5BC0", VA = "0x1861E6FC0", Slot = "4")]
	private float CLPKHEIIHJB([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JGMPBLGLPKC : DOPHCONDDKL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1AD1920", Offset = "0x1AD0520", VA = "0x181AD1920")]
	public float PFNKGJFMOHL([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1AD1920", Offset = "0x1AD0520", VA = "0x181AD1920", Slot = "4")]
	private float CLPKHEIIHJB([In] float3 BLKAHBIJBJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HFHNHHJIACL : DOPHCONDDKL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40")]
	public int PFNKGJFMOHL([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x13DDE40", Offset = "0x13DCA40", VA = "0x1813DDE40", Slot = "4")]
	private int FNJBKJIMMMP([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MIPCNMMKMBG : DOPHCONDDKL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61E7900", Offset = "0x61E6500", VA = "0x1861E7900")]
	public int PFNKGJFMOHL([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61E7900", Offset = "0x61E6500", VA = "0x1861E7900", Slot = "4")]
	private int FNJBKJIMMMP([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OJPGDLJCOEG : DOPHCONDDKL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16BEDF0", Offset = "0x16BD9F0", VA = "0x1816BEDF0")]
	public int PFNKGJFMOHL([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16BEDF0", Offset = "0x16BD9F0", VA = "0x1816BEDF0", Slot = "4")]
	private int FNJBKJIMMMP([In] int3 BLKAHBIJBJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GDGPKLLMFID : OGOPLFOLLPL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	public GDGPKLLMFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JOPHCNGAJAM : SystemBase, IFEPGPCLCHO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61E74C0", Offset = "0x61E60C0", VA = "0x1861E74C0")]
	public ComponentDataFromEntity FKPFOLDNAMO(int IJPBBHGPILF, bool CJMLCIMGOJJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61E74A0", Offset = "0x61E60A0", VA = "0x1861E74A0")]
	public EntityExistenceLookupByEntity ABPOGOCEAKN()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7580", Offset = "0x61E6180", VA = "0x1861E7580", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	protected JOPHCNGAJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class LDNKJIMFNLG : JOPHCNGAJAM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7590", Offset = "0x61E6190", VA = "0x1861E7590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	protected LDNKJIMFNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GKKHKHOFCGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class NDEIJMFBEJB : EntityCommandBufferSystem, IFEPGPCLCHO
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	protected NDEIJMFBEJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DOPHCONDDKL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PFNKGJFMOHL([In] TFrom BLKAHBIJBJO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OLEMLFOLFMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMAABMCHPNB(T BLKAHBIJBJO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct GJEGFFHMLAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes HNBFHICONON;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61E7290", Offset = "0x61E5E90", VA = "0x1861E7290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct MAHHJAKNDAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61E77E0", Offset = "0x61E63E0", VA = "0x1861E77E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct MGFKNLONJMK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType MFDHIGCIEED;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61E7880", Offset = "0x61E6480", VA = "0x1861E7880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct ABOELIHDHOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> KOMCCCIEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3730400", Offset = "0x372F000", VA = "0x183730400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LKADBHJJJPM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> BEGLJNBNMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct AILIELHAOEC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> KFNMOHEAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T BLKAHBIJBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer DFADGLGGNDA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37CFFD0", Offset = "0x37CEBD0", VA = "0x1837CFFD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct BBIPNEMONIB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DOPHCONDDKL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> OHHOFCHFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap ODKDNEPMNIA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct NJILGCOODBG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity HIDJMGOMKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> OHHOFCHFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int OJLPCDJLFLC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61E79A0", Offset = "0x61E65A0", VA = "0x1861E79A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct CHBEFJANOID<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ECIOGFECEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> GMDNJGJNEHB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct BLBNEGNKOIN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DOPHCONDDKL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> ACOAIGGIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> OHHOFCHFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap ODKDNEPMNIA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct ENEKGFNMJJL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLFCNFKAEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> MEDHHLLMJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> HOBBHJBLLOJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct EOBLJFILFPC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLFCNFKAEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> MEDHHLLMJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> HOBBHJBLLOJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x334D9E0", Offset = "0x334C5E0", VA = "0x18334D9E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct EHJGHHKCJAH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> GMDNJGJNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> BLDPFFCLHJF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3326BE0", Offset = "0x33257E0", VA = "0x183326BE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct AHHICCPAJKD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DOPHCONDDKL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> GMDNJGJNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> BLDPFFCLHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap ODKDNEPMNIA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BKGGIOEOLMP<T, TPredicate> : IJob where T : struct where TPredicate : struct, OLEMLFOLFMG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> GFGIGLNLKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> POHIMCNJBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate ODKDNEPMNIA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x47F0350", Offset = "0x47EEF50", VA = "0x1847F0350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IIHPAMPOOPG<T, TPredicate> : IJob where T : struct where TPredicate : struct, OLEMLFOLFMG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> HCCCIBAPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> GMDNJGJNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate ODKDNEPMNIA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HOAALKMGHCC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity DLFCNFKAEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> MEDHHLLMJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> BIMNMEECBJI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61E7380", Offset = "0x61E5F80", VA = "0x1861E7380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NDFBGIMKHGL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity DLFCNFKAEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> MEDHHLLMJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> BIMNMEECBJI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61E7910", Offset = "0x61E6510", VA = "0x1861E7910", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class GBILOBMIPFC
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CFKPLLJAFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2615EA0", Offset = "0x2614AA0", VA = "0x182615EA0")]
	public static bool NPCOLFEONML<T>(this NativeArray<Entity> MEDHHLLMJFE, EntityManager DIINGHOOBHL, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JMNGKJPFNJP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PDKMPKDOEGM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public PDKMPKDOEGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MCBOBHHKJIF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public MCBOBHHKJIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> MGBNOMLBILE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61E7410", Offset = "0x61E6010", VA = "0x1861E7410")]
	public JMNGKJPFNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CEHECPKHNLK
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EGFHFPEKKKG
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct NNPJANCLFOD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct IIOJHNFHEHP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal NNPJANCLFOD<TFrom> MJOMMKLGFIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> PHEFBNNJAMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct OHLNCOFILBD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct IIDLHBIKAOJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal OHLNCOFILBD<TFrom> MJOMMKLGFIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> PHEFBNNJAMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct AFGMECKALEO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct GEFKCNKOJKA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal AFGMECKALEO<TFrom> MJOMMKLGFIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> PHEFBNNJAMO;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct IHLMMDDODFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct PCGMLPOILNO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal IHLMMDDODFJ<TFrom> MJOMMKLGFIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> PHEFBNNJAMO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JIIKDBBDAMD
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CINPDAOLFDI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26178A0", Offset = "0x26164A0", VA = "0x1826178A0")]
	public static NativeList<T> GOPPEOLOOOI<T>(this NativeList<T> FKCJGBMKIAO, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2617920", Offset = "0x2616520", VA = "0x182617920")]
	public static NativeList<T> GOPPEOLOOOI<T>(this NativeArray<T> FKCJGBMKIAO, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DNHEALDELGE
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OIBEAKOOODI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2938B50", Offset = "0x2937750", VA = "0x182938B50")]
	[AIHCLDJOPKE]
	public static JobHandle AMLBEMJOBNA<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArrayAsync<Entity> KFNMOHEAFKD, NativeArrayAsync<T> KOMCCCIEHEA, [Optional] JobHandle NNFOCFECCAN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2938CB0", Offset = "0x29378B0", VA = "0x182938CB0")]
	[AIHCLDJOPKE]
	public static JobHandle AMLBEMJOBNA<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArrayAsync<Entity> KFNMOHEAFKD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2938A30", Offset = "0x2937630", VA = "0x182938A30")]
	[AIHCLDJOPKE]
	public static JobHandle AMLBEMJOBNA<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArray<Entity> KFNMOHEAFKD, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7C70", Offset = "0x61E6870", VA = "0x1861E7C70")]
	[AIHCLDJOPKE]
	public static JobHandle AMLBEMJOBNA(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArray<Entity> KFNMOHEAFKD, ComponentTypes HNBFHICONON, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DE0", Offset = "0x61E69E0", VA = "0x1861E7DE0")]
	[AIHCLDJOPKE]
	public static JobHandle AMLBEMJOBNA(this EntityCommandBufferSystem CJGLJBDEBOP, EntityCommandBuffer DFADGLGGNDA, NativeArray<Entity> KFNMOHEAFKD, ComponentTypes HNBFHICONON, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FHDEPFKOLMP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27C4A00", Offset = "0x27C3600", VA = "0x1827C4A00")]
	[AIHCLDJOPKE]
	public static JobHandle JHDOFKDEBOA<T>(this EntityCommandBufferSystem CJGLJBDEBOP, EntityCommandBuffer DFADGLGGNDA, EntityQuery LEPLDMMEAGJ, T BLKAHBIJBJO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class FHKKOPONEKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61E7100", Offset = "0x61E5D00", VA = "0x1861E7100")]
	[AIHCLDJOPKE]
	public static JobHandle FEIMDNODMGG(this EntityCommandBufferSystem CJGLJBDEBOP, NativeList<Entity> KFNMOHEAFKD, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61E7000", Offset = "0x61E5C00", VA = "0x1861E7000")]
	[AIHCLDJOPKE]
	public static JobHandle FEIMDNODMGG(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArrayAsync<Entity> KFNMOHEAFKD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KNMKNJKDEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x28598A0", Offset = "0x28584A0", VA = "0x1828598A0")]
	public static void DMJAHGFGLAO<T>(this EntityCommandBufferSystem CJGLJBDEBOP, EntityQuery LEPLDMMEAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2859E00", Offset = "0x2858A00", VA = "0x182859E00")]
	[AIHCLDJOPKE]
	public static JobHandle NMMCLKEHFDF<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeListAsync<Entity> KFNMOHEAFKD, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2859C70", Offset = "0x2858870", VA = "0x182859C70")]
	[AIHCLDJOPKE]
	public static JobHandle NMMCLKEHFDF<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArrayAsync<Entity> KFNMOHEAFKD, [Optional] JobHandle NNFOCFECCAN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KAAEKIDDGDI
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28532E0", Offset = "0x2851EE0", VA = "0x1828532E0")]
	[AIHCLDJOPKE]
	public static JobHandle GFNMGDAJHCJ<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArray<Entity> KFNMOHEAFKD, NativeArray<T> KOMCCCIEHEA, JobHandle NNFOCFECCAN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class NKLKHHJEPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2913B70", Offset = "0x2912770", VA = "0x182913B70")]
	[AIHCLDJOPKE]
	public static JobHandle JIFMCHDKLOP<T>(this EntityCommandBufferSystem CJGLJBDEBOP, NativeArray<Entity> KFNMOHEAFKD, T BLKAHBIJBJO, [Optional] JobHandle NNFOCFECCAN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2913AA0", Offset = "0x29126A0", VA = "0x182913AA0")]
	[AIHCLDJOPKE]
	public static JobHandle JIFMCHDKLOP<T>(this EntityCommandBufferSystem CJGLJBDEBOP, EntityCommandBuffer DFADGLGGNDA, NativeArray<Entity> KFNMOHEAFKD, T BLKAHBIJBJO, [Optional] JobHandle NNFOCFECCAN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ALCAHMNNCNO
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA7130", Offset = "0x2DA5D30", VA = "0x182DA7130")]
	public static NativeList<T> GOPPEOLOOOI<T>(NativeList<T> FKCJGBMKIAO, Allocator AIHLFFHGGIO) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class LMEHEMGGHBP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2881960", Offset = "0x2880560", VA = "0x182881960")]
	public static NativeArray<T> PCDHMODPAIL<T>(this NativeList<Entity> FKCJGBMKIAO, EntityManager DIINGHOOBHL, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2881420", Offset = "0x2880020", VA = "0x182881420")]
	public static NativeArray<T> PCDHMODPAIL<T>(this NativeArray<Entity> FKCJGBMKIAO, EntityManager DIINGHOOBHL, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7600", Offset = "0x61E6200", VA = "0x1861E7600")]
	public static NativeArray<Entity> PLEFNEFHAMG(this NativeArray<Entity> FKCJGBMKIAO, EntityManager DIINGHOOBHL, ComponentType MFDHIGCIEED, Allocator AIHLFFHGGIO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2881340", Offset = "0x287FF40", VA = "0x182881340")]
	public static NativeArray<T> FEACBFMNLMG<T>(this NativeArray<Entity> FKCJGBMKIAO, EntityManager DIINGHOOBHL, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FFFLCPGKHIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct KKJCHMMNBIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct HGFPBGOEIGI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KKJCHMMNBIH<TFrom> PHEFBNNJAMO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct FAGIGLDBLAE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct BOKHJPLAMKN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public FAGIGLDBLAE<TFrom> PHEFBNNJAMO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct BCIMLPMECBE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct MNHEINLOBEC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public BCIMLPMECBE<TFrom> PHEFBNNJAMO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> HCCCIBAPNKK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class BKOHPHDJMKJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FPABJEOPNPC
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct FCHNPHHNPHF : DOPHCONDDKL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EDFBEHLANDB;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61E6FF0", Offset = "0x61E5BF0", VA = "0x1861E6FF0")]
		[BurstCompatible]
		public Entity PFNKGJFMOHL([In] Entity BLKAHBIJBJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61E6FF0", Offset = "0x61E5BF0", VA = "0x1861E6FF0", Slot = "4")]
		private Entity JICJJEHPMEF([In] Entity BLKAHBIJBJO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class EOGHMLEJPII
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NJPJOCCKCMO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> GFGIGLNLKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KHIBFFFLEPJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> GFGIGLNLKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct NHFIHNIKKNP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> GFGIGLNLKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> HCCCIBAPNKK;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2724AF0", Offset = "0x27236F0", VA = "0x182724AF0")]
		public NativeListAsync<Entity> PMAABMCHPNB<TPredicate>() where TPredicate : struct, OLEMLFOLFMG<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2692CD0", Offset = "0x26918D0", VA = "0x182692CD0")]
	public static NHFIHNIKKNP<T> HCPOGJDNHKJ<T>(this NativeArrayAsync<Entity> MEDHHLLMJFE, NativeArrayAsync<T> FKCJGBMKIAO, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct
	{
		return default(NHFIHNIKKNP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MEODDOOCAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x28962E0", Offset = "0x2894EE0", VA = "0x1828962E0")]
	public static NativeListAsync<Entity> IOMPPJNFAMD<T, TPredicate>(this NativeArrayAsync<T> FKCJGBMKIAO, NativeArrayAsync<Entity> MEDHHLLMJFE, Allocator AIHLFFHGGIO = Allocator.TempJob) where T : struct where TPredicate : struct, OLEMLFOLFMG<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2896140", Offset = "0x2894D40", VA = "0x182896140")]
	private static NativeListAsync<Entity> FHMLAAKEAPO<T, TPredicate>(NativeArrayAsync<T> FMGPOBKGECH, NativeArrayAsync<Entity> MEDHHLLMJFE, int GFICJHOBPLH, Allocator AIHLFFHGGIO) where T : struct where TPredicate : struct, OLEMLFOLFMG<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class AHJDANHJFAF
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct EAPBOJPCDBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct JMAFFMDOLAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OJFGBNFCBDF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> HCCCIBAPNKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NLPHIKOEEKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator AIHLFFHGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> HCCCIBAPNKK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class IHOCHKIPMHD
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MGDPDEFHNJB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x289B220", Offset = "0x2899E20", VA = "0x18289B220")]
	public static NativeList<Entity> ILGMMHDBHFL<T>(this NativeArray<Entity> MEDHHLLMJFE, EntityManager DIINGHOOBHL, Allocator AIHLFFHGGIO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NMJDDDONPGN
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NGFEMFLBEMD
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct CDODCGLOAPO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> GBCEGNLFFAN;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public CDODCGLOAPO(NativeArray<TSrc> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public HCOKHAHOACF<TSrc, TValue> DJOLAODKNCA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HCOKHAHOACF<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct HCOKHAHOACF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> GBCEGNLFFAN;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public HCOKHAHOACF(NativeArray<TSrc> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public LAPKBAENPPP<TSrc, TValue, TSelector> NKPMODDLKGJ<TSelector>() where TSelector : struct, DOPHCONDDKL<TSrc, TValue>
		{
			return default(LAPKBAENPPP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct LAPKBAENPPP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DOPHCONDDKL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> GBCEGNLFFAN;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public LAPKBAENPPP(NativeArray<TSrc> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF83C0", Offset = "0x3BF6FC0", VA = "0x183BF83C0")]
		public JADBMHIOEKH<TSrc, TValue, TSelector> BPOEKBCDNGP()
		{
			return default(JADBMHIOEKH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct LHFEPBGHJBM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DOPHCONDDKL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> GBCEGNLFFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector CDFFMFINPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int PMIDLPOCCEE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3C1E5F0", Offset = "0x3C1D1F0", VA = "0x183C1E5F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int KGAKPAMIIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA512E0", Offset = "0xA4FEE0", VA = "0x180A512E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AMCFPGDCENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DE4E90", Offset = "0x1DE3A90", VA = "0x181DE4E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E680", Offset = "0x3C1D280", VA = "0x183C1E680")]
		public LHFEPBGHJBM(NativeArray<TSrc> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E5E0", Offset = "0x3C1D1E0", VA = "0x183C1E5E0")]
		public bool LFODMCIDFKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E500", Offset = "0x3C1D100", VA = "0x183C1E500")]
		private TSrc BLCGPNHGJDD(int CFPNJHJGBGM)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct JADBMHIOEKH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DOPHCONDDKL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LHFEPBGHJBM<TSrc, TValue, TSelector> BJBHGKEEGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue FEKNOPKACJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int FAFMJOHFKBE;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PLBNPNGNGLA DDAABOLABOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3ADEDF0", Offset = "0x3ADD9F0", VA = "0x183ADEDF0")]
			get
			{
				return default(PLBNPNGNGLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue BACOHAANMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, PLBNPNGNGLA range) DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3ADEF70", Offset = "0x3ADDB70", VA = "0x183ADEF70")]
			get
			{
				return default((TValue, PLBNPNGNGLA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF050", Offset = "0x3ADDC50", VA = "0x183ADF050")]
		public JADBMHIOEKH(NativeArray<TSrc> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3784F90", Offset = "0x3783B90", VA = "0x183784F90")]
		public JADBMHIOEKH<TSrc, TValue, TSelector> EABNIEGMBCK()
		{
			return default(JADBMHIOEKH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEE30", Offset = "0x3ADDA30", VA = "0x183ADEE30")]
		public bool LFODMCIDFKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x290C640", Offset = "0x290B240", VA = "0x18290C640")]
	public static CDODCGLOAPO<T> OCKKJAFBIAF<T>(this NativeList<T> GPOHBJENHCE) where T : struct
	{
		return default(CDODCGLOAPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
	public static CDODCGLOAPO<T> OCKKJAFBIAF<T>(this NativeArray<T> GBCEGNLFFAN) where T : struct
	{
		return default(CDODCGLOAPO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class IIBECGHMINB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JGGLGEHGDFI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly GBCEGNLFFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FAFMJOHFKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int EOMCBBGJNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T FEKNOPKACJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T GMMKLOLNIEF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public PLBNPNGNGLA DDAABOLABOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x334CDE0", Offset = "0x334B9E0", VA = "0x18334CDE0")]
			get
			{
				return default(PLBNPNGNGLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T BACOHAANMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x334CDC0", Offset = "0x334B9C0", VA = "0x18334CDC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, PLBNPNGNGLA) DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB440", Offset = "0x3AFA040", VA = "0x183AFB440")]
			get
			{
				return default((T, PLBNPNGNGLA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3AFB580", Offset = "0x3AFA180", VA = "0x183AFB580")]
		public JGGLGEHGDFI(NativeArray<T> GBCEGNLFFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3AFAFA0", Offset = "0x3AF9BA0", VA = "0x183AFAFA0")]
		public JGGLGEHGDFI<T> EABNIEGMBCK()
		{
			return default(JGGLGEHGDFI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AFAFE0", Offset = "0x3AF9BE0", VA = "0x183AFAFE0")]
		public bool LFODMCIDFKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x25A40C0", Offset = "0x25A2CC0", VA = "0x1825A40C0")]
		public ENOMMNGIBAP<T, TComparer> LIAJODIEHHN<TComparer>([Optional] TComparer IGGEEDKFPAJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(ENOMMNGIBAP<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ENOMMNGIBAP<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly GBCEGNLFFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int FAFMJOHFKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int EOMCBBGJNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T FEKNOPKACJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T GMMKLOLNIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer IGGEEDKFPAJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public PLBNPNGNGLA DDAABOLABOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x334CDE0", Offset = "0x334B9E0", VA = "0x18334CDE0")]
			get
			{
				return default(PLBNPNGNGLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T BACOHAANMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x334CDC0", Offset = "0x334B9C0", VA = "0x18334CDC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x334CFD0", Offset = "0x334BBD0", VA = "0x18334CFD0")]
		public ENOMMNGIBAP(NativeArray<T>.ReadOnly GBCEGNLFFAN, TComparer IGGEEDKFPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x334CDF0", Offset = "0x334B9F0", VA = "0x18334CDF0")]
		public bool LFODMCIDFKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x280C0F0", Offset = "0x280ACF0", VA = "0x18280C0F0")]
	public static JGGLGEHGDFI<T> BPOEKBCDNGP<T>(this NativeArray<T> GBCEGNLFFAN) where T : struct
	{
		return default(JGGLGEHGDFI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface MHEKDFICEEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class CMKJGGJKJOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct MDPDBCKGMEI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KCDMEMBIBDF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MDPDBCKGMEI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x36F4450", Offset = "0x36F3050", VA = "0x1836F4450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public KCDMEMBIBDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B664F0", Offset = "0x3B650F0", VA = "0x183B664F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B666A0", Offset = "0x3B652A0", VA = "0x183B666A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> EMKPFHNOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream LHFBIKKBMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream PGDLGONNBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf DEABEEHMNFH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int AMCFPGDCENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3E13830", Offset = "0x3E12430", VA = "0x183E13830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3E13870", Offset = "0x3E12470", VA = "0x183E13870", Slot = "4")]
	[IteratorStateMachine(typeof(MDPDBCKGMEI<>.KCDMEMBIBDF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3E13960", Offset = "0x3E12560", VA = "0x183E13960", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct MPOPBGMEDIG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] KLIMJJKAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf DEABEEHMNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream LHFBIKKBMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream HIACOLMPFBE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EA8370", Offset = "0x3EA6F70", VA = "0x183EA8370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LJHFAEHCIAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream LHFBIKKBMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream PGDLGONNBON;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61E75C0", Offset = "0x61E61C0", VA = "0x1861E75C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct OBEFGEMDCEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] KLIMJJKAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream LHFBIKKBMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream HIACOLMPFBE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B40", Offset = "0x61E6740", VA = "0x1861E7B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class HMGLNIIONDH
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class MPLKPKPLOCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum FPACJAKGCCB
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class LMFCIMCHABL
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class ALONICFNKBO
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ALONICFNKBO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
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
