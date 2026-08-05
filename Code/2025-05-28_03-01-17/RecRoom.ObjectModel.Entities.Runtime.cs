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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F58EB0", Offset = "0x7F57CB0", VA = "0x187F58EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F587A0", Offset = "0x7F575A0", VA = "0x187F587A0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IOAANAKHIMO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LEAOBEHEHNM PFBMALFMIMP
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
public interface EPMKCMGGBAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGBLEHKDIID(Entity OFJKELIPJNP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MGKNCMNNDCI(Entity OFJKELIPJNP, object JLFLGDNCANL, [Out] bool KCEDHEMFCPJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHCMKFAADEC(Entity OFJKELIPJNP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EEBCBDBAAHA<TComponentData, TValue> : PMMLCDPOHFL<TValue>, IDisposable where TComponentData : struct, IOAANAKHIMO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class EGOLMKLFNGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> COKPAJOONAO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int GFOKFGGJOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x41B40C0", Offset = "0x41B2EC0", VA = "0x1841B40C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x45F9FF0", Offset = "0x45F8DF0", VA = "0x1845F9FF0")]
		public bool CJDKNLDONPE([Out] TValue OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x45F9F10", Offset = "0x45F8D10", VA = "0x1845F9F10")]
		public void AIKICPLLADB(object JLFLGDNCANL, TValue OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x45FA1E0", Offset = "0x45F8FE0", VA = "0x1845FA1E0")]
		public bool FKCGDELNEED(object JLFLGDNCANL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45FA100", Offset = "0x45F8F00", VA = "0x1845FA100")]
		public int DAHONCDEKIP(object JLFLGDNCANL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x45FA290", Offset = "0x45F9090", VA = "0x1845FA290")]
		public EGOLMKLFNGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<EGOLMKLFNGC> PALCJEHNKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FNGLBMMBANM<LEAOBEHEHNM, EGOLMKLFNGC> MEHACDCDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager CCPBGAMLKKA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x45E0640", Offset = "0x45DF440", VA = "0x1845E0640")]
	public EEBCBDBAAHA(EntityManager CCPBGAMLKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45E03C0", Offset = "0x45DF1C0", VA = "0x1845E03C0", Slot = "4")]
	public void NGBLEHKDIID(Entity OFJKELIPJNP, object JLFLGDNCANL, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45E0110", Offset = "0x45DEF10", VA = "0x1845E0110", Slot = "5")]
	public bool MGKNCMNNDCI(Entity OFJKELIPJNP, object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45DFEA0", Offset = "0x45DECA0", VA = "0x1845DFEA0", Slot = "6")]
	public bool CJDKNLDONPE(Entity OFJKELIPJNP, [Out] TValue OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x45DFFB0", Offset = "0x45DEDB0", VA = "0x1845DFFB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45DFDE0", Offset = "0x45DEBE0", VA = "0x1845DFDE0")]
	private void AAODNCADPDP(EGOLMKLFNGC ICKIMHHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45E0300", Offset = "0x45DF100", VA = "0x1845E0300")]
	private bool MNJBMODNJCI(Entity OFJKELIPJNP, [Out] LEAOBEHEHNM BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45E0540", Offset = "0x45DF340", VA = "0x1845E0540")]
	private void OLOPEIDODHP(Entity OFJKELIPJNP, LEAOBEHEHNM BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45E00F0", Offset = "0x45DEEF0", VA = "0x1845E00F0")]
	private bool JPECHBIAFGI(LEAOBEHEHNM BHHPJCAPOMD, [Out] EGOLMKLFNGC ICKIMHHFOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45DFFD0", Offset = "0x45DEDD0", VA = "0x1845DFFD0")]
	private EGOLMKLFNGC HHJJEFOEMDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PMMLCDPOHFL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGBLEHKDIID(Entity OFJKELIPJNP, object JLFLGDNCANL, TValue OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MGKNCMNNDCI(Entity OFJKELIPJNP, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJDKNLDONPE(Entity OFJKELIPJNP, [Out] TValue OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LEAOBEHEHNM : OBLKINNOMIA, IEquatable<LEAOBEHEHNM>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly LEAOBEHEHNM IPPDMFADBOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JCCDJKBJEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F58D50", Offset = "0x7F57B50", VA = "0x187F58D50", Slot = "8")]
	public bool Equals(LEAOBEHEHNM HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F58DA0", Offset = "0x7F57BA0", VA = "0x187F58DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DMCBBLBOBID<THasTokensTag> : EPMKCMGGBAA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, LEAOBEHEHNM> IDIDOOBIEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> PALCJEHNKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FNGLBMMBANM<LEAOBEHEHNM, HashSet<object>> MEHACDCDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager CCPBGAMLKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem IBKADNGKJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B26C30", Offset = "0x6B25A30", VA = "0x186B26C30")]
	public DMCBBLBOBID(EntityManager CCPBGAMLKKA, EntityCommandBufferSystem IBKADNGKJHI, IEBEPMGFCGH GBPJMCEHKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B268A0", Offset = "0x6B256A0", VA = "0x186B268A0", Slot = "4")]
	public bool NGBLEHKDIID(Entity OFJKELIPJNP, object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B25A20", Offset = "0x6B24820", VA = "0x186B25A20", Slot = "5")]
	public bool MGKNCMNNDCI(Entity OFJKELIPJNP, object JLFLGDNCANL, [Out] bool KCEDHEMFCPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B25550", Offset = "0x6B24350", VA = "0x186B25550", Slot = "6")]
	public bool IHCMKFAADEC(Entity OFJKELIPJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B25600", Offset = "0x6B24400", VA = "0x186B25600", Slot = "8")]
	public bool IHCMKFAADEC(LEAOBEHEHNM BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B24580", Offset = "0x6B23380", VA = "0x186B24580", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B241D0", Offset = "0x6B22FD0", VA = "0x186B241D0")]
	private void AAODNCADPDP(HashSet<object> ICKIMHHFOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B26260", Offset = "0x6B25060", VA = "0x186B26260")]
	private bool MNJBMODNJCI(Entity OFJKELIPJNP, [Out] LEAOBEHEHNM BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B24480", Offset = "0x6B23280", VA = "0x186B24480")]
	private bool CBLLGKFFNFD(Entity OFJKELIPJNP, [Out] LEAOBEHEHNM BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B25140", Offset = "0x6B23F40", VA = "0x186B25140")]
	private void HMKIAFMALCI(Entity OFJKELIPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B248C0", Offset = "0x6B236C0", VA = "0x186B248C0")]
	private void GHBLNIIMPNO(Entity OFJKELIPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B24820", Offset = "0x6B23620", VA = "0x186B24820")]
	private void FCNONALDHEO(Entity OFJKELIPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B26A70", Offset = "0x6B25870", VA = "0x186B26A70")]
	private void OLOPEIDODHP(Entity OFJKELIPJNP, LEAOBEHEHNM BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B25710", Offset = "0x6B24510", VA = "0x186B25710")]
	private bool MEHBOEDBNFA(LEAOBEHEHNM BHHPJCAPOMD, [Out] HashSet<object> ICKIMHHFOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B24D60", Offset = "0x6B23B60", VA = "0x186B24D60")]
	private HashSet<object> HHJJEFOEMDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PHGJMGAKDNH
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GGAFCPLAJED : JJKIBONBDHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F587C0", Offset = "0x7F575C0", VA = "0x187F587C0")]
	public float LJDLCLCJELO([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F587C0", Offset = "0x7F575C0", VA = "0x187F587C0", Slot = "4")]
	private float MKEIMKNEHIK([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OEAMGNIMDBC : JJKIBONBDHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F30", Offset = "0x7F57D30", VA = "0x187F58F30")]
	public float LJDLCLCJELO([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F30", Offset = "0x7F57D30", VA = "0x187F58F30", Slot = "4")]
	private float MKEIMKNEHIK([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CKCPEBJJJHJ : JJKIBONBDHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xE9AF80", Offset = "0xE99D80", VA = "0x180E9AF80")]
	public float LJDLCLCJELO([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE9AF80", Offset = "0xE99D80", VA = "0x180E9AF80", Slot = "4")]
	private float MKEIMKNEHIK([In] float3 OAIIHELJHLG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MELHAIHEJOO : JJKIBONBDHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21E85F0", Offset = "0x21E73F0", VA = "0x1821E85F0")]
	public int LJDLCLCJELO([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21E85F0", Offset = "0x21E73F0", VA = "0x1821E85F0", Slot = "4")]
	private int MFGLOJMMIEM([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KCHBOKKFEPI : JJKIBONBDHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xF1DD80", Offset = "0xF1CB80", VA = "0x180F1DD80")]
	public int LJDLCLCJELO([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xF1DD80", Offset = "0xF1CB80", VA = "0x180F1DD80", Slot = "4")]
	private int MFGLOJMMIEM([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KOMLEPFLICB : JJKIBONBDHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xE69BA0", Offset = "0xE689A0", VA = "0x180E69BA0")]
	public int LJDLCLCJELO([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE69BA0", Offset = "0xE689A0", VA = "0x180E69BA0", Slot = "4")]
	private int MFGLOJMMIEM([In] int3 OAIIHELJHLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KJICBENAKPP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	public KJICBENAKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class PKLCKAMFOHP : SystemBase, DDFMLHAKJIG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F59130", Offset = "0x7F57F30", VA = "0x187F59130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B20330", Offset = "0x3B1F130", VA = "0x183B20330")]
	public void KKCCCAHFOAM<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B20330", Offset = "0x3B1F130", VA = "0x183B20330")]
	public void PJLOOBEDDMF<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F59210", Offset = "0x7F58010", VA = "0x187F59210")]
	public JobHandle MBPBMDOLJHC(ReadOnlySpan<int> HLNLPHDHEEM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B20390", Offset = "0x3B1F190", VA = "0x183B20390")]
	public JobHandle LBAHBLPHBLE<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F591C0", Offset = "0x7F57FC0", VA = "0x187F591C0")]
	public JobHandle LBAHBLPHBLE(ReadOnlySpan<int> HLNLPHDHEEM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F480", Offset = "0x3B1E280", VA = "0x183B1F480")]
	public void FHOOJCPIGNA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F9A0", Offset = "0x3B1E7A0", VA = "0x183B1F9A0")]
	public JobHandle FHOOJCPIGNA<T>(JobHandle BHHPJCAPOMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F590A0", Offset = "0x7F57EA0", VA = "0x187F590A0")]
	public JobHandle FHOOJCPIGNA(ReadOnlySpan<int> HLNLPHDHEEM, JobHandle BHHPJCAPOMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F480", Offset = "0x3B1E280", VA = "0x183B1F480")]
	public void AHLKIFKGHDC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F510", Offset = "0x3B1E310", VA = "0x183B1F510")]
	public JobHandle AHLKIFKGHDC<T>(JobHandle BHHPJCAPOMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F70", Offset = "0x7F57D70", VA = "0x187F58F70")]
	public JobHandle AHLKIFKGHDC(Span<int> HLNLPHDHEEM, JobHandle BHHPJCAPOMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F8D0", Offset = "0x3B1E6D0", VA = "0x183B1F8D0")]
	public ComponentDataFromEntity ENIGGODAAFE<T>(bool DLODKGPBAGL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F58FE0", Offset = "0x7F57DE0", VA = "0x187F58FE0")]
	public ComponentDataFromEntity ENIGGODAAFE(int HIICBEJDFMG, bool DLODKGPBAGL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B20260", Offset = "0x3B1F060", VA = "0x183B20260")]
	public SharedComponentIndexFromEntity<T> GDKPFMMJOLP<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F59160", Offset = "0x7F57F60", VA = "0x187F59160")]
	[BurstCompatible]
	public ComponentTypeHandle KEJDIHKHEOE(ComponentType PGGHOMGDDEG)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F59110", Offset = "0x7F57F10", VA = "0x187F59110")]
	public EntityExistenceLookupByEntity FLGPNCMLICC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F59260", Offset = "0x7F58060", VA = "0x187F59260", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F7B0", Offset = "0x3B1E5B0", VA = "0x183B1F7B0")]
	public bool CCCIECBKHNN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	protected PKLCKAMFOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NJJPNDJHGMF : PKLCKAMFOHP
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F58E80", Offset = "0x7F57C80", VA = "0x187F58E80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	protected NJJPNDJHGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DBMJJANGJFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PFKJHKKBMOO : EntityCommandBufferSystem, DDFMLHAKJIG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IEBEPMGFCGH NDLHJECGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD99660", Offset = "0xD98460", VA = "0x180D99660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F40", Offset = "0x7F57D40", VA = "0x187F58F40")]
	public PFKJHKKBMOO(IEBEPMGFCGH NHLEILEPJMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JJKIBONBDHP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LJDLCLCJELO([In] TFrom OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ONBNMELPNBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDNHLJEGIDF(T OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct CBMKBAIGEON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes CJNKCIJAONA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F585E0", Offset = "0x7F573E0", VA = "0x187F585E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct BNFHDBMGBLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F58540", Offset = "0x7F57340", VA = "0x187F58540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct BFAHODHOJMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType PGGHOMGDDEG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F58050", Offset = "0x7F56E50", VA = "0x187F58050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct HOAKJPBKIFC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C55260", Offset = "0x4C54060", VA = "0x184C55260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct KDMCAABAHGC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> BGBLHEHBHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct IFJMJDBGDPL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OAIIHELJHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer KGEALJMNJLG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct IOMCBBJHCNP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JJKIBONBDHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CNLDPMEOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct ILLEBOFJPBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity NKMJFIKMHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CNLDPMEOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int IIMONPEEIFP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F587E0", Offset = "0x7F575E0", VA = "0x187F587E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct KHCJNHNHLGI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NEFAJDMEDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> OPEHLHBGEFD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GNPFNLJKIGA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JJKIBONBDHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> MPJKOIHIEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CNLDPMEOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PHGDAGNOAPP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBHALLEHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PMJLBGGLKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> EDNMANGMJKA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct AKKAPJFBFLK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBHALLEHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> PMJLBGGLKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> EDNMANGMJKA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3200", Offset = "0x4DC2000", VA = "0x184DC3200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JGNAKGILFBO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> OPEHLHBGEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> HKJIFBOMMOL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC7D0", Offset = "0x4FAB5D0", VA = "0x184FAC7D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HHBNEHOGDPJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JJKIBONBDHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> OPEHLHBGEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> HKJIFBOMMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NFONDCDGHAP<T, TPredicate> : IJob where T : struct where TPredicate : struct, ONBNMELPNBK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> AHJIALOAFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> HFFAODNIGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct PDADIONMDEK<T, TPredicate> : IJob where T : struct where TPredicate : struct, ONBNMELPNBK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> HGMFLOGEOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OPEHLHBGEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate CFDGGKIIHOI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct EFIFOLMDDOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity IBHALLEHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PMJLBGGLKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> OLBBMNKEPMA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F58710", Offset = "0x7F57510", VA = "0x187F58710", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct JIFMMBDPDFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity IBHALLEHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> PMJLBGGLKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> OLBBMNKEPMA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F58BA0", Offset = "0x7F579A0", VA = "0x187F58BA0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KDKCMNIMEGO
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LAIJNHACFPI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x39E4F90", Offset = "0x39E3D90", VA = "0x1839E4F90")]
	public static bool HMFIOPNICKA<T>(this NativeArray<Entity> PMJLBGGLKDD, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NGHFPFEJNKO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JNBCKJIDLFD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public JNBCKJIDLFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CEBMMPJNKOE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public CEBMMPJNKOE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> MIHFGCPHKIC;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F58DF0", Offset = "0x7F57BF0", VA = "0x187F58DF0")]
	public NGHFPFEJNKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HLPGHDFIDMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FIIHKIADPIL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct LJNELPLBKFO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct NBMPABHIEPL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal LJNELPLBKFO<TFrom> BOGJJGPKPIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> KHJEADFMOJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FIMPOMHMPGF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PNDPPDKJFGE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal FIMPOMHMPGF<TFrom> BOGJJGPKPIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> KHJEADFMOJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FAFIMMPDLJI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct GAOEMDEKIMO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal FAFIMMPDLJI<TFrom> BOGJJGPKPIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> KHJEADFMOJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PLCIFBBCDOI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct FNLAMCFANJN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal PLCIFBBCDOI<TFrom> BOGJJGPKPIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> KHJEADFMOJM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GAJFDJPBHKO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CBOGLPKEEEI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3706AB0", Offset = "0x37058B0", VA = "0x183706AB0")]
	public static NativeList<T> HPBFLGCHALH<T>(this NativeArray<T> FKOKJEMCHKJ, Allocator LNMGNHHGHLL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OAGKNACIPLC
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JAAADKIECAE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3968890", Offset = "0x3967690", VA = "0x183968890")]
	[NENPGMJIAPO]
	public static JobHandle KOLILBNFMNI<T>(this EntityCommandBufferSystem IBKADNGKJHI, NativeArray<Entity> KKDBICIHPCE, NativeArray<T> FFEMKICJPKP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3968460", Offset = "0x3967260", VA = "0x183968460")]
	[NENPGMJIAPO]
	public static JobHandle KOLILBNFMNI<T>(this EntityCommandBufferSystem IBKADNGKJHI, NativeArrayAsync<Entity> KKDBICIHPCE, NativeArrayAsync<T> FFEMKICJPKP, [Optional] JobHandle BMHAFJILJPP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39685E0", Offset = "0x39673E0", VA = "0x1839685E0")]
	[NENPGMJIAPO]
	public static JobHandle KOLILBNFMNI<T>(this EntityCommandBufferSystem IBKADNGKJHI, NativeArray<Entity> KKDBICIHPCE, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F588E0", Offset = "0x7F576E0", VA = "0x187F588E0")]
	[NENPGMJIAPO]
	public static JobHandle KOLILBNFMNI(this EntityCommandBufferSystem IBKADNGKJHI, NativeArray<Entity> KKDBICIHPCE, ComponentTypes CJNKCIJAONA, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F58A50", Offset = "0x7F57850", VA = "0x187F58A50")]
	[NENPGMJIAPO]
	public static JobHandle KOLILBNFMNI(this EntityCommandBufferSystem IBKADNGKJHI, EntityCommandBuffer KGEALJMNJLG, NativeArray<Entity> KKDBICIHPCE, ComponentTypes CJNKCIJAONA, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JBAOBPDKAGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BHPMJHEDBMO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F580D0", Offset = "0x7F56ED0", VA = "0x187F580D0")]
	[NENPGMJIAPO]
	public static JobHandle BAJBHDIBKIE(this EntityCommandBufferSystem IBKADNGKJHI, NativeList<Entity> KKDBICIHPCE, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F58260", Offset = "0x7F57060", VA = "0x187F58260")]
	[NENPGMJIAPO]
	public static JobHandle BAJBHDIBKIE(this EntityCommandBufferSystem IBKADNGKJHI, NativeArrayAsync<Entity> KKDBICIHPCE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BCAICIKBBPE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3696680", Offset = "0x3695480", VA = "0x183696680")]
	public static void CNMIBMOFNPN<T>(this EntityCommandBufferSystem IBKADNGKJHI, EntityQuery LPMNLGHDNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x36968C0", Offset = "0x36956C0", VA = "0x1836968C0")]
	[NENPGMJIAPO]
	public static JobHandle PNLANPABBEA<T>(this EntityCommandBufferSystem IBKADNGKJHI, NativeArrayAsync<Entity> KKDBICIHPCE, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F57EC0", Offset = "0x7F56CC0", VA = "0x187F57EC0")]
	[NENPGMJIAPO]
	public static JobHandle PNLANPABBEA(this EntityCommandBufferSystem IBKADNGKJHI, NativeArrayAsync<Entity> KKDBICIHPCE, ComponentType PGGHOMGDDEG, [Optional] JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FIFFKCHDMHO
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38E7C20", Offset = "0x38E6A20", VA = "0x1838E7C20")]
	[NENPGMJIAPO]
	public static JobHandle PONFJDJEHBG<T>(this EntityCommandBufferSystem IBKADNGKJHI, NativeArray<Entity> KKDBICIHPCE, NativeArray<T> FFEMKICJPKP, JobHandle BMHAFJILJPP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AEMJIFCEJDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class PJKOOBGFFBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BLCHNGJLNLK
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36A1EC0", Offset = "0x36A0CC0", VA = "0x1836A1EC0")]
	public static NativeArray<T> IIANOMJIAJK<T>(this NativeList<Entity> FKOKJEMCHKJ, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36A1CE0", Offset = "0x36A0AE0", VA = "0x1836A1CE0")]
	public static NativeArray<T> IIANOMJIAJK<T>(this NativeArray<Entity> FKOKJEMCHKJ, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F58360", Offset = "0x7F57160", VA = "0x187F58360")]
	public static NativeArray<Entity> ANPAGANDDHD(this NativeArray<Entity> FKOKJEMCHKJ, EntityManager CCPBGAMLKKA, ComponentType PGGHOMGDDEG, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36A1BE0", Offset = "0x36A09E0", VA = "0x1836A1BE0")]
	public static NativeArray<T> AMCFKCHLBGO<T>(this NativeArray<Entity> FKOKJEMCHKJ, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BGHPMBCFNBM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FLDLIMIFAGG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct GNAJEPLMDBD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FLDLIMIFAGG<TFrom> KHJEADFMOJM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct LHILJLMKLGK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct MHGNPMMBCAN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LHILJLMKLGK<TFrom> KHJEADFMOJM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct CFCOLCANCED<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct HCOBAKCKFEL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CFCOLCANCED<TFrom> KHJEADFMOJM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> HGMFLOGEOFF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OJLCICFEECD
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OLCBINPEKBC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HMGDNBNCIHF : JJKIBONBDHP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F587D0", Offset = "0x7F575D0", VA = "0x187F587D0")]
		[BurstCompatible]
		public Entity LJDLCLCJELO([In] Entity OAIIHELJHLG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F587D0", Offset = "0x7F575D0", VA = "0x187F587D0", Slot = "4")]
		private Entity PMGNDBMFODH([In] Entity OAIIHELJHLG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HPLINMCNLOP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HMPCJOLFLHB<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4C54BD0", Offset = "0x4C539D0", VA = "0x184C54BD0", Slot = "4")]
		public int Compare((TKey, TValue) AJEEBBBAOKG, (TKey, TValue) GJPKMHAOJHB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3928FC0", Offset = "0x3927DC0", VA = "0x183928FC0")]
	public static void ABILIENNHFM<TKey, TValue>(NativeList<TKey> NHBOGPIKHLE, NativeList<TValue> BGBLHEHBHCD) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3928DF0", Offset = "0x3927BF0", VA = "0x183928DF0")]
	public static void ABILIENNHFM<TKey, TValue>(NativeArray<TKey> NHBOGPIKHLE, NativeArray<TValue> BGBLHEHBHCD) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3929250", Offset = "0x3928050", VA = "0x183929250")]
	public static void ABILIENNHFM<TKey, TValue, U>(NativeArray<TKey> NHBOGPIKHLE, NativeArray<TValue> BGBLHEHBHCD, U LDLDOEEDEGF) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JLNCHLEPFHP
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct LAPKFMCIDCD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> AHJIALOAFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct OAFKCPPKAJJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> AHJIALOAFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FMLAEEELNBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> AHJIALOAFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> HGMFLOGEOFF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CPNAJHHDNLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KAJMLLOBDBP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct LIEPILIEJGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct OCKDAGBDDEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct FEKAHLELKJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> HGMFLOGEOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct IBGOGHAJLNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator LNMGNHHGHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> HGMFLOGEOFF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MBPJMBGMOEO
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class OHCJPNNMGAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD230", Offset = "0x3AFC030", VA = "0x183AFD230")]
	public static NativeList<Entity> MFJOOPCJELO<T>(this NativeList<Entity> PMJLBGGLKDD, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCBF0", Offset = "0x3AFB9F0", VA = "0x183AFCBF0")]
	public static NativeList<Entity> MFJOOPCJELO<T>(this NativeArray<Entity> PMJLBGGLKDD, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class LABAHDPEAHD
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x39E4B70", Offset = "0x39E3970", VA = "0x1839E4B70")]
	public static NativeList<Entity> JOHJAOEGJJH<T>(this NativeArray<Entity> PMJLBGGLKDD, EntityManager CCPBGAMLKKA, Allocator LNMGNHHGHLL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class CABMANFNIKP
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct AEMBKICPDDF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> KNDCNOIHMGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct PPBMHLIJBFP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> KNDCNOIHMGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct POGOKEELENP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JJKIBONBDHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> KNDCNOIHMGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IABJLPPICBG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JJKIBONBDHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> KNDCNOIHMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector PGOIBKDMIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GLAOLHCPLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DNDGPHHHDNL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JJKIBONBDHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IABJLPPICBG<TSrc, TValue, TSelector> BMMKBOAHBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue KFJIIONEOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int AJOJFAFFHHF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class OCGGIFMFFBN
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct BEOANDCFKIM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> KNDCNOIHMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int AJOJFAFFHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int ANNGBPPNBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T KFJIIONEOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T FIBGKMLONPK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MAINECODIKP JIINJLFJODK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x57B9610", Offset = "0x57B8410", VA = "0x1857B9610")]
			get
			{
				return default(MAINECODIKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T DMDDOEAPLDI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, MAINECODIKP) CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x57B92B0", Offset = "0x57B80B0", VA = "0x1857B92B0")]
			get
			{
				return default((T, MAINECODIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6082B90", Offset = "0x6081990", VA = "0x186082B90")]
		public BEOANDCFKIM(NativeArray<T> KNDCNOIHMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x46C4E20", Offset = "0x46C3C20", VA = "0x1846C4E20")]
		public BEOANDCFKIM<T> PHEMDOOJNPF()
		{
			return default(BEOANDCFKIM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6082990", Offset = "0x6081790", VA = "0x186082990")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FA20", Offset = "0x3A6E820", VA = "0x183A6FA20")]
		public PNLEIILAAKE<T, TComparer> OMEONNLLCNM<TComparer>([Optional] TComparer LDLDOEEDEGF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PNLEIILAAKE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct PNLEIILAAKE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> KNDCNOIHMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int AJOJFAFFHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int ANNGBPPNBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T KFJIIONEOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T FIBGKMLONPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer LDLDOEEDEGF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MAINECODIKP JIINJLFJODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x57B9610", Offset = "0x57B8410", VA = "0x1857B9610")]
			get
			{
				return default(MAINECODIKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T DMDDOEAPLDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, MAINECODIKP range) CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x57B92B0", Offset = "0x57B80B0", VA = "0x1857B92B0")]
			get
			{
				return default((T, MAINECODIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57B9620", Offset = "0x57B8420", VA = "0x1857B9620")]
		public PNLEIILAAKE(NativeArray<T> KNDCNOIHMGO, TComparer LDLDOEEDEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x39E2460", Offset = "0x39E1260", VA = "0x1839E2460")]
		public PNLEIILAAKE<T, TComparer> PHEMDOOJNPF()
		{
			return default(PNLEIILAAKE<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x57B9560", Offset = "0x57B8360", VA = "0x1857B9560")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAB80", Offset = "0x3AF9980", VA = "0x183AFAB80")]
	public static BEOANDCFKIM<T> CJJNJMDMDKA<T>(this NativeArray<T> KNDCNOIHMGO) where T : struct
	{
		return default(BEOANDCFKIM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface DHHOLEBKBDC
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OEBDMPDJLMP
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct HONMCMDJCPD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PNOGEMIGBAJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HONMCMDJCPD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B40580", Offset = "0x4B3F380", VA = "0x184B40580", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public PNOGEMIGBAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57B9F70", Offset = "0x57B8D70", VA = "0x1857B9F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x57BA140", Offset = "0x57B8F40", VA = "0x1857BA140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> PKKDGCBGJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream GGIFBJCPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream CMKJJBLFOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf FCFFBGOAPEH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4C55A40", Offset = "0x4C54840", VA = "0x184C55A40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C55A80", Offset = "0x4C54880", VA = "0x184C55A80", Slot = "4")]
	[IteratorStateMachine(typeof(HONMCMDJCPD<>.PNOGEMIGBAJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C55B80", Offset = "0x4C54980", VA = "0x184C55B80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KDLKEHCOPKA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] GLBDCBGACGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf FCFFBGOAPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream GGIFBJCPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream DIKDHFJGCNG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50A1330", Offset = "0x50A0130", VA = "0x1850A1330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct DPIAPHCCKPI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GGIFBJCPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream CMKJJBLFOOC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F586D0", Offset = "0x7F574D0", VA = "0x187F586D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JLDKNFDNCII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] GLBDCBGACGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream GGIFBJCPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream DIKDHFJGCNG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F58C30", Offset = "0x7F57A30", VA = "0x187F58C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GJEMMNIJIPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class CKNIFKGFFAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum BFFPAPCKFOL
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
internal static class JLINHOJANNM
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
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
