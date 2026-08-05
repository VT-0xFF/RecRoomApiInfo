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
	public sealed class NWVBVDSZDFS<a> : VZAZYENGSOZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string EZVZMXGFVQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly a JYJRJZUXYDG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71AE990", Offset = "0x71AD390", VA = "0x1871AE990")]
		internal NWVBVDSZDFS(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SSRCXYMDJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BE00C0", Offset = "0x2BDEAC0", VA = "0x182BE00C0")]
		public static NWVBVDSZDFS<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B7C0", Offset = "0x3F0A1C0", VA = "0x183F0B7C0")]
		public static NWVBVDSZDFS<TData> New<TData>(string message, [In] TData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SBQZHAARUXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F029C0", Offset = "0x3F013C0", VA = "0x183F029C0")]
		public static Result<a, RYUTMMKYXMA> SSRCXYMDJEP<a>([In] this Result<a, RYUTMMKYXMA> self, string a)
		{
			return default(Result<a, RYUTMMKYXMA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class VZAZYENGSOZ : JLTZKNUNHPJ, RYUTMMKYXMA, LLLHSATKLGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D10", Offset = "0x2BA5710", VA = "0x182BA6D10")]
		protected VZAZYENGSOZ()
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
