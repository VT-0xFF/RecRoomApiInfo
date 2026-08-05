using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Econ.Abstractions.Error;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x998A2F0", Offset = "0x9988CF0", VA = "0x18998A2F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Abstractions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface UFUEMQJPXNZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface TFNRVJLUJPG
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public interface CXDFELBHXOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(Slot = "0")]
				Task<Result<None, IEconErr>> ORRPHYNOGHT();
			}

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			CXDFELBHXOD? AAZBDPRLARW
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<Result<None, IEconErr>> RHSBDUUHFZI(UFUEMQJPXNZ a);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<Id32<JWFGPUOPQZR>[], IEconErr>> NDFUUPVOUJR();

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<Result<int, IEconErr>> SBBMNRVJLJM(Id32<JWFGPUOPQZR>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task HVEQWPEJFTS();

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SGHJHWNDVWO(Id32<JWFGPUOPQZR>[] recipients, int a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void HEPWJDKKXQX();

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void AEEZARCFOLC();

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			void ZKYCMRXVHUF(Id32<JWFGPUOPQZR>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "9")]
			void HKBSZWMQMWX();

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void DXSBUXMRLPI();
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface EANSFVNHRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			TFNRVJLUJPG ROSJBLQEFJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task NAFRAQJMAIH(IEconErr a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task JHOXXBQAJPG(Exception a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface AKTTBKQEWLB : IEconErr
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public interface QSGSBVQHSCZ : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			long TMZUIMRTDKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			string GMNRYCHQQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public interface LLWLMRNCKFS
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			long? TMZUIMRTDKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			string GMNRYCHQQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface QGNPINGTBHT : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			int DBEGWCPOEVK
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public interface JHSVYHMCAGY
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			int CKTBAALVUEK
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			int DBEGWCPOEVK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<None, IEconErr>> OMJSPHHADWZ(EANSFVNHRVQ a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<None, QSGSBVQHSCZ> VKJTYRCNGCR(LLWLMRNCKFS a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Result<None, QGNPINGTBHT> JXRQLNZFOJJ(JHSVYHMCAGY a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class JWFGPUOPQZR
	{
	}
}
namespace RecRoom.Econ.Abstractions.Error
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IEconErr
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface XEXDUGQXSUE : IEconErr
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
namespace RecRoom.Econ.Abstractions.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface TWFNPQKGMUR
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<IEnumerable<Id32<JWFGPUOPQZR>>> TransformAccountsCallback(IEnumerable<Id32<JWFGPUOPQZR>> accountIds);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Id32<JWFGPUOPQZR?>?>? MBYVXEUGRHT(TransformAccountsCallback? a);
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
