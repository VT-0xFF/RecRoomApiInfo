using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Persistence;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.UGCLocalization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum TranslationState
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Translated,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		AwaitingTranslations,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Untranslated
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct TranslationRequestResult
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool Translated
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xF290A0", Offset = "0xF27CA0", VA = "0x180F290A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7B70", Offset = "0x1DF6770", VA = "0x181DF7B70")]
		public TranslationRequestResult(string text, bool translated)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface XXKKKYKOWUH
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool HENPTTOAGFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NXIKOZYHYCH(LATOEPQNEFS a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SerializeTo(PersistedRoomData roomData);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string ESQCPWQDQVB(string a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TranslationState WDGTFDBZHOC(string a, string b, HADOMKANPWQ c);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MTFVWRDNPVA(string a, HADOMKANPWQ b);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		TranslationRequestResult BYSOIJXHSFC(string a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task OUJSHJOGZNS(SerializeType a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HADOMKANPWQ : IEquatable<HADOMKANPWQ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		long AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string JKJORIMASLC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface LATOEPQNEFS
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		string ZFAJQFDEQXW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool DNVKEIIXCFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool CKDOJOYOEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RefreshLocalizableContent();
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
