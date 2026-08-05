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
		[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x729AB50", Offset = "0x7299550", VA = "0x18729AB50")]
		internal NWVBVDSZDFS(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SSRCXYMDJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCB10", Offset = "0x2BFB510", VA = "0x182BFCB10")]
		public static NWVBVDSZDFS<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F296F0", Offset = "0x3F280F0", VA = "0x183F296F0")]
		public static NWVBVDSZDFS<TData> New<TData>(string message, [In] TData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SBQZHAARUXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F20930", Offset = "0x3F1F330", VA = "0x183F20930")]
		public static Result<a, RYUTMMKYXMA> SSRCXYMDJEP<a>([In] this Result<a, RYUTMMKYXMA> self, string a)
		{
			return default(Result<a, RYUTMMKYXMA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class VZAZYENGSOZ : JLTZKNUNHPJ, RYUTMMKYXMA, LLLHSATKLGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5700", Offset = "0x2BC4100", VA = "0x182BC5700")]
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
