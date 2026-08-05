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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DE0280", Offset = "0x7DDF280", VA = "0x187DE0280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DDFB00", Offset = "0x7DDEB00", VA = "0x187DDFB00")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFKHMNBCONN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JENABNPBLBO AHDIELKOAGO
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
public interface GOIAADDNDJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHBEGDOKMPO(Entity IOGPJKLGKKO, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNCLOEFNKCC(Entity IOGPJKLGKKO, object EJJDDFFADPC, [Out] bool HEPLBKNIHKI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCICPEBGFHH(Entity IOGPJKLGKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GOCLOPMIOBB<TComponentData, TValue> : KAICBDDALGK<TValue>, IDisposable where TComponentData : struct, PFKHMNBCONN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BBIDHNKEFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> OLEDHEBBJPH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int CMIOJAJFIMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x404C6F0", Offset = "0x404B6F0", VA = "0x18404C6F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61A9FB0", Offset = "0x61A8FB0", VA = "0x1861A9FB0")]
		public bool OICPFPJKGPE([Out] TValue OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61A9DD0", Offset = "0x61A8DD0", VA = "0x1861A9DD0")]
		public void IIGLPCDPOEE(object EJJDDFFADPC, TValue OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61A9D10", Offset = "0x61A8D10", VA = "0x1861A9D10")]
		public bool GNAALOCCJEL(object EJJDDFFADPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61A9EC0", Offset = "0x61A8EC0", VA = "0x1861A9EC0")]
		public int KBEMGMDGBFE(object EJJDDFFADPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61AA0C0", Offset = "0x61A90C0", VA = "0x1861AA0C0")]
		public BBIDHNKEFCO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<BBIDHNKEFCO> BENFKMBJNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KEAENKDOBJK<JENABNPBLBO, BBIDHNKEFCO> GONJGHOBPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager IPJDHIAOJKP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A955C0", Offset = "0x4A945C0", VA = "0x184A955C0")]
	public GOCLOPMIOBB(EntityManager IPJDHIAOJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A95140", Offset = "0x4A94140", VA = "0x184A95140", Slot = "4")]
	public void JHBEGDOKMPO(Entity IOGPJKLGKKO, object EJJDDFFADPC, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A94F40", Offset = "0x4A93F40", VA = "0x184A94F40", Slot = "5")]
	public bool FNCLOEFNKCC(Entity IOGPJKLGKKO, object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A95490", Offset = "0x4A94490", VA = "0x184A95490", Slot = "6")]
	public bool OICPFPJKGPE(Entity IOGPJKLGKKO, [Out] TValue OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A94F20", Offset = "0x4A93F20", VA = "0x184A94F20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A952C0", Offset = "0x4A942C0", VA = "0x184A952C0")]
	private void KOABLCLJDII(BBIDHNKEFCO HPEDPOCNGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A94D20", Offset = "0x4A93D20", VA = "0x184A94D20")]
	private bool AONHNDABPNH(Entity IOGPJKLGKKO, [Out] JENABNPBLBO BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A95390", Offset = "0x4A94390", VA = "0x184A95390")]
	private void OFLMEHLFCFD(Entity IOGPJKLGKKO, JENABNPBLBO BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A955A0", Offset = "0x4A945A0", VA = "0x184A955A0")]
	private bool PMKFBOPONBB(JENABNPBLBO BOJCEMEJOMP, [Out] BBIDHNKEFCO HPEDPOCNGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A94DF0", Offset = "0x4A93DF0", VA = "0x184A94DF0")]
	private BBIDHNKEFCO BBKNLLJGFLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KAICBDDALGK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHBEGDOKMPO(Entity IOGPJKLGKKO, object EJJDDFFADPC, TValue OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNCLOEFNKCC(Entity IOGPJKLGKKO, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OICPFPJKGPE(Entity IOGPJKLGKKO, [Out] TValue OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JENABNPBLBO : PMKOIOKBFCO, IEquatable<JENABNPBLBO>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JENABNPBLBO CABIBLEKJPN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB70", Offset = "0x7DDEB70", VA = "0x187DDFB70", Slot = "8")]
	public bool Equals(JENABNPBLBO MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFBC0", Offset = "0x7DDEBC0", VA = "0x187DDFBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JAIBEMLOEHE<THasTokensTag> : GOIAADDNDJK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, JENABNPBLBO> CAHEADKAFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> BENFKMBJNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KEAENKDOBJK<JENABNPBLBO, HashSet<object>> GONJGHOBPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager IPJDHIAOJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem BMFKKHIJGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F330", Offset = "0x4E1E330", VA = "0x184E1F330")]
	public JAIBEMLOEHE(EntityManager IPJDHIAOJKP, EntityCommandBufferSystem BMFKKHIJGPI, JBBHIJHGEPM JEOHPCBHDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D4E0", Offset = "0x4E1C4E0", VA = "0x184E1D4E0", Slot = "4")]
	public bool JHBEGDOKMPO(Entity IOGPJKLGKKO, object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D2E0", Offset = "0x4E1C2E0", VA = "0x184E1D2E0", Slot = "5")]
	public bool FNCLOEFNKCC(Entity IOGPJKLGKKO, object EJJDDFFADPC, [Out] bool HEPLBKNIHKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E9A0", Offset = "0x4E1D9A0", VA = "0x184E1E9A0", Slot = "6")]
	public bool PCICPEBGFHH(Entity IOGPJKLGKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E8E0", Offset = "0x4E1D8E0", VA = "0x184E1E8E0", Slot = "8")]
	public bool PCICPEBGFHH(JENABNPBLBO BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E1CC20", Offset = "0x4E1BC20", VA = "0x184E1CC20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DCD0", Offset = "0x4E1CCD0", VA = "0x184E1DCD0")]
	private void KOABLCLJDII(HashSet<object> HPEDPOCNGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1C320", Offset = "0x4E1B320", VA = "0x184E1C320")]
	private bool AONHNDABPNH(Entity IOGPJKLGKKO, [Out] JENABNPBLBO BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1C8E0", Offset = "0x4E1B8E0", VA = "0x184E1C8E0")]
	private bool CPJPGPFHAPG(Entity IOGPJKLGKKO, [Out] JENABNPBLBO BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E0A0", Offset = "0x4E1D0A0", VA = "0x184E1E0A0")]
	private void MJOONBHNGEG(Entity IOGPJKLGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EBD0", Offset = "0x4E1DBD0", VA = "0x184E1EBD0")]
	private void PCLKGJPJPIN(Entity IOGPJKLGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E000", Offset = "0x4E1D000", VA = "0x184E1E000")]
	private void LFLCAEJLAPO(Entity IOGPJKLGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E550", Offset = "0x4E1D550", VA = "0x184E1E550")]
	private void OFLMEHLFCFD(Entity IOGPJKLGKKO, JENABNPBLBO BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E6A0", Offset = "0x4E1D6A0", VA = "0x184E1E6A0")]
	private bool OJIEHEBFAGC(JENABNPBLBO BOJCEMEJOMP, [Out] HashSet<object> HPEDPOCNGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E1C7A0", Offset = "0x4E1B7A0", VA = "0x184E1C7A0")]
	private HashSet<object> BBKNLLJGFLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AGPLNHCEAIF
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HIOGIOFGCKF : HKDBADCNAGJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB50", Offset = "0x7DDEB50", VA = "0x187DDFB50")]
	public float LLJPNEEKOIC([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB50", Offset = "0x7DDEB50", VA = "0x187DDFB50", Slot = "4")]
	private float AFJKJPKIEAL([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IOBKLJILHKN : HKDBADCNAGJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB60", Offset = "0x7DDEB60", VA = "0x187DDFB60")]
	public float LLJPNEEKOIC([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB60", Offset = "0x7DDEB60", VA = "0x187DDFB60", Slot = "4")]
	private float AFJKJPKIEAL([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IFLIMAJKMNO : HKDBADCNAGJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xE4AAC0", Offset = "0xE49AC0", VA = "0x180E4AAC0")]
	public float LLJPNEEKOIC([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE4AAC0", Offset = "0xE49AC0", VA = "0x180E4AAC0", Slot = "4")]
	private float AFJKJPKIEAL([In] float3 OHLIHBDBKCE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PIHLDOJNLKK : HKDBADCNAGJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2159BE0", Offset = "0x2158BE0", VA = "0x182159BE0")]
	public int LLJPNEEKOIC([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2159BE0", Offset = "0x2158BE0", VA = "0x182159BE0", Slot = "4")]
	private int HKACDNMFLLL([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EJNCGALOIEG : HKDBADCNAGJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEE0BD0", Offset = "0xEDFBD0", VA = "0x180EE0BD0")]
	public int LLJPNEEKOIC([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xEE0BD0", Offset = "0xEDFBD0", VA = "0x180EE0BD0", Slot = "4")]
	private int HKACDNMFLLL([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AFAJLAFIHIB : HKDBADCNAGJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xE30170", Offset = "0xE2F170", VA = "0x180E30170")]
	public int LLJPNEEKOIC([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE30170", Offset = "0xE2F170", VA = "0x180E30170", Slot = "4")]
	private int HKACDNMFLLL([In] int3 OHLIHBDBKCE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPALNLLHJBE : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2051A20", Offset = "0x2050A20", VA = "0x182051A20")]
	public DPALNLLHJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DPKKALIBIFL : SystemBase, IHHMJEKDJJH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF5B0", Offset = "0x7DDE5B0", VA = "0x187DDF5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36B7720", Offset = "0x36B6720", VA = "0x1836B7720")]
	public void GOAPECKKBBG<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36B7720", Offset = "0x36B6720", VA = "0x1836B7720")]
	public void GICABAIBNAP<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF540", Offset = "0x7DDE540", VA = "0x187DDF540")]
	public JobHandle HGOCEIOOHMJ(ReadOnlySpan<int> FICLDECPCIC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36B7670", Offset = "0x36B6670", VA = "0x1836B7670")]
	public JobHandle DJEDNPABKEE<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF420", Offset = "0x7DDE420", VA = "0x187DDF420")]
	public JobHandle DJEDNPABKEE(ReadOnlySpan<int> FICLDECPCIC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36B7780", Offset = "0x36B6780", VA = "0x1836B7780")]
	public void NONPDAICBBJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36B7B80", Offset = "0x36B6B80", VA = "0x1836B7B80")]
	public JobHandle NONPDAICBBJ<T>(JobHandle BOJCEMEJOMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF5E0", Offset = "0x7DDE5E0", VA = "0x187DDF5E0")]
	public JobHandle NONPDAICBBJ(ReadOnlySpan<int> FICLDECPCIC, JobHandle BOJCEMEJOMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36B7780", Offset = "0x36B6780", VA = "0x1836B7780")]
	public void GPLIHJLFIAL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36B7810", Offset = "0x36B6810", VA = "0x1836B7810")]
	public JobHandle GPLIHJLFIAL<T>(JobHandle BOJCEMEJOMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF4D0", Offset = "0x7DDE4D0", VA = "0x187DDF4D0")]
	public JobHandle GPLIHJLFIAL(Span<int> FICLDECPCIC, JobHandle BOJCEMEJOMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36B75A0", Offset = "0x36B65A0", VA = "0x1836B75A0")]
	public ComponentDataFromEntity BJKMBBHBJBI<T>(bool IBIHDDIPMBP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF360", Offset = "0x7DDE360", VA = "0x187DDF360")]
	public ComponentDataFromEntity BJKMBBHBJBI(int IKGHDBJPNHK, bool IBIHDDIPMBP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36B7AB0", Offset = "0x36B6AB0", VA = "0x1836B7AB0")]
	public SharedComponentIndexFromEntity<T> KNGKEGDJJAJ<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF470", Offset = "0x7DDE470", VA = "0x187DDF470")]
	[BurstCompatible]
	public ComponentTypeHandle FKENEMOKOFO(ComponentType HIOBPDDMMMD)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF590", Offset = "0x7DDE590", VA = "0x187DDF590")]
	public EntityExistenceLookupByEntity ILMCIFHFADI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF650", Offset = "0x7DDE650", VA = "0x187DDF650", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36B8440", Offset = "0x36B7440", VA = "0x1836B8440")]
	public bool OJINOMMGMNI<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2051A20", Offset = "0x2050A20", VA = "0x182051A20")]
	protected DPKKALIBIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GAAMLBNFJHF : DPKKALIBIFL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB20", Offset = "0x7DDEB20", VA = "0x187DDFB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2051A20", Offset = "0x2050A20", VA = "0x182051A20")]
	protected GAAMLBNFJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IMMMBOELFCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NDJLGFAPJBA : EntityCommandBufferSystem, IHHMJEKDJJH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JBBHIJHGEPM AHIMDJPCPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD62EE0", Offset = "0xD61EE0", VA = "0x180D62EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0240", Offset = "0x7DDF240", VA = "0x187DE0240")]
	public NDJLGFAPJBA(JBBHIJHGEPM PAJIGEJCNAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HKDBADCNAGJ<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LLJPNEEKOIC([In] TFrom OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EMCFKHEPHHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANAFBLDDCKA(T OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JHEJHBFPJDO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes BIMMMOPIEEG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC10", Offset = "0x7DDEC10", VA = "0x187DDFC10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OELPLHAOMDO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0390", Offset = "0x7DDF390", VA = "0x187DE0390", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct OEPAEMHFGEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType HIOBPDDMMMD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0430", Offset = "0x7DDF430", VA = "0x187DE0430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct OCGOKLCNAMO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x550C840", Offset = "0x550B840", VA = "0x18550C840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct HACNHJJBPBJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> DHLGAIMCINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct DJBHGICEBAD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OHLIHBDBKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer PCKOLNJHLPC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct CKBMPALPFME<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HKDBADCNAGJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> NNADICJAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct BMCHHAEKJOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity CPFCNBJIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> NNADICJAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PKOFFICDNCK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF220", Offset = "0x7DDE220", VA = "0x187DDF220", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PAJGDIEHPNK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NMIOIFMAMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> GBOMFAONDGJ;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct EMMBOMJLDFN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HKDBADCNAGJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> CFNAHJOGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> NNADICJAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct DFMOEPLLBBJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KGMNFBPHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> KFAFEFNBIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> AEKJBMCPKCD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct GKHLCKFAKHC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KGMNFBPHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> KFAFEFNBIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> AEKJBMCPKCD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4A898F0", Offset = "0x4A888F0", VA = "0x184A898F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HKHJNADDJAJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> GBOMFAONDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> NJGJLJFIMHO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4B003F0", Offset = "0x4AFF3F0", VA = "0x184B003F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct EHEKCMPNBOM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HKDBADCNAGJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> GBOMFAONDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> NJGJLJFIMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JFDLOJEDEOA<T, TPredicate> : IJob where T : struct where TPredicate : struct, EMCFKHEPHHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> GJDMFKLHHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> CPHFEPJCJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct AOLCMLHNBIJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, EMCFKHEPHHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> HGEFOAGAHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> GBOMFAONDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ANEIMBLNHIA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity KGMNFBPHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> KFAFEFNBIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> BHDNMDBLCLD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF190", Offset = "0x7DDE190", VA = "0x187DDF190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct ODAACLDMBAB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity KGMNFBPHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> KFAFEFNBIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> BHDNMDBLCLD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0300", Offset = "0x7DDF300", VA = "0x187DE0300", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LGNBJPIMEJI
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HKJEPFKFFOI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3869EC0", Offset = "0x3868EC0", VA = "0x183869EC0")]
	public static bool PDOCOGJJEBI<T>(this NativeArray<Entity> KFAFEFNBIOF, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PJPBEILPICG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ONMDCKBEHJA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public ONMDCKBEHJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EEFHGMJKGEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public EEFHGMJKGEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> HGIJOKGPMEJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE04B0", Offset = "0x7DDF4B0", VA = "0x187DE04B0")]
	public PJPBEILPICG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LEBBJCOHLBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BLFAINDOJCA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EPHMHEEMLNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct NKFFJJHPAFG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal EPHMHEEMLNJ<TFrom> JHDAOHEONAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> KIDPOMGFMKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NKNJJFNPAIN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct GEFIPKGHNJC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NKNJJFNPAIN<TFrom> JHDAOHEONAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> KIDPOMGFMKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct JINDDFILCIB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct CMPMDFDFOIO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal JINDDFILCIB<TFrom> JHDAOHEONAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> KIDPOMGFMKB;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct BECAJPJIJEH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct HLFJBCGDLNP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal BECAJPJIJEH<TFrom> JHDAOHEONAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> KIDPOMGFMKB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AALMHDNAKPG
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NJDAOFLECHB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3991550", Offset = "0x3990550", VA = "0x183991550")]
	public static NativeList<T> OACCBDLNELK<T>(this NativeArray<T> GNKPENKMHAG, Allocator NDFENJBGNOB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KEDKJIMBBCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EDOMOPEFNBN
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x36DC840", Offset = "0x36DB840", VA = "0x1836DC840")]
	[EJGKMEKIBDJ]
	public static JobHandle PAFDKPIOHJH<T>(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArray<Entity> ANKLKPHHPBD, NativeArray<T> APDBNIMCPID) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36DC410", Offset = "0x36DB410", VA = "0x1836DC410")]
	[EJGKMEKIBDJ]
	public static JobHandle PAFDKPIOHJH<T>(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArrayAsync<Entity> ANKLKPHHPBD, NativeArrayAsync<T> APDBNIMCPID, [Optional] JobHandle KKBIELNOEEO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x36DC590", Offset = "0x36DB590", VA = "0x1836DC590")]
	[EJGKMEKIBDJ]
	public static JobHandle PAFDKPIOHJH<T>(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArray<Entity> ANKLKPHHPBD, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF840", Offset = "0x7DDE840", VA = "0x187DDF840")]
	[EJGKMEKIBDJ]
	public static JobHandle PAFDKPIOHJH(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArray<Entity> ANKLKPHHPBD, ComponentTypes BIMMMOPIEEG, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF9B0", Offset = "0x7DDE9B0", VA = "0x187DDF9B0")]
	[EJGKMEKIBDJ]
	public static JobHandle PAFDKPIOHJH(this EntityCommandBufferSystem BMFKKHIJGPI, EntityCommandBuffer PCKOLNJHLPC, NativeArray<Entity> ANKLKPHHPBD, ComponentTypes BIMMMOPIEEG, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AJKKDBBNBDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LDEOLBHPFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFF90", Offset = "0x7DDEF90", VA = "0x187DDFF90")]
	[EJGKMEKIBDJ]
	public static JobHandle BJMBBDNDDMF(this EntityCommandBufferSystem BMFKKHIJGPI, NativeList<Entity> ANKLKPHHPBD, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFE90", Offset = "0x7DDEE90", VA = "0x187DDFE90")]
	[EJGKMEKIBDJ]
	public static JobHandle BJMBBDNDDMF(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArrayAsync<Entity> ANKLKPHHPBD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KAKFHJIABAA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x38D5F70", Offset = "0x38D4F70", VA = "0x1838D5F70")]
	[EJGKMEKIBDJ]
	public static JobHandle BBEAMEEKJJD<T>(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArrayAsync<Entity> ANKLKPHHPBD, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFD00", Offset = "0x7DDED00", VA = "0x187DDFD00")]
	[EJGKMEKIBDJ]
	public static JobHandle BBEAMEEKJJD(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArrayAsync<Entity> ANKLKPHHPBD, ComponentType HIOBPDDMMMD, [Optional] JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PPGMFAAJIMO
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39F68D0", Offset = "0x39F58D0", VA = "0x1839F68D0")]
	[EJGKMEKIBDJ]
	public static JobHandle LDIFBLAGDKO<T>(this EntityCommandBufferSystem BMFKKHIJGPI, NativeArray<Entity> ANKLKPHHPBD, NativeArray<T> APDBNIMCPID, JobHandle KKBIELNOEEO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PLKGOLMHPLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BPGOJGJFLBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DPLMKAHLOHE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36B8A20", Offset = "0x36B7A20", VA = "0x1836B8A20")]
	public static NativeArray<T> OHHLDENNLGK<T>(this NativeList<Entity> GNKPENKMHAG, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36B8660", Offset = "0x36B7660", VA = "0x1836B8660")]
	public static NativeArray<T> OHHLDENNLGK<T>(this NativeArray<Entity> GNKPENKMHAG, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF660", Offset = "0x7DDE660", VA = "0x187DDF660")]
	public static NativeArray<Entity> JHCDNJAEHJP(this NativeArray<Entity> GNKPENKMHAG, EntityManager IPJDHIAOJKP, ComponentType HIOBPDDMMMD, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36B8560", Offset = "0x36B7560", VA = "0x1836B8560")]
	public static NativeArray<T> FANKCJKALCM<T>(this NativeArray<Entity> GNKPENKMHAG, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DLALBFDPJLE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PCAGOPCCEGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct JJCOOFOLAGN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PCAGOPCCEGL<TFrom> KIDPOMGFMKB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BNKIDIIILID<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LDGLHDKFPCN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public BNKIDIIILID<TFrom> KIDPOMGFMKB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct KGPLFJJDCAL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct JEMFGPPJPDB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public KGPLFJJDCAL<TFrom> KIDPOMGFMKB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> HGEFOAGAHDF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CMNNIHMCGOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CMGHLFGHBGE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NHAHMMHDOIE : HKDBADCNAGJ<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0270", Offset = "0x7DDF270", VA = "0x187DE0270")]
		[BurstCompatible]
		public Entity LLJPNEEKOIC([In] Entity OHLIHBDBKCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0270", Offset = "0x7DDF270", VA = "0x187DE0270", Slot = "4")]
		private Entity ACKBGBOONDE([In] Entity OHLIHBDBKCE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HPDKIFKIFPP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HANJOIKCJPL<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4AC6190", Offset = "0x4AC5190", VA = "0x184AC6190", Slot = "4")]
		public int Compare((TKey, TValue) CEJAAIDLEPA, (TKey, TValue) IMNDAJIDDFG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x386EA80", Offset = "0x386DA80", VA = "0x18386EA80")]
	public static void EGGGPIHMFEO<TKey, TValue>(NativeList<TKey> AAMIOMCJGPE, NativeList<TValue> DHLGAIMCINE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x386EF50", Offset = "0x386DF50", VA = "0x18386EF50")]
	public static void EGGGPIHMFEO<TKey, TValue>(NativeArray<TKey> AAMIOMCJGPE, NativeArray<TValue> DHLGAIMCINE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x386ED10", Offset = "0x386DD10", VA = "0x18386ED10")]
	public static void EGGGPIHMFEO<TKey, TValue, U>(NativeArray<TKey> AAMIOMCJGPE, NativeArray<TValue> DHLGAIMCINE, U EHPBBCAOLKB) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HFAAGPBNJCH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct KFHCLIMKALA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> GJDMFKLHHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct PANBHGJJJKD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> GJDMFKLHHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct MNDDKAGNBAO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> GJDMFKLHHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> HGEFOAGAHDF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FFIKPMCPKBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CFJNHHPBOCO
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct OHLMICJMNPM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct JFDNONNPEHB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NMGJHBAGAJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> HGEFOAGAHDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct LHILAFJECMD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator NDFENJBGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> HGEFOAGAHDF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class GICJAKBPENB
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class ECGHJCGBDME
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36D8760", Offset = "0x36D7760", VA = "0x1836D8760")]
	public static NativeList<Entity> FILGPOHJGBL<T>(this NativeList<Entity> KFAFEFNBIOF, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36D7F90", Offset = "0x36D6F90", VA = "0x1836D7F90")]
	public static NativeList<Entity> FILGPOHJGBL<T>(this NativeArray<Entity> KFAFEFNBIOF, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class ODAECADLBFG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39CC8E0", Offset = "0x39CB8E0", VA = "0x1839CC8E0")]
	public static NativeList<Entity> LMELPKDCPCF<T>(this NativeArray<Entity> KFAFEFNBIOF, EntityManager IPJDHIAOJKP, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class IJNBGNBPDEP
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct CEJHBOFKGPG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> NBBLCIBNPBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct PEMFLNKDJIF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> NBBLCIBNPBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct AMJOLOOGMCH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HKDBADCNAGJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> NBBLCIBNPBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct MINJMIKGELB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HKDBADCNAGJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> NBBLCIBNPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector DEFCAGCPBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int OHHMJGCBCKD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LFLEFIAOODG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HKDBADCNAGJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private MINJMIKGELB<TSrc, TValue, TSelector> FMKNFJBKBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue NKDJLDMEBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NGFMNKONPKM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FCEDFELFCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct JOJDCCOAMJD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> NBBLCIBNPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int NGFMNKONPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int GKOBPNMJCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T NKDJLDMEBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T BMNLDNDHEDF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EIOEEPICKHB JIEKKHMBKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4E7C250", Offset = "0x4E7B250", VA = "0x184E7C250")]
			get
			{
				return default(EIOEEPICKHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T FIFCKOPHNCL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, EIOEEPICKHB) FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4E7C260", Offset = "0x4E7B260", VA = "0x184E7C260")]
			get
			{
				return default((T, EIOEEPICKHB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C960", Offset = "0x4E7B960", VA = "0x184E7C960")]
		public JOJDCCOAMJD(NativeArray<T> NBBLCIBNPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x459AEB0", Offset = "0x4599EB0", VA = "0x18459AEB0")]
		public JOJDCCOAMJD<T> OMLAPONJPHN()
		{
			return default(JOJDCCOAMJD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4E7C510", Offset = "0x4E7B510", VA = "0x184E7C510")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD5C0", Offset = "0x3CBC5C0", VA = "0x183CBD5C0")]
		public MBFFGAILBFJ<T, TComparer> BGGEJPHADMG<TComparer>([Optional] TComparer EHPBBCAOLKB) where TComparer : struct, IEqualityComparer<T>
		{
			return default(MBFFGAILBFJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct MBFFGAILBFJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> NBBLCIBNPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int NGFMNKONPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int GKOBPNMJCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T NKDJLDMEBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T BMNLDNDHEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer EHPBBCAOLKB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EIOEEPICKHB JIEKKHMBKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4E7C250", Offset = "0x4E7B250", VA = "0x184E7C250")]
			get
			{
				return default(EIOEEPICKHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T FIFCKOPHNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, EIOEEPICKHB range) FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4E7C260", Offset = "0x4E7B260", VA = "0x184E7C260")]
			get
			{
				return default((T, EIOEEPICKHB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5305D70", Offset = "0x5304D70", VA = "0x185305D70")]
		public MBFFGAILBFJ(NativeArray<T> NBBLCIBNPBK, TComparer EHPBBCAOLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3924F40", Offset = "0x3923F40", VA = "0x183924F40")]
		public MBFFGAILBFJ<T, TComparer> OMLAPONJPHN()
		{
			return default(MBFFGAILBFJ<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5305C60", Offset = "0x5304C60", VA = "0x185305C60")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3839540", Offset = "0x3838540", VA = "0x183839540")]
	public static JOJDCCOAMJD<T> MKPOKJHDJKH<T>(this NativeArray<T> NBBLCIBNPBK) where T : struct
	{
		return default(JOJDCCOAMJD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GIFMMGGGIHC
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class FMGNBLBDAIB
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct NONCBHGMCKP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AANPJIILNDD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NONCBHGMCKP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x49E9AD0", Offset = "0x49E8AD0", VA = "0x1849E9AD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public AANPJIILNDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4A15FD0", Offset = "0x4A14FD0", VA = "0x184A15FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A161B0", Offset = "0x4A151B0", VA = "0x184A161B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> MPBCIOBHCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream NLPKMHEBOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream OBMKEKJMPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf OHDGCHLKIKP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53FF990", Offset = "0x53FE990", VA = "0x1853FF990", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53FF9D0", Offset = "0x53FE9D0", VA = "0x1853FF9D0", Slot = "4")]
	[IteratorStateMachine(typeof(NONCBHGMCKP<>.AANPJIILNDD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53FFAD0", Offset = "0x53FEAD0", VA = "0x1853FFAD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct DLBODOHGFGM<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] IIGKBHIENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf OHDGCHLKIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream NLPKMHEBOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream AGFMELDDPJA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A65A80", Offset = "0x6A64A80", VA = "0x186A65A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct DOEBHHEHNFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream NLPKMHEBOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream OBMKEKJMPAN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF320", Offset = "0x7DDE320", VA = "0x187DDF320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MGBKKJDLFKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] IIGKBHIENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream NLPKMHEBOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream AGFMELDDPJA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0120", Offset = "0x7DDF120", VA = "0x187DE0120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LLHHMDOAMDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BJHMFNJAKOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum NBGEOEAOJON
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
internal static class MPEBIHBCKAB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPHBBBBMJHN()
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
