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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82194A0", Offset = "0x8217CA0", VA = "0x1882194A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Abstractions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface TXBTDIHUSAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface DNUWZYCDYAK
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public interface BGGWRZIFKTH
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(Slot = "0")]
				Task<Result<None, IEconErr>> CSIXHVFYIZN();
			}

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			BGGWRZIFKTH? SWJLYEKORGW
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<Result<None, IEconErr>> CUEQYILFGMY(TXBTDIHUSAN a);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<Id32<SVCRCREPZQZ>[], IEconErr>> FVUEQBBBJQR();

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<Result<int, IEconErr>> IRQQNUXWBII(Id32<SVCRCREPZQZ>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task VVJJICNOCCG();

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void JOZDNEOWGWY(Id32<SVCRCREPZQZ>[] recipients, int a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void DVIAFDIIRCZ();

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void JRCUMEPEEXM();

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			void DAJIHDZZXHV(Id32<SVCRCREPZQZ>[] recipients);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "9")]
			void SHDTPVWXSQV();

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void CYYVCEAWYXW();
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface RUSAYPJEAJC
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			DNUWZYCDYAK UAYNKTXEBOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task XPNMFRVUFAV(IEconErr a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task VDLPPNIDCWS(Exception a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface NINSPFSYTVT : IEconErr
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public interface QLPFMQVEXBR : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			long OTGCPYMMESD
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			string MRCGZKXYOYR
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public interface OLHWPWJZGVM
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			long? OTGCPYMMESD
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			string MRCGZKXYOYR
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface BENYULPBRQL : IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			int NIUOIUZCUZI
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public interface GRUWGTEPIVU
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			int RCYLDCJPICU
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			int NIUOIUZCUZI
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<None, IEconErr>> BQMOPGRREUX(RUSAYPJEAJC a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Result<None, QLPFMQVEXBR> HYNHMUGSIPZ(OLHWPWJZGVM a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Result<None, BENYULPBRQL> IZSJXZDQVHL(GRUWGTEPIVU a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class SVCRCREPZQZ
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
	public interface TFGSXZLXWSO : IEconErr
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
	public interface ADTMPQZISTZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<IEnumerable<Id32<SVCRCREPZQZ>>> TransformAccountsCallback(IEnumerable<Id32<SVCRCREPZQZ>> accountIds);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Id32<SVCRCREPZQZ?>?>? TFHABAUJTUX(TransformAccountsCallback? a);
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
