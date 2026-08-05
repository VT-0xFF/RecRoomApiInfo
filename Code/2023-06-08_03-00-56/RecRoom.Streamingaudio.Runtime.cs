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
public class FFKMBDIPHDO : AIJLBKDIAAF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class BAKJNMAFBAM : FFIJJKCFALP
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OLOPMBCAJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public OLOPMBCAJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1934AF0", Offset = "0x19338F0", VA = "0x181934AF0")]
			internal void NGBBHMEIGJJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice LAIHOMHKKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture BMMHNMAMJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource LNBIFCCAJKC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string EKLOELJJDOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x19344C0", Offset = "0x19332C0", VA = "0x1819344C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FHGOMOMIAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D30A0", Offset = "0x9D1EA0", VA = "0x1809D30A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LNDFFMADPCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x974530", Offset = "0x973330", VA = "0x180974530", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19340F0", Offset = "0x1932EF0", VA = "0x1819340F0", Slot = "7")]
		public LCOBCDDFMIG JNPGENIIPJK(Action<ArraySegment<float>> IIPKIDOCHMK)
		{
			return default(LCOBCDDFMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1934120", Offset = "0x1932F20", VA = "0x181934120")]
		private LCOBCDDFMIG JNPGENIIPJK(int AHIDKOKOLFI, int AOGIMPALJLE, int PJJDOJPDOFI, Action<ArraySegment<float>> IIPKIDOCHMK)
		{
			return default(LCOBCDDFMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1934070", Offset = "0x1932E70", VA = "0x181934070", Slot = "8")]
		public void JCEFOEHGHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x19344E0", Offset = "0x19332E0", VA = "0x1819344E0")]
		public BAKJNMAFBAM(MMDevice LAIHOMHKKJB, bool HFMAMPPFGDA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<BAKJNMAFBAM> KPOFCGBGAOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OEOADKLEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1934530", Offset = "0x1933330", VA = "0x181934530", Slot = "5")]
	public IReadOnlyList<FFIJJKCFALP> PLACDDFOHNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1934810", Offset = "0x1933610", VA = "0x181934810")]
	public FFKMBDIPHDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AIJLBKDIAAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OEOADKLEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FFIJJKCFALP> PLACDDFOHNL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FFIJJKCFALP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string EKLOELJJDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FHGOMOMIAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LNDFFMADPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCOBCDDFMIG JNPGENIIPJK(Action<ArraySegment<float>> IIPKIDOCHMK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCEFOEHGHGC();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LCOBCDDFMIG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CLHFOPOMMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EJGDKAOGKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD1D510", Offset = "0xD1C310", VA = "0x180D1D510")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x19304E0", VA = "0x1819316E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1934AE0", Offset = "0x19338E0", VA = "0x181934AE0")]
	public LCOBCDDFMIG(int AHIDKOKOLFI, int PJJDOJPDOFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FGAGLCLPNGD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static AIJLBKDIAAF LNBJPHPCLDC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool OEOADKLEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1934890", Offset = "0x1933690", VA = "0x181934890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1934A10", Offset = "0x1933810", VA = "0x181934A10")]
	static FGAGLCLPNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1934910", Offset = "0x1933710", VA = "0x181934910")]
	public static IReadOnlyList<FFIJJKCFALP> PLACDDFOHNL()
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
