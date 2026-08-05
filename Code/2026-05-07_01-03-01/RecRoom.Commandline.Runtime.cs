using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x973EB50", Offset = "0x973D550", VA = "0x18973EB50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BELZMPDOLVH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DNFHDTRWKQJ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TNQTGAREMJT(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : BELZMPDOLVH
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static List<string> NPJLFPFMIHM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string[] CBKNNMEFYPH;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static string[] WOLPEYATWTX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] OCPSUWHTEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x973EB40", Offset = "0x973D540", VA = "0x18973EB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] MJQTHHVQBFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x973E7F0", Offset = "0x973D1F0", VA = "0x18973E7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x973E650", Offset = "0x973D050", VA = "0x18973E650")]
		[ONTQUCAGRJW.Root]
		internal static void BREYGLPBXMV(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x973E990", Offset = "0x973D390", VA = "0x18973E990")]
		internal static string[] SNYAQTBAFAF(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x973E5A0", Offset = "0x973CFA0", VA = "0x18973E5A0", Slot = "4")]
		private string BRAYNQXQMIS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x973E740", Offset = "0x973D140", VA = "0x18973E740")]
		public static string DNFHDTRWKQJ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x973E500", Offset = "0x973CF00", VA = "0x18973E500", Slot = "5")]
		private bool ABABAWCSHPU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x973EAA0", Offset = "0x973D4A0", VA = "0x18973EAA0")]
		public static bool TNQTGAREMJT(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public CommandLineManager()
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
