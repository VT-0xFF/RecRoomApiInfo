using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HAIIDENMEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KNOFHMGDNMF BHAGNEJHEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KNOFHMGDNMF BGKHPJDCIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KNOFHMGDNMF IDMANOKIDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BLIFIEECGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BNBILNPPKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MFENADOJIIE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MHPFPCBFNCA.INHNCHELJFB BJCNPCBBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KPIOJDCNIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIOLDOHFLIE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GAGNNKNPBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFENADOJIIE CMEGCIMJBLO(MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFENADOJIIE JFDDMFGADNM(float AMBGGNMBPEC, MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC = MHPFPCBFNCA.INHNCHELJFB.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFENADOJIIE CDFBLDKOEFE(Func<bool> FOPIJABADPP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KMEALFGBPPA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BNBILNPPKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBEACJDEKDN Run(IEnumerator<MFENADOJIIE> CAOCBDKDKNO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBEACJDEKDN Run(Behaviour EEECBNNPKOA, IEnumerator<MFENADOJIIE> CAOCBDKDKNO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LBEACJDEKDN : BBPJLDGJKMK, BKMNEANDFIL, IEnumerator, MFENADOJIIE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BONBGPCGLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LGJPEAJFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float JADBKCNPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double NLLPMDIPBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MHPFPCBFNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[GMEBGHBGJCJ]
	public enum INHNCHELJFB
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KBOCFABBNGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BKMNEANDFIL promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public KBOCFABBNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x46C5AD0", Offset = "0x46C4AD0", VA = "0x1846C5AD0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static GAGNNKNPBJL JEOGKLLNPMO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<GAGNNKNPBJL> NDLLBDLAOFD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BONBGPCGLJB DIHAGAIACKH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<BONBGPCGLJB> GINFPENFPGK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static GAGNNKNPBJL CJAGPODBLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x46C60E0", Offset = "0x46C50E0", VA = "0x1846C60E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BONBGPCGLJB JMLEOGNDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x46C67C0", Offset = "0x46C57C0", VA = "0x1846C67C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MFENADOJIIE CMEGCIMJBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46C6B00", Offset = "0x46C5B00", VA = "0x1846C6B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x46C6A90", Offset = "0x46C5A90", VA = "0x1846C6A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MFENADOJIIE ODKJEOHEDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46C5D80", Offset = "0x46C4D80", VA = "0x1846C5D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x46C6070", Offset = "0x46C5070", VA = "0x1846C6070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MFENADOJIIE BENDHEHBJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x46C6BD0", Offset = "0x46C5BD0", VA = "0x1846C6BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x46C6C30", Offset = "0x46C5C30", VA = "0x1846C6C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MFENADOJIIE GCOFHOCGKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x46C5E50", Offset = "0x46C4E50", VA = "0x1846C5E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x46C5DE0", Offset = "0x46C4DE0", VA = "0x1846C5DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MFENADOJIIE KCHHAEECDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46C6A30", Offset = "0x46C5A30", VA = "0x1846C6A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x46C6B60", Offset = "0x46C5B60", VA = "0x1846C6B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x46C6820", Offset = "0x46C5820", VA = "0x1846C6820")]
	public static void GGFGJKCIPGJ(GAGNNKNPBJL DIDGNCOHCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46C68C0", Offset = "0x46C58C0", VA = "0x1846C68C0")]
	public static void HCBEINPLAJO(BONBGPCGLJB BEPHPJMOPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46C6140", Offset = "0x46C5140", VA = "0x1846C6140")]
	private static void GBIOCACANIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x46C6960", Offset = "0x46C5960", VA = "0x1846C6960")]
	public static MFENADOJIIE JFDDMFGADNM(float AMBGGNMBPEC, INHNCHELJFB JLLGINJLFDC = INHNCHELJFB.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46C5B80", Offset = "0x46C4B80", VA = "0x1846C5B80")]
	public static MFENADOJIIE AOCCBFGBKCP(float AMBGGNMBPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x46C5C50", Offset = "0x46C4C50", VA = "0x1846C5C50")]
	public static MFENADOJIIE CDFBLDKOEFE(Func<bool> FOPIJABADPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x46C5EB0", Offset = "0x46C4EB0", VA = "0x1846C5EB0")]
	public static MFENADOJIIE DJOHAONKNKD(BKMNEANDFIL HGCBPPKJKJF)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
