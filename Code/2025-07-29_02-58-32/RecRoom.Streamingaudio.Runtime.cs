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
public interface HFPOLMMPKGI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OCFFLBJOIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OKNHBOLOPLJ> FFMHAEMFANF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKNHBOLOPLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JNDJPBHHCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PPFEAFMHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKLMEIBJOJH ENIJLDJJAFN(Action<ArraySegment<float>> EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEPCOBOCPDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BKLMEIBJOJH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BDOPCHFPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IEGHIJMFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8367110", Offset = "0x8365B10", VA = "0x188367110")]
	public BKLMEIBJOJH(int OBDDMOILNLM, int FFFBBGDMCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJLENDLLNBP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HFPOLMMPKGI JLDIOICDEHI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OCFFLBJOIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E78FB0", Offset = "0x8E779B0", VA = "0x188E78FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8E79120", Offset = "0x8E77B20", VA = "0x188E79120")]
	static OJLENDLLNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8E79030", Offset = "0x8E77A30", VA = "0x188E79030")]
	public static IReadOnlyList<OKNHBOLOPLJ> FFMHAEMFANF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FDIPLPCEBDC : HFPOLMMPKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HNHKBBPJNAP : OKNHBOLOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GMMPLGAJBME
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
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public GMMPLGAJBME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E78950", Offset = "0x8E77350", VA = "0x188E78950")]
			internal void DMGBDGHLMBH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OPKHABBLBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JLGDAKLCOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource OINJGAIGJKC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BMEFPAKGMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8E78AD0", Offset = "0x8E774D0", VA = "0x188E78AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JNDJPBHHCCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PPFEAFMHHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEF5100", Offset = "0xEF3B00", VA = "0x180EF5100", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E78EB0", Offset = "0x8E778B0", VA = "0x188E78EB0", Slot = "7")]
		public BKLMEIBJOJH ENIJLDJJAFN(Action<ArraySegment<float>> EMBEDGKMMHB)
		{
			return default(BKLMEIBJOJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E78AF0", Offset = "0x8E774F0", VA = "0x188E78AF0")]
		private BKLMEIBJOJH ENIJLDJJAFN(int OBDDMOILNLM, int OLGFIMINEKJ, int FFFBBGDMCAA, Action<ArraySegment<float>> EMBEDGKMMHB)
		{
			return default(BKLMEIBJOJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E78EE0", Offset = "0x8E778E0", VA = "0x188E78EE0", Slot = "8")]
		public void HEPCOBOCPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E78F60", Offset = "0x8E77960", VA = "0x188E78F60")]
		public HNHKBBPJNAP(MMDevice OPKHABBLBLM, bool LDGODEHFCKD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HNHKBBPJNAP> BDMHDDFCGMH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OCFFLBJOIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8E785B0", Offset = "0x8E76FB0", VA = "0x188E785B0", Slot = "5")]
	public IReadOnlyList<OKNHBOLOPLJ> FFMHAEMFANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8E788C0", Offset = "0x8E772C0", VA = "0x188E788C0")]
	public FDIPLPCEBDC()
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
