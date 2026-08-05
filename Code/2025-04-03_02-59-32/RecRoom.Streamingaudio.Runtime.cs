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
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HOIGCOILFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2CBED00", Offset = "0x2CBE100", VA = "0x182CBED00")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1DE0", Offset = "0x6AE11E0", VA = "0x186AE1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x78DEF00", Offset = "0x78DE300", VA = "0x1878DEF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x831A480", Offset = "0x8319880", VA = "0x18831A480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x831A5F0", Offset = "0x83199F0", VA = "0x18831A5F0")]
	static FCAEMGGDIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x831A500", Offset = "0x8319900", VA = "0x18831A500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public FHNLDGADPPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x831A6E0", Offset = "0x8319AE0", VA = "0x18831A6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x831ACD0", Offset = "0x831A0D0", VA = "0x18831ACD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KHHADKJNIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9FECE0", Offset = "0x9FE0E0", VA = "0x1809FECE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ILPIIODCJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCE4E00", Offset = "0xCE4200", VA = "0x180CE4E00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x831A8E0", Offset = "0x8319CE0", VA = "0x18831A8E0", Slot = "7")]
		public GDPIEBEBFIG FCKLCBDABMP(Action<ArraySegment<float>> ADLKPPBLCIG)
		{
			return default(GDPIEBEBFIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x831A910", Offset = "0x8319D10", VA = "0x18831A910")]
		private GDPIEBEBFIG FCKLCBDABMP(int IBKDJCHJMAC, int PHCLGEHHHJI, int NNCJGKIKBID, Action<ArraySegment<float>> ADLKPPBLCIG)
		{
			return default(GDPIEBEBFIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x831A860", Offset = "0x8319C60", VA = "0x18831A860", Slot = "8")]
		public void EEAJBANMDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x831ACF0", Offset = "0x831A0F0", VA = "0x18831ACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x831A0D0", Offset = "0x83194D0", VA = "0x18831A0D0", Slot = "5")]
	public IReadOnlyList<CCPNMNJPHPJ> HJFJPILEJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x831A3F0", Offset = "0x83197F0", VA = "0x18831A3F0")]
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
