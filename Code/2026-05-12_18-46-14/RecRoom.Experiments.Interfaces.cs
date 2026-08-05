using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Experiments
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface IEXBBMPPMAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum OverrideSettings
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			NoOverride,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			AllOff,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			AllOn
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct AsyncInitDisposer : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private BQUYOYJDJCS initEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private Action callbackToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private bool disposed;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static AsyncInitDisposer NullDisposable;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99745D0", Offset = "0x9972FD0", VA = "0x1899745D0")]
			public AsyncInitDisposer(BQUYOYJDJCS initEvent, Action callbackToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99744C0", Offset = "0x9972EC0", VA = "0x1899744C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		long ESSISKPWEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		long RIOJRFBYUCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		long MCDLKQHOYRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int QTAVECDOEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		long SMHHUQHXOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int YKGZPNQHZXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FLGHAWMJTXG;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AsyncInitDisposer JSVEXLBDYVZ(Action a);
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
