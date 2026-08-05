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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x84CDEE0", Offset = "0x84CC8E0", VA = "0x1884CDEE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
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
		[Cpp2IlInjected.Address(RVA = "0x84CD420", Offset = "0x84CBE20", VA = "0x1884CD420")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FJDBCBNBCHI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KFBMKOPGMCG CPGCEJBKJOA
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
public interface COCNNJBDJBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJHICGNOBA(Entity EOGGAEBALGK, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDKCPJFKOMJ(Entity EOGGAEBALGK, object DHNMCOFINFM, [Out] bool IBBDBJMBCED);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKKAHAFPMLA(Entity EOGGAEBALGK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NPEADDFBJCF<TComponentData, TValue> : FMPNOBNEKMP<TValue>, IDisposable where TComponentData : struct, FJDBCBNBCHI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class DGMIAHGJLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> CKDFPBCCFHO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NEOIHEKIHEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4488F50", Offset = "0x4487950", VA = "0x184488F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD6F0", Offset = "0x6FFC0F0", VA = "0x186FFD6F0")]
		public bool ACDOMOADAGI([Out] TValue PDKJBMPOMNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD940", Offset = "0x6FFC340", VA = "0x186FFD940")]
		public void MJGPLOFFIKO(object DHNMCOFINFM, TValue PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD7E0", Offset = "0x6FFC1E0", VA = "0x186FFD7E0")]
		public bool BBOPECIHIDA(object DHNMCOFINFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD860", Offset = "0x6FFC260", VA = "0x186FFD860")]
		public int GLFKDNIBEKK(object DHNMCOFINFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD9F0", Offset = "0x6FFC3F0", VA = "0x186FFD9F0")]
		public DGMIAHGJLOG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<DGMIAHGJLOG> CKDINIJGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CAAPKKGPCNK<KFBMKOPGMCG, DGMIAHGJLOG> EHDMMFKEFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager MGCKGGMOENE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58F2D70", Offset = "0x58F1770", VA = "0x1858F2D70")]
	public NPEADDFBJCF(EntityManager MGCKGGMOENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58F2830", Offset = "0x58F1230", VA = "0x1858F2830", Slot = "4")]
	public void EKJHICGNOBA(Entity EOGGAEBALGK, object DHNMCOFINFM, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58F2A00", Offset = "0x58F1400", VA = "0x1858F2A00", Slot = "5")]
	public bool GDKCPJFKOMJ(Entity EOGGAEBALGK, object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58F2620", Offset = "0x58F1020", VA = "0x1858F2620", Slot = "6")]
	public bool ACDOMOADAGI(Entity EOGGAEBALGK, [Out] TValue PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x58F2810", Offset = "0x58F1210", VA = "0x1858F2810", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58F2970", Offset = "0x58F1370", VA = "0x1858F2970")]
	private void EKOBDPKNIIJ(DGMIAHGJLOG JLNBHGKNAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58F2CB0", Offset = "0x58F16B0", VA = "0x1858F2CB0")]
	private bool NLFJHPGEOKG(Entity EOGGAEBALGK, [Out] KFBMKOPGMCG OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58F2BC0", Offset = "0x58F15C0", VA = "0x1858F2BC0")]
	private void MCCJIGMEKNG(Entity EOGGAEBALGK, KFBMKOPGMCG OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58F2BA0", Offset = "0x58F15A0", VA = "0x1858F2BA0")]
	private bool HMPNKMEJBDL(KFBMKOPGMCG OFBHFOIEGGG, [Out] DGMIAHGJLOG JLNBHGKNAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x58F2720", Offset = "0x58F1120", VA = "0x1858F2720")]
	private DGMIAHGJLOG DDBNBOKAEID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FMPNOBNEKMP<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKJHICGNOBA(Entity EOGGAEBALGK, object DHNMCOFINFM, TValue PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDKCPJFKOMJ(Entity EOGGAEBALGK, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACDOMOADAGI(Entity EOGGAEBALGK, [Out] TValue PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KFBMKOPGMCG : NDJHBLEGILP, IEquatable<KFBMKOPGMCG>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KFBMKOPGMCG IFHOCKPABEA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84CDC90", Offset = "0x84CC690", VA = "0x1884CDC90", Slot = "8")]
	public bool Equals(KFBMKOPGMCG EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84CDCE0", Offset = "0x84CC6E0", VA = "0x1884CDCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JIEEMKKPFCI<THasTokensTag> : COCNNJBDJBL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, KFBMKOPGMCG> OKPDJAIJHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> CKDINIJGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CAAPKKGPCNK<KFBMKOPGMCG, HashSet<object>> EHDMMFKEFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager MGCKGGMOENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem BIDNHEFEJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53DB8A0", Offset = "0x53DA2A0", VA = "0x1853DB8A0")]
	public JIEEMKKPFCI(EntityManager MGCKGGMOENE, EntityCommandBufferSystem BIDNHEFEJKL, MEBJEIOEDLD FOBNFLCOPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53D9F10", Offset = "0x53D8910", VA = "0x1853D9F10", Slot = "4")]
	public bool EKJHICGNOBA(Entity EOGGAEBALGK, object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53DAC20", Offset = "0x53D9620", VA = "0x1853DAC20", Slot = "5")]
	public bool GDKCPJFKOMJ(Entity EOGGAEBALGK, object DHNMCOFINFM, [Out] bool IBBDBJMBCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53D90C0", Offset = "0x53D7AC0", VA = "0x1853D90C0", Slot = "6")]
	public bool CKKAHAFPMLA(Entity EOGGAEBALGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53D9200", Offset = "0x53D7C00", VA = "0x1853D9200", Slot = "8")]
	public bool CKKAHAFPMLA(KFBMKOPGMCG OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x53D9B50", Offset = "0x53D8550", VA = "0x1853D9B50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53DA3A0", Offset = "0x53D8DA0", VA = "0x1853DA3A0")]
	private void EKOBDPKNIIJ(HashSet<object> JLNBHGKNAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x53DB570", Offset = "0x53D9F70", VA = "0x1853DB570")]
	private bool NLFJHPGEOKG(Entity EOGGAEBALGK, [Out] KFBMKOPGMCG OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53DA650", Offset = "0x53D9050", VA = "0x1853DA650")]
	private bool FPHCHICFFEG(Entity EOGGAEBALGK, [Out] KFBMKOPGMCG OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53DAFF0", Offset = "0x53D99F0", VA = "0x1853DAFF0")]
	private void LGJCNOPALGM(Entity EOGGAEBALGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53D9690", Offset = "0x53D8090", VA = "0x1853D9690")]
	private void DIPELICGLHM(Entity EOGGAEBALGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x53D9040", Offset = "0x53D7A40", VA = "0x1853D9040")]
	private void BJEPJNFBLIK(Entity EOGGAEBALGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53DB2F0", Offset = "0x53D9CF0", VA = "0x1853DB2F0")]
	private void MCCJIGMEKNG(Entity EOGGAEBALGK, KFBMKOPGMCG OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53D8E00", Offset = "0x53D7800", VA = "0x1853D8E00")]
	private bool AFJHMMINLIJ(KFBMKOPGMCG OFBHFOIEGGG, [Out] HashSet<object> JLNBHGKNAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x53D94B0", Offset = "0x53D7EB0", VA = "0x1853D94B0")]
	private HashSet<object> DDBNBOKAEID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KOHGCKDFIOC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AFNMEKICKEP : ABBALHKKDGK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84CCD00", Offset = "0x84CB700", VA = "0x1884CCD00")]
	public float KJFEDBCFOHO([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84CCD00", Offset = "0x84CB700", VA = "0x1884CCD00", Slot = "4")]
	private float LDBKEANDDEH([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DCJFILBBCFC : ABBALHKKDGK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84CCF80", Offset = "0x84CB980", VA = "0x1884CCF80")]
	public float KJFEDBCFOHO([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84CCF80", Offset = "0x84CB980", VA = "0x1884CCF80", Slot = "4")]
	private float LDBKEANDDEH([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NNLELNONINB : ABBALHKKDGK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xFDB4A0", Offset = "0xFD9EA0", VA = "0x180FDB4A0")]
	public float KJFEDBCFOHO([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xFDB4A0", Offset = "0xFD9EA0", VA = "0x180FDB4A0", Slot = "4")]
	private float LDBKEANDDEH([In] float3 PDKJBMPOMNC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LOPONKFKEIN : ABBALHKKDGK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14249B0", Offset = "0x14233B0", VA = "0x1814249B0")]
	public int KJFEDBCFOHO([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14249B0", Offset = "0x14233B0", VA = "0x1814249B0", Slot = "4")]
	private int DHPJPPHJENP([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CMIBNNPAELD : ABBALHKKDGK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1388890", Offset = "0x1387290", VA = "0x181388890")]
	public int KJFEDBCFOHO([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1388890", Offset = "0x1387290", VA = "0x181388890", Slot = "4")]
	private int DHPJPPHJENP([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DNNIPPEPEJF : ABBALHKKDGK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xFA22D0", Offset = "0xFA0CD0", VA = "0x180FA22D0")]
	public int KJFEDBCFOHO([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFA22D0", Offset = "0xFA0CD0", VA = "0x180FA22D0", Slot = "4")]
	private int DHPJPPHJENP([In] int3 PDKJBMPOMNC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ACCMBJLPDND : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	public ACCMBJLPDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DFHAICALGGC : SystemBase, BFNCPMFACEG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84CD0B0", Offset = "0x84CBAB0", VA = "0x1884CD0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6890", Offset = "0x3AB5290", VA = "0x183AB6890")]
	public void HFOLMJPIEAE<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6890", Offset = "0x3AB5290", VA = "0x183AB6890")]
	public void ELFKOCEINME<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84CD1A0", Offset = "0x84CBBA0", VA = "0x1884CD1A0")]
	public JobHandle NGONIPJGCFP(ReadOnlySpan<int> BJKGLLAFGOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7370", Offset = "0x3AB5D70", VA = "0x183AB7370")]
	public JobHandle MAIBFDEOLMK<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84CD150", Offset = "0x84CBB50", VA = "0x1884CD150")]
	public JobHandle MAIBFDEOLMK(ReadOnlySpan<int> BJKGLLAFGOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6A50", Offset = "0x3AB5450", VA = "0x183AB6A50")]
	public void LAGMHDGBOHK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6990", Offset = "0x3AB5390", VA = "0x183AB6990")]
	public JobHandle LAGMHDGBOHK<T>(JobHandle OFBHFOIEGGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84CD0E0", Offset = "0x84CBAE0", VA = "0x1884CD0E0")]
	public JobHandle LAGMHDGBOHK(ReadOnlySpan<int> BJKGLLAFGOK, JobHandle OFBHFOIEGGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6A50", Offset = "0x3AB5450", VA = "0x183AB6A50")]
	public void OBDJAFCELHK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7410", Offset = "0x3AB5E10", VA = "0x183AB7410")]
	public JobHandle OBDJAFCELHK<T>(JobHandle OFBHFOIEGGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD1F0", Offset = "0x84CBBF0", VA = "0x1884CD1F0")]
	public JobHandle OBDJAFCELHK(Span<int> BJKGLLAFGOK, JobHandle OFBHFOIEGGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB68E0", Offset = "0x3AB52E0", VA = "0x183AB68E0")]
	public ComponentDataFromEntity ENNLCDHECOJ<T>(bool EGONONGDDCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84CCF90", Offset = "0x84CB990", VA = "0x1884CCF90")]
	public ComponentDataFromEntity ENNLCDHECOJ(int JLDKDBJGAAK, bool EGONONGDDCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7650", Offset = "0x3AB6050", VA = "0x183AB7650")]
	public SharedComponentIndexFromEntity<T> OJGMJGBMAIN<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84CD050", Offset = "0x84CBA50", VA = "0x1884CD050")]
	[BurstCompatible]
	public ComponentTypeHandle IMEPAIFIJFF(ComponentType KOHJNJOONHP)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84CD260", Offset = "0x84CBC60", VA = "0x1884CD260")]
	public EntityExistenceLookupByEntity OMGFJJPEDPC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84CD280", Offset = "0x84CBC80", VA = "0x1884CD280", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7250", Offset = "0x3AB5C50", VA = "0x183AB7250")]
	public bool LECHJIAGCAL<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	protected DFHAICALGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class PNLKCLBINJJ : DFHAICALGGC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84CE090", Offset = "0x84CCA90", VA = "0x1884CE090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	protected PNLKCLBINJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HEBLLGMMKIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NPJBIIECFDH : EntityCommandBufferSystem, BFNCPMFACEG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MEBJEIOEDLD GCLDEHJKFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xEC0EE0", Offset = "0xEBF8E0", VA = "0x180EC0EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84CDEB0", Offset = "0x84CC8B0", VA = "0x1884CDEB0")]
	public NPJBIIECFDH(MEBJEIOEDLD HJHMNJLNNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ABBALHKKDGK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KJFEDBCFOHO([In] TFrom PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FPBAPAFCBKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMHEBGMBIL(T PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct OAIODLGGNAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes PDJGACEBODO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF60", Offset = "0x84CC960", VA = "0x1884CDF60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct JCOAPFHJJKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84CDBE0", Offset = "0x84CC5E0", VA = "0x1884CDBE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct KJADNGJMLGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType KOHJNJOONHP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84CDD30", Offset = "0x84CC730", VA = "0x1884CDD30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct ILCGEEGBNEE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x516ACE0", Offset = "0x51696E0", VA = "0x18516ACE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct AGFGGGBMPFJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> EJKNLPOFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct IPELMHBLPOJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> JGINDINMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T PDKJBMPOMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer KLHDJGCPJBB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct EMFPKAMPBIL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ABBALHKKDGK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CJANELAOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct KNFPPIFMPBF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity HCMMOLBFPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CJANELAOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JHCGPLGIGFB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84CDDB0", Offset = "0x84CC7B0", VA = "0x1884CDDB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct CGDKBGOECHA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OJOPJIHKDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> CKDNCEKIOEI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct KEHANIHMCAO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ABBALHKKDGK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> AAEIBNBADAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CJANELAOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PIBAKDADLLA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BHCINLHFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> NDKEKEIIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> CLMNNBDCLDN;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct BONGGOELCIC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BHCINLHFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> NDKEKEIIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> CLMNNBDCLDN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x668C4C0", Offset = "0x668AEC0", VA = "0x18668C4C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KOOPBHBAIJE<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> CKDNCEKIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> IDLLEBGAAJG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55096F0", Offset = "0x55080F0", VA = "0x1855096F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct AFIABNICBKA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : ABBALHKKDGK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> CKDNCEKIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> IDLLEBGAAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct ILPCFALJDJM<T, TPredicate> : IJob where T : struct where TPredicate : struct, FPBAPAFCBKJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> OGCPNELHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> CHMNFCJEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct AJEFBNLOKGD<T, TPredicate> : IJob where T : struct where TPredicate : struct, FPBAPAFCBKJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> BGEALFJEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> CKDNCEKIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate FOAIPBIEILM;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct BDCIKJPMEGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity BHCINLHFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NDKEKEIIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> HKGDFLJCAEJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84CCD10", Offset = "0x84CB710", VA = "0x1884CCD10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct IDIKHHEMJHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity BHCINLHFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> NDKEKEIIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> HKGDFLJCAEJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84CDB50", Offset = "0x84CC550", VA = "0x1884CDB50", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MJCIPDBNBMF
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class ODFIDCNJLIL
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DBB0", Offset = "0x3E3C5B0", VA = "0x183E3DBB0")]
	public static bool KDEDFOCJCHB<T>(this NativeArray<Entity> NDKEKEIIOMF, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GBCDJDCAMDM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IAJMGEHAOBH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public IAJMGEHAOBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DBMIHKFODOO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public DBMIHKFODOO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> ELHEFPAIMEL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84CD700", Offset = "0x84CC100", VA = "0x1884CD700")]
	public GBCDJDCAMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ABPKIMJNLBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ADPGAGFIJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OJPILEIKCJM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GOCBJOHMLEJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OJPILEIKCJM<TFrom> DFKFFPKHNCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> GJFINIAHPMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct BIJEDJJLKIC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct FJIPKEGAHHN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal BIJEDJJLKIC<TFrom> DFKFFPKHNCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> GJFINIAHPMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct PHOHEGFDDKN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PIDAJPGBDCN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal PHOHEGFDDKN<TFrom> DFKFFPKHNCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> GJFINIAHPMG;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct HJDAOIMACHP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct MGLBMFDPECF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal HJDAOIMACHP<TFrom> DFKFFPKHNCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> GJFINIAHPMG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LNCFPCEBNGO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IBHIIJBJPLD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CA7640", Offset = "0x3CA6040", VA = "0x183CA7640")]
	public static NativeList<T> CGGMPKNENPL<T>(this NativeArray<T> DEOLMJPICHA, Allocator POJKLAFAMOD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HLJFDKGMDBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FBIOBLANOEE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B670", Offset = "0x3C4A070", VA = "0x183C4B670")]
	[OJIFNCBFJHF]
	public static JobHandle CFMHEOKCOPF<T>(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArray<Entity> JGINDINMFKO, NativeArray<T> GPCDCFCPGFK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B740", Offset = "0x3C4A140", VA = "0x183C4B740")]
	[OJIFNCBFJHF]
	public static JobHandle CFMHEOKCOPF<T>(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArrayAsync<Entity> JGINDINMFKO, NativeArrayAsync<T> GPCDCFCPGFK, [Optional] JobHandle IHNJIBPIPCN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B550", Offset = "0x3C49F50", VA = "0x183C4B550")]
	[OJIFNCBFJHF]
	public static JobHandle CFMHEOKCOPF<T>(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArray<Entity> JGINDINMFKO, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84CD590", Offset = "0x84CBF90", VA = "0x1884CD590")]
	[OJIFNCBFJHF]
	public static JobHandle CFMHEOKCOPF(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArray<Entity> JGINDINMFKO, ComponentTypes PDJGACEBODO, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84CD440", Offset = "0x84CBE40", VA = "0x1884CD440")]
	[OJIFNCBFJHF]
	public static JobHandle CFMHEOKCOPF(this EntityCommandBufferSystem BIDNHEFEJKL, EntityCommandBuffer KLHDJGCPJBB, NativeArray<Entity> JGINDINMFKO, ComponentTypes PDJGACEBODO, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CPFFPMJBLDM
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GCDNFBFLCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84CD790", Offset = "0x84CC190", VA = "0x1884CD790")]
	[OJIFNCBFJHF]
	public static JobHandle FEPHMCAEFDM(this EntityCommandBufferSystem BIDNHEFEJKL, NativeList<Entity> JGINDINMFKO, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84CD920", Offset = "0x84CC320", VA = "0x1884CD920")]
	[OJIFNCBFJHF]
	public static JobHandle FEPHMCAEFDM(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArrayAsync<Entity> JGINDINMFKO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class EOIJICFKDMO
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE97A0", Offset = "0x3AE81A0", VA = "0x183AE97A0")]
	public static void BNEPIJJMKIE<T>(this EntityCommandBufferSystem BIDNHEFEJKL, EntityQuery PFCAELNPJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9CA0", Offset = "0x3AE86A0", VA = "0x183AE9CA0")]
	[OJIFNCBFJHF]
	public static JobHandle GHAHMFPCLBF<T>(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArrayAsync<Entity> JGINDINMFKO, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD290", Offset = "0x84CBC90", VA = "0x1884CD290")]
	[OJIFNCBFJHF]
	public static JobHandle GHAHMFPCLBF(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArrayAsync<Entity> JGINDINMFKO, ComponentType KOHJNJOONHP, [Optional] JobHandle IHNJIBPIPCN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OIHAGPAJKIH
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A4C0", Offset = "0x3E48EC0", VA = "0x183E4A4C0")]
	[OJIFNCBFJHF]
	public static JobHandle APHGLDEIDLN<T>(this EntityCommandBufferSystem BIDNHEFEJKL, NativeArray<Entity> JGINDINMFKO, NativeArray<T> GPCDCFCPGFK, JobHandle IHNJIBPIPCN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NENBNBMIBFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FEBFACGAHKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CAJJOICBOJF
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A60740", Offset = "0x3A5F140", VA = "0x183A60740")]
	public static NativeArray<T> JAPCIOKEODG<T>(this NativeList<Entity> DEOLMJPICHA, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A603C0", Offset = "0x3A5EDC0", VA = "0x183A603C0")]
	public static NativeArray<T> JAPCIOKEODG<T>(this NativeArray<Entity> DEOLMJPICHA, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84CCDA0", Offset = "0x84CB7A0", VA = "0x1884CCDA0")]
	public static NativeArray<Entity> ADMMMDECEKI(this NativeArray<Entity> DEOLMJPICHA, EntityManager MGCKGGMOENE, ComponentType KOHJNJOONHP, Allocator POJKLAFAMOD = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3A602C0", Offset = "0x3A5ECC0", VA = "0x183A602C0")]
	public static NativeArray<T> DNLFLBEEHCN<T>(this NativeArray<Entity> DEOLMJPICHA, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CHAKCLCDNML
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GEHMOGCIACE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct JFNOIIGCKCF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GEHMOGCIACE<TFrom> GJFINIAHPMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FBGOPPGGHDE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct PHNHNHDNGCA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public FBGOPPGGHDE<TFrom> GJFINIAHPMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct PKJECBHKOMF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct FKLAJKEBAGG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PKJECBHKOMF<TFrom> GJFINIAHPMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> BGEALFJEBHK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JPBMNIMDCNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class INNOIKMMCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct JHFACCDDNKD : ABBALHKKDGK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> NIEOABOKDCM;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84CDC80", Offset = "0x84CC680", VA = "0x1884CDC80")]
		[BurstCompatible]
		public Entity KJFEDBCFOHO([In] Entity PDKJBMPOMNC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84CDC80", Offset = "0x84CC680", VA = "0x1884CDC80", Slot = "4")]
		private Entity KHIOJAKBIGP([In] Entity PDKJBMPOMNC)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class EHBBKBGBMHO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct IOBIIMEAJEH<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5170330", Offset = "0x516ED30", VA = "0x185170330", Slot = "4")]
		public int Compare((TKey, TValue) IECENJOJFJH, (TKey, TValue) OFOCBNJJIJE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AE13B0", Offset = "0x3ADFDB0", VA = "0x183AE13B0")]
	public static void PDDPFLLMGBF<TKey, TValue>(NativeList<TKey> IGGFLPKFMEB, NativeList<TValue> EJKNLPOFFNN) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AE11F0", Offset = "0x3ADFBF0", VA = "0x183AE11F0")]
	public static void PDDPFLLMGBF<TKey, TValue>(NativeArray<TKey> IGGFLPKFMEB, NativeArray<TValue> EJKNLPOFFNN) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1620", Offset = "0x3AE0020", VA = "0x183AE1620")]
	public static void PDDPFLLMGBF<TKey, TValue, U>(NativeArray<TKey> IGGFLPKFMEB, NativeArray<TValue> EJKNLPOFFNN, U IHMHAALFNHJ) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JBCJCJOEDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct AKPIJGGPKHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> OGCPNELHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct ADHHAAJIHGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> OGCPNELHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PAECGHELDFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> OGCPNELHGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> BGEALFJEBHK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GBCMAEOMIJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AOOCNLJHMFJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NBJMEMBKKJM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct PNPMKJIMEFI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct HJDNIHDCECO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> BGEALFJEBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NGGNBCLGDEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator POJKLAFAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> BGEALFJEBHK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MFPPLEADJJD
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class JCBHBKNCIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3AB0", Offset = "0x3CF24B0", VA = "0x183CF3AB0")]
	public static NativeList<Entity> MOBOIDMGCKM<T>(this NativeList<Entity> NDKEKEIIOMF, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CF34B0", Offset = "0x3CF1EB0", VA = "0x183CF34B0")]
	public static NativeList<Entity> MOBOIDMGCKM<T>(this NativeArray<Entity> NDKEKEIIOMF, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class CNCMFBPANML
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DE20", Offset = "0x3A6C820", VA = "0x183A6DE20")]
	public static NativeList<Entity> CCLGCNAPCDP<T>(this NativeArray<Entity> NDKEKEIIOMF, EntityManager MGCKGGMOENE, Allocator POJKLAFAMOD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class DGPKPMBKAEC
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct POICICOPEJG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> JCEJMKLBKKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct PAPJCBJIEDE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> JCEJMKLBKKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct FEJMFNGFLFP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ABBALHKKDGK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> JCEJMKLBKKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KBFDCOKDOMI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, ABBALHKKDGK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> JCEJMKLBKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector JKKJDLBEJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int FILGHJLFKAL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct APNGLJPHBBO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ABBALHKKDGK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private KBFDCOKDOMI<TSrc, TValue, TSelector> MEKDEFIHOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue DIGKEKAOIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int EMMDOKDGNJD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DBOBDNHHGDM
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EJIGIDIFLGP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> JCEJMKLBKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int EMMDOKDGNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int LKHEALEFFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T DIGKEKAOIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T LMDHINEDJEC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NFNHCBCLHDC OLBEFFHDGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4941140", Offset = "0x493FB40", VA = "0x184941140")]
			get
			{
				return default(NFNHCBCLHDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T CBFGKHHCIFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, NFNHCBCLHDC) CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4941780", Offset = "0x4940180", VA = "0x184941780")]
			get
			{
				return default((T, NFNHCBCLHDC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4941830", Offset = "0x4940230", VA = "0x184941830")]
		public EJIGIDIFLGP(NativeArray<T> JCEJMKLBKKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4941530", Offset = "0x493FF30", VA = "0x184941530")]
		public EJIGIDIFLGP<T> IBBMHAHFLHH()
		{
			return default(EJIGIDIFLGP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4941240", Offset = "0x493FC40", VA = "0x184941240")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x42AFF40", Offset = "0x42AE940", VA = "0x1842AFF40")]
		public KEKPHBBBKAC<T, TComparer> KHBJBINIKKB<TComparer>([Optional] TComparer IHMHAALFNHJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KEKPHBBBKAC<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct KEKPHBBBKAC<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> JCEJMKLBKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int EMMDOKDGNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int LKHEALEFFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T DIGKEKAOIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T LMDHINEDJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer IHMHAALFNHJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NFNHCBCLHDC OLBEFFHDGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4941140", Offset = "0x493FB40", VA = "0x184941140")]
			get
			{
				return default(NFNHCBCLHDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T CBFGKHHCIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, NFNHCBCLHDC range) CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4941780", Offset = "0x4940180", VA = "0x184941780")]
			get
			{
				return default((T, NFNHCBCLHDC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x54E6F50", Offset = "0x54E5950", VA = "0x1854E6F50")]
		public KEKPHBBBKAC(NativeArray<T> JCEJMKLBKKB, TComparer IHMHAALFNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3D43830", Offset = "0x3D42230", VA = "0x183D43830")]
		public KEKPHBBBKAC<T, TComparer> IBBMHAHFLHH()
		{
			return default(KEKPHBBBKAC<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x54E6D90", Offset = "0x54E5790", VA = "0x1854E6D90")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AABDA0", Offset = "0x3AAA7A0", VA = "0x183AABDA0")]
	public static EJIGIDIFLGP<T> HHLLMHLILEM<T>(this NativeArray<T> JCEJMKLBKKB) where T : struct
	{
		return default(EJIGIDIFLGP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KALADCHAAOE
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AKIEGLHPPNJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BJKBKLMNPLG<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OMBEAFDIGDF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BJKBKLMNPLG<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F2A990", Offset = "0x4F29390", VA = "0x184F2A990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public OMBEAFDIGDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5A29110", Offset = "0x5A27B10", VA = "0x185A29110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5A292C0", Offset = "0x5A27CC0", VA = "0x185A292C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> JHBJMLMCDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream AKDFBDNJGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream JMDNHCKKIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf IKAEKOBLDMB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x65A1BC0", Offset = "0x65A05C0", VA = "0x1865A1BC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65A1C00", Offset = "0x65A0600", VA = "0x1865A1C00", Slot = "4")]
	[IteratorStateMachine(typeof(BJKBKLMNPLG<>.OMBEAFDIGDF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x65A1CF0", Offset = "0x65A06F0", VA = "0x1865A1CF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KIMHKGLHOCD<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] AEJOONCILAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf IKAEKOBLDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream AKDFBDNJGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream HMGDBBMHGFK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x54F7510", Offset = "0x54F5F10", VA = "0x1854F7510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct OIGELICABOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream AKDFBDNJGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream JMDNHCKKIFE;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84CE050", Offset = "0x84CCA50", VA = "0x1884CE050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct ICPMPLJIPOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] AEJOONCILAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream AKDFBDNJGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream HMGDBBMHGFK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84CDA20", Offset = "0x84CC420", VA = "0x1884CDA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LPKFBMMACMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BGKODIEOFAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum BAJLLJABCGG
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
internal static class ALOCIEHLMNH
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
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
