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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7609A50", Offset = "0x7608650", VA = "0x187609A50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
		[Cpp2IlInjected.Address(RVA = "0x7608FF0", Offset = "0x7607BF0", VA = "0x187608FF0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NGMKJMHNPKG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BHGGDDHLAEI CDIDJEACEGG
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
public interface IPNIAIGMJMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPBLFIJCMNJ(Entity CANLONBNOKL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCCKOFMAKAM(Entity CANLONBNOKL, object IKLHDHMJFFL, [Out] bool MENPENFDBIP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPECIAMPJID(Entity CANLONBNOKL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MGBIALPAINL<TComponentData, TValue> : MEKFKPFHOGJ<TValue>, IDisposable where TComponentData : struct, NGMKJMHNPKG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class OMAPFEHOKKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> DGHHCPPFODF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int PHJGKILIPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC90E0", VA = "0x183CCA4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4F935E0", Offset = "0x4F921E0", VA = "0x184F935E0")]
		public bool FPFIMCJHIDF([Out] TValue MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4F936F0", Offset = "0x4F922F0", VA = "0x184F936F0")]
		public void GFCJDEIJPEO(object IKLHDHMJFFL, TValue MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F93520", Offset = "0x4F92120", VA = "0x184F93520")]
		public bool BLAPNJAELFA(object IKLHDHMJFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F937E0", Offset = "0x4F923E0", VA = "0x184F937E0")]
		public int HAJPGONHFGE(object IKLHDHMJFFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F938E0", Offset = "0x4F924E0", VA = "0x184F938E0")]
		public OMAPFEHOKKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<OMAPFEHOKKD> KFKGJINEMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HLEEPLNIOEE<BHGGDDHLAEI, OMAPFEHOKKD> FCMJFCFFBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager BJAJJLPDBMA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D43540", Offset = "0x4D42140", VA = "0x184D43540")]
	public MGBIALPAINL(EntityManager BJAJJLPDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D432F0", Offset = "0x4D41EF0", VA = "0x184D432F0", Slot = "4")]
	public void MPBLFIJCMNJ(Entity CANLONBNOKL, object IKLHDHMJFFL, TValue MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D42FE0", Offset = "0x4D41BE0", VA = "0x184D42FE0", Slot = "5")]
	public bool LCCKOFMAKAM(Entity CANLONBNOKL, object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D42D90", Offset = "0x4D41990", VA = "0x184D42D90", Slot = "6")]
	public bool FPFIMCJHIDF(Entity CANLONBNOKL, [Out] TValue MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D42D50", Offset = "0x4D41950", VA = "0x184D42D50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D42C80", Offset = "0x4D41880", VA = "0x184D42C80")]
	private void CGJDCCELFLD(OMAPFEHOKKD EAPBBCPKACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D43480", Offset = "0x4D42080", VA = "0x184D43480")]
	private bool PMLDGFIHEDK(Entity CANLONBNOKL, [Out] BHGGDDHLAEI EHNDIPGCOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D431F0", Offset = "0x4D41DF0", VA = "0x184D431F0")]
	private void MMBOCFGECOD(Entity CANLONBNOKL, BHGGDDHLAEI EHNDIPGCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D42D70", Offset = "0x4D41970", VA = "0x184D42D70")]
	private bool EAKJBDMMNDN(BHGGDDHLAEI EHNDIPGCOKP, [Out] OMAPFEHOKKD EAPBBCPKACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D42EB0", Offset = "0x4D41AB0", VA = "0x184D42EB0")]
	private OMAPFEHOKKD HDIPPFIOOCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MEKFKPFHOGJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPBLFIJCMNJ(Entity CANLONBNOKL, object IKLHDHMJFFL, TValue MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCCKOFMAKAM(Entity CANLONBNOKL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FPFIMCJHIDF(Entity CANLONBNOKL, [Out] TValue MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BHGGDDHLAEI : BJACBJHGLEM, IEquatable<BHGGDDHLAEI>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly BHGGDDHLAEI GDEBNFLOOLE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IOKKPHFOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7608CE0", Offset = "0x76078E0", VA = "0x187608CE0", Slot = "8")]
	public bool Equals(BHGGDDHLAEI PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7608D30", Offset = "0x7607930", VA = "0x187608D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ABJEEEFLFPJ<THasTokensTag> : IPNIAIGMJMF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, BHGGDDHLAEI> AGFCLNNBIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> KFKGJINEMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HLEEPLNIOEE<BHGGDDHLAEI, HashSet<object>> FCMJFCFFBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager BJAJJLPDBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem NNNJLOGECLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x453FBE0", Offset = "0x453E7E0", VA = "0x18453FBE0")]
	public ABJEEEFLFPJ(EntityManager BJAJJLPDBMA, EntityCommandBufferSystem NNNJLOGECLH, NDNFAPMFFIF ANJIEPOLFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x453EA90", Offset = "0x453D690", VA = "0x18453EA90", Slot = "4")]
	public bool MPBLFIJCMNJ(Entity CANLONBNOKL, object IKLHDHMJFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x453E0D0", Offset = "0x453CCD0", VA = "0x18453E0D0", Slot = "5")]
	public bool LCCKOFMAKAM(Entity CANLONBNOKL, object IKLHDHMJFFL, [Out] bool MENPENFDBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x453F450", Offset = "0x453E050", VA = "0x18453F450", Slot = "6")]
	public bool NPECIAMPJID(Entity CANLONBNOKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x453F500", Offset = "0x453E100", VA = "0x18453F500", Slot = "8")]
	public bool NPECIAMPJID(BHGGDDHLAEI EHNDIPGCOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x453D310", Offset = "0x453BF10", VA = "0x18453D310", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x453CD90", Offset = "0x453B990", VA = "0x18453CD90")]
	private void CGJDCCELFLD(HashSet<object> EAPBBCPKACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x453F740", Offset = "0x453E340", VA = "0x18453F740")]
	private bool PMLDGFIHEDK(Entity CANLONBNOKL, [Out] BHGGDDHLAEI EHNDIPGCOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x453CF50", Offset = "0x453BB50", VA = "0x18453CF50")]
	private bool DEJDNOGMPOC(Entity CANLONBNOKL, [Out] BHGGDDHLAEI EHNDIPGCOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x453DFC0", Offset = "0x453CBC0", VA = "0x18453DFC0")]
	private void KMFFONNOJBH(Entity CANLONBNOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x453D850", Offset = "0x453C450", VA = "0x18453D850")]
	private void JENCEKKGJHI(Entity CANLONBNOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x453D710", Offset = "0x453C310", VA = "0x18453D710")]
	private void HLFEMHPBJMN(Entity CANLONBNOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x453E8D0", Offset = "0x453D4D0", VA = "0x18453E8D0")]
	private void MMBOCFGECOD(Entity CANLONBNOKL, BHGGDDHLAEI EHNDIPGCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x453CC10", Offset = "0x453B810", VA = "0x18453CC10")]
	private bool AMDDPGDLJBI(BHGGDDHLAEI EHNDIPGCOKP, [Out] HashSet<object> EAPBBCPKACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x453D490", Offset = "0x453C090", VA = "0x18453D490")]
	private HashSet<object> HDIPPFIOOCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LPCEOBJELNB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NJAAJDICFOE : OAGNHGECAGI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7609A40", Offset = "0x7608640", VA = "0x187609A40")]
	public float HGGHDJJAMJK([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7609A40", Offset = "0x7608640", VA = "0x187609A40", Slot = "4")]
	private float IOHMPDBAMMC([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PIFNDONFMEB : OAGNHGECAGI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7609B10", Offset = "0x7608710", VA = "0x187609B10")]
	public float HGGHDJJAMJK([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7609B10", Offset = "0x7608710", VA = "0x187609B10", Slot = "4")]
	private float IOHMPDBAMMC([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MOFBNGALFHB : OAGNHGECAGI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xCFB620", Offset = "0xCFA220", VA = "0x180CFB620")]
	public float HGGHDJJAMJK([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCFB620", Offset = "0xCFA220", VA = "0x180CFB620", Slot = "4")]
	private float IOHMPDBAMMC([In] float3 MPDLOLIOGJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MLCOGEACCLH : OAGNHGECAGI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0")]
	public int HGGHDJJAMJK([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0", Slot = "4")]
	private int PJBDDOPLICJ([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JELEEBMKDHC : OAGNHGECAGI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75FAD60", Offset = "0x75F9960", VA = "0x1875FAD60")]
	public int HGGHDJJAMJK([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75FAD60", Offset = "0x75F9960", VA = "0x1875FAD60", Slot = "4")]
	private int PJBDDOPLICJ([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EGMGEANJIIM : OAGNHGECAGI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xCE06B0", Offset = "0xCDF2B0", VA = "0x180CE06B0")]
	public int HGGHDJJAMJK([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCE06B0", Offset = "0xCDF2B0", VA = "0x180CE06B0", Slot = "4")]
	private int PJBDDOPLICJ([In] int3 MPDLOLIOGJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JAAOEHEKMKM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	public JAAOEHEKMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class LOHOFMOMPFM : SystemBase, OLNCLKHAKPA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7609620", Offset = "0x7608220", VA = "0x187609620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34567B0", Offset = "0x34553B0", VA = "0x1834567B0")]
	public void KKNICJOACAN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34567B0", Offset = "0x34553B0", VA = "0x1834567B0")]
	public void FCNIHGFPLAB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7609380", Offset = "0x7607F80", VA = "0x187609380")]
	public JobHandle EPDOMKDPFBE(ReadOnlySpan<int> NPPIELGKJBE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3457280", Offset = "0x3455E80", VA = "0x183457280")]
	public JobHandle LFMBJFPHAJP<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76094A0", Offset = "0x76080A0", VA = "0x1876094A0")]
	public JobHandle LFMBJFPHAJP(ReadOnlySpan<int> NPPIELGKJBE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3456A10", Offset = "0x3455610", VA = "0x183456A10")]
	public void JEKKIGPNMOD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3456930", Offset = "0x3455530", VA = "0x183456930")]
	public JobHandle JEKKIGPNMOD<T>(JobHandle EHNDIPGCOKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7609430", Offset = "0x7608030", VA = "0x187609430")]
	public JobHandle JEKKIGPNMOD(ReadOnlySpan<int> NPPIELGKJBE, JobHandle EHNDIPGCOKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3456A10", Offset = "0x3455610", VA = "0x183456A10")]
	public void LGAFECPAELN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3457330", Offset = "0x3455F30", VA = "0x183457330")]
	public JobHandle LGAFECPAELN<T>(JobHandle EHNDIPGCOKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76094F0", Offset = "0x76080F0", VA = "0x1876094F0")]
	public JobHandle LGAFECPAELN(Span<int> NPPIELGKJBE, JobHandle EHNDIPGCOKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34575D0", Offset = "0x34561D0", VA = "0x1834575D0")]
	public ComponentDataFromEntity NGMDHPBHFOC<T>(bool ALLIABLLMPB = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7609560", Offset = "0x7608160", VA = "0x187609560")]
	public ComponentDataFromEntity NGMDHPBHFOC(int HOFOPGKFAMC, bool ALLIABLLMPB = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34564D0", Offset = "0x34550D0", VA = "0x1834564D0")]
	public SharedComponentIndexFromEntity<T> DAMMMLAIOAF<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76093D0", Offset = "0x7607FD0", VA = "0x1876093D0")]
	[BurstCompatible]
	public ComponentTypeHandle GOFCFJCBLGE(ComponentType CEDJNNKCNLN)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7609360", Offset = "0x7607F60", VA = "0x187609360")]
	public EntityExistenceLookupByEntity CHNCAMFENDJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7609650", Offset = "0x7608250", VA = "0x187609650", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3456810", Offset = "0x3455410", VA = "0x183456810")]
	public bool IKGPNDHIJKK<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	protected LOHOFMOMPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IFFPKMAHFAJ : LOHOFMOMPFM
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76090B0", Offset = "0x7607CB0", VA = "0x1876090B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	protected IFFPKMAHFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KGOFEBDBBKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JNHPJKJAEPF : EntityCommandBufferSystem, OLNCLKHAKPA, HDDLKPCILEA<NDNFAPMFFIF>
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NDNFAPMFFIF HBFNBGCENOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xBEAA50", Offset = "0xBE9650", VA = "0x180BEAA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBEAA50", Offset = "0xBE9650", VA = "0x180BEAA50", Slot = "14")]
	public void EGIGLLCINKF(NDNFAPMFFIF DFFCPCMIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31B0", Offset = "0x1DE1DB0", VA = "0x181DE31B0")]
	public JNHPJKJAEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OAGNHGECAGI<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo HGGHDJJAMJK([In] TFrom MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HBPCFLMDMFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNMFKJCDMGI(T MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct ELNCCJAGJJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes GPFFCGLDOLB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7608F00", Offset = "0x7607B00", VA = "0x187608F00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct LILEIHPFCNA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76092C0", Offset = "0x7607EC0", VA = "0x1876092C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct ELBGJNCDPAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType CEDJNNKCNLN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7608E80", Offset = "0x7607A80", VA = "0x187608E80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct OLNCHIBBJJJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> LLDJIJICLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4F92B90", Offset = "0x4F91790", VA = "0x184F92B90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct CNJFIIMLPNC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> FKBJBKHIAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct NDNMEJKJOJC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T MPDLOLIOGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer EBLOIJFGELB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct ACAIJIBGEJJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OAGNHGECAGI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> MMEBDGCGPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct EDKDAMAOPKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity CLGNOEMEHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> MMEBDGCGPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int FKNFGOEIJBH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7608D80", Offset = "0x7607980", VA = "0x187608D80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ILJAEOENCBE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JOEHCJLMGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> MHICAFOCOOM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct IJFKDLMHHFH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OAGNHGECAGI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> JANDICANBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> MMEBDGCGPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CEGGODNCCOK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGKNNLEDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> CDDEIHKOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> DNCDIAIMPDE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct KBPODIOBJFA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGKNNLEDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> CDDEIHKOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> DNCDIAIMPDE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4A06780", Offset = "0x4A05380", VA = "0x184A06780", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MBJMJPFCEGF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> MHICAFOCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> MHJJDBNKJFA;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4D393D0", Offset = "0x4D37FD0", VA = "0x184D393D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HIBIFJOAEKK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OAGNHGECAGI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> MHICAFOCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> MHJJDBNKJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LJFGIAJABAP<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBPCFLMDMFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> AEPJNCCOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> JKCPHGIBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OJBCGILPEJJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBPCFLMDMFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> LGGOFOLENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> MHICAFOCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NDFMEOGJCBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity OGKNNLEDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> CDDEIHKOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> OKLJJDDGLLH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x76099B0", Offset = "0x76085B0", VA = "0x1876099B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct MCAAPINANKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity OGKNNLEDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> CDDEIHKOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> OKLJJDDGLLH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7609660", Offset = "0x7608260", VA = "0x187609660", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ECPNIBBOIPD
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KFAKGONHNFC
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3435550", Offset = "0x3434150", VA = "0x183435550")]
	public static bool BEMPKJHAIAI<T>(this NativeArray<Entity> CDDEIHKOACJ, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HKKPANIEGCE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ANAEFMPCOCP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public ANAEFMPCOCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KJDABPPOEGG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public KJDABPPOEGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> EMOLBPHKMAB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7609020", Offset = "0x7607C20", VA = "0x187609020")]
	public HKKPANIEGCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NPOJGMIKBFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KEJPJGDIEJP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DHCCLJOCCDJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BGBKBFMOAOJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal DHCCLJOCCDJ<TFrom> KOIBCEOILEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> CGPMLCFDDHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OLNHHBMAJPJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AECMIDLIPPA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal OLNHHBMAJPJ<TFrom> KOIBCEOILEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> CGPMLCFDDHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct KKDGINNFHCK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct FGPKEDKDGPN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal KKDGINNFHCK<TFrom> KOIBCEOILEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> CGPMLCFDDHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct KKBLOMCEECB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct PDKDGBHJAIH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal KKBLOMCEECB<TFrom> KOIBCEOILEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> CGPMLCFDDHA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JDNHJOAAEME
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ICABBJJGIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x33B09F0", Offset = "0x33AF5F0", VA = "0x1833B09F0")]
	public static NativeList<T> HLDKFNFHKCM<T>(this NativeArray<T> ACHGEEOGFPI, Allocator LNBNGBBFCIG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BDAJOMFPMHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MDMMGIIDHAG
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3469C90", Offset = "0x3468890", VA = "0x183469C90")]
	[MLNCOLIFMDH]
	public static JobHandle KHHMFKHNMCH<T>(this EntityCommandBufferSystem NNNJLOGECLH, NativeArray<Entity> BMGAGFMALJB, NativeArray<T> LLDJIJICLJF) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3469D80", Offset = "0x3468980", VA = "0x183469D80")]
	[MLNCOLIFMDH]
	public static JobHandle KHHMFKHNMCH<T>(this EntityCommandBufferSystem NNNJLOGECLH, NativeArrayAsync<Entity> BMGAGFMALJB, NativeArrayAsync<T> LLDJIJICLJF, [Optional] JobHandle COHFFHJAGDK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3469B60", Offset = "0x3468760", VA = "0x183469B60")]
	[MLNCOLIFMDH]
	public static JobHandle KHHMFKHNMCH<T>(this EntityCommandBufferSystem NNNJLOGECLH, NativeArray<Entity> BMGAGFMALJB, [Optional] JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76096F0", Offset = "0x76082F0", VA = "0x1876096F0")]
	[MLNCOLIFMDH]
	public static JobHandle KHHMFKHNMCH(this EntityCommandBufferSystem NNNJLOGECLH, NativeArray<Entity> BMGAGFMALJB, ComponentTypes GPFFCGLDOLB, [Optional] JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7609860", Offset = "0x7608460", VA = "0x187609860")]
	[MLNCOLIFMDH]
	public static JobHandle KHHMFKHNMCH(this EntityCommandBufferSystem NNNJLOGECLH, EntityCommandBuffer EBLOIJFGELB, NativeArray<Entity> BMGAGFMALJB, ComponentTypes GPFFCGLDOLB, [Optional] JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PLFDMNBLCGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BBNJJPOIJAN
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7608A50", Offset = "0x7607650", VA = "0x187608A50")]
	[MLNCOLIFMDH]
	public static JobHandle HNAEGDOCGNP(this EntityCommandBufferSystem NNNJLOGECLH, NativeList<Entity> BMGAGFMALJB, [Optional] JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7608BE0", Offset = "0x76077E0", VA = "0x187608BE0")]
	[MLNCOLIFMDH]
	public static JobHandle HNAEGDOCGNP(this EntityCommandBufferSystem NNNJLOGECLH, NativeArrayAsync<Entity> BMGAGFMALJB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MEALAFKEKMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class IHPHGGIPKLP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33B5010", Offset = "0x33B3C10", VA = "0x1833B5010")]
	[MLNCOLIFMDH]
	public static JobHandle GNFAGNPMPIK<T>(this EntityCommandBufferSystem NNNJLOGECLH, NativeArray<Entity> BMGAGFMALJB, NativeArray<T> LLDJIJICLJF, JobHandle COHFFHJAGDK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OLAFGEIMEDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OLLAKNJCMOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JMJLGKFOGBP
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x34001E0", Offset = "0x33FEDE0", VA = "0x1834001E0")]
	public static NativeArray<T> KLFAKDJHPPP<T>(this NativeList<Entity> ACHGEEOGFPI, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3400000", Offset = "0x33FEC00", VA = "0x183400000")]
	public static NativeArray<T> KLFAKDJHPPP<T>(this NativeArray<Entity> ACHGEEOGFPI, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76090E0", Offset = "0x7607CE0", VA = "0x1876090E0")]
	public static NativeArray<Entity> FHMFOPLKENK(this NativeArray<Entity> ACHGEEOGFPI, EntityManager BJAJJLPDBMA, ComponentType CEDJNNKCNLN, Allocator LNBNGBBFCIG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x33FFF00", Offset = "0x33FEB00", VA = "0x1833FFF00")]
	public static NativeArray<T> BLIHEEDKPNN<T>(this NativeArray<Entity> ACHGEEOGFPI, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EBKIOBJPBDK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CGAPKFOBDKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct CIDPELIOLIO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CGAPKFOBDKE<TFrom> CGPMLCFDDHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JJGDFMDAPJD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LCDODMBNLEI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JJGDFMDAPJD<TFrom> CGPMLCFDDHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct GNMMJNHKEML<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct NKNCMHEFCKE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public GNMMJNHKEML<TFrom> CGPMLCFDDHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> LGGOFOLENBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EHKHLFEOMOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IIMAGEJMGBH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct GMDCDNHIAOC : OAGNHGECAGI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7609010", Offset = "0x7607C10", VA = "0x187609010")]
		[BurstCompatible]
		public Entity HGGHDJJAMJK([In] Entity MPDLOLIOGJL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7609010", Offset = "0x7607C10", VA = "0x187609010", Slot = "4")]
		private Entity MNAFFPNFKJC([In] Entity MPDLOLIOGJL)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FHJHLHLGHJC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HCDAKCHCNGC<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x456F380", Offset = "0x456DF80", VA = "0x18456F380", Slot = "4")]
		public int Compare((TKey, TValue) MDFKHKOGFDI, (TKey, TValue) ELJEANFLEPB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3353630", Offset = "0x3352230", VA = "0x183353630")]
	public static void NPJHALIAJCI<TKey, TValue>(NativeList<TKey> OJFFMJECHGB, NativeList<TValue> FKBJBKHIAAE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3353B00", Offset = "0x3352700", VA = "0x183353B00")]
	public static void NPJHALIAJCI<TKey, TValue>(NativeArray<TKey> OJFFMJECHGB, NativeArray<TValue> FKBJBKHIAAE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33538C0", Offset = "0x33524C0", VA = "0x1833538C0")]
	public static void NPJHALIAJCI<TKey, TValue, U>(NativeArray<TKey> OJFFMJECHGB, NativeArray<TValue> FKBJBKHIAAE, U LNAHNFEOIPD) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HPOEDMOMLLM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct NNPDPDHBKCF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> AEPJNCCOFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CAOCAJFKLHP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> AEPJNCCOFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NHMOCNJKLFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> AEPJNCCOFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> LGGOFOLENBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KGPLONAIAAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OPPKAIMEDKB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct PIEBNNHPBMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct IEIHFPHHMIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct JEIOKKIDFBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> LGGOFOLENBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct KKGIHOBMBOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator LNBNGBBFCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> LGGOFOLENBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NKLHAIJCEBC
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class NMGBEDKOKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x34E3BE0", Offset = "0x34E27E0", VA = "0x1834E3BE0")]
	public static NativeList<Entity> IGLEALCBGLB<T>(this NativeList<Entity> CDDEIHKOACJ, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x34E35A0", Offset = "0x34E21A0", VA = "0x1834E35A0")]
	public static NativeList<Entity> IGLEALCBGLB<T>(this NativeArray<Entity> CDDEIHKOACJ, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class HDCJNELOOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3388660", Offset = "0x3387260", VA = "0x183388660")]
	public static NativeList<Entity> GAOKNLCAHAH<T>(this NativeArray<Entity> CDDEIHKOACJ, EntityManager BJAJJLPDBMA, Allocator LNBNGBBFCIG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class NNPAFNACHPD
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct LGCKPCFOODJ<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CPOMPIIIEGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct KFKKALNJFAA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> CPOMPIIIEGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct JCKAHNGEOEF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OAGNHGECAGI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> CPOMPIIIEGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct NLILEMMEMNC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OAGNHGECAGI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> CPOMPIIIEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector MJIIPJLLGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int BIEEMEKMINN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct PDGLPONJNIG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OAGNHGECAGI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NLILEMMEMNC<TSrc, TValue, TSelector> JOPPOBNNBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue IONEKDGMPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int PKAJCFBDMNB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FELBFFHKKFO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct LDCFIHLDIBM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> CPOMPIIIEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int PKAJCFBDMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int CJJHDNEFAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T IONEKDGMPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T PEABHBFDEMN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PPECJFOKLGF GILJOGCHNBC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4B20980", Offset = "0x4B1F580", VA = "0x184B20980")]
			get
			{
				return default(PPECJFOKLGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T EKJDLFODKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, PPECJFOKLGF) OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4B20BC0", Offset = "0x4B1F7C0", VA = "0x184B20BC0")]
			get
			{
				return default((T, PPECJFOKLGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4B20C70", Offset = "0x4B1F870", VA = "0x184B20C70")]
		public LDCFIHLDIBM(NativeArray<T> CPOMPIIIEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x40A83B0", Offset = "0x40A6FB0", VA = "0x1840A83B0")]
		public LDCFIHLDIBM<T> HCMJLOGCBCL()
		{
			return default(LDCFIHLDIBM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4B20690", Offset = "0x4B1F290", VA = "0x184B20690")]
		public bool DJBPCPHNBAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x33D0960", Offset = "0x33CF560", VA = "0x1833D0960")]
		public OOMMCNLMELG<T, TComparer> MOPJLCIOGNN<TComparer>([Optional] TComparer LNAHNFEOIPD) where TComparer : struct, IEqualityComparer<T>
		{
			return default(OOMMCNLMELG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct OOMMCNLMELG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> CPOMPIIIEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int PKAJCFBDMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int CJJHDNEFAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T IONEKDGMPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T PEABHBFDEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer LNAHNFEOIPD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PPECJFOKLGF GILJOGCHNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4B20980", Offset = "0x4B1F580", VA = "0x184B20980")]
			get
			{
				return default(PPECJFOKLGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T EKJDLFODKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, PPECJFOKLGF range) OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4B20BC0", Offset = "0x4B1F7C0", VA = "0x184B20BC0")]
			get
			{
				return default((T, PPECJFOKLGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4F9B020", Offset = "0x4F99C20", VA = "0x184F9B020")]
		public OOMMCNLMELG(NativeArray<T> CPOMPIIIEGC, TComparer LNAHNFEOIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x31B1100", Offset = "0x31AFD00", VA = "0x1831B1100")]
		public OOMMCNLMELG<T, TComparer> HCMJLOGCBCL()
		{
			return default(OOMMCNLMELG<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4F9AF70", Offset = "0x4F99B70", VA = "0x184F9AF70")]
		public bool DJBPCPHNBAK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3351620", Offset = "0x3350220", VA = "0x183351620")]
	public static LDCFIHLDIBM<T> GEKLGBMBFED<T>(this NativeArray<T> CPOMPIIIEGC) where T : struct
	{
		return default(LDCFIHLDIBM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GHHLGJHDDEA
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MAFJOFBPPDK
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DFINBIMNDHM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class IKNNNFAPMCI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DFINBIMNDHM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x4482480", Offset = "0x4481080", VA = "0x184482480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public IKNNNFAPMCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4708A40", Offset = "0x4707640", VA = "0x184708A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4708C20", Offset = "0x4707820", VA = "0x184708C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> LDHCJLOGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream EJHPLBNDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream ANGECCGJJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf GEEJIMECCCB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6304610", Offset = "0x6303210", VA = "0x186304610", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6304650", Offset = "0x6303250", VA = "0x186304650", Slot = "4")]
	[IteratorStateMachine(typeof(DFINBIMNDHM<>.IKNNNFAPMCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6304750", Offset = "0x6303350", VA = "0x186304750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IOEPNOKFMKH<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] IOKDPJEDBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf GEEJIMECCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream EJHPLBNDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream AGLAHIMJBFL;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4718BD0", Offset = "0x47177D0", VA = "0x184718BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct OFMLPIIPDPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream EJHPLBNDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream ANGECCGJJPO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7609AD0", Offset = "0x76086D0", VA = "0x187609AD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AAMGKCOOBKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] IOKDPJEDBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream EJHPLBNDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream AGLAHIMJBFL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7608930", Offset = "0x7607530", VA = "0x187608930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MHOJIBMEPFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class OIIFMOOBEEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum KCBHBPBONBJ
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
internal static class HGOIOEMJJHE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
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
