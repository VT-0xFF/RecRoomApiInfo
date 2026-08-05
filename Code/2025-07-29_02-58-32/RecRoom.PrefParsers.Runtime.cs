using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OGHKLFFIOOP : LABNKHCBIEH<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86E6080", Offset = "0x86E4A80", VA = "0x1886E6080", Slot = "9")]
	public override string AGNKEKDJGCC(bool GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86E60D0", Offset = "0x86E4AD0", VA = "0x1886E60D0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] bool PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86E6130", Offset = "0x86E4B30", VA = "0x1886E6130")]
	public OGHKLFFIOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class HOLDOKOPICJ : LABNKHCBIEH<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86E5440", Offset = "0x86E3E40", VA = "0x1886E5440", Slot = "9")]
	public override string AGNKEKDJGCC(DateTime GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86E54D0", Offset = "0x86E3ED0", VA = "0x1886E54D0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] DateTime PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86E5570", Offset = "0x86E3F70", VA = "0x1886E5570")]
	public HOLDOKOPICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GPEMNEPBMIF<TEnum> : LABNKHCBIEH<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type OMAGHKKMDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DODHOEEHOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] EJKNLPOFFNN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0F80", Offset = "0x4FBF980", VA = "0x184FC0F80")]
	[Preserve]
	public GPEMNEPBMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0BB0", Offset = "0x4FBF5B0", VA = "0x184FC0BB0", Slot = "9")]
	public override string AGNKEKDJGCC(TEnum GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0DB0", Offset = "0x4FBF7B0", VA = "0x184FC0DB0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] TEnum PDKJBMPOMNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NPNPOONAJJO<TEnum> : LABNKHCBIEH<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type OMAGHKKMDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BJDFMCDCHBO MGIPHKPCPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool DODHOEEHOGE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58F3770", Offset = "0x58F2170", VA = "0x1858F3770")]
	[Preserve]
	public NPNPOONAJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58F2F50", Offset = "0x58F1950", VA = "0x1858F2F50", Slot = "9")]
	public override string AGNKEKDJGCC(TEnum GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x58F33B0", Offset = "0x58F1DB0", VA = "0x1858F33B0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] TEnum PDKJBMPOMNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class MEIFFLJDNOC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, BJDFMCDCHBO> NHIKEOABCEE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86E56F0", Offset = "0x86E40F0", VA = "0x1886E56F0")]
	public static BJDFMCDCHBO KBHBPJBNIJF(Type NKIGFHADNFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HJFGCPDLLBG<T> : LABNKHCBIEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E16A00", Offset = "0x3E15400", VA = "0x183E16A00", Slot = "9")]
	public override string AGNKEKDJGCC(T GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5050A50", Offset = "0x504F450", VA = "0x185050A50", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48FE580", Offset = "0x48FCF80", VA = "0x1848FE580")]
	public HJFGCPDLLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class HNHOAIAFLHC<TCollection, T> : LABNKHCBIEH<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly GMOIOMKHGMM<T> DPDJCDEOHJA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5066B70", Offset = "0x5065570", VA = "0x185066B70")]
	protected HNHOAIAFLHC(GMOIOMKHGMM<T> DPDJCDEOHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50636B0", Offset = "0x50620B0", VA = "0x1850636B0", Slot = "9")]
	public override string AGNKEKDJGCC(TCollection GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5064980", Offset = "0x5063380", VA = "0x185064980", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] TCollection PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection NCLNMEFKMAO(IEnumerable<T> PDBEMMKOCBP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5063A30", Offset = "0x5062430", VA = "0x185063A30", Slot = "12")]
	internal virtual IEnumerable<string> CCPAMDILHPG(string GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5063D00", Offset = "0x5062700", VA = "0x185063D00")]
	[CompilerGenerated]
	private string MIJOCIKLJEC(T ELPCBPJLJEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JDCFPEEODLK<T> : HNHOAIAFLHC<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x505D220", Offset = "0x505BC20", VA = "0x18505D220")]
	[Preserve]
	public JDCFPEEODLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	[Preserve]
	public JDCFPEEODLK(GMOIOMKHGMM<T> DPDJCDEOHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x53CD010", Offset = "0x53CBA10", VA = "0x1853CD010", Slot = "11")]
	protected override T[] NCLNMEFKMAO(IEnumerable<T> PDBEMMKOCBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DIEDDCNIFDE<T> : HNHOAIAFLHC<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x505D220", Offset = "0x505BC20", VA = "0x18505D220")]
	[Preserve]
	public DIEDDCNIFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	[Preserve]
	public DIEDDCNIFDE([Optional] GMOIOMKHGMM<T> DPDJCDEOHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70011B0", Offset = "0x6FFFBB0", VA = "0x1870011B0", Slot = "11")]
	protected override List<T> NCLNMEFKMAO(IEnumerable<T> PDBEMMKOCBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PGFMMHHEEJM<T> : LABNKHCBIEH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? DBOLJCHAOEJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5882790", Offset = "0x5881190", VA = "0x185882790")]
	public PGFMMHHEEJM(JsonSerializerSettings? PPDGPHABJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B18B20", Offset = "0x5B17520", VA = "0x185B18B20", Slot = "9")]
	public override string AGNKEKDJGCC(T GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B18B80", Offset = "0x5B17580", VA = "0x185B18B80", Slot = "10")]
	protected override bool NHOLMOMDPHC([NotNull] string GMLILPJAKBM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FHCCPFDGGMC : LABNKHCBIEH<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86E5260", Offset = "0x86E3C60", VA = "0x1886E5260", Slot = "9")]
	public override string AGNKEKDJGCC(byte GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86E52C0", Offset = "0x86E3CC0", VA = "0x1886E52C0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] byte PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86E5350", Offset = "0x86E3D50", VA = "0x1886E5350")]
	public FHCCPFDGGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class AFHMIBJLABK : LABNKHCBIEH<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86E4DF0", Offset = "0x86E37F0", VA = "0x1886E4DF0", Slot = "9")]
	public override string AGNKEKDJGCC(short GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x86E4E50", Offset = "0x86E3850", VA = "0x1886E4E50", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] short PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86E4EF0", Offset = "0x86E38F0", VA = "0x1886E4EF0")]
	public AFHMIBJLABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class KPMAGEKOKGN : LABNKHCBIEH<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86E55B0", Offset = "0x86E3FB0", VA = "0x1886E55B0", Slot = "9")]
	public override string AGNKEKDJGCC(ushort GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86E5610", Offset = "0x86E4010", VA = "0x1886E5610", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] ushort PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86E56B0", Offset = "0x86E40B0", VA = "0x1886E56B0")]
	public KPMAGEKOKGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class POIFKCIOEEG : LABNKHCBIEH<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86E6520", Offset = "0x86E4F20", VA = "0x1886E6520", Slot = "9")]
	public override string AGNKEKDJGCC(int GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86E6580", Offset = "0x86E4F80", VA = "0x1886E6580", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] int PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86E6610", Offset = "0x86E5010", VA = "0x1886E6610")]
	public POIFKCIOEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OMHMMCNEBCE : LABNKHCBIEH<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86E62B0", Offset = "0x86E4CB0", VA = "0x1886E62B0", Slot = "9")]
	public override string AGNKEKDJGCC(uint GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86E6310", Offset = "0x86E4D10", VA = "0x1886E6310", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] uint PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86E63A0", Offset = "0x86E4DA0", VA = "0x1886E63A0")]
	public OMHMMCNEBCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OLHNOHGNJAM : LABNKHCBIEH<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86E6170", Offset = "0x86E4B70", VA = "0x1886E6170", Slot = "9")]
	public override string AGNKEKDJGCC(long GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86E61D0", Offset = "0x86E4BD0", VA = "0x1886E61D0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] long PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86E6270", Offset = "0x86E4C70", VA = "0x1886E6270")]
	public OLHNOHGNJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PBOLDOBKOCP : LABNKHCBIEH<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86E63E0", Offset = "0x86E4DE0", VA = "0x1886E63E0", Slot = "9")]
	public override string AGNKEKDJGCC(ulong GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86E6440", Offset = "0x86E4E40", VA = "0x1886E6440", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] ulong PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86E64E0", Offset = "0x86E4EE0", VA = "0x1886E64E0")]
	public PBOLDOBKOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NAHJBPGHONM : LABNKHCBIEH<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86E5E60", Offset = "0x86E4860", VA = "0x1886E5E60", Slot = "9")]
	public override string AGNKEKDJGCC(float GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x86E5ED0", Offset = "0x86E48D0", VA = "0x1886E5ED0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] float PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86E5F60", Offset = "0x86E4960", VA = "0x1886E5F60")]
	public NAHJBPGHONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BJDFMCDCHBO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LNJHKFOFBHO(object GMLILPJAKBM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENFCAPKKIHN([CanBeNull] string GMLILPJAKBM, [Out] object PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GMOIOMKHGMM<T> : BJDFMCDCHBO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AGNKEKDJGCC(T GMLILPJAKBM);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGIANNPEOKC([CanBeNull] string GMLILPJAKBM, [Out] T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IANIPNEDGNP([CanBeNull] string GMLILPJAKBM, [Optional] T KKCMINIPIBD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class LABNKHCBIEH<T> : GMOIOMKHGMM<T>, BJDFMCDCHBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type FCHCBMFNMKC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x557D160", Offset = "0x557BB60", VA = "0x18557D160")]
	protected LABNKHCBIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x557CF50", Offset = "0x557B950", VA = "0x18557CF50")]
	private T BCDEMLDDLCA(object CEFJEHJNIAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string AGNKEKDJGCC(T GMLILPJAKBM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x557D030", Offset = "0x557BA30", VA = "0x18557D030", Slot = "7")]
	public string LNJHKFOFBHO(object GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x557D140", Offset = "0x557BB40", VA = "0x18557D140", Slot = "5")]
	public bool NGIANNPEOKC(string GMLILPJAKBM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NHOLMOMDPHC([NotNull] string GMLILPJAKBM, [Out] T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x557D080", Offset = "0x557BA80", VA = "0x18557D080", Slot = "8")]
	private bool MPBHNHHHEGM(string GMLILPJAKBM, [Out] object PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x557CFE0", Offset = "0x557B9E0", VA = "0x18557CFE0", Slot = "6")]
	public T IANIPNEDGNP(string GMLILPJAKBM, [Optional] T KKCMINIPIBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HCMFIJLLOGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GMOIOMKHGMM<T> MDAKIDAOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2E20", Offset = "0x4DE1820", VA = "0x184DE2E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x43FC010", Offset = "0x43FAA10", VA = "0x1843FC010")]
	public static GMOIOMKHGMM<TSerialized> EGBHMFFBJKO<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x50080F0", Offset = "0x5006AF0", VA = "0x1850080F0")]
	public static BJDFMCDCHBO EGBHMFFBJKO(Type LHCKDGCJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5009DF0", Offset = "0x50087F0", VA = "0x185009DF0")]
	private static BJDFMCDCHBO FFKAANFHCPB(Type FANAAMLKIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x500AEF0", Offset = "0x50098F0", VA = "0x18500AEF0")]
	private static BJDFMCDCHBO NLAHECFCDBD(Type FANAAMLKIBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class IDDDAEPFINF<TCollection> : HNHOAIAFLHC<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KLHGOMIJJIM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string <>3__input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IDDDAEPFINF<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PLCOAGOGGNJ<StringBuilder> <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private StringBuilder <partBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool <insideQuotes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public KLHGOMIJJIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4980", Offset = "0x4EB3380", VA = "0x184EB4980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5501480", Offset = "0x54FFE80", VA = "0x185501480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5501430", Offset = "0x54FFE30", VA = "0x185501430")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55019B0", Offset = "0x55003B0", VA = "0x1855019B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x55018E0", Offset = "0x55002E0", VA = "0x1855018E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x54C1FD0", Offset = "0x54C09D0", VA = "0x1854C1FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool CFNLNBACBCK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x511D990", Offset = "0x511C390", VA = "0x18511D990")]
	protected IDDDAEPFINF(bool CFNLNBACBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x511D600", Offset = "0x511C000", VA = "0x18511D600", Slot = "9")]
	public override string AGNKEKDJGCC(TCollection GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x511D8E0", Offset = "0x511C2E0", VA = "0x18511D8E0", Slot = "12")]
	[IteratorStateMachine(typeof(IDDDAEPFINF<>.KLHGOMIJJIM))]
	internal override IEnumerable<string> CCPAMDILHPG(string GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x511D860", Offset = "0x511C260", VA = "0x18511D860")]
	[CompilerGenerated]
	internal static string BJNKBGBPIFN(StringBuilder DGMDJMAFLHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ODCJOONMCGF : IDDDAEPFINF<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x86E6030", Offset = "0x86E4A30", VA = "0x1886E6030")]
	[Preserve]
	public ODCJOONMCGF(bool CFNLNBACBCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86E5FA0", Offset = "0x86E49A0", VA = "0x1886E5FA0", Slot = "11")]
	protected override List<string> NCLNMEFKMAO(IEnumerable<string> PDBEMMKOCBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GDECMNCPMAF : IDDDAEPFINF<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86E53F0", Offset = "0x86E3DF0", VA = "0x1886E53F0")]
	[Preserve]
	public GDECMNCPMAF(bool CFNLNBACBCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86E5390", Offset = "0x86E3D90", VA = "0x1886E5390", Slot = "11")]
	protected override string[] NCLNMEFKMAO(IEnumerable<string> PDBEMMKOCBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class BAJAJIHCEMP : LABNKHCBIEH<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "9")]
	public override string AGNKEKDJGCC(string GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86E4F30", Offset = "0x86E3930", VA = "0x1886E4F30", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] string PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86E4F50", Offset = "0x86E3950", VA = "0x1886E4F50")]
	public BAJAJIHCEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CJMHDNHFPEB : LABNKHCBIEH<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x86E4F90", Offset = "0x86E3990", VA = "0x1886E4F90", Slot = "9")]
	public override string AGNKEKDJGCC(TimeSpan GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86E50B0", Offset = "0x86E3AB0", VA = "0x1886E50B0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] TimeSpan PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x86E5220", Offset = "0x86E3C20", VA = "0x1886E5220")]
	public CJMHDNHFPEB()
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
