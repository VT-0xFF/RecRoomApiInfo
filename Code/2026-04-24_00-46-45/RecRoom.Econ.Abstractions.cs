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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9991970", Offset = "0x9990370", VA = "0x189991970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Abstractions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HISZZVQGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface QVXRFTJOQZN
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public interface XTYRHSMZSOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(Slot = "0")]
				Task<Result<None, IEconErr>> HJUUVAYLVQG();
			}

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			XTYRHSMZSOY? ECRQXMUAXRP
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<Result<None, IEconErr>> NFVTBHLQEIN(HISZZVQGJKE a);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<Id32<CUVJWRUHOMA>[], IEconErr>> MQSLMPJBNRC();

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<Result<int, IEconErr>> XULCUKSCAIR(Id32<CUVJWRUHOMA>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task QIJYXIQWWNF();

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SPIAPACAYHJ(Id32<CUVJWRUHOMA>[] recipients, int a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void OYBVVMGLYRE();

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void NDGXEUAFUAH();

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			void CLPDFKMQVWI(Id32<CUVJWRUHOMA>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "9")]
			void IABDVQMPDIY();

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void FTMHERYKFZT();
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface ROCBIEZSTML
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			QVXRFTJOQZN JJCEHKRCQVA
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task TBKELBWLQUK(IEconErr a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task QCHHNXLXHAJ(Exception a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface OPNIXIOQQHQ : IEconErr
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public interface OCIAOLNYTKI : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			long XZWBCTJMDRA
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			string JJKHXTDEGKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public interface GYAFTWHHHFV
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			long? XZWBCTJMDRA
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			string JJKHXTDEGKM
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface RENYEWGTBWC : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			int NOJNKLEVJMT
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public interface YCXVQQDPUOZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			int CYREHHSWVBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			int NOJNKLEVJMT
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<None, IEconErr>> KZAKBOHGOQC(ROCBIEZSTML a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<None, OCIAOLNYTKI> BVAYBGYIUKU(GYAFTWHHHFV a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Result<None, RENYEWGTBWC> MKFPHJZSDZC(YCXVQQDPUOZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class CUVJWRUHOMA
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
	public interface ZMQYRPQFHVP : IEconErr
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
	public interface OQALBWHHZEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<IEnumerable<Id32<CUVJWRUHOMA>>> TransformAccountsCallback(IEnumerable<Id32<CUVJWRUHOMA>> accountIds);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Id32<CUVJWRUHOMA?>?>? CVPFNDXRLUY(TransformAccountsCallback? a);
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
