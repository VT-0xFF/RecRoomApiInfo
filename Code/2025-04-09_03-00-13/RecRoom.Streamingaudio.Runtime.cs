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
public interface NJEGENJJNHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IPHKFFIDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CCPNMNJPHPJ> HJFJPILEJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CCPNMNJPHPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FPBPKFOFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KHHADKJNIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ILPIIODCJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GDPIEBEBFIG FCKLCBDABMP(Action<ArraySegment<float>> ADLKPPBLCIG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEAJBANMDJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GDPIEBEBFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MLLCEHKLLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HOIGCOILFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x792D4B0", Offset = "0x792C8B0", VA = "0x18792D4B0")]
	public GDPIEBEBFIG(int IBKDJCHJMAC, int NNCJGKIKBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCAEMGGDIKM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NJEGENJJNHJ HGPJDADJFCJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IPHKFFIDCON
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8364A70", Offset = "0x8363E70", VA = "0x188364A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8364BD0", Offset = "0x8363FD0", VA = "0x188364BD0")]
	static FCAEMGGDIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8364AE0", Offset = "0x8363EE0", VA = "0x188364AE0")]
	public static IReadOnlyList<CCPNMNJPHPJ> HJFJPILEJOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CBPKFDKCDFK : NJEGENJJNHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GJKOIIBAEPK : CCPNMNJPHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FHNLDGADPPA
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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public FHNLDGADPPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8364CC0", Offset = "0x83640C0", VA = "0x188364CC0")]
			internal void FNIHNDFBGBH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IPOKNDBDIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JKEBDINDKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LPNEIJMFLPJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FPBPKFOFMPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83652B0", Offset = "0x83646B0", VA = "0x1883652B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KHHADKJNIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ILPIIODCJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCE9FD0", Offset = "0xCE93D0", VA = "0x180CE9FD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8364EC0", Offset = "0x83642C0", VA = "0x188364EC0", Slot = "7")]
		public GDPIEBEBFIG FCKLCBDABMP(Action<ArraySegment<float>> ADLKPPBLCIG)
		{
			return default(GDPIEBEBFIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8364EF0", Offset = "0x83642F0", VA = "0x188364EF0")]
		private GDPIEBEBFIG FCKLCBDABMP(int IBKDJCHJMAC, int PHCLGEHHHJI, int NNCJGKIKBID, Action<ArraySegment<float>> ADLKPPBLCIG)
		{
			return default(GDPIEBEBFIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8364E40", Offset = "0x8364240", VA = "0x188364E40", Slot = "8")]
		public void EEAJBANMDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83652D0", Offset = "0x83646D0", VA = "0x1883652D0")]
		public GJKOIIBAEPK(MMDevice IPOKNDBDIIG, bool OCCMLJOCECM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GJKOIIBAEPK> IGPCJHPIJFP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IPHKFFIDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83646C0", Offset = "0x8363AC0", VA = "0x1883646C0", Slot = "5")]
	public IReadOnlyList<CCPNMNJPHPJ> HJFJPILEJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83649E0", Offset = "0x8363DE0", VA = "0x1883649E0")]
	public CBPKFDKCDFK()
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
