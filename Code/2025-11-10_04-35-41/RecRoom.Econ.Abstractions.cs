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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x825BC20", Offset = "0x825B020", VA = "0x18825BC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Abstractions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NNOMCHXTAKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface KQXFSXBNNFZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public interface IXMSSERPNWM
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(Slot = "0")]
				Task<Result<None, IEconErr?>>? UNKPQRWMEVQ();
			}

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			IXMSSERPNWM? CJGJZTINBLL
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<Result<None, IEconErr>> WNFSZJCPHVX(NNOMCHXTAKA a);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<Id32<SGVLTZUNAZG?>[]?, IEconErr?>>? XEVXRHFSOWE();

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<Result<None, IEconErr?>>? MCDMZRLOOPV(Id32<SGVLTZUNAZG>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void EIFWHQOEMIG();

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void FTPNDMDMSLZ();

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void HJMHBBAASXK(Id32<SGVLTZUNAZG>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void CNQZXJLDMFC();

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			void UVHDDEOUFWB();
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface QBHLKMRSRDN
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			KQXFSXBNNFZ KMGLFOLZSVQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task LFGDPDDLURI(IEconErr a);

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task NOQFVRUWWWZ(Exception a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface IEZWSIOITXU : IEconErr
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public interface WEKSCLVOEMQ : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			long GKYCXTPBYJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			string QAOCDSUPDRK
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public interface XWXCJATNQFR
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			long? GKYCXTPBYJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			string QAOCDSUPDRK
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface ROYNRBJIXNM : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			int BERUVASDTML
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public interface NDTLJUEKFYZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			int HJLCWSAOHZB
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			int BERUVASDTML
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<None, IEconErr>> MANVMGVSPGS(QBHLKMRSRDN a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<None, WEKSCLVOEMQ> RASTFOYBHIE(XWXCJATNQFR a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Result<None, ROYNRBJIXNM> FHLWPDOJHQE(NDTLJUEKFYZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class SGVLTZUNAZG
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
	public interface WAMGIROGEGJ : IEconErr
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
namespace RecRoom.Econ.Abstractions.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface FGXNVCSWHQA
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<IEnumerable<Id32<SGVLTZUNAZG>>> TransformAccountsCallback(IEnumerable<Id32<SGVLTZUNAZG>> accountIds);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Id32<SGVLTZUNAZG?>?>? CBQARCPPQLO(TransformAccountsCallback? a);
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
