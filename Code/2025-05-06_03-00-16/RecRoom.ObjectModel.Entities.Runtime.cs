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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2940", Offset = "0x7CA1140", VA = "0x187CA2940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA1C70", Offset = "0x7CA0470", VA = "0x187CA1C70")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LDCAEHCBJPO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FMMMHPMEALG KKDDIBAEBFK
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
public interface ANDHLMKAPJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADDJNGMIA(Entity EAALLGNPDMK, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAKLPNFBHDB(Entity EAALLGNPDMK, object JILOCOLKOMJ, [Out] bool IHGDGNLHPKC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLNHPINNCHG(Entity EAALLGNPDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JFICKKAHLJJ<TComponentData, TValue> : PIFLGJJEBML<TValue>, IDisposable where TComponentData : struct, LDCAEHCBJPO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class DDNDLAPAJNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> GIPAMJGJGNH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FCHJPHAGFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3FED240", Offset = "0x3FEBA40", VA = "0x183FED240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F80", Offset = "0x68C1780", VA = "0x1868C2F80")]
		public bool FBIBLMOFNAG([Out] TValue OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68C3090", Offset = "0x68C1890", VA = "0x1868C3090")]
		public void OIHLAKEIFNH(object JILOCOLKOMJ, TValue OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68C2DF0", Offset = "0x68C15F0", VA = "0x1868C2DF0")]
		public bool AHELLINFOCL(object JILOCOLKOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68C2EA0", Offset = "0x68C16A0", VA = "0x1868C2EA0")]
		public int EPEAOGKBKKK(object JILOCOLKOMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68C3170", Offset = "0x68C1970", VA = "0x1868C3170")]
		public DDNDLAPAJNN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<DDNDLAPAJNN> LCAPFPOBDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MCMJDBAFPKC<FMMMHPMEALG, DDNDLAPAJNN> DNAHGCCLDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager MIJJPMGKBJK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D65C40", Offset = "0x4D64440", VA = "0x184D65C40")]
	public JFICKKAHLJJ(EntityManager MIJJPMGKBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D657B0", Offset = "0x4D63FB0", VA = "0x184D657B0", Slot = "4")]
	public void FLADDJNGMIA(Entity EAALLGNPDMK, object JILOCOLKOMJ, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D65A30", Offset = "0x4D64230", VA = "0x184D65A30", Slot = "5")]
	public bool MAKLPNFBHDB(Entity EAALLGNPDMK, object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D655E0", Offset = "0x4D63DE0", VA = "0x184D655E0", Slot = "6")]
	public bool FBIBLMOFNAG(Entity EAALLGNPDMK, [Out] TValue OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D655C0", Offset = "0x4D63DC0", VA = "0x184D655C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D653E0", Offset = "0x4D63BE0", VA = "0x184D653E0")]
	private void BEGFLGJFLDD(DDNDLAPAJNN FCHEJLBOLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D656F0", Offset = "0x4D63EF0", VA = "0x184D656F0")]
	private bool FHCDBMCPBKF(Entity EAALLGNPDMK, [Out] FMMMHPMEALG EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D65930", Offset = "0x4D64130", VA = "0x184D65930")]
	private void JGLJGOOJJGJ(Entity EAALLGNPDMK, FMMMHPMEALG EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D65C20", Offset = "0x4D64420", VA = "0x184D65C20")]
	private bool OMBHHEFCAOJ(FMMMHPMEALG EKNJAMPDKID, [Out] DDNDLAPAJNN FCHEJLBOLOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D654A0", Offset = "0x4D63CA0", VA = "0x184D654A0")]
	private DDNDLAPAJNN BEINLOMMHEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PIFLGJJEBML<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLADDJNGMIA(Entity EAALLGNPDMK, object JILOCOLKOMJ, TValue OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAKLPNFBHDB(Entity EAALLGNPDMK, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBIBLMOFNAG(Entity EAALLGNPDMK, [Out] TValue OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FMMMHPMEALG : KAICMPMFPHE, IEquatable<FMMMHPMEALG>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly FMMMHPMEALG HCANDHABHHO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1CA0", Offset = "0x7CA04A0", VA = "0x187CA1CA0", Slot = "8")]
	public bool Equals(FMMMHPMEALG PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1CF0", Offset = "0x7CA04F0", VA = "0x187CA1CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CEPFFBCIGPC<THasTokensTag> : ANDHLMKAPJB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, FMMMHPMEALG> CBCKCPIHBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> LCAPFPOBDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MCMJDBAFPKC<FMMMHPMEALG, HashSet<object>> DNAHGCCLDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager MIJJPMGKBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem NDLHNEBLCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63E0F70", Offset = "0x63DF770", VA = "0x1863E0F70")]
	public CEPFFBCIGPC(EntityManager MIJJPMGKBJK, EntityCommandBufferSystem NDLHNEBLCBM, LLPKKNNAIAE AFLLDHDDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63DF5E0", Offset = "0x63DDDE0", VA = "0x1863DF5E0", Slot = "4")]
	public bool FLADDJNGMIA(Entity EAALLGNPDMK, object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63E0300", Offset = "0x63DEB00", VA = "0x1863E0300", Slot = "5")]
	public bool MAKLPNFBHDB(Entity EAALLGNPDMK, object JILOCOLKOMJ, [Out] bool IHGDGNLHPKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63DFB50", Offset = "0x63DE350", VA = "0x1863DFB50", Slot = "6")]
	public bool FLNHPINNCHG(Entity EAALLGNPDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63DFC00", Offset = "0x63DE400", VA = "0x1863DFC00", Slot = "8")]
	public bool FLNHPINNCHG(FMMMHPMEALG EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63DED10", Offset = "0x63DD510", VA = "0x1863DED10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63DE4A0", Offset = "0x63DCCA0", VA = "0x1863DE4A0")]
	private void BEGFLGJFLDD(HashSet<object> FCHEJLBOLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63DF350", Offset = "0x63DDB50", VA = "0x1863DF350")]
	private bool FHCDBMCPBKF(Entity EAALLGNPDMK, [Out] FMMMHPMEALG EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63DEE10", Offset = "0x63DD610", VA = "0x1863DEE10")]
	private bool EHCKBKEFOII(Entity EAALLGNPDMK, [Out] FMMMHPMEALG EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63DDF50", Offset = "0x63DC750", VA = "0x1863DDF50")]
	private void BCOLIOEJAED(Entity EAALLGNPDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63DE790", Offset = "0x63DCF90", VA = "0x1863DE790")]
	private void COODIJADBFN(Entity EAALLGNPDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63E00A0", Offset = "0x63DE8A0", VA = "0x1863E00A0")]
	private void IOBCOMKPEKN(Entity EAALLGNPDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63E01B0", Offset = "0x63DE9B0", VA = "0x1863E01B0")]
	private void JGLJGOOJJGJ(Entity EAALLGNPDMK, FMMMHPMEALG EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63DECB0", Offset = "0x63DD4B0", VA = "0x1863DECB0")]
	private bool DCLIMOBKPAF(FMMMHPMEALG EKNJAMPDKID, [Out] HashSet<object> FCHEJLBOLOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63DE6F0", Offset = "0x63DCEF0", VA = "0x1863DE6F0")]
	private HashSet<object> BEINLOMMHEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AHHHDEOGCAE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FNKCJAOHOCI : MOKMFFMCGGG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1D40", Offset = "0x7CA0540", VA = "0x187CA1D40")]
	public float CAINCJAHEMF([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1D40", Offset = "0x7CA0540", VA = "0x187CA1D40", Slot = "4")]
	private float KLAPGNBIHEN([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FKBHGACPIPI : MOKMFFMCGGG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1C90", Offset = "0x7CA0490", VA = "0x187CA1C90")]
	public float CAINCJAHEMF([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1C90", Offset = "0x7CA0490", VA = "0x187CA1C90", Slot = "4")]
	private float KLAPGNBIHEN([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EEMIOFEMPHE : MOKMFFMCGGG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xE32C60", Offset = "0xE31460", VA = "0x180E32C60")]
	public float CAINCJAHEMF([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE32C60", Offset = "0xE31460", VA = "0x180E32C60", Slot = "4")]
	private float KLAPGNBIHEN([In] float3 OPMIAMEJKDH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BGHOHEDPPFF : MOKMFFMCGGG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x212E4E0", Offset = "0x212CCE0", VA = "0x18212E4E0")]
	public int CAINCJAHEMF([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x212E4E0", Offset = "0x212CCE0", VA = "0x18212E4E0", Slot = "4")]
	private int KJBFBMNCNEL([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ACMGJGEFPLG : MOKMFFMCGGG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEC83B0", Offset = "0xEC6BB0", VA = "0x180EC83B0")]
	public int CAINCJAHEMF([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xEC83B0", Offset = "0xEC6BB0", VA = "0x180EC83B0", Slot = "4")]
	private int KJBFBMNCNEL([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MIDIGIEGPJI : MOKMFFMCGGG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xE18350", Offset = "0xE16B50", VA = "0x180E18350")]
	public int CAINCJAHEMF([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE18350", Offset = "0xE16B50", VA = "0x180E18350", Slot = "4")]
	private int KJBFBMNCNEL([In] int3 OPMIAMEJKDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IOAICHFJAEI : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	public IOAICHFJAEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class KNGBAOCKOIB : SystemBase, MAOCEBGBGNM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2630", Offset = "0x7CA0E30", VA = "0x187CA2630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x383FAB0", Offset = "0x383E2B0", VA = "0x18383FAB0")]
	public void GADOJFNFMIK<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x383FAB0", Offset = "0x383E2B0", VA = "0x18383FAB0")]
	public void PJHJPDKMIIN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CA24A0", Offset = "0x7CA0CA0", VA = "0x187CA24A0")]
	public JobHandle IMAOFBNMFAJ(ReadOnlySpan<int> ALJDBMEMACC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x383F930", Offset = "0x383E130", VA = "0x18383F930")]
	public JobHandle EOGIHCBIFFD<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2430", Offset = "0x7CA0C30", VA = "0x187CA2430")]
	public JobHandle EOGIHCBIFFD(ReadOnlySpan<int> ALJDBMEMACC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x383FB10", Offset = "0x383E310", VA = "0x18383FB10")]
	public void OKCKEHAMFIE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x383FE40", Offset = "0x383E640", VA = "0x18383FE40")]
	public JobHandle OKCKEHAMFIE<T>(JobHandle EKNJAMPDKID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CA25C0", Offset = "0x7CA0DC0", VA = "0x187CA25C0")]
	public JobHandle OKCKEHAMFIE(ReadOnlySpan<int> ALJDBMEMACC, JobHandle EKNJAMPDKID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x383FB10", Offset = "0x383E310", VA = "0x18383FB10")]
	public void JIOJFIEFDHM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x383FBA0", Offset = "0x383E3A0", VA = "0x18383FBA0")]
	public JobHandle JIOJFIEFDHM<T>(JobHandle EKNJAMPDKID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA24F0", Offset = "0x7CA0CF0", VA = "0x187CA24F0")]
	public JobHandle JIOJFIEFDHM(Span<int> ALJDBMEMACC, JobHandle EKNJAMPDKID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x383F860", Offset = "0x383E060", VA = "0x18383F860")]
	public ComponentDataFromEntity CLKFAAACOPC<T>(bool LLMFDIDBMNA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2370", Offset = "0x7CA0B70", VA = "0x187CA2370")]
	public ComponentDataFromEntity CLKFAAACOPC(int HHKKDJCOGMF, bool LLMFDIDBMNA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x383F9E0", Offset = "0x383E1E0", VA = "0x18383F9E0")]
	public SharedComponentIndexFromEntity<T> FEEJOOGLAFC<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2560", Offset = "0x7CA0D60", VA = "0x187CA2560")]
	[BurstCompatible]
	public ComponentTypeHandle KJJPEMCEDFI(ComponentType AMEJPCJGKPP)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2480", Offset = "0x7CA0C80", VA = "0x187CA2480")]
	public EntityExistenceLookupByEntity IKKNJHBPPLH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2660", Offset = "0x7CA0E60", VA = "0x187CA2660", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x383F740", Offset = "0x383DF40", VA = "0x18383F740")]
	public bool CJOBDHHGECD<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	protected KNGBAOCKOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CCLDLFLPMNI : KNGBAOCKOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1BB0", Offset = "0x7CA03B0", VA = "0x187CA1BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20278A0", Offset = "0x20260A0", VA = "0x1820278A0")]
	protected CCLDLFLPMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IFMLJKCDCCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MKFKNBDBOBL : EntityCommandBufferSystem, MAOCEBGBGNM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LLPKKNNAIAE BAOGIJBMDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD44100", Offset = "0xD42900", VA = "0x180D44100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2670", Offset = "0x7CA0E70", VA = "0x187CA2670")]
	public MKFKNBDBOBL(LLPKKNNAIAE NOMHFHBJHNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MOKMFFMCGGG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo CAINCJAHEMF([In] TFrom OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KCIANLMJGBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCOMBHMEADL(T OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct IENDDHONCJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes LHEKOBJHPPK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2280", Offset = "0x7CA0A80", VA = "0x187CA2280", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct AEIBOBEKFJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA16A0", Offset = "0x7C9FEA0", VA = "0x187CA16A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct HJNDKEKEJMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType AMEJPCJGKPP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2170", Offset = "0x7CA0970", VA = "0x187CA2170", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct ONIFOJPGELG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5483AB0", Offset = "0x54822B0", VA = "0x185483AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct PMMLOIIJMJG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> MGEDIIGJIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct COBNNBLNKHD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OPMIAMEJKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer CBCMIFJOCPK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PAPHANPIHBA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MOKMFFMCGGG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> APOHPEFKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NHEECPBENBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity FDFECMEFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> APOHPEFKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OFLHGGIKBNI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2840", Offset = "0x7CA1040", VA = "0x187CA2840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct OAHMMCBMKPD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AMEIDBMGNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> HIMHHLFHGPO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LAKOFJFEEOJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MOKMFFMCGGG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> CNJLCKLLHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> APOHPEFKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct MIJEKAIIFML<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> INEJBPIGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> KDJLHLOCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> JFALCMCMICD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct FEJJFIMDJPI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> INEJBPIGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> KDJLHLOCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> JFALCMCMICD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4868FD0", Offset = "0x48677D0", VA = "0x184868FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KBCBMHNNGFH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> HIMHHLFHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> NKKKOCAGLDI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA400", Offset = "0x4EE8C00", VA = "0x184EEA400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct NCODJPODILM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : MOKMFFMCGGG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> HIMHHLFHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> NKKKOCAGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GNHHLOKNING<T, TPredicate> : IJob where T : struct where TPredicate : struct, KCIANLMJGBP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> AMFIFJPDEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> ICAFELDJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct AABMIBHFKFF<T, TPredicate> : IJob where T : struct where TPredicate : struct, KCIANLMJGBP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> LFDCPCADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> HIMHHLFHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct HMNOPNHCLLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity INEJBPIGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> KDJLHLOCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LKPIFPJHGNC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA21F0", Offset = "0x7CA09F0", VA = "0x187CA21F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct PAJFGDJCIKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity INEJBPIGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> KDJLHLOCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> LKPIFPJHGNC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA29C0", Offset = "0x7CA11C0", VA = "0x187CA29C0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GICMLGGKPDC
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class OPGFEMOABAH
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3962430", Offset = "0x3960C30", VA = "0x183962430")]
	public static bool CHPHGAOFDAN<T>(this NativeArray<Entity> KDJLHLOCFAD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DOENLCOBKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DJHLBJBBJCM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public DJHLBJBBJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ICMMLLBIAAH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public ICMMLLBIAAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> AFNPJOCMONM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1BE0", Offset = "0x7CA03E0", VA = "0x187CA1BE0")]
	public DOENLCOBKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FMHKPGDINJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LFFLGBFEAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct HBBPLAGJGCN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct CFPNEPFFKFK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal HBBPLAGJGCN<TFrom> DFPCBMGPBFO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> GGBFBJAOFOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct ADPOKNEBDPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AANPFDDPMME<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal ADPOKNEBDPB<TFrom> DFPCBMGPBFO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> GGBFBJAOFOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct JAPIBOAOPJA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct DKLAEFMHNEN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal JAPIBOAOPJA<TFrom> DFPCBMGPBFO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> GGBFBJAOFOK;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct APAAIBAMOJM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct OILADGOKHJE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal APAAIBAMOJM<TFrom> DFPCBMGPBFO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> GGBFBJAOFOK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CIHJFJEJLLD
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GBDCJCHKKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3793890", Offset = "0x3792090", VA = "0x183793890")]
	public static NativeList<T> NPBHMFMNMAH<T>(this NativeArray<T> BIAKPLJDFKD, Allocator KKCJNCNIICO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LAAAKFILLGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FOGBNCLFGHO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3786E60", Offset = "0x3785660", VA = "0x183786E60")]
	[JHNMDGNOLOI]
	public static JobHandle CJDLPLCOPCG<T>(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArray<Entity> OOCEMABKIJN, NativeArray<T> NFNBKNAJBPN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3786BB0", Offset = "0x37853B0", VA = "0x183786BB0")]
	[JHNMDGNOLOI]
	public static JobHandle CJDLPLCOPCG<T>(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArrayAsync<Entity> OOCEMABKIJN, NativeArrayAsync<T> NFNBKNAJBPN, [Optional] JobHandle LHPJLLFOIME) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3786D30", Offset = "0x3785530", VA = "0x183786D30")]
	[JHNMDGNOLOI]
	public static JobHandle CJDLPLCOPCG<T>(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArray<Entity> OOCEMABKIJN, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1D50", Offset = "0x7CA0550", VA = "0x187CA1D50")]
	[JHNMDGNOLOI]
	public static JobHandle CJDLPLCOPCG(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArray<Entity> OOCEMABKIJN, ComponentTypes LHEKOBJHPPK, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1EC0", Offset = "0x7CA06C0", VA = "0x187CA1EC0")]
	[JHNMDGNOLOI]
	public static JobHandle CJDLPLCOPCG(this EntityCommandBufferSystem NDLHNEBLCBM, EntityCommandBuffer CBCMIFJOCPK, NativeArray<Entity> OOCEMABKIJN, ComponentTypes LHEKOBJHPPK, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MLOLDJPLJJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AGCOANKJEBH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1840", Offset = "0x7CA0040", VA = "0x187CA1840")]
	[JHNMDGNOLOI]
	public static JobHandle BEFNLAEAPBJ(this EntityCommandBufferSystem NDLHNEBLCBM, NativeList<Entity> OOCEMABKIJN, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1740", Offset = "0x7C9FF40", VA = "0x187CA1740")]
	[JHNMDGNOLOI]
	public static JobHandle BEFNLAEAPBJ(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArrayAsync<Entity> OOCEMABKIJN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MPAKBFJJHOF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x38C69E0", Offset = "0x38C51E0", VA = "0x1838C69E0")]
	[JHNMDGNOLOI]
	public static JobHandle JCOAICEACFJ<T>(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArrayAsync<Entity> OOCEMABKIJN, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA26B0", Offset = "0x7CA0EB0", VA = "0x187CA26B0")]
	[JHNMDGNOLOI]
	public static JobHandle JCOAICEACFJ(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArrayAsync<Entity> OOCEMABKIJN, ComponentType AMEJPCJGKPP, [Optional] JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LBPNFPHHMKC
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3841F90", Offset = "0x3840790", VA = "0x183841F90")]
	[JHNMDGNOLOI]
	public static JobHandle JAOMEIECCCO<T>(this EntityCommandBufferSystem NDLHNEBLCBM, NativeArray<Entity> OOCEMABKIJN, NativeArray<T> NFNBKNAJBPN, JobHandle LHPJLLFOIME) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OFJPGGGCLEA
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BLPIBMMMHMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BGKNDAAEACI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x351E520", Offset = "0x351CD20", VA = "0x18351E520")]
	public static NativeArray<T> HAIBLLIPFLK<T>(this NativeList<Entity> BIAKPLJDFKD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x351E340", Offset = "0x351CB40", VA = "0x18351E340")]
	public static NativeArray<T> HAIBLLIPFLK<T>(this NativeArray<Entity> BIAKPLJDFKD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA19D0", Offset = "0x7CA01D0", VA = "0x187CA19D0")]
	public static NativeArray<Entity> NDDJBHPANOA(this NativeArray<Entity> BIAKPLJDFKD, EntityManager MIJJPMGKBJK, ComponentType AMEJPCJGKPP, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x351E240", Offset = "0x351CA40", VA = "0x18351E240")]
	public static NativeArray<T> FEMFGILDNDM<T>(this NativeArray<Entity> BIAKPLJDFKD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AFENJPJIKNF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IDPAAHNHOMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct FNNEGJMMLDN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public IDPAAHNHOMK<TFrom> GGBFBJAOFOK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KEJANABECOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct EFKODHGHGML<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KEJANABECOG<TFrom> GGBFBJAOFOK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct HMIILOFOPNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct ODFKNKAHDOC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public HMIILOFOPNJ<TFrom> GGBFBJAOFOK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> LFDCPCADJCD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CHBGOBPGGAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NFHECLJBEHC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct MMNEBEGCDGD : MOKMFFMCGGG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CA26A0", Offset = "0x7CA0EA0", VA = "0x187CA26A0")]
		[BurstCompatible]
		public Entity CAINCJAHEMF([In] Entity OPMIAMEJKDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CA26A0", Offset = "0x7CA0EA0", VA = "0x187CA26A0", Slot = "4")]
		private Entity DBPFNAKANLK([In] Entity OPMIAMEJKDH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class BJKPFNMPMAJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct KFHIHNMGPDF<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCF0", Offset = "0x4EFA4F0", VA = "0x184EFBCF0", Slot = "4")]
		public int Compare((TKey, TValue) LEFBJAGNHCD, (TKey, TValue) LLGPJHIECFH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x352C980", Offset = "0x352B180", VA = "0x18352C980")]
	public static void JAEEGIBJLDK<TKey, TValue>(NativeList<TKey> IDLKPIHPINJ, NativeList<TValue> MGEDIIGJIGC) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x352CC10", Offset = "0x352B410", VA = "0x18352CC10")]
	public static void JAEEGIBJLDK<TKey, TValue>(NativeArray<TKey> IDLKPIHPINJ, NativeArray<TValue> MGEDIIGJIGC) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x352C740", Offset = "0x352AF40", VA = "0x18352C740")]
	public static void JAEEGIBJLDK<TKey, TValue, U>(NativeArray<TKey> IDLKPIHPINJ, NativeArray<TValue> MGEDIIGJIGC, U AECIPDCMJOO) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FFONAHEMCOH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct JACCOHFLOOI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> AMFIFJPDEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct AJFCMNJKFOI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> AMFIFJPDEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KKAIBEJDMPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> AMFIFJPDEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> LFDCPCADJCD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CEFGLOFNPHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class IDNKNLIFELK
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GDNFMLEFKPC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct KDFNGAFCOFE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct EEIPHNDPKHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> LFDCPCADJCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct POBPFCLOPHG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator KKCJNCNIICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> LFDCPCADJCD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NDAAFMCNADG
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class LOJEIMAGONI
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3891AD0", Offset = "0x38902D0", VA = "0x183891AD0")]
	public static NativeList<Entity> ICILCIIOOKN<T>(this NativeList<Entity> KDJLHLOCFAD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3891300", Offset = "0x388FB00", VA = "0x183891300")]
	public static NativeList<Entity> ICILCIIOOKN<T>(this NativeArray<Entity> KDJLHLOCFAD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class MFKOHGMAGDB
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38C01F0", Offset = "0x38BE9F0", VA = "0x1838C01F0")]
	public static NativeList<Entity> LNLFENFECJK<T>(this NativeArray<Entity> KDJLHLOCFAD, EntityManager MIJJPMGKBJK, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FOLCLBIBMBB
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct DJOKIDPFJEF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CPIDEKBKOPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct PKCLGHNKKBE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> CPIDEKBKOPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct CCLNABKKLDC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MOKMFFMCGGG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> CPIDEKBKOPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HJNIFDEPGFE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, MOKMFFMCGGG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> CPIDEKBKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector IGHLBLMKLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int FPEOONOJHML;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FADEFELFEAF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MOKMFFMCGGG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private HJNIFDEPGFE<TSrc, TValue, TSelector> GDPKJELKNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue IEHMPFAMKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int IFOFOJHAFEG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class CHDKJGIJKHN
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct HGGDCMAPEKA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> CPIDEKBKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int IFOFOJHAFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int HOKEANNHDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T IEHMPFAMKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T GNBCJEAPGLE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CFCDJGMMHDE GDGOFJJKHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C8C0", Offset = "0x4A4B0C0", VA = "0x184A4C8C0")]
			get
			{
				return default(CFCDJGMMHDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T APFLNMFBJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, CFCDJGMMHDE) IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4A4CAD0", Offset = "0x4A4B2D0", VA = "0x184A4CAD0")]
			get
			{
				return default((T, CFCDJGMMHDE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CBA0", Offset = "0x4A4B3A0", VA = "0x184A4CBA0")]
		public HGGDCMAPEKA(NativeArray<T> CPIDEKBKOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x395E070", Offset = "0x395C870", VA = "0x18395E070")]
		public HGGDCMAPEKA<T> DPNIJJHCOGM()
		{
			return default(HGGDCMAPEKA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C5E0", Offset = "0x4A4ADE0", VA = "0x184A4C5E0")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x398EA00", Offset = "0x398D200", VA = "0x18398EA00")]
		public DEMGEHIPCBK<T, TComparer> MHFIMIPIHKK<TComparer>([Optional] TComparer AECIPDCMJOO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DEMGEHIPCBK<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct DEMGEHIPCBK<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> CPIDEKBKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IFOFOJHAFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int HOKEANNHDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T IEHMPFAMKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T GNBCJEAPGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer AECIPDCMJOO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CFCDJGMMHDE GDGOFJJKHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C8C0", Offset = "0x4A4B0C0", VA = "0x184A4C8C0")]
			get
			{
				return default(CFCDJGMMHDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T APFLNMFBJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, CFCDJGMMHDE range) IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4A4CAD0", Offset = "0x4A4B2D0", VA = "0x184A4CAD0")]
			get
			{
				return default((T, CFCDJGMMHDE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x68CC140", Offset = "0x68CA940", VA = "0x1868CC140")]
		public DEMGEHIPCBK(NativeArray<T> CPIDEKBKOPO, TComparer AECIPDCMJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x44ECC00", Offset = "0x44EB400", VA = "0x1844ECC00")]
		public DEMGEHIPCBK<T, TComparer> DPNIJJHCOGM()
		{
			return default(DEMGEHIPCBK<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x68CC060", Offset = "0x68CA860", VA = "0x1868CC060")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x358F240", Offset = "0x358DA40", VA = "0x18358F240")]
	public static HGGDCMAPEKA<T> JCDLBMPPNLI<T>(this NativeArray<T> CPIDEKBKOPO) where T : struct
	{
		return default(HGGDCMAPEKA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface OFINLFIJFCF
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class JNCKFAMBOFI
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct EILJBBONJNB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class GICDAHNPEFF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public EILJBBONJNB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x492D4C0", Offset = "0x492BCC0", VA = "0x18492D4C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public GICDAHNPEFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x49B19F0", Offset = "0x49B01F0", VA = "0x1849B19F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x49B1BC0", Offset = "0x49B03C0", VA = "0x1849B1BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> CBIJOMFDBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream PIAGKKGLFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream OBHMIOCKKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf IJHICJECDIG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44007E0", Offset = "0x43FEFE0", VA = "0x1844007E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4400820", Offset = "0x43FF020", VA = "0x184400820", Slot = "4")]
	[IteratorStateMachine(typeof(EILJBBONJNB<>.GICDAHNPEFF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4400920", Offset = "0x43FF120", VA = "0x184400920", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JPMLLJGMMFC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] HOAEKOMMHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf IJHICJECDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream PIAGKKGLFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream DFKIMGJGJDG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E300A0", Offset = "0x4E2E8A0", VA = "0x184E300A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct HIOJBDNBMAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream PIAGKKGLFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream OBHMIOCKKGD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2130", Offset = "0x7CA0930", VA = "0x187CA2130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HBOPIOHBDHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] HOAEKOMMHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream PIAGKKGLFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream DFKIMGJGJDG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2010", Offset = "0x7CA0810", VA = "0x187CA2010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CKKBGCDCJFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class JCHFNPGCBED
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum CDDPCFFKLHL
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
internal static class AIPCKJBBPOO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
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
