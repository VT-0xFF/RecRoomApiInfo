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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E38870", Offset = "0x7E37A70", VA = "0x187E38870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E37C10", Offset = "0x7E36E10", VA = "0x187E37C10")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MBNOMAAFELG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JBEKFECHPDC NNBLIKHGNEC
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
public interface HKALFBJLMON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEBMMDOBOOL(Entity LBPCFJCJDPM, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBAHFPOFGMC(Entity LBPCFJCJDPM, object PPOILDCNBFL, [Out] bool NJGEGGNLECE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODCFLIDDFCC(Entity LBPCFJCJDPM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PIDLJBJKMOI<TComponentData, TValue> : GJAGKIHHGBJ<TValue>, IDisposable where TComponentData : struct, MBNOMAAFELG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class PKPNNBMLDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> MEHAOGGFJIO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FAGABNHAKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x40DBD40", Offset = "0x40DAF40", VA = "0x1840DBD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5632120", Offset = "0x5631320", VA = "0x185632120")]
		public bool IJNLNPLCBAJ([Out] TValue MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56323C0", Offset = "0x56315C0", VA = "0x1856323C0")]
		public void OOLDDNFEGEK(object PPOILDCNBFL, TValue MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5632310", Offset = "0x5631510", VA = "0x185632310")]
		public bool KKKHDEJPLIG(object PPOILDCNBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5632230", Offset = "0x5631430", VA = "0x185632230")]
		public int IOLJJNDBKMM(object PPOILDCNBFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56324A0", Offset = "0x56316A0", VA = "0x1856324A0")]
		public PKPNNBMLDGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<PKPNNBMLDGP> IIMFPDBPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KIMGDACKBII<JBEKFECHPDC, PKPNNBMLDGP> CAOHDBFLGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager EPEFONCBOCP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x562B320", Offset = "0x562A520", VA = "0x18562B320")]
	public PIDLJBJKMOI(EntityManager EPEFONCBOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x562B1A0", Offset = "0x562A3A0", VA = "0x18562B1A0", Slot = "4")]
	public void PEBMMDOBOOL(Entity LBPCFJCJDPM, object PPOILDCNBFL, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x562ABA0", Offset = "0x5629DA0", VA = "0x18562ABA0", Slot = "5")]
	public bool GBAHFPOFGMC(Entity LBPCFJCJDPM, object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x562AEB0", Offset = "0x562A0B0", VA = "0x18562AEB0", Slot = "6")]
	public bool IJNLNPLCBAJ(Entity LBPCFJCJDPM, [Out] TValue MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x562AB80", Offset = "0x5629D80", VA = "0x18562AB80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x562B0E0", Offset = "0x562A2E0", VA = "0x18562B0E0")]
	private void OELEOMDOKBH(PKPNNBMLDGP LPKEOPBFPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x562AAC0", Offset = "0x5629CC0", VA = "0x18562AAC0")]
	private bool DMCMJGFBHHD(Entity LBPCFJCJDPM, [Out] JBEKFECHPDC NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x562AD90", Offset = "0x5629F90", VA = "0x18562AD90")]
	private void HPHJFDOBPFE(Entity LBPCFJCJDPM, JBEKFECHPDC NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x562AE90", Offset = "0x562A090", VA = "0x18562AE90")]
	private bool IDCJBGENHAK(JBEKFECHPDC NLNGJFNOHGL, [Out] PKPNNBMLDGP LPKEOPBFPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x562AFC0", Offset = "0x562A1C0", VA = "0x18562AFC0")]
	private PKPNNBMLDGP MNHHKLOABBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GJAGKIHHGBJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEBMMDOBOOL(Entity LBPCFJCJDPM, object PPOILDCNBFL, TValue MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBAHFPOFGMC(Entity LBPCFJCJDPM, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJNLNPLCBAJ(Entity LBPCFJCJDPM, [Out] TValue MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JBEKFECHPDC : AKEBFDHKPEH, IEquatable<JBEKFECHPDC>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JBEKFECHPDC GOADDLNGGGH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E38000", Offset = "0x7E37200", VA = "0x187E38000", Slot = "8")]
	public bool Equals(JBEKFECHPDC FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E38050", Offset = "0x7E37250", VA = "0x187E38050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OBICJOPLBKB<THasTokensTag> : HKALFBJLMON, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, JBEKFECHPDC> BNOKFAMNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> IIMFPDBPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KIMGDACKBII<JBEKFECHPDC, HashSet<object>> CAOHDBFLGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager EPEFONCBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem NLAHBKJHOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x54C1260", Offset = "0x54C0460", VA = "0x1854C1260")]
	public OBICJOPLBKB(EntityManager EPEFONCBOCP, EntityCommandBufferSystem NLAHBKJHOJD, FODGIOKBGBI ALPKHCOGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x54C0F00", Offset = "0x54C0100", VA = "0x1854C0F00", Slot = "4")]
	public bool PEBMMDOBOOL(Entity LBPCFJCJDPM, object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x54BF330", Offset = "0x54BE530", VA = "0x1854BF330", Slot = "5")]
	public bool GBAHFPOFGMC(Entity LBPCFJCJDPM, object PPOILDCNBFL, [Out] bool NJGEGGNLECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x54C0460", Offset = "0x54BF660", VA = "0x1854C0460", Slot = "6")]
	public bool ODCFLIDDFCC(Entity LBPCFJCJDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x54C0510", Offset = "0x54BF710", VA = "0x1854C0510", Slot = "8")]
	public bool ODCFLIDDFCC(JBEKFECHPDC NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x54BED20", Offset = "0x54BDF20", VA = "0x1854BED20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x54C07D0", Offset = "0x54BF9D0", VA = "0x1854C07D0")]
	private void OELEOMDOKBH(HashSet<object> LPKEOPBFPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x54BEAE0", Offset = "0x54BDCE0", VA = "0x1854BEAE0")]
	private bool DMCMJGFBHHD(Entity LBPCFJCJDPM, [Out] JBEKFECHPDC NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x54BF860", Offset = "0x54BEA60", VA = "0x1854BF860")]
	private bool KJDPFMILCEJ(Entity LBPCFJCJDPM, [Out] JBEKFECHPDC NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x54C00E0", Offset = "0x54BF2E0", VA = "0x1854C00E0")]
	private void MIEBFENFIFG(Entity LBPCFJCJDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54BFBE0", Offset = "0x54BEDE0", VA = "0x1854BFBE0")]
	private void KPCCPOLCNND(Entity LBPCFJCJDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x54BE780", Offset = "0x54BD980", VA = "0x1854BE780")]
	private void BMCEMJDKHJK(Entity LBPCFJCJDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x54BF670", Offset = "0x54BE870", VA = "0x1854BF670")]
	private void HPHJFDOBPFE(Entity LBPCFJCJDPM, JBEKFECHPDC NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x54BE560", Offset = "0x54BD760", VA = "0x1854BE560")]
	private bool ACNPNCAAEOE(JBEKFECHPDC NLNGJFNOHGL, [Out] HashSet<object> LPKEOPBFPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x54C0320", Offset = "0x54BF520", VA = "0x1854C0320")]
	private HashSet<object> MNHHKLOABBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DNPPFPOJLAO
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MHCDJDLJJOJ : ENLLAHPIPMA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E38580", Offset = "0x7E37780", VA = "0x187E38580")]
	public float JNJLBJNHEPI([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E38580", Offset = "0x7E37780", VA = "0x187E38580", Slot = "4")]
	private float DHNHABLAJDB([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MEIFFLNLFJE : ENLLAHPIPMA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E38570", Offset = "0x7E37770", VA = "0x187E38570")]
	public float JNJLBJNHEPI([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E38570", Offset = "0x7E37770", VA = "0x187E38570", Slot = "4")]
	private float DHNHABLAJDB([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OMGHPBGAJFG : ENLLAHPIPMA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xE7B4A0", Offset = "0xE7A6A0", VA = "0x180E7B4A0")]
	public float JNJLBJNHEPI([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE7B4A0", Offset = "0xE7A6A0", VA = "0x180E7B4A0", Slot = "4")]
	private float DHNHABLAJDB([In] float3 MLCDCHNOCFI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EHIMDFMKIIA : ENLLAHPIPMA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0")]
	public int JNJLBJNHEPI([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0", Slot = "4")]
	private int EKNIMNGMAEE([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CEOJNIPGPKO : ENLLAHPIPMA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEFCBE0", Offset = "0xEFBDE0", VA = "0x180EFCBE0")]
	public int JNJLBJNHEPI([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xEFCBE0", Offset = "0xEFBDE0", VA = "0x180EFCBE0", Slot = "4")]
	private int EKNIMNGMAEE([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KHKDJFMPHKL : ENLLAHPIPMA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xE4AA10", Offset = "0xE49C10", VA = "0x180E4AA10")]
	public int JNJLBJNHEPI([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE4AA10", Offset = "0xE49C10", VA = "0x180E4AA10", Slot = "4")]
	private int EKNIMNGMAEE([In] int3 MLCDCHNOCFI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EIPBHAGEAJB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086B70", VA = "0x182087970")]
	public EIPBHAGEAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class FNPANKDKAKI : SystemBase, EFBHNMNINIH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E37F00", Offset = "0x7E37100", VA = "0x187E37F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38069E0", Offset = "0x3805BE0", VA = "0x1838069E0")]
	public void BOJGICPEGIK<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38069E0", Offset = "0x3805BE0", VA = "0x1838069E0")]
	public void CPFEFACDOCJ<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E37D70", Offset = "0x7E36F70", VA = "0x187E37D70")]
	public JobHandle DIBOFLFEJNL(ReadOnlySpan<int> FIGCNLKIHMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3806860", Offset = "0x3805A60", VA = "0x183806860")]
	public JobHandle ANHJMEJPENI<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E37C40", Offset = "0x7E36E40", VA = "0x187E37C40")]
	public JobHandle ANHJMEJPENI(ReadOnlySpan<int> FIGCNLKIHMP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3806B10", Offset = "0x3805D10", VA = "0x183806B10")]
	public void DPKMMAECJAM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3806F80", Offset = "0x3806180", VA = "0x183806F80")]
	public JobHandle DPKMMAECJAM<T>(JobHandle NLNGJFNOHGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E37E30", Offset = "0x7E37030", VA = "0x187E37E30")]
	public JobHandle DPKMMAECJAM(ReadOnlySpan<int> FIGCNLKIHMP, JobHandle NLNGJFNOHGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3806B10", Offset = "0x3805D10", VA = "0x183806B10")]
	public void DKCDOJANOIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3806CE0", Offset = "0x3805EE0", VA = "0x183806CE0")]
	public JobHandle DKCDOJANOIM<T>(JobHandle NLNGJFNOHGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E37DC0", Offset = "0x7E36FC0", VA = "0x187E37DC0")]
	public JobHandle DKCDOJANOIM(Span<int> FIGCNLKIHMP, JobHandle NLNGJFNOHGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3806A40", Offset = "0x3805C40", VA = "0x183806A40")]
	public ComponentDataFromEntity DCNPBMAFPIL<T>(bool HAKDEDLGFPF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E37CB0", Offset = "0x7E36EB0", VA = "0x187E37CB0")]
	public ComponentDataFromEntity DCNPBMAFPIL(int JGCOFBDMFGO, bool HAKDEDLGFPF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3806910", Offset = "0x3805B10", VA = "0x183806910")]
	public SharedComponentIndexFromEntity<T> AONDJIKKPGG<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E37EA0", Offset = "0x7E370A0", VA = "0x187E37EA0")]
	[BurstCompatible]
	public ComponentTypeHandle EJJNHGJGECA(ComponentType INAGDPBAAJH)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E37C90", Offset = "0x7E36E90", VA = "0x187E37C90")]
	public EntityExistenceLookupByEntity CGHDDKDCNIH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E37F30", Offset = "0x7E37130", VA = "0x187E37F30", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3807840", Offset = "0x3806A40", VA = "0x183807840")]
	public bool MPBDBHFLFBP<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086B70", VA = "0x182087970")]
	protected FNPANKDKAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AGNCLKDFCAE : FNPANKDKAKI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E37660", Offset = "0x7E36860", VA = "0x187E37660", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086B70", VA = "0x182087970")]
	protected AGNCLKDFCAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ABNMJKLPPBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HMOBGEKJCOD : EntityCommandBufferSystem, EFBHNMNINIH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FODGIOKBGBI GCMHLHCLEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD863A0", Offset = "0xD855A0", VA = "0x180D863A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E37F40", Offset = "0x7E37140", VA = "0x187E37F40")]
	public HMOBGEKJCOD(FODGIOKBGBI FHEIHFBIKLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ENLLAHPIPMA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo JNJLBJNHEPI([In] TFrom MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DADAAIGDNGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJODDJKCNDD(T MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct DLGBNOHMJPP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes KFBEOOBOHFF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E37B20", Offset = "0x7E36D20", VA = "0x187E37B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct PKCGNPHMDNO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E388F0", Offset = "0x7E37AF0", VA = "0x187E388F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct POJNPEABBDB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType INAGDPBAAJH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E38990", Offset = "0x7E37B90", VA = "0x187E38990", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct IADFACKPHNM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C698C0", Offset = "0x4C68AC0", VA = "0x184C698C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct GBBOGKMBEIB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> CPMBLPBIGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct HHLDNMCMELO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T MLCDCHNOCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer BHOGEIBOCOG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct FAMDKPPJAKL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ENLLAHPIPMA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> MJBJCJGGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NGDEGANKODG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity HLPKECDMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> MJBJCJGGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GAMDMHAMEGL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E38770", Offset = "0x7E37970", VA = "0x187E38770", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct JHANDFBGDPO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LJDCGLEOJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> LGEKKBGBLKG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FCLEJKMLEDA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ENLLAHPIPMA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> BKNDCFLFIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> MJBJCJGGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct OBACEGPLEMI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HHAJDMBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> LOICBLHJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> JDHAAGPGJPK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct EDAPIJAFBOK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HHAJDMBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> LOICBLHJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> JDHAAGPGJPK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4528BE0", Offset = "0x4527DE0", VA = "0x184528BE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GIJLOAIOKGD<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> LGEKKBGBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> ALEGHEAOMGM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F2B0", Offset = "0x4A6E4B0", VA = "0x184A6F2B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct CECLAENKLKN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : ENLLAHPIPMA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> LGEKKBGBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> ALEGHEAOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct MPMGBOPKOOI<T, TPredicate> : IJob where T : struct where TPredicate : struct, DADAAIGDNGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> AGHDGKENICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> EFFEHDJFAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OMFAKOHIMGE<T, TPredicate> : IJob where T : struct where TPredicate : struct, DADAAIGDNGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> KJKCHKABEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> LGEKKBGBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct KPBBEAPHDCD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity HHAJDMBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> LOICBLHJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JFHOGLHKNHH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E381C0", Offset = "0x7E373C0", VA = "0x187E381C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct HPEHGADDMBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity HHAJDMBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> LOICBLHJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> JFHOGLHKNHH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E37F70", Offset = "0x7E37170", VA = "0x187E37F70", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class AGKKKPPBBEF
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class DCHHCOMAGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x36627A0", Offset = "0x36619A0", VA = "0x1836627A0")]
	public static bool NHHLAKGOJKL<T>(this NativeArray<Entity> LOICBLHJOIM, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LJNDOGFNHFD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IAHEHLLNPLO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public IAHEHLLNPLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MMNKFDOHHBA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public MMNKFDOHHBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> IJFGCHGOAKI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E38250", Offset = "0x7E37450", VA = "0x187E38250")]
	public LJNDOGFNHFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JIICGLIFDMN
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GDNJNAJGHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OACEKFMLDPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LFEHCFCJPBK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OACEKFMLDPB<TFrom> NJHDJGHEICO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> JIJCOIBMMGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OPDHDPNMMFA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct DDCFLKFMPCD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal OPDHDPNMMFA<TFrom> NJHDJGHEICO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> JIJCOIBMMGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct PALMFNHLAMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct HBDCMNHBECF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal PALMFNHLAMK<TFrom> NJHDJGHEICO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> JIJCOIBMMGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct ALBLGPGNDDO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct OBNCOBEIJJA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal ALBLGPGNDDO<TFrom> NJHDJGHEICO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> JIJCOIBMMGK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OCGEAMMHLCO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FCLGAPLPOEA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37F4B00", Offset = "0x37F3D00", VA = "0x1837F4B00")]
	public static NativeList<T> ICOHGAIJEGL<T>(this NativeArray<T> HEDDMJOGMMB, Allocator FOPENOLHBOM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OCPMIGKCOMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BJEEGGFABND
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x35B8070", Offset = "0x35B7270", VA = "0x1835B8070")]
	[BIAKIIJPEFF]
	public static JobHandle CPMMPLEBEDF<T>(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArray<Entity> EEOGDGCIFOA, NativeArray<T> DHAOEHNLNON) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35B7D70", Offset = "0x35B6F70", VA = "0x1835B7D70")]
	[BIAKIIJPEFF]
	public static JobHandle CPMMPLEBEDF<T>(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArrayAsync<Entity> EEOGDGCIFOA, NativeArrayAsync<T> DHAOEHNLNON, [Optional] JobHandle FCIEDFFGDDO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35B7C40", Offset = "0x35B6E40", VA = "0x1835B7C40")]
	[BIAKIIJPEFF]
	public static JobHandle CPMMPLEBEDF<T>(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArray<Entity> EEOGDGCIFOA, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E377E0", Offset = "0x7E369E0", VA = "0x187E377E0")]
	[BIAKIIJPEFF]
	public static JobHandle CPMMPLEBEDF(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArray<Entity> EEOGDGCIFOA, ComponentTypes KFBEOOBOHFF, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E37690", Offset = "0x7E36890", VA = "0x187E37690")]
	[BIAKIIJPEFF]
	public static JobHandle CPMMPLEBEDF(this EntityCommandBufferSystem NLAHBKJHOJD, EntityCommandBuffer BHOGEIBOCOG, NativeArray<Entity> EEOGDGCIFOA, ComponentTypes KFBEOOBOHFF, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MBPHPIJHNCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class MEGFECCALEI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E383E0", Offset = "0x7E375E0", VA = "0x187E383E0")]
	[BIAKIIJPEFF]
	public static JobHandle BJMLGGLKIJH(this EntityCommandBufferSystem NLAHBKJHOJD, NativeList<Entity> EEOGDGCIFOA, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E382E0", Offset = "0x7E374E0", VA = "0x187E382E0")]
	[BIAKIIJPEFF]
	public static JobHandle BJMLGGLKIJH(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArrayAsync<Entity> EEOGDGCIFOA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DHLBIKBLIFK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x366A1C0", Offset = "0x36693C0", VA = "0x18366A1C0")]
	public static void JKPBHBHPOKC<T>(this EntityCommandBufferSystem NLAHBKJHOJD, EntityQuery OJJIKCPLFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x366A050", Offset = "0x3669250", VA = "0x18366A050")]
	[BIAKIIJPEFF]
	public static JobHandle IGPBECMIONI<T>(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArrayAsync<Entity> EEOGDGCIFOA, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E37990", Offset = "0x7E36B90", VA = "0x187E37990")]
	[BIAKIIJPEFF]
	public static JobHandle IGPBECMIONI(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArrayAsync<Entity> EEOGDGCIFOA, ComponentType INAGDPBAAJH, [Optional] JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MEBAAACKNBD
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38D7A40", Offset = "0x38D6C40", VA = "0x1838D7A40")]
	[BIAKIIJPEFF]
	public static JobHandle LIPFKKHOEHO<T>(this EntityCommandBufferSystem NLAHBKJHOJD, NativeArray<Entity> EEOGDGCIFOA, NativeArray<T> DHAOEHNLNON, JobHandle FCIEDFFGDDO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NNJJFEJCNBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BKKKABCKKLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NDICEGFEGEP
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39805F0", Offset = "0x397F7F0", VA = "0x1839805F0")]
	public static NativeArray<T> OECPOMKHJIK<T>(this NativeList<Entity> HEDDMJOGMMB, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x39806C0", Offset = "0x397F8C0", VA = "0x1839806C0")]
	public static NativeArray<T> OECPOMKHJIK<T>(this NativeArray<Entity> HEDDMJOGMMB, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E38590", Offset = "0x7E37790", VA = "0x187E38590")]
	public static NativeArray<Entity> DNJEHDGAJLH(this NativeArray<Entity> HEDDMJOGMMB, EntityManager EPEFONCBOCP, ComponentType INAGDPBAAJH, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x39804F0", Offset = "0x397F6F0", VA = "0x1839804F0")]
	public static NativeArray<T> FLBOCOFJBJN<T>(this NativeArray<Entity> HEDDMJOGMMB, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HOHPKOMBLML
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CMDMLOFMCEK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct DKDBJKGGFKD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CMDMLOFMCEK<TFrom> JIJCOIBMMGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct ICJKCHINJCA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct PIICFBPMBLH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ICJKCHINJCA<TFrom> JIJCOIBMMGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct JDGDJCHOLCI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct OLOAJMAAIDM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public JDGDJCHOLCI<TFrom> JIJCOIBMMGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> KJKCHKABEFM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ODNMGEGHJKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AEKCIDDDDDI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct FGMCNODOFJA : ENLLAHPIPMA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C30", Offset = "0x7E36E30", VA = "0x187E37C30")]
		[BurstCompatible]
		public Entity JNJLBJNHEPI([In] Entity MLCDCHNOCFI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C30", Offset = "0x7E36E30", VA = "0x187E37C30", Slot = "4")]
		private Entity LCLLFEHJJDH([In] Entity MLCDCHNOCFI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KKGBLICIDFC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct DKJCAMCNLAA<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A29210", Offset = "0x6A28410", VA = "0x186A29210", Slot = "4")]
		public int Compare((TKey, TValue) CCOLDGJALNH, (TKey, TValue) JCBKIOEHCDD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38B33E0", Offset = "0x38B25E0", VA = "0x1838B33E0")]
	public static void HAGJHGAGGFC<TKey, TValue>(NativeList<TKey> AABACGABDHN, NativeList<TValue> CPMBLPBIGIH) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38B3670", Offset = "0x38B2870", VA = "0x1838B3670")]
	public static void HAGJHGAGGFC<TKey, TValue>(NativeArray<TKey> AABACGABDHN, NativeArray<TValue> CPMBLPBIGIH) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38B3840", Offset = "0x38B2A40", VA = "0x1838B3840")]
	public static void HAGJHGAGGFC<TKey, TValue, U>(NativeArray<TKey> AABACGABDHN, NativeArray<TValue> CPMBLPBIGIH, U GBIKKNALKGA) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class PDIGACIMIDL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BKAIMHBLOMI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> AGHDGKENICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LMPMAMGBNEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> AGHDGKENICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct LKMOKDDPFOC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> AGHDGKENICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> KJKCHKABEFM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MIGLIMDOODL
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KJCGEACJMLD
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EGJELLBIBKC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct ILGINJGHMJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct IBFAOPDDAHI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> KJKCHKABEFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct PLDOMBIGBOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator FOPENOLHBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> KJKCHKABEFM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class PKCEGNHLJLA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class KNNICLCEAON
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38B6F50", Offset = "0x38B6150", VA = "0x1838B6F50")]
	public static NativeList<Entity> PPMKBOFDDPN<T>(this NativeList<Entity> LOICBLHJOIM, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38B6780", Offset = "0x38B5980", VA = "0x1838B6780")]
	public static NativeList<Entity> PPMKBOFDDPN<T>(this NativeArray<Entity> LOICBLHJOIM, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class ODBMKHKIFCG
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x39DFFD0", Offset = "0x39DF1D0", VA = "0x1839DFFD0")]
	public static NativeList<Entity> AOKOFHIOOAO<T>(this NativeArray<Entity> LOICBLHJOIM, EntityManager EPEFONCBOCP, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GHECEFKHOIF
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct NJPAHAFDLFB<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CABEAFGDMFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct DPGDHBLOOAG<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> CABEAFGDMFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct IIKOPKGIEFN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ENLLAHPIPMA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> CABEAFGDMFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ABPJKNGOFNF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, ENLLAHPIPMA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> CABEAFGDMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector JJMPEACGCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int NIBICIJAIGM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct MPACFIEGMBC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ENLLAHPIPMA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private ABPJKNGOFNF<TSrc, TValue, TSelector> BGMKKIIPDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue KFOHHOAMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int AIGLIPKHKOK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class IIKOAENBHAK
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PHBEOMDKDDD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> CABEAFGDMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int AIGLIPKHKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int PGPLHHGGAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T KFOHHOAMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T AAOLAOHGDOB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GDHEFDIGGIJ BKCMJDDCPNA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5626230", Offset = "0x5625430", VA = "0x185626230")]
			get
			{
				return default(GDHEFDIGGIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T LJOHIAGCLMH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, GDHEFDIGGIJ) HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5625DC0", Offset = "0x5624FC0", VA = "0x185625DC0")]
			get
			{
				return default((T, GDHEFDIGGIJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56262B0", Offset = "0x56254B0", VA = "0x1856262B0")]
		public PHBEOMDKDDD(NativeArray<T> CABEAFGDMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x45F5A40", Offset = "0x45F4C40", VA = "0x1845F5A40")]
		public PHBEOMDKDDD<T> MAJHBAEJHEK()
		{
			return default(PHBEOMDKDDD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5625E60", Offset = "0x5625060", VA = "0x185625E60")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F430", Offset = "0x3F7E630", VA = "0x183F7F430")]
		public BFKMFMFFOGL<T, TComparer> BPGCNPKONLE<TComparer>([Optional] TComparer GBIKKNALKGA) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BFKMFMFFOGL<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct BFKMFMFFOGL<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> CABEAFGDMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int AIGLIPKHKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int PGPLHHGGAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T KFOHHOAMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T AAOLAOHGDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer GBIKKNALKGA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GDHEFDIGGIJ BKCMJDDCPNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5626230", Offset = "0x5625430", VA = "0x185626230")]
			get
			{
				return default(GDHEFDIGGIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T LJOHIAGCLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, GDHEFDIGGIJ range) HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5625DC0", Offset = "0x5624FC0", VA = "0x185625DC0")]
			get
			{
				return default((T, GDHEFDIGGIJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E82990", Offset = "0x5E81B90", VA = "0x185E82990")]
		public BFKMFMFFOGL(NativeArray<T> CABEAFGDMFF, TComparer GBIKKNALKGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x381EA00", Offset = "0x381DC00", VA = "0x18381EA00")]
		public BFKMFMFFOGL<T, TComparer> MAJHBAEJHEK()
		{
			return default(BFKMFMFFOGL<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E82750", Offset = "0x5E81950", VA = "0x185E82750")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x384AD20", Offset = "0x3849F20", VA = "0x18384AD20")]
	public static PHBEOMDKDDD<T> LEJGIKIDJGP<T>(this NativeArray<T> CABEAFGDMFF) where T : struct
	{
		return default(PHBEOMDKDDD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface JNHBJLIBJGP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HMBINABJDBH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BDEDEJPKPFM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class IGAICHBCBBN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BDEDEJPKPFM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x49FD880", Offset = "0x49FCA80", VA = "0x1849FD880", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public IGAICHBCBBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4C7D7A0", Offset = "0x4C7C9A0", VA = "0x184C7D7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4C7D970", Offset = "0x4C7CB70", VA = "0x184C7D970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> MBNNHDCIEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream KDAEEKGJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream MIKKDMMGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf PEABIEGCDFI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E210", Offset = "0x5E7D410", VA = "0x185E7E210", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E250", Offset = "0x5E7D450", VA = "0x185E7E250", Slot = "4")]
	[IteratorStateMachine(typeof(BDEDEJPKPFM<>.IGAICHBCBBN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E350", Offset = "0x5E7D550", VA = "0x185E7E350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KGJPNBFCJML<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] KKCFCHBPMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf PEABIEGCDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream KDAEEKGJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream LFFOGBLCOJM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x500D860", Offset = "0x500CA60", VA = "0x18500D860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CMLMAPICJLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream KDAEEKGJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream MIKKDMMGBJD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E37950", Offset = "0x7E36B50", VA = "0x187E37950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KJKMJDCOFNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] KKCFCHBPMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream KDAEEKGJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream LFFOGBLCOJM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E380A0", Offset = "0x7E372A0", VA = "0x187E380A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GKPFMNDDMIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FKOLJCJPJBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum DMFJKCOOMLG
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
internal static class JKMPEELCDNB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
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
