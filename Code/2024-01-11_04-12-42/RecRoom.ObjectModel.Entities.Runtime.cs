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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x60AEF40", Offset = "0x60AD940", VA = "0x1860AEF40")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EGGAECCDBKC<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] FMNEDNAEAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2F16E90", Offset = "0x2F15890", VA = "0x182F16E90")]
	public static void DGHEAGBPIEB<TField>(int BNALCEABILL, string CDHDOGOGPME, DHOBHBIBGAN OEDMDMFKHOG, [Out] BCPHIOEBKPP<TField> NPDAMELJOLL) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F16FC0", Offset = "0x2F159C0", VA = "0x182F16FC0")]
	public static void EALJDAMJGNN<TField>(int BNALCEABILL, string CDHDOGOGPME, [Out] AIIIAGKHGGD<TField> JJCBBELMNJG) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class HLENPEDGONK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60AF530", Offset = "0x60ADF30", VA = "0x1860AF530")]
	public static FieldInfo[] KHOCDDBJKKN(Type AKDFFJNHJJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class MPCNICHPJHC<View, Data> : HFPOIHPIKGO where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType EHLGDMGHCHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type OBAJBLMPBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8B20", Offset = "0x3DF7520", VA = "0x183DF8B20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int KAKKEJPCBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF82C0", Offset = "0x3DF6CC0", VA = "0x183DF82C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7A50", Offset = "0x3DF6450", VA = "0x183DF7A50")]
	public Data CPIFIKEODME(Entity MJDHOBNEHKO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View HBIDMHAJDIB(Entity MJDHOBNEHKO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23279F0", Offset = "0x23263F0", VA = "0x1823279F0", Slot = "14")]
	public override T HBIDMHAJDIB<T>(Entity MJDHOBNEHKO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	protected MPCNICHPJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class HFPOIHPIKGO : DHOBHBIBGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle IDMLCCDLFJC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager GHCEOOJLCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type OBAJBLMPBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int KAKKEJPCBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type IOLMEDIHEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9952F0", Offset = "0x993CF0", VA = "0x1809952F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NCIDEGJDMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60AF440", Offset = "0x60ADE40", VA = "0x1860AF440", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private MCCKGIFJHAO[] AFHMJONNJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F75310", Offset = "0x1F73D10", VA = "0x181F75310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual MCCKGIFJHAO[] CEDHPFPINDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60AF3B0", Offset = "0x60ADDB0", VA = "0x1860AF3B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60AF180", Offset = "0x60ADB80", VA = "0x1860AF180")]
	public void IAMMEFBKIFH(EntityManager DIKBBLNPABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T HBIDMHAJDIB<T>(Entity MJDHOBNEHKO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60AF2C0", Offset = "0x60ADCC0", VA = "0x1860AF2C0", Slot = "8")]
	public (uint, uint) IEHKNBGGBHD(Entity MJDHOBNEHKO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60AF090", Offset = "0x60ADA90", VA = "0x1860AF090", Slot = "9")]
	public bool ANGJIEJIJNB(Entity MJDHOBNEHKO, (uint order, uint change) BKOLDLDNEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected HFPOIHPIKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HAEIMBCNOEM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OLBCKPMBJDB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NNEJFNDGFNI BMMHOLPJNFG
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
public interface PHNEKKDKAFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNPLBAPNJDN(Entity MJDHOBNEHKO, object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJOIINNOFGH(Entity MJDHOBNEHKO, object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPCLEABBEEE(Entity MJDHOBNEHKO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DFKJPGKKGDN(Entity MJDHOBNEHKO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IJDGBFKAEDM<TComponentData, TValue> : AGHIEKCONNI<TValue>, IDisposable where TComponentData : struct, OLBCKPMBJDB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class BCFBJODHAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> BPDJICGMKNG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MDLNLAAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x305E200", Offset = "0x305CC00", VA = "0x18305E200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46DE930", Offset = "0x46DD330", VA = "0x1846DE930")]
		public bool ENCFGPFECMC([Out] TValue BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46DE880", Offset = "0x46DD280", VA = "0x1846DE880")]
		public void DGLLAPEBOKO(object BDAPLOBBPIE, TValue BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46DE800", Offset = "0x46DD200", VA = "0x1846DE800")]
		public bool BPOFHEGLDCM(object BDAPLOBBPIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46DEA20", Offset = "0x46DD420", VA = "0x1846DEA20")]
		public int PLOCAMCNEDF(object BDAPLOBBPIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46DEB00", Offset = "0x46DD500", VA = "0x1846DEB00")]
		public BCFBJODHAAA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<BCFBJODHAAA> KADHKEMHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LKMIGBALIEJ<NNEJFNDGFNI, BCFBJODHAAA> LOJEPGEGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager DIKBBLNPABK;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38457A0", Offset = "0x38441A0", VA = "0x1838457A0")]
	public IJDGBFKAEDM(EntityManager DIKBBLNPABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3845640", Offset = "0x3844040", VA = "0x183845640", Slot = "4")]
	public void MNPLBAPNJDN(Entity MJDHOBNEHKO, object BDAPLOBBPIE, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3845050", Offset = "0x3843A50", VA = "0x183845050", Slot = "5")]
	public bool AJOIINNOFGH(Entity MJDHOBNEHKO, object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843CD0", VA = "0x1838452D0", Slot = "6")]
	public bool ENCFGPFECMC(Entity MJDHOBNEHKO, [Out] TValue BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38452B0", Offset = "0x3843CB0", VA = "0x1838452B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38454C0", Offset = "0x3843EC0", VA = "0x1838454C0")]
	private void JABABBLIFCE(BCFBJODHAAA KJIPBLFNLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38451F0", Offset = "0x3843BF0", VA = "0x1838451F0")]
	private bool BDJEJNBJKLO(Entity MJDHOBNEHKO, [Out] NNEJFNDGFNI FGGJEPIEMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38453D0", Offset = "0x3843DD0", VA = "0x1838453D0")]
	private void FKPIOHFLLIP(Entity MJDHOBNEHKO, NNEJFNDGFNI FGGJEPIEMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3845780", Offset = "0x3844180", VA = "0x183845780")]
	private bool NHBAHOOEHAJ(NNEJFNDGFNI FGGJEPIEMPM, [Out] BCFBJODHAAA KJIPBLFNLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3845550", Offset = "0x3843F50", VA = "0x183845550")]
	private BCFBJODHAAA KGKOLLPIGBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AGHIEKCONNI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPLBAPNJDN(Entity MJDHOBNEHKO, object BDAPLOBBPIE, TValue BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJOIINNOFGH(Entity MJDHOBNEHKO, object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENCFGPFECMC(Entity MJDHOBNEHKO, [Out] TValue BEEGCHJLJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NNEJFNDGFNI : KLJLOJDCNCC, IEquatable<NNEJFNDGFNI>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly NNEJFNDGFNI LIKOBFINLBP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int AMPNEGOJBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8986D0", Offset = "0x8970D0", VA = "0x1808986D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int MLKHALHFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x215A030", Offset = "0x2158A30", VA = "0x18215A030", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x545DDD0", Offset = "0x545C7D0", VA = "0x18545DDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60AFE30", Offset = "0x60AE830", VA = "0x1860AFE30", Slot = "8")]
	public bool Equals(NNEJFNDGFNI CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60AFE80", Offset = "0x60AE880", VA = "0x1860AFE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FOODAGKKKMC<THasTokensTag> : PHNEKKDKAFM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EACOFNPIGGG ACIECAMLMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, NNEJFNDGFNI> AFMPACFECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> KADHKEMHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LKMIGBALIEJ<NNEJFNDGFNI, HashSet<object>> LOJEPGEGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager DIKBBLNPABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem BJOJHIACLCI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35E1B80", Offset = "0x35E0580", VA = "0x1835E1B80")]
	public FOODAGKKKMC(EntityManager DIKBBLNPABK, EntityCommandBufferSystem BJOJHIACLCI, EACOFNPIGGG AJNOGLMGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35E07E0", Offset = "0x35DF1E0", VA = "0x1835E07E0", Slot = "4")]
	public bool MNPLBAPNJDN(Entity MJDHOBNEHKO, object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35DE250", Offset = "0x35DCC50", VA = "0x1835DE250", Slot = "5")]
	public bool AJOIINNOFGH(Entity MJDHOBNEHKO, object BDAPLOBBPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35E12E0", Offset = "0x35DFCE0", VA = "0x1835E12E0", Slot = "6")]
	public bool OPCLEABBEEE(Entity MJDHOBNEHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35E1180", Offset = "0x35DFB80", VA = "0x1835E1180", Slot = "9")]
	public bool OPCLEABBEEE(NNEJFNDGFNI FGGJEPIEMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35DED90", Offset = "0x35DD790", VA = "0x1835DED90", Slot = "7")]
	public bool DFKJPGKKGDN(Entity MJDHOBNEHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35DF2D0", Offset = "0x35DDCD0", VA = "0x1835DF2D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35DFE80", Offset = "0x35DE880", VA = "0x1835DFE80")]
	private void JABABBLIFCE(HashSet<object> KJIPBLFNLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35DEB20", Offset = "0x35DD520", VA = "0x1835DEB20")]
	private bool BDJEJNBJKLO(Entity MJDHOBNEHKO, [Out] NNEJFNDGFNI FGGJEPIEMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35DDE90", Offset = "0x35DC890", VA = "0x1835DDE90")]
	private bool AACIFLPEFOI(Entity MJDHOBNEHKO, [Out] NNEJFNDGFNI FGGJEPIEMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35E0D40", Offset = "0x35DF740", VA = "0x1835E0D40")]
	private void OMJHGACIBLK(Entity MJDHOBNEHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35DFC20", Offset = "0x35DE620", VA = "0x1835DFC20")]
	private void GIMKACABJCA(Entity MJDHOBNEHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35E0060", Offset = "0x35DEA60", VA = "0x1835E0060")]
	private void JOBDJGEDMKF(Entity MJDHOBNEHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35DF4B0", Offset = "0x35DDEB0", VA = "0x1835DF4B0")]
	private void FKPIOHFLLIP(Entity MJDHOBNEHKO, NNEJFNDGFNI FGGJEPIEMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35DF6C0", Offset = "0x35DE0C0", VA = "0x1835DF6C0")]
	private bool FMKHCEJHGGB(NNEJFNDGFNI FGGJEPIEMPM, [Out] HashSet<object> KJIPBLFNLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35E01E0", Offset = "0x35DEBE0", VA = "0x1835E01E0")]
	private HashSet<object> KGKOLLPIGBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DKMJAPJFCPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KHOGKCDPLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int IACEHNBBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int MPNHPMPEEBM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EJGBKLGCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x215A030", Offset = "0x2158A30", VA = "0x18215A030")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x545DDD0", Offset = "0x545C7D0", VA = "0x18545DDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OPKKIHLGEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8986D0", Offset = "0x8970D0", VA = "0x1808986D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JJJCOCMBCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60AF940", Offset = "0x60AE340", VA = "0x1860AF940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60AF950", Offset = "0x60AE350", VA = "0x1860AF950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA40560", Offset = "0xA3EF60", VA = "0x180A40560")]
	private KHOGKCDPLKP(int IACEHNBBCDL, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D26A50", Offset = "0x1D25450", VA = "0x181D26A50")]
	public static KHOGKCDPLKP IJBJMEBHOME(int IACEHNBBCDL, int MPNHPMPEEBM)
	{
		return default(KHOGKCDPLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60AF960", Offset = "0x60AE360", VA = "0x1860AF960")]
	public static KHOGKCDPLKP KLOPDBCFDIL(int OHBFODPGDGE, int BFAIICDOEKN)
	{
		return default(KHOGKCDPLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60AF970", Offset = "0x60AE370", VA = "0x1860AF970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DDLBMJOFMEH : HEPLIGLMDPK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6097390", Offset = "0x6095D90", VA = "0x186097390")]
	public float POMDKIGIFKL([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6097390", Offset = "0x6095D90", VA = "0x186097390", Slot = "4")]
	private float GKGIEKFLNGG([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JMJEDFFNIKE : HEPLIGLMDPK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6097FC0", Offset = "0x60969C0", VA = "0x186097FC0")]
	public float POMDKIGIFKL([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6097FC0", Offset = "0x60969C0", VA = "0x186097FC0", Slot = "4")]
	private float GKGIEKFLNGG([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FPHKGKBELAO : HEPLIGLMDPK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19D7380", Offset = "0x19D5D80", VA = "0x1819D7380")]
	public float POMDKIGIFKL([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19D7380", Offset = "0x19D5D80", VA = "0x1819D7380", Slot = "4")]
	private float GKGIEKFLNGG([In] float3 BEEGCHJLJFC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EBCFJCEEJDC : HEPLIGLMDPK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1316650", Offset = "0x1315050", VA = "0x181316650")]
	public int POMDKIGIFKL([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1316650", Offset = "0x1315050", VA = "0x181316650", Slot = "4")]
	private int PCBAPLNPCCK([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KHADOCLIHBM : HEPLIGLMDPK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6092080", Offset = "0x6090A80", VA = "0x186092080")]
	public int POMDKIGIFKL([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6092080", Offset = "0x6090A80", VA = "0x186092080", Slot = "4")]
	private int PCBAPLNPCCK([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LHBDHCKPHHM : HEPLIGLMDPK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15DFE40", Offset = "0x15DE840", VA = "0x1815DFE40")]
	public int POMDKIGIFKL([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15DFE40", Offset = "0x15DE840", VA = "0x1815DFE40", Slot = "4")]
	private int PCBAPLNPCCK([In] int3 BEEGCHJLJFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LCJHIJLDPKG : MOEKHOCKEJK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type NKLOIMKJHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type DMGDADAEDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60AFA50", Offset = "0x60AE450", VA = "0x1860AFA50")]
	public LCJHIJLDPKG(Type JHOGMNFIJJP, Type HNNHLKKGCOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EEHFALFGBFK : MOEKHOCKEJK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type DMGDADAEDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB920", Offset = "0x5FBA320", VA = "0x185FBB920")]
	public EEHFALFGBFK(Type HNNHLKKGCOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AAOMINIOIDF : MOEKHOCKEJK
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	public AAOMINIOIDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class MDOEDHDLGNO<Data> : CCBBJOLHFKH where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data MBNAEHMDPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE5A0", Offset = "0x3DCCFA0", VA = "0x183DCE5A0", Slot = "8")]
	protected virtual bool HHPNKGMKECB(ReadOnlySpan<Data> HBAGFCLKGMJ, JHBLGOHBDMF JOFCABMGOCH, [Out] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "9")]
	protected virtual bool HCMKAIANBGN(int BKOLDLDNEOO, Span<Data> HBAGFCLKGMJ, [In] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE4E0", Offset = "0x3DCCEE0", VA = "0x183DCE4E0", Slot = "5")]
	internal sealed override bool HHPNKGMKECB(Unity.Entities.Chunk EJFKDGCPOLB, int PNGHAOOEBGM, JHBLGOHBDMF JOFCABMGOCH, [Out] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCCFE0", Offset = "0x3DCB9E0", VA = "0x183DCCFE0", Slot = "6")]
	internal sealed override bool HCMKAIANBGN(int BKOLDLDNEOO, Unity.Entities.Chunk EJFKDGCPOLB, int PNGHAOOEBGM, [In] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x21C8690", Offset = "0x21C7090", VA = "0x1821C8690")]
	protected LOKHKCBECFP<Protobuf> KNPMFLLACHI<Protobuf>(ReadOnlySpan<Data> HBAGFCLKGMJ) where Protobuf : IMessage, new()
	{
		return default(LOKHKCBECFP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x21C8610", Offset = "0x21C7010", VA = "0x1821C8610")]
	protected BHNOAIOADDE<Protobuf> ENMPENMKNPH<Protobuf>(ReadOnlySpan<byte> HANEBMPJCCB, ReadOnlySpan<Data> HBAGFCLKGMJ, Action<Protobuf> JCMDJCMCDLB) where Protobuf : IMessage, new()
	{
		return default(BHNOAIOADDE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
	protected MDOEDHDLGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class CCBBJOLHFKH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int MLKHALHFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60AE720", Offset = "0x60AD120", VA = "0x1860AE720", Slot = "5")]
	internal virtual bool HHPNKGMKECB(Unity.Entities.Chunk EJFKDGCPOLB, int PNGHAOOEBGM, JHBLGOHBDMF JOFCABMGOCH, [Out] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "6")]
	internal virtual bool HCMKAIANBGN(int BKOLDLDNEOO, Unity.Entities.Chunk EJFKDGCPOLB, int PNGHAOOEBGM, [In] ReadOnlySpan<byte> HANEBMPJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected CCBBJOLHFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OKJOEEPKKCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class DBJEACNGAEH : SystemBase, OKJOEEPKKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60AE9F0", Offset = "0x60AD3F0", VA = "0x1860AE9F0")]
	public ComponentDataFromEntity NIPOODOKELN(int KFKECAKPFJP, bool NHNDDCCGHAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60AE9D0", Offset = "0x60AD3D0", VA = "0x1860AE9D0")]
	public EntityExistenceLookupByEntity FJCDHOJBPGI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60AEAB0", Offset = "0x60AD4B0", VA = "0x1860AEAB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	protected DBJEACNGAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class BOLMLLMKJAP : DBJEACNGAEH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60AE6F0", Offset = "0x60AD0F0", VA = "0x1860AE6F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	protected BOLMLLMKJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DLLPIHNAAJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class NFPIIDIJGCG : PIFJFPEBMKI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60AFDE0", Offset = "0x60AE7E0", VA = "0x1860AFDE0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase BGAGBMJKLJH();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60AFD90", Offset = "0x60AE790", VA = "0x1860AFD90")]
	protected ComponentSystemBase HMIPIKELBIF(params ComponentSystemBase[] AKNFAFBFMJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27453E0", Offset = "0x2743DE0", VA = "0x1827453E0")]
	protected ComponentSystemBase HMIPIKELBIF<T>(params ComponentSystemBase[] AKNFAFBFMJO) where T : PIFJFPEBMKI, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27453A0", Offset = "0x2743DA0", VA = "0x1827453A0")]
	protected ComponentSystemBase MNHLLOCNLNF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27453A0", Offset = "0x2743DA0", VA = "0x1827453A0")]
	protected ComponentSystemBase EPGOFOAIFID<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60AFD40", Offset = "0x60AE740", VA = "0x1860AFD40")]
	protected ComponentSystemBase DFBFADMPPJC(params SystemHandleUntyped[] AKNFAFBFMJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2745310", Offset = "0x2743D10", VA = "0x182745310")]
	protected ComponentSystemBase DFBFADMPPJC<T>(params SystemHandleUntyped[] AKNFAFBFMJO) where T : PIFJFPEBMKI, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2745470", Offset = "0x2743E70", VA = "0x182745470")]
	protected SystemHandleUntyped JJDCGKLKFDJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60AFA00", Offset = "0x60AE400", VA = "0x1860AFA00")]
	protected NFPIIDIJGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PIFJFPEBMKI : KIBFKECDMBI
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60B00B0", Offset = "0x60AEAB0", VA = "0x1860B00B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60AFA00", Offset = "0x60AE400", VA = "0x1860AFA00")]
	public PIFJFPEBMKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class KIBFKECDMBI : ComponentSystemGroup, OKJOEEPKKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60AFA00", Offset = "0x60AE400", VA = "0x1860AFA00")]
	protected KIBFKECDMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class COFDPDHLHOE : EntityCommandBufferSystem, OKJOEEPKKCJ
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	protected COFDPDHLHOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HEPLIGLMDPK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo POMDKIGIFKL([In] TFrom BEEGCHJLJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MAGMIKODCDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIOLECMJOGA(T BEEGCHJLJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BAEGIJHKFHJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes LAPMKJAFKCP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60AE330", Offset = "0x60ACD30", VA = "0x1860AE330", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct FHFLAFBPAMP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60AEF60", Offset = "0x60AD960", VA = "0x1860AEF60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HIOMMCOFJJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType LEAAEEAEIJD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60AF4B0", Offset = "0x60ADEB0", VA = "0x1860AF4B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct BELCOMEBGLL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> OBAHLGOPPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x471C560", Offset = "0x471AF60", VA = "0x18471C560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct ENDJBKAAAOB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> AKMHBKNPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct IBJNPDOOANP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PLPONNOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T BEEGCHJLJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer BKLLOJIAIEG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3816300", Offset = "0x3814D00", VA = "0x183816300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct GOKBNLLPKPD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HEPLIGLMDPK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> HLGHFPNLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap GMHPLHJININ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct HPHHBJFJCAI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity LFGDLCHOJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> HLGHFPNLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int FMAKDLPOGOA;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60AF700", Offset = "0x60AE100", VA = "0x1860AF700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct IGEHPDNGBHI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BDONGEAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> GAEAMBDCOML;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct KHCNGAHAFKM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HEPLIGLMDPK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> EDEJANFFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> HLGHFPNLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap GMHPLHJININ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct PMBBIAPAAND<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNNHLKKGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> PLEINEFKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> JCOKFKHJJAD;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct DJMMGFGFABP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNNHLKKGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> PLEINEFKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> JCOKFKHJJAD;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4F67C20", Offset = "0x4F66620", VA = "0x184F67C20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct LFMJPJLMJPC<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> GAEAMBDCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> HPDEFGMBAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3BCBEE0", Offset = "0x3BCA8E0", VA = "0x183BCBEE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct IPIPHMKKCNI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HEPLIGLMDPK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> GAEAMBDCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> HPDEFGMBAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap GMHPLHJININ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct AHLABIOFCDE<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAGMIKODCDP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NLKOAMLGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> FOEJEAICKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate GMHPLHJININ;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3677D20", Offset = "0x3676720", VA = "0x183677D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct OCFNIOMEKNO<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAGMIKODCDP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> MNDFHBMJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> GAEAMBDCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate GMHPLHJININ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct HMHPANJHAIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity HNNHLKKGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> PLEINEFKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> BKFFBMFFILA;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60AF670", Offset = "0x60AE070", VA = "0x1860AF670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct GEAKKFNANBK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity HNNHLKKGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> PLEINEFKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> BKFFBMFFILA;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60AF000", Offset = "0x60ADA00", VA = "0x1860AF000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LHDLGAEMGGM
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KPNJHHEINEL
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x26BB990", Offset = "0x26BA390", VA = "0x1826BB990")]
	public static bool GNLNGGCCDLO<T>(this NativeArray<Entity> PLEINEFKCIG, EntityManager DIKBBLNPABK, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EIHFIKOMOEI
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PABIIMEEJIJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public PABIIMEEJIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FGFJAINEIGJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public FGFJAINEIGJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> IBHDOGBBLPD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60AEBF0", Offset = "0x60AD5F0", VA = "0x1860AEBF0")]
	public EIHFIKOMOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LMMIMCHMMMH
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GFKIGFHAIJE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct EDMBIOACMBH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct IFJNJMALHEI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal EDMBIOACMBH<TFrom> CDMOGOKIPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> MHLOJABNACB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct MNFIFKGNMCA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct POOLJIOLDPE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal MNFIFKGNMCA<TFrom> CDMOGOKIPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> MHLOJABNACB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct OCNCHILMEDC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct DEMNPHGGPGF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal OCNCHILMEDC<TFrom> CDMOGOKIPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> MHLOJABNACB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct GELDAGAEADN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct BCLEGJFPDBK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal GELDAGAEADN<TFrom> CDMOGOKIPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> MHLOJABNACB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KFFOMPNJAGK
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class FLHDPELMDCC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x25ED480", Offset = "0x25EBE80", VA = "0x1825ED480")]
	public static NativeList<T> LMGGBKJMHEA<T>(this NativeList<T> GPOLBJIMMIG, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x25ED300", Offset = "0x25EBD00", VA = "0x1825ED300")]
	public static NativeList<T> LMGGBKJMHEA<T>(this NativeArray<T> GPOLBJIMMIG, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PJJNDBKCBFO
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ENEFHHFDIMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24B9DF0", Offset = "0x24B87F0", VA = "0x1824B9DF0")]
	[EELHMLPNENA]
	public static JobHandle PIEHPLMGDEE<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArrayAsync<Entity> PLPONNOLDMD, NativeArrayAsync<T> OBAHLGOPPIK, [Optional] JobHandle HCKGAJHLHGH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24BA3D0", Offset = "0x24B8DD0", VA = "0x1824BA3D0")]
	[EELHMLPNENA]
	public static JobHandle PIEHPLMGDEE<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArrayAsync<Entity> PLPONNOLDMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x24B9F50", Offset = "0x24B8950", VA = "0x1824B9F50")]
	[EELHMLPNENA]
	public static JobHandle PIEHPLMGDEE<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArray<Entity> PLPONNOLDMD, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60AEDD0", Offset = "0x60AD7D0", VA = "0x1860AEDD0")]
	[EELHMLPNENA]
	public static JobHandle PIEHPLMGDEE(this EntityCommandBufferSystem BJOJHIACLCI, NativeArray<Entity> PLPONNOLDMD, ComponentTypes LAPMKJAFKCP, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60AEC80", Offset = "0x60AD680", VA = "0x1860AEC80")]
	[EELHMLPNENA]
	public static JobHandle PIEHPLMGDEE(this EntityCommandBufferSystem BJOJHIACLCI, EntityCommandBuffer BKLLOJIAIEG, NativeArray<Entity> PLPONNOLDMD, ComponentTypes LAPMKJAFKCP, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PEPHMGEINKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x27791A0", Offset = "0x2777BA0", VA = "0x1827791A0")]
	[EELHMLPNENA]
	public static JobHandle NGJADELOOII<T>(this EntityCommandBufferSystem BJOJHIACLCI, EntityCommandBuffer BKLLOJIAIEG, EntityQuery KGAIEBJLBME, T BEEGCHJLJFC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LDIBPMFFIDP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60AFBA0", Offset = "0x60AE5A0", VA = "0x1860AFBA0")]
	[EELHMLPNENA]
	public static JobHandle LOFCJDJIDDN(this EntityCommandBufferSystem BJOJHIACLCI, NativeList<Entity> PLPONNOLDMD, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60AFAA0", Offset = "0x60AE4A0", VA = "0x1860AFAA0")]
	[EELHMLPNENA]
	public static JobHandle LOFCJDJIDDN(this EntityCommandBufferSystem BJOJHIACLCI, NativeArrayAsync<Entity> PLPONNOLDMD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BIDGPLLMHAC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x23BEA20", Offset = "0x23BD420", VA = "0x1823BEA20")]
	public static void KBFEIHILEGC<T>(this EntityCommandBufferSystem BJOJHIACLCI, EntityQuery KGAIEBJLBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x23BF1D0", Offset = "0x23BDBD0", VA = "0x1823BF1D0")]
	[EELHMLPNENA]
	public static JobHandle NPKHEKCIFIF<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeListAsync<Entity> PLPONNOLDMD, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x23BF040", Offset = "0x23BDA40", VA = "0x1823BF040")]
	[EELHMLPNENA]
	public static JobHandle NPKHEKCIFIF<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArrayAsync<Entity> PLPONNOLDMD, [Optional] JobHandle HCKGAJHLHGH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BPIDNLGPAND
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x23D4B50", Offset = "0x23D3550", VA = "0x1823D4B50")]
	[EELHMLPNENA]
	public static JobHandle EAEGCFEHBGG<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArray<Entity> PLPONNOLDMD, NativeArray<T> OBAHLGOPPIK, JobHandle HCKGAJHLHGH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class IKHNNDPNOPA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2638110", Offset = "0x2636B10", VA = "0x182638110")]
	[EELHMLPNENA]
	public static JobHandle OEOCGAOFGNP<T>(this EntityCommandBufferSystem BJOJHIACLCI, NativeArray<Entity> PLPONNOLDMD, T BEEGCHJLJFC, [Optional] JobHandle HCKGAJHLHGH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x26381F0", Offset = "0x2636BF0", VA = "0x1826381F0")]
	[EELHMLPNENA]
	public static JobHandle OEOCGAOFGNP<T>(this EntityCommandBufferSystem BJOJHIACLCI, EntityCommandBuffer BKLLOJIAIEG, NativeArray<Entity> PLPONNOLDMD, T BEEGCHJLJFC, [Optional] JobHandle HCKGAJHLHGH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EENBDEENJEC
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24A0620", Offset = "0x249F020", VA = "0x1824A0620")]
	public static NativeList<T> LMGGBKJMHEA<T>(NativeList<T> GPOLBJIMMIG, Allocator OOLLJDKALHO) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OFLGMEOEIDC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x276D860", Offset = "0x276C260", VA = "0x18276D860")]
	public static NativeArray<T> ACBPCCCACHM<T>(this NativeList<Entity> GPOLBJIMMIG, EntityManager DIKBBLNPABK, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x276D320", Offset = "0x276BD20", VA = "0x18276D320")]
	public static NativeArray<T> ACBPCCCACHM<T>(this NativeArray<Entity> GPOLBJIMMIG, EntityManager DIKBBLNPABK, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60AFED0", Offset = "0x60AE8D0", VA = "0x1860AFED0")]
	public static NativeArray<Entity> DACLGMCGDAO(this NativeArray<Entity> GPOLBJIMMIG, EntityManager DIKBBLNPABK, ComponentType LEAAEEAEIJD, Allocator OOLLJDKALHO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x276D910", Offset = "0x276C310", VA = "0x18276D910")]
	public static NativeArray<T> LNMJNOGCKHK<T>(this NativeArray<Entity> GPOLBJIMMIG, EntityManager DIKBBLNPABK, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KABPHBCLPFE
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct OCFLDAKLPPD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct MJOEMAAEEBG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OCFLDAKLPPD<TFrom> MHLOJABNACB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct BBGNCNLACCO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct PMBKPGDCMIC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public BBGNCNLACCO<TFrom> MHLOJABNACB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GDDIJEKIAAK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct APKDDBOHFMF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GDDIJEKIAAK<TFrom> MHLOJABNACB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> MNDFHBMJEPJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BFFFBAGPCNI
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class OKOMJPEGOHH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct LMDCIGNPNLJ : HEPLIGLMDPK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JCJBNFJLLEF;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60AFD30", Offset = "0x60AE730", VA = "0x1860AFD30")]
		[BurstCompatible]
		public Entity POMDKIGIFKL([In] Entity BEEGCHJLJFC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60AFD30", Offset = "0x60AE730", VA = "0x1860AFD30", Slot = "4")]
		private Entity PMADCFOFJGD([In] Entity BEEGCHJLJFC)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class JILKJGHDIHO
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct LFDJIFOKEJB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> NLKOAMLGBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct NFOPEGONILG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> NLKOAMLGBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct DKMCEKDMCMJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> NLKOAMLGBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> MNDFHBMJEPJ;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2F15D30", Offset = "0x2F14730", VA = "0x182F15D30")]
		public NativeListAsync<Entity> HIOLECMJOGA<TPredicate>() where TPredicate : struct, MAGMIKODCDP<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x267A330", Offset = "0x2678D30", VA = "0x18267A330")]
	public static DKMCEKDMCMJ<T> ENLIENBGJNN<T>(this NativeArrayAsync<Entity> PLEINEFKCIG, NativeArrayAsync<T> GPOLBJIMMIG, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct
	{
		return default(DKMCEKDMCMJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class AGGLHKLMCDN
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C34290", Offset = "0x2C32C90", VA = "0x182C34290")]
	public static NativeListAsync<Entity> MHBOPOHADFJ<T, TPredicate>(this NativeArrayAsync<T> GPOLBJIMMIG, NativeArrayAsync<Entity> PLEINEFKCIG, Allocator OOLLJDKALHO = Allocator.TempJob) where T : struct where TPredicate : struct, MAGMIKODCDP<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C340F0", Offset = "0x2C32AF0", VA = "0x182C340F0")]
	private static NativeListAsync<Entity> HAHANLOPBNJ<T, TPredicate>(NativeArrayAsync<T> AHOGGOOHGIJ, NativeArrayAsync<Entity> PLEINEFKCIG, int FJADIACPEIM, Allocator OOLLJDKALHO) where T : struct where TPredicate : struct, MAGMIKODCDP<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class BCOHENDDMEP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GMJCCHAGHKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct KBKBEAAINJL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct JCBEIOKFEJC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> MNDFHBMJEPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct ADFKNFMFGEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator OOLLJDKALHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> MNDFHBMJEPJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class IOMMDOGJEFL
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class IMJJHDNKGLB
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x26387C0", Offset = "0x26371C0", VA = "0x1826387C0")]
	public static NativeList<Entity> DKFIDEEPLAP<T>(this NativeArray<Entity> PLEINEFKCIG, EntityManager DIKBBLNPABK, Allocator OOLLJDKALHO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MGMADPHHMOI
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class KNCADCKIIDE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct KAGKPMHICCP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> BHNHFMPCKPL;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public KAGKPMHICCP(NativeArray<TSrc> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public CDCAFBEIIAB<TSrc, TValue> HLJBCGCMFED<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(CDCAFBEIIAB<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct CDCAFBEIIAB<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> BHNHFMPCKPL;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public CDCAFBEIIAB(NativeArray<TSrc> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public MLKAHOEJGMC<TSrc, TValue, TSelector> CNEGGLEJLHA<TSelector>() where TSelector : struct, HEPLIGLMDPK<TSrc, TValue>
		{
			return default(MLKAHOEJGMC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct MLKAHOEJGMC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HEPLIGLMDPK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> BHNHFMPCKPL;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public MLKAHOEJGMC(NativeArray<TSrc> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC7C0", Offset = "0x3DEB1C0", VA = "0x183DEC7C0")]
		public AFDLDGIGGEP<TSrc, TValue, TSelector> HMIPIKELBIF()
		{
			return default(AFDLDGIGGEP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct PIJNAIKJACB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HEPLIGLMDPK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> BHNHFMPCKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector LDNKEKAJNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int BNALCEABILL;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4098CB0", Offset = "0x40976B0", VA = "0x184098CB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int AMPNEGOJBEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9BF220", Offset = "0x9BDC20", VA = "0x1809BF220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int PPDKOADJGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4098E30", Offset = "0x4097830", VA = "0x184098E30")]
		public PIJNAIKJACB(NativeArray<TSrc> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4098E20", Offset = "0x4097820", VA = "0x184098E20")]
		public bool PAFGAHDMPMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4098D40", Offset = "0x4097740", VA = "0x184098D40")]
		private TSrc IGKJGJAJAPN(int HLIHAMMEEIJ)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct AFDLDGIGGEP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HEPLIGLMDPK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PIJNAIKJACB<TSrc, TValue, TSelector> ACBJMLPNKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue CPEHIFLJJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int MGKCHJOOGGA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KHOGKCDPLKP PEDKJKEHHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x366DD60", Offset = "0x366C760", VA = "0x18366DD60")]
			get
			{
				return default(KHOGKCDPLKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue IMONHMFODGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, KHOGKCDPLKP range) POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x366DDA0", Offset = "0x366C7A0", VA = "0x18366DDA0")]
			get
			{
				return default((TValue, KHOGKCDPLKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x366DFC0", Offset = "0x366C9C0", VA = "0x18366DFC0")]
		public AFDLDGIGGEP(NativeArray<TSrc> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x366DD40", Offset = "0x366C740", VA = "0x18366DD40")]
		public AFDLDGIGGEP<TSrc, TValue, TSelector> DHCNIOBIIDB()
		{
			return default(AFDLDGIGGEP<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x366DE80", Offset = "0x366C880", VA = "0x18366DE80")]
		public bool PAFGAHDMPMG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x26A3A90", Offset = "0x26A2490", VA = "0x1826A3A90")]
	public static KAGKPMHICCP<T> LHNHKBJOKLH<T>(this NativeList<T> BPDJICGMKNG) where T : struct
	{
		return default(KAGKPMHICCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
	public static KAGKPMHICCP<T> LHNHKBJOKLH<T>(this NativeArray<T> BHNHFMPCKPL) where T : struct
	{
		return default(KAGKPMHICCP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class CPDOJFOEBJI
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct KEJCDEMMNGM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly BHNHFMPCKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int MGKCHJOOGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int HIOFMCCLCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T CPEHIFLJJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T PKPJCOEPLLL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KHOGKCDPLKP PEDKJKEHHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3AD7C50", Offset = "0x3AD6650", VA = "0x183AD7C50")]
			get
			{
				return default(KHOGKCDPLKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T IMONHMFODGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x32689E0", Offset = "0x32673E0", VA = "0x1832689E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, KHOGKCDPLKP) POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3AD7C60", Offset = "0x3AD6660", VA = "0x183AD7C60")]
			get
			{
				return default((T, KHOGKCDPLKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8200", Offset = "0x3AD6C00", VA = "0x183AD8200")]
		public KEJCDEMMNGM(NativeArray<T> BHNHFMPCKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7C10", Offset = "0x3AD6610", VA = "0x183AD7C10")]
		public KEJCDEMMNGM<T> DHCNIOBIIDB()
		{
			return default(KEJCDEMMNGM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7FB0", Offset = "0x3AD69B0", VA = "0x183AD7FB0")]
		public bool PAFGAHDMPMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x21BCD90", Offset = "0x21BB790", VA = "0x1821BCD90")]
		public BCNKBNMMMBF<T, TComparer> CDPKOCGOBKE<TComparer>([Optional] TComparer ALEFICAPIHP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BCNKBNMMMBF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct BCNKBNMMMBF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly BHNHFMPCKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int MGKCHJOOGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int HIOFMCCLCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T CPEHIFLJJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T PKPJCOEPLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer ALEFICAPIHP;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KHOGKCDPLKP PEDKJKEHHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x3AD7C50", Offset = "0x3AD6650", VA = "0x183AD7C50")]
			get
			{
				return default(KHOGKCDPLKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T IMONHMFODGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x32689E0", Offset = "0x32673E0", VA = "0x1832689E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, KHOGKCDPLKP range) POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x46DEBD0", Offset = "0x46DD5D0", VA = "0x1846DEBD0")]
			get
			{
				return default((T, KHOGKCDPLKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x46DEE80", Offset = "0x46DD880", VA = "0x1846DEE80")]
		public BCNKBNMMMBF(NativeArray<T>.ReadOnly BHNHFMPCKPL, TComparer ALEFICAPIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x46DEB90", Offset = "0x46DD590", VA = "0x1846DEB90")]
		public BCNKBNMMMBF<T, TComparer> DHCNIOBIIDB()
		{
			return default(BCNKBNMMMBF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x46DECA0", Offset = "0x46DD6A0", VA = "0x1846DECA0")]
		public bool PAFGAHDMPMG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2450640", Offset = "0x244F040", VA = "0x182450640")]
	public static KEJCDEMMNGM<T> HMIPIKELBIF<T>(this NativeArray<T> BHNHFMPCKPL) where T : struct
	{
		return default(KEJCDEMMNGM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface NIODAOALIDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class KODBAMIIIEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BHNOAIOADDE<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BBJJOOEBGJK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BHNOAIOADDE<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35E8360", Offset = "0x35E6D60", VA = "0x1835E8360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public BBJJOOEBGJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x46DE480", Offset = "0x46DCE80", VA = "0x1846DE480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x46DE630", Offset = "0x46DD030", VA = "0x1846DE630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> JCMDJCMCDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream MLLHHPADIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream BDNGBINLAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf CJKCELIHINP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int PPDKOADJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4724CD0", Offset = "0x47236D0", VA = "0x184724CD0")]
	private BHNOAIOADDE(byte[] LMJJBGCJLAL, Action<Protobuf> JCMDJCMCDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F123D0", Offset = "0x2F10DD0", VA = "0x182F123D0")]
	public static BHNOAIOADDE<Protobuf> CMMJGECCMDN<Data>(ReadOnlySpan<byte> HANEBMPJCCB, ReadOnlySpan<Data> HBAGFCLKGMJ, Action<Protobuf> JCMDJCMCDLB)
	{
		return default(BHNOAIOADDE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4724B40", Offset = "0x4723540", VA = "0x184724B40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4724B80", Offset = "0x4723580", VA = "0x184724B80", Slot = "4")]
	[IteratorStateMachine(typeof(BHNOAIOADDE<>.BBJJOOEBGJK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4724C70", Offset = "0x4723670", VA = "0x184724C70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LOKHKCBECFP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] LMJJBGCJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf CJKCELIHINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream MLLHHPADIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream PNCOLAHHOFG;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3BF62D0", Offset = "0x3BF4CD0", VA = "0x183BF62D0")]
	private LOKHKCBECFP(byte[] LMJJBGCJLAL, [In] Protobuf CJKCELIHINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x21BCF60", Offset = "0x21BB960", VA = "0x1821BCF60")]
	public static LOKHKCBECFP<Protobuf> CMMJGECCMDN<T>(ReadOnlySpan<T> HBAGFCLKGMJ)
	{
		return default(LOKHKCBECFP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BF62A0", Offset = "0x3BF4CA0", VA = "0x183BF62A0")]
	public void PIMGFJEMMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6210", Offset = "0x3BF4C10", VA = "0x183BF6210")]
	public ByteString FPLFAOELPEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3BF60E0", Offset = "0x3BF4AE0", VA = "0x183BF60E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EGBIMLKHJCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream MLLHHPADIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream BDNGBINLAJK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60AEBB0", Offset = "0x60AD5B0", VA = "0x1860AEBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KDJAKGDMIDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] LMJJBGCJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream MLLHHPADIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream PNCOLAHHOFG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60AF810", Offset = "0x60AE210", VA = "0x1860AF810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class BMAPBEPKNAC
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void HMBIGOPGLJF<From, To>(From MHLOJABNACB, To PJBELOELIMA, JHBLGOHBDMF JOFCABMGOCH);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class DHJEKJAKCAM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static HMBIGOPGLJF<From, To> HBMGKNFOHLM;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DHJEKJAKCAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60AE420", Offset = "0x60ACE20", VA = "0x1860AE420")]
	static BMAPBEPKNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x23C7200", Offset = "0x23C5C00", VA = "0x1823C7200")]
	public static void BMFDCDJPMGP<T>(HMBIGOPGLJF<T, T> NLLBDADLCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x23C7C40", Offset = "0x23C6640", VA = "0x1823C7C40")]
	public static void BMFDCDJPMGP<From, To>(HMBIGOPGLJF<From, To> NLLBDADLCPD, HMBIGOPGLJF<To, From> NMNAHLBMBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x23C6D90", Offset = "0x23C5790", VA = "0x1823C6D90")]
	public static void BMFDCDJPMGP<From, To>(HMBIGOPGLJF<From, To> HBMGKNFOHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x23CB8F0", Offset = "0x23CA2F0", VA = "0x1823CB8F0")]
	public static HMBIGOPGLJF<From, To> DJLCINBJLNO<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x23D0B20", Offset = "0x23CF520", VA = "0x1823D0B20")]
	public static void IMPCDCNKIEA<From, To>(From MHLOJABNACB, To PJBELOELIMA, JHBLGOHBDMF JOFCABMGOCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class JHBLGOHBDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PGBPALNBEDI;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA680", Offset = "0x1CE9080", VA = "0x181CEA680")]
	public JHBLGOHBDMF(NativeArray<EntityRemapUtility.EntityRemapInfo> PGBPALNBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60AF800", Offset = "0x60AE200", VA = "0x1860AF800")]
	public Entity OBNIHICCONJ(Entity DMOGDONOGKM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class EALGKPANGDG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60AEAC0", Offset = "0x60AD4C0", VA = "0x1860AEAC0")]
	public static ulong AHMNCNPHDJO(Type AKDFFJNHJJN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60AEB50", Offset = "0x60AD550", VA = "0x1860AEB50")]
	public static ulong AHMNCNPHDJO(string ADHIHHIFNKE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum IJMGIFKKPNI
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
public class JMBABIPBLJK : MOEKHOCKEJK
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
	public JMBABIPBLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class CIHCPCLLAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60AE730", Offset = "0x60AD130", VA = "0x1860AE730")]
	private unsafe static Span<byte> BKOCPAGGAMC(Unity.Entities.Chunk* EJFKDGCPOLB, int PNGHAOOEBGM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x242FB30", Offset = "0x242E530", VA = "0x18242FB30")]
	public unsafe static Span<T> LDFIMFKKKIL<T>(Unity.Entities.Chunk* EJFKDGCPOLB, int PNGHAOOEBGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x23AC8D0", Offset = "0x23AB2D0", VA = "0x1823AC8D0")]
	public static Span<T> LDFIMFKKKIL<T>(this Unity.Entities.Chunk EJFKDGCPOLB, int PNGHAOOEBGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60AE800", Offset = "0x60AD200", VA = "0x1860AE800")]
	public unsafe static Span<Entity> DPFLHOFEMMG(Unity.Entities.Chunk* EJFKDGCPOLB)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60AE860", Offset = "0x60AD260", VA = "0x1860AE860")]
	public unsafe static void JOBLGFAFDNE(Unity.Entities.Chunk* EJFKDGCPOLB, int PNGHAOOEBGM)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PMMLLLCENIK
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PMMLLLCENIK()
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
