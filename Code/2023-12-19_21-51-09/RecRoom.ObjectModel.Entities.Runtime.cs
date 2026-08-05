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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE5F20", Offset = "0x5EE4B20", VA = "0x185EE5F20")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class INPDGECPDIL<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] KMBDICCIJCM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2109A30", Offset = "0x2108630", VA = "0x182109A30")]
	public static void PCBDPIFIJEO<TField>(int DCGGFHOCGGH, string JEICAPDKHKI, FNMNEFCBFDG AAEGNEKBLGJ, [Out] JHNDGMMMKCP<TField> IEIEKFIPLEG) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2107030", Offset = "0x2105C30", VA = "0x182107030")]
	public static void OIKJLKNBACN<TField>(int DCGGFHOCGGH, string JEICAPDKHKI, [Out] IGEKDKKOPBK<TField> DKLHENCIMJI) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class IKGEOIAFJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE62A0", Offset = "0x5EE4EA0", VA = "0x185EE62A0")]
	public static FieldInfo[] EHPJGLFCBOC(Type OMKEAAPIABA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EIHNGEOMJLH<View, Data> : DKLNNALIHAG where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType ALGCGAKJLCH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type KDPDNPENBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3176220", Offset = "0x3174E20", VA = "0x183176220", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int BKBGNPOEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3178710", Offset = "0x3177310", VA = "0x183178710", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31785F0", Offset = "0x31771F0", VA = "0x1831785F0")]
	public Data KHHECFMEFNP(Entity BMHPCOMOJJA)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View CIKNKCBCJDH(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CAF0", Offset = "0x2E1B6F0", VA = "0x182E1CAF0", Slot = "14")]
	public override T CIKNKCBCJDH<T>(Entity BMHPCOMOJJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	protected EIHNGEOMJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class DKLNNALIHAG : FNMNEFCBFDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle MPCHFKLCKLB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager MOAHEHFBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x123D720", Offset = "0x123C320", VA = "0x18123D720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type KDPDNPENBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int BKBGNPOEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type PNGNOEOGFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x962440", Offset = "0x961040", VA = "0x180962440", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int JFALAKNHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EE56B0", Offset = "0x5EE42B0", VA = "0x185EE56B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private JPCOIOCHKOG[] IGLMGJLDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7030", Offset = "0x3CF5C30", VA = "0x183CF7030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual JPCOIOCHKOG[] BOLLIHLIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5720", Offset = "0x5EE4320", VA = "0x185EE5720", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5990", Offset = "0x5EE4590", VA = "0x185EE5990")]
	public void JMCKLNABHHJ(EntityManager INPODDDIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T CIKNKCBCJDH<T>(Entity BMHPCOMOJJA) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE58A0", Offset = "0x5EE44A0", VA = "0x185EE58A0", Slot = "8")]
	public (uint, uint) IIBEPBGJJBG(Entity BMHPCOMOJJA)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE57B0", Offset = "0x5EE43B0", VA = "0x185EE57B0", Slot = "9")]
	public bool HKMOFANKLIH(Entity BMHPCOMOJJA, (uint order, uint change) DLBBNPMBKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected DKLNNALIHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHHJJDGMHPD
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DAFMOBCOHOG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AEPOLAMFMAE OGHDKGLEDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JJECKOHNCMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNEPIEFKPAO(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IOCDGPFIIIG(Entity BMHPCOMOJJA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FDICMMIPDCA<TComponentData, TValue> : GNPLHOCEEIB<TValue>, IDisposable where TComponentData : struct, DAFMOBCOHOG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GENLCNJCFGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> ALFGCABNDNK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CMJPMBPLDNP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2F86040", Offset = "0x2F84C40", VA = "0x182F86040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35B5ED0", Offset = "0x35B4AD0", VA = "0x1835B5ED0")]
		public bool CMCLDFCBIHG([Out] TValue GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35B60A0", Offset = "0x35B4CA0", VA = "0x1835B60A0")]
		public void HFMDKEOMMOI(object KJCAGLABEME, TValue GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35B6150", Offset = "0x35B4D50", VA = "0x1835B6150")]
		public bool IFJPOCDCFNK(object KJCAGLABEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35B5FC0", Offset = "0x35B4BC0", VA = "0x1835B5FC0")]
		public int EABJGBKGHGI(object KJCAGLABEME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35B61D0", Offset = "0x35B4DD0", VA = "0x1835B61D0")]
		public GENLCNJCFGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<GENLCNJCFGL> BEJFFPIMNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LIPEFAEMCDI<AEPOLAMFMAE, GENLCNJCFGL> PFOMHNLEMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager INPODDDIDHO;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34CB5E0", Offset = "0x34CA1E0", VA = "0x1834CB5E0")]
	public FDICMMIPDCA(EntityManager INPODDDIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34CB070", Offset = "0x34C9C70", VA = "0x1834CB070", Slot = "4")]
	public void GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34CB420", Offset = "0x34CA020", VA = "0x1834CB420", Slot = "5")]
	public bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34CAF50", Offset = "0x34C9B50", VA = "0x1834CAF50", Slot = "6")]
	public bool CMCLDFCBIHG(Entity BMHPCOMOJJA, [Out] TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34CB050", Offset = "0x34C9C50", VA = "0x1834CB050", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34CB2A0", Offset = "0x34C9EA0", VA = "0x1834CB2A0")]
	private void JNDDJFKBBLO(GENLCNJCFGL AHGBALODIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34CAE90", Offset = "0x34C9A90", VA = "0x1834CAE90")]
	private bool ABMBMCBOKPI(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x34CB1B0", Offset = "0x34C9DB0", VA = "0x1834CB1B0")]
	private void IIECMEJCBFD(Entity BMHPCOMOJJA, AEPOLAMFMAE IFMBFHNFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34CB5C0", Offset = "0x34CA1C0", VA = "0x1834CB5C0")]
	private bool OJKIDBEEEOO(AEPOLAMFMAE IFMBFHNFCLO, [Out] GENLCNJCFGL AHGBALODIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34CB330", Offset = "0x34C9F30", VA = "0x1834CB330")]
	private GENLCNJCFGL LIIOKMJBFCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GNPLHOCEEIB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME, TValue GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMCLDFCBIHG(Entity BMHPCOMOJJA, [Out] TValue GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AEPOLAMFMAE : PKOAKKMJOIJ, IEquatable<AEPOLAMFMAE>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly AEPOLAMFMAE PHKLJCNEMGA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int EJAAMOHLDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int AMLCOLPAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x20A6110", Offset = "0x20A4D10", VA = "0x1820A6110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5304700", Offset = "0x5303300", VA = "0x185304700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4C00", Offset = "0x5EE3800", VA = "0x185EE4C00", Slot = "8")]
	public bool Equals(AEPOLAMFMAE LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4C50", Offset = "0x5EE3850", VA = "0x185EE4C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KHODDFCIKLL<THasTokensTag> : JJECKOHNCMO, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, AEPOLAMFMAE> FDGCKKLGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> BEJFFPIMNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LIPEFAEMCDI<AEPOLAMFMAE, HashSet<object>> PFOMHNLEMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager INPODDDIDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem APJHDNKMDGO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x397F8C0", Offset = "0x397E4C0", VA = "0x18397F8C0")]
	public KHODDFCIKLL(EntityManager INPODDDIDHO, EntityCommandBufferSystem APJHDNKMDGO, ELHKCOAEACJ GODOBDBPMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x397D220", Offset = "0x397BE20", VA = "0x18397D220", Slot = "4")]
	public bool GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x397F180", Offset = "0x397DD80", VA = "0x18397F180", Slot = "5")]
	public bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x397C460", Offset = "0x397B060", VA = "0x18397C460", Slot = "6")]
	public bool CNEPIEFKPAO(Entity BMHPCOMOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x397C4F0", Offset = "0x397B0F0", VA = "0x18397C4F0", Slot = "9")]
	public bool CNEPIEFKPAO(AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x397E1F0", Offset = "0x397CDF0", VA = "0x18397E1F0", Slot = "7")]
	public bool IOCDGPFIIIG(Entity BMHPCOMOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x397C8E0", Offset = "0x397B4E0", VA = "0x18397C8E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x397E840", Offset = "0x397D440", VA = "0x18397E840")]
	private void JNDDJFKBBLO(HashSet<object> AHGBALODIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x397C120", Offset = "0x397AD20", VA = "0x18397C120")]
	private bool ABMBMCBOKPI(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x397CDC0", Offset = "0x397B9C0", VA = "0x18397CDC0")]
	private bool FKKIJGKLCKN(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x397D670", Offset = "0x397C270", VA = "0x18397D670")]
	private void HFIPBIGKHPJ(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x397E730", Offset = "0x397D330", VA = "0x18397E730")]
	private void JAHPAHLMPJP(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x397EAF0", Offset = "0x397D6F0", VA = "0x18397EAF0")]
	private void KDFIAPOGOMJ(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x397DC30", Offset = "0x397C830", VA = "0x18397DC30")]
	private void IIECMEJCBFD(Entity BMHPCOMOJJA, AEPOLAMFMAE IFMBFHNFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x397CB20", Offset = "0x397B720", VA = "0x18397CB20")]
	private bool FAJJHEAOLOL(AEPOLAMFMAE IFMBFHNFCLO, [Out] HashSet<object> AHGBALODIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x397ECF0", Offset = "0x397D8F0", VA = "0x18397ECF0")]
	private HashSet<object> LIIOKMJBFCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJNFEBILIJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EHAJMKELJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int IAKOFEGDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int EMHEDPDPEMP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NAJLGFDJGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x20A6110", Offset = "0x20A4D10", VA = "0x1820A6110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5304700", Offset = "0x5303300", VA = "0x185304700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PFIKOOBKMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GPGNCMFFFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5E80", Offset = "0x5EE4A80", VA = "0x185EE5E80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5E60", Offset = "0x5EE4A60", VA = "0x185EE5E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA0F810", Offset = "0xA0E410", VA = "0x180A0F810")]
	private EHAJMKELJDI(int IAKOFEGDGBF, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CDB120", Offset = "0x1CD9D20", VA = "0x181CDB120")]
	public static EHAJMKELJDI JBPDLALFHIK(int IAKOFEGDGBF, int EMHEDPDPEMP)
	{
		return default(EHAJMKELJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E70", Offset = "0x5EE4A70", VA = "0x185EE5E70")]
	public static EHAJMKELJDI EEJGDEOHOBP(int DIOBLODNDCP, int AEFDKINALJN)
	{
		return default(EHAJMKELJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E90", Offset = "0x5EE4A90", VA = "0x185EE5E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct PLHBMIIEPCP : BLAHMNJGMPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9160", Offset = "0x5EC7D60", VA = "0x185EC9160")]
	public float JJDHKAOFKGE([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9160", Offset = "0x5EC7D60", VA = "0x185EC9160", Slot = "4")]
	private float KPLPMFNFCNL([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MAOADOELMEF : BLAHMNJGMPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9070", Offset = "0x5EC7C70", VA = "0x185EC9070")]
	public float JJDHKAOFKGE([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9070", Offset = "0x5EC7C70", VA = "0x185EC9070", Slot = "4")]
	private float KPLPMFNFCNL([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KMPHHLJEJFK : BLAHMNJGMPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1985680", Offset = "0x1984280", VA = "0x181985680")]
	public float JJDHKAOFKGE([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1985680", Offset = "0x1984280", VA = "0x181985680", Slot = "4")]
	private float KPLPMFNFCNL([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GFDDLHBIAOI : BLAHMNJGMPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12CDF40", Offset = "0x12CCB40", VA = "0x1812CDF40")]
	public int JJDHKAOFKGE([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12CDF40", Offset = "0x12CCB40", VA = "0x1812CDF40", Slot = "4")]
	private int KKNKNPELGPG([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NLKFIMAMPAJ : BLAHMNJGMPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE50", Offset = "0x5ECEA50", VA = "0x185ECFE50")]
	public int JJDHKAOFKGE([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE50", Offset = "0x5ECEA50", VA = "0x185ECFE50", Slot = "4")]
	private int KKNKNPELGPG([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KPKKKJGHNLC : BLAHMNJGMPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x159FC60", Offset = "0x159E860", VA = "0x18159FC60")]
	public int JJDHKAOFKGE([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x159FC60", Offset = "0x159E860", VA = "0x18159FC60", Slot = "4")]
	private int KKNKNPELGPG([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GLANKOMNCJH : LFDNJHDOLMF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type ONOBFKLLJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type ABFKPONIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6240", Offset = "0x5EE4E40", VA = "0x185EE6240")]
	public GLANKOMNCJH(Type OMOBCJNHGEM, Type EAKKNCIGKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PPHEDNDICKJ : LFDNJHDOLMF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type ABFKPONIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA100", Offset = "0x5DF8D00", VA = "0x185DFA100")]
	public PPHEDNDICKJ(Type EAKKNCIGKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BDGINMNLMDH : LFDNJHDOLMF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	public BDGINMNLMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OJDAHEADKJH<Data> : IAEFBOEMLDL where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data IJJIHHKLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3E02C60", Offset = "0x3E01860", VA = "0x183E02C60", Slot = "8")]
	protected virtual bool GDOEADGIEFB(ReadOnlySpan<Data> PECFDDJHOLI, KHLMCJLLPNE NEAOMJPAIEL, [Out] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "9")]
	protected virtual bool ACCKFIDFPPC(int DLBBNPMBKBG, Span<Data> PECFDDJHOLI, [In] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E02BA0", Offset = "0x3E017A0", VA = "0x183E02BA0", Slot = "5")]
	internal sealed override bool GDOEADGIEFB(Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, KHLMCJLLPNE NEAOMJPAIEL, [Out] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E00E30", Offset = "0x3DFFA30", VA = "0x183E00E30", Slot = "6")]
	internal sealed override bool ACCKFIDFPPC(int DLBBNPMBKBG, Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, [In] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x243D950", Offset = "0x243C550", VA = "0x18243D950")]
	protected KACKCAANCDA<Protobuf> PPHOEMHPHAP<Protobuf>(ReadOnlySpan<Data> PECFDDJHOLI) where Protobuf : IMessage, new()
	{
		return default(KACKCAANCDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x243D8D0", Offset = "0x243C4D0", VA = "0x18243D8D0")]
	protected PLNBDECJEDH<Protobuf> JPCPLGIPDBA<Protobuf>(ReadOnlySpan<byte> KCGANELMDLB, ReadOnlySpan<Data> PECFDDJHOLI, Action<Protobuf> OLHJHPPEGCA) where Protobuf : IMessage, new()
	{
		return default(PLNBDECJEDH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
	protected OJDAHEADKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class IAEFBOEMLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int AMLCOLPAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6290", Offset = "0x5EE4E90", VA = "0x185EE6290", Slot = "5")]
	internal virtual bool GDOEADGIEFB(Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, KHLMCJLLPNE NEAOMJPAIEL, [Out] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "6")]
	internal virtual bool ACCKFIDFPPC(int DLBBNPMBKBG, Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, [In] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected IAEFBOEMLDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JDMFCCLDNJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class JCAILBAJJEN : SystemBase, JDMFCCLDNJA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6400", Offset = "0x5EE5000", VA = "0x185EE6400")]
	public ComponentDataFromEntity MEODKFKNDFI(int ADJEGAJMFIJ, bool GLPKAJPCJLF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE63E0", Offset = "0x5EE4FE0", VA = "0x185EE63E0")]
	public EntityExistenceLookupByEntity CPLJAAPANLL()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE64C0", Offset = "0x5EE50C0", VA = "0x185EE64C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	protected JCAILBAJJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class GHGDMALHDFP : JCAILBAJJEN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6210", Offset = "0x5EE4E10", VA = "0x185EE6210", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	protected GHGDMALHDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class IHKFCLPCOHD
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class NHJLDCPNOCP : MMMEACKIALD
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67B0", Offset = "0x5EE53B0", VA = "0x185EE67B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase FEJJDCMAKCJ();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6800", Offset = "0x5EE5400", VA = "0x185EE6800")]
	protected ComponentSystemBase PGCINMHCDNL(params ComponentSystemBase[] BMAEGIJCBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2623450", Offset = "0x2622050", VA = "0x182623450")]
	protected ComponentSystemBase PGCINMHCDNL<T>(params ComponentSystemBase[] BMAEGIJCBDA) where T : MMMEACKIALD, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26233B0", Offset = "0x2621FB0", VA = "0x1826233B0")]
	protected ComponentSystemBase OCILAGGCMJI<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26233B0", Offset = "0x2621FB0", VA = "0x1826233B0")]
	protected ComponentSystemBase HFEMOKOLOMO<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6760", Offset = "0x5EE5360", VA = "0x185EE6760")]
	protected ComponentSystemBase EDFINGOBLGK(params SystemHandleUntyped[] BMAEGIJCBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2623320", Offset = "0x2621F20", VA = "0x182623320")]
	protected ComponentSystemBase EDFINGOBLGK<T>(params SystemHandleUntyped[] BMAEGIJCBDA) where T : MMMEACKIALD, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26233F0", Offset = "0x2621FF0", VA = "0x1826233F0")]
	protected SystemHandleUntyped NALFGADMDHG<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6710", Offset = "0x5EE5310", VA = "0x185EE6710")]
	protected NHJLDCPNOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MMMEACKIALD : OGDIDDEBLBA
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE66E0", Offset = "0x5EE52E0", VA = "0x185EE66E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6710", Offset = "0x5EE5310", VA = "0x185EE6710")]
	public MMMEACKIALD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class OGDIDDEBLBA : ComponentSystemGroup, JDMFCCLDNJA
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6710", Offset = "0x5EE5310", VA = "0x185EE6710")]
	protected OGDIDDEBLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class HILJAFMPKDN : EntityCommandBufferSystem, JDMFCCLDNJA
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	protected HILJAFMPKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BLAHMNJGMPL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo JJDHKAOFKGE([In] TFrom GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NBIDHFLJNMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFMAFLELDPI(T GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LFMEAIKPMME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes KNHFCEBDBHP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE65F0", Offset = "0x5EE51F0", VA = "0x185EE65F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct AALDDEKMAAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4B60", Offset = "0x5EE3760", VA = "0x185EE4B60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct POMFEKGKLGD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType NIAEBEEHPCA;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6890", Offset = "0x5EE5490", VA = "0x185EE6890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct OJJGELMNNOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> IGJLGPELHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3E032A0", Offset = "0x3E01EA0", VA = "0x183E032A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct EDHACACBPPJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> HJEFNDCLEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct DBMNPDOGMFA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> ELHAAFMGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T GCPEEAODAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer MIOOODGCIJA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6470", Offset = "0x4DE5070", VA = "0x184DE6470", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct ADPLPBGBPOM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLAHMNJGMPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> IGEGNAKIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct KCMJCDADIAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity CDPIKFFDONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> IGEGNAKIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int AGCKJJIAFIM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EE64E0", Offset = "0x5EE50E0", VA = "0x185EE64E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct DHOHGMKNKLB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CDMFHFBJCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> KLDICOLHOKO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct FGJIJPBLFEB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLAHMNJGMPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> AHKHGOODDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> IGEGNAKIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct KOAMCAPIDFG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EAKKNCIGKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> IPMNJKFNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> PCENJJIABKM;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct IFDIAGKEJID<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EAKKNCIGKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> IPMNJKFNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> PCENJJIABKM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3718430", Offset = "0x3717030", VA = "0x183718430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct JCDGEBCNOCN<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> KLDICOLHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> HAENNPALKDJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38E6BA0", Offset = "0x38E57A0", VA = "0x1838E6BA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct CINBECCPGPI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BLAHMNJGMPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> KLDICOLHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> HAENNPALKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct MJPMLIBJOKC<T, TPredicate> : IJob where T : struct where TPredicate : struct, NBIDHFLJNMK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NHJHLNDFFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LGCKIHBJANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB40B0", Offset = "0x3CB2CB0", VA = "0x183CB40B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct DGGHOGOCNLO<T, TPredicate> : IJob where T : struct where TPredicate : struct, NBIDHFLJNMK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> HOEHKKNFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> KLDICOLHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate GAFABDCELFL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct DKAPGHFALIL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity EAKKNCIGKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> IPMNJKFNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> CLIMFIPMJCH;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5440", Offset = "0x5EE4040", VA = "0x185EE5440", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct CLEDCDOHLAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity EAKKNCIGKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> IPMNJKFNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> CLIMFIPMJCH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4FF0", Offset = "0x5EE3BF0", VA = "0x185EE4FF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EOFNJAJHDDN
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FACBPBAPJMJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24DA440", Offset = "0x24D9040", VA = "0x1824DA440")]
	public static bool NGGNGLEIKKL<T>(this NativeArray<Entity> IPMNJKFNIGH, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class AFDFHIHIMNF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PPKPMBEPNLP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public PPKPMBEPNLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LGGKLENGIJJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public LGGKLENGIJJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> IPGJFDNAAPK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CA0", Offset = "0x5EE38A0", VA = "0x185EE4CA0")]
	public AFDFHIHIMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JPFABDIMGGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OCMNJJNELGK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct PIFOOAIJICM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CBAMBKFNJJJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal PIFOOAIJICM<TFrom> HHNAEDAPOHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> PFJBHGAEIJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct DOHMPEEBBGN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct JFACIGDMNCJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal DOHMPEEBBGN<TFrom> HHNAEDAPOHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> PFJBHGAEIJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct AAMNBLLMDNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct LJGLKHKGLDF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal AAMNBLLMDNJ<TFrom> HHNAEDAPOHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> PFJBHGAEIJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct OIDEBDPPNNE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct ABKKGCAIBLK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal OIDEBDPPNNE<TFrom> HHNAEDAPOHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> PFJBHGAEIJN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NOGHLPNLDFP
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OIMGBNKIALB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2647170", Offset = "0x2645D70", VA = "0x182647170")]
	public static NativeList<T> BCOBDOIEPEJ<T>(this NativeList<T> EGDGHJJBHHI, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x26471F0", Offset = "0x2645DF0", VA = "0x1826471F0")]
	public static NativeList<T> BCOBDOIEPEJ<T>(this NativeArray<T> EGDGHJJBHHI, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CBIBFOBOLIK
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BKCKNDBFJHM
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x22CF040", Offset = "0x22CDC40", VA = "0x1822CF040")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP, NativeArrayAsync<T> IGJLGPELHOJ, [Optional] JobHandle MHLLBAHNEII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22CEE80", Offset = "0x22CDA80", VA = "0x1822CEE80")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x22CEF20", Offset = "0x22CDB20", VA = "0x1822CEF20")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4E80", Offset = "0x5EE3A80", VA = "0x185EE4E80")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, ComponentTypes KNHFCEBDBHP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D30", Offset = "0x5EE3930", VA = "0x185EE4D30")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO(this EntityCommandBufferSystem APJHDNKMDGO, EntityCommandBuffer MIOOODGCIJA, NativeArray<Entity> ELHAAFMGCOP, ComponentTypes KNHFCEBDBHP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GBKMLNKMJIC
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x24F53D0", Offset = "0x24F3FD0", VA = "0x1824F53D0")]
	[BIBGHAJFLGB]
	public static JobHandle OAMEIECFGFA<T>(this EntityCommandBufferSystem APJHDNKMDGO, EntityCommandBuffer MIOOODGCIJA, EntityQuery DJFGGHAGHOI, T GCPEEAODAIB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DJDNFKNBOOO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE52B0", Offset = "0x5EE3EB0", VA = "0x185EE52B0")]
	[BIBGHAJFLGB]
	public static JobHandle DEEJBIHNLHA(this EntityCommandBufferSystem APJHDNKMDGO, NativeList<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE51B0", Offset = "0x5EE3DB0", VA = "0x185EE51B0")]
	[BIBGHAJFLGB]
	public static JobHandle DEEJBIHNLHA(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NLJMHBNHPJF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x262A940", Offset = "0x2629540", VA = "0x18262A940")]
	public static void LJALHGHLAEA<T>(this EntityCommandBufferSystem APJHDNKMDGO, EntityQuery DJFGGHAGHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x262A880", Offset = "0x2629480", VA = "0x18262A880")]
	[BIBGHAJFLGB]
	public static JobHandle EFKKIPHBHLE<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeListAsync<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x262A6F0", Offset = "0x26292F0", VA = "0x18262A6F0")]
	[BIBGHAJFLGB]
	public static JobHandle EFKKIPHBHLE<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class MALFONEPAPH
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2588DF0", Offset = "0x25879F0", VA = "0x182588DF0")]
	[BIBGHAJFLGB]
	public static JobHandle PKDBBGJPPJE<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, NativeArray<T> IGJLGPELHOJ, JobHandle MHLLBAHNEII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MMJLLHNKBIB
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2597400", Offset = "0x2596000", VA = "0x182597400")]
	[BIBGHAJFLGB]
	public static JobHandle MJGPHPGJNNJ<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, T GCPEEAODAIB, [Optional] JobHandle MHLLBAHNEII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2597330", Offset = "0x2595F30", VA = "0x182597330")]
	[BIBGHAJFLGB]
	public static JobHandle MJGPHPGJNNJ<T>(this EntityCommandBufferSystem APJHDNKMDGO, EntityCommandBuffer MIOOODGCIJA, NativeArray<Entity> ELHAAFMGCOP, T GCPEEAODAIB, [Optional] JobHandle MHLLBAHNEII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class IBJBJJFMIEI
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x25297D0", Offset = "0x25283D0", VA = "0x1825297D0")]
	public static NativeList<T> BCOBDOIEPEJ<T>(NativeList<T> EGDGHJJBHHI, Allocator NOFANFDHPGP) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class DKDHBEJLNOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2387000", Offset = "0x2385C00", VA = "0x182387000")]
	public static NativeArray<T> MOACFHJILDD<T>(this NativeList<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2386AC0", Offset = "0x23856C0", VA = "0x182386AC0")]
	public static NativeArray<T> MOACFHJILDD<T>(this NativeArray<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE54D0", Offset = "0x5EE40D0", VA = "0x185EE54D0")]
	public static NativeArray<Entity> OENAOEHPPFB(this NativeArray<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, ComponentType NIAEBEEHPCA, Allocator NOFANFDHPGP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x23869E0", Offset = "0x23855E0", VA = "0x1823869E0")]
	public static NativeArray<T> AAOJFNKMJHP<T>(this NativeArray<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FBKFAEBOOPA
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct MAIEHBHCFBF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct JJAPBOFECBF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public MAIEHBHCFBF<TFrom> PFJBHGAEIJN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct HOOFLKLOFLH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct NJKKDMDAMHF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public HOOFLKLOFLH<TFrom> PFJBHGAEIJN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct MLCIBHOCAJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct LBIGFMPPALI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public MLCIBHOCAJG<TFrom> PFJBHGAEIJN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> HOEHKKNFJOO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LALLFDJOECL
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class OGLHOMPBCDM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct JCKHODODJPA : BLAHMNJGMPL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> PILBPCPCDMH;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE64D0", Offset = "0x5EE50D0", VA = "0x185EE64D0")]
		[BurstCompatible]
		public Entity JJDHKAOFKGE([In] Entity GCPEEAODAIB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE64D0", Offset = "0x5EE50D0", VA = "0x185EE64D0", Slot = "4")]
		private Entity NBCCLOKDNKO([In] Entity GCPEEAODAIB)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class MMKDGEKCKCN
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct MPAIKNHCLIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> NHJHLNDFFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct PEHFNBNEGEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> NHJHLNDFFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HOIHMCOEHNG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> NHJHLNDFFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> HOEHKKNFJOO;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2106050", Offset = "0x2104C50", VA = "0x182106050")]
		public NativeListAsync<Entity> KFMAFLELDPI<TPredicate>() where TPredicate : struct, NBIDHFLJNMK<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25974E0", Offset = "0x25960E0", VA = "0x1825974E0")]
	public static HOIHMCOEHNG<T> BGOBHDCHMPL<T>(this NativeArrayAsync<Entity> IPMNJKFNIGH, NativeArrayAsync<T> EGDGHJJBHHI, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct
	{
		return default(HOIHMCOEHNG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DHLOEBBPCPC
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x23842F0", Offset = "0x2382EF0", VA = "0x1823842F0")]
	public static NativeListAsync<Entity> PJOHGHFPHGD<T, TPredicate>(this NativeArrayAsync<T> EGDGHJJBHHI, NativeArrayAsync<Entity> IPMNJKFNIGH, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct where TPredicate : struct, NBIDHFLJNMK<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2384150", Offset = "0x2382D50", VA = "0x182384150")]
	private static NativeListAsync<Entity> OMKBAJCOCDB<T, TPredicate>(NativeArrayAsync<T> BIAEBEOAPNK, NativeArrayAsync<Entity> IPMNJKFNIGH, int NBJKCBMEDIG, Allocator NOFANFDHPGP) where T : struct where TPredicate : struct, NBIDHFLJNMK<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LDNAPKPOLMB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CBIHBDIKFBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DOPFGFLGJIG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct DKCABFOGEKE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> HOEHKKNFJOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct NIMCHIDPKAF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator NOFANFDHPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> HOEHKKNFJOO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class DFELCJJGHBK
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class NLKMOFLHPGB
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x262ADC0", Offset = "0x26299C0", VA = "0x18262ADC0")]
	public static NativeList<Entity> HOCIHBDNIKM<T>(this NativeArray<Entity> IPMNJKFNIGH, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AKEFNAPCGKB
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class GJNBEPHGIOF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct BBAEDKNMCCC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> DAJPKFPFPMI;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
		public BBAEDKNMCCC(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public HABLPBHLKEF<TSrc, TValue> JFIMDOLOEPK<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HABLPBHLKEF<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct HABLPBHLKEF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> DAJPKFPFPMI;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
		public HABLPBHLKEF(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public FHNPFGCFNCB<TSrc, TValue, TSelector> LFKFLHLAPKH<TSelector>() where TSelector : struct, BLAHMNJGMPL<TSrc, TValue>
		{
			return default(FHNPFGCFNCB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct FHNPFGCFNCB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLAHMNJGMPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> DAJPKFPFPMI;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
		public FHNPFGCFNCB(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x34E1F00", Offset = "0x34E0B00", VA = "0x1834E1F00")]
		public JMPOHOFBLPF<TSrc, TValue, TSelector> PGCINMHCDNL()
		{
			return default(JMPOHOFBLPF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct FBGKKNEFHON<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BLAHMNJGMPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> DAJPKFPFPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector OBBOBILEEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int DCGGFHOCGGH;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x34C5DC0", Offset = "0x34C49C0", VA = "0x1834C5DC0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int EJAAMOHLDLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x993200", Offset = "0x991E00", VA = "0x180993200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int HOBMJDIAKNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CDC8B0", Offset = "0x1CDB4B0", VA = "0x181CDC8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E60", Offset = "0x34C4A60", VA = "0x1834C5E60")]
		public FBGKKNEFHON(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E50", Offset = "0x34C4A50", VA = "0x1834C5E50")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x34C5CE0", Offset = "0x34C48E0", VA = "0x1834C5CE0")]
		private TSrc GNDKBOBHNAJ(int JBCJBAEMMMK)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct JMPOHOFBLPF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLAHMNJGMPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private FBGKKNEFHON<TSrc, TValue, TSelector> MCDMPGFPEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue JNOFMFMPGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int EJAHPHIIAGB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public EHAJMKELJDI NABAGKBGKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x391D1C0", Offset = "0x391BDC0", VA = "0x18391D1C0")]
			get
			{
				return default(EHAJMKELJDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue GOPGIMIGJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, EHAJMKELJDI range) FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x391D0E0", Offset = "0x391BCE0", VA = "0x18391D0E0")]
			get
			{
				return default((TValue, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x391D340", Offset = "0x391BF40", VA = "0x18391D340")]
		public JMPOHOFBLPF(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x35F4DE0", Offset = "0x35F39E0", VA = "0x1835F4DE0")]
		public JMPOHOFBLPF<TSrc, TValue, TSelector> IFFPMJIPELE()
		{
			return default(JMPOHOFBLPF<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x391D200", Offset = "0x391BE00", VA = "0x18391D200")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24FBBE0", Offset = "0x24FA7E0", VA = "0x1824FBBE0")]
	public static BBAEDKNMCCC<T> AJMJDKGOLFO<T>(this NativeList<T> ALFGCABNDNK) where T : struct
	{
		return default(BBAEDKNMCCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
	public static BBAEDKNMCCC<T> AJMJDKGOLFO<T>(this NativeArray<T> DAJPKFPFPMI) where T : struct
	{
		return default(BBAEDKNMCCC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LHBMBJODACA
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct AHELGBFLKIG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly DAJPKFPFPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int EJAHPHIIAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int HNIMNAEBHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T JNOFMFMPGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T OBJHIGGPNNE;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public EHAJMKELJDI NABAGKBGKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x35E0320", Offset = "0x35DEF20", VA = "0x1835E0320")]
			get
			{
				return default(EHAJMKELJDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T GOPGIMIGJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x316D850", Offset = "0x316C450", VA = "0x18316D850")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, EHAJMKELJDI) FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x35F4EF0", Offset = "0x35F3AF0", VA = "0x1835F4EF0")]
			get
			{
				return default((T, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35F5370", Offset = "0x35F3F70", VA = "0x1835F5370")]
		public AHELGBFLKIG(NativeArray<T> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x35F4E00", Offset = "0x35F3A00", VA = "0x1835F4E00")]
		public AHELGBFLKIG<T> IFFPMJIPELE()
		{
			return default(AHELGBFLKIG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35F5190", Offset = "0x35F3D90", VA = "0x1835F5190")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x20DF070", Offset = "0x20DDC70", VA = "0x1820DF070")]
		public GONINILKBFM<T, TComparer> BJKBMECIOLB<TComparer>([Optional] TComparer HBEANMLJHLC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(GONINILKBFM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct GONINILKBFM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly DAJPKFPFPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int EJAHPHIIAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int HNIMNAEBHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T JNOFMFMPGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T OBJHIGGPNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer HBEANMLJHLC;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public EHAJMKELJDI NABAGKBGKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x35E0320", Offset = "0x35DEF20", VA = "0x1835E0320")]
			get
			{
				return default(EHAJMKELJDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T GOPGIMIGJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x316D850", Offset = "0x316C450", VA = "0x18316D850")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, EHAJMKELJDI range) FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x35E0250", Offset = "0x35DEE50", VA = "0x1835E0250")]
			get
			{
				return default((T, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x35E0510", Offset = "0x35DF110", VA = "0x1835E0510")]
		public GONINILKBFM(NativeArray<T>.ReadOnly DAJPKFPFPMI, TComparer HBEANMLJHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x35E0210", Offset = "0x35DEE10", VA = "0x1835E0210")]
		public GONINILKBFM<T, TComparer> IFFPMJIPELE()
		{
			return default(GONINILKBFM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x35E0330", Offset = "0x35DEF30", VA = "0x1835E0330")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25743B0", Offset = "0x2572FB0", VA = "0x1825743B0")]
	public static AHELGBFLKIG<T> PGCINMHCDNL<T>(this NativeArray<T> DAJPKFPFPMI) where T : struct
	{
		return default(AHELGBFLKIG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface NMOIMLPBIPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NMBBFGEECJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct PLNBDECJEDH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DBBFDAPNIAN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PLNBDECJEDH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x346FFE0", Offset = "0x346EBE0", VA = "0x18346FFE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public DBBFDAPNIAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4DE5080", Offset = "0x4DE3C80", VA = "0x184DE5080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DE5230", Offset = "0x4DE3E30", VA = "0x184DE5230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> OLHJHPPEGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream BOOOCBOEPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream IAILJDCDHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf FEOFIEDHMJL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int HOBMJDIAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE460", Offset = "0x3EAD060", VA = "0x183EAE460")]
	private PLNBDECJEDH(byte[] NJCBLCELFEN, Action<Protobuf> OLHJHPPEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x243F390", Offset = "0x243DF90", VA = "0x18243F390")]
	public static PLNBDECJEDH<Protobuf> PAKONFKLIMF<Data>(ReadOnlySpan<byte> KCGANELMDLB, ReadOnlySpan<Data> PECFDDJHOLI, Action<Protobuf> OLHJHPPEGCA)
	{
		return default(PLNBDECJEDH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE2D0", Offset = "0x3EACED0", VA = "0x183EAE2D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE310", Offset = "0x3EACF10", VA = "0x183EAE310", Slot = "4")]
	[IteratorStateMachine(typeof(PLNBDECJEDH<>.DBBFDAPNIAN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE400", Offset = "0x3EAD000", VA = "0x183EAE400", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct KACKCAANCDA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NJCBLCELFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf FEOFIEDHMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream BOOOCBOEPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream EPLGBPLFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3962890", Offset = "0x3961490", VA = "0x183962890")]
	private KACKCAANCDA(byte[] NJCBLCELFEN, [In] Protobuf FEOFIEDHMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2109BC0", Offset = "0x21087C0", VA = "0x182109BC0")]
	public static KACKCAANCDA<Protobuf> PAKONFKLIMF<T>(ReadOnlySpan<T> PECFDDJHOLI)
	{
		return default(KACKCAANCDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x39626A0", Offset = "0x39612A0", VA = "0x1839626A0")]
	public void BNIFAGEBNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3962800", Offset = "0x3961400", VA = "0x183962800")]
	public ByteString NDCHKBGFEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x39626D0", Offset = "0x39612D0", VA = "0x1839626D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NPHJMBAMEJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream BOOOCBOEPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream IAILJDCDHFC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6850", Offset = "0x5EE5450", VA = "0x185EE6850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct DCOPDPGCAFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] NJCBLCELFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream BOOOCBOEPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream EPLGBPLFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5080", Offset = "0x5EE3C80", VA = "0x185EE5080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class FMKHGKJKJIG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void NHAPGAHAGLF<From, To>(From PFJBHGAEIJN, To JKLLIKBBCBF, KHLMCJLLPNE NEAOMJPAIEL);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EEJHIFJNDMK<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static NHAPGAHAGLF<From, To> EAEBKFGLKMD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EEJHIFJNDMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5F40", Offset = "0x5EE4B40", VA = "0x185EE5F40")]
	static FMKHGKJKJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x24E2000", Offset = "0x24E0C00", VA = "0x1824E2000")]
	public static void BJLKJHGIANE<T>(NHAPGAHAGLF<T, T> GEDMDCHNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x24E2740", Offset = "0x24E1340", VA = "0x1824E2740")]
	public static void BJLKJHGIANE<From, To>(NHAPGAHAGLF<From, To> GEDMDCHNMND, NHAPGAHAGLF<To, From> PKNKGBFAFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x24E1C10", Offset = "0x24E0810", VA = "0x1824E1C10")]
	public static void BJLKJHGIANE<From, To>(NHAPGAHAGLF<From, To> EAEBKFGLKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24E8810", Offset = "0x24E7410", VA = "0x1824E8810")]
	public static NHAPGAHAGLF<From, To> KMADDJJLIAD<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x24E4A80", Offset = "0x24E3680", VA = "0x1824E4A80")]
	public static void KHKJHBLGDBL<From, To>(From PFJBHGAEIJN, To JKLLIKBBCBF, KHLMCJLLPNE NEAOMJPAIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KHLMCJLLPNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> LAKICEOFEON;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CA3890", Offset = "0x1CA2490", VA = "0x181CA3890")]
	public KHLMCJLLPNE(NativeArray<EntityRemapUtility.EntityRemapInfo> LAKICEOFEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE65E0", Offset = "0x5EE51E0", VA = "0x185EE65E0")]
	public Entity OADAOFEONGG(Entity NOOIIGLDGHB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class EFKPANFNEFG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5DD0", Offset = "0x5EE49D0", VA = "0x185EE5DD0")]
	public static ulong AFPAAPKKCCL(Type OMKEAAPIABA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5D70", Offset = "0x5EE4970", VA = "0x185EE5D70")]
	public static ulong AFPAAPKKCCL(string FHNALOFJFFH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum FGLGMNLDAHD
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class NFFEAJMFNLK : LFDNJHDOLMF
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	public NFFEAJMFNLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class EDHHKJJLEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5AD0", Offset = "0x5EE46D0", VA = "0x185EE5AD0")]
	private unsafe static Span<byte> CNMECLKKIPG(Unity.Entities.Chunk* DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x23C8B70", Offset = "0x23C7770", VA = "0x1823C8B70")]
	public unsafe static Span<T> IHAILDLHOFE<T>(Unity.Entities.Chunk* DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x22D3080", Offset = "0x22D1C80", VA = "0x1822D3080")]
	public static Span<T> IHAILDLHOFE<T>(this Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5BA0", Offset = "0x5EE47A0", VA = "0x185EE5BA0")]
	public unsafe static Span<Entity> GIFJPFIBEON(Unity.Entities.Chunk* DPFKELKPIPD)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C00", Offset = "0x5EE4800", VA = "0x185EE5C00")]
	public unsafe static void GMINFKPEKLF(Unity.Entities.Chunk* DPFKELKPIPD, int ECJHLLMGCGN)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CNCAHEHIFIE
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNCAHEHIFIE()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
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
