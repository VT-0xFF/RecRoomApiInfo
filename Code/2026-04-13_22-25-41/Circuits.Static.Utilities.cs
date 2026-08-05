using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Circuits.Static.Api;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.Static.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public sealed class KKOTRYTNVPK<a> : THQIDYNYSUZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string YRNJBNRLCIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly a HBLTVDNEEXS;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x679D3E0", Offset = "0x679BDE0", VA = "0x18679D3E0")]
		internal KKOTRYTNVPK(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CYQPGGWZNWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1410", Offset = "0x2BDFE10", VA = "0x182BE1410")]
		public static KKOTRYTNVPK<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x382D590", Offset = "0x382BF90", VA = "0x18382D590")]
		public static KKOTRYTNVPK<TData> New<TData>(string message, [In] TData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class JAAYBNWYRKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BAEF80", Offset = "0x3BAD980", VA = "0x183BAEF80")]
		public static Result<a, LYQWSZGLQZW> CYQPGGWZNWP<a>([In] this Result<a, LYQWSZGLQZW> self, string a)
		{
			return default(Result<a, LYQWSZGLQZW>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class THQIDYNYSUZ : ARGBUOZFZQD, LYQWSZGLQZW, SCULPNIXVDU
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7BB0", Offset = "0x2BA65B0", VA = "0x182BA7BB0")]
		protected THQIDYNYSUZ()
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
