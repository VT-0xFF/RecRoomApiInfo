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
using RecRoom;
using Unity.Burst;
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7137DB0", Offset = "0x71371B0", VA = "0x187137DB0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ONAIEHJBKEH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MJMELJIEOEP AFAHLPCLAHO
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
public interface ALMFLGMEBOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIOILPFFBPB(Entity DGPOIOLCNNN, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAOEJEIGNLB(Entity DGPOIOLCNNN, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOICNIKBOCK(Entity DGPOIOLCNNN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CJFBPLENHAB<TComponentData, TValue> : BFHLOEKNMLN<TValue>, IDisposable where TComponentData : struct, ONAIEHJBKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class BIOPHOJCGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> CECMFLAILAL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MKHKOEAGNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x39C69D0", Offset = "0x39C5DD0", VA = "0x1839C69D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x53D7F80", Offset = "0x53D7380", VA = "0x1853D7F80")]
		public bool MLBCPAFLHOA([Out] TValue HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x53D7D90", Offset = "0x53D7190", VA = "0x1853D7D90")]
		public void EBDKDKCDLND(object CMNJCPJBHGE, TValue HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x53D7CD0", Offset = "0x53D70D0", VA = "0x1853D7CD0")]
		public bool BDKJEBALGLD(object CMNJCPJBHGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53D7E80", Offset = "0x53D7280", VA = "0x1853D7E80")]
		public int GLPGCKAPGKN(object CMNJCPJBHGE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x53D8090", Offset = "0x53D7490", VA = "0x1853D8090")]
		public BIOPHOJCGAC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<BIOPHOJCGAC> FOCDFNAEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BGDPNJNNFBB<MJMELJIEOEP, BIOPHOJCGAC> IHCLFAIBCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager PKOBGBCOJNG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58FE710", Offset = "0x58FDB10", VA = "0x1858FE710")]
	public CJFBPLENHAB(EntityManager PKOBGBCOJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58FE070", Offset = "0x58FD470", VA = "0x1858FE070", Slot = "4")]
	public void DIOILPFFBPB(Entity DGPOIOLCNNN, object CMNJCPJBHGE, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x58FE3E0", Offset = "0x58FD7E0", VA = "0x1858FE3E0", Slot = "5")]
	public bool FAOEJEIGNLB(Entity DGPOIOLCNNN, object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58FE5F0", Offset = "0x58FD9F0", VA = "0x1858FE5F0", Slot = "6")]
	public bool MLBCPAFLHOA(Entity DGPOIOLCNNN, [Out] TValue HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58FE2C0", Offset = "0x58FD6C0", VA = "0x1858FE2C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58FDF80", Offset = "0x58FD380", VA = "0x1858FDF80")]
	private void CHCKNMLDIAN(BIOPHOJCGAC CAFBGGJFJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58FE200", Offset = "0x58FD600", VA = "0x1858FE200")]
	private bool DKEFBPKIAGA(Entity DGPOIOLCNNN, [Out] MJMELJIEOEP KADPKBIGPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x58FE2E0", Offset = "0x58FD6E0", VA = "0x1858FE2E0")]
	private void EDLGCDHCKOD(Entity DGPOIOLCNNN, MJMELJIEOEP KADPKBIGPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58FE050", Offset = "0x58FD450", VA = "0x1858FE050")]
	private bool CODDIGCNENC(MJMELJIEOEP KADPKBIGPFN, [Out] BIOPHOJCGAC CAFBGGJFJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58FDE50", Offset = "0x58FD250", VA = "0x1858FDE50")]
	private BIOPHOJCGAC AAMLMGDFPON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFHLOEKNMLN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIOILPFFBPB(Entity DGPOIOLCNNN, object CMNJCPJBHGE, TValue HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAOEJEIGNLB(Entity DGPOIOLCNNN, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLBCPAFLHOA(Entity DGPOIOLCNNN, [Out] TValue HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MJMELJIEOEP : BCFJABJPHMG, IEquatable<MJMELJIEOEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly MJMELJIEOEP GBDBCKKFJEP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FALKEIDFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7138400", Offset = "0x7137800", VA = "0x187138400", Slot = "8")]
	public bool Equals(MJMELJIEOEP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7138450", Offset = "0x7137850", VA = "0x187138450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KJKHPHGEMNP<THasTokensTag> : ALMFLGMEBOA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, MJMELJIEOEP> EJOPGOKNOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> FOCDFNAEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BGDPNJNNFBB<MJMELJIEOEP, HashSet<object>> IHCLFAIBCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager PKOBGBCOJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem CLENNNIACFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4694590", Offset = "0x4693990", VA = "0x184694590")]
	public KJKHPHGEMNP(EntityManager PKOBGBCOJNG, EntityCommandBufferSystem CLENNNIACFJ, GKOKEEMOOFG FMEMJIGHNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4692A90", Offset = "0x4691E90", VA = "0x184692A90", Slot = "4")]
	public bool DIOILPFFBPB(Entity DGPOIOLCNNN, object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4693A30", Offset = "0x4692E30", VA = "0x184693A30", Slot = "5")]
	public bool FAOEJEIGNLB(Entity DGPOIOLCNNN, object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4691D60", Offset = "0x4691160", VA = "0x184691D60", Slot = "6")]
	public bool AOICNIKBOCK(Entity DGPOIOLCNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4691ED0", Offset = "0x46912D0", VA = "0x184691ED0", Slot = "8")]
	public bool AOICNIKBOCK(MJMELJIEOEP KADPKBIGPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4693190", Offset = "0x4692590", VA = "0x184693190", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x46923E0", Offset = "0x46917E0", VA = "0x1846923E0")]
	private void CHCKNMLDIAN(HashSet<object> CAFBGGJFJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4692E50", Offset = "0x4692250", VA = "0x184692E50")]
	private bool DKEFBPKIAGA(Entity DGPOIOLCNNN, [Out] MJMELJIEOEP KADPKBIGPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4691F90", Offset = "0x4691390", VA = "0x184691F90")]
	private bool AOOIIFFIGFO(Entity DGPOIOLCNNN, [Out] MJMELJIEOEP KADPKBIGPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4693410", Offset = "0x4692810", VA = "0x184693410")]
	private void ELFDIGGEIFJ(Entity DGPOIOLCNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4694150", Offset = "0x4693550", VA = "0x184694150")]
	private void MMOHJEJAIBK(Entity DGPOIOLCNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4692450", Offset = "0x4691850", VA = "0x184692450")]
	private void COLLOLPANLB(Entity DGPOIOLCNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46933A0", Offset = "0x46927A0", VA = "0x1846933A0")]
	private void EDLGCDHCKOD(Entity DGPOIOLCNNN, MJMELJIEOEP KADPKBIGPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4694090", Offset = "0x4693490", VA = "0x184694090")]
	private bool JAGGCDHCIHD(MJMELJIEOEP KADPKBIGPFN, [Out] HashSet<object> CAFBGGJFJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4691960", Offset = "0x4690D60", VA = "0x184691960")]
	private HashSet<object> AAMLMGDFPON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OIKCPCOLNIK
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GFFPEEPKMNI : EONFFEENFPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7137FC0", Offset = "0x71373C0", VA = "0x187137FC0")]
	public float NIMJEGACONA([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7137FC0", Offset = "0x71373C0", VA = "0x187137FC0", Slot = "4")]
	private float LFMKFKLJNJO([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CFIEPNKFMOG : EONFFEENFPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7137A50", Offset = "0x7136E50", VA = "0x187137A50")]
	public float NIMJEGACONA([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7137A50", Offset = "0x7136E50", VA = "0x187137A50", Slot = "4")]
	private float LFMKFKLJNJO([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JANKJPFPJDH : EONFFEENFPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xAA42E0", Offset = "0xAA36E0", VA = "0x180AA42E0")]
	public float NIMJEGACONA([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xAA42E0", Offset = "0xAA36E0", VA = "0x180AA42E0", Slot = "4")]
	private float LFMKFKLJNJO([In] float3 HCPAOILCJCB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JFHMJLEOCOF : EONFFEENFPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B42ED0", VA = "0x181B43AD0")]
	public int NIMJEGACONA([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B42ED0", VA = "0x181B43AD0", Slot = "4")]
	private int BNBPEKEPKBL([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ICGJILNACOO : EONFFEENFPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7138080", Offset = "0x7137480", VA = "0x187138080")]
	public int NIMJEGACONA([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7138080", Offset = "0x7137480", VA = "0x187138080", Slot = "4")]
	private int BNBPEKEPKBL([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct INLAKFDLIBJ : EONFFEENFPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA6D980", Offset = "0xA6CD80", VA = "0x180A6D980")]
	public int NIMJEGACONA([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA6D980", Offset = "0xA6CD80", VA = "0x180A6D980", Slot = "4")]
	private int BNBPEKEPKBL([In] int3 HCPAOILCJCB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ENAJODIICEO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	public ENAJODIICEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ICMPKEPKJGI : SystemBase, FCJOFHJCDEE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7138170", Offset = "0x7137570", VA = "0x187138170")]
	public JobHandle JOHDPBAKALN(ReadOnlySpan<int> EGLODLDJNPJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3090330", Offset = "0x308F730", VA = "0x183090330")]
	public void LDIGEELFPGG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x308FED0", Offset = "0x308F2D0", VA = "0x18308FED0")]
	public JobHandle LDIGEELFPGG<T>(JobHandle KADPKBIGPFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71381C0", Offset = "0x71375C0", VA = "0x1871381C0")]
	public JobHandle LDIGEELFPGG(ReadOnlySpan<int> EGLODLDJNPJ, JobHandle KADPKBIGPFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x308FC30", Offset = "0x308F030", VA = "0x18308FC30")]
	public JobHandle KDKHKHANHCL<T>(JobHandle KADPKBIGPFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7138090", Offset = "0x7137490", VA = "0x187138090")]
	public ComponentDataFromEntity CBCEEDNLPKG(int MMGNMHOEBAO, bool LKFNACIIFML = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7138150", Offset = "0x7137550", VA = "0x187138150")]
	public EntityExistenceLookupByEntity EJIJNGGKEMB()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7138230", Offset = "0x7137630", VA = "0x187138230", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	protected ICMPKEPKJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IBPFAMOGPMK : ICMPKEPKJGI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7138050", Offset = "0x7137450", VA = "0x187138050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	protected IBPFAMOGPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GPEPFJPFDDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IPKAJNLNPCI : EntityCommandBufferSystem, FCJOFHJCDEE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	protected IPKAJNLNPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EONFFEENFPA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NIMJEGACONA([In] TFrom HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OJLHDFLIADM<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHCLGIOHEEC(T HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct FCEGFDCIAJK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes HJBOMLAKIOP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7137DD0", Offset = "0x71371D0", VA = "0x187137DD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct ECBENKFLGCH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7137C80", Offset = "0x7137080", VA = "0x187137C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct IBNBKIELAJP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType KNKDDEKJOCO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7137FD0", Offset = "0x71373D0", VA = "0x187137FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct IJBOHMCFEJC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> JGCOLLOOLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43504E0", Offset = "0x434F8E0", VA = "0x1843504E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct BNHMNHKLBIB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> KLODBELJCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct DNFINBJNFMI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T HCPAOILCJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer JAIMCGPFDNO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E87570", Offset = "0x5E86970", VA = "0x185E87570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct LFBAOBINOOL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EONFFEENFPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> KMELJNALKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct FPEPKGDPJNN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity PBGNNNMNCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> KMELJNALKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int PPDCFPPGEKB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7137EC0", Offset = "0x71372C0", VA = "0x187137EC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct ILLFGLJHDCB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DPAFONKPPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> ADOFBPOHCLA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct OCOCFHCHFGP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EONFFEENFPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> DPNDAJPDJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> KMELJNALKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct IKLLHGHAELC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GIDDLGHLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> DAGDGCFIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> IKFLGFLNBFM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct HIEABMIDIIB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GIDDLGHLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DAGDGCFIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> IKFLGFLNBFM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4255BF0", Offset = "0x4254FF0", VA = "0x184255BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct GCIGLJBNANK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> ADOFBPOHCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> ODFNNAJIIMK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41864C0", Offset = "0x41858C0", VA = "0x1841864C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct DPMFCMJCCCF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : EONFFEENFPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> ADOFBPOHCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> ODFNNAJIIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct JOIBNNCKMJD<T, TPredicate> : IJob where T : struct where TPredicate : struct, OJLHDFLIADM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CCJBEHOHHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> AIKKEDKFOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ECNBMNPJBIP<T, TPredicate> : IJob where T : struct where TPredicate : struct, OJLHDFLIADM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> JBIGBCGNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> ADOFBPOHCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JOMEIMPAFAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity GIDDLGHLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> DAGDGCFIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> CJLPCGMDPBC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7138240", Offset = "0x7137640", VA = "0x187138240", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CFAFHAAMPDM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity GIDDLGHLMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DAGDGCFIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> CJLPCGMDPBC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x71379C0", Offset = "0x7136DC0", VA = "0x1871379C0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JNEDJALCPGL
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BAGNFMGLGFI
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBBBE0", Offset = "0x2DBAFE0", VA = "0x182DBBBE0")]
	public static bool EPOMJMLFBCD<T>(this NativeArray<Entity> DAGDGCFIJJL, EntityManager PKOBGBCOJNG, Allocator MEFLJHAPKJF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EKIHEAPKFPB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BPHCMDNGDEJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public BPHCMDNGDEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FBPHLOLCEGM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public FBPHLOLCEGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> CLALOBAIJIB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7137D20", Offset = "0x7137120", VA = "0x187137D20")]
	public EKIHEAPKFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DJODBKHGLEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KLFINPLHOBM
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct IJDIECMNBIK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct HDEPIAEBBGF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal IJDIECMNBIK<TFrom> AMMKPAGCALK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> DOELFDCMLHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct LBIECLEHIIG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct CDLJPMBNKOI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal LBIECLEHIIG<TFrom> AMMKPAGCALK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> DOELFDCMLHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct EEOHJEDJFBH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AGIGGPPAHMJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal EEOHJEDJFBH<TFrom> AMMKPAGCALK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> DOELFDCMLHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EEDFLLANOLN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct OGLNNKMAPEM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal EEDFLLANOLN<TFrom> AMMKPAGCALK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> DOELFDCMLHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CJLKHFJNEOH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NFFAEOLFOEH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x31D7750", Offset = "0x31D6B50", VA = "0x1831D7750")]
	public static NativeList<T> FGGKIFMKEOD<T>(this NativeArray<T> JBEDJDHJIDG, Allocator MEFLJHAPKJF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OBHHPOHDOLA
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NNEJCHDLGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x31E6130", Offset = "0x31E5530", VA = "0x1831E6130")]
	[NCACIAINNNE]
	public static JobHandle PHEBIEJJPDJ<T>(this EntityCommandBufferSystem CLENNNIACFJ, NativeArrayAsync<Entity> NNNALCFDKMF, NativeArrayAsync<T> JGCOLLOOLHL, [Optional] JobHandle BGAGLBHPLFA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31E62B0", Offset = "0x31E56B0", VA = "0x1831E62B0")]
	[NCACIAINNNE]
	public static JobHandle PHEBIEJJPDJ<T>(this EntityCommandBufferSystem CLENNNIACFJ, NativeArrayAsync<Entity> NNNALCFDKMF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31E6000", Offset = "0x31E5400", VA = "0x1831E6000")]
	[NCACIAINNNE]
	public static JobHandle PHEBIEJJPDJ<T>(this EntityCommandBufferSystem CLENNNIACFJ, NativeArray<Entity> NNNALCFDKMF, [Optional] JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71384A0", Offset = "0x71378A0", VA = "0x1871384A0")]
	[NCACIAINNNE]
	public static JobHandle PHEBIEJJPDJ(this EntityCommandBufferSystem CLENNNIACFJ, NativeArray<Entity> NNNALCFDKMF, ComponentTypes HJBOMLAKIOP, [Optional] JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7138610", Offset = "0x7137A10", VA = "0x187138610")]
	[NCACIAINNNE]
	public static JobHandle PHEBIEJJPDJ(this EntityCommandBufferSystem CLENNNIACFJ, EntityCommandBuffer JAIMCGPFDNO, NativeArray<Entity> NNNALCFDKMF, ComponentTypes HJBOMLAKIOP, [Optional] JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LMIBGLOGHDG
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x311DA30", Offset = "0x311CE30", VA = "0x18311DA30")]
	[NCACIAINNNE]
	public static JobHandle HLKMJEEIEOH<T>(this EntityCommandBufferSystem CLENNNIACFJ, EntityCommandBuffer JAIMCGPFDNO, EntityQuery KMAGGAOJLCG, T HCPAOILCJCB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OFKONNDKPKB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7138860", Offset = "0x7137C60", VA = "0x187138860")]
	[NCACIAINNNE]
	public static JobHandle HDIKFKHJMKN(this EntityCommandBufferSystem CLENNNIACFJ, NativeList<Entity> NNNALCFDKMF, [Optional] JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7138760", Offset = "0x7137B60", VA = "0x187138760")]
	[NCACIAINNNE]
	public static JobHandle HDIKFKHJMKN(this EntityCommandBufferSystem CLENNNIACFJ, NativeArrayAsync<Entity> NNNALCFDKMF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EIJKKDDBLLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EJEJCIFPJPG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA0D0", Offset = "0x2EB94D0", VA = "0x182EBA0D0")]
	[NCACIAINNNE]
	public static JobHandle NDMPCBEFJEC<T>(this EntityCommandBufferSystem CLENNNIACFJ, NativeArray<Entity> NNNALCFDKMF, NativeArray<T> JGCOLLOOLHL, JobHandle BGAGLBHPLFA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CCAOBIGFFGP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E38A60", Offset = "0x2E37E60", VA = "0x182E38A60")]
	[NCACIAINNNE]
	public static JobHandle JDMGMIGDEFP<T>(this EntityCommandBufferSystem CLENNNIACFJ, NativeArray<Entity> NNNALCFDKMF, T HCPAOILCJCB, [Optional] JobHandle BGAGLBHPLFA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E38980", Offset = "0x2E37D80", VA = "0x182E38980")]
	[NCACIAINNNE]
	public static JobHandle JDMGMIGDEFP<T>(this EntityCommandBufferSystem CLENNNIACFJ, EntityCommandBuffer JAIMCGPFDNO, NativeArray<Entity> NNNALCFDKMF, T HCPAOILCJCB, [Optional] JobHandle BGAGLBHPLFA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LOLNJPHAOOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CPILABDODEG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E67BC0", Offset = "0x2E66FC0", VA = "0x182E67BC0")]
	public static NativeArray<T> DGALPNJINJM<T>(this NativeArray<Entity> JBEDJDHJIDG, EntityManager PKOBGBCOJNG, Allocator MEFLJHAPKJF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7137AA0", Offset = "0x7136EA0", VA = "0x187137AA0")]
	public static NativeArray<Entity> FBLJGHNIMEI(this NativeArray<Entity> JBEDJDHJIDG, EntityManager PKOBGBCOJNG, ComponentType KNKDDEKJOCO, Allocator MEFLJHAPKJF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E67AE0", Offset = "0x2E66EE0", VA = "0x182E67AE0")]
	public static NativeArray<T> BGGBGPHJIEJ<T>(this NativeArray<Entity> JBEDJDHJIDG, EntityManager PKOBGBCOJNG, Allocator MEFLJHAPKJF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BLPLFGNNFGH
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct LPOOJEGNJKP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct LAOHLHKKFAP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public LPOOJEGNJKP<TFrom> DOELFDCMLHC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FJBIMKPGJHO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct BGELNPNOCPJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FJBIMKPGJHO<TFrom> DOELFDCMLHC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JGOJJCICHFC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NJNFKONOJAB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JGOJJCICHFC<TFrom> DOELFDCMLHC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> JBIGBCGNBIF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IOPNMIAJDMD
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LFIIKPNHMKK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KLHHIIGLEBL : EONFFEENFPA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71382D0", Offset = "0x71376D0", VA = "0x1871382D0")]
		[BurstCompatible]
		public Entity NIMJEGACONA([In] Entity HCPAOILCJCB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71382D0", Offset = "0x71376D0", VA = "0x1871382D0", Slot = "4")]
		private Entity BFHBHBFOPJD([In] Entity HCPAOILCJCB)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FDIMENFLOHP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IKPAJJDPIBN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> CCJBEHOHHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DJHOLFGBJPG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> CCJBEHOHHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HFIBIBNANEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> CCJBEHOHHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> JBIGBCGNBIF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MJPAOAJNANF
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DCGAEBDEBME
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct EGPLOPPAJOK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct AKCBEGOPNCJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct HMAEABJNDPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> JBIGBCGNBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct AOAALIBBIPC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MEFLJHAPKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> JBIGBCGNBIF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IAACKCJNKPC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CJIMIOPJBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2E46F00", Offset = "0x2E46300", VA = "0x182E46F00")]
	public static NativeList<Entity> CILDKCLCDDN<T>(this NativeArray<Entity> DAGDGCFIJJL, EntityManager PKOBGBCOJNG, Allocator MEFLJHAPKJF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class KNFNJHGIDOM
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FOEBPEENAKE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct AOLGBFBDIKH<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> CHDCMIMONFN;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public AOLGBFBDIKH(NativeArray<TSrc> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public KBKCKDAFEGI<TSrc, TValue> MAEOBLEDKGJ<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(KBKCKDAFEGI<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct KBKCKDAFEGI<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> CHDCMIMONFN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public KBKCKDAFEGI(NativeArray<TSrc> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public DOAHALHKGDI<TSrc, TValue, TSelector> ELDNMJGFBJL<TSelector>() where TSelector : struct, EONFFEENFPA<TSrc, TValue>
		{
			return default(DOAHALHKGDI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct DOAHALHKGDI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EONFFEENFPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> CHDCMIMONFN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public DOAHALHKGDI(NativeArray<TSrc> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AA60", Offset = "0x5E89E60", VA = "0x185E8AA60")]
		public DFLLIKFICLA<TSrc, TValue, TSelector> MNBLLNODCFF()
		{
			return default(DFLLIKFICLA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct OLMNOHCHDBJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, EONFFEENFPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CHDCMIMONFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector ECJKENICCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int IIACLAMOIEE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4B94D40", Offset = "0x4B94140", VA = "0x184B94D40")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MCCLHKLCIBG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C950", Offset = "0xA9BD50", VA = "0x180A9C950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EPMKILCCCOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4B94E20", Offset = "0x4B94220", VA = "0x184B94E20")]
		public OLMNOHCHDBJ(NativeArray<TSrc> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4B94E10", Offset = "0x4B94210", VA = "0x184B94E10")]
		public bool KFHHDPCHMMF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4B94C40", Offset = "0x4B94040", VA = "0x184B94C40")]
		private TSrc GMAAEMJEINI(int IBIAGDBMPOH)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4B94D80", Offset = "0x4B94180", VA = "0x184B94D80")]
		private TValue IKNDKJKEBIM()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct DFLLIKFICLA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EONFFEENFPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private OLMNOHCHDBJ<TSrc, TValue, TSelector> LGHHOJKALAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue CFIHAHOCBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GDCLLKFPEAF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IGMINMCGFIO OJJEFHIOFLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AEC0", Offset = "0x5E6A2C0", VA = "0x185E6AEC0")]
			get
			{
				return default(IGMINMCGFIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue HNMNLFKEPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, IGMINMCGFIO range) DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AC60", Offset = "0x5E6A060", VA = "0x185E6AC60")]
			get
			{
				return default((TValue, IGMINMCGFIO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AF00", Offset = "0x5E6A300", VA = "0x185E6AF00")]
		public DFLLIKFICLA(NativeArray<TSrc> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3CBABC0", Offset = "0x3CB9FC0", VA = "0x183CBABC0")]
		public DFLLIKFICLA<TSrc, TValue, TSelector> JDJKPBEKJIJ()
		{
			return default(DFLLIKFICLA<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AD40", Offset = "0x5E6A140", VA = "0x185E6AD40")]
		public bool KFHHDPCHMMF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x305E190", Offset = "0x305D590", VA = "0x18305E190")]
	public static AOLGBFBDIKH<T> LMBOECLBMJM<T>(this NativeList<T> CECMFLAILAL) where T : struct
	{
		return default(AOLGBFBDIKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
	public static AOLGBFBDIKH<T> LMBOECLBMJM<T>(this NativeArray<T> CHDCMIMONFN) where T : struct
	{
		return default(AOLGBFBDIKH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class HBEHLOOHEAG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct AFPFMHAKIDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly CHDCMIMONFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int GDCLLKFPEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BLBODBGBDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T CFIHAHOCBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T PBLODADJDPE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IGMINMCGFIO OJJEFHIOFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x40A49C0", Offset = "0x40A3DC0", VA = "0x1840A49C0")]
			get
			{
				return default(IGMINMCGFIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T HNMNLFKEPKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3D3ACE0", Offset = "0x3D3A0E0", VA = "0x183D3ACE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, IGMINMCGFIO) DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x41D0810", Offset = "0x41CFC10", VA = "0x1841D0810")]
			get
			{
				return default((T, IGMINMCGFIO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x41D0E10", Offset = "0x41D0210", VA = "0x1841D0E10")]
		public AFPFMHAKIDI(NativeArray<T> CHDCMIMONFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x41D0990", Offset = "0x41CFD90", VA = "0x1841D0990")]
		public AFPFMHAKIDI<T> JDJKPBEKJIJ()
		{
			return default(AFPFMHAKIDI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x41D0BB0", Offset = "0x41CFFB0", VA = "0x1841D0BB0")]
		public bool KFHHDPCHMMF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x297C380", Offset = "0x297B780", VA = "0x18297C380")]
		public FKAPBKCKEJB<T, TComparer> BLPPPIGPNOP<TComparer>([Optional] TComparer CHHLDJFODPF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(FKAPBKCKEJB<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FKAPBKCKEJB<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly CHDCMIMONFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int GDCLLKFPEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int BLBODBGBDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T CFIHAHOCBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T PBLODADJDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer CHHLDJFODPF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IGMINMCGFIO OJJEFHIOFLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x40A49C0", Offset = "0x40A3DC0", VA = "0x1840A49C0")]
			get
			{
				return default(IGMINMCGFIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T HNMNLFKEPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3D3ACE0", Offset = "0x3D3A0E0", VA = "0x183D3ACE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40A49D0", Offset = "0x40A3DD0", VA = "0x1840A49D0")]
		public FKAPBKCKEJB(NativeArray<T>.ReadOnly CHDCMIMONFN, TComparer CHHLDJFODPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x40A47D0", Offset = "0x40A3BD0", VA = "0x1840A47D0")]
		public bool KFHHDPCHMMF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3074930", Offset = "0x3073D30", VA = "0x183074930")]
	public static AFPFMHAKIDI<T> MNBLLNODCFF<T>(this NativeArray<T> CHDCMIMONFN) where T : struct
	{
		return default(AFPFMHAKIDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JNIOBKFHOAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DLBJNMGNCOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct CMMBBGAENPI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JENLPFDHCGA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CMMBBGAENPI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4101D20", Offset = "0x4101120", VA = "0x184101D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public JENLPFDHCGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x457F8F0", Offset = "0x457ECF0", VA = "0x18457F8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x457FAD0", Offset = "0x457EED0", VA = "0x18457FAD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> OPPGNMIFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream CLFCADGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream OHBCIBCEFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf PEEBEBLBIKF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5902A90", Offset = "0x5901E90", VA = "0x185902A90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5902AD0", Offset = "0x5901ED0", VA = "0x185902AD0", Slot = "4")]
	[IteratorStateMachine(typeof(CMMBBGAENPI<>.JENLPFDHCGA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5902BD0", Offset = "0x5901FD0", VA = "0x185902BD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct CJKBCBAGJLE<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] CELIBNPACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf PEEBEBLBIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream CLFCADGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream CMJMCCLKGNC;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x58FEB40", Offset = "0x58FDF40", VA = "0x1858FEB40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct COFAMEEBAGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream CLFCADGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream OHBCIBCEFHP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7137A60", Offset = "0x7136E60", VA = "0x187137A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct MGDKABPJIDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] CELIBNPACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream CLFCADGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream CMJMCCLKGNC;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71382E0", Offset = "0x71376E0", VA = "0x1871382E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KNMKDPJLANN
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BMBKGMCOLIL
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum JMABMCCMHEE
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class BNBHKINKNCK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EIEKKDBLJLC
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EIEKKDBLJLC()
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
