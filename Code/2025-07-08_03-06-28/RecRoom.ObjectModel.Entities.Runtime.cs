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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x827F6A0", Offset = "0x827E4A0", VA = "0x18827F6A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x827E8F0", Offset = "0x827D6F0", VA = "0x18827E8F0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KBOPFIBNPBI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FMAJPJOEDGP OIOBNMGLBMJ
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
public interface PLICPFPANBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AACONNKAAEK(Entity ALBBAEBLONH, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFGJLNDEDCL(Entity ALBBAEBLONH, object OCGDLEBGIMO, [Out] bool PFNCOJIJKIP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDDBOJMIPKP(Entity ALBBAEBLONH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NGGDIBCACOJ<TComponentData, TValue> : ACKAFOOKLOM<TValue>, IDisposable where TComponentData : struct, KBOPFIBNPBI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class CFNPFKIAPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> ECEBLBALENP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int OOJPJFMJCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x43AC800", Offset = "0x43AB600", VA = "0x1843AC800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6712CC0", Offset = "0x6711AC0", VA = "0x186712CC0")]
		public bool LNLJGFIAJHI([Out] TValue BNECONOIKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6712DB0", Offset = "0x6711BB0", VA = "0x186712DB0")]
		public void OLHPIGGMIDE(object OCGDLEBGIMO, TValue BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6712B60", Offset = "0x6711960", VA = "0x186712B60")]
		public bool EBNLHEFHMEO(object OCGDLEBGIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6712BE0", Offset = "0x67119E0", VA = "0x186712BE0")]
		public int GEOKHIPDOII(object OCGDLEBGIMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6712E60", Offset = "0x6711C60", VA = "0x186712E60")]
		public CFNPFKIAPIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<CFNPFKIAPIF> HNHHABOHKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IAJAGBHBKMA<FMAJPJOEDGP, CFNPFKIAPIF> BJEBFFGKMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager BIBOOAGIPAC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56E2420", Offset = "0x56E1220", VA = "0x1856E2420")]
	public NGGDIBCACOJ(EntityManager BIBOOAGIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x56E1CD0", Offset = "0x56E0AD0", VA = "0x1856E1CD0", Slot = "4")]
	public void AACONNKAAEK(Entity ALBBAEBLONH, object OCGDLEBGIMO, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x56E2030", Offset = "0x56E0E30", VA = "0x1856E2030", Slot = "5")]
	public bool JFGJLNDEDCL(Entity ALBBAEBLONH, object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x56E21D0", Offset = "0x56E0FD0", VA = "0x1856E21D0", Slot = "6")]
	public bool LNLJGFIAJHI(Entity ALBBAEBLONH, [Out] TValue BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x56E1F20", Offset = "0x56E0D20", VA = "0x1856E1F20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x56E22D0", Offset = "0x56E10D0", VA = "0x1856E22D0")]
	private void MGMALKEBCMA(CFNPFKIAPIF INMMDJEIOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x56E2360", Offset = "0x56E1160", VA = "0x1856E2360")]
	private bool NABHOJOMFIP(Entity ALBBAEBLONH, [Out] FMAJPJOEDGP DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x56E1F40", Offset = "0x56E0D40", VA = "0x1856E1F40")]
	private void HAKGHMICAEG(Entity ALBBAEBLONH, FMAJPJOEDGP DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x56E1E10", Offset = "0x56E0C10", VA = "0x1856E1E10")]
	private bool AKEKHAKPBMJ(FMAJPJOEDGP DADONNGONOC, [Out] CFNPFKIAPIF INMMDJEIOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x56E1E30", Offset = "0x56E0C30", VA = "0x1856E1E30")]
	private CFNPFKIAPIF DMJCLMKNOML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ACKAFOOKLOM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AACONNKAAEK(Entity ALBBAEBLONH, object OCGDLEBGIMO, TValue BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFGJLNDEDCL(Entity ALBBAEBLONH, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNLJGFIAJHI(Entity ALBBAEBLONH, [Out] TValue BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FMAJPJOEDGP : FOLAMDMFEJK, IEquatable<FMAJPJOEDGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly FMAJPJOEDGP POJIIGPHFHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CALPLMDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x827EAD0", Offset = "0x827D8D0", VA = "0x18827EAD0", Slot = "8")]
	public bool Equals(FMAJPJOEDGP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x827EB20", Offset = "0x827D920", VA = "0x18827EB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DEGPIBPODAP<THasTokensTag> : PLICPFPANBA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, FMAJPJOEDGP> BNCGGPILAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> HNHHABOHKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IAJAGBHBKMA<FMAJPJOEDGP, HashSet<object>> BJEBFFGKMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager BIBOOAGIPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem LILMAMMDCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7790", Offset = "0x6DD6590", VA = "0x186DD7790")]
	public DEGPIBPODAP(EntityManager BIBOOAGIPAC, EntityCommandBufferSystem LILMAMMDCBG, PHLHEDGDBJO KFGHBBBIJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5280", Offset = "0x6DD4080", VA = "0x186DD5280", Slot = "4")]
	public bool AACONNKAAEK(Entity ALBBAEBLONH, object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6790", Offset = "0x6DD5590", VA = "0x186DD6790", Slot = "5")]
	public bool JFGJLNDEDCL(Entity ALBBAEBLONH, object OCGDLEBGIMO, [Out] bool PFNCOJIJKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5870", Offset = "0x6DD4670", VA = "0x186DD5870", Slot = "6")]
	public bool BDDBOJMIPKP(Entity ALBBAEBLONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5900", Offset = "0x6DD4700", VA = "0x186DD5900", Slot = "8")]
	public bool BDDBOJMIPKP(FMAJPJOEDGP DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6210", Offset = "0x6DD5010", VA = "0x186DD6210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD73E0", Offset = "0x6DD61E0", VA = "0x186DD73E0")]
	private void MGMALKEBCMA(HashSet<object> INMMDJEIOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7520", Offset = "0x6DD6320", VA = "0x186DD7520")]
	private bool NABHOJOMFIP(Entity ALBBAEBLONH, [Out] FMAJPJOEDGP DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6550", Offset = "0x6DD5350", VA = "0x186DD6550")]
	private bool HDFAKNPFFAG(Entity ALBBAEBLONH, [Out] FMAJPJOEDGP DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6F60", Offset = "0x6DD5D60", VA = "0x186DD6F60")]
	private void KMELLFNCAKM(Entity ALBBAEBLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5D30", Offset = "0x6DD4B30", VA = "0x186DD5D30")]
	private void BEHHJGHNHMO(Entity ALBBAEBLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5740", Offset = "0x6DD4540", VA = "0x186DD5740")]
	private void AHPPMBBMPMF(Entity ALBBAEBLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DD63B0", Offset = "0x6DD51B0", VA = "0x186DD63B0")]
	private void HAKGHMICAEG(Entity ALBBAEBLONH, FMAJPJOEDGP DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4DC0", Offset = "0x6DD3BC0", VA = "0x186DD4DC0")]
	private bool AACEBHCBIBB(FMAJPJOEDGP DADONNGONOC, [Out] HashSet<object> INMMDJEIOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6090", Offset = "0x6DD4E90", VA = "0x186DD6090")]
	private HashSet<object> DMJCLMKNOML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JJKKPIHLKEJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct COBDIHPDCGG : JHPFIIJKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x827E8E0", Offset = "0x827D6E0", VA = "0x18827E8E0")]
	public float BJJHFEJKNPC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x827E8E0", Offset = "0x827D6E0", VA = "0x18827E8E0", Slot = "4")]
	private float EEECHIGOPAC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NLGICAIJCKP : JHPFIIJKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x827F690", Offset = "0x827E490", VA = "0x18827F690")]
	public float BJJHFEJKNPC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x827F690", Offset = "0x827E490", VA = "0x18827F690", Slot = "4")]
	private float EEECHIGOPAC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OFHLJLHMONP : JHPFIIJKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xFAE690", Offset = "0xFAD490", VA = "0x180FAE690")]
	public float BJJHFEJKNPC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xFAE690", Offset = "0xFAD490", VA = "0x180FAE690", Slot = "4")]
	private float EEECHIGOPAC([In] float3 BNECONOIKOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BPFNBOODNAM : JHPFIIJKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x23EB140", Offset = "0x23E9F40", VA = "0x1823EB140")]
	public int BJJHFEJKNPC([In] int3 BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23EB140", Offset = "0x23E9F40", VA = "0x1823EB140", Slot = "4")]
	private int IOCLBOOLIJB([In] int3 BNECONOIKOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PBOPFGCNILE : JHPFIIJKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1340A90", Offset = "0x133F890", VA = "0x181340A90")]
	public int BJJHFEJKNPC([In] int3 BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1340A90", Offset = "0x133F890", VA = "0x181340A90", Slot = "4")]
	private int IOCLBOOLIJB([In] int3 BNECONOIKOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GLLFAHJNMLE : JHPFIIJKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF72EB0", Offset = "0xF71CB0", VA = "0x180F72EB0")]
	public int BJJHFEJKNPC([In] int3 BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF72EB0", Offset = "0xF71CB0", VA = "0x180F72EB0", Slot = "4")]
	private int IOCLBOOLIJB([In] int3 BNECONOIKOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJOLOJBBGDB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22D54F0", Offset = "0x22D42F0", VA = "0x1822D54F0")]
	public GJOLOJBBGDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class MMBILNDFKLF : SystemBase, FILMNOODLPG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x827F440", Offset = "0x827E240", VA = "0x18827F440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F4B0", Offset = "0x3C9E2B0", VA = "0x183C9F4B0")]
	public void NGJPOOMILLL<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F4B0", Offset = "0x3C9E2B0", VA = "0x183C9F4B0")]
	public void HELEOKPBMMF<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x827F470", Offset = "0x827E270", VA = "0x18827F470")]
	public JobHandle MEOHMNFKFIM(ReadOnlySpan<int> LMGDJBMGPKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F410", Offset = "0x3C9E210", VA = "0x183C9F410")]
	public JobHandle BGAKGHOEDMM<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x827F260", Offset = "0x827E060", VA = "0x18827F260")]
	public JobHandle BGAKGHOEDMM(ReadOnlySpan<int> LMGDJBMGPKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F710", Offset = "0x3C9E510", VA = "0x183C9F710")]
	public void PNDDIMHCKNL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F910", Offset = "0x3C9E710", VA = "0x183C9F910")]
	public JobHandle PNDDIMHCKNL<T>(JobHandle DADONNGONOC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x827F4E0", Offset = "0x827E2E0", VA = "0x18827F4E0")]
	public JobHandle PNDDIMHCKNL(ReadOnlySpan<int> LMGDJBMGPKF, JobHandle DADONNGONOC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F710", Offset = "0x3C9E510", VA = "0x183C9F710")]
	public void KCHBBBBMAGI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F650", Offset = "0x3C9E450", VA = "0x183C9F650")]
	public JobHandle KCHBBBBMAGI<T>(JobHandle DADONNGONOC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x827F3D0", Offset = "0x827E1D0", VA = "0x18827F3D0")]
	public JobHandle KCHBBBBMAGI(Span<int> LMGDJBMGPKF, JobHandle DADONNGONOC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F5A0", Offset = "0x3C9E3A0", VA = "0x183C9F5A0")]
	public ComponentDataFromEntity ILEBAGINAJB<T>(bool IJHOIHKCLJE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x827F2B0", Offset = "0x827E0B0", VA = "0x18827F2B0")]
	public ComponentDataFromEntity ILEBAGINAJB(int NHAMEADDKAO, bool IJHOIHKCLJE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F500", Offset = "0x3C9E300", VA = "0x183C9F500")]
	public SharedComponentIndexFromEntity<T> HIKEKHENEJG<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x827F370", Offset = "0x827E170", VA = "0x18827F370")]
	[BurstCompatible]
	public ComponentTypeHandle KCBDMCBDBBE(ComponentType IJGHPBJEGPC)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x827F4C0", Offset = "0x827E2C0", VA = "0x18827F4C0")]
	public EntityExistenceLookupByEntity NIHGDHFLJBJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x827F550", Offset = "0x827E350", VA = "0x18827F550", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F2F0", Offset = "0x3C9E0F0", VA = "0x183C9F2F0")]
	public bool ANNLMOGOGBG<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22D54F0", Offset = "0x22D42F0", VA = "0x1822D54F0")]
	protected MMBILNDFKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ADCBOBNNOEP : MMBILNDFKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x827E4B0", Offset = "0x827D2B0", VA = "0x18827E4B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22D54F0", Offset = "0x22D42F0", VA = "0x1822D54F0")]
	protected ADCBOBNNOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MOEAPCHKEBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PDNEHLMHDIO : EntityCommandBufferSystem, FILMNOODLPG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PHLHEDGDBJO OJKKHHLLEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE7CB60", Offset = "0xE7B960", VA = "0x180E7CB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x827F840", Offset = "0x827E640", VA = "0x18827F840")]
	public PDNEHLMHDIO(PHLHEDGDBJO CFEMPAINFAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JHPFIIJKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BJJHFEJKNPC([In] TFrom BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AGKLAFGEGAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBHPBPPACBL(T BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct FDJDCKINOMB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes BHFOMOBCJEB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x827E910", Offset = "0x827D710", VA = "0x18827E910", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OAHKAFFFACJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x827F720", Offset = "0x827E520", VA = "0x18827F720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct PDHGHKPHMFG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType IJGHPBJEGPC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x827F7C0", Offset = "0x827E5C0", VA = "0x18827F7C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct BMABAANFMMF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x633AE70", Offset = "0x6339C70", VA = "0x18633AE70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct OIAAKLBJKNC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> FEBLBJIINOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct CAHIFGEBHJB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T BNECONOIKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer DFPLNEMGLEN;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct OGHFOPAFCGC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JHPFIIJKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> IOLCILFPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FNOMGEEECIF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity BGAIGHPAGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> IOLCILFPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JDJODEDFDNH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x827EB70", Offset = "0x827D970", VA = "0x18827EB70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct DJABIAAINCB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NBIMMGABGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> NKGPBDDABMB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct HHJOAOGCFLE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JHPFIIJKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> CMJHOMKKDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> IOLCILFPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct LPMDJFCLEPK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MAJGOPOLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> ECMDJBGFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GGJOFGLKJMI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct JFEEKNJNMML<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MAJGOPOLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> ECMDJBGFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> GGJOFGLKJMI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51A24E0", Offset = "0x51A12E0", VA = "0x1851A24E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BONLCGJPMOM<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> NKGPBDDABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> JDPAALNKJKC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6349A10", Offset = "0x6348810", VA = "0x186349A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct DIPJIHJCCBF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JHPFIIJKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> NKGPBDDABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> JDPAALNKJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct FAEBFGINDGO<T, TPredicate> : IJob where T : struct where TPredicate : struct, AGKLAFGEGAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> PLIBPMJJPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> EAPFECKPGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OGMOFOKEHEL<T, TPredicate> : IJob where T : struct where TPredicate : struct, AGKLAFGEGAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> LELLLEBGGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> NKGPBDDABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct LCHOIIKHKDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity MAJGOPOLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> ECMDJBGFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> KBEGJDNDIBC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x827EF10", Offset = "0x827DD10", VA = "0x18827EF10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct FHKEKNOJLCJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity MAJGOPOLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> ECMDJBGFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> KBEGJDNDIBC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x827EA00", Offset = "0x827D800", VA = "0x18827EA00", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MGFBHEKLFPE
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LFIIOBAGELH
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3C4FAA0", Offset = "0x3C4E8A0", VA = "0x183C4FAA0")]
	public static bool JPONHAIDIFK<T>(this NativeArray<Entity> ECMDJBGFNAO, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BCEGGHEFDAN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EHGDNDMDPKE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public EHGDNDMDPKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HBNDDPKKDEA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public HBNDDPKKDEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> IFJOHEMLBAA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x827E850", Offset = "0x827D650", VA = "0x18827E850")]
	public BCEGGHEFDAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NDOJFBHBDDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HFMIIDOPMHA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct KADOKJACIEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct DCNFCCDGKIB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal KADOKJACIEF<TFrom> CMDMCJGFCDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> GGCHDPHENOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FJFHJMGKMCO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct BAFJFGAHLPG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal FJFHJMGKMCO<TFrom> CMDMCJGFCDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> GGCHDPHENOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct BCKGEFAFBBP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PJHFBELKMKK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal BCKGEFAFBBP<TFrom> CMDMCJGFCDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> GGCHDPHENOB;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct FJOJBKGKJDM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct NIFHIAIPPJJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal FJOJBKGKJDM<TFrom> CMDMCJGFCDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> GGCHDPHENOB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FJEOPCJDGCC
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IBLDNEFMJEC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF330", Offset = "0x3BBE130", VA = "0x183BBF330")]
	public static NativeList<T> MAKFAPPFDAI<T>(this NativeArray<T> GGCENMEEMKN, Allocator DFGMDNGNOEN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EHHJLDNNGCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LIBNBIKAHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C55E40", Offset = "0x3C54C40", VA = "0x183C55E40")]
	[LLGEDOLAEHA]
	public static JobHandle KHDOMPKCOLK<T>(this EntityCommandBufferSystem LILMAMMDCBG, NativeArray<Entity> DIDGDGLCMEE, NativeArray<T> BOIPFNOKGBJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C55A60", Offset = "0x3C54860", VA = "0x183C55A60")]
	[LLGEDOLAEHA]
	public static JobHandle KHDOMPKCOLK<T>(this EntityCommandBufferSystem LILMAMMDCBG, NativeArrayAsync<Entity> DIDGDGLCMEE, NativeArrayAsync<T> BOIPFNOKGBJ, [Optional] JobHandle PMKMPILBKMD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C55BC0", Offset = "0x3C549C0", VA = "0x183C55BC0")]
	[LLGEDOLAEHA]
	public static JobHandle KHDOMPKCOLK<T>(this EntityCommandBufferSystem LILMAMMDCBG, NativeArray<Entity> DIDGDGLCMEE, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x827F0F0", Offset = "0x827DEF0", VA = "0x18827F0F0")]
	[LLGEDOLAEHA]
	public static JobHandle KHDOMPKCOLK(this EntityCommandBufferSystem LILMAMMDCBG, NativeArray<Entity> DIDGDGLCMEE, ComponentTypes BHFOMOBCJEB, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x827EFA0", Offset = "0x827DDA0", VA = "0x18827EFA0")]
	[LLGEDOLAEHA]
	public static JobHandle KHDOMPKCOLK(this EntityCommandBufferSystem LILMAMMDCBG, EntityCommandBuffer DFPLNEMGLEN, NativeArray<Entity> DIDGDGLCMEE, ComponentTypes BHFOMOBCJEB, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JBJMJHMKKPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GNGKGDONBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x827EC70", Offset = "0x827DA70", VA = "0x18827EC70")]
	[LLGEDOLAEHA]
	public static JobHandle PABHMLEEHFL(this EntityCommandBufferSystem LILMAMMDCBG, NativeList<Entity> DIDGDGLCMEE, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x827EE00", Offset = "0x827DC00", VA = "0x18827EE00")]
	[LLGEDOLAEHA]
	public static JobHandle PABHMLEEHFL(this EntityCommandBufferSystem LILMAMMDCBG, NativeArrayAsync<Entity> DIDGDGLCMEE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AMFNLPDIHGA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x311EF00", Offset = "0x311DD00", VA = "0x18311EF00")]
	public static void BIBKKOILAKM<T>(this EntityCommandBufferSystem LILMAMMDCBG, EntityQuery LNMFFMOCINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x311F2C0", Offset = "0x311E0C0", VA = "0x18311F2C0")]
	[LLGEDOLAEHA]
	public static JobHandle OMCNNJNLPGP<T>(this EntityCommandBufferSystem LILMAMMDCBG, NativeArrayAsync<Entity> DIDGDGLCMEE, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x827E4E0", Offset = "0x827D2E0", VA = "0x18827E4E0")]
	[LLGEDOLAEHA]
	public static JobHandle OMCNNJNLPGP(this EntityCommandBufferSystem LILMAMMDCBG, NativeArrayAsync<Entity> DIDGDGLCMEE, ComponentType IJGHPBJEGPC, [Optional] JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KMHGEKMOIJJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C44640", Offset = "0x3C43440", VA = "0x183C44640")]
	[LLGEDOLAEHA]
	public static JobHandle FNJJFBEPAOL<T>(this EntityCommandBufferSystem LILMAMMDCBG, NativeArray<Entity> DIDGDGLCMEE, NativeArray<T> BOIPFNOKGBJ, JobHandle PMKMPILBKMD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DPMMOCPHJOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GJBHCNPOKAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ANABJBBNCAG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x311FEC0", Offset = "0x311ECC0", VA = "0x18311FEC0")]
	public static NativeArray<T> JBMFADPHAGG<T>(this NativeList<Entity> GGCENMEEMKN, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x311FB40", Offset = "0x311E940", VA = "0x18311FB40")]
	public static NativeArray<T> JBMFADPHAGG<T>(this NativeArray<Entity> GGCENMEEMKN, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x827E670", Offset = "0x827D470", VA = "0x18827E670")]
	public static NativeArray<Entity> DLHKJLKPBPB(this NativeArray<Entity> GGCENMEEMKN, EntityManager BIBOOAGIPAC, ComponentType IJGHPBJEGPC, Allocator DFGMDNGNOEN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x311FA40", Offset = "0x311E840", VA = "0x18311FA40")]
	public static NativeArray<T> BGDACALMACP<T>(this NativeArray<Entity> GGCENMEEMKN, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OLNKPEMHCFL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DGBCKIEJOLJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct HFBHKODLJHJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public DGBCKIEJOLJ<TFrom> GGCHDPHENOB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GHBEKOMGNED<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct OMIEALPAOJL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GHBEKOMGNED<TFrom> GGCHDPHENOB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct OFLCIGJEFJJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct AAIMKBFACNL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public OFLCIGJEFJJ<TFrom> GGCHDPHENOB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> LELLLEBGGIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GPLDDPAFPOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GFOOCKODANC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct IFNLLIDFLKG : JHPFIIJKDFE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x827EF00", Offset = "0x827DD00", VA = "0x18827EF00")]
		[BurstCompatible]
		public Entity BJJHFEJKNPC([In] Entity BNECONOIKOE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x827EF00", Offset = "0x827DD00", VA = "0x18827EF00", Slot = "4")]
		private Entity MAALGMDNFFP([In] Entity BNECONOIKOE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class JJPKCPHMNEI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct JDEBNJHEJMK<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x518FAD0", Offset = "0x518E8D0", VA = "0x18518FAD0", Slot = "4")]
		public int Compare((TKey, TValue) DHOMBGCEEAK, (TKey, TValue) EDBCCDDDLPI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE870", Offset = "0x3BED670", VA = "0x183BEE870")]
	public static void BFKJHCOPJKI<TKey, TValue>(NativeList<TKey> LKKFLGPIONB, NativeList<TValue> FEBLBJIINOM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE6B0", Offset = "0x3BED4B0", VA = "0x183BEE6B0")]
	public static void BFKJHCOPJKI<TKey, TValue>(NativeArray<TKey> LKKFLGPIONB, NativeArray<TValue> FEBLBJIINOM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE4A0", Offset = "0x3BED2A0", VA = "0x183BEE4A0")]
	public static void BFKJHCOPJKI<TKey, TValue, U>(NativeArray<TKey> LKKFLGPIONB, NativeArray<TValue> FEBLBJIINOM, U DHJOIDPKLPP) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MEPANOKHEMG
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct MDNPDDGILPK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> PLIBPMJJPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CFNMGJMFHPO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> PLIBPMJJPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KFILNPGCFIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> PLIBPMJJPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> LELLLEBGGIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MACLIINDACG
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NALBBMOLOOA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct CIMJBMFLENA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct NICKMGPFOJL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NEKCHPPLLKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> LELLLEBGGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OIGDGCFCHKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator DFGMDNGNOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> LELLLEBGGIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JEABNCJAEMA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class KMNAOHCGNFE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C44EA0", Offset = "0x3C43CA0", VA = "0x183C44EA0")]
	public static NativeList<Entity> CPOBOEDDEMF<T>(this NativeList<Entity> ECMDJBGFNAO, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C448A0", Offset = "0x3C436A0", VA = "0x183C448A0")]
	public static NativeList<Entity> CPOBOEDDEMF<T>(this NativeArray<Entity> ECMDJBGFNAO, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class FOCGFMIHNIM
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6B750", Offset = "0x3B6A550", VA = "0x183B6B750")]
	public static NativeList<Entity> GHCLKAKPHDF<T>(this NativeArray<Entity> ECMDJBGFNAO, EntityManager BIBOOAGIPAC, Allocator DFGMDNGNOEN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class CBPOICDCDMM
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct OHECMBFHCGH<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> COPOPHFGNFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct EHLFDGNNPAK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> COPOPHFGNFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct AEDPKMALMHL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JHPFIIJKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> COPOPHFGNFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GLLKJIBFANH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JHPFIIJKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> COPOPHFGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector KKFCBIHHIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int CKFKPOAGPKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CMGECJOPDJP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JHPFIIJKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GLLKJIBFANH<TSrc, TValue, TSelector> DOHHLDONBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue FFJLOOLALDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int HBNCFIPENFO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class PAPLBJPAAPP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct NIAPMJBCGIH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> COPOPHFGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int HBNCFIPENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int OLMCOHBECPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T FFJLOOLALDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T FFPLBNOAEPC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PIHJPNGEKCI KPKFGPMGDJL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x56ED380", Offset = "0x56EC180", VA = "0x1856ED380")]
			get
			{
				return default(PIHJPNGEKCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T IJPFGOFJNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, PIHJPNGEKCI) BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x56ED8D0", Offset = "0x56EC6D0", VA = "0x1856ED8D0")]
			get
			{
				return default((T, PIHJPNGEKCI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56EDA50", Offset = "0x56EC850", VA = "0x1856EDA50")]
		public NIAPMJBCGIH(NativeArray<T> COPOPHFGNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB120", Offset = "0x2BD9F20", VA = "0x182BDB120")]
		public NIAPMJBCGIH<T> OMGGHMFPBJO()
		{
			return default(NIAPMJBCGIH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56ED390", Offset = "0x56EC190", VA = "0x1856ED390")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4202650", Offset = "0x4201450", VA = "0x184202650")]
		public CBCCKKCBGAF<T, TComparer> DBMAMMFPECF<TComparer>([Optional] TComparer DHJOIDPKLPP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(CBCCKKCBGAF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct CBCCKKCBGAF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> COPOPHFGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int HBNCFIPENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int OLMCOHBECPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T FFJLOOLALDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T FFPLBNOAEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer DHJOIDPKLPP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PIHJPNGEKCI KPKFGPMGDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x56ED380", Offset = "0x56EC180", VA = "0x1856ED380")]
			get
			{
				return default(PIHJPNGEKCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T IJPFGOFJNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, PIHJPNGEKCI range) BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x56ED8D0", Offset = "0x56EC6D0", VA = "0x1856ED8D0")]
			get
			{
				return default((T, PIHJPNGEKCI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6706110", Offset = "0x6704F10", VA = "0x186706110")]
		public CBCCKKCBGAF(NativeArray<T> COPOPHFGNFG, TComparer DHJOIDPKLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x480C380", Offset = "0x480B180", VA = "0x18480C380")]
		public CBCCKKCBGAF<T, TComparer> OMGGHMFPBJO()
		{
			return default(CBCCKKCBGAF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6706000", Offset = "0x6704E00", VA = "0x186706000")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E630", Offset = "0x3D4D430", VA = "0x183D4E630")]
	public static NIAPMJBCGIH<T> PJLHDBLIDMD<T>(this NativeArray<T> COPOPHFGNFG) where T : struct
	{
		return default(NIAPMJBCGIH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface JGEIGFGININ
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class DJHBKBFLBOH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DDACKACAMGF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MBHOAABPNLF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DDACKACAMGF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D52B00", Offset = "0x4D51900", VA = "0x184D52B00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public MBHOAABPNLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56510F0", Offset = "0x564FEF0", VA = "0x1856510F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x56512A0", Offset = "0x56500A0", VA = "0x1856512A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> DHOAJCBMBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream DJJDFCKFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream PEMHGOPKHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf AGPNNEOOLAK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9BB0", Offset = "0x6DC89B0", VA = "0x186DC9BB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9BF0", Offset = "0x6DC89F0", VA = "0x186DC9BF0", Slot = "4")]
	[IteratorStateMachine(typeof(DDACKACAMGF<>.MBHOAABPNLF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9CE0", Offset = "0x6DC8AE0", VA = "0x186DC9CE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KGMNMJLOEHL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] NHMENHDBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf AGPNNEOOLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream DJJDFCKFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream LPPLCECAEFF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x52CD4D0", Offset = "0x52CC2D0", VA = "0x1852CD4D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct FLGKICNCBJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream DJJDFCKFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream PEMHGOPKHKL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x827EA90", Offset = "0x827D890", VA = "0x18827EA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MNGKHHOCHAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NHMENHDBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream DJJDFCKFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream LPPLCECAEFF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x827F560", Offset = "0x827E360", VA = "0x18827F560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DJIOIHKECDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BNHJMLMBCPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum LKMNDGPPJFE
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
internal static class CAEILDKNJMI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GNLNCCKEALF
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GNLNCCKEALF()
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
