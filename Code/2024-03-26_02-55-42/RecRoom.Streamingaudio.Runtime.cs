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
public interface KMDJKJNPGBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GELHGAMLHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MIHIMJHLKGA> OGDGJGHCCGA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIHIMJHLKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BJPOHEIDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BCDOGEGAMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GBLHAICFOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EECNFCFNNJH LNCEFMDDJNN(Action<ArraySegment<float>> KCNCNEMPBGA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBMFPIKNNAG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EECNFCFNNJH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DMKILKKOCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BPAAKIEMFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2291210", Offset = "0x2290610", VA = "0x182291210")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5603DA0", Offset = "0x56031A0", VA = "0x185603DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FD60", Offset = "0x6A5F160", VA = "0x186A5FD60")]
	public EECNFCFNNJH(int EBCGJEBBBNN, int JDDLANKBIAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OMPJGLMJEJO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KMDJKJNPGBC PJJNPBAHBCM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GELHGAMLHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A60780", Offset = "0x6A5FB80", VA = "0x186A60780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A608F0", Offset = "0x6A5FCF0", VA = "0x186A608F0")]
	static OMPJGLMJEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A60800", Offset = "0x6A5FC00", VA = "0x186A60800")]
	public static IReadOnlyList<MIHIMJHLKGA> OGDGJGHCCGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJMCANFELGH : KMDJKJNPGBC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OMGKGELBPEI : MIHIMJHLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KCNOKLCPDIG
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public KCNOKLCPDIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A5FD70", Offset = "0x6A5F170", VA = "0x186A5FD70")]
			internal void CBOAMHAMKDC(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FEJHKKFOIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EDECEGKHHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JNGDLCCMAFB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BJPOHEIDEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A602A0", Offset = "0x6A5F6A0", VA = "0x186A602A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BCDOGEGAMMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x900930", Offset = "0x8FFD30", VA = "0x180900930", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F4100", Offset = "0x9F3500", VA = "0x1809F4100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GBLHAICFOPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD06BB0", Offset = "0xD05FB0", VA = "0x180D06BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A60700", Offset = "0x6A5FB00", VA = "0x186A60700", Slot = "7")]
		public EECNFCFNNJH LNCEFMDDJNN(Action<ArraySegment<float>> KCNCNEMPBGA)
		{
			return default(EECNFCFNNJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A60340", Offset = "0x6A5F740", VA = "0x186A60340")]
		private EECNFCFNNJH LNCEFMDDJNN(int EBCGJEBBBNN, int JOGIMJICNAJ, int JDDLANKBIAO, Action<ArraySegment<float>> KCNCNEMPBGA)
		{
			return default(EECNFCFNNJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A602C0", Offset = "0x6A5F6C0", VA = "0x186A602C0", Slot = "8")]
		public void JBMFPIKNNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A60730", Offset = "0x6A5FB30", VA = "0x186A60730")]
		public OMGKGELBPEI(MMDevice FEJHKKFOIJM, bool PKOEGJIPGEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OMGKGELBPEI> OENLANDLGKN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GELHGAMLHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FEF0", Offset = "0x6A5F2F0", VA = "0x186A5FEF0", Slot = "5")]
	public IReadOnlyList<MIHIMJHLKGA> OGDGJGHCCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A60210", Offset = "0x6A5F610", VA = "0x186A60210")]
	public KJMCANFELGH()
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
