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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F4AB0", Offset = "0x86F3AB0", VA = "0x1886F4AB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Abstractions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OZHQMQQPZCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface YVUIZETXLKA
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public interface HDFXNTLBSFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(Slot = "0")]
				Task<Result<None, IEconErr?>>? IINJPSJFJIN();
			}

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			HDFXNTLBSFZ? KOMTNGQBNMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<Result<None, IEconErr>> WPKEPIMXPIS(OZHQMQQPZCH a);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<Id32<YERKHERMQNJ?>[]?, IEconErr?>>? LSOXQYKBCXN();

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<Result<None, IEconErr?>>? FTXTTVUREFG(Id32<YERKHERMQNJ>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void OYORZRSZEVR();

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void DIQXCWYDGCE();

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void MDDYMLLWMLL(Id32<YERKHERMQNJ>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void XJJOHFKHSBB();

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			void JEDEQEKJBHY();
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface OUAHOMYBGLY
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			YVUIZETXLKA HDFTYWVRXVF
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task IOIUMOAQASL(IEconErr a);

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task XGVBFLVPEQA(Exception a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface FWXMDHGKJUD : IEconErr
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public interface JZOJGDJFHRH : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			long VYZWFJTHXPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			string FATHSQNQMGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public interface VRDGNHMKTJO
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			long? VYZWFJTHXPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			string FATHSQNQMGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface AIRYOATUOOZ : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			int QWTWYNJUIIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public interface FKRTLNKQVRO
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			int SWPEENSIUFA
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			int QWTWYNJUIIE
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<None, IEconErr>> SSFHBWOYLMF(OUAHOMYBGLY a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<None, JZOJGDJFHRH> SHXKCPUPWVL(VRDGNHMKTJO a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Result<None, AIRYOATUOOZ> VEWIAAFDGXF(FKRTLNKQVRO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class YERKHERMQNJ
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
	public interface KMCWMLWDXHK : IEconErr
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
	public interface PDEPVXBNTJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<IEnumerable<Id32<YERKHERMQNJ>>> TransformAccountsCallback(IEnumerable<Id32<YERKHERMQNJ>> accountIds);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Id32<YERKHERMQNJ?>?>? EANNTILBNZP(TransformAccountsCallback? a);
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
