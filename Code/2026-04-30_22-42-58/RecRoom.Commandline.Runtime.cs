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
		[Cpp2IlInjected.Address(RVA = "0x96A0860", Offset = "0x969FC60", VA = "0x1896A0860", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JDNYVJTRWLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string VIPRTAACHXR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GOZZOZQYCRF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : JDNYVJTRWLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static List<string> EEALYALJGSU;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string[] VHBANAPEAZV;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static string[] ZKQQCBQWFXR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] TRWZRDGJFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96A06B0", Offset = "0x969FAB0", VA = "0x1896A06B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] LFEWHKVEZEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x96A0220", Offset = "0x969F620", VA = "0x1896A0220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96A06C0", Offset = "0x969FAC0", VA = "0x1896A06C0")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96A0450", Offset = "0x969F850", VA = "0x1896A0450")]
		internal static string[] GVWPNWWAYTZ(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96A0600", Offset = "0x969FA00", VA = "0x1896A0600", Slot = "4")]
		private string OSGIQBNAFCA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96A07B0", Offset = "0x969FBB0", VA = "0x1896A07B0")]
		public static string VIPRTAACHXR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96A0560", Offset = "0x969F960", VA = "0x1896A0560", Slot = "5")]
		private bool JIUQYDJFEAU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96A03B0", Offset = "0x969F7B0", VA = "0x1896A03B0")]
		public static bool GOZZOZQYCRF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
