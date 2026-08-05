using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore.CoreAudioAPI;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.StreamingAudio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface EJQTUCLNSTV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool BVUHOZMACPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<QXPSYNFESZS> GEDAUYDIKJK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QXPSYNFESZS
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DILKMHQZDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class StreamingAudio
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static EJQTUCLNSTV QMNWPXZLFEW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool BVUHOZMACPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9048860", Offset = "0x9047660", VA = "0x189048860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x90488E0", Offset = "0x90476E0", VA = "0x1890488E0")]
		static StreamingAudio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9048770", Offset = "0x9047570", VA = "0x189048770")]
		public static IReadOnlyList<QXPSYNFESZS> GEDAUYDIKJK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class OIYCQDTDIWT : EJQTUCLNSTV
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BNIKVCYCPMV : QXPSYNFESZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private MMDevice MCXVTVVZIBQ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool DILKMHQZDLJ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xACF2E0", Offset = "0xACE0E0", VA = "0x180ACF2E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x14396A0", Offset = "0x14384A0", VA = "0x1814396A0")]
			public BNIKVCYCPMV(MMDevice a, bool b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private List<BNIKVCYCPMV> BZLELNGRQLO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool BVUHOZMACPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x90483F0", Offset = "0x90471F0", VA = "0x1890483F0", Slot = "5")]
		public IReadOnlyList<QXPSYNFESZS> GEDAUYDIKJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x90486F0", Offset = "0x90474F0", VA = "0x1890486F0")]
		public OIYCQDTDIWT()
		{
		}
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
