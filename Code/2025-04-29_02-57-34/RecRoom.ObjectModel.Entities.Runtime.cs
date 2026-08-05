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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C74730", Offset = "0x7C73B30", VA = "0x187C74730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C73A30", Offset = "0x7C72E30", VA = "0x187C73A30")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EFKDPLHJHPM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JJLCDLHMNPI DKLOOEGDBJA
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
public interface BIENIAKCEGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJAAGANNMEE(Entity BGFOMMJBGIM, object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PECDJDPFNIB(Entity BGFOMMJBGIM, object PAHPIGHLKFG, [Out] bool CIPCIPBBMCG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GONENFDIEMF(Entity BGFOMMJBGIM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MBAHMJKKHPF<TComponentData, TValue> : KLIAOGEDPML<TValue>, IDisposable where TComponentData : struct, EFKDPLHJHPM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class IIIBIGHKMPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> ANHMDLEGCDL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FBDCOBNEAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3F693A0", Offset = "0x3F687A0", VA = "0x183F693A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4A632A0", Offset = "0x4A626A0", VA = "0x184A632A0")]
		public bool BALHHNMHAFN([Out] TValue OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4A633B0", Offset = "0x4A627B0", VA = "0x184A633B0")]
		public void FGAAHPGCDNG(object PAHPIGHLKFG, TValue OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4A635A0", Offset = "0x4A629A0", VA = "0x184A635A0")]
		public bool NMPKBAOEGPN(object PAHPIGHLKFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4A634A0", Offset = "0x4A628A0", VA = "0x184A634A0")]
		public int MJHCAIKEHEA(object PAHPIGHLKFG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4A63660", Offset = "0x4A62A60", VA = "0x184A63660")]
		public IIIBIGHKMPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<IIIBIGHKMPP> DAPLDLFIHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DCJAOLDOCPL<JJLCDLHMNPI, IIIBIGHKMPP> IOCDNMMPAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager IBLGEGBFEIJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50A9A60", Offset = "0x50A8E60", VA = "0x1850A9A60")]
	public MBAHMJKKHPF(EntityManager IBLGEGBFEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50A92F0", Offset = "0x50A86F0", VA = "0x1850A92F0", Slot = "4")]
	public void EJAAGANNMEE(Entity BGFOMMJBGIM, object PAHPIGHLKFG, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50A9850", Offset = "0x50A8C50", VA = "0x1850A9850", Slot = "5")]
	public bool PECDJDPFNIB(Entity BGFOMMJBGIM, object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50A91B0", Offset = "0x50A85B0", VA = "0x1850A91B0", Slot = "6")]
	public bool BALHHNMHAFN(Entity BGFOMMJBGIM, [Out] TValue OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x50A92D0", Offset = "0x50A86D0", VA = "0x1850A92D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50A9480", Offset = "0x50A8880", VA = "0x1850A9480")]
	private void ELDGMLMCNAP(IIIBIGHKMPP KHKAANKHMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50A9780", Offset = "0x50A8B80", VA = "0x1850A9780")]
	private bool KOHAEFIMMMJ(Entity BGFOMMJBGIM, [Out] JJLCDLHMNPI PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50A9680", Offset = "0x50A8A80", VA = "0x1850A9680")]
	private void JPGJLBJOPII(Entity BGFOMMJBGIM, JJLCDLHMNPI PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50A9190", Offset = "0x50A8590", VA = "0x1850A9190")]
	private bool AFGJLEAMDLJ(JJLCDLHMNPI PAOMPCHHBKF, [Out] IIIBIGHKMPP KHKAANKHMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50A9550", Offset = "0x50A8950", VA = "0x1850A9550")]
	private IIIBIGHKMPP HILMBKOAABO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KLIAOGEDPML<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJAAGANNMEE(Entity BGFOMMJBGIM, object PAHPIGHLKFG, TValue OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PECDJDPFNIB(Entity BGFOMMJBGIM, object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BALHHNMHAFN(Entity BGFOMMJBGIM, [Out] TValue OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JJLCDLHMNPI : KPKDAMONEJC, IEquatable<JJLCDLHMNPI>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JJLCDLHMNPI NKGDFHKGFHA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LGHILPCJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C74290", Offset = "0x7C73690", VA = "0x187C74290", Slot = "8")]
	public bool Equals(JJLCDLHMNPI DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C742E0", Offset = "0x7C736E0", VA = "0x187C742E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GOFAKIMNPJF<THasTokensTag> : BIENIAKCEGD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, JJLCDLHMNPI> MLILLKKAFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> DAPLDLFIHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DCJAOLDOCPL<JJLCDLHMNPI, HashSet<object>> IOCDNMMPAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager IBLGEGBFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem NGFDHLPOPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48D1090", Offset = "0x48D0490", VA = "0x1848D1090")]
	public GOFAKIMNPJF(EntityManager IBLGEGBFEIJ, EntityCommandBufferSystem NGFDHLPOPGO, LMKAPNBAFDO CALNLOGPAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48CE460", Offset = "0x48CD860", VA = "0x1848CE460", Slot = "4")]
	public bool EJAAGANNMEE(Entity BGFOMMJBGIM, object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48D0C90", Offset = "0x48D0090", VA = "0x1848D0C90", Slot = "5")]
	public bool PECDJDPFNIB(Entity BGFOMMJBGIM, object PAHPIGHLKFG, [Out] bool CIPCIPBBMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48CF320", Offset = "0x48CE720", VA = "0x1848CF320", Slot = "6")]
	public bool GONENFDIEMF(Entity BGFOMMJBGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x48CF1A0", Offset = "0x48CE5A0", VA = "0x1848CF1A0", Slot = "8")]
	public bool GONENFDIEMF(JJLCDLHMNPI PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48CE360", Offset = "0x48CD760", VA = "0x1848CE360", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48CECC0", Offset = "0x48CE0C0", VA = "0x1848CECC0")]
	private void ELDGMLMCNAP(HashSet<object> KHKAANKHMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48CFF70", Offset = "0x48CF370", VA = "0x1848CFF70")]
	private bool KOHAEFIMMMJ(Entity BGFOMMJBGIM, [Out] JJLCDLHMNPI PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48D01E0", Offset = "0x48CF5E0", VA = "0x1848D01E0")]
	private bool KPMOBGABLOB(Entity BGFOMMJBGIM, [Out] JJLCDLHMNPI PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48CF880", Offset = "0x48CEC80", VA = "0x1848CF880")]
	private void HDGIHABHCJJ(Entity BGFOMMJBGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48D0560", Offset = "0x48CF960", VA = "0x1848D0560")]
	private void OPHDBAFOLLA(Entity BGFOMMJBGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x48CEF20", Offset = "0x48CE320", VA = "0x1848CEF20")]
	private void GCIBIOLGIBF(Entity BGFOMMJBGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48CFD60", Offset = "0x48CF160", VA = "0x1848CFD60")]
	private void JPGJLBJOPII(Entity BGFOMMJBGIM, JJLCDLHMNPI PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48CEE60", Offset = "0x48CE260", VA = "0x1848CEE60")]
	private bool FKKPJJDHMIG(JJLCDLHMNPI PAOMPCHHBKF, [Out] HashSet<object> KHKAANKHMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48CF990", Offset = "0x48CED90", VA = "0x1848CF990")]
	private HashSet<object> HILMBKOAABO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CDCEFBKDLLA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EEAEPHBAAPM : FCEHECGFJPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C73800", Offset = "0x7C72C00", VA = "0x187C73800")]
	public float GMNPIGNGEHD([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C73800", Offset = "0x7C72C00", VA = "0x187C73800", Slot = "4")]
	private float OOKJHBHNGHA([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GLDJIIJHPAF : FCEHECGFJPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C73D20", Offset = "0x7C73120", VA = "0x187C73D20")]
	public float GMNPIGNGEHD([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C73D20", Offset = "0x7C73120", VA = "0x187C73D20", Slot = "4")]
	private float OOKJHBHNGHA([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CIPCDFDANDE : FCEHECGFJPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xE26690", Offset = "0xE25A90", VA = "0x180E26690")]
	public float GMNPIGNGEHD([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE26690", Offset = "0xE25A90", VA = "0x180E26690", Slot = "4")]
	private float OOKJHBHNGHA([In] float3 OOEMJLHLIHJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IMCNMGFPKJA : FCEHECGFJPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50")]
	public int GMNPIGNGEHD([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50", Slot = "4")]
	private int BLGCGHLKNHN([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OMNMFJAJLLH : FCEHECGFJPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEB8A90", Offset = "0xEB7E90", VA = "0x180EB8A90")]
	public int GMNPIGNGEHD([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xEB8A90", Offset = "0xEB7E90", VA = "0x180EB8A90", Slot = "4")]
	private int BLGCGHLKNHN([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KCFECMMMGLI : FCEHECGFJPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xE0AB10", Offset = "0xE09F10", VA = "0x180E0AB10")]
	public int GMNPIGNGEHD([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE0AB10", Offset = "0xE09F10", VA = "0x180E0AB10", Slot = "4")]
	private int BLGCGHLKNHN([In] int3 OOEMJLHLIHJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LMHAPHEEBJH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5BD0", Offset = "0x1FE4FD0", VA = "0x181FE5BD0")]
	public LMHAPHEEBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class IEAMNHGIGNJ : SystemBase, HNMGONDIAPD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C73E70", Offset = "0x7C73270", VA = "0x187C73E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3725CF0", Offset = "0x37250F0", VA = "0x183725CF0")]
	public void ANIBPODCGHA<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3725CF0", Offset = "0x37250F0", VA = "0x183725CF0")]
	public void PCEDLDLEPLM<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C74050", Offset = "0x7C73450", VA = "0x187C74050")]
	public JobHandle IDNDBKNCOIN(ReadOnlySpan<int> MDMBMEEECAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3725E20", Offset = "0x3725220", VA = "0x183725E20")]
	public JobHandle CJDBFBAJMDI<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C73EA0", Offset = "0x7C732A0", VA = "0x187C73EA0")]
	public JobHandle CJDBFBAJMDI(ReadOnlySpan<int> MDMBMEEECAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3725ED0", Offset = "0x37252D0", VA = "0x183725ED0")]
	public void FJBBFHILMAF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3726200", Offset = "0x3725600", VA = "0x183726200")]
	public JobHandle FJBBFHILMAF<T>(JobHandle PAOMPCHHBKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C73F80", Offset = "0x7C73380", VA = "0x187C73F80")]
	public JobHandle FJBBFHILMAF(ReadOnlySpan<int> MDMBMEEECAA, JobHandle PAOMPCHHBKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3725ED0", Offset = "0x37252D0", VA = "0x183725ED0")]
	public void EFGLOKECLDG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3725F60", Offset = "0x3725360", VA = "0x183725F60")]
	public JobHandle EFGLOKECLDG<T>(JobHandle PAOMPCHHBKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C73F10", Offset = "0x7C73310", VA = "0x187C73F10")]
	public JobHandle EFGLOKECLDG(Span<int> MDMBMEEECAA, JobHandle PAOMPCHHBKF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3725C20", Offset = "0x3725020", VA = "0x183725C20")]
	public ComponentDataFromEntity ACKLFJOFIAB<T>(bool BOACKDBINIF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73DB0", Offset = "0x7C731B0", VA = "0x187C73DB0")]
	public ComponentDataFromEntity ACKLFJOFIAB(int EMPFLKDGLPP, bool BOACKDBINIF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3725D50", Offset = "0x3725150", VA = "0x183725D50")]
	public SharedComponentIndexFromEntity<T> BMFKKELBHKD<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C73FF0", Offset = "0x7C733F0", VA = "0x187C73FF0")]
	[BurstCompatible]
	public ComponentTypeHandle FKEONNNLBEJ(ComponentType APHNCBHIIBG)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C73EF0", Offset = "0x7C732F0", VA = "0x187C73EF0")]
	public EntityExistenceLookupByEntity DCKLCHJANIN()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C740A0", Offset = "0x7C734A0", VA = "0x187C740A0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3726AC0", Offset = "0x3725EC0", VA = "0x183726AC0")]
	public bool PCFCOHLOFNG<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5BD0", Offset = "0x1FE4FD0", VA = "0x181FE5BD0")]
	protected IEAMNHGIGNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class MLOFKEBCGJN : IEAMNHGIGNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C746F0", Offset = "0x7C73AF0", VA = "0x187C746F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5BD0", Offset = "0x1FE4FD0", VA = "0x181FE5BD0")]
	protected MLOFKEBCGJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IKFKJKLLGNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OAHDBCOONCO : EntityCommandBufferSystem, HNMGONDIAPD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LMKAPNBAFDO BKFDGJHNENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD37C90", Offset = "0xD37090", VA = "0x180D37C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C747B0", Offset = "0x7C73BB0", VA = "0x187C747B0")]
	public OAHDBCOONCO(LMKAPNBAFDO KIBGFJNEFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FCEHECGFJPA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo GMNPIGNGEHD([In] TFrom OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CCNGIMEFGLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBEANDHCNMK(T OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct AIGHAOIFIJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes ODOOKFBDJNN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C73550", Offset = "0x7C72950", VA = "0x187C73550", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct EAKPGFBFDNC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C73760", Offset = "0x7C72B60", VA = "0x187C73760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct HKEIPMPFHCJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType APHNCBHIIBG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73D30", Offset = "0x7C73130", VA = "0x187C73D30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct KADPBCLDMEF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4D72300", Offset = "0x4D71700", VA = "0x184D72300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct NECCNMDLBGK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> LMNAOMMMDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct PAJGEPEBBPF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OOEMJLHLIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer OAHFMECOBEB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct GCCIOKAEPKJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FCEHECGFJPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> EONOPFFKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap PDHMHKIHKPF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MEPDKLMOJEP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity EEGGKFGKCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> EONOPFFKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int BBKIGPALIKO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C745F0", Offset = "0x7C739F0", VA = "0x187C745F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct MHODGPFCCNO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FNDFFOFLPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> MBGONBCGLOK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct MJCIKKEBFAP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FCEHECGFJPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> KHBKKEFLDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> EONOPFFKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap PDHMHKIHKPF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct NFHMENJJDOP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBGDLHEEAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> ECECJJMCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> JCBOMEOKIHF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct KIOPPDCBCKK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBGDLHEEAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> ECECJJMCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> JCBOMEOKIHF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4DF7110", Offset = "0x4DF6510", VA = "0x184DF7110", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct CMPOFLLIAAK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> MBGONBCGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> CLLELHMJGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6632980", Offset = "0x6631D80", VA = "0x186632980", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct DJLBDJNPOII<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FCEHECGFJPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> MBGONBCGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> CLLELHMJGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap PDHMHKIHKPF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct AEOAFKFJMKK<T, TPredicate> : IJob where T : struct where TPredicate : struct, CCNGIMEFGLG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> PANOEKNFLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> JNPMHBMCHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate PDHMHKIHKPF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BOCOPNDFHDF<T, TPredicate> : IJob where T : struct where TPredicate : struct, CCNGIMEFGLG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> NHFJJIOKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> MBGONBCGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate PDHMHKIHKPF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CEJIFDAKLBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity JBGDLHEEAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> ECECJJMCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NJNMGPOMNBO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C73640", Offset = "0x7C72A40", VA = "0x187C73640", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct DJMOOBJMNJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity JBGDLHEEAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> ECECJJMCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> NJNMGPOMNBO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C736D0", Offset = "0x7C72AD0", VA = "0x187C736D0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ADMGAAMKHGC
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KGAGBMMBOIN
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3785620", Offset = "0x3784A20", VA = "0x183785620")]
	public static bool PADHAALJJBP<T>(this NativeArray<Entity> ECECJJMCMOP, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ELKJAGBLFKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ILCNGCHKCMP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public ILCNGCHKCMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CCHKMGPANCJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public CCHKMGPANCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> GEDKEILPAKO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C739A0", Offset = "0x7C72DA0", VA = "0x187C739A0")]
	public ELKJAGBLFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NBNHEGLOLKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HNELHCDEGCG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DIHJLBEHCDJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LBACAHKDDDH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal DIHJLBEHCDJ<TFrom> GEFLCBDBKHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> BHCEDEKBMHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct ELOIJODJGOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct APEICNAMPHK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal ELOIJODJGOG<TFrom> GEFLCBDBKHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> BHCEDEKBMHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct IPKPMNGCGNM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ECCBJACANGF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal IPKPMNGCGNM<TFrom> GEFLCBDBKHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> BHCEDEKBMHE;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PKJIIKKAKKG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct MNGBNEFFDJJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal PKJIIKKAKKG<TFrom> GEFLCBDBKHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> BHCEDEKBMHE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DIEAPOFNEND
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FMDFJHKGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3691870", Offset = "0x3690C70", VA = "0x183691870")]
	public static NativeList<T> HKDMCFMJNCA<T>(this NativeArray<T> FELGEJPEPGN, Allocator LMMGDELCIGC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CBBLGKOPCEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JOIMMEHOBGN
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3763950", Offset = "0x3762D50", VA = "0x183763950")]
	[DALCMJIGFLO]
	public static JobHandle MKNMCKEKDCA<T>(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArray<Entity> EOFNKKAANKG, NativeArray<T> AOFGGGKINCN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37637D0", Offset = "0x3762BD0", VA = "0x1837637D0")]
	[DALCMJIGFLO]
	public static JobHandle MKNMCKEKDCA<T>(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArrayAsync<Entity> EOFNKKAANKG, NativeArrayAsync<T> AOFGGGKINCN, [Optional] JobHandle LLKBKEKCHLL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37636A0", Offset = "0x3762AA0", VA = "0x1837636A0")]
	[DALCMJIGFLO]
	public static JobHandle MKNMCKEKDCA<T>(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArray<Entity> EOFNKKAANKG, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C74330", Offset = "0x7C73730", VA = "0x187C74330")]
	[DALCMJIGFLO]
	public static JobHandle MKNMCKEKDCA(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArray<Entity> EOFNKKAANKG, ComponentTypes ODOOKFBDJNN, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C744A0", Offset = "0x7C738A0", VA = "0x187C744A0")]
	[DALCMJIGFLO]
	public static JobHandle MKNMCKEKDCA(this EntityCommandBufferSystem NGFDHLPOPGO, EntityCommandBuffer OAHFMECOBEB, NativeArray<Entity> EOFNKKAANKG, ComponentTypes ODOOKFBDJNN, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MGCDOPHDILK
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FBPIBJPJMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C73A90", Offset = "0x7C72E90", VA = "0x187C73A90")]
	[DALCMJIGFLO]
	public static JobHandle IHAILADJLPP(this EntityCommandBufferSystem NGFDHLPOPGO, NativeList<Entity> EOFNKKAANKG, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C73C20", Offset = "0x7C73020", VA = "0x187C73C20")]
	[DALCMJIGFLO]
	public static JobHandle IHAILADJLPP(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArrayAsync<Entity> EOFNKKAANKG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class EECOOMEPEJD
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3527800", Offset = "0x3526C00", VA = "0x183527800")]
	[DALCMJIGFLO]
	public static JobHandle BFJJMJJHLJK<T>(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArrayAsync<Entity> EOFNKKAANKG, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C73810", Offset = "0x7C72C10", VA = "0x187C73810")]
	[DALCMJIGFLO]
	public static JobHandle BFJJMJJHLJK(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArrayAsync<Entity> EOFNKKAANKG, ComponentType APHNCBHIIBG, [Optional] JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FLJFNMPPCMK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36913F0", Offset = "0x36907F0", VA = "0x1836913F0")]
	[DALCMJIGFLO]
	public static JobHandle FCBGMBKMAMM<T>(this EntityCommandBufferSystem NGFDHLPOPGO, NativeArray<Entity> EOFNKKAANKG, NativeArray<T> AOFGGGKINCN, JobHandle LLKBKEKCHLL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FIOHMIFCJFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MCFCKDGAGFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JGPECJJJBIE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3753BF0", Offset = "0x3752FF0", VA = "0x183753BF0")]
	public static NativeArray<T> BJFDDEMCFGC<T>(this NativeList<Entity> FELGEJPEPGN, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3753830", Offset = "0x3752C30", VA = "0x183753830")]
	public static NativeArray<T> BJFDDEMCFGC<T>(this NativeArray<Entity> FELGEJPEPGN, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C740B0", Offset = "0x7C734B0", VA = "0x187C740B0")]
	public static NativeArray<Entity> PIPMGDPPHAK(this NativeArray<Entity> FELGEJPEPGN, EntityManager IBLGEGBFEIJ, ComponentType APHNCBHIIBG, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3754220", Offset = "0x3753620", VA = "0x183754220")]
	public static NativeArray<T> CPFLNAFFBPA<T>(this NativeArray<Entity> FELGEJPEPGN, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CAMBBAOFLIE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct HHOAKINMKIF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct OMJKAKNNOLB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HHOAKINMKIF<TFrom> BHCEDEKBMHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FHDNBHAHEHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LCIOMHANOFH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public FHDNBHAHEHE<TFrom> BHCEDEKBMHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct DNOEDDLPCGJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct HEGJGIFJEGD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public DNOEDDLPCGJ<TFrom> BHCEDEKBMHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> NHFJJIOKOBE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FKPCPOKAIKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DPFHJDJDJFO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NCJEMMLJDIH : FCEHECGFJPA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C74720", Offset = "0x7C73B20", VA = "0x187C74720")]
		[BurstCompatible]
		public Entity GMNPIGNGEHD([In] Entity OOEMJLHLIHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C74720", Offset = "0x7C73B20", VA = "0x187C74720", Slot = "4")]
		private Entity IPFOOJIBMCA([In] Entity OOEMJLHLIHJ)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PKDKEBMKAAN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct KBHOENOFHII<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4D73470", Offset = "0x4D72870", VA = "0x184D73470", Slot = "4")]
		public int Compare((TKey, TValue) COBPEJEHIHC, (TKey, TValue) CEJJJCAALLM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38C43B0", Offset = "0x38C37B0", VA = "0x1838C43B0")]
	public static void GJBMANCDLFG<TKey, TValue>(NativeList<TKey> DDDCIKMDMJA, NativeList<TValue> LMNAOMMMDJP) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38C3FA0", Offset = "0x38C33A0", VA = "0x1838C3FA0")]
	public static void GJBMANCDLFG<TKey, TValue>(NativeArray<TKey> DDDCIKMDMJA, NativeArray<TValue> LMNAOMMMDJP) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38C4170", Offset = "0x38C3570", VA = "0x1838C4170")]
	public static void GJBMANCDLFG<TKey, TValue, U>(NativeArray<TKey> DDDCIKMDMJA, NativeArray<TValue> LMNAOMMMDJP, U OJDBNFPGELL) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OBJLMAJCEEH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct APMCNHCMKMF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> PANOEKNFLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IMOPNCDLKAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> PANOEKNFLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct GJDHDHFCAEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> PANOEKNFLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> NHFJJIOKOBE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IMFAFLEMOKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JDDNKDKJLCK
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct IKIAMMENDCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct DCCIPKBBKCA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct MHEKFPIBGAK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> NHFJJIOKOBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct IBLKCPNMEKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator LMMGDELCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> NHFJJIOKOBE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JCOJDFIFMDL
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FBHEKOAJKHC
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3684160", Offset = "0x3683560", VA = "0x183684160")]
	public static NativeList<Entity> KOJHOILKDBJ<T>(this NativeList<Entity> ECECJJMCMOP, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3683B20", Offset = "0x3682F20", VA = "0x183683B20")]
	public static NativeList<Entity> KOJHOILKDBJ<T>(this NativeArray<Entity> ECECJJMCMOP, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class KBNLHOJDHAC
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3784010", Offset = "0x3783410", VA = "0x183784010")]
	public static NativeList<Entity> POCBBPJLLBB<T>(this NativeArray<Entity> ECECJJMCMOP, EntityManager IBLGEGBFEIJ, Allocator LMMGDELCIGC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class NKIFBJKJLOG
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct PGANBPBIHFP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IMLJIFPAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct IFDPBCFMBHD<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> IMLJIFPAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct DAMGPJMMKBK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FCEHECGFJPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> IMLJIFPAFGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CPLBAFAMNGA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FCEHECGFJPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> IMLJIFPAFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector COHEHIGELBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int COPLIEINKOF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ACENJNDIILP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FCEHECGFJPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CPLBAFAMNGA<TSrc, TValue, TSelector> KJLPEEACILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue PCAFPIGDLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NHKONNPHPEL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class JHNIGKHLBGM
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct NNLHJDAPCPN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> IMLJIFPAFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int NHKONNPHPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int BIJJBKNGFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T PCAFPIGDLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T JNOKAAOBBCA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OIJNMGBLDKP OPFHOPMIDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x439E780", Offset = "0x439DB80", VA = "0x18439E780")]
			get
			{
				return default(OIJNMGBLDKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T KOOLINNNAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, OIJNMGBLDKP) CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x439E6D0", Offset = "0x439DAD0", VA = "0x18439E6D0")]
			get
			{
				return default((T, OIJNMGBLDKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x522E700", Offset = "0x522DB00", VA = "0x18522E700")]
		public NNLHJDAPCPN(NativeArray<T> IMLJIFPAFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x36857E0", Offset = "0x3684BE0", VA = "0x1836857E0")]
		public NNLHJDAPCPN<T> PMMOLBDEIOM()
		{
			return default(NNLHJDAPCPN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x522E610", Offset = "0x522DA10", VA = "0x18522E610")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D690", Offset = "0x3D9CA90", VA = "0x183D9D690")]
		public EIJABEOMDHI<T, TComparer> BPEAMGIEAKI<TComparer>([Optional] TComparer OJDBNFPGELL) where TComparer : struct, IEqualityComparer<T>
		{
			return default(EIJABEOMDHI<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct EIJABEOMDHI<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> IMLJIFPAFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int NHKONNPHPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int BIJJBKNGFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T PCAFPIGDLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T JNOKAAOBBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer OJDBNFPGELL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OIJNMGBLDKP OPFHOPMIDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x439E780", Offset = "0x439DB80", VA = "0x18439E780")]
			get
			{
				return default(OIJNMGBLDKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T KOOLINNNAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, OIJNMGBLDKP range) CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x439E6D0", Offset = "0x439DAD0", VA = "0x18439E6D0")]
			get
			{
				return default((T, OIJNMGBLDKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x439E9C0", Offset = "0x439DDC0", VA = "0x18439E9C0")]
		public EIJABEOMDHI(NativeArray<T> IMLJIFPAFGH, TComparer OJDBNFPGELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x439E9A0", Offset = "0x439DDA0", VA = "0x18439E9A0")]
		public EIJABEOMDHI<T, TComparer> PMMOLBDEIOM()
		{
			return default(EIJABEOMDHI<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x439E8F0", Offset = "0x439DCF0", VA = "0x18439E8F0")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37554D0", Offset = "0x37548D0", VA = "0x1837554D0")]
	public static NNLHJDAPCPN<T> EDMPAFBLKBD<T>(this NativeArray<T> IMLJIFPAFGH) where T : struct
	{
		return default(NNLHJDAPCPN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface FINCDILFIDD
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AEMEMOLOANF
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct FLPDJOKEFNG<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JNIDBKOEIAN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FLPDJOKEFNG<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x484D230", Offset = "0x484C630", VA = "0x18484D230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public JNIDBKOEIAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4CBDCD0", Offset = "0x4CBD0D0", VA = "0x184CBDCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4CBDEB0", Offset = "0x4CBD2B0", VA = "0x184CBDEB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> LEIHHPCCOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream AJOPCIKNIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream AOJHOGGCMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf KKMKNNENHBP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47EBE30", Offset = "0x47EB230", VA = "0x1847EBE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47EBE70", Offset = "0x47EB270", VA = "0x1847EBE70", Slot = "4")]
	[IteratorStateMachine(typeof(FLPDJOKEFNG<>.JNIDBKOEIAN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47EBF70", Offset = "0x47EB370", VA = "0x1847EBF70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KBAAFHEGDMP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] HDBNDELHALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf KKMKNNENHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream AJOPCIKNIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream MCMFLBCMKOL;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D72CB0", Offset = "0x4D720B0", VA = "0x184D72CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct FBDJOENJKDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream AJOPCIKNIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream AOJHOGGCMOG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C73A50", Offset = "0x7C72E50", VA = "0x187C73A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct PFKDLEEEADB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] HDBNDELHALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream AJOPCIKNIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream MCMFLBCMKOL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C747E0", Offset = "0x7C73BE0", VA = "0x187C747E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IEKGCJFANNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class KKMEOHFIJNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum IHIOEKNKCNL
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
internal static class CNNLNNHHCAI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PBFMMKCDNDG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PBFMMKCDNDG()
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
