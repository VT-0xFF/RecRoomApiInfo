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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x627AEA0", Offset = "0x627A2A0", VA = "0x18627AEA0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NFFCFMODGMN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPABGPMFAGJ MBGNOEBAOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CICPACLDJKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOENKMGNAM(Entity OGLHBJLEIOC, object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHHGINLDKJA(Entity OGLHBJLEIOC, object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGNGJEPLJNB(Entity OGLHBJLEIOC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FCLPCPEOBMC(Entity OGLHBJLEIOC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AEDBAPKOJIN<TComponentData, TValue> : PEDCMEPGODF<TValue>, IDisposable where TComponentData : struct, NFFCFMODGMN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class JDADGKDLDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> OCAIIBKPIPH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ALDOGAGGHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x312D4F0", Offset = "0x312C8F0", VA = "0x18312D4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B57170", Offset = "0x3B56570", VA = "0x183B57170")]
		public bool FNDNIJHCGFD([Out] TValue PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B570C0", Offset = "0x3B564C0", VA = "0x183B570C0")]
		public void FFIECPFJEFG(object ICNJFMMNIKL, TValue PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B57340", Offset = "0x3B56740", VA = "0x183B57340")]
		public bool PIABDNKCBCD(object ICNJFMMNIKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B57260", Offset = "0x3B56660", VA = "0x183B57260")]
		public int KKPAGALMPAN(object ICNJFMMNIKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B573C0", Offset = "0x3B567C0", VA = "0x183B573C0")]
		public JDADGKDLDCO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<JDADGKDLDCO> NNOKCNNKENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LAFNLADIJMB<EPABGPMFAGJ, JDADGKDLDCO> GMEDLPNACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager CDKDONGNIMC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x381B350", Offset = "0x381A750", VA = "0x18381B350")]
	public AEDBAPKOJIN(EntityManager CDKDONGNIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x381AFD0", Offset = "0x381A3D0", VA = "0x18381AFD0", Slot = "4")]
	public void NBOENKMGNAM(Entity OGLHBJLEIOC, object ICNJFMMNIKL, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x381AE10", Offset = "0x381A210", VA = "0x18381AE10", Slot = "5")]
	public bool LHHGINLDKJA(Entity OGLHBJLEIOC, object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x381AD10", Offset = "0x381A110", VA = "0x18381AD10", Slot = "6")]
	public bool FNDNIJHCGFD(Entity OGLHBJLEIOC, [Out] TValue PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x381ACF0", Offset = "0x381A0F0", VA = "0x18381ACF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x381B1D0", Offset = "0x381A5D0", VA = "0x18381B1D0")]
	private void NPADMANJOOC(JDADGKDLDCO EBMHFNGEPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x381B110", Offset = "0x381A510", VA = "0x18381B110")]
	private bool NOKEJPJNEIC(Entity OGLHBJLEIOC, [Out] EPABGPMFAGJ GBHCPDPGJOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x381B260", Offset = "0x381A660", VA = "0x18381B260")]
	private void OJIAJDGLFPJ(Entity OGLHBJLEIOC, EPABGPMFAGJ GBHCPDPGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x381AFB0", Offset = "0x381A3B0", VA = "0x18381AFB0")]
	private bool MMLHCAJPGCN(EPABGPMFAGJ GBHCPDPGJOO, [Out] JDADGKDLDCO EBMHFNGEPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x381AC00", Offset = "0x381A000", VA = "0x18381AC00")]
	private JDADGKDLDCO BLHPFOBPFBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PEDCMEPGODF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBOENKMGNAM(Entity OGLHBJLEIOC, object ICNJFMMNIKL, TValue PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHHGINLDKJA(Entity OGLHBJLEIOC, object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNDNIJHCGFD(Entity OGLHBJLEIOC, [Out] TValue PCGOHCLJAPN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EPABGPMFAGJ : ODAGFPLBOGN, IEquatable<EPABGPMFAGJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly EPABGPMFAGJ AHGBCMNAJAH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LCMFLKBKPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CMDNCLFDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2291210", Offset = "0x2290610", VA = "0x182291210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5603DA0", Offset = "0x56031A0", VA = "0x185603DA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x627AE00", Offset = "0x627A200", VA = "0x18627AE00", Slot = "8")]
	public bool Equals(EPABGPMFAGJ MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x627AE50", Offset = "0x627A250", VA = "0x18627AE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OJEJFLOHOFI<THasTokensTag> : CICPACLDJKE, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, EPABGPMFAGJ> GAFAOJIPNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> NNOKCNNKENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LAFNLADIJMB<EPABGPMFAGJ, HashSet<object>> GMEDLPNACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager CDKDONGNIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem PEPHHPHKELK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40E02E0", Offset = "0x40DF6E0", VA = "0x1840E02E0")]
	public OJEJFLOHOFI(EntityManager CDKDONGNIMC, EntityCommandBufferSystem PEPHHPHKELK, GFLOJPOFOAD BLILOIEMNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40DF300", Offset = "0x40DE700", VA = "0x1840DF300", Slot = "4")]
	public bool NBOENKMGNAM(Entity OGLHBJLEIOC, object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40DE2C0", Offset = "0x40DD6C0", VA = "0x1840DE2C0", Slot = "5")]
	public bool LHHGINLDKJA(Entity OGLHBJLEIOC, object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40DD900", Offset = "0x40DCD00", VA = "0x1840DD900", Slot = "6")]
	public bool KGNGJEPLJNB(Entity OGLHBJLEIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40DDC50", Offset = "0x40DD050", VA = "0x1840DDC50", Slot = "9")]
	public bool KGNGJEPLJNB(EPABGPMFAGJ GBHCPDPGJOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40DD700", Offset = "0x40DCB00", VA = "0x1840DD700", Slot = "7")]
	public bool FCLPCPEOBMC(Entity OGLHBJLEIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40DD040", Offset = "0x40DC440", VA = "0x1840DD040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40DF9D0", Offset = "0x40DEDD0", VA = "0x1840DF9D0")]
	private void NPADMANJOOC(HashSet<object> EBMHFNGEPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40DF7B0", Offset = "0x40DEBB0", VA = "0x1840DF7B0")]
	private bool NOKEJPJNEIC(Entity OGLHBJLEIOC, [Out] EPABGPMFAGJ GBHCPDPGJOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40DE5B0", Offset = "0x40DD9B0", VA = "0x1840DE5B0")]
	private bool LIJELILFKMH(Entity OGLHBJLEIOC, [Out] EPABGPMFAGJ GBHCPDPGJOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40DE7F0", Offset = "0x40DDBF0", VA = "0x1840DE7F0")]
	private void MIMJGGGMENH(Entity OGLHBJLEIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x40DCE20", Offset = "0x40DC220", VA = "0x1840DCE20")]
	private void CNPGGPBKGPA(Entity OGLHBJLEIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x40DD300", Offset = "0x40DC700", VA = "0x1840DD300")]
	private void FBFGKAKDCFC(Entity OGLHBJLEIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40DFB20", Offset = "0x40DEF20", VA = "0x1840DFB20")]
	private void OJIAJDGLFPJ(Entity OGLHBJLEIOC, EPABGPMFAGJ GBHCPDPGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40DC6B0", Offset = "0x40DBAB0", VA = "0x1840DC6B0")]
	private bool BHMJIKDMHBL(EPABGPMFAGJ GBHCPDPGJOO, [Out] HashSet<object> EBMHFNGEPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40DC910", Offset = "0x40DBD10", VA = "0x1840DC910")]
	private HashSet<object> BLHPFOBPFBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NHDMLDJIFMF
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BOBMJNFMGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int PADMGOMCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int JDBLGKLFJDF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JDFFMJCEGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2291210", Offset = "0x2290610", VA = "0x182291210")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5603DA0", Offset = "0x56031A0", VA = "0x185603DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PHADHANMEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BEFCIIIMLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x627A5D0", Offset = "0x62799D0", VA = "0x18627A5D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x627A5C0", Offset = "0x62799C0", VA = "0x18627A5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
	private BOBMJNFMGAM(int PADMGOMCMCK, int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF18B0", Offset = "0x1DF0CB0", VA = "0x181DF18B0")]
	public static BOBMJNFMGAM CHMFLCFCPBA(int PADMGOMCMCK, int JDBLGKLFJDF)
	{
		return default(BOBMJNFMGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x627A5B0", Offset = "0x62799B0", VA = "0x18627A5B0")]
	public static BOBMJNFMGAM APAJEAJOKBG(int IEPLFGFMPDD, int HLFFIBCGIOB)
	{
		return default(BOBMJNFMGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x627A5E0", Offset = "0x62799E0", VA = "0x18627A5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MEHMNLICHAG : FMFAPFGOBPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x627B200", Offset = "0x627A600", VA = "0x18627B200")]
	public float BJMKHDNPKAP([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x627B200", Offset = "0x627A600", VA = "0x18627B200", Slot = "4")]
	private float PKMAAFNGMCO([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DCFGPOOCHCI : FMFAPFGOBPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x627A9A0", Offset = "0x6279DA0", VA = "0x18627A9A0")]
	public float BJMKHDNPKAP([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x627A9A0", Offset = "0x6279DA0", VA = "0x18627A9A0", Slot = "4")]
	private float PKMAAFNGMCO([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INJOGJMEMAK : FMFAPFGOBPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1ABFBD0", Offset = "0x1ABEFD0", VA = "0x181ABFBD0")]
	public float BJMKHDNPKAP([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1ABFBD0", Offset = "0x1ABEFD0", VA = "0x181ABFBD0", Slot = "4")]
	private float PKMAAFNGMCO([In] float3 PCGOHCLJAPN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PJPBKDGKNFH : FMFAPFGOBPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0")]
	public int BJMKHDNPKAP([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0", Slot = "4")]
	private int ODCCHFNMMIA([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DKNKADCECIB : FMFAPFGOBPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x627A9B0", Offset = "0x6279DB0", VA = "0x18627A9B0")]
	public int BJMKHDNPKAP([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x627A9B0", Offset = "0x6279DB0", VA = "0x18627A9B0", Slot = "4")]
	private int ODCCHFNMMIA([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JIEDMHMDFGC : FMFAPFGOBPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16B15D0", Offset = "0x16B09D0", VA = "0x1816B15D0")]
	public int BJMKHDNPKAP([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16B15D0", Offset = "0x16B09D0", VA = "0x1816B15D0", Slot = "4")]
	private int ODCCHFNMMIA([In] int3 PCGOHCLJAPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OMJMHDGHAAI : MKFINLHOENC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	public OMJMHDGHAAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DNJOBPCHOIK : SystemBase, FKAADAOFAPP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x627A9C0", Offset = "0x6279DC0", VA = "0x18627A9C0")]
	public ComponentDataFromEntity KLKOLFPPGCM(int BMMPAHPPMLC, bool IKPLGDFAGCP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x627AA80", Offset = "0x6279E80", VA = "0x18627AA80")]
	public EntityExistenceLookupByEntity NDHLGCMFEFK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x627AAA0", Offset = "0x6279EA0", VA = "0x18627AAA0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	protected DNJOBPCHOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class AGOLMBGMGHP : DNJOBPCHOIK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x627A580", Offset = "0x6279980", VA = "0x18627A580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	protected AGOLMBGMGHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DKHEGAMLNKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class ICOHGPCCBHP : EntityCommandBufferSystem, FKAADAOFAPP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	protected ICOHGPCCBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FMFAPFGOBPD<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BJMKHDNPKAP([In] TFrom PCGOHCLJAPN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IKPEFOCAFPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJIOCCOEGLC(T PCGOHCLJAPN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct MEBKAGIMNOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes JOCGKEOJDHP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x627B110", Offset = "0x627A510", VA = "0x18627B110", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct CIGLNEMGCIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x627A900", Offset = "0x6279D00", VA = "0x18627A900", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct LKNPGJMKEEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType NGDMBDOKLAL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x627B090", Offset = "0x627A490", VA = "0x18627B090", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct HFNGAIMKIGM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> FLKOGFDGJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x385A6F0", Offset = "0x3859AF0", VA = "0x18385A6F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct GONONJIECFJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> JFCBPFNIMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct MMIDOMEGONE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> AKIMONAAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T PCGOHCLJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer JBMLJAELDPO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F172C0", Offset = "0x3F166C0", VA = "0x183F172C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct CIAOBPCHMMK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FMFAPFGOBPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> JGKFBLFDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap PNAPELFIIEJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct GKKDJMKILMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity ABOJFPNKKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> JGKFBLFDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int ODKLPFCNOHH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x627AF90", Offset = "0x627A390", VA = "0x18627AF90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct KDOLEBHJEKN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DPEJKCENNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> PJFDLLFLOOK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct OPOIKNFOKPN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FMFAPFGOBPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> AOAGDOGKJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> JGKFBLFDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap PNAPELFIIEJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct ILHMFONNGND<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NJJGMAKFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> CJCBBHPCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> BKNDCDKEJBO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BAAAOMBNDAD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NJJGMAKFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> CJCBBHPCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> BKNDCDKEJBO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x47F6C80", Offset = "0x47F6080", VA = "0x1847F6C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct OPHKNBJDHMN<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> PJFDLLFLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> FIOKJMAOKDA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4105010", Offset = "0x4104410", VA = "0x184105010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct DCAONOGLGBF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FMFAPFGOBPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> PJFDLLFLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> FIOKJMAOKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap PNAPELFIIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct PCOHFMLCEGC<T, TPredicate> : IJob where T : struct where TPredicate : struct, IKPEFOCAFPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> IMMPAIHEPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> IOLABCIABKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate PNAPELFIIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4197AB0", Offset = "0x4196EB0", VA = "0x184197AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IKKHILFEIDC<T, TPredicate> : IJob where T : struct where TPredicate : struct, IKPEFOCAFPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> CCADEBLGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> PJFDLLFLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate PNAPELFIIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct EOBOCGNDKJH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity NJJGMAKFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> CJCBBHPCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> AEDKHNKCFKE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x627AD70", Offset = "0x627A170", VA = "0x18627AD70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct PPCNLMGKGGE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity NJJGMAKFPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> CJCBBHPCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> AEDKHNKCFKE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x627B530", Offset = "0x627A930", VA = "0x18627B530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FHFEFPIIJBB
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ECBADDJPEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x267FA30", Offset = "0x267EE30", VA = "0x18267FA30")]
	public static bool CKHMDADJEIB<T>(this NativeArray<Entity> CJCBBHPCMAC, EntityManager CDKDONGNIMC, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FDGBBEBDAIG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JPCFALANIPE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public JPCFALANIPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AKOEBOMMKDI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public AKOEBOMMKDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> IFNLJEMKDAC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x627AF00", Offset = "0x627A300", VA = "0x18627AF00")]
	public FDGBBEBDAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LFPLPPNGMFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LAOPMLPDJBL
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct EOEMBGPODMO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct KBGFLKOGLBB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal EOEMBGPODMO<TFrom> NCGFJMKBOIN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> PPKEPEHJANL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct ENEBAHBNGEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct LKDPOOOMHNN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal ENEBAHBNGEL<TFrom> NCGFJMKBOIN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> PPKEPEHJANL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct FEDCDDCAHHK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct FLBOHLCADFH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal FEDCDDCAHHK<TFrom> NCGFJMKBOIN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> PPKEPEHJANL;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct AOEDMPMPHKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ADKJEGBNAAP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AOEDMPMPHKJ<TFrom> NCGFJMKBOIN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> PPKEPEHJANL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EPCDBNCEPCP
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IBBLMAILONN
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2820E60", Offset = "0x2820260", VA = "0x182820E60")]
	public static NativeList<T> IDFIAOFBKGL<T>(this NativeList<T> ANONMKLGAAK, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2820CE0", Offset = "0x28200E0", VA = "0x182820CE0")]
	public static NativeList<T> IDFIAOFBKGL<T>(this NativeArray<T> ANONMKLGAAK, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JFKNFNMLHDE
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EILBIBGHOJF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2689B30", Offset = "0x2688F30", VA = "0x182689B30")]
	[OPOGCNHNEEL]
	public static JobHandle PHDMMPOFIGA<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArrayAsync<Entity> AKIMONAAPIN, NativeArrayAsync<T> FLKOGFDGJDF, [Optional] JobHandle KPBJPCIODIE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2689DB0", Offset = "0x26891B0", VA = "0x182689DB0")]
	[OPOGCNHNEEL]
	public static JobHandle PHDMMPOFIGA<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArrayAsync<Entity> AKIMONAAPIN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2689C90", Offset = "0x2689090", VA = "0x182689C90")]
	[OPOGCNHNEEL]
	public static JobHandle PHDMMPOFIGA<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArray<Entity> AKIMONAAPIN, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x627AC00", Offset = "0x627A000", VA = "0x18627AC00")]
	[OPOGCNHNEEL]
	public static JobHandle PHDMMPOFIGA(this EntityCommandBufferSystem PEPHHPHKELK, NativeArray<Entity> AKIMONAAPIN, ComponentTypes JOCGKEOJDHP, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x627AAB0", Offset = "0x6279EB0", VA = "0x18627AAB0")]
	[OPOGCNHNEEL]
	public static JobHandle PHDMMPOFIGA(this EntityCommandBufferSystem PEPHHPHKELK, EntityCommandBuffer JBMLJAELDPO, NativeArray<Entity> AKIMONAAPIN, ComponentTypes JOCGKEOJDHP, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FIFBALPKEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27D6160", Offset = "0x27D5560", VA = "0x1827D6160")]
	[OPOGCNHNEEL]
	public static JobHandle PHJMPAPEFDD<T>(this EntityCommandBufferSystem PEPHHPHKELK, EntityCommandBuffer JBMLJAELDPO, EntityQuery GJMMDOFLGHI, T PCGOHCLJAPN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CGGBDGJIDGG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x627A770", Offset = "0x6279B70", VA = "0x18627A770")]
	[OPOGCNHNEEL]
	public static JobHandle CINCDOAAALK(this EntityCommandBufferSystem PEPHHPHKELK, NativeList<Entity> AKIMONAAPIN, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x627A670", Offset = "0x6279A70", VA = "0x18627A670")]
	[OPOGCNHNEEL]
	public static JobHandle CINCDOAAALK(this EntityCommandBufferSystem PEPHHPHKELK, NativeArrayAsync<Entity> AKIMONAAPIN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CIIBAJODOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2620030", Offset = "0x261F430", VA = "0x182620030")]
	public static void KECCJMMPBCE<T>(this EntityCommandBufferSystem PEPHHPHKELK, EntityQuery GJMMDOFLGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2620400", Offset = "0x261F800", VA = "0x182620400")]
	[OPOGCNHNEEL]
	public static JobHandle NPFJMKIFJHI<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeListAsync<Entity> AKIMONAAPIN, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26204C0", Offset = "0x261F8C0", VA = "0x1826204C0")]
	[OPOGCNHNEEL]
	public static JobHandle NPFJMKIFJHI<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArrayAsync<Entity> AKIMONAAPIN, [Optional] JobHandle KPBJPCIODIE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NAJLBDJDOGN
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x290F5C0", Offset = "0x290E9C0", VA = "0x18290F5C0")]
	[OPOGCNHNEEL]
	public static JobHandle GBOHBJPGKCH<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArray<Entity> AKIMONAAPIN, NativeArray<T> FLKOGFDGJDF, JobHandle KPBJPCIODIE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JFGOLDCMKHI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2841B00", Offset = "0x2840F00", VA = "0x182841B00")]
	[OPOGCNHNEEL]
	public static JobHandle BPAKBBEABAA<T>(this EntityCommandBufferSystem PEPHHPHKELK, NativeArray<Entity> AKIMONAAPIN, T PCGOHCLJAPN, [Optional] JobHandle KPBJPCIODIE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2841BE0", Offset = "0x2840FE0", VA = "0x182841BE0")]
	[OPOGCNHNEEL]
	public static JobHandle BPAKBBEABAA<T>(this EntityCommandBufferSystem PEPHHPHKELK, EntityCommandBuffer JBMLJAELDPO, NativeArray<Entity> AKIMONAAPIN, T PCGOHCLJAPN, [Optional] JobHandle KPBJPCIODIE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class IPELICHLNEB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2831230", Offset = "0x2830630", VA = "0x182831230")]
	public static NativeList<T> IDFIAOFBKGL<T>(NativeList<T> ANONMKLGAAK, Allocator ABAEADFKICB) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NACFMFCANOJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x290C5D0", Offset = "0x290B9D0", VA = "0x18290C5D0")]
	public static NativeArray<T> KHAIHDNIJNG<T>(this NativeList<Entity> ANONMKLGAAK, EntityManager CDKDONGNIMC, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x290C090", Offset = "0x290B490", VA = "0x18290C090")]
	public static NativeArray<T> KHAIHDNIJNG<T>(this NativeArray<Entity> ANONMKLGAAK, EntityManager CDKDONGNIMC, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x627B220", Offset = "0x627A620", VA = "0x18627B220")]
	public static NativeArray<Entity> FLNJLJMEOLD(this NativeArray<Entity> ANONMKLGAAK, EntityManager CDKDONGNIMC, ComponentType NGDMBDOKLAL, Allocator ABAEADFKICB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x290C680", Offset = "0x290BA80", VA = "0x18290C680")]
	public static NativeArray<T> NENKIKCPEPG<T>(this NativeArray<Entity> ANONMKLGAAK, EntityManager CDKDONGNIMC, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KKEGDOJGGEH
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct IDIADADOENF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct NMCIKELEKNK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public IDIADADOENF<TFrom> PPKEPEHJANL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct KNBGGJENNHD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct DJKIPEDMEDM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public KNBGGJENNHD<TFrom> PPKEPEHJANL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct PODAIFJMMOP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct IAFILNFICDI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public PODAIFJMMOP<TFrom> PPKEPEHJANL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> CCADEBLGGPC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class EKBEEIKKNCP
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FIKNFNMAMFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct MEICJHPOELE : FMFAPFGOBPD<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> BMKKHJLGEDK;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x627B210", Offset = "0x627A610", VA = "0x18627B210")]
		[BurstCompatible]
		public Entity BJMKHDNPKAP([In] Entity PCGOHCLJAPN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x627B210", Offset = "0x627A610", VA = "0x18627B210", Slot = "4")]
		private Entity JDCAEOMLLHL([In] Entity PCGOHCLJAPN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class NPNECADCKBI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct OKMPDHFJENK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> IMMPAIHEPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct LFDOHAEHNLC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> IMMPAIHEPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct FNMNNEHHOED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> IMMPAIHEPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> CCADEBLGGPC;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24AB970", Offset = "0x24AAD70", VA = "0x1824AB970")]
		public NativeListAsync<Entity> GJIOCCOEGLC<TPredicate>() where TPredicate : struct, IKPEFOCAFPD<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2924D00", Offset = "0x2924100", VA = "0x182924D00")]
	public static FNMNNEHHOED<T> PHOGOCEEILM<T>(this NativeArrayAsync<Entity> CJCBBHPCMAC, NativeArrayAsync<T> ANONMKLGAAK, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct
	{
		return default(FNMNNEHHOED<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class ABGHABAPBMM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8410", Offset = "0x2DA7810", VA = "0x182DA8410")]
	public static NativeListAsync<Entity> OPAJFPNNGGJ<T, TPredicate>(this NativeArrayAsync<T> ANONMKLGAAK, NativeArrayAsync<Entity> CJCBBHPCMAC, Allocator ABAEADFKICB = Allocator.TempJob) where T : struct where TPredicate : struct, IKPEFOCAFPD<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8270", Offset = "0x2DA7670", VA = "0x182DA8270")]
	private static NativeListAsync<Entity> GEKOKDJCGIH<T, TPredicate>(NativeArrayAsync<T> JOGPNOPENGH, NativeArrayAsync<Entity> CJCBBHPCMAC, int POJMEHKIPEF, Allocator ABAEADFKICB) where T : struct where TPredicate : struct, IKPEFOCAFPD<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class ABBBGMPCODC
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct MGJODEECBFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DIDPKDDAKAD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct IGPHMCJCNBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> CCADEBLGGPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct MOONAOODMDE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator ABAEADFKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> CCADEBLGGPC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PJANJCMCBHI
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GJMJCLNCGDG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x27E9F70", Offset = "0x27E9370", VA = "0x1827E9F70")]
	public static NativeList<Entity> EANDIPADAHO<T>(this NativeArray<Entity> CJCBBHPCMAC, EntityManager CDKDONGNIMC, Allocator ABAEADFKICB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LOIDHFDJAHH
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class LKOEBCCNEEO
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct AEHFECCHBHP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> KGECIFKDBHF;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public AEHFECCHBHP(NativeArray<TSrc> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public LBAHPLBBDEP<TSrc, TValue> DMMMIDPHEEP<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LBAHPLBBDEP<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct LBAHPLBBDEP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> KGECIFKDBHF;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public LBAHPLBBDEP(NativeArray<TSrc> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public GFOAJIGKLAF<TSrc, TValue, TSelector> CFBDCHFBIMD<TSelector>() where TSelector : struct, FMFAPFGOBPD<TSrc, TValue>
		{
			return default(GFOAJIGKLAF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct GFOAJIGKLAF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FMFAPFGOBPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> KGECIFKDBHF;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public GFOAJIGKLAF(NativeArray<TSrc> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x37C0850", Offset = "0x37BFC50", VA = "0x1837C0850")]
		public BCDIEEEONAE<TSrc, TValue, TSelector> LKDDFELJGAG()
		{
			return default(BCDIEEEONAE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct ALLMIAHPGPP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FMFAPFGOBPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> KGECIFKDBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector GOONFJMFCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int PMLKPJNGBAD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D640", Offset = "0x3A1CA40", VA = "0x183A1D640")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LCMFLKBKPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA55740", Offset = "0xA54B40", VA = "0x180A55740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GGHIHFENJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D7B0", Offset = "0x3A1CBB0", VA = "0x183A1D7B0")]
		public ALLMIAHPGPP(NativeArray<TSrc> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D630", Offset = "0x3A1CA30", VA = "0x183A1D630")]
		public bool KCCPNMGCBFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D6D0", Offset = "0x3A1CAD0", VA = "0x183A1D6D0")]
		private TSrc NKDIAECKIJJ(int DJKFAHMDLOE)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct BCDIEEEONAE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FMFAPFGOBPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ALLMIAHPGPP<TSrc, TValue, TSelector> IFPJEBNJGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue KNJCOCDNCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int CAIMMNKGOCP;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BOBMJNFMGAM ONEFDOOEOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x47FC3A0", Offset = "0x47FB7A0", VA = "0x1847FC3A0")]
			get
			{
				return default(BOBMJNFMGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue HHKBFMDCBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, BOBMJNFMGAM range) MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x47FC520", Offset = "0x47FB920", VA = "0x1847FC520")]
			get
			{
				return default((TValue, BOBMJNFMGAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x47FC600", Offset = "0x47FBA00", VA = "0x1847FC600")]
		public BCDIEEEONAE(NativeArray<TSrc> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDA20", Offset = "0x3CFCE20", VA = "0x183CFDA20")]
		public BCDIEEEONAE<TSrc, TValue, TSelector> CKFAHJNIOKH()
		{
			return default(BCDIEEEONAE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x47FC3E0", Offset = "0x47FB7E0", VA = "0x1847FC3E0")]
		public bool KCCPNMGCBFN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2891780", Offset = "0x2890B80", VA = "0x182891780")]
	public static AEHFECCHBHP<T> ALBEOAFMOEJ<T>(this NativeList<T> OCAIIBKPIPH) where T : struct
	{
		return default(AEHFECCHBHP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
	public static AEHFECCHBHP<T> ALBEOAFMOEJ<T>(this NativeArray<T> KGECIFKDBHF) where T : struct
	{
		return default(AEHFECCHBHP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LHBIEBMMLBI
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BBPAGNADHIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly KGECIFKDBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int CAIMMNKGOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int AAKEFLEACNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T KNJCOCDNCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T HHPHLGMAOAG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BOBMJNFMGAM ONEFDOOEOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x47FBD30", Offset = "0x47FB130", VA = "0x1847FBD30")]
			get
			{
				return default(BOBMJNFMGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T HHKBFMDCBDA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x33CD910", Offset = "0x33CCD10", VA = "0x1833CD910")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, BOBMJNFMGAM) MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x47FC1E0", Offset = "0x47FB5E0", VA = "0x1847FC1E0")]
			get
			{
				return default((T, BOBMJNFMGAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x47FC320", Offset = "0x47FB720", VA = "0x1847FC320")]
		public BBPAGNADHIP(NativeArray<T> KGECIFKDBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x47FBD40", Offset = "0x47FB140", VA = "0x1847FBD40")]
		public BBPAGNADHIP<T> CKFAHJNIOKH()
		{
			return default(BBPAGNADHIP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x47FBF50", Offset = "0x47FB350", VA = "0x1847FBF50")]
		public bool KCCPNMGCBFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x22E6FF0", Offset = "0x22E63F0", VA = "0x1822E6FF0")]
		public CGKGCNPHEIB<T, TComparer> PJKNKDDFDNH<TComparer>([Optional] TComparer BOFEDGFMDPE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(CGKGCNPHEIB<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CGKGCNPHEIB<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly KGECIFKDBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int CAIMMNKGOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int AAKEFLEACNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T KNJCOCDNCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T HHPHLGMAOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer BOFEDGFMDPE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BOBMJNFMGAM ONEFDOOEOJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x47FBD30", Offset = "0x47FB130", VA = "0x1847FBD30")]
			get
			{
				return default(BOBMJNFMGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T HHKBFMDCBDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x33CD910", Offset = "0x33CCD10", VA = "0x1833CD910")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4AECE40", Offset = "0x4AEC240", VA = "0x184AECE40")]
		public CGKGCNPHEIB(NativeArray<T>.ReadOnly KGECIFKDBHF, TComparer BOFEDGFMDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4AECC60", Offset = "0x4AEC060", VA = "0x184AECC60")]
		public bool KCCPNMGCBFN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x288EE60", Offset = "0x288E260", VA = "0x18288EE60")]
	public static BBPAGNADHIP<T> LKDDFELJGAG<T>(this NativeArray<T> KGECIFKDBHF) where T : struct
	{
		return default(BBPAGNADHIP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface JNADJMGCMDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class ENADDDBCHDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct DJBDLNCOJCF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class INCHIJEJFIA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DJBDLNCOJCF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAE23A0", Offset = "0xAE17A0", VA = "0x180AE23A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x373B4D0", Offset = "0x373A8D0", VA = "0x18373B4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public INCHIJEJFIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x39C3200", Offset = "0x39C2600", VA = "0x1839C3200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x39C33B0", Offset = "0x39C27B0", VA = "0x1839C33B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> CILOKBOCLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream KOJLMFPHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream HMBIONAKDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf IGGFIGLHKAD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int GGHIHFENJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50F5440", Offset = "0x50F4840", VA = "0x1850F5440", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x50F5480", Offset = "0x50F4880", VA = "0x1850F5480", Slot = "4")]
	[IteratorStateMachine(typeof(DJBDLNCOJCF<>.INCHIJEJFIA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50F5570", Offset = "0x50F4970", VA = "0x1850F5570", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PNHCGGMAOIF<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] DPJOGLFAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf IGGFIGLHKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream KOJLMFPHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream GGDNHNHPLLF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x41B97C0", Offset = "0x41B8BC0", VA = "0x1841B97C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct FCNOMDMPFLP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream KOJLMFPHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream HMBIONAKDED;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x627AEC0", Offset = "0x627A2C0", VA = "0x18627AEC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct NPDDFKBBDAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] DPJOGLFAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream KOJLMFPHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream GGDNHNHPLLF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x627B400", Offset = "0x627A800", VA = "0x18627B400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OANHKMHKKDG
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class ABNPBDNMJJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum DDCMCAPHIAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class FJABANHANON
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GGOHFKMAPDD
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GGOHFKMAPDD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
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
