using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OKJDIDDLOOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GJIDBOBEGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HMIABFCAECK> PMHCIMGKMLP();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HMIABFCAECK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string EMOKHLCDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JGNBAPMPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNJEEFEKLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EADGNKKFFFF BNCANMMIIAL(Action<ArraySegment<float>> CGEKFPDGHCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HINMLCDOAKP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EADGNKKFFFF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PDKDAKACLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FDAJMOJKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x209E4E0", Offset = "0x209CCE0", VA = "0x18209E4E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5302BF0", Offset = "0x53013F0", VA = "0x185302BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x652C030", Offset = "0x652A830", VA = "0x18652C030")]
	public EADGNKKFFFF(int LOAADEEPAAD, int PNDDHNKOMFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLEAFOFEGMO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OKJDIDDLOOB IIJBDCEPNBA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GJIDBOBEGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x652BDD0", Offset = "0x652A5D0", VA = "0x18652BDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x652BF40", Offset = "0x652A740", VA = "0x18652BF40")]
	static CLEAFOFEGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x652BE50", Offset = "0x652A650", VA = "0x18652BE50")]
	public static IReadOnlyList<HMIABFCAECK> PMHCIMGKMLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JPPNKPKAENO : OKJDIDDLOOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FFCJDIHEPIA : HMIABFCAECK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class INJBFCPCCJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public INJBFCPCCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x652C520", Offset = "0x652AD20", VA = "0x18652C520")]
			internal void MOONGBOCPGM(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HOAFAECICFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ALAACEIDKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NDDKMKCCMJO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EMOKHLCDPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x652C4B0", Offset = "0x652ACB0", VA = "0x18652C4B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JGNBAPMPMIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90C880", Offset = "0x90B080", VA = "0x18090C880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NNJEEFEKLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC50B90", Offset = "0xC4F390", VA = "0x180C50B90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x652C040", Offset = "0x652A840", VA = "0x18652C040", Slot = "7")]
		public EADGNKKFFFF BNCANMMIIAL(Action<ArraySegment<float>> CGEKFPDGHCG)
		{
			return default(EADGNKKFFFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x652C070", Offset = "0x652A870", VA = "0x18652C070")]
		private EADGNKKFFFF BNCANMMIIAL(int LOAADEEPAAD, int IENOIEJCKFH, int PNDDHNKOMFH, Action<ArraySegment<float>> CGEKFPDGHCG)
		{
			return default(EADGNKKFFFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x652C430", Offset = "0x652AC30", VA = "0x18652C430", Slot = "8")]
		public void HINMLCDOAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x652C4D0", Offset = "0x652ACD0", VA = "0x18652C4D0")]
		public FFCJDIHEPIA(MMDevice HOAFAECICFP, bool POFJCCNFOLI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FFCJDIHEPIA> PDDDLBINMPF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GJIDBOBEGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x652C6A0", Offset = "0x652AEA0", VA = "0x18652C6A0", Slot = "5")]
	public IReadOnlyList<HMIABFCAECK> PMHCIMGKMLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x652C9C0", Offset = "0x652B1C0", VA = "0x18652C9C0")]
	public JPPNKPKAENO()
	{
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
