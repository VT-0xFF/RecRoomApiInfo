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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F09C00", Offset = "0x7F08600", VA = "0x187F09C00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F08DD0", Offset = "0x7F077D0", VA = "0x187F08DD0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MMGDHABHMMF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IDLHGOBNGLO CCGKKINMCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PCMPFPHAMNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFENIGGADHM(Entity FCFDGFFMMDF, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OFJOKDEMKGB(Entity FCFDGFFMMDF, object BECBHDDLOHA, [Out] bool GLKCAAGPMAP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LHCFBCPMIBA(Entity FCFDGFFMMDF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MOMCODJGLBE<TComponentData, TValue> : ILJOKLMLHDI<TValue>, IDisposable where TComponentData : struct, MMGDHABHMMF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class CGKLFLKDEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> IBKFNAMHILN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int IMMMMMEPNJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4255850", Offset = "0x4254250", VA = "0x184255850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6583C30", Offset = "0x6582630", VA = "0x186583C30")]
		public bool JFPEFAIMLLJ([Out] TValue PCDAHJCDHHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6583D00", Offset = "0x6582700", VA = "0x186583D00")]
		public void PBDMKLNODMP(object BECBHDDLOHA, TValue PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6583AD0", Offset = "0x65824D0", VA = "0x186583AD0")]
		public bool DAAFLACHELB(object BECBHDDLOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6583B50", Offset = "0x6582550", VA = "0x186583B50")]
		public int HHIDBDHOLJB(object BECBHDDLOHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6583DB0", Offset = "0x65827B0", VA = "0x186583DB0")]
		public CGKLFLKDEPG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<CGKLFLKDEPG> DIOCEBLJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EOFNLJOONEC<IDLHGOBNGLO, CGKLFLKDEPG> KBEDFABBBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager CBHCEEBBPPJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x54ACBA0", Offset = "0x54AB5A0", VA = "0x1854ACBA0")]
	public MOMCODJGLBE(EntityManager CBHCEEBBPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x54AC500", Offset = "0x54AAF00", VA = "0x1854AC500", Slot = "4")]
	public void GFENIGGADHM(Entity FCFDGFFMMDF, object BECBHDDLOHA, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54ACA20", Offset = "0x54AB420", VA = "0x1854ACA20", Slot = "5")]
	public bool OFJOKDEMKGB(Entity FCFDGFFMMDF, object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54AC6D0", Offset = "0x54AB0D0", VA = "0x1854AC6D0", Slot = "6")]
	public bool JFPEFAIMLLJ(Entity FCFDGFFMMDF, [Out] TValue PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x54AC4E0", Offset = "0x54AAEE0", VA = "0x1854AC4E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x54AC640", Offset = "0x54AB040", VA = "0x1854AC640")]
	private void GHHPGCPFONM(CGKLFLKDEPG BHFNNGPLOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x54AC7B0", Offset = "0x54AB1B0", VA = "0x1854AC7B0")]
	private bool KPLEDPHMDHJ(Entity FCFDGFFMMDF, [Out] IDLHGOBNGLO GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x54AC860", Offset = "0x54AB260", VA = "0x1854AC860")]
	private void LKFLBNCAJAC(Entity FCFDGFFMMDF, IDLHGOBNGLO GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x54AC620", Offset = "0x54AB020", VA = "0x1854AC620")]
	private bool GHGPAEPCAFL(IDLHGOBNGLO GCKDJGKENJL, [Out] CGKLFLKDEPG BHFNNGPLOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x54AC940", Offset = "0x54AB340", VA = "0x1854AC940")]
	private CGKLFLKDEPG MOODOBIPBAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ILJOKLMLHDI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFENIGGADHM(Entity FCFDGFFMMDF, object BECBHDDLOHA, TValue PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OFJOKDEMKGB(Entity FCFDGFFMMDF, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFPEFAIMLLJ(Entity FCFDGFFMMDF, [Out] TValue PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IDLHGOBNGLO : MCDNNIEBNOJ, IEquatable<IDLHGOBNGLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IDLHGOBNGLO HLCKODHBFKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EHHACNLGFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F092D0", Offset = "0x7F07CD0", VA = "0x187F092D0", Slot = "8")]
	public bool Equals(IDLHGOBNGLO NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F09320", Offset = "0x7F07D20", VA = "0x187F09320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OIKBPNNEKOJ<THasTokensTag> : PCMPFPHAMNB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, IDLHGOBNGLO> DFKFLFMEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> DIOCEBLJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EOFNLJOONEC<IDLHGOBNGLO, HashSet<object>> KBEDFABBBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager CBHCEEBBPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem KDHHDHABEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56647D0", Offset = "0x56631D0", VA = "0x1856647D0")]
	public OIKBPNNEKOJ(EntityManager CBHCEEBBPPJ, EntityCommandBufferSystem KDHHDHABEII, COJJKFBGGKB PHGBJKGIHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5662E60", Offset = "0x5661860", VA = "0x185662E60", Slot = "4")]
	public bool GFENIGGADHM(Entity FCFDGFFMMDF, object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5664490", Offset = "0x5662E90", VA = "0x185664490", Slot = "5")]
	public bool OFJOKDEMKGB(Entity FCFDGFFMMDF, object BECBHDDLOHA, [Out] bool GLKCAAGPMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5663880", Offset = "0x5662280", VA = "0x185663880", Slot = "6")]
	public bool LHCFBCPMIBA(Entity FCFDGFFMMDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5663900", Offset = "0x5662300", VA = "0x185663900", Slot = "8")]
	public bool LHCFBCPMIBA(IDLHGOBNGLO GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5662510", Offset = "0x5660F10", VA = "0x185662510", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5663380", Offset = "0x5661D80", VA = "0x185663380")]
	private void GHHPGCPFONM(HashSet<object> BHFNNGPLOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5663710", Offset = "0x5662110", VA = "0x185663710")]
	private bool KPLEDPHMDHJ(Entity FCFDGFFMMDF, [Out] IDLHGOBNGLO GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5662AC0", Offset = "0x56614C0", VA = "0x185662AC0")]
	private bool GCEHMAMCMMD(Entity FCFDGFFMMDF, [Out] IDLHGOBNGLO GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5662910", Offset = "0x5661310", VA = "0x185662910")]
	private void ECICJKGBBJE(Entity FCFDGFFMMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5662110", Offset = "0x5660B10", VA = "0x185662110")]
	private void BEJGPEBPKGA(Entity FCFDGFFMMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5663E50", Offset = "0x5662850", VA = "0x185663E50")]
	private void MCACEIKKGBC(Entity FCFDGFFMMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5663C60", Offset = "0x5662660", VA = "0x185663C60")]
	private void LKFLBNCAJAC(Entity FCFDGFFMMDF, IDLHGOBNGLO GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x56620B0", Offset = "0x5660AB0", VA = "0x1856620B0")]
	private bool BDOJGNEAHBL(IDLHGOBNGLO GCKDJGKENJL, [Out] HashSet<object> BHFNNGPLOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5664010", Offset = "0x5662A10", VA = "0x185664010")]
	private HashSet<object> MOODOBIPBAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HJMPMKBODPJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BNGNLKBCKOA : FNFHEOCLNMG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F08C10", Offset = "0x7F07610", VA = "0x187F08C10")]
	public float PLCDOLHELKJ([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F08C10", Offset = "0x7F07610", VA = "0x187F08C10", Slot = "4")]
	private float NHPHMPILHBA([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OBNILLGAJDK : FNFHEOCLNMG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F09C80", Offset = "0x7F08680", VA = "0x187F09C80")]
	public float PLCDOLHELKJ([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F09C80", Offset = "0x7F08680", VA = "0x187F09C80", Slot = "4")]
	private float NHPHMPILHBA([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NIFNKFGOJKK : FNFHEOCLNMG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xF0A350", Offset = "0xF08D50", VA = "0x180F0A350")]
	public float PLCDOLHELKJ([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xF0A350", Offset = "0xF08D50", VA = "0x180F0A350", Slot = "4")]
	private float NHPHMPILHBA([In] float3 PCDAHJCDHHF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JINFJFFEMOG : FNFHEOCLNMG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22F87B0", Offset = "0x22F71B0", VA = "0x1822F87B0")]
	public int PLCDOLHELKJ([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22F87B0", Offset = "0x22F71B0", VA = "0x1822F87B0", Slot = "4")]
	private int GGBOFBMFMEO([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ADNFFLBKGAC : FNFHEOCLNMG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x129D660", Offset = "0x129C060", VA = "0x18129D660")]
	public int PLCDOLHELKJ([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x129D660", Offset = "0x129C060", VA = "0x18129D660", Slot = "4")]
	private int GGBOFBMFMEO([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MNECPAOEFDK : FNFHEOCLNMG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xEEFC40", Offset = "0xEEE640", VA = "0x180EEFC40")]
	public int PLCDOLHELKJ([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xEEFC40", Offset = "0xEEE640", VA = "0x180EEFC40", Slot = "4")]
	private int GGBOFBMFMEO([In] int3 PCDAHJCDHHF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NILBLNBJDBB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21ED290", VA = "0x1821EE890")]
	public NILBLNBJDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NFJLOKHFHGF : SystemBase, IPDFKODNEIN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F09900", Offset = "0x7F08300", VA = "0x187F09900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8370", Offset = "0x3BB6D70", VA = "0x183BB8370")]
	public void JFIJHNEODGE<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8370", Offset = "0x3BB6D70", VA = "0x183BB8370")]
	public void DDLOKLFEFPN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F09A70", Offset = "0x7F08470", VA = "0x187F09A70")]
	public JobHandle LINHOJGAOKO(ReadOnlySpan<int> IAKGLMGKOEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BB83C0", Offset = "0x3BB6DC0", VA = "0x183BB83C0")]
	public JobHandle JGFEENACAFE<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F09A20", Offset = "0x7F08420", VA = "0x187F09A20")]
	public JobHandle JGFEENACAFE(ReadOnlySpan<int> IAKGLMGKOEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3BB80B0", Offset = "0x3BB6AB0", VA = "0x183BB80B0")]
	public void PHEKJILDCCA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3BB86D0", Offset = "0x3BB70D0", VA = "0x183BB86D0")]
	public JobHandle PHEKJILDCCA<T>(JobHandle GCKDJGKENJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F09B80", Offset = "0x7F08580", VA = "0x187F09B80")]
	public JobHandle PHEKJILDCCA(ReadOnlySpan<int> IAKGLMGKOEF, JobHandle GCKDJGKENJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB80B0", Offset = "0x3BB6AB0", VA = "0x183BB80B0")]
	public void DBFNAKFBNHB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8130", Offset = "0x3BB6B30", VA = "0x183BB8130")]
	public JobHandle DBFNAKFBNHB<T>(JobHandle GCKDJGKENJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F09930", Offset = "0x7F08330", VA = "0x187F09930")]
	public JobHandle DBFNAKFBNHB(Span<int> IAKGLMGKOEF, JobHandle GCKDJGKENJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8500", Offset = "0x3BB6F00", VA = "0x183BB8500")]
	public ComponentDataFromEntity MFJDNHIOAKL<T>(bool AIJOGNDOIOI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F09AC0", Offset = "0x7F084C0", VA = "0x187F09AC0")]
	public ComponentDataFromEntity MFJDNHIOAKL(int OBNOAMFOPDD, bool AIJOGNDOIOI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8460", Offset = "0x3BB6E60", VA = "0x183BB8460")]
	public SharedComponentIndexFromEntity<T> MDPEIDHKMMK<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F099A0", Offset = "0x7F083A0", VA = "0x187F099A0")]
	[BurstCompatible]
	public ComponentTypeHandle EBDNJIPCGLI(ComponentType COIEKHIICND)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F09A00", Offset = "0x7F08400", VA = "0x187F09A00")]
	public EntityExistenceLookupByEntity EBGOHBFFMBN()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F09BF0", Offset = "0x7F085F0", VA = "0x187F09BF0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BB85B0", Offset = "0x3BB6FB0", VA = "0x183BB85B0")]
	public bool PDBOACGNGBB<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21ED290", VA = "0x1821EE890")]
	protected NFJLOKHFHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CHDOHLKCOMH : NFJLOKHFHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F08C20", Offset = "0x7F07620", VA = "0x187F08C20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21ED290", VA = "0x1821EE890")]
	protected CHDOHLKCOMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DMEOLCDGHAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DOHGOGBJMHF : EntityCommandBufferSystem, IPDFKODNEIN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private COJJKFBGGKB NLLEOCMFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE074F0", Offset = "0xE05EF0", VA = "0x180E074F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F08D20", Offset = "0x7F07720", VA = "0x187F08D20")]
	public DOHGOGBJMHF(COJJKFBGGKB PMPMPCJHKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FNFHEOCLNMG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PLCDOLHELKJ([In] TFrom PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ENLLMIIHCPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEGBLAMLJLC(T PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct LKPGFACMIFL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes FHAMDHINANC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F09810", Offset = "0x7F08210", VA = "0x187F09810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct ALMGLLMJJJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F08B70", Offset = "0x7F07570", VA = "0x187F08B70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct EKDAHIMENJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType COIEKHIICND;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F08D50", Offset = "0x7F07750", VA = "0x187F08D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct MFBBHFIGMNM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x547A840", Offset = "0x5479240", VA = "0x18547A840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct BIIIEAHKCHL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> OKEIIBNBBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct JDJCEECKBPN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T PCDAHJCDHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer KNFJHECOODC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct DGCABLLFKPE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FNFHEOCLNMG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> IFMAFPJDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FKMNNKBLAMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity IPMBAKKDCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> IFMAFPJDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GJDFIDOBDAF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F08F10", Offset = "0x7F07910", VA = "0x187F08F10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PGBPHEGBDPP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GAHIFMFPGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> GKONAGDIOGM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FBNMMOENLGC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FNFHEOCLNMG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> OLAAFLKJKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> IFMAFPJDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BOPNEMNKMJE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LOGBFMIPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> FLOLLMNHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> FHNHJMDAMED;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct BGJJLLDGEOA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LOGBFMIPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> FLOLLMNHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> FHNHJMDAMED;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x610E630", Offset = "0x610D030", VA = "0x18610E630", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct IDKNENOOFPP<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> GKONAGDIOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> MFEGPLGCIDN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C710", Offset = "0x4E3B110", VA = "0x184E3C710", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BHPGCLFNLPH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FNFHEOCLNMG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> GKONAGDIOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> MFEGPLGCIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct FLBPKNHLMBN<T, TPredicate> : IJob where T : struct where TPredicate : struct, ENLLMIIHCPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> BMGFMLLEGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> NBNEPMMFGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HBPPBOGCPNJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, ENLLMIIHCPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> DLNJMDEMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> GKONAGDIOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CHJNJHALNFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity LOGBFMIPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> FLOLLMNHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> APDAPGFPOBM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F08C50", Offset = "0x7F07650", VA = "0x187F08C50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct JEEOGFAHJDC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity LOGBFMIPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> FLOLLMNHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> APDAPGFPOBM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F09500", Offset = "0x7F07F00", VA = "0x187F09500", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OAHLHOMPOBD
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AHBMHKMGKGE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3002370", Offset = "0x3000D70", VA = "0x183002370")]
	public static bool OJEPAANNFCC<T>(this NativeArray<Entity> FLOLLMNHDLG, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNPOJBLFJCB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MKKAEHKPNKB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public MKKAEHKPNKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LJLHOLMHFAJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public LJLHOLMHFAJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> HMAAGNMLICA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F09780", Offset = "0x7F08180", VA = "0x187F09780")]
	public KNPOJBLFJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MBGLPOEMFJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GFKGAOFKBAC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OMDBFLEKIBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GJBPIDPDGIJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OMDBFLEKIBG<TFrom> EAGGHBKHKHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> AJHCLHGHINB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct BDKHCJIJHDP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct OHHGOIEFLMG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal BDKHCJIJHDP<TFrom> EAGGHBKHKHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> AJHCLHGHINB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct DCIOKDPPIDL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct EHPHKHBMDFC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal DCIOKDPPIDL<TFrom> EAGGHBKHKHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> AJHCLHGHINB;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PBPFBHLLFGC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct FKGNGNNAEDA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal PBPFBHLLFGC<TFrom> EAGGHBKHKHF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> AJHCLHGHINB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BJAKHGBMLCC
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MOEGJPEDDME
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B5BD20", Offset = "0x3B5A720", VA = "0x183B5BD20")]
	public static NativeList<T> HGGKMGKFNDH<T>(this NativeArray<T> BIFADIMOBMA, Allocator NDKMELBEFLH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IIBNGAPPHDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GEADKHGOEDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A65000", Offset = "0x3A63A00", VA = "0x183A65000")]
	[KHNPNEGGLNO]
	public static JobHandle OIFOKPMEPPG<T>(this EntityCommandBufferSystem KDHHDHABEII, NativeArray<Entity> OBKJONELPMG, NativeArray<T> HPGIDELCODH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3A64D40", Offset = "0x3A63740", VA = "0x183A64D40")]
	[KHNPNEGGLNO]
	public static JobHandle OIFOKPMEPPG<T>(this EntityCommandBufferSystem KDHHDHABEII, NativeArrayAsync<Entity> OBKJONELPMG, NativeArrayAsync<T> HPGIDELCODH, [Optional] JobHandle HGAGAALLKJC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A64C20", Offset = "0x3A63620", VA = "0x183A64C20")]
	[KHNPNEGGLNO]
	public static JobHandle OIFOKPMEPPG<T>(this EntityCommandBufferSystem KDHHDHABEII, NativeArray<Entity> OBKJONELPMG, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F09010", Offset = "0x7F07A10", VA = "0x187F09010")]
	[KHNPNEGGLNO]
	public static JobHandle OIFOKPMEPPG(this EntityCommandBufferSystem KDHHDHABEII, NativeArray<Entity> OBKJONELPMG, ComponentTypes FHAMDHINANC, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F09180", Offset = "0x7F07B80", VA = "0x187F09180")]
	[KHNPNEGGLNO]
	public static JobHandle OIFOKPMEPPG(this EntityCommandBufferSystem KDHHDHABEII, EntityCommandBuffer KNFJHECOODC, NativeArray<Entity> OBKJONELPMG, ComponentTypes FHAMDHINANC, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PMJLCNNANJF
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PIMJCILGDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F09C90", Offset = "0x7F08690", VA = "0x187F09C90")]
	[KHNPNEGGLNO]
	public static JobHandle PMMGJFBHDNE(this EntityCommandBufferSystem KDHHDHABEII, NativeList<Entity> OBKJONELPMG, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F09E20", Offset = "0x7F08820", VA = "0x187F09E20")]
	[KHNPNEGGLNO]
	public static JobHandle PMMGJFBHDNE(this EntityCommandBufferSystem KDHHDHABEII, NativeArrayAsync<Entity> OBKJONELPMG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JCOJFPHGJNC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD540", Offset = "0x3ABBF40", VA = "0x183ABD540")]
	public static void GFBIPFENJBN<T>(this EntityCommandBufferSystem KDHHDHABEII, EntityQuery HGDNMECPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD780", Offset = "0x3ABC180", VA = "0x183ABD780")]
	[KHNPNEGGLNO]
	public static JobHandle ODOLOEBEGHC<T>(this EntityCommandBufferSystem KDHHDHABEII, NativeArrayAsync<Entity> OBKJONELPMG, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F09370", Offset = "0x7F07D70", VA = "0x187F09370")]
	[KHNPNEGGLNO]
	public static JobHandle ODOLOEBEGHC(this EntityCommandBufferSystem KDHHDHABEII, NativeArrayAsync<Entity> OBKJONELPMG, ComponentType COIEKHIICND, [Optional] JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KAOICEDPFNE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF430", Offset = "0x3AFDE30", VA = "0x183AFF430")]
	[KHNPNEGGLNO]
	public static JobHandle LOFKNAEGDCI<T>(this EntityCommandBufferSystem KDHHDHABEII, NativeArray<Entity> OBKJONELPMG, NativeArray<T> HPGIDELCODH, JobHandle HGAGAALLKJC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AEFIMDHPCLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FKKHPPMDOGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KBDAPHIBEAO
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF790", Offset = "0x3AFE190", VA = "0x183AFF790")]
	public static NativeArray<T> GJCDPPHFDHE<T>(this NativeList<Entity> BIFADIMOBMA, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF840", Offset = "0x3AFE240", VA = "0x183AFF840")]
	public static NativeArray<T> GJCDPPHFDHE<T>(this NativeArray<Entity> BIFADIMOBMA, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F09590", Offset = "0x7F07F90", VA = "0x187F09590")]
	public static NativeArray<Entity> HHFKKGNAMAE(this NativeArray<Entity> BIFADIMOBMA, EntityManager CBHCEEBBPPJ, ComponentType COIEKHIICND, Allocator NDKMELBEFLH = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF690", Offset = "0x3AFE090", VA = "0x183AFF690")]
	public static NativeArray<T> DKOKDNDCCOK<T>(this NativeArray<Entity> BIFADIMOBMA, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MBPPLDEJMOC
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NCICPNPMAID<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct GMDFAHJNLED<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NCICPNPMAID<TFrom> AJHCLHGHINB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OCHLNFLBPPE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct DLMFDMKLFAC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public OCHLNFLBPPE<TFrom> AJHCLHGHINB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct NEEJFJGEBEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct BHDKPAJDPCF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public NEEJFJGEBEL<TFrom> AJHCLHGHINB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> DLNJMDEMMNA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DHDPEKMCMMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GEPFLINPHMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct KEHJIPGBMGO : FNFHEOCLNMG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F09770", Offset = "0x7F08170", VA = "0x187F09770")]
		[BurstCompatible]
		public Entity PLCDOLHELKJ([In] Entity PCDAHJCDHHF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F09770", Offset = "0x7F08170", VA = "0x187F09770", Slot = "4")]
		private Entity MIOGLGIGOOF([In] Entity PCDAHJCDHHF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HJNDOMPBAOK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct FHEGDGCFFGD<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4B41020", Offset = "0x4B3FA20", VA = "0x184B41020", Slot = "4")]
		public int Compare((TKey, TValue) CBPCNABIALH, (TKey, TValue) CBOHEKOGGHJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A895A0", Offset = "0x3A87FA0", VA = "0x183A895A0")]
	public static void OPABKGGOCFK<TKey, TValue>(NativeList<TKey> HHPCMFNDCJI, NativeList<TValue> OKEIIBNBBOL) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3A89810", Offset = "0x3A88210", VA = "0x183A89810")]
	public static void OPABKGGOCFK<TKey, TValue>(NativeArray<TKey> HHPCMFNDCJI, NativeArray<TValue> OKEIIBNBBOL) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3A89B50", Offset = "0x3A88550", VA = "0x183A89B50")]
	public static void OPABKGGOCFK<TKey, TValue, U>(NativeArray<TKey> HHPCMFNDCJI, NativeArray<TValue> OKEIIBNBBOL, U AMNFDBIIDFH) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OLOLBGDJCGM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct CMAJBLIIEHM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> BMGFMLLEGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct PCKJALGEOHH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> BMGFMLLEGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PKMCCHOKIGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> BMGFMLLEGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> DLNJMDEMMNA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EKJBOAEEJHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PLJANCJCKEA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct KPCKMIHBJDK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct POKCBLHFDMC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct JPNABNBEJFI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> DLNJMDEMMNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct FKNKGIIBJID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator NDKMELBEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> DLNJMDEMMNA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class CBNGLLBOAEJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FPBIBEAOHEP
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EA60", Offset = "0x3A4D460", VA = "0x183A4EA60")]
	public static NativeList<Entity> HBEOCKDBFFA<T>(this NativeList<Entity> FLOLLMNHDLG, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E460", Offset = "0x3A4CE60", VA = "0x183A4E460")]
	public static NativeList<Entity> HBEOCKDBFFA<T>(this NativeArray<Entity> FLOLLMNHDLG, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class GMFKJGMDLAB
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A78780", Offset = "0x3A77180", VA = "0x183A78780")]
	public static NativeList<Entity> BNEBNPFJDGC<T>(this NativeArray<Entity> FLOLLMNHDLG, EntityManager CBHCEEBBPPJ, Allocator NDKMELBEFLH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class NFHEBIJHIIK
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct FENNJFLOOMD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> KLDOGKPLNJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct EMLOAABBJCG<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> KLDOGKPLNJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct OCACFFLDCPG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FNFHEOCLNMG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> KLDOGKPLNJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GHBJIDAIFPK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FNFHEOCLNMG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> KLDOGKPLNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector PCPPPLCEIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int MNFHMLCLFEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ICFFAGFCOPD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FNFHEOCLNMG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GHBJIDAIFPK<TSrc, TValue, TSelector> EJDGCMPDMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue LJBOKDLOGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int OBKGKEGIECO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class BLIIDPOGAHP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct ENLPPEIKOCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> KLDOGKPLNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int OBKGKEGIECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int DDKBDEBABFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T LJBOKDLOGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T EJEGDAEGNDL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JOGKEMLKOOJ ADEAKOLDDHL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x46BA3B0", Offset = "0x46B8DB0", VA = "0x1846BA3B0")]
			get
			{
				return default(JOGKEMLKOOJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T PHOPNDLDIIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, JOGKEMLKOOJ) NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x46BA480", Offset = "0x46B8E80", VA = "0x1846BA480")]
			get
			{
				return default((T, JOGKEMLKOOJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x46BAAD0", Offset = "0x46B94D0", VA = "0x1846BAAD0")]
		public ENLPPEIKOCH(NativeArray<T> KLDOGKPLNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF88F0", Offset = "0x2AF72F0", VA = "0x182AF88F0")]
		public ENLPPEIKOCH<T> ICNPOCIJNJG()
		{
			return default(ENLPPEIKOCH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x46BA690", Offset = "0x46B9090", VA = "0x1846BA690")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF300", Offset = "0x3ECDD00", VA = "0x183ECF300")]
		public LAPJHLJLBJG<T, TComparer> HCDOMKNAHEM<TComparer>([Optional] TComparer AMNFDBIIDFH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LAPJHLJLBJG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct LAPJHLJLBJG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> KLDOGKPLNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int OBKGKEGIECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int DDKBDEBABFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T LJBOKDLOGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T EJEGDAEGNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer AMNFDBIIDFH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JOGKEMLKOOJ ADEAKOLDDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x46BA3B0", Offset = "0x46B8DB0", VA = "0x1846BA3B0")]
			get
			{
				return default(JOGKEMLKOOJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T PHOPNDLDIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, JOGKEMLKOOJ range) NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x46BA480", Offset = "0x46B8E80", VA = "0x1846BA480")]
			get
			{
				return default((T, JOGKEMLKOOJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5273590", Offset = "0x5271F90", VA = "0x185273590")]
		public LAPJHLJLBJG(NativeArray<T> KLDOGKPLNJA, TComparer AMNFDBIIDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x46BA3C0", Offset = "0x46B8DC0", VA = "0x1846BA3C0")]
		public LAPJHLJLBJG<T, TComparer> ICNPOCIJNJG()
		{
			return default(LAPJHLJLBJG<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5273400", Offset = "0x5271E00", VA = "0x185273400")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37F34D0", Offset = "0x37F1ED0", VA = "0x1837F34D0")]
	public static ENLPPEIKOCH<T> BCMPBPNEEJI<T>(this NativeArray<T> KLDOGKPLNJA) where T : struct
	{
		return default(ENLPPEIKOCH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface ELBGLNDNMDE
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EBEANAGEGBE
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct NALHJMPDKFN<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OOHOADACCAH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NALHJMPDKFN<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4BFD490", Offset = "0x4BFBE90", VA = "0x184BFD490", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public OOHOADACCAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56A1C40", Offset = "0x56A0640", VA = "0x1856A1C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x56A1DF0", Offset = "0x56A07F0", VA = "0x1856A1DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> MEOIOKMGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream LAIENGFAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream BKJJEKCJHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf HLLAODLFFLE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x54EA5D0", Offset = "0x54E8FD0", VA = "0x1854EA5D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x54EA610", Offset = "0x54E9010", VA = "0x1854EA610", Slot = "4")]
	[IteratorStateMachine(typeof(NALHJMPDKFN<>.OOHOADACCAH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x54EA700", Offset = "0x54E9100", VA = "0x1854EA700", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NFAHHFPBHGO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] NNHDOHEKGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf HLLAODLFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream LAIENGFAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream KALAIKKMIIA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x54FF7D0", Offset = "0x54FE1D0", VA = "0x1854FF7D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct DHCDKMEECIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream LAIENGFAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream BKJJEKCJHEG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F08CE0", Offset = "0x7F076E0", VA = "0x187F08CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FDKBJNKCCIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NNHDOHEKGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream LAIENGFAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream KALAIKKMIIA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F08DF0", Offset = "0x7F077F0", VA = "0x187F08DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PHPANGBFOLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GGMKBHBHHGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum DGEOBGICHNF
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class OGJENMKDICM
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IBFGABBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IBFGABBDLJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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
