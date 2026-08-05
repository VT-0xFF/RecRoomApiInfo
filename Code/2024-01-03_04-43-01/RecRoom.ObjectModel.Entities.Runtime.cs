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
		[Cpp2IlInjected.Address(RVA = "0x5EE5FB0", Offset = "0x5EE4BB0", VA = "0x185EE5FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2109AC0", Offset = "0x21086C0", VA = "0x182109AC0")]
	public static void PCBDPIFIJEO<TField>(int DCGGFHOCGGH, string JEICAPDKHKI, FNMNEFCBFDG AAEGNEKBLGJ, [Out] JHNDGMMMKCP<TField> IEIEKFIPLEG) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21070C0", Offset = "0x2105CC0", VA = "0x1821070C0")]
	public static void OIKJLKNBACN<TField>(int DCGGFHOCGGH, string JEICAPDKHKI, [Out] IGEKDKKOPBK<TField> DKLHENCIMJI) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class IKGEOIAFJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6330", Offset = "0x5EE4F30", VA = "0x185EE6330")]
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
		[Cpp2IlInjected.Address(RVA = "0x31762B0", Offset = "0x3174EB0", VA = "0x1831762B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int BKBGNPOEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x31787A0", Offset = "0x31773A0", VA = "0x1831787A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3178680", Offset = "0x3177280", VA = "0x183178680")]
	public Data KHHECFMEFNP(Entity BMHPCOMOJJA)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View CIKNKCBCJDH(Entity BMHPCOMOJJA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CB80", Offset = "0x2E1B780", VA = "0x182E1CB80", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE5740", Offset = "0x5EE4340", VA = "0x185EE5740", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private JPCOIOCHKOG[] IGLMGJLDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF70C0", Offset = "0x3CF5CC0", VA = "0x183CF70C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual JPCOIOCHKOG[] BOLLIHLIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE57B0", Offset = "0x5EE43B0", VA = "0x185EE57B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5A20", Offset = "0x5EE4620", VA = "0x185EE5A20")]
	public void JMCKLNABHHJ(EntityManager INPODDDIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T CIKNKCBCJDH<T>(Entity BMHPCOMOJJA) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5930", Offset = "0x5EE4530", VA = "0x185EE5930", Slot = "8")]
	public (uint, uint) IIBEPBGJJBG(Entity BMHPCOMOJJA)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5840", Offset = "0x5EE4440", VA = "0x185EE5840", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F860D0", Offset = "0x2F84CD0", VA = "0x182F860D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35B5F60", Offset = "0x35B4B60", VA = "0x1835B5F60")]
		public bool CMCLDFCBIHG([Out] TValue GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35B6130", Offset = "0x35B4D30", VA = "0x1835B6130")]
		public void HFMDKEOMMOI(object KJCAGLABEME, TValue GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35B61E0", Offset = "0x35B4DE0", VA = "0x1835B61E0")]
		public bool IFJPOCDCFNK(object KJCAGLABEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35B6050", Offset = "0x35B4C50", VA = "0x1835B6050")]
		public int EABJGBKGHGI(object KJCAGLABEME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35B6260", Offset = "0x35B4E60", VA = "0x1835B6260")]
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
	[Cpp2IlInjected.Address(RVA = "0x34CB670", Offset = "0x34CA270", VA = "0x1834CB670")]
	public FDICMMIPDCA(EntityManager INPODDDIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34CB100", Offset = "0x34C9D00", VA = "0x1834CB100", Slot = "4")]
	public void GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34CB4B0", Offset = "0x34CA0B0", VA = "0x1834CB4B0", Slot = "5")]
	public bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34CAFE0", Offset = "0x34C9BE0", VA = "0x1834CAFE0", Slot = "6")]
	public bool CMCLDFCBIHG(Entity BMHPCOMOJJA, [Out] TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34CB0E0", Offset = "0x34C9CE0", VA = "0x1834CB0E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34CB330", Offset = "0x34C9F30", VA = "0x1834CB330")]
	private void JNDDJFKBBLO(GENLCNJCFGL AHGBALODIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34CAF20", Offset = "0x34C9B20", VA = "0x1834CAF20")]
	private bool ABMBMCBOKPI(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x34CB240", Offset = "0x34C9E40", VA = "0x1834CB240")]
	private void IIECMEJCBFD(Entity BMHPCOMOJJA, AEPOLAMFMAE IFMBFHNFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34CB650", Offset = "0x34CA250", VA = "0x1834CB650")]
	private bool OJKIDBEEEOO(AEPOLAMFMAE IFMBFHNFCLO, [Out] GENLCNJCFGL AHGBALODIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34CB3C0", Offset = "0x34C9FC0", VA = "0x1834CB3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20A61A0", Offset = "0x20A4DA0", VA = "0x1820A61A0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5304790", Offset = "0x5303390", VA = "0x185304790", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4C90", Offset = "0x5EE3890", VA = "0x185EE4C90", Slot = "8")]
	public bool Equals(AEPOLAMFMAE LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CE0", Offset = "0x5EE38E0", VA = "0x185EE4CE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x397F950", Offset = "0x397E550", VA = "0x18397F950")]
	public KHODDFCIKLL(EntityManager INPODDDIDHO, EntityCommandBufferSystem APJHDNKMDGO, ELHKCOAEACJ GODOBDBPMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x397D2B0", Offset = "0x397BEB0", VA = "0x18397D2B0", Slot = "4")]
	public bool GMECGFGMLFL(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x397F210", Offset = "0x397DE10", VA = "0x18397F210", Slot = "5")]
	public bool MAADMDILILK(Entity BMHPCOMOJJA, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x397C4F0", Offset = "0x397B0F0", VA = "0x18397C4F0", Slot = "6")]
	public bool CNEPIEFKPAO(Entity BMHPCOMOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x397C580", Offset = "0x397B180", VA = "0x18397C580", Slot = "9")]
	public bool CNEPIEFKPAO(AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x397E280", Offset = "0x397CE80", VA = "0x18397E280", Slot = "7")]
	public bool IOCDGPFIIIG(Entity BMHPCOMOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x397C970", Offset = "0x397B570", VA = "0x18397C970", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x397E8D0", Offset = "0x397D4D0", VA = "0x18397E8D0")]
	private void JNDDJFKBBLO(HashSet<object> AHGBALODIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x397C1B0", Offset = "0x397ADB0", VA = "0x18397C1B0")]
	private bool ABMBMCBOKPI(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x397CE50", Offset = "0x397BA50", VA = "0x18397CE50")]
	private bool FKKIJGKLCKN(Entity BMHPCOMOJJA, [Out] AEPOLAMFMAE IFMBFHNFCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x397D700", Offset = "0x397C300", VA = "0x18397D700")]
	private void HFIPBIGKHPJ(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x397E7C0", Offset = "0x397D3C0", VA = "0x18397E7C0")]
	private void JAHPAHLMPJP(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x397EB80", Offset = "0x397D780", VA = "0x18397EB80")]
	private void KDFIAPOGOMJ(Entity BMHPCOMOJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x397DCC0", Offset = "0x397C8C0", VA = "0x18397DCC0")]
	private void IIECMEJCBFD(Entity BMHPCOMOJJA, AEPOLAMFMAE IFMBFHNFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x397CBB0", Offset = "0x397B7B0", VA = "0x18397CBB0")]
	private bool FAJJHEAOLOL(AEPOLAMFMAE IFMBFHNFCLO, [Out] HashSet<object> AHGBALODIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x397ED80", Offset = "0x397D980", VA = "0x18397ED80")]
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
		[Cpp2IlInjected.Address(RVA = "0x20A61A0", Offset = "0x20A4DA0", VA = "0x1820A61A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5304790", Offset = "0x5303390", VA = "0x185304790")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE5F10", Offset = "0x5EE4B10", VA = "0x185EE5F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5EF0", Offset = "0x5EE4AF0", VA = "0x185EE5EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CDB1B0", Offset = "0x1CD9DB0", VA = "0x181CDB1B0")]
	public static EHAJMKELJDI JBPDLALFHIK(int IAKOFEGDGBF, int EMHEDPDPEMP)
	{
		return default(EHAJMKELJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5F00", Offset = "0x5EE4B00", VA = "0x185EE5F00")]
	public static EHAJMKELJDI EEJGDEOHOBP(int DIOBLODNDCP, int AEFDKINALJN)
	{
		return default(EHAJMKELJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5F20", Offset = "0x5EE4B20", VA = "0x185EE5F20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EC91F0", Offset = "0x5EC7DF0", VA = "0x185EC91F0")]
	public float JJDHKAOFKGE([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC91F0", Offset = "0x5EC7DF0", VA = "0x185EC91F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EC9100", Offset = "0x5EC7D00", VA = "0x185EC9100")]
	public float JJDHKAOFKGE([In] float3 GCPEEAODAIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9100", Offset = "0x5EC7D00", VA = "0x185EC9100", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5ECFEE0", Offset = "0x5ECEAE0", VA = "0x185ECFEE0")]
	public int JJDHKAOFKGE([In] int3 GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFEE0", Offset = "0x5ECEAE0", VA = "0x185ECFEE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE62D0", Offset = "0x5EE4ED0", VA = "0x185EE62D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DFA190", Offset = "0x5DF8D90", VA = "0x185DFA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E02CF0", Offset = "0x3E018F0", VA = "0x183E02CF0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E02C30", Offset = "0x3E01830", VA = "0x183E02C30", Slot = "5")]
	internal sealed override bool GDOEADGIEFB(Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, KHLMCJLLPNE NEAOMJPAIEL, [Out] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E00EC0", Offset = "0x3DFFAC0", VA = "0x183E00EC0", Slot = "6")]
	internal sealed override bool ACCKFIDFPPC(int DLBBNPMBKBG, Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN, [In] ReadOnlySpan<byte> KCGANELMDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x243D9E0", Offset = "0x243C5E0", VA = "0x18243D9E0")]
	protected KACKCAANCDA<Protobuf> PPHOEMHPHAP<Protobuf>(ReadOnlySpan<Data> PECFDDJHOLI) where Protobuf : IMessage, new()
	{
		return default(KACKCAANCDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x243D960", Offset = "0x243C560", VA = "0x18243D960")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6320", Offset = "0x5EE4F20", VA = "0x185EE6320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6490", Offset = "0x5EE5090", VA = "0x185EE6490")]
	public ComponentDataFromEntity MEODKFKNDFI(int ADJEGAJMFIJ, bool GLPKAJPCJLF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6470", Offset = "0x5EE5070", VA = "0x185EE6470")]
	public EntityExistenceLookupByEntity CPLJAAPANLL()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6550", Offset = "0x5EE5150", VA = "0x185EE6550", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE62A0", Offset = "0x5EE4EA0", VA = "0x185EE62A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6840", Offset = "0x5EE5440", VA = "0x185EE6840", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase FEJJDCMAKCJ();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6890", Offset = "0x5EE5490", VA = "0x185EE6890")]
	protected ComponentSystemBase PGCINMHCDNL(params ComponentSystemBase[] BMAEGIJCBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26234E0", Offset = "0x26220E0", VA = "0x1826234E0")]
	protected ComponentSystemBase PGCINMHCDNL<T>(params ComponentSystemBase[] BMAEGIJCBDA) where T : MMMEACKIALD, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2623440", Offset = "0x2622040", VA = "0x182623440")]
	protected ComponentSystemBase OCILAGGCMJI<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2623440", Offset = "0x2622040", VA = "0x182623440")]
	protected ComponentSystemBase HFEMOKOLOMO<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67F0", Offset = "0x5EE53F0", VA = "0x185EE67F0")]
	protected ComponentSystemBase EDFINGOBLGK(params SystemHandleUntyped[] BMAEGIJCBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26233B0", Offset = "0x2621FB0", VA = "0x1826233B0")]
	protected ComponentSystemBase EDFINGOBLGK<T>(params SystemHandleUntyped[] BMAEGIJCBDA) where T : MMMEACKIALD, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2623480", Offset = "0x2622080", VA = "0x182623480")]
	protected SystemHandleUntyped NALFGADMDHG<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67A0", Offset = "0x5EE53A0", VA = "0x185EE67A0")]
	protected NHJLDCPNOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MMMEACKIALD : OGDIDDEBLBA
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6770", Offset = "0x5EE5370", VA = "0x185EE6770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67A0", Offset = "0x5EE53A0", VA = "0x185EE67A0")]
	public MMMEACKIALD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class OGDIDDEBLBA : ComponentSystemGroup, JDMFCCLDNJA
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67A0", Offset = "0x5EE53A0", VA = "0x185EE67A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6680", Offset = "0x5EE5280", VA = "0x185EE6680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4BF0", Offset = "0x5EE37F0", VA = "0x185EE4BF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6920", Offset = "0x5EE5520", VA = "0x185EE6920", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E03330", Offset = "0x3E01F30", VA = "0x183E03330", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DE6500", Offset = "0x4DE5100", VA = "0x184DE6500", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6570", Offset = "0x5EE5170", VA = "0x185EE6570", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x37184C0", Offset = "0x37170C0", VA = "0x1837184C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x38E6C30", Offset = "0x38E5830", VA = "0x1838E6C30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CB4140", Offset = "0x3CB2D40", VA = "0x183CB4140", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE54D0", Offset = "0x5EE40D0", VA = "0x185EE54D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5080", Offset = "0x5EE3C80", VA = "0x185EE5080", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x24DA4D0", Offset = "0x24D90D0", VA = "0x1824DA4D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4D30", Offset = "0x5EE3930", VA = "0x185EE4D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2647200", Offset = "0x2645E00", VA = "0x182647200")]
	public static NativeList<T> BCOBDOIEPEJ<T>(this NativeList<T> EGDGHJJBHHI, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2647280", Offset = "0x2645E80", VA = "0x182647280")]
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
	[Cpp2IlInjected.Address(RVA = "0x22CF0D0", Offset = "0x22CDCD0", VA = "0x1822CF0D0")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP, NativeArrayAsync<T> IGJLGPELHOJ, [Optional] JobHandle MHLLBAHNEII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22CEF10", Offset = "0x22CDB10", VA = "0x1822CEF10")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArrayAsync<Entity> ELHAAFMGCOP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x22CEFB0", Offset = "0x22CDBB0", VA = "0x1822CEFB0")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4F10", Offset = "0x5EE3B10", VA = "0x185EE4F10")]
	[BIBGHAJFLGB]
	public static JobHandle GKFHCMJOPIO(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, ComponentTypes KNHFCEBDBHP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4DC0", Offset = "0x5EE39C0", VA = "0x185EE4DC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x24F5460", Offset = "0x24F4060", VA = "0x1824F5460")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5340", Offset = "0x5EE3F40", VA = "0x185EE5340")]
	[BIBGHAJFLGB]
	public static JobHandle DEEJBIHNLHA(this EntityCommandBufferSystem APJHDNKMDGO, NativeList<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5240", Offset = "0x5EE3E40", VA = "0x185EE5240")]
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
	[Cpp2IlInjected.Address(RVA = "0x262A9D0", Offset = "0x26295D0", VA = "0x18262A9D0")]
	public static void LJALHGHLAEA<T>(this EntityCommandBufferSystem APJHDNKMDGO, EntityQuery DJFGGHAGHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x262A910", Offset = "0x2629510", VA = "0x18262A910")]
	[BIBGHAJFLGB]
	public static JobHandle EFKKIPHBHLE<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeListAsync<Entity> ELHAAFMGCOP, [Optional] JobHandle MHLLBAHNEII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x262A780", Offset = "0x2629380", VA = "0x18262A780")]
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
	[Cpp2IlInjected.Address(RVA = "0x2588E80", Offset = "0x2587A80", VA = "0x182588E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2597490", Offset = "0x2596090", VA = "0x182597490")]
	[BIBGHAJFLGB]
	public static JobHandle MJGPHPGJNNJ<T>(this EntityCommandBufferSystem APJHDNKMDGO, NativeArray<Entity> ELHAAFMGCOP, T GCPEEAODAIB, [Optional] JobHandle MHLLBAHNEII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25973C0", Offset = "0x2595FC0", VA = "0x1825973C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2529860", Offset = "0x2528460", VA = "0x182529860")]
	public static NativeList<T> BCOBDOIEPEJ<T>(NativeList<T> EGDGHJJBHHI, Allocator NOFANFDHPGP) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class DKDHBEJLNOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2387090", Offset = "0x2385C90", VA = "0x182387090")]
	public static NativeArray<T> MOACFHJILDD<T>(this NativeList<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2386B50", Offset = "0x2385750", VA = "0x182386B50")]
	public static NativeArray<T> MOACFHJILDD<T>(this NativeArray<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5560", Offset = "0x5EE4160", VA = "0x185EE5560")]
	public static NativeArray<Entity> OENAOEHPPFB(this NativeArray<Entity> EGDGHJJBHHI, EntityManager INPODDDIDHO, ComponentType NIAEBEEHPCA, Allocator NOFANFDHPGP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2386A70", Offset = "0x2385670", VA = "0x182386A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE6560", Offset = "0x5EE5160", VA = "0x185EE6560")]
		[BurstCompatible]
		public Entity JJDHKAOFKGE([In] Entity GCPEEAODAIB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6560", Offset = "0x5EE5160", VA = "0x185EE6560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x21060E0", Offset = "0x2104CE0", VA = "0x1821060E0")]
		public NativeListAsync<Entity> KFMAFLELDPI<TPredicate>() where TPredicate : struct, NBIDHFLJNMK<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2597570", Offset = "0x2596170", VA = "0x182597570")]
	public static HOIHMCOEHNG<T> BGOBHDCHMPL<T>(this NativeArrayAsync<Entity> IPMNJKFNIGH, NativeArrayAsync<T> EGDGHJJBHHI, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct
	{
		return default(HOIHMCOEHNG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DHLOEBBPCPC
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2384380", Offset = "0x2382F80", VA = "0x182384380")]
	public static NativeListAsync<Entity> PJOHGHFPHGD<T, TPredicate>(this NativeArrayAsync<T> EGDGHJJBHHI, NativeArrayAsync<Entity> IPMNJKFNIGH, Allocator NOFANFDHPGP = Allocator.TempJob) where T : struct where TPredicate : struct, NBIDHFLJNMK<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x23841E0", Offset = "0x2382DE0", VA = "0x1823841E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x262AE50", Offset = "0x2629A50", VA = "0x18262AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
		public FHNPFGCFNCB(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x34E1F90", Offset = "0x34E0B90", VA = "0x1834E1F90")]
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
			[Cpp2IlInjected.Address(RVA = "0x34C5E50", Offset = "0x34C4A50", VA = "0x1834C5E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CDC940", Offset = "0x1CDB540", VA = "0x181CDC940")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x34C5EF0", Offset = "0x34C4AF0", VA = "0x1834C5EF0")]
		public FBGKKNEFHON(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x34C5EE0", Offset = "0x34C4AE0", VA = "0x1834C5EE0")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x34C5D70", Offset = "0x34C4970", VA = "0x1834C5D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x391D250", Offset = "0x391BE50", VA = "0x18391D250")]
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
			[Cpp2IlInjected.Address(RVA = "0x391D170", Offset = "0x391BD70", VA = "0x18391D170")]
			get
			{
				return default((TValue, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x391D3D0", Offset = "0x391BFD0", VA = "0x18391D3D0")]
		public JMPOHOFBLPF(NativeArray<TSrc> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x35F4E70", Offset = "0x35F3A70", VA = "0x1835F4E70")]
		public JMPOHOFBLPF<TSrc, TValue, TSelector> IFFPMJIPELE()
		{
			return default(JMPOHOFBLPF<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x391D290", Offset = "0x391BE90", VA = "0x18391D290")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24FBC70", Offset = "0x24FA870", VA = "0x1824FBC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x35E03B0", Offset = "0x35DEFB0", VA = "0x1835E03B0")]
			get
			{
				return default(EHAJMKELJDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T GOPGIMIGJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x316D8E0", Offset = "0x316C4E0", VA = "0x18316D8E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, EHAJMKELJDI) FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x35F4F80", Offset = "0x35F3B80", VA = "0x1835F4F80")]
			get
			{
				return default((T, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35F5400", Offset = "0x35F4000", VA = "0x1835F5400")]
		public AHELGBFLKIG(NativeArray<T> DAJPKFPFPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x35F4E90", Offset = "0x35F3A90", VA = "0x1835F4E90")]
		public AHELGBFLKIG<T> IFFPMJIPELE()
		{
			return default(AHELGBFLKIG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35F5220", Offset = "0x35F3E20", VA = "0x1835F5220")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x20DF100", Offset = "0x20DDD00", VA = "0x1820DF100")]
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
			[Cpp2IlInjected.Address(RVA = "0x35E03B0", Offset = "0x35DEFB0", VA = "0x1835E03B0")]
			get
			{
				return default(EHAJMKELJDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T GOPGIMIGJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x316D8E0", Offset = "0x316C4E0", VA = "0x18316D8E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, EHAJMKELJDI range) FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x35E02E0", Offset = "0x35DEEE0", VA = "0x1835E02E0")]
			get
			{
				return default((T, EHAJMKELJDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x35E05A0", Offset = "0x35DF1A0", VA = "0x1835E05A0")]
		public GONINILKBFM(NativeArray<T>.ReadOnly DAJPKFPFPMI, TComparer HBEANMLJHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x35E02A0", Offset = "0x35DEEA0", VA = "0x1835E02A0")]
		public GONINILKBFM<T, TComparer> IFFPMJIPELE()
		{
			return default(GONINILKBFM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x35E03C0", Offset = "0x35DEFC0", VA = "0x1835E03C0")]
		public bool NBBIAHHGPAH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2574440", Offset = "0x2573040", VA = "0x182574440")]
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
			[Cpp2IlInjected.Address(RVA = "0x3470070", Offset = "0x346EC70", VA = "0x183470070", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE5110", Offset = "0x4DE3D10", VA = "0x184DE5110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DE52C0", Offset = "0x4DE3EC0", VA = "0x184DE52C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EAE4F0", Offset = "0x3EAD0F0", VA = "0x183EAE4F0")]
	private PLNBDECJEDH(byte[] NJCBLCELFEN, Action<Protobuf> OLHJHPPEGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x243F420", Offset = "0x243E020", VA = "0x18243F420")]
	public static PLNBDECJEDH<Protobuf> PAKONFKLIMF<Data>(ReadOnlySpan<byte> KCGANELMDLB, ReadOnlySpan<Data> PECFDDJHOLI, Action<Protobuf> OLHJHPPEGCA)
	{
		return default(PLNBDECJEDH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE360", Offset = "0x3EACF60", VA = "0x183EAE360", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE3A0", Offset = "0x3EACFA0", VA = "0x183EAE3A0", Slot = "4")]
	[IteratorStateMachine(typeof(PLNBDECJEDH<>.DBBFDAPNIAN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE490", Offset = "0x3EAD090", VA = "0x183EAE490", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3962920", Offset = "0x3961520", VA = "0x183962920")]
	private KACKCAANCDA(byte[] NJCBLCELFEN, [In] Protobuf FEOFIEDHMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2109C50", Offset = "0x2108850", VA = "0x182109C50")]
	public static KACKCAANCDA<Protobuf> PAKONFKLIMF<T>(ReadOnlySpan<T> PECFDDJHOLI)
	{
		return default(KACKCAANCDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3962730", Offset = "0x3961330", VA = "0x183962730")]
	public void BNIFAGEBNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3962890", Offset = "0x3961490", VA = "0x183962890")]
	public ByteString NDCHKBGFEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3962760", Offset = "0x3961360", VA = "0x183962760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE68E0", Offset = "0x5EE54E0", VA = "0x185EE68E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5110", Offset = "0x5EE3D10", VA = "0x185EE5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5FD0", Offset = "0x5EE4BD0", VA = "0x185EE5FD0")]
	static FMKHGKJKJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x24E2090", Offset = "0x24E0C90", VA = "0x1824E2090")]
	public static void BJLKJHGIANE<T>(NHAPGAHAGLF<T, T> GEDMDCHNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x24E27D0", Offset = "0x24E13D0", VA = "0x1824E27D0")]
	public static void BJLKJHGIANE<From, To>(NHAPGAHAGLF<From, To> GEDMDCHNMND, NHAPGAHAGLF<To, From> PKNKGBFAFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x24E1CA0", Offset = "0x24E08A0", VA = "0x1824E1CA0")]
	public static void BJLKJHGIANE<From, To>(NHAPGAHAGLF<From, To> EAEBKFGLKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24E88A0", Offset = "0x24E74A0", VA = "0x1824E88A0")]
	public static NHAPGAHAGLF<From, To> KMADDJJLIAD<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x24E4B10", Offset = "0x24E3710", VA = "0x1824E4B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CA3920", Offset = "0x1CA2520", VA = "0x181CA3920")]
	public KHLMCJLLPNE(NativeArray<EntityRemapUtility.EntityRemapInfo> LAKICEOFEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6670", Offset = "0x5EE5270", VA = "0x185EE6670")]
	public Entity OADAOFEONGG(Entity NOOIIGLDGHB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class EFKPANFNEFG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E60", Offset = "0x5EE4A60", VA = "0x185EE5E60")]
	public static ulong AFPAAPKKCCL(Type OMKEAAPIABA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E00", Offset = "0x5EE4A00", VA = "0x185EE5E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5B60", Offset = "0x5EE4760", VA = "0x185EE5B60")]
	private unsafe static Span<byte> CNMECLKKIPG(Unity.Entities.Chunk* DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x23C8C00", Offset = "0x23C7800", VA = "0x1823C8C00")]
	public unsafe static Span<T> IHAILDLHOFE<T>(Unity.Entities.Chunk* DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x22D3110", Offset = "0x22D1D10", VA = "0x1822D3110")]
	public static Span<T> IHAILDLHOFE<T>(this Unity.Entities.Chunk DPFKELKPIPD, int ECJHLLMGCGN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C30", Offset = "0x5EE4830", VA = "0x185EE5C30")]
	public unsafe static Span<Entity> GIFJPFIBEON(Unity.Entities.Chunk* DPFKELKPIPD)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C90", Offset = "0x5EE4890", VA = "0x185EE5C90")]
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
