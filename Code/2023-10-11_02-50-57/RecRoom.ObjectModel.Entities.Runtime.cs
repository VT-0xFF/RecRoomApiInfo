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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA30C0", Offset = "0x5DA1EC0", VA = "0x185DA30C0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EFNDKPDNINO<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] DKEKGFFBCJN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE330", Offset = "0x2CED130", VA = "0x182CEE330")]
	public static void IKCDJMJEHAB<TField>(int DOJILIOCHKM, string ONIBECKLJDD, KCIEHIFDMEB POEJGOPFIDE, [Out] CMIFDPMNHCO<TField> GGCGADADFCH) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB1B0", Offset = "0x2CE9FB0", VA = "0x182CEB1B0")]
	public static void AKDPGJHDMBO<TField>(int DOJILIOCHKM, string ONIBECKLJDD, [Out] DKCNFDOHIPC<TField> COPMFEAGFCB) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JLAJNKAFBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3A10", Offset = "0x5DA2810", VA = "0x185DA3A10")]
	public static FieldInfo[] OPJAKFMJGKE(Type PEMNIEMPPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class DMJCKCJMNEM<View, Data> : MFGAIFFIFKP where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType NEECIPJKOED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type ACEPFNBFOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D06960", Offset = "0x4D05760", VA = "0x184D06960", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int AFLLFLLPMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D05F20", Offset = "0x4D04D20", VA = "0x184D05F20", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D06F60", Offset = "0x4D05D60", VA = "0x184D06F60")]
	public Data KOFNICOOGKI(Entity CCHOHIEEHEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View GBIMJKBBLAM(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2780", Offset = "0x2BD1580", VA = "0x182BD2780", Slot = "14")]
	public override T GBIMJKBBLAM<T>(Entity CCHOHIEEHEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	protected DMJCKCJMNEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class MFGAIFFIFKP : KCIEHIFDMEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle IDNGANPKCPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x115E2C0", Offset = "0x115D0C0", VA = "0x18115E2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type ACEPFNBFOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int AFLLFLLPMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type KHHJJGGBCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B3740", Offset = "0x8B2540", VA = "0x1808B3740", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int EHCCOOADIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4340", Offset = "0x5DA3140", VA = "0x185DA4340", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private MDMHNBKGCGM[] MGPLDINIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9750", Offset = "0x3BB8550", VA = "0x183BB9750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual MDMHNBKGCGM[] OOKPONCCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA43B0", Offset = "0x5DA31B0", VA = "0x185DA43B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4530", Offset = "0x5DA3330", VA = "0x185DA4530")]
	public void OOCIGOIJKNJ(EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T GBIMJKBBLAM<T>(Entity CCHOHIEEHEH) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4670", Offset = "0x5DA3470", VA = "0x185DA4670", Slot = "8")]
	public (uint, uint) PCGHMBNENOA(Entity CCHOHIEEHEH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4440", Offset = "0x5DA3240", VA = "0x185DA4440", Slot = "9")]
	public bool KODOCNFJGGF(Entity CCHOHIEEHEH, (uint order, uint change) KCPGKFKLEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected MFGAIFFIFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JAMGDIHAMIK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JECAHKJAFHM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NCNMOPKBHNL AAMCEOPKDDJ
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
public interface OJMBFAMANPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNCJOGAIDPD(Entity CCHOHIEEHEH, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOIKEFLPLHJ(Entity CCHOHIEEHEH, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBNGLFIJJGK(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBJHFMAAGFO(Entity CCHOHIEEHEH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FOOOBLMDMNH<TComponentData, TValue> : CHMOADEILFB<TValue>, IDisposable where TComponentData : struct, JECAHKJAFHM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GJCAEJMONIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> NDKEAGMKBJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CBILAPKHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2E9F580", Offset = "0x2E9E380", VA = "0x182E9F580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x34C1290", Offset = "0x34C0090", VA = "0x1834C1290")]
		public bool PLJJFIKKCCL([Out] TValue GNLEHBFFNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x34C1080", Offset = "0x34BFE80", VA = "0x1834C1080")]
		public void AAFNAGDLNDC(object PFKLELGAJPH, TValue GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34C1130", Offset = "0x34BFF30", VA = "0x1834C1130")]
		public bool ILBKIBAINPM(object PFKLELGAJPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x34C11B0", Offset = "0x34BFFB0", VA = "0x1834C11B0")]
		public int JIMNIGDFLAD(object PFKLELGAJPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34C1380", Offset = "0x34C0180", VA = "0x1834C1380")]
		public GJCAEJMONIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<GJCAEJMONIC> PNKCJLEKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DAMCLELNJPB<NCNMOPKBHNL, GJCAEJMONIC> LFGEJAFCAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x340C2A0", Offset = "0x340B0A0", VA = "0x18340C2A0")]
	public FOOOBLMDMNH(EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x340BB90", Offset = "0x340A990", VA = "0x18340BB90", Slot = "4")]
	public void GNCJOGAIDPD(Entity CCHOHIEEHEH, object PFKLELGAJPH, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x340BCD0", Offset = "0x340AAD0", VA = "0x18340BCD0", Slot = "5")]
	public bool GOIKEFLPLHJ(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x340C1A0", Offset = "0x340AFA0", VA = "0x18340C1A0", Slot = "6")]
	public bool PLJJFIKKCCL(Entity CCHOHIEEHEH, [Out] TValue GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x340BB70", Offset = "0x340A970", VA = "0x18340BB70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x340C110", Offset = "0x340AF10", VA = "0x18340C110")]
	private void PJKKCFIGPGD(GJCAEJMONIC GKHHOPGENFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x340BE70", Offset = "0x340AC70", VA = "0x18340BE70")]
	private bool IBCFKMCNNDN(Entity CCHOHIEEHEH, [Out] NCNMOPKBHNL KMOBDGPHBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x340BF30", Offset = "0x340AD30", VA = "0x18340BF30")]
	private void JIMMFNFCFOP(Entity CCHOHIEEHEH, NCNMOPKBHNL KMOBDGPHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x340BB50", Offset = "0x340A950", VA = "0x18340BB50")]
	private bool ALJLAMBKCBN(NCNMOPKBHNL KMOBDGPHBOK, [Out] GJCAEJMONIC GKHHOPGENFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x340C020", Offset = "0x340AE20", VA = "0x18340C020")]
	private GJCAEJMONIC MBHHNPELNBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CHMOADEILFB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNCJOGAIDPD(Entity CCHOHIEEHEH, object PFKLELGAJPH, TValue GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOIKEFLPLHJ(Entity CCHOHIEEHEH, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLJJFIKKCCL(Entity CCHOHIEEHEH, [Out] TValue GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NCNMOPKBHNL : BLILJFBNCDH, IEquatable<NCNMOPKBHNL>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly NCNMOPKBHNL LKJBFPNKADE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int CPCFHDJMLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int MMJFKHJNAML
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51FC460", Offset = "0x51FB260", VA = "0x1851FC460", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4820", Offset = "0x5DA3620", VA = "0x185DA4820", Slot = "8")]
	public bool Equals(NCNMOPKBHNL MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4870", Offset = "0x5DA3670", VA = "0x185DA4870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DCCBDAOFFHB<THasTokensTag> : OJMBFAMANPH, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, NCNMOPKBHNL> MFDHENFACGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> PNKCJLEKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private DAMCLELNJPB<NCNMOPKBHNL, HashSet<object>> LFGEJAFCAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem NGLMJAHNOHO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC010", Offset = "0x4CBAE10", VA = "0x184CBC010")]
	public DCCBDAOFFHB(EntityManager FMCNCDMBJDH, EntityCommandBufferSystem NGLMJAHNOHO, GKFGDEJLFAD CDNEJBHGPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4CBA4A0", Offset = "0x4CB92A0", VA = "0x184CBA4A0", Slot = "4")]
	public bool GNCJOGAIDPD(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4CBAAE0", Offset = "0x4CB98E0", VA = "0x184CBAAE0", Slot = "5")]
	public bool GOIKEFLPLHJ(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4CB94C0", Offset = "0x4CB82C0", VA = "0x184CB94C0", Slot = "6")]
	public bool CBNGLFIJJGK(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9360", Offset = "0x4CB8160", VA = "0x184CB9360", Slot = "9")]
	public bool CBNGLFIJJGK(NCNMOPKBHNL KMOBDGPHBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4CBAE50", Offset = "0x4CB9C50", VA = "0x184CBAE50", Slot = "7")]
	public bool HBJHFMAAGFO(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9610", Offset = "0x4CB8410", VA = "0x184CB9610", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBCD0", Offset = "0x4CBAAD0", VA = "0x184CBBCD0")]
	private void PJKKCFIGPGD(HashSet<object> GKHHOPGENFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4CBB120", Offset = "0x4CB9F20", VA = "0x184CBB120")]
	private bool IBCFKMCNNDN(Entity CCHOHIEEHEH, [Out] NCNMOPKBHNL KMOBDGPHBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4CBB390", Offset = "0x4CBA190", VA = "0x184CBB390")]
	private bool IJBBPPLOILK(Entity CCHOHIEEHEH, [Out] NCNMOPKBHNL KMOBDGPHBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9BA0", Offset = "0x4CB89A0", VA = "0x184CB9BA0")]
	private void GLCCBFCIILC(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9870", Offset = "0x4CB8670", VA = "0x184CB9870")]
	private void EEAMNEKEAHM(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBC50", Offset = "0x4CBAA50", VA = "0x184CBBC50")]
	private void OINENABFOAG(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4CBB690", Offset = "0x4CBA490", VA = "0x184CBB690")]
	private void JIMMFNFCFOP(Entity CCHOHIEEHEH, NCNMOPKBHNL KMOBDGPHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBF50", Offset = "0x4CBAD50", VA = "0x184CBBF50")]
	private bool PNJHELKJMBO(NCNMOPKBHNL KMOBDGPHBOK, [Out] HashSet<object> GKHHOPGENFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4CBB8F0", Offset = "0x4CBA6F0", VA = "0x184CBB8F0")]
	private HashSet<object> MBHHNPELNBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FPKIFKMMJDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NGLDHKJAKDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int HLAIJKBFIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int HLFCMANHPKF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FLEHAKPGOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51FC460", Offset = "0x51FB260", VA = "0x1851FC460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LDHCJHHGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NADIGMMCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5DA48D0", Offset = "0x5DA36D0", VA = "0x185DA48D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5DA48E0", Offset = "0x5DA36E0", VA = "0x185DA48E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	private NGLDHKJAKDF(int HLAIJKBFIJH, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C3DEF0", Offset = "0x1C3CCF0", VA = "0x181C3DEF0")]
	public static NGLDHKJAKDF GNNMKFDCKJG(int HLAIJKBFIJH, int HLFCMANHPKF)
	{
		return default(NGLDHKJAKDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DA48C0", Offset = "0x5DA36C0", VA = "0x185DA48C0")]
	public static NGLDHKJAKDF CBMCNEKMNDK(int KMFMMHANJHK, int MCKBHHHCKCE)
	{
		return default(NGLDHKJAKDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DA48F0", Offset = "0x5DA36F0", VA = "0x185DA48F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JOIIDJLJMEF : JBFCEFLGDIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D88230", Offset = "0x5D87030", VA = "0x185D88230")]
	public float JJBOMBABIFH([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D88230", Offset = "0x5D87030", VA = "0x185D88230", Slot = "4")]
	private float GOKLNHCBEDE([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PNCHBAPPNFB : JBFCEFLGDIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D897F0", Offset = "0x5D885F0", VA = "0x185D897F0")]
	public float JJBOMBABIFH([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D897F0", Offset = "0x5D885F0", VA = "0x185D897F0", Slot = "4")]
	private float GOKLNHCBEDE([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FLLMIMHIMNB : JBFCEFLGDIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1892DD0", Offset = "0x1891BD0", VA = "0x181892DD0")]
	public float JJBOMBABIFH([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1892DD0", Offset = "0x1891BD0", VA = "0x181892DD0", Slot = "4")]
	private float GOKLNHCBEDE([In] float3 GNLEHBFFNFG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CMCGBNPKCJB : JBFCEFLGDIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1201160", Offset = "0x11FFF60", VA = "0x181201160")]
	public int JJBOMBABIFH([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1201160", Offset = "0x11FFF60", VA = "0x181201160", Slot = "4")]
	private int KPGPBGEAFFE([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GDMGFEDDBKO : JBFCEFLGDIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D900", Offset = "0x5D8C700", VA = "0x185D8D900")]
	public int JJBOMBABIFH([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D900", Offset = "0x5D8C700", VA = "0x185D8D900", Slot = "4")]
	private int KPGPBGEAFFE([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GEMDPAHJHNJ : JBFCEFLGDIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14AF7D0", Offset = "0x14AE5D0", VA = "0x1814AF7D0")]
	public int JJBOMBABIFH([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14AF7D0", Offset = "0x14AE5D0", VA = "0x1814AF7D0", Slot = "4")]
	private int KPGPBGEAFFE([In] int3 GNLEHBFFNFG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KGPHIIBEDMJ : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type GGPFFKDGCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type PHBGBJFFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3DE0", Offset = "0x5DA2BE0", VA = "0x185DA3DE0")]
	public KGPHIIBEDMJ(Type CONHEEJPKLN, Type JPEDOIDPFGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IDPOCOKGLBE : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type PHBGBJFFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2EC0", Offset = "0x5CC1CC0", VA = "0x185CC2EC0")]
	public IDPOCOKGLBE(Type JPEDOIDPFGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KOAHIMOCLPK : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public KOAHIMOCLPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BGCEKAEBHKH<Data> : NKGJKGDJEJL where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data BKEFLEENBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B33F0", VA = "0x1807B45F0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4441A80", Offset = "0x4440880", VA = "0x184441A80", Slot = "8")]
	protected virtual bool FDKJPOPDMPK(ReadOnlySpan<Data> GBGFELNIFAG, DLOCLBOCELG DLAHENGMLBI, [Out] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "9")]
	protected virtual bool CFACIFEFFID(int KCPGKFKLEJL, Span<Data> GBGFELNIFAG, [In] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44419C0", Offset = "0x44407C0", VA = "0x1844419C0", Slot = "5")]
	internal sealed override bool FDKJPOPDMPK(Unity.Entities.Chunk NEFPDCFOPMI, int FDIOJFOKMEG, DLOCLBOCELG DLAHENGMLBI, [Out] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x443FC50", Offset = "0x443EA50", VA = "0x18443FC50", Slot = "6")]
	internal sealed override bool CFACIFEFFID(int KCPGKFKLEJL, Unity.Entities.Chunk NEFPDCFOPMI, int FDIOJFOKMEG, [In] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7720", Offset = "0x2BC6520", VA = "0x182BC7720")]
	protected CDBCHANKMAB<Protobuf> NBDEKAFIJFD<Protobuf>(ReadOnlySpan<Data> GBGFELNIFAG) where Protobuf : IMessage, new()
	{
		return default(CDBCHANKMAB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2BC76A0", Offset = "0x2BC64A0", VA = "0x182BC76A0")]
	protected NLDFEDOBAOH<Protobuf> FAPCJHFHECK<Protobuf>(ReadOnlySpan<byte> GHHJLCMBOHI, ReadOnlySpan<Data> GBGFELNIFAG, Action<Protobuf> BJHKLOFGLCA) where Protobuf : IMessage, new()
	{
		return default(NLDFEDOBAOH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	protected BGCEKAEBHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class NKGJKGDJEJL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int MMJFKHJNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4980", Offset = "0x5DA3780", VA = "0x185DA4980", Slot = "5")]
	internal virtual bool FDKJPOPDMPK(Unity.Entities.Chunk NEFPDCFOPMI, int FDIOJFOKMEG, DLOCLBOCELG DLAHENGMLBI, [Out] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "6")]
	internal virtual bool CFACIFEFFID(int KCPGKFKLEJL, Unity.Entities.Chunk NEFPDCFOPMI, int FDIOJFOKMEG, [In] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected NKGJKGDJEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PDJCGOOFKBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class FMBIPPPJNCE : SystemBase, PDJCGOOFKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3450", Offset = "0x5DA2250", VA = "0x185DA3450")]
	public ComponentDataFromEntity PCOHFGHMBHC(int IDDPEMOGPEO, bool PFJGIECBADF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3430", Offset = "0x5DA2230", VA = "0x185DA3430")]
	public EntityExistenceLookupByEntity HGNBLIPAOOA()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3510", Offset = "0x5DA2310", VA = "0x185DA3510", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	protected FMBIPPPJNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class IALGNLMAPEN : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3620", Offset = "0x5DA2420", VA = "0x185DA3620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	protected IALGNLMAPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class PJKKHAGMCDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class LNDOMDEMCJJ : NBIHFNKMCJC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA42A0", Offset = "0x5DA30A0", VA = "0x185DA42A0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase COLCFNMLCIC();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4200", Offset = "0x5DA3000", VA = "0x185DA4200")]
	protected ComponentSystemBase FHIPGMJBKCH(params ComponentSystemBase[] DECADLJJLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x241BF40", Offset = "0x241AD40", VA = "0x18241BF40")]
	protected ComponentSystemBase FHIPGMJBKCH<T>(params ComponentSystemBase[] DECADLJJLLJ) where T : NBIHFNKMCJC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x241BF00", Offset = "0x241AD00", VA = "0x18241BF00")]
	protected ComponentSystemBase LGMINAJGMCP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x241BF00", Offset = "0x241AD00", VA = "0x18241BF00")]
	protected ComponentSystemBase EMAIPLLFFJD<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4250", Offset = "0x5DA3050", VA = "0x185DA4250")]
	protected ComponentSystemBase FODKOFINCJP(params SystemHandleUntyped[] DECADLJJLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x241BFD0", Offset = "0x241ADD0", VA = "0x18241BFD0")]
	protected ComponentSystemBase FODKOFINCJP<T>(params SystemHandleUntyped[] DECADLJJLLJ) where T : NBIHFNKMCJC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x241C060", Offset = "0x241AE60", VA = "0x18241C060")]
	protected SystemHandleUntyped OIODGOGGMML<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DA42F0", Offset = "0x5DA30F0", VA = "0x185DA42F0")]
	protected LNDOMDEMCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NBIHFNKMCJC : MLIOKEAIOIH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DA47F0", Offset = "0x5DA35F0", VA = "0x185DA47F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DA42F0", Offset = "0x5DA30F0", VA = "0x185DA42F0")]
	public NBIHFNKMCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class MLIOKEAIOIH : ComponentSystemGroup, PDJCGOOFKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DA42F0", Offset = "0x5DA30F0", VA = "0x185DA42F0")]
	protected MLIOKEAIOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class BDBHKBBMOIC : EntityCommandBufferSystem, PDJCGOOFKBH
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	protected BDBHKBBMOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JBFCEFLGDIE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo JJBOMBABIFH([In] TFrom GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EJCPJGFADGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJEGGAICAPE(T GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JINCMMMFDCG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes EHIKNGOOIMM;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3920", Offset = "0x5DA2720", VA = "0x185DA3920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct KHIAIPHJCCE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3E30", Offset = "0x5DA2C30", VA = "0x185DA3E30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FHOBFNOKJCE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType ACNKJFPHPMG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA30E0", Offset = "0x5DA1EE0", VA = "0x185DA30E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct IPIHOMICJIK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36A0E70", Offset = "0x369FC70", VA = "0x1836A0E70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct NECOHBHMOAC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> HJOJMOBKMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct NBHPIGPNMLD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T GNLEHBFFNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB9B0", Offset = "0x3BBA7B0", VA = "0x183BBB9B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct MNLIGDABLBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JBFCEFLGDIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> JHJLFAOEIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct FOPIMKPMHHI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity IIGPEJKHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> JHJLFAOEIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int BAJPLFICGDC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3520", Offset = "0x5DA2320", VA = "0x185DA3520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct EKLKFFFNOBE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CLAMEOBHGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> LFOFABHPCDD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct KNLGJHBAICP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JBFCEFLGDIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> EJHDIBNHJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> JHJLFAOEIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct NFCEDBBLEJP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JPEDOIDPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> FNKMIOLKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> APGOAIGAAIO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct NPMAFCJAOEC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JPEDOIDPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> FNKMIOLKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> APGOAIGAAIO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3BF31B0", Offset = "0x3BF1FB0", VA = "0x183BF31B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct IAEHLCOAFHC<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> LFOFABHPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> IAJACANMJMF;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36404A0", Offset = "0x363F2A0", VA = "0x1836404A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct GEOOFOEEOCH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JBFCEFLGDIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> LFOFABHPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> IAJACANMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct ICLJNIKINFC<T, TPredicate> : IJob where T : struct where TPredicate : struct, EJCPJGFADGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> MDCGGJOMELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> DHDCCMFPKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x364BCB0", Offset = "0x364AAB0", VA = "0x18364BCB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct KDDKKCHCDAJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, EJCPJGFADGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> PBMFHJPGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> LFOFABHPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct EADHNFMDEJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity JPEDOIDPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> FNKMIOLKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> MJPEHPDJMGB;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2FF0", Offset = "0x5DA1DF0", VA = "0x185DA2FF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct NALCJFFEDBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity JPEDOIDPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> FNKMIOLKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> MJPEHPDJMGB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4760", Offset = "0x5DA3560", VA = "0x185DA4760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LFKEOODNLJN
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CKALBMIGNPF
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x21CDC10", Offset = "0x21CCA10", VA = "0x1821CDC10")]
	public static bool AMONLMLCKHM<T>(this NativeArray<Entity> FNKMIOLKILH, EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LGNJJNEFDJP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HNMDHIDMDFH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public HNMDHIDMDFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EOONOGPDPOH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public EOONOGPDPOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> EPMEMFCJBHE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3ED0", Offset = "0x5DA2CD0", VA = "0x185DA3ED0")]
	public LGNJJNEFDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NJPPDLCGHBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HGGBDIGAPGE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct ANOPMCCBIKA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct NJCMHAMPNCP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal ANOPMCCBIKA<TFrom> LBLLNFOEKNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> PKELBKGJAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct BPFNAOCEHHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct NDEGOKAPDHK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal BPFNAOCEHHE<TFrom> LBLLNFOEKNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> PKELBKGJAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct KPEKGEAIBCF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct ACFJOMICDKF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal KPEKGEAIBCF<TFrom> LBLLNFOEKNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> PKELBKGJAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct FIKMOFIAOEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct LHOBOAOPLIB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal FIKMOFIAOEI<TFrom> LBLLNFOEKNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> PKELBKGJAFM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PCEEJHLJDLA
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IADFLJENKJO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x23848E0", Offset = "0x23836E0", VA = "0x1823848E0")]
	public static NativeList<T> FEOIMFGILLE<T>(this NativeList<T> FNOFMLPGPBG, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2384760", Offset = "0x2383560", VA = "0x182384760")]
	public static NativeList<T> FEOIMFGILLE<T>(this NativeArray<T> FNOFMLPGPBG, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KFPLAEKMJGB
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IPLIKHKPEBA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x23AE530", Offset = "0x23AD330", VA = "0x1823AE530")]
	[NIPMHGGHCAI]
	public static JobHandle NPLIJDJGBNO<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArrayAsync<Entity> PFOPLIKJCHB, NativeArrayAsync<T> PFDMLBFKIAP, [Optional] JobHandle AHKLOHOGJID) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23AEB10", Offset = "0x23AD910", VA = "0x1823AEB10")]
	[NIPMHGGHCAI]
	public static JobHandle NPLIJDJGBNO<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArrayAsync<Entity> PFOPLIKJCHB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23AE690", Offset = "0x23AD490", VA = "0x1823AE690")]
	[NIPMHGGHCAI]
	public static JobHandle NPLIJDJGBNO<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArray<Entity> PFOPLIKJCHB, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA37B0", Offset = "0x5DA25B0", VA = "0x185DA37B0")]
	[NIPMHGGHCAI]
	public static JobHandle NPLIJDJGBNO(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArray<Entity> PFOPLIKJCHB, ComponentTypes EHIKNGOOIMM, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3660", Offset = "0x5DA2460", VA = "0x185DA3660")]
	[NIPMHGGHCAI]
	public static JobHandle NPLIJDJGBNO(this EntityCommandBufferSystem NGLMJAHNOHO, EntityCommandBuffer GFFHLFCGKFL, NativeArray<Entity> PFOPLIKJCHB, ComponentTypes EHIKNGOOIMM, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class EFFLBFJAGBA
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2216660", Offset = "0x2215460", VA = "0x182216660")]
	[NIPMHGGHCAI]
	public static JobHandle CELPAELODGJ<T>(this EntityCommandBufferSystem NGLMJAHNOHO, EntityCommandBuffer GFFHLFCGKFL, EntityQuery LKMIGFDOIIA, T GNLEHBFFNFG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JLCIFLDDIDG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3C50", Offset = "0x5DA2A50", VA = "0x185DA3C50")]
	[NIPMHGGHCAI]
	public static JobHandle LMBHHBLKBLJ(this EntityCommandBufferSystem NGLMJAHNOHO, NativeList<Entity> PFOPLIKJCHB, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3B50", Offset = "0x5DA2950", VA = "0x185DA3B50")]
	[NIPMHGGHCAI]
	public static JobHandle LMBHHBLKBLJ(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArrayAsync<Entity> PFOPLIKJCHB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EPFOFBGCPCM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22256C0", Offset = "0x22244C0", VA = "0x1822256C0")]
	public static void BICKPBOKEPC<T>(this EntityCommandBufferSystem NGLMJAHNOHO, EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2225EF0", Offset = "0x2224CF0", VA = "0x182225EF0")]
	[NIPMHGGHCAI]
	public static JobHandle JFENEGEEPAH<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeListAsync<Entity> PFOPLIKJCHB, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2225D60", Offset = "0x2224B60", VA = "0x182225D60")]
	[NIPMHGGHCAI]
	public static JobHandle JFENEGEEPAH<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArrayAsync<Entity> PFOPLIKJCHB, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ENIPAIDJPCA
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2223C30", Offset = "0x2222A30", VA = "0x182223C30")]
	[NIPMHGGHCAI]
	public static JobHandle BOKIBJJAACB<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArray<Entity> PFOPLIKJCHB, NativeArray<T> PFDMLBFKIAP, JobHandle AHKLOHOGJID) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class DHNMMDCEMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21F7490", Offset = "0x21F6290", VA = "0x1821F7490")]
	[NIPMHGGHCAI]
	public static JobHandle FIPPGBFMLKN<T>(this EntityCommandBufferSystem NGLMJAHNOHO, NativeArray<Entity> PFOPLIKJCHB, T GNLEHBFFNFG, [Optional] JobHandle AHKLOHOGJID) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x21F7570", Offset = "0x21F6370", VA = "0x1821F7570")]
	[NIPMHGGHCAI]
	public static JobHandle FIPPGBFMLKN<T>(this EntityCommandBufferSystem NGLMJAHNOHO, EntityCommandBuffer GFFHLFCGKFL, NativeArray<Entity> PFOPLIKJCHB, T GNLEHBFFNFG, [Optional] JobHandle AHKLOHOGJID) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BHDEJIGMPAI
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x216D320", Offset = "0x216C120", VA = "0x18216D320")]
	public static NativeList<T> FEOIMFGILLE<T>(NativeList<T> FNOFMLPGPBG, Allocator JFLEKJGGDHL) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GJFKBNDEEIM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2359220", Offset = "0x2358020", VA = "0x182359220")]
	public static NativeArray<T> LDIDNFOBLHA<T>(this NativeList<Entity> FNOFMLPGPBG, EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2358CE0", Offset = "0x2357AE0", VA = "0x182358CE0")]
	public static NativeArray<T> LDIDNFOBLHA<T>(this NativeArray<Entity> FNOFMLPGPBG, EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class LEJKIEEHFEH
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct APALKDNNDOM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct MJFPAHONHLI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public APALKDNNDOM<TFrom> PKELBKGJAFM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct EBBLDLPFBML<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct PKJFINBGGMM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public EBBLDLPFBML<TFrom> PKELBKGJAFM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct FBEFCJFGEOM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct CDEBGMIHJNP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public FBEFCJFGEOM<TFrom> PKELBKGJAFM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> PBMFHJPGDCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FMPFGIFFDGA
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BIPOFAOAEDM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct IEIPAJBBFEJ : JBFCEFLGDIE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JFJMMEPAGGE;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3650", Offset = "0x5DA2450", VA = "0x185DA3650")]
		[BurstCompatible]
		public Entity JJBOMBABIFH([In] Entity GNLEHBFFNFG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3650", Offset = "0x5DA2450", VA = "0x185DA3650", Slot = "4")]
		private Entity GKJLAOKHBBB([In] Entity GNLEHBFFNFG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class CILDPENNCEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct OIEHJLMAEID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> MDCGGJOMELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct HINDKFFFEHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> MDCGGJOMELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct IMPDBGKJAJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> MDCGGJOMELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> PBMFHJPGDCA;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2285950", Offset = "0x2284750", VA = "0x182285950")]
		public NativeListAsync<Entity> HJEGGAICAPE<TPredicate>() where TPredicate : struct, EJCPJGFADGE<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x21CD380", Offset = "0x21CC180", VA = "0x1821CD380")]
	public static IMPDBGKJAJG<T> JNPLJMIFOAA<T>(this NativeArrayAsync<Entity> FNKMIOLKILH, NativeArrayAsync<T> FNOFMLPGPBG, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct
	{
		return default(IMPDBGKJAJG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class FNHCAADHJDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2349D60", Offset = "0x2348B60", VA = "0x182349D60")]
	public static NativeListAsync<Entity> DFPPKFGFNAL<T, TPredicate>(this NativeArrayAsync<T> FNOFMLPGPBG, NativeArrayAsync<Entity> FNKMIOLKILH, Allocator JFLEKJGGDHL = Allocator.TempJob) where T : struct where TPredicate : struct, EJCPJGFADGE<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2349E20", Offset = "0x2348C20", VA = "0x182349E20")]
	private static NativeListAsync<Entity> MDJNDHFJDKO<T, TPredicate>(NativeArrayAsync<T> IMHFEPJFBNA, NativeArrayAsync<Entity> FNKMIOLKILH, int JMNJMKJAMOL, Allocator JFLEKJGGDHL) where T : struct where TPredicate : struct, EJCPJGFADGE<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class DJFPBCDDHAM
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DGLLIHCOJDB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OLPEPLHNGJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NACDPIPNFID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> PBMFHJPGDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct HNCEDIDLNEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator JFLEKJGGDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> PBMFHJPGDCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class JAHECPEJILE
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DJIKAHBLDBL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x21F8CB0", Offset = "0x21F7AB0", VA = "0x1821F8CB0")]
	public static NativeList<Entity> DDOBLHAKPOL<T>(this NativeArray<Entity> FNKMIOLKILH, EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class KPFCIIIADMA
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class OCFMJJLIODG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct GJPCNDBGEHF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> FNIMPMJDPGM;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public GJPCNDBGEHF(NativeArray<TSrc> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public FENDIABJLGD<TSrc, TValue> GJPIJDJADHB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(FENDIABJLGD<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct FENDIABJLGD<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> FNIMPMJDPGM;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public FENDIABJLGD(NativeArray<TSrc> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public DNCFBLHDKEA<TSrc, TValue, TSelector> INIPBBFGCNK<TSelector>() where TSelector : struct, JBFCEFLGDIE<TSrc, TValue>
		{
			return default(DNCFBLHDKEA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct DNCFBLHDKEA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JBFCEFLGDIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> FNIMPMJDPGM;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public DNCFBLHDKEA(NativeArray<TSrc> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4D0D530", Offset = "0x4D0C330", VA = "0x184D0D530")]
		public PFCCJKOCOJP<TSrc, TValue, TSelector> FHIPGMJBKCH()
		{
			return default(PFCCJKOCOJP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct LJOKMBIJPKJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JBFCEFLGDIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> FNIMPMJDPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector HBDMMGNDEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int DOJILIOCHKM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x3957A90", Offset = "0x3956890", VA = "0x183957A90")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int CPCFHDJMLHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C3030", Offset = "0x8C1E30", VA = "0x1808C3030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int DCLHHJJDFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1C3FD50", Offset = "0x1C3EB50", VA = "0x181C3FD50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3957B20", Offset = "0x3956920", VA = "0x183957B20")]
		public LJOKMBIJPKJ(NativeArray<TSrc> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x39579A0", Offset = "0x39567A0", VA = "0x1839579A0")]
		public bool AJCELHIKDOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x39579B0", Offset = "0x39567B0", VA = "0x1839579B0")]
		private TSrc ILLBNGMBDLH(int FJLKBMOCNHL)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct PFCCJKOCOJP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JBFCEFLGDIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LJOKMBIJPKJ<TSrc, TValue, TSelector> LOJCJECHJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue CHMPLOMHPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int KMGLIANDLEO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public NGLDHKJAKDF OHDIMGBBAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6A20", Offset = "0x3DD5820", VA = "0x183DD6A20")]
			get
			{
				return default(NGLDHKJAKDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue NCDCLPFOCFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, NGLDHKJAKDF range) MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6A60", Offset = "0x3DD5860", VA = "0x183DD6A60")]
			get
			{
				return default((TValue, NGLDHKJAKDF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B40", Offset = "0x3DD5940", VA = "0x183DD6B40")]
		public PFCCJKOCOJP(NativeArray<TSrc> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x35BC300", Offset = "0x35BB100", VA = "0x1835BC300")]
		public PFCCJKOCOJP<TSrc, TValue, TSelector> MIBGMGJFDKE()
		{
			return default(PFCCJKOCOJP<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD68E0", Offset = "0x3DD56E0", VA = "0x183DD68E0")]
		public bool AJCELHIKDOO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x24EDBF0", Offset = "0x24EC9F0", VA = "0x1824EDBF0")]
	public static GJPCNDBGEHF<T> LJMJEKMCILM<T>(this NativeList<T> NDKEAGMKBJJ) where T : struct
	{
		return default(GJPCNDBGEHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
	public static GJPCNDBGEHF<T> LJMJEKMCILM<T>(this NativeArray<T> FNIMPMJDPGM) where T : struct
	{
		return default(GJPCNDBGEHF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class CNNDJLCOJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct HPGFKHGNKBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly FNIMPMJDPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int KMGLIANDLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int CLHPBEAGFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T CHMPLOMHPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T LEKCIABMLHF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NGLDHKJAKDF OHDIMGBBAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x35BC2F0", Offset = "0x35BB0F0", VA = "0x1835BC2F0")]
			get
			{
				return default(NGLDHKJAKDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T NCDCLPFOCFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x30DFEB0", Offset = "0x30DECB0", VA = "0x1830DFEB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, NGLDHKJAKDF) MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x35BC410", Offset = "0x35BB210", VA = "0x1835BC410")]
			get
			{
				return default((T, NGLDHKJAKDF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x35BC550", Offset = "0x35BB350", VA = "0x1835BC550")]
		public HPGFKHGNKBK(NativeArray<T> FNIMPMJDPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x35BC320", Offset = "0x35BB120", VA = "0x1835BC320")]
		public HPGFKHGNKBK<T> MIBGMGJFDKE()
		{
			return default(HPGFKHGNKBK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x35BBF40", Offset = "0x35BAD40", VA = "0x1835BBF40")]
		public bool AJCELHIKDOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x22844B0", Offset = "0x22832B0", VA = "0x1822844B0")]
		public CDLOGHFHACM<T, TComparer> EDHJFILBOBM<TComparer>([Optional] TComparer KOHPFGLFOKE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(CDLOGHFHACM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct CDLOGHFHACM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly FNIMPMJDPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int KMGLIANDLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int CLHPBEAGFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T CHMPLOMHPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T LEKCIABMLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer KOHPFGLFOKE;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NGLDHKJAKDF OHDIMGBBAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x35BC2F0", Offset = "0x35BB0F0", VA = "0x1835BC2F0")]
			get
			{
				return default(NGLDHKJAKDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T NCDCLPFOCFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x30DFEB0", Offset = "0x30DECB0", VA = "0x1830DFEB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, NGLDHKJAKDF range) MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x47379A0", Offset = "0x47367A0", VA = "0x1847379A0")]
			get
			{
				return default((T, NGLDHKJAKDF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4737A70", Offset = "0x4736870", VA = "0x184737A70")]
		public CDLOGHFHACM(NativeArray<T>.ReadOnly FNIMPMJDPGM, TComparer KOHPFGLFOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4737960", Offset = "0x4736760", VA = "0x184737960")]
		public CDLOGHFHACM<T, TComparer> MIBGMGJFDKE()
		{
			return default(CDLOGHFHACM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4737780", Offset = "0x4736580", VA = "0x184737780")]
		public bool AJCELHIKDOO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21D0530", Offset = "0x21CF330", VA = "0x1821D0530")]
	public static HPGFKHGNKBK<T> FHIPGMJBKCH<T>(this NativeArray<T> FNIMPMJDPGM) where T : struct
	{
		return default(HPGFKHGNKBK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FKEDDDLBCNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class DPFMGLHKBIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct NLDFEDOBAOH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GJILEAAJLOE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NLDFEDOBAOH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x33B9590", Offset = "0x33B8390", VA = "0x1833B9590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public GJILEAAJLOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34C1A10", Offset = "0x34C0810", VA = "0x1834C1A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x34C1BC0", Offset = "0x34C09C0", VA = "0x1834C1BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> BJHKLOFGLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream MMGOENDACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream PEPGKMENGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf LAIHBNMGAMM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3780", Offset = "0x3BE2580", VA = "0x183BE3780")]
	private NLDFEDOBAOH(byte[] BKOBMCKFFFH, Action<Protobuf> BJHKLOFGLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2290460", Offset = "0x228F260", VA = "0x182290460")]
	public static NLDFEDOBAOH<Protobuf> HKJMJGOBNGA<Data>(ReadOnlySpan<byte> GHHJLCMBOHI, ReadOnlySpan<Data> GBGFELNIFAG, Action<Protobuf> BJHKLOFGLCA)
	{
		return default(NLDFEDOBAOH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BE35F0", Offset = "0x3BE23F0", VA = "0x183BE35F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3630", Offset = "0x3BE2430", VA = "0x183BE3630", Slot = "4")]
	[IteratorStateMachine(typeof(NLDFEDOBAOH<>.GJILEAAJLOE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3720", Offset = "0x3BE2520", VA = "0x183BE3720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CDBCHANKMAB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf LAIHBNMGAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream MMGOENDACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream JLHMKHIFBHP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4736AC0", Offset = "0x47358C0", VA = "0x184736AC0")]
	private CDBCHANKMAB(byte[] BKOBMCKFFFH, [In] Protobuf LAIHBNMGAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7810", Offset = "0x2BC6610", VA = "0x182BC7810")]
	public static CDBCHANKMAB<Protobuf> HKJMJGOBNGA<T>(ReadOnlySpan<T> GBGFELNIFAG)
	{
		return default(CDBCHANKMAB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4736960", Offset = "0x4735760", VA = "0x184736960")]
	public void DCADHNJKBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x47368D0", Offset = "0x47356D0", VA = "0x1847368D0")]
	public ByteString AAKHFJHDIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4736990", Offset = "0x4735790", VA = "0x184736990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EFDKENIMMAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream MMGOENDACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream PEPGKMENGBN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3080", Offset = "0x5DA1E80", VA = "0x185DA3080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct OIEEFKMFHNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream MMGOENDACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream JLHMKHIFBHP;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4990", Offset = "0x5DA3790", VA = "0x185DA4990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class FJABLLKAODG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void JCABNCAGFFH<From, To>(From PKELBKGJAFM, To GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class DJNOKKANDJK<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static JCABNCAGFFH<From, To> NANHDJLGDNC;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DJNOKKANDJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3160", Offset = "0x5DA1F60", VA = "0x185DA3160")]
	static FJABLLKAODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x233D930", Offset = "0x233C730", VA = "0x18233D930")]
	public static void KHKAHHGLJHG<T>(JCABNCAGFFH<T, T> AOPMMCHPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x233D630", Offset = "0x233C430", VA = "0x18233D630")]
	public static void KHKAHHGLJHG<From, To>(JCABNCAGFFH<From, To> AOPMMCHPBND, JCABNCAGFFH<To, From> PAOAJDPBNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x233D5C0", Offset = "0x233C3C0", VA = "0x18233D5C0")]
	public static void KHKAHHGLJHG<From, To>(JCABNCAGFFH<From, To> NANHDJLGDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2337350", Offset = "0x2336150", VA = "0x182337350")]
	public static JCABNCAGFFH<From, To> JCEBPLBFDPJ<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2334B80", Offset = "0x2333980", VA = "0x182334B80")]
	public static void IGEJICFKKFB<From, To>(From PKELBKGJAFM, To GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DLOCLBOCELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> FINNNGNFMBN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C08190", Offset = "0x1C06F90", VA = "0x181C08190")]
	public DLOCLBOCELG(NativeArray<EntityRemapUtility.EntityRemapInfo> FINNNGNFMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2FE0", Offset = "0x5DA1DE0", VA = "0x185DA2FE0")]
	public Entity DKBFMJIPNCG(Entity JIHPAFENIMM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class DDMOHAOCCNI
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2EF0", Offset = "0x5DA1CF0", VA = "0x185DA2EF0")]
	public static ulong LFNJBHNODDM(Type PEMNIEMPPLO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2F80", Offset = "0x5DA1D80", VA = "0x185DA2F80")]
	public static ulong LFNJBHNODDM(string FOLDAPDEFDP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum PFMJKAHLNBE
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
public class LBAGHLOGJIN : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public LBAGHLOGJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class LHKOKIPMFIM
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3F60", Offset = "0x5DA2D60", VA = "0x185DA3F60")]
	private unsafe static Span<byte> DLJHFDCEDIE(Unity.Entities.Chunk* NEFPDCFOPMI, int FDIOJFOKMEG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x240AB80", Offset = "0x2409980", VA = "0x18240AB80")]
	public unsafe static Span<T> FEAKJEMNMMH<T>(Unity.Entities.Chunk* NEFPDCFOPMI, int FDIOJFOKMEG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x240AB50", Offset = "0x2409950", VA = "0x18240AB50")]
	public static Span<T> FEAKJEMNMMH<T>(this Unity.Entities.Chunk NEFPDCFOPMI, int FDIOJFOKMEG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41A0", Offset = "0x5DA2FA0", VA = "0x185DA41A0")]
	public unsafe static Span<Entity> OOHPHPJAMBN(Unity.Entities.Chunk* NEFPDCFOPMI)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4030", Offset = "0x5DA2E30", VA = "0x185DA4030")]
	public unsafe static void EOCKAINKMIG(Unity.Entities.Chunk* NEFPDCFOPMI, int FDIOJFOKMEG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class IKMPJPADFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKMPJPADFGH()
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
